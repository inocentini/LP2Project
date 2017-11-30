using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HouseManager
{
    public class Pessoa
    {
        //Declaração de variáveis.
        private string nome;
        private string cpf;
        private string email;
        private string telefone;

        //Construtores.
        public Pessoa()
        {

        }

        public Pessoa(string nome, string cpf, string email, string telefone)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.Telefone = telefone;
        }

        //Properties.
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

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }


        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public static bool verificaCPF(string cpf)
        {
            cpf = cpf.Replace(@"-","");
            cpf = cpf.Replace(@".","");
            cpf.Trim();

            if (cpf.Length != 11 || !Regex.IsMatch(cpf, @"[0-9]{11}"))
            {
                return false;
            }

            string sub = cpf.Substring(0, 9);
            int soma = 0;
            int digito;
            int i = 10;

            foreach(char c in sub)
            {
                soma = soma + (int.Parse(c.ToString()) * i);
                i--;
            }

            digito = soma % 11;

            if(digito <= 2)
            {
                digito = 0;
            }else
            {
                digito = 11 - digito;
            }
            
            if(Char.Equals(digito,cpf[9]))
            {
                return false;
            }

            sub = sub + digito;

            soma = 0;
            i = 11;

            foreach(char c in sub) {
                soma = soma + int.Parse(c.ToString()) * i;
                i--;
            }

            digito = soma % 11;

            if(digito <= 2)
            {
                digito = 0;
            }else
            {
                digito = 11 - digito;
            }

            return cpf.EndsWith(digito.ToString());
        }
    }
}
