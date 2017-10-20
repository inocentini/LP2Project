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
        }

        public FormListaPagamentos(Conta c)
        {
            this.c = c;
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
                            dgvPagamentos.Rows.Add(p.C.Nome, pp.APagar, p.C.Vencimento.ToShortDateString(), pp.Pago ? "Pago" : "Não pago");
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
                                dgvPagamentos.Rows.Add(p.C.Nome, pp.APagar, p.C.Vencimento.ToShortDateString(), pp.Pago ? "Pago" : "Não pago");
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
    }
}
