using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class PessoaPagamento
    {
        private Pessoa p = new Pessoa();
        private bool pago = false;
        private double aPagar = new double();

        public PessoaPagamento(Pessoa p, bool pago, double aPagar)
        {
            this.P = p;
            this.Pago = pago;
            this.APagar = aPagar;
        }

        public PessoaPagamento()
        {

        }

        public double APagar
        {
            get
            {
                return aPagar;
            }

            set
            {
                aPagar = value;
            }
        }

        public bool Pago
        {
            get
            {
                return pago;
            }

            set
            {
                pago = value;
            }
        }

        public Pessoa P
        {
            get
            {
                return p;
            }

            set
            {
                p = value;
            }
        }
    }
}
