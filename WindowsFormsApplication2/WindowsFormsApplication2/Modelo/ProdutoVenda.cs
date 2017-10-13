using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class ProdutoVenda
    {
        private Produto prod = new Produto();
        private double quantidade = new double();

        public ProdutoVenda(Produto prod, double quantidade)
        {
            this.Prod = prod;
            this.Quantidade = quantidade;
        }

        public ProdutoVenda()
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
