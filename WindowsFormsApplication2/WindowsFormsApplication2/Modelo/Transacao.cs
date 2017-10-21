using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseManager
{
    public class Transacao
    {
        //Declaração de variáveis.
        private int id = new int();
        private DateTime data = new DateTime();
        private List<ProdutoTransacao> lista = new List<ProdutoTransacao>();
        private bool compra = new bool();
        private double valor = new double();

        //Properties.
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

        public List<ProdutoTransacao> Lista
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

        //Construtores.
        public Transacao(DateTime data, List<ProdutoTransacao> lista, int id,bool compra,double valor)
        {
            this.Id = id;
            this.Data = data;
            this.Lista = lista;
            this.Compra = compra;
            this.Valor = valor;
        }

        public Transacao()
        {

        }

        //Método override ToString de formatação para visualização no DataGridView.
        public override string ToString()
        {
            string stg = "";
            foreach(ProdutoTransacao pv in Lista)
            {
                stg = stg + "" + pv.Prod.Nome + ": " + pv.Quantidade + "  |  ";
            }

            return stg.Remove(stg.Length - 3,1);
        }
    }
}
