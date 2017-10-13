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
    public partial class FormListaProdutos : Form
    {
        public FormListaProdutos()
        {
            InitializeComponent();
        }

        private void Fill()
        {
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
            FormCadastraProduto cadastro = new FormCadastraProduto();
            cadastro.ShowDialog(this);
            Fill();
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
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
            Produto selecionado = selecao();
            if (selecionado != null)
            {
                FormCadastraProduto detalhes = new FormCadastraProduto(selecionado, false);
                detalhes.ShowDialog(this);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
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
            Fill();
        }

        private void FormListaProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
