using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WindowsFormsApplication2
{
    class LoginDAO
    {
        public bool Login (Login l)
        {
            Database db = Database.GetInstance();

            Login n = (Login)Read(l.Nome);

            if (n != null)
            {
                string hash = n.Senha;
                return Hashing.Verifica(l.Senha, hash);
            }
            else
            {
                return false;
            }

        }


        public void Editar(Login p)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE Login SET senha ='{0}' where nome ='{1}'", p.Senha, p.Nome);

            db.ExecuteNonQuery(qry);

        }

        public List<Login> Listar()
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Login");
            DataSet ds = db.ExecuteQuery(qry);

            List<Login> LLogin = new List<Login>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Login l = new Login();
                l.Nome = dr["nome"].ToString();
                l.Senha = dr["senha"].ToString();
                LLogin.Add(l);
            }
            return LLogin;
        }

        public Login Read(string nome)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Login WHERE nome = '{0}'", nome);
            DataSet ds = db.ExecuteQuery(qry);

            Login l = new Login();

            if(ds.Tables[0].Rows.Count != 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                l.Nome = dr["nome"].ToString();
                l.Senha = dr["senha"].ToString();
                return l;
            }
            else
            {
                return null;
            }
        }

        public void Remover(string o)
        {
            Database db = Database.GetInstance();

            string qry = string.Format("DELETE FROM Login WHERE nome ='{0}", o);
            db.ExecuteNonQuery(qry);
        }

        public void Salvar(Login p)
        {
            Database db = Database.GetInstance();

            string qry = string.Format("INSERT INTO Login VALUES('{0}', '{1}')", p.Nome, Hashing.Hash(p.Senha,null));
            db.ExecuteNonQuery(qry);
        }
    }
}
