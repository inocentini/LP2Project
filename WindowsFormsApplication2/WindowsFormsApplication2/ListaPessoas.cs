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
    public partial class wPessoa : Form
    {
        public wPessoa()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            wCadastro cadastro = new wCadastro();
            cadastro.ShowDialog(this);
            Fill();
        }

        private void Fill()
        {
            IDatabase db = new DatabaseDict();
            List <Pessoa> lista = db.Listar();

            dgvPessoas.Rows.Clear();
            foreach(Pessoa p in lista)
            {
                dgvPessoas.Rows.Add(p.Cpf, p.Nome, p.Email, p.Telefone);
            }
        }

        private string selecao()
        {
            int indiceSelecao = dgvPessoas.SelectedCells[0].RowIndex;
            DataGridViewRow linhaSelecionada = dgvPessoas.Rows[indiceSelecao];
            return linhaSelecionada.Cells[0].Value.ToString();
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            wCadastro editar = new wCadastro(selecao(),true);
            editar.ShowDialog(this);
            Fill();
        }

        private void bntDetalhes_Click(object sender, EventArgs e)
        {
            wCadastro detalhes = new wCadastro(selecao(),false);
            detalhes.ShowDialog(this);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            IDatabase db = new DatabaseDict();
            db.Remover(selecao());
            Fill();
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            IDatabase db = new DatabaseDict();
            List<Pessoa> lista = db.Listar();

            dgvPessoas.Rows.Clear();
            foreach(Pessoa p in lista)
            {
                if (p.Nome.Contains(txtFiltrar.Text))
                {
                    dgvPessoas.Rows.Add(p.Cpf, p.Nome, p.Email, p.Telefone);
                }
            }
        }
    }
}
