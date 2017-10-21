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
    public partial class FormListaTransacoes : Form
    {
        public FormListaTransacoes()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            FormCadastraTransacao cadastro = new FormCadastraTransacao();
            cadastro.ShowDialog(this);
            Fill();
        }

        private void Fill()
        {
            TransacaoDAO db = new TransacaoDAO();

            List<Transacao> lista = db.Listar();

            dgvComprasEVendas.Rows.Clear();

            bool compra = new bool();

            if (cbbTransacao.SelectedIndex == 0)
            {
                foreach(Transacao cv in lista)
                {
                    if (cv.ToString().Contains(txtFiltrar.Text))
                    {
                        dgvComprasEVendas.Rows.Add(cv.Id, cv.Data.ToShortDateString(), cv.ToString(), cv.Valor, cv.Compra ? "Compra" : "Uso");
                    }
                }
            }
            else
            {
                if (cbbTransacao.SelectedIndex == 1)
                {
                    compra = true;
                }
                else
                {
                    compra = false;
                }

                foreach (Transacao cv in lista)
                {
                    if (cv.ToString().Contains(txtFiltrar.Text) && cv.Compra == compra)
                    {
                        dgvComprasEVendas.Rows.Add(cv.Id, cv.Data.ToShortDateString(), cv.ToString(), cv.Valor, cv.Compra ? "Compra" : "Uso");
                    }
                }
            }
        }

        private Transacao selecao()
        {
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
            Transacao selecionada = selecao();
            if (selecionada != null)
            {
                FormCadastraTransacao detalhes = new FormCadastraTransacao(selecionada, false);
                detalhes.ShowDialog(this);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
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
            Fill();
        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {
            cbbTransacao.SelectedIndex = 0;
        }

        private void FormEstoque_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void cbbTransacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill();
        }
    }
}
