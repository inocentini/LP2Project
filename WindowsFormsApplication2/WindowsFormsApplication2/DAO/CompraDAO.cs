using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HouseManager
{
    class CompraDAO
    {
        //Método utilizado para editar uma transação
        public void Editar(Transacao t)
        {
            Database db = Database.GetInstance();

            //Atualiza as informações pertinentes à tabela de transação
            string qry = string.Format("UPDATE transacao SET data='{0}', valor={1} WHERE id={2};",t.Data.ToString("yyyy-MM-dd"),t.Valor.ToString(System.Globalization.CultureInfo.InvariantCulture),t.Id);

            //Exclui todos os produtos dessa transação para não haver conflitos após a readição
            qry = string.Concat(qry, string.Format("DELETE FROM transacao_produto WHERE idcompra = {0}; ", t.Id));

            foreach(ProdutoTransacao pt in t.Lista)
            {
                qry = string.Concat(qry, string.Format("INSERT INTO transacao_produto(idcompra,produto,quantidade) VALUES({0}, '{1}', {2});",t.Id, pt.Prod, pt.Quantidade.ToString(System.Globalization.CultureInfo.InvariantCulture)));
            }

            db.ExecuteNonQuery(qry);
        }

        public List<Transacao> Listar()
        {
            //Método utilizado para listar todas as transações
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM transacao");
            DataSet ds = db.ExecuteQuery(qry);

            List<Transacao> LCompra = new List<Transacao>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Transacao t = new Transacao();
                t.Id = int.Parse(dr["id"].ToString());
                string data = dr["data"].ToString();
                t.Data = Convert.ToDateTime(data);
                t.Valor = double.Parse(dr["valor"].ToString());

                //Chama o método ListarProd (abaixo) para listar todos os produtos de uma transação e a quantidade comprada/usada
                t.Lista = ListarProd(t.Id);
                LCompra.Add(t);
            }

            return LCompra;
        }

        public List<Transacao> ListarPorData(DateTime data)
        {
            //Conexão, qry e atribuição da consulta para uma variavel.
            Database db = Database.GetInstance();
            string qry;
            if (data.Month < 10)
            {
                qry = string.Format("SELECT * FROM Transacao WHERE strftime('%m', data) = '{0}{1}' AND strftime('%Y', data) = '{2}';", 0, data.Month, data.Year);
            }
            else
            {
                qry = string.Format("SELECT * FROM Transacao WHERE strftime('%m', data) = '{0}' AND strftime('%Y', data) = '{1}';", data.Month, data.Year);
            }
            DataSet ds = db.ExecuteQuery(qry);

            List<Transacao> LCompra = new List<Transacao>();

            //Atribui dados da consulta para a lista e retorna a lista.
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Transacao t = new Transacao();
                t.Id = int.Parse(dr["id"].ToString());
                string data2 = dr["data"].ToString();
                t.Data = Convert.ToDateTime(data2);
                t.Valor = double.Parse(dr["valor"].ToString());

                //Chama o método ListarProd (abaixo) para listar todos os produtos de uma transação e a quantidade comprada/usada
                t.Lista = ListarProd(t.Id);
                LCompra.Add(t);
            }

            return LCompra;
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
                pv.Prod = dr["produto"].ToString();
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

            //Exclui todas as informações de ambas as tabelas
            string qry = string.Format("DELETE FROM transacao WHERE id = {0}; DELETE FROM transacao_produto WHERE idcompra = {0}", id);
            db.ExecuteNonQuery(qry);
        }

        public void Salvar(Transacao t)
        {
            //Método utilizado para se salvar uma transação
            Database db = Database.GetInstance();
            string qry = string.Format("INSERT INTO transacao(data,valor) VALUES ('{0}',{1});", t.Data.ToString("yyyy-MM-dd"), t.Valor.ToString(System.Globalization.CultureInfo.InvariantCulture));
            db.ExecuteNonQuery(qry);

            //Aqui, por meio do método "UltimoId" (abaixo), se guarda o id gerado pelo autoincrement na query anterior para se adicionar os produtos na tabela "transacao_produto"
            int ultimoid = UltimoId();
            qry = "";

            foreach (ProdutoTransacao pv in t.Lista)
            {
                qry = string.Concat(qry, string.Format("INSERT INTO transacao_produto(idcompra,produto,quantidade) VALUES ({0},'{1}',{2});", ultimoid, pv.Prod, pv.Quantidade.ToString(System.Globalization.CultureInfo.InvariantCulture)));
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
