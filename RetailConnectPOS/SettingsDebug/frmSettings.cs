using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailConnectPOS.SettingsDebug
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnDebugMode_Click(object sender, EventArgs e)
        {
            frmDebug Debug = new frmDebug();
            Debug.Show();
            this.Hide();
        }

        private void btnSettingsclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
