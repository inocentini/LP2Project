using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HouseManager
{
    //Classe de controle.
    class ContaDAO
    {
        //Métodos CRUD:

            //Editar Conta, faz conexão com db e passa uma qry para o método de executar qry da db.
        public void Editar(Conta c)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE Conta SET nome = '{0}', detalhes = '{1}', valor = {2}, vencimento = '{3}', cpfresponsavel = '{4}' where id={5}", c.Nome, c.Detalhes, c.Valor.ToString(System.Globalization.CultureInfo.InvariantCulture), c.Vencimento.ToString("yyyy-MM-dd"), c.Responsavel.Cpf, c.Id);

            db.ExecuteNonQuery(qry);

        }

            //Listar Conta:
        public List<Conta> Listar()
        {
            //Conexão, qry e atribuição da consulta para uma variavel.
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Conta");
            DataSet ds = db.ExecuteQuery(qry);

            List<Conta> LContas = new List<Conta>();

            //Atribui dados da consulta para a lista e retorna a lista.
            foreach (DataRow dr in ds.Tables[0].Rows) 
            {
                Conta c = new Conta();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome = dr["nome"].ToString(); 
                c.Detalhes = dr["detalhes"].ToString();
                c.Valor = double.Parse(dr["valor"].ToString());
                string vencimento = dr["vencimento"].ToString();
                c.Vencimento = Convert.ToDateTime(vencimento);
                PessoaDAO dbp = new PessoaDAO();
                c.Responsavel = dbp.Read(dr["cpfresponsavel"].ToString());
                LContas.Add(c);
            }
            return LContas;
        }

        public List<Conta> ListarPorData(DateTime data)
        {
            //Conexão, qry e atribuição da consulta para uma variavel.
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Conta WHERE vencimento = '{0}';", data.ToString("yyyy-MM-dd"));
            DataSet ds = db.ExecuteQuery(qry);

            List<Conta> LContas = new List<Conta>();

            //Atribui dados da consulta para a lista e retorna a lista.
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Conta c = new Conta();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome = dr["nome"].ToString();
                c.Detalhes = dr["detalhes"].ToString();
                c.Valor = double.Parse(dr["valor"].ToString());
                string vencimento = dr["vencimento"].ToString();
                c.Vencimento = Convert.ToDateTime(vencimento);
                PessoaDAO dbp = new PessoaDAO();
                c.Responsavel = dbp.Read(dr["cpfresponsavel"].ToString());
                LContas.Add(c);
            }
            return LContas;
        }

        //Listar Conta apartir de um responsável.
        public List<Conta> ListarPorResponsavel(string cpf)
        {
            //Conexão, qry e atribuição da consulta para uma variavel.
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Conta WHERE cpfresponsavel = '{0}'",cpf);
            DataSet ds = db.ExecuteQuery(qry);

            List<Conta> LContas = new List<Conta>();

            //Atribuição da consulta para uma lista e retorna a lista..
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Conta c = new Conta();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome = dr["nome"].ToString();
                c.Detalhes = dr["detalhes"].ToString();
                c.Valor = double.Parse(dr["valor"].ToString());
                string vencimento = dr["vencimento"].ToString();
                c.Vencimento = Convert.ToDateTime(vencimento);
                PessoaDAO dbp = new PessoaDAO();
                c.Responsavel = dbp.Read(dr["cpfresponsavel"].ToString());
                LContas.Add(c);
            }
            return LContas;
        }

            //Read Conta
        public Conta Read(int id)
        {
            //Conexão, qry e atribuição da consulta para uma variavel.
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Conta WHERE id = {0}", id);
            DataSet ds = db.ExecuteQuery(qry);

            Conta c = new Conta();

            //Atribuição do resultado da consulta na variável conta e se encontrada é retornada se não retorna nulo.
            if (ds.Tables[0].Rows.Count != 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome = dr["nome"].ToString();
                c.Detalhes = dr["detalhes"].ToString();
                c.Valor = double.Parse(dr["valor"].ToString());
                c.Vencimento = Convert.ToDateTime(dr["vencimento"].ToString());
                PessoaDAO dbp = new PessoaDAO();
                c.Responsavel = dbp.Read(dr["cpfresponsavel"].ToString());
                return c;
            }
            else
            {
                return null;
            }
        }

            //Remover Conta
        public void Remover(int id)
        {
            //Conexão, qry e execução da qry na DB.
            Database db = Database.GetInstance();
            PagamentoDAO dbp = new PagamentoDAO();

            dbp.Remover(id);
            string qry = string.Format("DELETE FROM Conta WHERE id ={0}", id);
            db.ExecuteNonQuery(qry);
        }

        public int UltimoId()
        {
            //Método utilizado para se obter o último valor do autoincrement, utilizado para realizar as ligações das informações das tabelas "transacao" e "transacao_produto"
            Database db = Database.GetInstance();

            //A tabela sqlite_sequence contém os valores atuais do autoincrement na coluna "seq" e o nome da tabela que usa esse autoincrement na coluna "name"
            string qry = string.Format("SELECT seq FROM sqlite_sequence WHERE name='Conta';");
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

        //Salvar Conta
        public void Salvar(Conta c)
        {
            //Conexão, qry e execução da qry na DB.
            Database db = Database.GetInstance();

            string qry = string.Format("INSERT INTO Conta(nome,detalhes,valor,vencimento,cpfresponsavel) VALUES('{0}','{1}',{2},'{3}','{4}')", c.Nome,c.Detalhes,c.Valor.ToString(System.Globalization.CultureInfo.InvariantCulture),c.Vencimento.ToString("yyyy-MM-dd"), c.Responsavel.Cpf);
            db.ExecuteNonQuery(qry);

            c.Id = UltimoId();

            PagamentoDAO dbp = new PagamentoDAO();
            dbp.Gerar(c);
        }

        public void AtribuirResp(string cpf)
        {
            Database db = Database.GetInstance();
            LoginDAO dbl = new LoginDAO();

            string qry = string.Format("UPDATE Conta SET cpfresponsavel='{0}' WHERE cpfresponsavel='{1}';", dbl.cpfAdmin(), cpf);

            db.ExecuteNonQuery(qry);
        }
    }
}
