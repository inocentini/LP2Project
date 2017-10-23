using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseManager
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private Login GetDTO()
        {
            //Método utilizado para se obter um login a partir do que é digitado nos campos
            Login l = new Login();
            l.Nome = txtUser.Text;
            l.Senha = txtSenha.Text;
            return l;
        }

        private bool IsComplete()
        {
            //Método utilizado para verificar se algum dos campos está em branco
            if (txtUser.Text.Trim() == "" || txtSenha.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "Entrar"
            if (IsComplete())
            {
                LoginDAO database = new LoginDAO();

                Login l = GetDTO();
                if (database.Login(l))
                {
                    database.SetSession(l.Nome);
                    FormPrincipal fp = new FormPrincipal();
                    this.Hide();
                    fp.ShowDialog(this);
                    try
                    {
                        this.Show();
                        txtUser.Text = "";
                        txtSenha.Text = "";
                    }
                    catch (System.ObjectDisposedException)
                    {
                        //Trata a exceção de quando o usuário fecha a aplicação principal ao invés de deslogar, para que não se volte ao login quando ele já foi descartado
                    }
                }
                else
                {
                    MessageBox.Show("Erro! Login ou senha errados!", "Tente novamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Erro! Login ou senha incompletos!", "Informe seu login e sua senha.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "Novo"
            FormCadastraLogin newlogin = new FormCadastraLogin();
            newlogin.ShowDialog(this);
        }
    }
}
