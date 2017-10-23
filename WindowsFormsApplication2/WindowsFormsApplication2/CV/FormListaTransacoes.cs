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
    public partial class FormListaTransacoes : Form
    {
        public FormListaTransacoes()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            //Evento do botão "Adicionar"
            FormCadastraTransacao cadastro = new FormCadastraTransacao();
            cadastro.ShowDialog(this);
            Fill();
        }

        private void Fill()
        {
            //Método utilizado para listar todas as transações na DataGridView
            TransacaoDAO db = new TransacaoDAO();

            List<Transacao> lista = db.Listar();

            dgvComprasEVendas.Rows.Clear();

            //Variável utilizada para definir qual opção (compra ou uso) está selecionada no ComboBox
            bool compra = new bool();

            if (cbbTransacao.SelectedIndex == 0)
            {
                //Se a opção de índice 0 ("Mostrar tudo") estiver selecionada na ComboBox, mostra todas as transações
                foreach(Transacao t in lista)
                {
                    //Se tiver algo digitado no "txtFiltrar", mostra apenas as transações que têm o que é digitado na sua lista de produtos
                    if (t.ToString().Contains(txtFiltrar.Text))
                    {
                        dgvComprasEVendas.Rows.Add(t.Id, t.Data.ToShortDateString(), t.ToString(), t.Valor, t.Compra ? "Compra" : "Uso");
                    }
                }
            }
            else
            {
                //Senão, define "compra" como "true" ou "false" dependendo da opção escolhida ("compra" ou "uso")
                if (cbbTransacao.SelectedIndex == 1)
                {
                    compra = true;
                }
                else
                {
                    compra = false;
                }

                foreach (Transacao t in lista)
                {
                    //Se tiver algo digitado no "txtFiltrar", mostra apenas as transações que têm o que é digitado na sua lista de produtos
                    if (t.ToString().Contains(txtFiltrar.Text) && t.Compra == compra)
                    {
                        dgvComprasEVendas.Rows.Add(t.Id, t.Data.ToShortDateString(), t.ToString(), t.Valor, t.Compra ? "Compra" : "Uso");
                    }
                }
            }
        }

        private Transacao selecao()
        {
            //Método utilizado para se obter uma transação a partir da linha selecionada na DataGridView
            if (dgvComprasEVendas.CurrentRow != null)
            {
                int indiceSelecao = dgvComprasEVendas.SelectedCells[0].RowIndex;
                DataGridViewRow linhaSelecionada = dgvComprasEVendas.Rows[indiceSelecao];
                TransacaoDAO db = new TransacaoDAO();
                return db.Read(int.Parse(linhaSelecionada.Cells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Selecione uma transação!", "Você deve selecionar uma transação.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "editar"
            Transacao selecionada = selecao();
            if (selecionada != null)
            {
                FormCadastraTransacao editar = new FormCadastraTransacao(selecionada, true);
                editar.ShowDialog(this);
                Fill();
            }
        }

        private void bntDetalhes_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "detalhes"
            Transacao selecionada = selecao();
            if (selecionada != null)
            {
                FormCadastraTransacao detalhes = new FormCadastraTransacao(selecionada, false);
                detalhes.ShowDialog(this);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "remover"
            Transacao selecionada = selecao();
            if (selecionada != null)
            {
                TransacaoDAO db = new TransacaoDAO();
                db.Remover(selecionada.Id);
                Fill();
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            //Evento que chama o método "fill" se for digitado algo no campo "txtFiltrar"
            Fill();
        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {
            //Evento de carregamento do form, define o valor marcado da ComboBox "cbbTransacao" como "Mostrar tudo"
            cbbTransacao.SelectedIndex = 0;
        }

        private void FormEstoque_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Evento chamado no fechamento do form, apenas o esconde ao invés de realizar um "Dispose"
            this.Hide();

            //Cancela o evento padrão de fechamento ("Dispose")
            e.Cancel = true;
        }

        private void cbbTransacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Evento que chama o método "Fill" toda vez que o valor selecionado do ComboBox "cbbTransacao" for mudado
            Fill();
        }
    }
}
