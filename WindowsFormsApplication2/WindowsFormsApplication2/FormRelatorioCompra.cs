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
        public FormRelatorioCompra()
        {
            InitializeComponent();
        }

        public FormRelatorioCompra(Transacao t)
        {
            InitializeComponent();
        }

        private void FormRelatorioCompra_Load(object sender, EventArgs e)
        {
            CompraDAO cdao = new CompraDAO();
            List<CompraDAO> lcdao = new List<CompraDAO>();
            RelatorioCompra report = new RelatorioCompra();
            report.SetDataSource(lcdao);
            crvRelatorioCompra.ReportSource = report;
        }
    }
}
