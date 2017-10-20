using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class ProdutoTransacao
    {
        //Declaração de variáveis.
        private Produto prod = new Produto();
        private double quantidade = new double();

        //Construtores.
        public ProdutoTransacao(Produto prod, double quantidade)
        {
            this.Prod = prod;
            this.Quantidade = quantidade;
        }

        public ProdutoTransacao()
        {

        }

        //Properties.
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
