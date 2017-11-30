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
    public partial class FormListaPessoas : Form
    {
        public FormListaPessoas()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            //Evento do botão "Adicionar"
            FormCadastraLogin cadastro = new FormCadastraLogin();
            cadastro.ShowDialog(this);
            Fill();
        }

        private void Fill()
        {
            //Método utilizado para listar todas as pessoas na DataGridView
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
            //Método utilizado para se obter uma pessoa a partir da linha selecionada na DataGridView
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
            //Evento de clique no botão "editar"
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
            //Evento de clique no botão "detalhes"
            Pessoa selecionada = selecao();
            if (selecionada != null)
            {
                FormCadastraPessoa detalhes = new FormCadastraPessoa(selecionada, false);
                detalhes.ShowDialog(this);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "remover"
            LoginDAO dbl = new LoginDAO();

            Pessoa selecionada = selecao();
            if ((selecionada != null)&&(selecionada.Cpf != dbl.cpfAdmin()))
            {
                PessoaDAO db = new PessoaDAO();
                db.Remover(selecionada.Cpf);
                Fill();
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            //Evento que filtra as pessoas mostradas conforme é digitado no campo de texto "txtFiltrar", tem funcionamento semelhante ao "Fill"
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
            //Evento de carregamento do form, chama o método "Fill"
            Fill();
        }

        private void FormListaPessoas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Evento chamado no fechamento do form, apenas o esconde ao invés de realizar um "Dispose"
            this.Hide();

            //Cancela o evento padrão de fechamento ("Dispose")
            e.Cancel = true;
        }
    }
}
