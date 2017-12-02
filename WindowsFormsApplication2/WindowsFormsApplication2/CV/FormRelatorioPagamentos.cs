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
    public partial class FormRelatorioPagamentos : Form
    {
        private Conta selecionada;

        public FormRelatorioPagamentos()
        {
            InitializeComponent();
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão para escolher a conta desejada
            FormPesquisaConta pesquisaConta = new FormPesquisaConta();
            pesquisaConta.ShowDialog(this);
            selecionada = pesquisaConta.Selecionado;
            if (selecionada != null)
            {
                txtConta.Text = selecionada.Nome;
            }
        }

        private void FormRelatorioContas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Evento chamado no fechamento do form, apenas o esconde ao invés de realizar um "Dispose"
            this.Hide();

            //Cancela o evento padrão de fechamento ("Dispose")
            e.Cancel = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "Cancelar"
            this.Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            FormRelatorioCompra frc = new FormRelatorioCompra(selecionada.Id);
            frc.Show(this);
        }
    }
}
