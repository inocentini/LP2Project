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

        public bool verificaCPF(string cpf)
        {
            cpf.Trim();
            if (cpf.Length != 11 && System.Text.RegularExpressions.Regex.IsMatch(cpf, @"[^0-9]"))
            {
                return false;
            }

            string sub = cpf.Substring(0, 9);
            int soma = 0;
            int digito;

            for(int i = 10; i >= 2; i++)
            {
                soma = soma + int.Parse(sub[i].ToString()) * i;
            }

            digito = soma % 11;

            if(digito <= 2)
            {
                digito = 0;
            }else
            {
                digito = 11 - digito;
            }

            if(digito != cpf.Substring(9, 1)[0])
            {
                return false;
            }

            sub = sub + digito;

            soma = 0;

            for(int i = 11; i >= 2; i++)
            {
                soma = soma + int.Parse(sub[i].ToString()) * i;
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
