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

        }

        public FormRelatorioCompra(DateTime d)
        {
            InitializeComponent();
            CompraDAO cdao = new CompraDAO();
            List<Transacao> ltrans = cdao.ListarPorData(d);
            RelatorioTransacao report = new RelatorioTransacao();
            report.SetDataSource(lcdao);
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
