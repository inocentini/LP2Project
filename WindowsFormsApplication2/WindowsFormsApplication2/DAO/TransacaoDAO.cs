using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HouseManager
{
    class TransacaoDAO
    {
        //Método utilizado para editar uma transação
        public void Editar(Transacao t,Dictionary<int,ProdutoTransacao> dictAnterior)
        {
            Database db = Database.GetInstance();

            //Atualiza as informações pertinentes à tabela de transação
            string qry = string.Format("UPDATE transacao SET data='{0}', valor={1}, compra={2} WHERE id={3};",t.Data.ToString("yyyy-MM-dd"),t.Valor.ToString(System.Globalization.CultureInfo.InvariantCulture),Convert.ToInt32(t.Compra),t.Id);

            //Exclui todos os produtos dessa transação para não haver conflitos após a readição
            qry = string.Concat(qry, string.Format("DELETE FROM transacao_produto WHERE idcompra = {0}; ", t.Id));

            ProdutoDAO pd = new ProdutoDAO();

            //Se for uma compra
            if (t.Compra)
            {
                foreach (ProdutoTransacao pt in t.Lista)
                {
                    if (dictAnterior.ContainsKey(pt.Prod.Id))
                    {
                        //Se anteriormente o produto já tinha uma quantidade em estoque, ele recebe o que tinha anteriormente menos a diferença do que foi mudado para o que tinha sido adicionado na compra
                        pt.Prod.Quantidade = pt.Prod.Quantidade + pt.Quantidade - dictAnterior[pt.Prod.Id].Quantidade;
                    }
                    else
                    {
                        //Senão, o estoque do produto recebe a quantidade comprada
                        pt.Prod.Quantidade += pt.Quantidade;
                    }

                    if (pt.Quantidade != 0)
                    {
                        //Se o produto não foi zerado (ou seja, ele ainda faz parte da compra, não foi removido na edição)
                        qry = string.Concat(qry, string.Format("INSERT INTO transacao_produto(idcompra,idproduto,quantidade) VALUES ({0},{1},{2});", t.Id, pt.Prod.Id, pt.Quantidade.ToString(System.Globalization.CultureInfo.InvariantCulture)));
                    }

                    //Edita o produto para atualizar seu estoque
                    pd.Editar(pt.Prod);
                }
            }
            //Se for um uso
            else
            {
                foreach (ProdutoTransacao pt in t.Lista)
                {
                    if (dictAnterior.ContainsKey(pt.Prod.Id))
                    {
                        //Se o produto já tinha uma quantidade em estoque, ele recebe o que tinha antes mais a diferença entre o que se tinha adicionado no uso e a nova quantidade fornecida na edição
                        pt.Prod.Quantidade = pt.Prod.Quantidade + dictAnterior[pt.Prod.Id].Quantidade - pt.Quantidade;
                    }
                    else
                    {
                        //Senão, o estoque do produto é decrescido do tanto que foi usado
                        pt.Prod.Quantidade -= pt.Quantidade;
                    }

                    if (pt.Quantidade != 0)
                    {
                        //Se o produto não foi zerado (ou seja, ele faz parte do uso, não foi removido na edição)
                        qry = string.Concat(qry, string.Format("INSERT INTO transacao_produto(idcompra,idproduto,quantidade) VALUES ({0},{1},{2});", t.Id, pt.Prod.Id, pt.Quantidade.ToString(System.Globalization.CultureInfo.InvariantCulture)));
                    }

                    //Edita o produto para atualizar seu estoque
                    pd.Editar(pt.Prod);
                }
            }

            db.ExecuteNonQuery(qry);
        }

        public List<Transacao> Listar()
        {
            //Método utilizado para listar todas as transações
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM transacao");
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

                //Chama o método ListarProd (abaixo) para listar todos os produtos de uma transação e a quantidade comprada/usada
                cv.Lista = ListarProd(cv.Id);
                LCompraEVenda.Add(cv);
            }

            return LCompraEVenda;
        }

        public List<ProdutoTransacao> ListarProd(int id)
        {
            //Método utilizado para listar todos os produtos de uma transação, dado seu id
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
            //Método utilizado para ler as informações de uma transação específica
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

                //Chama o método ListarProd (abaixo) para listar todos os produtos da transação e a quantidade comprada/usada
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
            //Método utilizado para remover uma transação, dado seu id
            Database db = Database.GetInstance();
            Transacao t = Read(id);

            ProdutoDAO dbp = new ProdutoDAO();

            if (t.Compra)
            {
                //Se ela for uma compra, edita a quantidade no estoque de cada produto dela para remover a quantidade que foi adicionada
                foreach (ProdutoTransacao pt in t.Lista)
                {
                    pt.Prod.Quantidade -= pt.Quantidade;
                    dbp.Editar(pt.Prod);
                }
            }
            else
            {
                //Se for um uso, edita o estoque para readicionar os produtos que tinham sido usados
                foreach (ProdutoTransacao pt in t.Lista)
                {
                    pt.Prod.Quantidade += pt.Quantidade;
                    dbp.Editar(pt.Prod);
                }
            }

            //Exclui todas as informações de ambas as tabelas
            string qry = string.Format("DELETE FROM transacao WHERE id = {0}; DELETE FROM transacao_produto WHERE idcompra = {0}", id);
            db.ExecuteNonQuery(qry);
        }

        public void Salvar(Transacao cv)
        {
            //Método utilizado para se salvar uma transação
            Database db = Database.GetInstance();
            string qry = string.Format("INSERT INTO transacao(data,valor,compra) VALUES ('{0}',{1},{2});", cv.Data.ToString("yyyy-MM-dd"), cv.Valor.ToString(System.Globalization.CultureInfo.InvariantCulture), Convert.ToInt32(cv.Compra));
            db.ExecuteNonQuery(qry);

            //Aqui, por meio do método "UltimoId" (abaixo), se guarda o id gerado pelo autoincrement na query anterior para se adicionar os produtos na tabela "transacao_produto"
            int ultimoid = UltimoId();
            qry = "";

            ProdutoDAO pd = new ProdutoDAO();

            if (cv.Compra)
            {
                //Se foi uma compra, para cada produto na lista se acrescenta a quantidade comprada no estoque
                foreach (ProdutoTransacao pv in cv.Lista)
                {
                    pv.Prod.Quantidade += pv.Quantidade;
                    qry = string.Concat(qry, string.Format("INSERT INTO transacao_produto(idcompra,idproduto,quantidade) VALUES ({0},{1},{2});", ultimoid, pv.Prod.Id, pv.Quantidade.ToString(System.Globalization.CultureInfo.InvariantCulture)));
                    pd.Editar(pv.Prod);
                }
            }
            else
            {
                //Se foi um uso, para cada produto na lista se decrescenta a quantidade usada no estoque
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
            //Método utilizado para se obter o último valor do autoincrement, utilizado para realizar as ligações das informações das tabelas "transacao" e "transacao_produto"
            Database db = Database.GetInstance();

            //A tabela sqlite_sequence contém os valores atuais do autoincrement na coluna "seq" e o nome da tabela que usa esse autoincrement na coluna "name"
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
