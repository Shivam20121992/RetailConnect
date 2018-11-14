using RetailConnectPOS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailConnectPOS.Options
{
    public partial class frmSalesReturn : Form
    {
        DBModelContext db = new DBModelContext();

        public frmSalesReturn()
        {
            InitializeComponent();
        }

        private void btnSalesReturnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSalesReturn_Load(object sender, EventArgs e)
            {
            var List = (from a in db.RIREASONs
                       select new
                           {
                           Code = a.RIREASONCODE,
                           Description = a.RIREASONDESC

                           }).ToList();

            gridReturn.DataSource = List;
            }
        }
}
