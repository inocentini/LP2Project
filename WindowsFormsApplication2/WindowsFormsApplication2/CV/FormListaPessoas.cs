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
            //IDatabase db = new DatabaseDict();
            PessoaDAO db = new PessoaDAO();
            
            List <object> lista = db.Listar();

            dgvPessoas.Rows.Clear();
            foreach(object p in lista)
            {
                dgvPessoas.Rows.Add(((Pessoa)p).Cpf, ((Pessoa)p).Nome, ((Pessoa)p).Email, ((Pessoa)p).Telefone);
            }
        }

        private Pessoa selecao()
        {
            if (dgvPessoas.CurrentRow != null) {
                int indiceSelecao = dgvPessoas.SelectedCells[0].RowIndex;
                DataGridViewRow linhaSelecionada = dgvPessoas.Rows[indiceSelecao];
                PessoaDAO db = new PessoaDAO();
                return (Pessoa)db.Read(linhaSelecionada.Cells[0].Value.ToString());
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
                wCadastro editar = new wCadastro(selecao(), true);
                editar.ShowDialog(this);
                Fill();
            }
        }

        private void bntDetalhes_Click(object sender, EventArgs e)
        {
            Pessoa selecionada = selecao();
            if (selecionada != null)
            {
                wCadastro detalhes = new wCadastro(selecao(), false);
                detalhes.ShowDialog(this);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Pessoa selecionada = selecao();
            if (selecionada != null)
            {
                PessoaDAO db = new PessoaDAO();
                db.Remover(selecao().Cpf);
                Fill();
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            PessoaDAO db = new PessoaDAO();

            List<object> lista = db.Listar();
           

            dgvPessoas.Rows.Clear();
            foreach(object p in lista)
            {
                if (((Pessoa)p).Nome.Contains(txtFiltrar.Text))
                {
                    dgvPessoas.Rows.Add(((Pessoa)p).Cpf, ((Pessoa)p).Nome, ((Pessoa)p).Email, ((Pessoa)p).Telefone);
                }
            }
        }

        private void wPessoa_Load(object sender, EventArgs e)
        {
            Fill();
        }
    }
}
