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
    public partial class FormCadastraConta : Form
    {
        private bool editar = new bool();
        private int id = new int();
        private Pessoa resp = new Pessoa();

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

        public FormCadastraConta(Conta c, bool edicao, bool nonAdmin)
        {
            Editar = edicao;
            InitializeComponent();
            setDTO(c);
            this.id = c.Id;
            if (!Editar)
            {
                this.Text = "Visualizando conta " + c.Nome;
                txtNome.ReadOnly = true;
                txtNome.TabStop = false;
                txtDetalhes.ReadOnly = true;
                txtDetalhes.TabStop = false;
                txtValor.ReadOnly = true;
                txtValor.TabStop = false;
                txtValor.Increment = 0;
                txtValor.Controls[0].Enabled = false;
                dtpVencimento.Hide();
                btnResponsavel.Hide();
                txtVencimento.Visible = true;
                txtVencimento.Text = dtpVencimento.Value.ToShortDateString();
                btnCancelar.Text = "Voltar";
                btnSalvar.Hide();
            }
            else
            {
                this.Text = "Editando conta " + c.Nome;
                if (nonAdmin)
                {
                    btnResponsavel.Hide();
                }
            }
        }

        public FormCadastraConta(bool nonAdmin)
        {
            InitializeComponent();
            if (nonAdmin)
            {
                btnResponsavel.Hide();
                resp = Sessao.login.P;
                txtResponsavel.Text = Sessao.login.P.Nome;
            }
        }

        private Conta getDTO()
        {
            Conta c = new Conta();
            c.Nome = txtNome.Text;
            c.Detalhes = txtDetalhes.Text;
            c.Valor = double.Parse(txtValor.Text);
            c.Vencimento = dtpVencimento.Value;
            c.Responsavel = resp;

            return c;
        }

        private void setDTO(Conta c)
        {
            txtNome.Text = c.Nome;
            txtDetalhes.Text = c.Detalhes;
            txtValor.Text = c.Valor.ToString();
            dtpVencimento.Value = c.Vencimento;
            txtResponsavel.Text = c.Responsavel.Nome;
            PessoaDAO dbp = new PessoaDAO();
            resp = dbp.Read(c.Responsavel.Cpf);
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
                Conta c = getDTO();
                if (Editar)
                {
                    c.Id = id;
                    database.Editar(c);
                    Dispose();
                }
                else
                {
                    database.Salvar(c);
                    Dispose();
                }
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResponsavel_Click(object sender, EventArgs e)
        {
            FormPesquisaPessoa pesquisaResponsavel = new FormPesquisaPessoa();
            pesquisaResponsavel.ShowDialog(this);
            resp = pesquisaResponsavel.Selecionado;
            if(resp != null)
            {
                txtResponsavel.Text = resp.Nome;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
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
