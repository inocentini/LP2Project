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
    public partial class FormPrincipal : Form
    {
        FormListaProdutos flpr = new FormListaProdutos();
        FormListaContas flc = new FormListaContas();
        FormListaTransacoes flt = new FormListaTransacoes();
        FormListaPessoas flp;
        FormCadastraLogin flmi = new FormCadastraLogin(Sessao.login);
        FormAlteraSenha fmas = new FormAlteraSenha();
        FormListaPagamentos flpag = new FormListaPagamentos();
        FormRelatorioContas frc;
        FormRelatorioPagamentos frp;
        FormRelatorioTransacoes frt;

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
                flc = new FormListaContas();
                frc = new FormRelatorioContas();
                frp = new FormRelatorioPagamentos();
                frt = new FormRelatorioTransacoes();
                flp.MdiParent = this;
                flc.MdiParent = this;
                frc.MdiParent = this;
                frp.MdiParent = this;
                frt.MdiParent = this;
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                foreach(Form f in MdiChildren)
                {
                    f.Close();
                }
                Application.Exit();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
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

        private void contasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frc.Show();
        }

        private void pagamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frp.Show();
        }

        private void transaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frt.Show();
        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Como esse relatório não precisará de nenhuma configuração, ele será chamado direto por aqui
        }
    }
}
