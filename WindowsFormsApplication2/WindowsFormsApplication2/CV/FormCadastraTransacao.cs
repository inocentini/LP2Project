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
    public partial class FormCadastraTransacao : Form
    {
        Dictionary<string, ProdutoTransacao> dictProdutosDgv = new Dictionary<string, ProdutoTransacao>();

        public FormCadastraTransacao()
        {
            //Construtor padrão utilizado na adição de uma nova transação
            InitializeComponent();
        }

        private Transacao getDTO()
        {
            //Método utilizado para se obter uma transação a partir das informações digitadas e dos produtos escolhidos
            Transacao cv = new Transacao();

            //Cada produto escolhido na DGV (que está no "DictProdutosDgv") é adicionado numa lista e a lista é passada para a transação
            List<ProdutoTransacao> lproduto = new List<ProdutoTransacao>();
            foreach(KeyValuePair<string,ProdutoTransacao> pv in dictProdutosDgv)
            {
                ProdutoTransacao pve = new ProdutoTransacao(pv.Value.Prod, pv.Value.Quantidade, 0);
                lproduto.Add(pve);
            }

            cv.Lista = lproduto;

            return cv;
        }

        private ProdutoTransacao getDTOProd()
        {
            ProdutoTransacao p = new ProdutoTransacao();

            p.Prod = txtProduto.Text;
            p.Quantidade = double.Parse(txtQuantidade.Text);

            return p;
        }

        bool IsCompleteForm()
        {
            if(dictProdutosDgv.Count==0)
            {
                return false;
            }
            return true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (IsCompleteProd())
            {
                ProdutoTransacao p = getDTOProd();
                if (dictProdutosDgv.ContainsKey(p.Prod))
                {
                    DialogResult resp = MessageBox.Show("Esse produto já está na lista! Você tem certeza que deseja substituir sua quantidade?", "Produto repetido", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if(resp == DialogResult.Yes)
                    {
                        dictProdutosDgv[p.Prod] = p;
                        dgvProdutos.Rows.Clear();
                        Fill();
                    }
                }
                else
                {
                    dictProdutosDgv.Add(p.Prod, p);
                    dgvProdutos.Rows.Add(p.Prod, p.Quantidade, "Remover");
                }

                txtProduto.Clear();
                txtQuantidade.Text = "0";
            }
        }

        bool IsCompleteProd()
        {
            //Método utilizado para verificar se o produto que se está tentando adicionar é válido e se a quantidade não é 0
            if((txtProduto.Text.Trim()!="")&&(txtQuantidade.Text != "0,00")){
                return true;
            }else
            {
                return false;
            }
        }

        private void Fill()
        {
            //Método utilizado para preencher a DataGridView de produtos da transação com os produtos do dictionary "dictProdutosDgv"
            foreach(KeyValuePair<string,ProdutoTransacao> p in dictProdutosDgv)
            {
                dgvProdutos.Rows.Add(p.Key, p.Value.Quantidade, "Remover");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Evento do botão "Salvar" da transação
            if (IsCompleteForm())
            {
                //Se tudo estiver completo
                CompraDAO database = new CompraDAO();
                Transacao t = getDTO();
                database.Salvar(t);
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Evento do botão "cancelar"
            Dispose();
        }

        private void txtNomeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evento que verifica se a tecla "Enter" é pressionada em um campo de texto referente ao produto, se for, clica no botão "Adicionar"
                btnAdicionar.PerformClick();

                //Altera os argumentos da função para que não possa ocorrer repetidas vezes o evento ao se apertar a tecla rapidamente
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                dictProdutosDgv.Remove(dgvProdutos.Rows[e.RowIndex].Cells[0].Value.ToString());
                dgvProdutos.Rows.Remove(dgvProdutos.Rows[e.RowIndex]);
            }
        }
    }
}