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

        //Função estática para verificar CPF de uma pessoa
        public static bool verificaCPF(string cpf)
        {
            //Remove todos traços e pontos, além dos espaços
            cpf = cpf.Replace(@"-","");
            cpf = cpf.Replace(@".","");
            cpf.Trim();

            //Se o tamanho do CPF não for 11 ou se ele não for 11 números de 0 a 9
            if (cpf.Length != 11 || !Regex.IsMatch(cpf, @"[0-9]{11}"))
            {
                return false;
            }

            string sub = cpf.Substring(0, 9); //Cria uma substring com os 9 primeiros dígitos do CPF
            int soma = 0;
            int digito;
            int i = 10;

            //Faz o somatório, multiplica o primeiro número por 10, o segundo por 9, etc e soma tudo isso
            foreach(char c in sub)
            {
                soma = soma + (int.Parse(c.ToString()) * i);
                i--;
            }

            digito = soma % 11; //O primeiro dígito de verificação é o resto da soma por 11

            if(digito <= 2) //Se ele for menor ou igual a 2, é 0
            {
                digito = 0;
            }else //Senão, ele é o resultado de 11 subtraído por seu valor
            {
                digito = 11 - digito;
            }
            
            if(Char.Equals(digito,cpf[9])) //Se ele não for igual ao informado pelo usuário, retorna
            {
                return false;
            }

            sub = sub + digito; //Concatena o dígito na substring

            soma = 0;
            i = 11;

            foreach(char c in sub) { //Faz outro somatório, dessa vez o primeiro número é multiplicado por 11, o segundo por 10, etc.
                soma = soma + int.Parse(c.ToString()) * i;
                i--;
            }

            digito = soma % 11; //O segundo dígito de verificação é o resto da soma por 11

            if(digito <= 2) //Se ele for menor ou igual a 2, é 0
            {
                digito = 0;
            }else //Senão, ele é o resultado de 11 subtraído por seu valor
            {
                digito = 11 - digito;
            }

            return cpf.EndsWith(digito.ToString()); //Retorna true se o cpf informado tem seu último dígito igual a ele e false se não terminar
        }
    }
}
