using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    class DatabaseMySQLLogin : IDatabaseLogin
    {
        public List<Login> Listar()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost; Database=aula; Uid=root; Pwd=ifsp;";

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = string.Format("SELECT * FROM Login");
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            List<Login> LLogin = new List<Login>();
            while (dr.Read())
            {
                Login l = new Login();
                l.Nome = dr.GetString(0);
                l.Senha = dr.GetString(1);

                LLogin.Add(l);
            }
            conn.Close();
            return LLogin;
        }

        public bool Login(Login l)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost; Database=aula; Uid=root; Pwd=ifsp;";

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = string.Format("SELECT * FROM Login WHERE Nome = '{0}';", l.Nome);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string hash = dr.GetString(1);

                conn.Close();
                return Hashing.Verifica(l.Senha, hash);
            }
            conn.Close();
            return false;
        }

        public Login Read(string nome)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost; Database=aula; Uid=root; Pwd=ifsp;";

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = string.Format("SELECT * FROM Login WHERE Nome = '{0}';", nome);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Login l = new Login();
                l.Nome = dr.GetString(0);
                l.Senha = dr.GetString(1);
                conn.Close();
                return l;
            }
            conn.Close();
            return null;
        }

        public void Remover(string nome)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost; Database=aula; Uid=root; Pwd=ifsp;";

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = string.Format("DELETE FROM Login WHERE Nome = '{0}';", nome);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Salvar(Login l)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost; Database=aula; Uid=root; Pwd=ifsp;";

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = string.Format("INSERT INTO Login (Nome,Senha) VALUES ('{0}','{1}');", l.Nome, Hashing.Hash(l.Senha,null));

            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
