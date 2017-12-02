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
        //Aqui são instanciados ou apenas declarados todos os Forms que são "filhos" do principal
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
            //Método para inicializar os forms, definindo seu pai MDI como este
            flpr.MdiParent = this;
            flt.MdiParent = this;
            flmi.MdiParent = this;
            fmas.MdiParent = this;
            flpag.MdiParent = this;
        }

        public FormPrincipal()
        {
            //Construtor padrão, verifica se o usuário logado é admin para instanciar e definir os forms da área administrativa
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
            //Evento chamado no fechamento do Form
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //Se o usuário que fechou, fecha todos os "filhos" do form e sai da aplicação
                foreach(Form f in MdiChildren)
                {
                    f.Close();
                }
                Application.Exit();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Evento chamado na opção "sair", fecha todos os "filhos" do form e sai da aplicação
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            Application.Exit();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Evento de clique na opção "Produtos"
            flpr.Show();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Evento de clique na opção de "Contas" da área administrativa, se já estiver aberto pela área não administrativa fecha o form ante de reabri-lo
            if(flc.Visible == true)
            {
                flc.Dispose();
            }
            flc = new FormListaContas();
            flc.MdiParent = this;
            flc.NonAdmin = false;
            flc.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Evento de clique na opção "Compras/Usos"
            flt.Show();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Evento de clique na opção "Pessoas"
            flp.Show();
        }

        private void FormPrincipal_ResizeEnd(object sender, EventArgs e)
        {
            //Evento que atualiza o Form toda vez que ele for redimensionado
            this.Refresh();
        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Evento de clique na opção "Deslogar", chama o método "Logoff" da sessão e fecha o form
            Sessao.Logoff();
            Dispose();
        }

        private void alterarInformaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Evento de clique na opção "Mudar informações"
            flmi.Show();
        }

        private void mudarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Evento de clique na opção "Mudar senha"
            fmas.Show();
        }

        private void contasQueAdministroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Evento de clique na opção "Compras que administro", se já estiver aberto pela área administrativa fecha o form antes de reabri-lo
            if (flc.Visible == true)
            {
                flc.Dispose();
            }
            flc = new FormListaContas();
            flc.MdiParent = this;
            flc.NonAdmin = true;
            flc.Show();
        }

        private void meusPagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Evento de clique na opção "Meus pagamentos", se já estiver aberto pelo form de compras esconde ele antes de reabri-lo
            if (flpag.Visible == true)
            {
                flpag.Hide();
            }
            flpag.NonResp = true;
            flpag.Show();
        }

        private void contasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Evento de clique na opção "Contas" dos relatórios
            frc.Show();
        }

        private void pagamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Evento de clique na opção "Pagamentos" dos relatórios
            frp.Show();
        }

        private void transaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Evento de clique na opção "transações" dos relatórios
            frt.Show();
        }
    }
}
