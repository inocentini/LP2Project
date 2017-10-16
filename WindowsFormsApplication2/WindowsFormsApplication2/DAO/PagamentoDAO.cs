using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication2
{
    class PagamentoDAO
    {
        public void Editar(Pagamento p)
        {
            Remover(p.C.Id);
            Salvar(p);
        }

        public List<Pagamento> Listar()
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Pagamento");
            DataSet ds = db.ExecuteQuery(qry);
            
            ContaDAO dbc = new ContaDAO();
            List<Conta> lContas = dbc.Listar();
            List<Pagamento> lPagamentos = new List<Pagamento>();

            foreach(Conta c in lContas)
            {
                lPagamentos.Add(Read(c.Id));
            }

            return c;
        }

        public Pagamento Read(int id)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Pagamento WHERE idConta = {0}", id);
            DataSet ds = db.ExecuteQuery(qry);

            Pagamento c = new Pagamento();
            ContaDAO dbc = new ContaDAO();
            PessoaDAO dbp = new PessoaDAO();

            c.C = dbc.Read(id);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                PessoaPagamento pg = new PessoaPagamento();
                pg.P = dbp.Read(dr["cpfpessoa"].ToString());
                pg.APagar = double.Parse(dr["apagar"].ToString());
                pg.Pago = Convert.ToBoolean(int.Parse(dr["pago"].ToString()));
                c.LPessoas.Add(pg);
            }

            return c;
        }

        public void Remover(int id)
        {
            Database db = Database.GetInstance();

            string qry = string.Format("DELETE FROM Pagamento WHERE idconta = {0}", id);
            db.ExecuteNonQuery(qry);
        }

        public void Salvar(Pagamento p)
        {
            Database db = Database.GetInstance();
            string qry = "";

            foreach(PessoaPagamento pp in p.LPessoas)
            {
                qry = string.Concat(qry, string.Format("INSERT INTO Pagamento(idconta,cpfpessoa,pago,apagar) VALUES({0},'{1}',{2},{3}); ", p.C.Id, pp.P.Cpf, Convert.ToInt32(pp.Pago), pp.APagar.ToString(System.Globalization.CultureInfo.InvariantCulture)));
            }

            db.ExecuteNonQuery(qry);
        }
    }
}
