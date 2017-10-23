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
    public partial class FormPesquisaPessoa : Form
    {
        private Pessoa selecionado; //Atributo que define a pessoa selecionada

        public Pessoa Selecionado
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

        public FormPesquisaPessoa()
        {
            InitializeComponent();
        }

        private void Fill()
        {
            //Método que preenche a DataGridView com todas as pessoas disponíveis
            PessoaDAO db = new PessoaDAO();

            List<Pessoa> lista = db.Listar();

            dgvPessoas.Rows.Clear();
            foreach (Pessoa p in lista)
            {
                dgvPessoas.Rows.Add(p.Cpf, p.Nome);
            }
        }

        private Pessoa selecao()
        {
            if (dgvPessoas.CurrentRow != null)
            {
                //Método que obtém uma pessoa a partir da seleção do DataGridView
                int indiceSelecao = dgvPessoas.SelectedCells[0].RowIndex;
                DataGridViewRow linhaSelecionada = dgvPessoas.Rows[indiceSelecao];
                PessoaDAO db = new PessoaDAO();
                return db.Read(linhaSelecionada.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Selecione uma pessoa!", "Você deve selecionar uma pessoa.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            //Evento chamado ao se digitar algo no campo "txtFiltrar", é semelhante ao "Fill"
            PessoaDAO db = new PessoaDAO();

            List<Pessoa> lista = db.Listar();


            dgvPessoas.Rows.Clear();
            foreach (Pessoa p in lista)
            {
                if (p.Nome.Contains(txtFiltrar.Text))
                {
                    dgvPessoas.Rows.Add(p.Cpf, p.Nome);
                }
            }
        }

        private void FormPesquisaPessoa_Load(object sender, EventArgs e)
        {
            //Evento chamado no carregamento do Form, chama o método "Fill"
            Fill();
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

        private void dgvPessoas_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvPessoas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Evento que verifica se ocorre um clique duplo em uma linha na DataGridView
            btnEnviar.PerformClick();
        }
    }
}
