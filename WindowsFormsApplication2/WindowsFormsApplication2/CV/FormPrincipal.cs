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
    public partial class FormPrincipal : Form
    {
        FormListaProdutos flpr = new FormListaProdutos();
        FormListaContas flc = new FormListaContas();
        FormRelatorios frel;
        FormListaTransacoes flt = new FormListaTransacoes();
        FormListaPessoas flp;
        FormCadastraLogin flmi = new FormCadastraLogin(Sessao.login);
        FormAlteraSenha fmas = new FormAlteraSenha();
        FormListaPagamentos flpag = new FormListaPagamentos();

        private void InicializaForms()
        {
            flpr.MdiParent = this;
            flt.MdiParent = this;
            flmi.MdiParent = this;
            fmas.MdiParent = this;
            flpag.MdiParent = this;
        }

        public FormPrincipal()
        {
            InitializeComponent();
            InicializaForms();
            if (Sessao.login.Admin)
            {
                áreaAdministrativaToolStripMenuItem.Visible = true;
                áreaAdministrativaToolStripMenuItem.Enabled = true;
                flp = new FormListaPessoas();
                frel = new FormRelatorios();
                flc = new FormListaContas();
                flp.MdiParent = this;
                frel.MdiParent = this;
                flc.MdiParent = this;
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flpr.Show();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(flc.Visible == true)
            {
                flc.Hide();
            }
            flc.NonAdmin = false;
            flc.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flt.Show();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flp.Show();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frel.Show();
        }

        private void FormPrincipal_ResizeEnd(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sessao.Logoff();
            Dispose();
        }

        private void alterarInformaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flmi.Show();
        }

        private void mudarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmas.Show();
        }

        private void contasQueAdministroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flc.Visible == true)
            {
                flc.Hide();
            }
            flc.NonAdmin = true;
            flc.Show();
        }

        private void meusPagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(flpag.Visible == true)
            {
                flpag.Hide();
            }
            flpag.NonResp = true;
            flpag.Show();
        }
    }
}
