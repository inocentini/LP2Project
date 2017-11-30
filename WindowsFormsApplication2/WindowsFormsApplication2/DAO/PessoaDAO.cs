using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HouseManager
{
    class PessoaDAO
    {
        //Edita uma pessoa
        public void Editar(Pessoa p)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE pessoa SET nome = '{0}', email = '{1}', telefone = '{2}' where cpf='{3}'", p.Nome, p.Email, p.Telefone, p.Cpf );

            db.ExecuteNonQuery(qry);           
            
        }

        //Lista todas as pessoas
        public List<Pessoa> Listar()
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Pessoa");
            DataSet ds = db.ExecuteQuery(qry);

            List<Pessoa> LPessoas = new List<Pessoa>();

            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                Pessoa p = new Pessoa();
                p.Cpf = dr["cpf"].ToString();
                p.Nome = dr["nome"].ToString();
                p.Email = dr["email"].ToString();
                p.Telefone = dr["telefone"].ToString();
                LPessoas.Add(p);
            }
            return LPessoas;
        }

        //Lê as informações de uma pessoa
        public Pessoa Read(string cpf)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Pessoa WHERE cpf = '{0}'", cpf);
            DataSet ds = db.ExecuteQuery(qry);

            Pessoa p = new Pessoa();

            if (ds.Tables[0].Rows.Count != 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                p.Cpf = dr["cpf"].ToString();
                p.Nome = dr["nome"].ToString();
                p.Email = dr["email"].ToString();
                p.Telefone = dr["telefone"].ToString();
                return p;
            }
            else
            {
                return null;
            }
        }

        //Exclui uma pessoa
        public void Remover(string cpf)
        {
            Database db = Database.GetInstance();

            ContaDAO dbc = new ContaDAO();
            dbc.AtribuirResp(cpf);

            PagamentoDAO dbp = new PagamentoDAO();
            dbp.RemoverPessoa(cpf);

            string qry = string.Format("DELETE FROM Pessoa WHERE cpf ='{0}'; DELETE FROM Login WHERE cpfpessoa = '{0}';", cpf);
            db.ExecuteNonQuery(qry);
        }

        //Adiciona uma pessoa
        public void Salvar(Pessoa p)
        {
            Database db = Database.GetInstance();

            string qry = string.Format("INSERT INTO PESSOA VALUES('{0}','{1}','{2}','{3}')", p.Cpf, p.Nome, p.Email, p.Telefone);
            db.ExecuteNonQuery(qry);
        }

        //Conta o número de pessoas (será utilizado para a geração de pagamentos)
        public int Contar()
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT COUNT(*) AS pessoas FROM Pessoa");
            DataSet ds = db.ExecuteQuery(qry);

            if (ds.Tables[0].Rows.Count != 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                return int.Parse(dr["pessoas"].ToString());
            }
            else
            {
                return 0;
            }
        }
    }
}