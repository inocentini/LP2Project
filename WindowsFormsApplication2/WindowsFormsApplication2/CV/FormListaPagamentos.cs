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
    public partial class FormListaPagamentos : Form
    {
        private bool nonResp;
        private Conta c;

        public bool NonResp
        {
            get
            {
                return nonResp;
            }

            set
            {
                nonResp = value;
            }
        }

        public FormListaPagamentos()
        {
            InitializeComponent();
            colPessoa.Visible = false;
            btnSituacao.Hide();
            dgvPagamentos.Height = 400;
        }

        public FormListaPagamentos(Conta c)
        {
            this.c = c;
            InitializeComponent();
            labFiltrarPagamento.Hide();
            txtFiltrar.Hide();
            pnlFiltro.Height = 54;
            pnlInfo.Height = 452;
        }

        private void FormListaPagamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Fill()
        {
            PagamentoDAO db = new PagamentoDAO();

            List<Pagamento> lista;
            if (nonResp)
            {
                 lista = db.ListarPessoa(Sessao.login.P.Cpf);
            }
            else
            {
                lista = new List<Pagamento>();
                lista.Add(db.Read(c.Id));
            }

            dgvPagamentos.Rows.Clear();

            bool situacao = new bool();

            if (cbbSituacao.SelectedIndex == 0)
            {
                foreach (Pagamento p in lista)
                {
                    if (p.C.Nome.Contains(txtFiltrar.Text))
                    {
                        foreach(PessoaPagamento pp in p.LPessoas)
                        {
                            dgvPagamentos.Rows.Add(p.C.Nome, pp.APagar, p.C.Vencimento.ToShortDateString(), pp.Pago ? "Pago" : "Não pago", p.C.Id, pp.P.Cpf);
                        }
                    }
                }
            }
            else
            {
                if (cbbSituacao.SelectedIndex == 1)
                {
                    situacao = true;
                }
                else
                {
                    situacao = false;
                }

                foreach (Pagamento p in lista)
                {
                    if (p.C.Nome.Contains(txtFiltrar.Text))
                    {
                        foreach (PessoaPagamento pp in p.LPessoas)
                        {
                            if(pp.Pago == situacao)
                            {
                                dgvPagamentos.Rows.Add(p.C.Nome, pp.APagar, p.C.Vencimento.ToShortDateString(), pp.Pago ? "Pago" : "Não pago", p.C.Id, pp.P.Cpf);
                            }
                        }
                    }
                }
            }
        }

        private void cbbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill();
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            Fill();
        }

        private void FormListaPagamentos_Load(object sender, EventArgs e)
        {
            cbbSituacao.SelectedIndex = 0;
        }

        private PessoaPagamento selecaoPessoaPagamento()
        {
            if (dgvPagamentos.CurrentRow != null)
            {
                int indiceSelecao = dgvPagamentos.SelectedCells[0].RowIndex;
                DataGridViewRow linhaSelecionada = dgvPagamentos.Rows[indiceSelecao];
                PagamentoDAO db = new PagamentoDAO();
                return db.Read(int.Parse(linhaSelecionada.Cells[5].Value.ToString()),linhaSelecionada.Cells[6].Value.ToString());
            }
            else
            {
                MessageBox.Show("Selecione um pagamento!", "Você deve selecionar um pagamento.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private Conta selecaoConta()
        {
            if (dgvPagamentos.CurrentRow != null)
            {
                int indiceSelecao = dgvPagamentos.SelectedCells[0].RowIndex;
                DataGridViewRow linhaSelecionada = dgvPagamentos.Rows[indiceSelecao];
                ContaDAO db = new ContaDAO();
                return db.Read(int.Parse(linhaSelecionada.Cells[5].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Selecione um pagamento!", "Você deve selecionar um pagamento.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btnSituacao_Click(object sender, EventArgs e)
        {
            PagamentoDAO db = new PagamentoDAO();

            PessoaPagamento pp = selecaoPessoaPagamento();
            Conta c = selecaoConta();

            if(pp != null && c != null)
            {
                if (pp.Pago)
                {
                    pp.Pago = false;
                }
                else
                {
                    pp.Pago = true;
                }
                db.Editar(pp, c);
            }
        }
    }
}
