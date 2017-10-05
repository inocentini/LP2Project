using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace WindowsFormsApplication2
{
    class LoginDAO : IDAO
    {
        public bool Login (Login l)
        {
            Database db = Database.GetInstance();

            Login n = (Login)Read(l.Nome);

            string hash = n.Senha;
            return Hashing.Verifica(l.Senha, hash);
        }


        public void Editar(object o)
        {
            Login p = (Login)o;
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE Login SET senha ='{0}' where nome ='{1}'", p.Senha, p.Nome);

            db.ExecuteNonQuery(qry);

        }

        public List<object> Listar()
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Login");
            DataSet ds = db.ExecuteQuery(qry);

            List<object> LLogin = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Login l = new Login();
                l.Nome = dr["nome"].ToString();
                l.Senha = dr["senha"].ToString();
                LLogin.Add(l);
            }
            return LLogin;
        }

        public object Read(object nome)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Login WHERE nome = '{0}'", nome);
            DataSet ds = db.ExecuteQuery(qry);

            Login p = new Login();

            DataRow dr = ds.Tables[0].Rows[0];
            p.Nome = dr["nome"].ToString();
            p.Senha = dr["senha"].ToString();
            
            return p;
        }

        public void Remover(object o)
        {
            Database db = Database.GetInstance();
            Login p = (Login)o;

            string qry = string.Format("DELETE FROM Login WHERE nome ='{0}", p.Nome);
            db.ExecuteNonQuery(qry);
        }

        public void Salvar(object o)
        {
            Login p = (Login)o;
            Database db = Database.GetInstance();

            string qry = string.Format("INSERT INTO Login VALUES('{0}', '{1}')", p.Nome, Hashing.Hash(p.Senha,null));
            db.ExecuteNonQuery(qry);
        }
    }
}
