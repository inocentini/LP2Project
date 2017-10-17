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
    public partial class FormCadastraLogin : Form
    {
        private bool editar = false;

        public FormCadastraLogin()
        {
            InitializeComponent();
        }

        public FormCadastraLogin(Login l)
        {
            InitializeComponent();

            this.MinimumSize = new Size(this.Width, 280);
            this.MaximumSize = new Size(this.Width, 280);
            this.Height = 300;
            btnSalvar.Location = new Point(btnSalvar.Location.X, 170);
            btnCancelar.Location = new Point(btnCancelar.Location.X, 170);

            setDTO(l.P);
            setDTOL(l);
            txtCPF.ReadOnly = true;
            txtUser.ReadOnly = true;
            txtSenha.Visible = false;
            labSenha.Visible = false;
            gbNovoLogin.Text = "Modificando informações";

            editar = true;
        }

        private Login getDTOL()
        {
            Login l = new Login();
            l.Nome = txtUser.Text;
            l.Senha = txtSenha.Text;

            return l;
        }

        private void setDTOL(Login l)
        {
            txtUser.Text = l.Nome;
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
        private bool IsComplete()
        {
            txtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtNome.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtEmail.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtCPF.Text.Trim() == "" || txtNome.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtTelefone.Text.Trim() == "" || txtUser.Text.Trim() == "" || txtSenha.Text.Trim() == "")
            {
                txtCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
                txtNome.TextMaskFormat = MaskFormat.IncludeLiterals;
                txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
                txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
                txtUser.TextMaskFormat = MaskFormat.IncludeLiterals;
                txtSenha.TextMaskFormat = MaskFormat.IncludeLiterals;
                return false;
            }
            txtCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtNome.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtUser.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSenha.TextMaskFormat = MaskFormat.IncludeLiterals;
            return true;
        }

        private bool IsCompleteEdicao()
        {
            txtNome.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtEmail.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtNome.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtTelefone.Text.Trim() == "")
            {
                txtNome.TextMaskFormat = MaskFormat.IncludeLiterals;
                txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
                txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
                return false;
            }
            txtNome.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                if (IsCompleteEdicao())
                {
                    PessoaDAO databasep = new PessoaDAO();

                    Pessoa p = getDTO();

                    databasep.Editar(p);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Campo inválido ou vazio.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (IsComplete())
                {
                    LoginDAO database = new LoginDAO();
                    PessoaDAO databasep = new PessoaDAO();

                    Login l = getDTOL();
                    Pessoa p = getDTO();

                    l.P = p;

                    if (database.HasAdmin())
                    {
                        MessageBox.Show("Bem vindo ao House Manager! Como primeiro usuário, você terá previlégios de administrador. Para gerenciar os administradores, consulte a área administrativa.", "Bem vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        l.Admin = true;
                    }
                    database.Salvar(l);
                    databasep.Salvar(p);
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Campo inválido ou vazio.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void FormCadastraLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editar)
            {
                this.Hide();
                e.Cancel = true;
            }
            else
            {
                Dispose();
            }
        }
    }
}
