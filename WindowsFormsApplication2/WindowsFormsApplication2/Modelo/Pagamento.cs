using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseManager
{
    public class Pagamento
    {
        //Declaração de variáveis.
        private Conta c = new Conta();
        private List<PessoaPagamento> lPessoas = new List<PessoaPagamento>();

        //Construtores.
        public Pagamento(Conta c, List<PessoaPagamento> lPessoas)
        {
            this.C = c;
            this.LPessoas = lPessoas;
        }

        public Pagamento()
        {

        }

        //Properties
        public Conta C
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }

        internal List<PessoaPagamento> LPessoas
        {
            get
            {
                return lPessoas;
            }

            set
            {
                lPessoas = value;
            }
        }
    }
}
