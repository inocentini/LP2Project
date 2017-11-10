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
    public partial class FormTeste : Form
    {
        public FormTeste()
        {
            InitializeComponent();
        }

        private void FormTeste_Load(object sender, EventArgs e)
        {
            PagamentoDAO dao = new PagamentoDAO();
            List<Pagamento> pList = dao.Listar();
            RelatorioTeste report = new RelatorioTeste();
            report.SetDataSource(pList);
            crvTeste.ReportSource = report;
        }
    }
}
