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
        private Conta selecionado; //Atributo que define a conta selecionada

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
            //Método que preenche a DataGridView com todas as contas disponíveis
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
            //Evento chamado ao se digitar algo no campo "txtFiltrar", é semelhante ao "Fill"
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
            //Método que obtém uma Conta a partir da seleção do DataGridView
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
            //Evento de clique no botão "Enviar"
            Selecionado = selecao();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "Cancelar"
            Dispose();
        }

        private void dgvContas_KeyDown(object sender, KeyEventArgs e)
        {
            //Evento que verifica se a tecla "Enter" é pressionada com uma linha selecionada na DataGridView
            if (e.KeyCode == Keys.Enter)
            {
                btnEnviar.PerformClick();

                //Altera os argumentos da função para que não possa ocorrer repetidas vezes o evento ao se apertar a tecla rapidamente
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void dgvContas_DoubleClick(object sender, EventArgs e)
        {
            //Evento que verifica se ocorre um clique duplo em uma linha na DataGridView
            btnEnviar.PerformClick();
        }

        private void FormPesquisaConta_Load(object sender, EventArgs e)
        {
            //Evento chamado no carregamento do Form, chama o método "Fill"
            Fill();
        }
    }
}
