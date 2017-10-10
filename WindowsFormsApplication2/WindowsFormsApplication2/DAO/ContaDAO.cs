using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    class ContaDAO
    {
        public void Editar(Conta c)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE Conta SET nome = '{0}', detalhes = '{1}', valor = {2}, vencimento = '{3}', cpfresponsavel = '{4}' where id={5}", c.Nome, c.Detalhes, c.Valor.ToString(System.Globalization.CultureInfo.InvariantCulture), c.Vencimento.ToString("yyyy-MM-dd"), c.Responsavel.Cpf, c.Id);

            db.ExecuteNonQuery(qry);

        }

        public List<Conta> Listar()
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Conta");
            DataSet ds = db.ExecuteQuery(qry);

            List<Conta> LContas = new List<Conta>();

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

        public Conta Read(int id)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Conta WHERE id = {0}", id);
            DataSet ds = db.ExecuteQuery(qry);

            Conta c = new Conta();

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

        public void Remover(int id)
        {
            Database db = Database.GetInstance();

            string qry = string.Format("DELETE FROM Conta WHERE id ={0}", id);
            db.ExecuteNonQuery(qry);
        }

        public void Salvar(Conta c)
        {
            Database db = Database.GetInstance();

            string qry = string.Format("INSERT INTO Conta(nome,detalhes,valor,vencimento,cpfresponsavel) VALUES('{0}','{1}',{2},'{3}','{4}')", c.Nome,c.Detalhes,c.Valor.ToString(System.Globalization.CultureInfo.InvariantCulture),c.Vencimento.ToString("yyyy-MM-dd"), c.Responsavel.Cpf);
            db.ExecuteNonQuery(qry);
        }
    }
}
