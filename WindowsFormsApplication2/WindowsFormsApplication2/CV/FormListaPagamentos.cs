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
        private bool nonResp; //Atributo utilizado para se definir se quem está vendo os pagamentos vai ter a possibilidade de confirmá-los ou não
        private Conta c; //Atributo utilizado para armazenar a conta se eles forem listados para uma conta

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
            //Construtor padrão, utilizado para se listar os pagamentos do usuário
            InitializeComponent();
            colPessoa.Visible = false;
            btnSituacao.Hide();
            dgvPagamentos.Height = 400;
        }

        public FormListaPagamentos(Conta c)
        {
            //Construtor utilizado para se listar os pagamentos de uma conta em questão
            this.c = c;
            InitializeComponent();
            labFiltrarPagamento.Hide();
            txtFiltrar.Hide();
            pnlFiltro.Height = 54;
            pnlInfo.Height = 462;
            colConta.Visible = false;
        }

        private void FormListaPagamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Evento chamado no fechamento do form, apenas o esconde ao invés de realizar um "Dispose"
            this.Hide();

            //Cancela o evento padrão de fechamento ("Dispose")
            e.Cancel = true;
        }

        private void Fill()
        {
            //Método utilizado para preencher a DataGridView
            PagamentoDAO db = new PagamentoDAO();

            List<Pagamento> lista;
            if (nonResp)
            {
                //Se não for responsável ou administrador, lista todos os pagamentos da pessoa logada
                 lista = db.ListarPessoa(Sessao.login.P.Cpf);
            }
            else
            {
                //Se for responsável ou administrador, lista todos os pagamentos de uma conta em questão
                lista = new List<Pagamento>();
                lista.Add(db.Read(c.Id));
            }

            dgvPagamentos.Rows.Clear();

            //Variável utilizada para definir se está checada a opção "mostrar tudo", "pagos" ou "não pagos"
            bool situacao = new bool();

            if (cbbSituacao.SelectedIndex == 0)
            {
                //Se a opção escolhida for "mostrar tudo", lista todos os pagamentos
                foreach (Pagamento p in lista)
                {
                    if (p.C.Nome.Contains(txtFiltrar.Text))
                    {
                        foreach(PessoaPagamento pp in p.LPessoas)
                        {
                            dgvPagamentos.Rows.Add(pp.P.Nome,p.C.Nome, pp.APagar, p.C.Vencimento.ToShortDateString(), pp.Pago ? "Pago" : "Não pago");
                        }
                    }
                }
            }
            else
            {
                //Senão, define "situacao" como true ou false conforme "pago" ou "não pago" estiverem selecionados
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
                                dgvPagamentos.Rows.Add(pp.P.Nome, p.C.Nome, pp.APagar, p.C.Vencimento.ToShortDateString(), pp.Pago ? "Pago" : "Não pago");
                            }
                        }
                    }
                }
            }
        }

        private void cbbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se a opção da ComboBox de situação do pagamento for modificada, chama esse evento para realizar o método "Fill"
            Fill();
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            //Se for digitado algum texto no campo de busca, chama esse evento para realizar o método "Fill"
            Fill();
        }

        private void FormListaPagamentos_Load(object sender, EventArgs e)
        {
            //Ao iniciar o Form, define o índice selecionado no ComboBox de situação como o primeiro ("Mostrar tudo")
            cbbSituacao.SelectedIndex = 0;
        }

        private PessoaPagamento selecaoPessoaPagamento()
        {
            //Método utilizado para se obter um objeto "PessoaPagamento" a partir da seleção da DataGridView
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
            //Método utilizado para se obter uma conta a partir da seleção da DataGridView
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
            /*//Evento de clique no botão para mudar a situação
            PagamentoDAO db = new PagamentoDAO();

            PessoaPagamento pp = selecaoPessoaPagamento();
            Conta c = selecaoConta();

            //Se há um pagamento válido de uma conta válida, define o valor como "pago"/"não pago" dependendo da situação anterior e realiza uma edição
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
            }*/
        }
    }
}
