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
            ContaDAO dbc = new ContaDAO();
            List<Conta> lContas = dbc.Listar();
            List<Pagamento> lPagamentos = new List<Pagamento>();

            foreach(Conta c in lContas)
            {
                lPagamentos.Add(Read(c.Id));
            }

            return lPagamentos;
        }

        public List<Pagamento> ListarPessoa(string cpf)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Pagamento WHERE cpfpessoa = '{0}'",cpf);
            DataSet ds = db.ExecuteQuery(qry);

            PessoaDAO dbp = new PessoaDAO();
            ContaDAO dbc = new ContaDAO();

            Pessoa p = dbp.Read(cpf);
            List<Pagamento> lPagamentos = new List<Pagamento>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Pagamento pgm = new Pagamento();
                Conta c = dbc.Read(int.Parse(dr["idconta"].ToString()));
                PessoaPagamento pg = new PessoaPagamento();
                pg.P = p;
                pg.Pago = Convert.ToBoolean(int.Parse(dr["pago"].ToString()));
                pg.APagar = double.Parse(dr["apagar"].ToString());
                pgm.LPessoas.Add(pg);
                lPagamentos.Add(pgm);
            }

            return lPagamentos;
        }

        public Pagamento Read(int id)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Pagamento WHERE idConta = {0}", id);
            DataSet ds = db.ExecuteQuery(qry);

            Pagamento p = new Pagamento();
            ContaDAO dbc = new ContaDAO();
            PessoaDAO dbp = new PessoaDAO();

            p.C = dbc.Read(id);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                PessoaPagamento pg = new PessoaPagamento();
                pg.P = dbp.Read(dr["cpfpessoa"].ToString());
                pg.APagar = double.Parse(dr["apagar"].ToString());
                pg.Pago = Convert.ToBoolean(int.Parse(dr["pago"].ToString()));
                p.LPessoas.Add(pg);
            }

            return p;
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
