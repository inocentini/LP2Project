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
            this.Hide();
            e.Cancel = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
