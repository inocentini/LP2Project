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
    public partial class FormRelatorioContaPrint : Form
    {
        public FormRelatorioContaPrint()
        {
            InitializeComponent();
        }

        private void FormRelatorioContaPrint_Load(object sender, EventArgs e)
        {
            ContaDAO dao = new ContaDAO();
            List<Conta> lConta = dao.Listar();
            RelatorioConta report = new RelatorioConta();
            report.SetDataSource(lConta);
            crvConta.ReportSource = report;
        }
    }
}
