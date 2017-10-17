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
    public partial class FormAlteraSenha : Form
    {
        private Login l = new Login();

        public FormAlteraSenha()
        {
            InitializeComponent();
            l = Sessao.login;
        }

        public FormAlteraSenha(Login l)
        {
            this.l = l;
        }

        private void FormAlteraSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsComplete()
        {
            if(txtNovaSenha.Text.Trim() == "" || txtSenhaAtual.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            LoginDAO db = new LoginDAO();

            if (IsComplete())
            {
                l.Senha = txtSenhaAtual.Text;

                if (db.Login(l))
                {
                    l.Senha = txtNovaSenha.Text;
                    db.Editar(l);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro! Senha inválida!", "Tente novamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Erro! Os campos não podem estar vazios!", "Tente novamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
