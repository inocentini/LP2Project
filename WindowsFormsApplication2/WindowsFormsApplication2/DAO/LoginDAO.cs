using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace HouseManager
{
    class LoginDAO
    {
        //Método para realizar login
        public bool Login (Login l)
        {
            Database db = Database.GetInstance();

            //Verifica se o usuário informado existe
            Login n = (Login)Read(l.Nome);

            if (n != null)
            {
                //Chama o hashing para verificar a senha
                return Hashing.Verifica(l.Senha, n.Senha);
            }
            else
            {
                return false;
            }

        }

        //Edita um login
        public void Editar(Login l)
        {
            Console.WriteLine(l.Nome + " " + l.Senha);

            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE Login SET senha ='{0}', admin={1} where nome ='{2}'", Hashing.Hash(l.Senha, null), Convert.ToInt32(l.Admin), l.Nome);

            db.ExecuteNonQuery(qry);

        }

        //Lista todos os logins
        public List<Login> Listar()
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Login");
            DataSet ds = db.ExecuteQuery(qry);

            List<Login> LLogin = new List<Login>();
            PessoaDAO dbp = new PessoaDAO();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Login l = new Login();
                l.Nome = dr["nome"].ToString();
                l.Senha = dr["senha"].ToString();
                l.Admin = Convert.ToBoolean(int.Parse(dr["admin"].ToString()));
                l.P = dbp.Read(dr["cpfpessoa"].ToString());
                LLogin.Add(l);
            }
            return LLogin;
        }

        //Lê um login
        public Login Read(string nome)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Login WHERE nome = '{0}'", nome);
            DataSet ds = db.ExecuteQuery(qry);

            Login l = new Login();
            PessoaDAO dbp = new PessoaDAO();

            if(ds.Tables[0].Rows.Count != 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                l.Nome = dr["nome"].ToString();
                l.Senha = dr["senha"].ToString();
                l.P = dbp.Read(dr["cpfpessoa"].ToString());
                l.Admin = Convert.ToBoolean(int.Parse(dr["admin"].ToString()));
                return l;
            }
            else
            {
                return null;
            }
        }

        //Remove um login
        public void Remover(string nome)
        {
            Database db = Database.GetInstance();

            string qry = string.Format("DELETE FROM Login WHERE nome ='{0}", nome);
            db.ExecuteNonQuery(qry);
        }

        //Salva um login, realiza um hashing na senha
        public void Salvar(Login l)
        {
            Database db = Database.GetInstance();
            
            string qry = string.Format("INSERT INTO Login VALUES('{0}', '{1}', '{2}', '{3}')", l.Nome, Hashing.Hash(l.Senha, null), Convert.ToInt32(l.Admin), l.P.Cpf);
            db.ExecuteNonQuery(qry);
        }

        //Define o usuário que está logado
        public void SetSession(string nome)
        {
            Database db = Database.GetInstance();

            string qry = string.Format("SELECT cpfpessoa, nome, admin FROM Login WHERE nome = '{0}'", nome);
            DataSet ds = db.ExecuteQuery(qry);

            if (ds.Tables[0].Rows.Count != 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                Sessao.login.Admin = Convert.ToBoolean(int.Parse(dr["admin"].ToString()));
                Sessao.login.Nome = dr["nome"].ToString();

                PessoaDAO dbp = new PessoaDAO();

                Sessao.login.P = dbp.Read(dr["cpfpessoa"].ToString());
            }

        }

        //Verifica se existe algum admin para que não ocorram problemas por falta de admin
        public bool HasAdmin()
        {
            Database db = Database.GetInstance();

            string qry = string.Format("SELECT Count(*) AS c FROM Login WHERE admin=1");
            DataSet ds = db.ExecuteQuery(qry);

            if (ds.Tables[0].Rows.Count != 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                return int.Parse(dr["c"].ToString()) == 0 ? true : false;
            }
            else
            {
                return false;
            }
        }

        public string cpfAdmin()
        {
            //Pega o CPF do administrador para a atribuição como responsável quando uma pessoa que possui contas é removida
            Database db = Database.GetInstance();

            string qry = string.Format("SELECT cpfpessoa FROM Login WHERE admin=1");
            DataSet ds = db.ExecuteQuery(qry);

            if (ds.Tables[0].Rows.Count != 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                return dr["cpfpessoa"].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
