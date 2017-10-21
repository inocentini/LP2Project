using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseManager
{
    public class PessoaPagamento
    {
        //Declaração de variáveis.
        private Pessoa p = new Pessoa();
        private bool pago = false;
        private double aPagar = new double();

        //Construtores.
        public PessoaPagamento(Pessoa p, bool pago, double aPagar)
        {
            this.P = p;
            this.Pago = pago;
            this.APagar = aPagar;
        }

        public PessoaPagamento()
        {

        }

        //Properties.
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
