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
    public partial class FormPesquisaConta : Form
    {
        private Conta selecionado;

        public Conta Selecionado
        {
            get
            {
                return selecionado;
            }

            set
            {
                this.selecionado = value;
            }
        }

        public FormPesquisaConta()
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
                dgvContas.Rows.Add(c.Id, c.Nome, "R$" + c.Valor, c.Vencimento.ToShortDateString(), c.Responsavel.Nome);
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            ContaDAO db = new ContaDAO();

            List<Conta> lista;

            lista = db.Listar();

            dgvContas.Rows.Clear();
            foreach (Conta c in lista)
            {
                if (c.Nome.Contains(txtFiltrar.Text))
                {
                    dgvContas.Rows.Add(c.Id, c.Nome, "R$" + c.Valor, c.Vencimento.ToShortDateString(), c.Responsavel.Nome);
                }
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Selecionado = selecao();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dgvContas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnviar.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void dgvContas_DoubleClick(object sender, EventArgs e)
        {
            btnEnviar.PerformClick();
        }

        private void FormPesquisaConta_Load(object sender, EventArgs e)
        {
            Fill();
        }
    }
}
