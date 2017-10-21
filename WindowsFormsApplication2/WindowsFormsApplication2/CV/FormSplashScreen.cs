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
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            tmLoad.Start();
        }

        private void tmLoad_Tick(object sender, EventArgs e)
        {
            pbLoading.Width += 5;
            if(pbLoading.Width >= 410)
            {
                this.Close();
            }
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
