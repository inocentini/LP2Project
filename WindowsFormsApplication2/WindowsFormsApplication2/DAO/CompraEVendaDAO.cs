using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication2
{
    class CompraEVendaDAO
    {
        public void Editar(CompraEVenda cv)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE compraevenda SET data='{0}', valor={1}, compra={2} WHERE id={3};",cv.Data.ToString("yyyy-MM-dd"),cv.Valor.ToString(System.Globalization.CultureInfo.InvariantCulture),Convert.ToInt32(cv.Compra),cv.Id);
            qry = string.Concat(qry, string.Format("DELETE FROM compraevenda_produto WHERE idcompra = {0}; ", cv.Id));
            foreach (ProdutoVenda pv in cv.Lista)
            {
                qry = string.Concat(qry, string.Format("INSERT INTO compraevenda_produto(idcompra,idproduto,quantidade) VALUES ({0},{1},{2});", cv.Id, pv.Prod.Id, pv.Quantidade.ToString(System.Globalization.CultureInfo.InvariantCulture)));
            }

            db.ExecuteNonQuery(qry);
        }

        public List<CompraEVenda> Listar()
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM compraevenda GROUP BY id");
            DataSet ds = db.ExecuteQuery(qry);

            List<CompraEVenda> LCompraEVenda = new List<CompraEVenda>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                CompraEVenda cv = new CompraEVenda();
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

        public List<ProdutoVenda> ListarProd(int id)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM compraevenda_produto WHERE idcompra={0}", id);
            DataSet ds = db.ExecuteQuery(qry);

            List<ProdutoVenda> Lprod = new List<ProdutoVenda>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ProdutoVenda pv = new ProdutoVenda();
                ProdutoDAO dbprod = new ProdutoDAO();
                pv.Prod = dbprod.Read(int.Parse(dr["idproduto"].ToString()));
                pv.Quantidade = double.Parse(dr["quantidade"].ToString());
                Lprod.Add(pv);
            }
            return Lprod;
        }

        public CompraEVenda Read(int id)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM compraevenda WHERE id = {0}", id);
            DataSet ds = db.ExecuteQuery(qry);

            CompraEVenda cv = new CompraEVenda();

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

            string qry = string.Format("DELETE FROM compraevenda WHERE id = {0}; DELETE FROM compraevenda_produto WHERE idcompra = {0}", id);
            db.ExecuteNonQuery(qry);
        }

        public void Salvar(CompraEVenda cv)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("INSERT INTO compraevenda(data,valor,compra) VALUES ('{0}',{1},{2});", cv.Data.ToString("yyyy-MM-dd"), cv.Valor.ToString(System.Globalization.CultureInfo.InvariantCulture), Convert.ToInt32(cv.Compra));
            db.ExecuteNonQuery(qry);

            int ultimoid = UltimoId();

            qry = "";
            foreach (ProdutoVenda p in cv.Lista)
            {
                qry = string.Concat(qry,string.Format("INSERT INTO compraevenda_produto(idcompra,idproduto,quantidade) VALUES ({0},{1},{2});", ultimoid, p.Prod.Id, p.Quantidade.ToString(System.Globalization.CultureInfo.InvariantCulture)));
            }

            db.ExecuteNonQuery(qry);
        }

        public int UltimoId()
        {
            Database db = Database.GetInstance();

            string qry = string.Format("SELECT seq FROM sqlite_sequence WHERE name='CompraEVenda';");
            DataSet ds = db.ExecuteQuery(qry);

            if (ds.Tables[0].Rows.Count != 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                Console.WriteLine(dr["seq"].ToString());
                int id = int.Parse(dr["seq"].ToString());
                Console.WriteLine(id);
                return id;
            }
            else
            {
                return 1;
            }
        }
    }
}
