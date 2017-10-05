using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication2
{
    class PessoaDAO : IDAO
    {
        public void Editar(object o)
        {
            Pessoa p = (Pessoa)o;
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE pessoa SET nome = '{0}', email = '{1}', telefone = '{2}' where cpf='{3}'", p.Nome, p.Email, p.Telefone, p.Cpf );

            db.ExecuteNonQuery(qry);           
            
        }

        public List<object> Listar()
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Pessoa");
            DataSet ds = db.ExecuteQuery(qry);

            List<object> LPessoas = new List<object>();

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

        public object Read(object cpf)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Pessoa WHERE cpf = '{0}'", cpf);
            DataSet ds = db.ExecuteQuery(qry);

            Pessoa p = new Pessoa();

            DataRow dr = ds.Tables[0].Rows[0];
            p.Cpf = dr["cpf"].ToString();
            p.Nome = dr["nome"].ToString();
            p.Email = dr["email"].ToString();
            p.Telefone = dr["telefone"].ToString();   
            return p;
        }

        public void Remover(object o)
        {
            Database db = Database.GetInstance();

            string qry = string.Format("DELETE FROM Pessoa WHERE cpf ='{0}'", o);
            db.ExecuteNonQuery(qry);
        }

        public void Salvar(object o)
        {
            Database db = Database.GetInstance();

            string qry = string.Format("INSERT INTO PESSOA VALUES('{0}','{1}','{2}','{3}')", ((Pessoa)o).Cpf, ((Pessoa)o).Nome, ((Pessoa)o).Email, ((Pessoa)o).Telefone);
            db.ExecuteNonQuery(qry);
        }
    }
}