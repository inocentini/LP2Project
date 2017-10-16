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
    public partial class FormCadastraTransacao : Form
    {
        private bool editar = new bool();
        private int id = new int();
        private Dictionary<int, ProdutoVenda> dictProdutosDgv = new Dictionary<int, ProdutoVenda>();
        private Dictionary<int, ProdutoVenda> dictProdutosAnteriores = new Dictionary<int, ProdutoVenda>();
        private Produto prod;
        private RadioButton escolhido = new RadioButton();
        private bool reescolha = false;

        public FormCadastraTransacao()
        {
            InitializeComponent();
        }

        public FormCadastraTransacao(CompraEVenda cv, bool edicao) //objeto
        {
            Editar = edicao;
            InitializeComponent();
            setDTO(cv);
            this.id = cv.Id;

            if (!Editar)
            {
                txtNomeProduto.Hide();
                txtValor.ReadOnly = true;
                txtValor.TabStop = false;
                txtValor.Increment = 0;
                txtValor.Controls[0].Enabled = false;
                txtQuantidade.Hide();
                txtDescricao.Hide();
                rdbCompra.Enabled = false;
                rdbUso.Enabled = false;
                dtpData.Hide();
                btnAdd.Hide();
                btnRemover.Hide();
                txtData.Visible = true;
                dgvProdutos.Height = 325;
                dgvProdutos.Top = 145;
                dgvProdutos.ClearSelection();
                dgvProdutos.DefaultCellStyle.SelectionBackColor = dgvProdutos.DefaultCellStyle.BackColor;
                dgvProdutos.DefaultCellStyle.SelectionForeColor = dgvProdutos.DefaultCellStyle.ForeColor;
                txtData.Text = dtpData.Value.Date.ToShortDateString();
                btnCancelar.Text = "Voltar";
                btnSalvar.Hide();
            }
        }

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

        private CompraEVenda getDTO()
        {
            CompraEVenda cv = new CompraEVenda();
            cv.Data = dtpData.Value;
            cv.Valor = double.Parse(txtValor.Text);
            cv.Compra = rdbCompra.Checked;

            List<ProdutoVenda> lproduto = new List<ProdutoVenda>();
            foreach(KeyValuePair<int,ProdutoVenda> pv in dictProdutosDgv)
            {
                ProdutoVenda pve = new ProdutoVenda(pv.Value.Prod, pv.Value.Quantidade);
                lproduto.Add(pve);
            }

            cv.Lista = lproduto;

            return cv;
        }

        private void setDTO(CompraEVenda cv)
        {
            dtpData.Value = cv.Data;
            txtValor.Text = cv.Valor.ToString();
            if (cv.Compra)
            {
                rdbCompra.Checked = true;
            }
            else
            {
                rdbUso.Checked = true;
            }
            foreach(ProdutoVenda pv in cv.Lista)
            {
                dictProdutosDgv.Add(pv.Prod.Id, pv);
                int id = pv.Prod.Id;
                dictProdutosAnteriores.Add(id, new ProdutoVenda(pv.Prod,pv.Quantidade));
            }
            Fill();
        }

        bool IsCompleteForm()
        {
            if(dictProdutosDgv.Count==0||dtpData.Value.ToString().Trim() == "" || txtValor.ToString().Trim() == "")
            {
                return false;
            }
            return true;
        }

        bool IsCompleteProd()
        {
            if((prod!=null)&&(txtQuantidade.Text != "0,00")){
                return true;
            }else
            {
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsCompleteProd())
            {
                if (dictProdutosDgv.ContainsKey(prod.Id))
                {

                    dgvProdutos.Rows.Clear();
                    dictProdutosDgv[prod.Id].Quantidade += double.Parse(txtQuantidade.Text);
                    txtQuantidade.Text = "0";
                    Fill();
                }
                else
                {
                    ProdutoVenda prodvenda = new ProdutoVenda(prod, double.Parse(txtQuantidade.Text));
                    dgvProdutos.Rows.Add(prod.Id, prod.Nome, txtQuantidade.Text);
                    dictProdutosDgv.Add(prod.Id, prodvenda);
                    txtQuantidade.Text = "0";
                }
                AtualizaMaximo();
            }
            else
            {
                MessageBox.Show("Verifique se o produto foi encontrado e se a quantidade foi preenchida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Fill()
        {
            foreach(KeyValuePair<int,ProdutoVenda> p in dictProdutosDgv)
            {
                dgvProdutos.Rows.Add(p.Key, p.Value.Prod.Nome, p.Value.Quantidade);
            }
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            ProdutoDAO db = new ProdutoDAO();
            prod = db.Read(txtNomeProduto.Text);
            if(prod != null)
            {
                txtDescricao.Text = prod.Detalhes;
            }else
            {
                txtDescricao.Text = "";
            }
            AtualizaMaximo();
        }

        private void rdbCompra_CheckedChanged(object sender, EventArgs e)
        {
            if ((!reescolha) && (dgvProdutos.Rows.Count != 0))
            {
                reescolha = true;
                if (escolhido.Checked)
                {
                    DialogResult resultado = MessageBox.Show("Mudar o tipo de transação resetará os produtos adicionados, continuar mesmo assim?", "Você tem certeza disto?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (resultado == DialogResult.OK)
                    {
                        dictProdutosDgv.Clear();
                        dgvProdutos.Rows.Clear();
                        escolhido = rdbCompra.Checked ? rdbCompra : rdbUso;
                    }
                    else if (resultado == DialogResult.Cancel)
                    {
                        rdbCompra.Checked = false;
                        rdbUso.Checked = false;
                        if (escolhido.Name == "rdbCompra")
                        {
                            rdbUso.Checked = true;
                        }
                        else
                        {
                            rdbCompra.Checked = true;
                        }
                    }
                }
                reescolha = false;
                escolhido = rdbCompra.Checked ? rdbCompra : rdbUso;
                AtualizaMaximo();
            }
            else if (!reescolha)
            {
                AtualizaMaximo();
            }
        }

        private void AtualizaMaximo()
        {
            txtQuantidade.Text = "0";
            if(prod != null)
            {
                if (rdbCompra.Checked)
                {
                    txtQuantidade.Maximum = 99999;
                }
                else if (rdbUso.Checked)
                {
                    if (dictProdutosDgv.ContainsKey(prod.Id))
                    {
                        if (dictProdutosAnteriores.ContainsKey(prod.Id))
                        {
                            txtQuantidade.Maximum = decimal.Parse(((prod.Quantidade + dictProdutosAnteriores[prod.Id].Quantidade) - dictProdutosDgv[prod.Id].Quantidade).ToString());
                        }
                        else
                        {
                            txtQuantidade.Maximum = decimal.Parse((prod.Quantidade - dictProdutosDgv[prod.Id].Quantidade).ToString());
                        }
                    }
                    else
                    {
                        txtQuantidade.Maximum = decimal.Parse(prod.Quantidade.ToString());
                    }
                }
            }
            else
            {
                txtQuantidade.Maximum = 0;
            }
            txtQuantidade.Minimum = 0;
            txtQuantidade.Text = "0";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow != null)
            {
                foreach (DataGridViewRow row in dgvProdutos.SelectedRows)
                {
                    if (Editar)
                    {
                        dictProdutosDgv[int.Parse(row.Cells[0].Value.ToString())].Quantidade = 0;
                    }
                    else
                    {
                        dictProdutosDgv.Remove(int.Parse(row.Cells[0].Value.ToString()));
                    }
                    dgvProdutos.Rows.Remove(row);
                }
                AtualizaMaximo();
            }
            else
            {
                MessageBox.Show("Selecione uma transação!", "Você deve selecionar uma transação.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsCompleteForm())
            {
                CompraEVendaDAO database = new CompraEVendaDAO();
                CompraEVenda cv = getDTO();
                if (Editar)
                {
                    cv.Id = id;
                    database.Editar(cv,dictProdutosAnteriores);
                    Dispose();
                }
                else
                {
                    database.Salvar(cv);
                    Dispose();
                }
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dtpData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtNomeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
