using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailConnectPOS.Dashboard
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void btnXReport_Click(object sender, EventArgs e)
        {
            pnCashIn.Hide();
            pnCashOut.Hide();
            pnXReport.Show();
            pnYReading.Hide();
        }

        private void btnCashIn_Click(object sender, EventArgs e)
        {
            pnCashIn.Show();
            pnCashOut.Hide();
            pnXReport.Hide();
            pnYReading.Hide();
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            pnCashIn.Hide();
            pnCashOut.Show();
            pnXReport.Hide();
            pnYReading.Hide();
        }

        private void btnYReading_Click(object sender, EventArgs e)
        {
            pnCashIn.Hide();
            pnCashOut.Hide();
            pnXReport.Hide();
            pnYReading.Show();
        }        

        private void btnAppClose_Click(object sender, EventArgs e)
        {

        }
    }
}
