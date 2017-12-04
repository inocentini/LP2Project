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
    public partial class FormRelatorioContas : Form
    {
        public FormRelatorioContas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "Cancelar"
            this.Close();
        }

        private void FormRelatorioContas_FormClosing(object sender, FormClosingEventArgs e)
        {            
            //Evento chamado no fechamento do form, apenas o esconde ao invés de realizar um "Dispose"
            this.Hide();

            //Cancela o evento padrão de fechamento ("Dispose")
            e.Cancel = true;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "gerar relatório"
            FormRelatorioContaPrint rConta = new FormRelatorioContaPrint(dtpReferencia.Value);
            rConta.Show();
        }
    }
}
