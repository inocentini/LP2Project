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
    public partial class FormCadastraPessoa : Form
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

        public FormCadastraPessoa(Pessoa p, bool edicao) //objeto
        {
            Editar = edicao;
            InitializeComponent();
            setDTO(p);
            txtCPF.ReadOnly = true;
            txtCPF.TabStop = false;
            if (!Editar)
            {
                txtEmail.ReadOnly = true;
                txtEmail.TabStop = false;
                txtNome.ReadOnly = true;
                txtNome.TabStop = false;
                txtTelefone.ReadOnly = true;
                txtTelefone.TabStop = false;
                btnCancelar.Text = "Voltar";
                btnSalvar.Hide();
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
            }
            else
            {
                MessageBox.Show("Erro!","Verifique se todos os campos estão preenchidos!",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
    }
}
