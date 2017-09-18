﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class wCadastro : Form
    {
        private bool editar = new bool();

        public bool Editar
        {
            get
            {
                return editar;
            }

            set
            {
                editar = value;
            }
        }

        public wCadastro(Pessoa p, bool edicao) //objeto
        {
            Editar = edicao;
            InitializeComponent();
            setDTO(p);
            if (Editar)
            {
                txtCPF.ReadOnly = true;
                txtCPF.TabIndex = btnCancelar.TabIndex + 1;
            }
            else
            {
                txtCPF.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtNome.ReadOnly = true;
                txtTelefone.ReadOnly = true;
                btnCancelar.Text = "Voltar";
                btnSalvar.Hide();
            }
        }

        public wCadastro()
        {
            InitializeComponent();
        }

        private Pessoa getDTO()
        {
            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.Cpf = txtCPF.Text;
            p.Email = txtEmail.Text;
            p.Telefone = txtTelefone.Text;

            return p;
        }

        private void setDTO(Pessoa p)
        {
            txtNome.Text = p.Nome;
            txtCPF.Text = p.Cpf;
            txtEmail.Text = p.Email;
            txtTelefone.Text = p.Telefone;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsComplete())
            {
                IDatabase database = new DatabaseDict();
                if (Editar)
                {
                    database.Editar(getDTO());
                    Dispose();
                }
                else
                {
                    Pessoa p = getDTO();
                    if (database.Read(p.Cpf) == null)
                    {
                        database.Salvar(getDTO());
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("O CPF já está cadastrado!", "Erro: utilize um CPF diferente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }else
            {
                MessageBox.Show("Escreve direito vacilão","Menssagem para vacilão",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool IsComplete()
        {
            if(txtCPF.Text.Trim() == "" || txtNome.Text.Trim() =="" || txtEmail.Text.Trim() =="" || txtTelefone.Text.Trim()=="")
            {
                return false;
            }
            return true;
        }

        private void wCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
