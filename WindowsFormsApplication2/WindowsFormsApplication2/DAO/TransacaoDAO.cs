using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication2
{
    class TransacaoDAO
    {
        public void Editar(Transacao t,Dictionary<int,ProdutoTransacao> dictAnterior)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE transacao SET data='{0}', valor={1}, compra={2} WHERE id={3};",t.Data.ToString("yyyy-MM-dd"),t.Valor.ToString(System.Globalization.CultureInfo.InvariantCulture),Convert.ToInt32(t.Compra),t.Id);
            qry = string.Concat(qry, string.Format("DELETE FROM transacao_produto WHERE idcompra = {0}; ", t.Id));

            ProdutoDAO pd = new ProdutoDAO();

            if (t.Compra)
            {
                foreach (ProdutoTransacao pt in t.Lista)
                {
                    if (dictAnterior.ContainsKey(pt.Prod.Id))
                    {
                        pt.Prod.Quantidade = pt.Prod.Quantidade + pt.Quantidade - dictAnterior[pt.Prod.Id].Quantidade;
                    }
                    else
                    {
                        pt.Prod.Quantidade += pt.Quantidade;
                    }

                    if (pt.Quantidade != 0)
                    {
                        qry = string.Concat(qry, string.Format("INSERT INTO transacao_produto(idcompra,idproduto,quantidade) VALUES ({0},{1},{2});", t.Id, pt.Prod.Id, pt.Quantidade.ToString(System.Globalization.CultureInfo.InvariantCulture)));
                    }
                    pd.Editar(pt.Prod);
                }
            }
            else
            {
                foreach (ProdutoTransacao pv in t.Lista)
                {
                    if (dictAnterior.ContainsKey(pv.Prod.Id))
                    {
                        pv.Prod.Quantidade = pv.Prod.Quantidade + dictAnterior[pv.Prod.Id].Quantidade - pv.Quantidade;
                    }
                    else
                    {
                        pv.Prod.Quantidade -= pv.Quantidade;
                    }
                    qry = string.Concat(qry, string.Format("INSERT INTO transacao_produto(idcompra,idproduto,quantidade) VALUES ({0},{1},{2});", t.Id, pv.Prod.Id, pv.Quantidade.ToString(System.Globalization.CultureInfo.InvariantCulture)));
                    pd.Editar(pv.Prod);
                }
            }

            db.ExecuteNonQuery(qry);
        }

        public List<Transacao> Listar()
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM transacao GROUP BY id");
            DataSet ds = db.ExecuteQuery(qry);

            List<Transacao> LCompraEVenda = new List<Transacao>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Transacao cv = new Transacao();
                cv.Id = int.Parse(dr["id"].ToString());
                string data = dr["data"].ToString();
                cv.Data = Convert.ToDateTime(data);
                cv.Compra = Convert.ToBoolean(int.Parse(dr["compra"].ToString()));
                cv.Valor = double.Parse(dr["valor"].ToString());
                cv.Lista = ListarProd(cv.Id);
                LCompraEVenda.Add(cv);
            }

            return LCompraEVenda;
        }

        public List<ProdutoTransacao> ListarProd(int id)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM transacao_produto WHERE idcompra={0}", id);
            DataSet ds = db.ExecuteQuery(qry);

            List<ProdutoTransacao> Lprod = new List<ProdutoTransacao>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ProdutoTransacao pv = new ProdutoTransacao();
                ProdutoDAO dbprod = new ProdutoDAO();
                pv.Prod = dbprod.Read(int.Parse(dr["idproduto"].ToString()));
                pv.Quantidade = double.Parse(dr["quantidade"].ToString());
                Lprod.Add(pv);
            }
            return Lprod;
        }

        public Transacao Read(int id)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM transacao WHERE id = {0}", id);
            DataSet ds = db.ExecuteQuery(qry);

            Transacao cv = new Transacao();

            if (ds.Tables[0].Rows.Count != 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                cv.Id = int.Parse(dr["id"].ToString());
                string data = dr["data"].ToString();
                cv.Valor = double.Parse(dr["valor"].ToString());
                cv.Data = Convert.ToDateTime(data);
                cv.Compra = Convert.ToBoolean(int.Parse(dr["compra"].ToString()));
                cv.Lista = ListarProd(cv.Id);
                return cv;
            }
            else
            {
                return null;
            }
        }

        public void Remover(int id)
        {
            Database db = Database.GetInstance();
            Transacao t = Read(id);

            ProdutoDAO dbp = new ProdutoDAO();

            if (t.Compra)
            {
                foreach (ProdutoTransacao pt in t.Lista)
                {
                    pt.Prod.Quantidade -= pt.Quantidade;
                    dbp.Editar(pt.Prod);
                }
            }
            else
            {
                foreach (ProdutoTransacao pt in t.Lista)
                {
                    pt.Prod.Quantidade += pt.Quantidade;
                    dbp.Editar(pt.Prod);
                }
            }


            string qry = string.Format("DELETE FROM transacao WHERE id = {0}; DELETE FROM transacao_produto WHERE idcompra = {0}", id);
            db.ExecuteNonQuery(qry);
        }

        public void Salvar(Transacao cv)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("INSERT INTO transacao(data,valor,compra) VALUES ('{0}',{1},{2});", cv.Data.ToString("yyyy-MM-dd"), cv.Valor.ToString(System.Globalization.CultureInfo.InvariantCulture), Convert.ToInt32(cv.Compra));
            db.ExecuteNonQuery(qry);
            int ultimoid = UltimoId();
            qry = "";

            ProdutoDAO pd = new ProdutoDAO();

            if (cv.Compra)
            {
                foreach (ProdutoTransacao pv in cv.Lista)
                {
                    pv.Prod.Quantidade += pv.Quantidade;
                    qry = string.Concat(qry, string.Format("INSERT INTO transacao_produto(idcompra,idproduto,quantidade) VALUES ({0},{1},{2});", ultimoid, pv.Prod.Id, pv.Quantidade.ToString(System.Globalization.CultureInfo.InvariantCulture)));
                    pd.Editar(pv.Prod);
                }
            }
            else
            {
                foreach (ProdutoTransacao pv in cv.Lista)
                {
                    pv.Prod.Quantidade -= pv.Quantidade;
                    qry = string.Concat(qry, string.Format("INSERT INTO transacao_produto(idcompra,idproduto,quantidade) VALUES ({0},{1},{2});", ultimoid, pv.Prod.Id, pv.Quantidade.ToString(System.Globalization.CultureInfo.InvariantCulture)));
                    pd.Editar(pv.Prod);
                }
            }

            db.ExecuteNonQuery(qry);
        }

        public int UltimoId()
        {
            Database db = Database.GetInstance();

            string qry = string.Format("SELECT seq FROM sqlite_sequence WHERE name='Transacao';");
            DataSet ds = db.ExecuteQuery(qry);

            if (ds.Tables[0].Rows.Count != 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                int id = int.Parse(dr["seq"].ToString());
                return id;
            }
            else
            {
                return 1;
            }
        }
    }
}
