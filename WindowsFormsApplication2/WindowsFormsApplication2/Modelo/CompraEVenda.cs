using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class CompraEVenda
    {
        private int id = new int();
        private DateTime data = new DateTime();
        private List<ProdutoVenda> lista = new List<ProdutoVenda>();
        private bool compra = new bool();
        private double valor = new double();

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public List<ProdutoVenda> Lista
        {
            get
            {
                return lista;
            }

            set
            {
                lista = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public bool Compra
        {
            get
            {
                return compra;
            }

            set
            {
                compra = value;
            }
        }

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public CompraEVenda(DateTime data, List<ProdutoVenda> lista, int id,bool compra,double valor)
        {
            this.Id = id;
            this.Data = data;
            this.Lista = lista;
            this.Compra = compra;
            this.Valor = valor;
        }

        public CompraEVenda()
        {

        }

    }
}
