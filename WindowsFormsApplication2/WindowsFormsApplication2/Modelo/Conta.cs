using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Conta
    {
        private int id;
        private string nome;
        private string detalhes;
        private float valor;
        private DateTime vencimento;
        private Pessoa responsavel;

        //Construtor e properties feitos, dúvida quanto a lista de pessoas e o quanto ja pagaram.

        public Conta()
        {

        }
        public Conta(int id, string nome, string detalhes, float valor, DateTime vencimento, Pessoa responsavel)
        {
            this.Id = id;
            this.Nome = nome;
            this.Detalhes = detalhes;
            this.Valor = valor;
            this.Vencimento = vencimento;
            this.Responsavel = responsavel;
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

        public float Valor
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

        public DateTime Vencimento
        {
            get
            {
                return vencimento;
            }

            set
            {
                vencimento = value;
            }
        }

        public Pessoa Responsavel
        {
            get
            {
                return responsavel;
            }

            set
            {
                responsavel = value;
            }
        }
    }
}
