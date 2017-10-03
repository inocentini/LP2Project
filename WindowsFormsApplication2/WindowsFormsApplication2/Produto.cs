using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Produto
    {
        private int id;
        private string nome;
        private string detalhes;
        private int qtdDisponivel;

        public Produto(string id, string nome, string detalhes, int qtdDisponivel)
        {
            this.Id = id;
            this.Nome = nome;
            this.Detalhes = detalhes;
            this.QtdDisponivel = qtdDisponivel;
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

        public int QtdDisponivel
        {
            get
            {
                return qtdDisponivel;
            }

            set
            {
                qtdDisponivel = value;
            }
        }

            
    }
}
