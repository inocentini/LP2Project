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
    public partial class FormNovoLogin : Form
    {
        public FormNovoLogin()
        {
            InitializeComponent();
        }

        public FormNovoLogin(Pessoa p, Login l)
        {
            InitializeComponent();
            setDTO(p);
            setDTOL(l);
            txtCPF.ReadOnly = true;
            txtCPF.TabIndex = btnCancelar.TabIndex + 1;

        }

        private Login getDTOL()
        {
            Login l = new Login();
            l.Nome = txtUser.Text;
            l.Senha = maskedTextBox2.Text;

            return l;
        }

        private void setDTOL(Login l)
        {
            txtUser.Text = l.Nome;
            maskedTextBox2.Text = l.Senha;
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
            if (txtCPF.Text.Trim() == "" || txtNome.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtTelefone.Text.Trim() == "" || txtUser.Text.Trim() == "" || maskedTextBox2.Text.Trim() == "")
            {
                txtCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
                txtNome.TextMaskFormat = MaskFormat.IncludeLiterals;
                txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
                txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
                txtUser.TextMaskFormat = MaskFormat.IncludeLiterals;
                maskedTextBox2.TextMaskFormat = MaskFormat.IncludeLiterals;
                return false;
            }
            txtCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtNome.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtUser.TextMaskFormat = MaskFormat.IncludeLiterals;
            maskedTextBox2.TextMaskFormat = MaskFormat.IncludeLiterals;
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsComplete())
            {
                LoginDAO database = new LoginDAO();
                PessoaDAO databasep = new PessoaDAO();

                Login l = getDTOL();
                Pessoa p = getDTO();
                
                database.Salvar(l);
                databasep.Salvar(p);
                Dispose();
            }
            else
            {
                MessageBox.Show("Erro!", "Campo inválido ou vazio.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
