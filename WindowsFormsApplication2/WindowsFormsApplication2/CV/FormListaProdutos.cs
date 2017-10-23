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
    public partial class FormListaProdutos : Form
    {
        public FormListaProdutos()
        {
            InitializeComponent();
        }

        private void Fill()
        {
            //Método utilizado para listar todos os produtos na DataGridView
            ProdutoDAO db = new ProdutoDAO();

            List<Produto> lista = db.Listar();

            dgvProdutos.Rows.Clear();
            foreach (Produto p in lista)
            {
                dgvProdutos.Rows.Add(p.Id, p.Nome, p.Detalhes, p.Quantidade);
            }
        }

        private Produto selecao()
        {
            //Método utilizado para se obter um produto a partir da linha selecionada na DataGridView
            if (dgvProdutos.CurrentRow != null)
            {
                int indiceSelecao = dgvProdutos.SelectedCells[0].RowIndex;
                DataGridViewRow linhaSelecionada = dgvProdutos.Rows[indiceSelecao];
                ProdutoDAO db = new ProdutoDAO();
                return db.Read(int.Parse(linhaSelecionada.Cells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Selecione um produto!", "Você deve selecionar um produto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            //Evento do botão "Adicionar"
            FormCadastraProduto cadastro = new FormCadastraProduto();
            cadastro.ShowDialog(this);
            Fill();
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "editar"
            Produto selecionado = selecao();
            if (selecionado != null)
            {
                FormCadastraProduto editar = new FormCadastraProduto(selecionado, true);
                editar.ShowDialog(this);
                Fill();
            }
        }

        private void bntDetalhes_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "detalhes"
            Produto selecionado = selecao();
            if (selecionado != null)
            {
                FormCadastraProduto detalhes = new FormCadastraProduto(selecionado, false);
                detalhes.ShowDialog(this);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "remover"
            Produto selecionado = selecao();
            if (selecionado != null)
            {
                ProdutoDAO db = new ProdutoDAO();
                db.Remover(selecionado.Id);
                Fill();
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            //Evento que filtra os produtos mostrados conforme é digitado no campo de texto "txtFiltrar", tem funcionamento semelhante ao "Fill"
            ProdutoDAO db = new ProdutoDAO();

            List<Produto> lista = db.Listar();


            dgvProdutos.Rows.Clear();
            foreach (Produto p in lista)
            {
                if (p.Nome.Contains(txtFiltrar.Text))
                {
                    dgvProdutos.Rows.Add(p.Id, p.Nome, p.Detalhes, p.Quantidade);
                }
            }
        }

        private void FromListaProdutos_Load(object sender, EventArgs e)
        {
            //Evento de carregamento do form, chama o método "Fill"
            Fill();
        }

        private void FormListaProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Evento chamado no fechamento do form, apenas o esconde ao invés de realizar um "Dispose"
            this.Hide();

            //Cancela o evento padrão de fechamento ("Dispose")
            e.Cancel = true;
        }
    }
}
