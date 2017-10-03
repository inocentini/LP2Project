using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    class DatabaseMySQLPessoa : IDatabasePessoa
    {
        public void Editar(Pessoa p)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost; Database=aula; Uid=root; Pwd=ifsp;";

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = string.Format("UPDATE Pessoa SET nome = '{0}', email = '{1}', telefone = '{2}' WHERE cpf = '{3}';", p.Nome, p.Email, p.Telefone, p.Cpf);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public List<Pessoa> Listar()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost; Database=aula; Uid=root; Pwd=ifsp;";

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = string.Format("SELECT * FROM Pessoa");
            MySqlCommand cmd = new MySqlCommand(qry,conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            List<Pessoa> LPessoas = new List<Pessoa>();
            while (dr.Read())
            {
                Pessoa p = new Pessoa();
                p.Cpf = dr.GetString(0);
                p.Nome = dr.GetString(1);
                p.Email = dr.GetString(2);
                p.Telefone = dr.GetString(3);

                LPessoas.Add(p);
            }
            conn.Close();
            return LPessoas;
            
        }

        public Pessoa Read(string cpf)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost; Database=aula; Uid=root; Pwd=ifsp;";

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = string.Format("SELECT * FROM Pessoa WHERE cpf = '{0}';", cpf);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Pessoa p = new Pessoa();
                p.Cpf = dr.GetString(0);
                p.Nome = dr.GetString(1);
                p.Email = dr.GetString(2);
                p.Telefone = dr.GetString(3);
                conn.Close();
                return p;
            }
            conn.Close();
            return null;
            
        }

        public void Remover(string cpf)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost; Database=aula; Uid=root; Pwd=ifsp;";

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = string.Format("DELETE FROM Pessoa WHERE cpf = '{0}';", cpf);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Salvar(Pessoa p)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost; Database=aula; Uid=root; Pwd=ifsp;";

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = string.Format("INSERT INTO Pessoa (cpf,nome,email,telefone) VALUES ('{0}','{1}','{2}','{3}');", p.Cpf, p.Nome, p.Email, p.Telefone);

            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}