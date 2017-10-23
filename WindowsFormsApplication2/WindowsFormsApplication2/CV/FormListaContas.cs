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
    public partial class FormListaContas : Form
    {
        private bool nonAdmin = false; //Atributo utilizado para verificar se quem chama o form é adiministrador ou se é responsável pelas compras listadas

        public bool NonAdmin
        {
            get
            {
                return nonAdmin;
            }

            set
            {
                nonAdmin = value;
            }
        }

        public FormListaContas()
        {
            InitializeComponent();
        }

        private void Fill()
        {
            //Método utilizado pala preencher a DataGridView com as contas
            ContaDAO db = new ContaDAO();

            List<Conta> lista;
            if (NonAdmin)
            {
                //Se não for administrador, lista as contas que ele é responsável
                lista = db.ListarPorResponsavel(Sessao.login.P.Cpf);
            }
            else
            {
                //Se for administrador, lista todas as contas
                lista = db.Listar();
            }

            dgvContas.Rows.Clear();
            foreach (Conta c in lista)
            {
                dgvContas.Rows.Add(c.Id,c.Nome,c.Detalhes,"R$" + c.Valor,c.Vencimento.ToShortDateString(),c.Responsavel.Nome);
            }
        }

        private Conta selecao()
        {
            //Método utilizado para se obter uma conta a partir da seleção da DataGridView
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
            //Evento de clique no botão "adicionar"
            FormCadastraConta cadastro;

            if (nonAdmin)
            {
                //Se não for administrador, chama o FormCadastraConta com o parâmetro "true" para que não haja opção de escolher o responsável
                cadastro = new FormCadastraConta(true);
            }
            else
            {
                //Se for administrador, chama o FormCadastraCOnta com o parâmetro "false" para que exista a opção de escolher o responsável
                cadastro = new FormCadastraConta(false);
            }

            cadastro.ShowDialog(this);
            Fill();
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "editar"
            Conta selecionada = selecao();
            if (selecionada != null)
            {
                FormCadastraConta editar;
                if (nonAdmin)
                {
                    //Se não for administrador, chama o FormCadastraConta com o parâmetro "true" para que não haja opção de escolher o responsável
                    editar = new FormCadastraConta(selecionada, true, true);
                }
                else
                {
                    //Se for administrador, chama o FormCadastraCOnta com o parâmetro "false" para que exista a opção de escolher o responsável
                    editar = new FormCadastraConta(selecionada, true, false);
                }

                editar.ShowDialog(this);
                Fill();
            }
        }

        private void bntDetalhes_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "editar"
            Conta selecionada = selecao();
            if (selecionada != null)
            {
                //Chama o FormCadastraPessoa com o segundo parâmetro como "false" para indicar uma visualização de informações e não uma edição
                FormCadastraConta detalhes = new FormCadastraConta(selecionada, false, false);
                detalhes.ShowDialog(this);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "remover"
            Conta selecionada = selecao();
            if (selecionada != null)
            {
                ContaDAO db = new ContaDAO();
                db.Remover(selecionada.Id);
                Fill();
            }
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "pagamentos"
            Conta selecionada = selecao();
            if (selecionada != null)
            {
                //Chama o FormListaPagamentos passando como parâmetro a conta selecionada, para que só sejam listados seus pagamentos
                FormListaPagamentos pagamentos = new FormListaPagamentos(selecionada);

                //"NonResp" é definido como "false" para que exista a opção de dar baixa no pagamentos
                pagamentos.NonResp = false;
                pagamentos.ShowDialog();
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            //Método utilizado para filtrar as contas a partir do que é digitado, tem funcionamento semelhante ao fill
            ContaDAO db = new ContaDAO();

            List<Conta> lista;
            if (NonAdmin)
            {
                lista = db.ListarPorResponsavel(Sessao.login.P.Cpf);
            }
            else
            {
                lista = db.Listar();
            }


            dgvContas.Rows.Clear();
            foreach (Conta c in lista)
            {
                if (c.Nome.Contains(txtFiltrar.Text))
                {
                    dgvContas.Rows.Add(c.Id,c.Nome,c.Detalhes,"R$" + c.Valor,c.Vencimento.ToShortDateString(),c.Responsavel.Nome);
                }
            }
        }

        private void FormListaContas_Load(object sender, EventArgs e)
        {
            //Evento chamado no carregamento do Form e na sua reativação
            if (this.nonAdmin)
            {
                this.Text = "Contas que administro";
                colResponsavel.Visible = false;
            }
            else
            {
                this.Text = "Contas";
            }
            Fill();
        }

        private void FormListaContas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Evento chamado no fechamento do form, apenas o esconde ao invés de realizar um "Dispose"
            this.Hide();

            //Cancela o evento padrão de fechamento ("Dispose")
            e.Cancel = true;
        }
    }
}
