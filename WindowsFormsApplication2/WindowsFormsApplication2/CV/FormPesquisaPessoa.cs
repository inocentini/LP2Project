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
    public partial class FormPesquisaPessoa : Form
    {
        private Pessoa selecionado;

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
            Fill();
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
    }
}
