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
    public partial class FormRelatorioCompra : Form
    {
        List<ProdutoTransacao> lcdao = new List<ProdutoTransacao>();

        public FormRelatorioCompra()
        {
            InitializeComponent();
            PessoaDAO pdao = new PessoaDAO();
            List<Pessoa> lpessoa = pdao.Listar();
            RelatorioPessoa report = new RelatorioPessoa();
            report.SetDataSource(lpessoa);
            crvRelatorioCompra.ReportSource = report;
        }
        public FormRelatorioCompra(int id)
        {
            InitializeComponent();
            PagamentoDAO cdao = new PagamentoDAO();
            List<PessoaPagamento> ltrans = cdao.Read(id).LPessoas;
            RelatorioPessoaPagemento report = new RelatorioPessoaPagemento();
            report.SetDataSource(ltrans);
            crvRelatorioCompra.ReportSource = report;

        }

        public FormRelatorioCompra(Transacao t)
        {
            InitializeComponent();
            CompraDAO cdao = new CompraDAO();
            lcdao = cdao.ListarProd(t.Id);
            RelatorioCompra report = new RelatorioCompra();
            report.SetDataSource(lcdao);
            crvRelatorioCompra.ReportSource = report;
        }

        private void FormRelatorioCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
