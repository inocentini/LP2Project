﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseManager
{
    public class ProdutoTransacao
    {
        //Declaração de variáveis.
        private string prod = "";
        private double quantidade = new double();
        private double valor = new double();

        //Construtores.
        public ProdutoTransacao(string prod, double quantidade, double valor)
        {
            this.Prod = prod;
            this.Quantidade = quantidade;
            this.Valor = valor;
        }

        public ProdutoTransacao()
        {

        }

        //Properties.
        public string Prod
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
    }
}
