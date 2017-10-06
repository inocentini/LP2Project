using System;
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
    public partial class wLogin : Form
    {
        public wLogin()
        {
            InitializeComponent();
        }

        private Login GetDTO()
        {
            Login l = new WindowsFormsApplication2.Login();
            l.Nome = txtUser.Text;
            l.Senha = txtSenha.Text;
            return l;
        }

        private bool IsComplete()
        {
            if (txtUser.Text.Trim() == "" || txtSenha.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (IsComplete())
            {
                LoginDAO database = new LoginDAO();

                Login l = GetDTO();
                if (database.Login(l))
                {
                    wPessoa wp = new wPessoa();
                    this.Hide();
                    wp.ShowDialog();
                    Dispose();
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
            FormNovoLogin newlogin = new FormNovoLogin();
            newlogin.ShowDialog(this);
            /*if (IsComplete())
            {
                LoginDAO database = new LoginDAO();

                Login l = GetDTO();
                database.Salvar(l);
            }
            else
            {
                MessageBox.Show("Erro! Login ou senha incompletos!", "Informe seu login e sua senha.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
    }
}
