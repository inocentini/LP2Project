using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Produto
    {
        private int id;
        private string nome;
        private string detalhes;
        private double quantidade;

        public Produto()
        {

        }
        public Produto(int id, string nome, string detalhes, double quantidade)
        {
            this.Id = id;
            this.Nome = nome;
            this.Detalhes = detalhes;
            this.quantidade = quantidade;
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

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Detalhes
        {
            get
            {
                return detalhes;
            }

            set
            {
                detalhes = value;
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
