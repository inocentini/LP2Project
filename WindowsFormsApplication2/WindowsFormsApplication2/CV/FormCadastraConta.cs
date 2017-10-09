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
    public partial class FormCadastraConta : Form
    {
        private bool editar = new bool();
        private int id = new int();
        private TextBox txtVencimento;

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

        public FormCadastraConta(Conta c, bool edicao) //objeto
        {
            Editar = edicao;
            InitializeComponent();
            setDTO(c);
            this.id = c.Id;
            if (!Editar)
            {
                txtNome.ReadOnly = true;
                txtDetalhes.ReadOnly = true;
                txtValor.ReadOnly = true;
                dtpVencimento.Hide();
                btnResponsavel.Hide();
                this.txtVencimento = new System.Windows.Forms.TextBox();
                txtVencimento.Size = dtpVencimento.Size;
                txtVencimento.Location = dtpVencimento.Location;
                txtVencimento.TabIndex = dtpVencimento.TabIndex;
                txtVencimento.Anchor = dtpVencimento.Anchor;
                txtVencimento.Text = dtpVencimento.Value.ToString();
                txtVencimento.ReadOnly = true;
                btnCancelar.Text = "Voltar";
                btnSalvar.Hide();
            }
        }

        public FormCadastraConta()
        {
            InitializeComponent();
        }

        private Conta getDTO()
        {
            Conta c = new Conta();
            c.Nome = txtNome.Text;
            c.Detalhes = txtDetalhes.Text;
            c.Valor = float.Parse(txtValor.Text);
            c.Vencimento = dtpVencimento.Value;
            PessoaDAO dbp = new PessoaDAO();
            c.Responsavel = dbp.Read(txtResponsavel.Text);

            return c;
        }

        private void setDTO(Conta c)
        {
            txtNome.Text = c.Nome;
            txtDetalhes.Text = c.Detalhes;
            txtValor.Text = c.Valor.ToString();
            dtpVencimento.Value = c.Vencimento;
            txtResponsavel.Text = c.Responsavel.Cpf;
        }

        private bool IsComplete()
        {
            if (txtNome.Text.Trim() == "" || txtDetalhes.Text.Trim() == "" || txtValor.Text.Trim() == "" || txtResponsavel.Text.Trim() == "" || dtpVencimento.Value.ToString().Trim() == "")
            {
                return false;
            }
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsComplete())
            {
                ContaDAO database = new ContaDAO();
                if (Editar)
                {
                    Conta c = getDTO();
                    c.Id = id;
                    database.Editar(c);
                    Dispose();
                }
                else
                {
                    database.Salvar(getDTO());
                    Dispose();
                }
            }
            else
            {
                MessageBox.Show("Erro!", "Verifique se todos os campos estão preenchidos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCadastraConta_Load(object sender, EventArgs e)
        {

        }

        private void btnResponsavel_Click(object sender, EventArgs e)
        {
            FormPesquisaPessoa pesquisaResponsavel = new FormPesquisaPessoa();
            pesquisaResponsavel.ShowDialog(this);
            string cpfresp = pesquisaResponsavel.Selecionado;
            if(cpfresp != "")
            {
                txtResponsavel.Text = cpfresp;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
