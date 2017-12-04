using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HouseManager
{
    class PagamentoDAO
    {
        //Edita a situação de pago de uma pessoa para uma conta
        public void Editar(PessoaPagamento p, Conta c)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE Pagamento SET pago = {0} WHERE cpfpessoa = '{1}' AND idconta={2};", Convert.ToInt32(p.Pago), p.P.Cpf, c.Id);
            

            db.ExecuteNonQuery(qry);
        }

        //Edita todos os pagamentos de uma conta
        public void Editar(Pagamento p)
        {
            Remover(p.C.Id);
            Salvar(p);
        }

        //Lista todos os pagamentos de todas as contas
        public List<Pagamento> Listar()
        {            
            ContaDAO dbc = new ContaDAO();

            //Lista todas contas
            List<Conta> lContas = dbc.Listar();

            List<Pagamento> lPagamentos = new List<Pagamento>();

            //Para toda conta encontrada, lê os pagamentos dela
            foreach(Conta c in lContas)
            {
                lPagamentos.Add(Read(c.Id));
            }

            return lPagamentos;
        }

        //Lista todos os pagamentos de uma pessoa
        public List<Pagamento> ListarPessoa(string cpf)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Pagamento WHERE cpfpessoa = '{0}'",cpf);
            DataSet ds = db.ExecuteQuery(qry);

            PessoaDAO dbp = new PessoaDAO();
            ContaDAO dbc = new ContaDAO();

            //Instancia a pessoa pesquisada
            Pessoa p = dbp.Read(cpf);

            List<Pagamento> lPagamentos = new List<Pagamento>();

            //Para cada pagamento encontrado, lê a conta que ele pertence e a situação da pessoa e se adiciona na lista
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Pagamento pgm = new Pagamento();
                pgm.C = dbc.Read(int.Parse(dr["idconta"].ToString()));
                PessoaPagamento pg = new PessoaPagamento();
                pg.P = p;
                pg.Pago = Convert.ToBoolean(int.Parse(dr["pago"].ToString()));
                pg.APagar = double.Parse(dr["apagar"].ToString());
                pgm.LPessoas.Add(pg);
                lPagamentos.Add(pgm);
            }

            return lPagamentos;
        }

        //Lista todos os pagamentos de uma conta em particular
        public Pagamento Read(int id)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT idconta, cpfpessoa, pago, apagar FROM Pagamento WHERE idConta = {0}", id);
            DataSet ds = db.ExecuteQuery(qry);

            Pagamento p = new Pagamento();
            ContaDAO dbc = new ContaDAO();
            PessoaDAO dbp = new PessoaDAO();

            //Instancia a conta procurada
            p.C = dbc.Read(id);

            //Para cada pagamento encontrado, lê adiciona as informações da pessoa na lista
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                PessoaPagamento pg = new PessoaPagamento();
                Console.WriteLine(dr["cpfpessoa"].ToString());
                pg.P = dbp.Read(dr["cpfpessoa"].ToString());
                pg.APagar = double.Parse(dr["apagar"].ToString());
                pg.Pago = Convert.ToBoolean(int.Parse(dr["pago"].ToString()));
                p.LPessoas.Add(pg);
            }

            return p;
        }

        //Retorna a situação de pagamento de uma pessoa para uma conta
        public PessoaPagamento Read(int idconta, string cpf)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("SELECT * FROM Pagamento WHERE cpfpessoa = '{0}' AND idconta = {1}", cpf,idconta);
            DataSet ds = db.ExecuteQuery(qry);

            PessoaPagamento p = new PessoaPagamento();
            PessoaDAO dbp = new PessoaDAO();

            //Instancia a pessoa pesquisada
            p.P = dbp.Read(cpf);

            if (ds.Tables[0].Rows.Count != 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                p.APagar = double.Parse(dr["apagar"].ToString());
                p.Pago = Convert.ToBoolean(int.Parse(dr["pago"].ToString()));
                return p;
            }
            else
            {
                return null;
            }
        }

        //Exclui todos os pagamentos de uma conta
        public void Remover(int id)
        {
            Database db = Database.GetInstance();

            string qry = string.Format("DELETE FROM Pagamento WHERE idconta = {0}", id);
            db.ExecuteNonQuery(qry);
        }

        //Salva um pagamento
        public void Salvar(Pagamento p)
        {
            Database db = Database.GetInstance();
            string qry = "";

            //Para cada pessoa, gera um comando para a inserção de sua situação no pagamento da conta
            foreach(PessoaPagamento pp in p.LPessoas)
            {
                qry = string.Concat(qry, string.Format("INSERT INTO Pagamento(idconta,cpfpessoa,pago,apagar) VALUES({0},'{1}',{2},{3}); ", p.C.Id, pp.P.Cpf, Convert.ToInt32(pp.Pago), pp.APagar.ToString(System.Globalization.CultureInfo.InvariantCulture)));
            }

            db.ExecuteNonQuery(qry);
        }

        //Função para gerar os pagamentos ao se adicionar uma conta
        public void Gerar(Conta c)
        {
            PessoaDAO dbp = new PessoaDAO();

            List<Pessoa> lPessoas = new List<Pessoa>();
            lPessoas = dbp.Listar();
            Pagamento pag = new Pagamento();
            pag.C = c;
            int numPessoas = dbp.Contar();
            double aPagar = c.Valor / numPessoas;

            foreach(Pessoa p in lPessoas)
            {
                PessoaPagamento pp;
                pp = new PessoaPagamento(p, false, aPagar);

                pag.LPessoas.Add(pp);
            }

            Remover(c.Id);
            Salvar(pag);
        }

        //Função utilizada para remover os pagamentos de uma pessoa
        public void RemoverPessoa(string cpf)
        {
            Database db = Database.GetInstance();
            
            string qry = string.Format("DELETE FROM Pagamento WHERE cpfpessoa = '{0}';", cpf);
            db.ExecuteNonQuery(qry);
        }
    }
}
