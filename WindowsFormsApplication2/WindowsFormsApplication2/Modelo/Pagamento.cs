using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Pagamento
    {
        private Conta c = new Conta();
        private List<PessoaPagamento> lPessoas = new List<PessoaPagamento>();

        public Pagamento(Conta c, List<PessoaPagamento> lPessoas)
        {
            this.C = c;
            this.LPessoas = lPessoas;
        }

        public Pagamento()
        {

        }

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
