using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseManager
{
    public class Login
    {
        //Declaração de variáveis.
        private string nome;
        private string senha;
        private Pessoa p;
        private bool admin = false;

        //Construtores.
        public Login()
        {

        }

        public Login(string nome, string senha, bool admin, Pessoa p)
        {
            this.Nome = nome;
            this.Senha = Hashing.Hash(senha,null);
            this.Admin = admin;
            this.P = p;
        }

        //Properties
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

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public bool Admin
        {
            get
            {
                return admin;
            }

            set
            {
                admin = value;
            }
        }

        public Pessoa P
        {
            get
            {
                return p;
            }

            set
            {
                p = value;
            }
        }
    }
}
