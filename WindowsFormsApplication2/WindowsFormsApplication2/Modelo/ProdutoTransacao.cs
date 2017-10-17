using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class ProdutoTransacao
    {
        private Produto prod = new Produto();
        private double quantidade = new double();

        public ProdutoTransacao(Produto prod, double quantidade)
        {
            this.Prod = prod;
            this.Quantidade = quantidade;
        }

        public ProdutoTransacao()
        {

        }

        public Produto Prod
        {
            get
            {
                return prod;
            }

            set
            {
                prod = value;
            }
        }

        public double Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }
    }
}
