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
    public partial class FormListaContas : Form
    {
        public FormListaContas()
        {
            InitializeComponent();
        }

        private void Fill()
        {
            ContaDAO db = new ContaDAO();

            List<Conta> lista = db.Listar();

            dgvContas.Rows.Clear();
            foreach (Conta c in lista)
            {
                dgvContas.Rows.Add(c.Id,c.Nome,c.Detalhes,c.Valor,c.Vencimento,c.Responsavel.Nome);
            }
        }

        private Conta selecao()
        {
            if (dgvContas.CurrentRow != null)
            {
                int indiceSelecao = dgvContas.SelectedCells[0].RowIndex;
                DataGridViewRow linhaSelecionada = dgvContas.Rows[indiceSelecao];
                ContaDAO db = new ContaDAO();
                return db.Read(int.Parse(linhaSelecionada.Cells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Selecione uma conta!", "Você deve selecionar uma conta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            FormCadastraConta cadastro = new FormCadastraConta();
            cadastro.ShowDialog(this);
            Fill();
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            Conta selecionada = selecao();
            if (selecionada != null)
            {
                FormCadastraConta editar = new FormCadastraConta(selecionada, true);
                editar.ShowDialog(this);
                Fill();
            }
        }

        private void bntDetalhes_Click(object sender, EventArgs e)
        {
            Conta selecionada = selecao();
            if (selecionada != null)
            {
                FormCadastraConta detalhes = new FormCadastraConta(selecionada, false);
                detalhes.ShowDialog(this);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Conta selecionada = selecao();
            if (selecionada != null)
            {
                ContaDAO db = new ContaDAO();
                db.Remover(selecionada.Id);
                Fill();
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            ContaDAO db = new ContaDAO();

            List<Conta> lista = db.Listar();


            dgvContas.Rows.Clear();
            foreach (Conta c in lista)
            {
                if (c.Nome.Contains(txtFiltrar.Text))
                {
                    dgvContas.Rows.Add(c.Id,c.Nome,c.Detalhes,c.Valor,c.Vencimento,c.Responsavel.Nome);
                }
            }
        }

        private void FromListaContas_Load(object sender, EventArgs e)
        {
            Fill();
        }
    }
}
