using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication2
{
    class ProdutoDAO
    {
        public void Editar(Produto p)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE produto SET nome = '{0}', detalhes = '{1}', quantidade = {2} where id={3}", p.Nome, p.Detalhes, p.Quantidade.ToString(System.Globalization.CultureInfo.InvariantCulture), p.Id);

            db.ExecuteNonQuery(qry);

        }

        public List<Produto> Listar()
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Produto");
            DataSet ds = db.ExecuteQuery(qry);

            List<Produto> LProdutos = new List<Produto>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Produto p = new Produto();
                p.Id = int.Parse(dr["id"].ToString());
                p.Nome = dr["nome"].ToString();
                p.Detalhes = dr["detalhes"].ToString();
                p.Quantidade = double.Parse(dr["quantidade"].ToString());
                LProdutos.Add(p);
            }
            return LProdutos;
        }

        public Produto Read(int id)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Produto WHERE id = {0}", id);
            DataSet ds = db.ExecuteQuery(qry);

            Produto p = new Produto();

            if (ds.Tables[0].Rows.Count != 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                p.Id = int.Parse(dr["id"].ToString());
                p.Nome = dr["nome"].ToString();
                p.Detalhes = dr["detalhes"].ToString();
                p.Quantidade = Double.Parse(dr["quantidade"].ToString());
                return p;
            }
            else
            {
                return null;
            }
        }

        public Produto Read(string nome)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Produto WHERE nome = '{0}'", nome);
            DataSet ds = db.ExecuteQuery(qry);

            Produto p = new Produto();

            if (ds.Tables[0].Rows.Count != 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                p.Id = int.Parse(dr["id"].ToString());
                p.Nome = dr["nome"].ToString();
                p.Detalhes = dr["detalhes"].ToString();
                p.Quantidade = Double.Parse(dr["quantidade"].ToString());
                return p;
            }
            else
            {
                return null;
            }
        }

        public void Remover(int id)
        {
            Database db = Database.GetInstance();

            string qry = string.Format("DELETE FROM Produto WHERE id ={0}", id);
            db.ExecuteNonQuery(qry);
        }

        public void Salvar(Produto p)
        {
            Database db = Database.GetInstance();

            string qry = string.Format("INSERT INTO Produto(nome,detalhes,quantidade) VALUES('{0}','{1}',{2})", p.Nome, p.Detalhes, p.Quantidade.ToString(System.Globalization.CultureInfo.InvariantCulture));
            db.ExecuteNonQuery(qry);
        }
    }
}
