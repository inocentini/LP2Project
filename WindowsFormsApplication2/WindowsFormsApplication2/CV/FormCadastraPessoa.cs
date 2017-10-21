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
    public partial class FormCadastraPessoa : Form
    {
        private bool editar = false;

        public FormCadastraPessoa(Pessoa p, bool edicao) //objeto
        {
            editar = edicao;
            InitializeComponent();
            setDTO(p);
            txtCPF.ReadOnly = true;
            txtCPF.TabStop = false;
            if (!editar)
            {
                this.Text = "Visualizando informações de " + p.Nome;
                txtEmail.ReadOnly = true;
                txtEmail.TabStop = false;
                txtNome.ReadOnly = true;
                txtNome.TabStop = false;
                txtTelefone.ReadOnly = true;
                txtTelefone.TabStop = false;
                btnCancelar.Text = "Voltar";
                btnSalvar.Hide();
            }
            else
            {
                this.Text = "Editando informações de " + p.Nome;
            }
        }

        public FormCadastraPessoa()
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
                PessoaDAO database = new PessoaDAO();
                if (editar)
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
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos!", "Erro!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool IsComplete()
        {
            txtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtNome.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtEmail.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtCPF.Text.Trim() == "" || txtNome.Text.Trim() =="" || txtEmail.Text.Trim() =="" || txtTelefone.Text.Trim()=="")
            {
                txtCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
                txtNome.TextMaskFormat = MaskFormat.IncludeLiterals;
                txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
                txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
                return false;
            }
            txtCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtNome.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
            return true;
        }

        private void FormCadastraPessoa_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
