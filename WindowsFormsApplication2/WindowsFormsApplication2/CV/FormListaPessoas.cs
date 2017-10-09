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
    public partial class FormListaPessoas : Form
    {
        public FormListaPessoas()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            FormCadastraPessoa cadastro = new FormCadastraPessoa();
            cadastro.ShowDialog(this);
            Fill();
        }

        private void Fill()
        {
            //IDatabase db = new DatabaseDict();
            PessoaDAO db = new PessoaDAO();
            
            List <Pessoa> lista = db.Listar();

            dgvPessoas.Rows.Clear();
            foreach(Pessoa p in lista)
            {
                dgvPessoas.Rows.Add(p.Cpf, p.Nome, p.Email, p.Telefone);
            }
        }

        private Pessoa selecao()
        {
            if (dgvPessoas.CurrentRow != null) {
                int indiceSelecao = dgvPessoas.SelectedCells[0].RowIndex;
                DataGridViewRow linhaSelecionada = dgvPessoas.Rows[indiceSelecao];
                PessoaDAO db = new PessoaDAO();
                return db.Read(linhaSelecionada.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Selecione uma pessoa!", "Você deve selecionar uma pessoa.", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            Pessoa selecionada = selecao();
            if (selecionada != null)
            {
                FormCadastraPessoa editar = new FormCadastraPessoa(selecionada, true);
                editar.ShowDialog(this);
                Fill();
            }
        }

        private void bntDetalhes_Click(object sender, EventArgs e)
        {
            Pessoa selecionada = selecao();
            if (selecionada != null)
            {
                FormCadastraPessoa detalhes = new FormCadastraPessoa(selecionada, false);
                detalhes.ShowDialog(this);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Pessoa selecionada = selecao();
            if (selecionada != null)
            {
                PessoaDAO db = new PessoaDAO();
                db.Remover(selecionada.Cpf);
                Fill();
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            PessoaDAO db = new PessoaDAO();

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

        private void FormListaPessoas_Load(object sender, EventArgs e)
        {
            Fill();
        }
    }
}
