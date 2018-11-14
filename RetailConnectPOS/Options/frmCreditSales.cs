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
    public partial class frmCreditSales : Form
    {
        //DBModelContext db = new DBModelContext();

        public frmCreditSales()
        {
            InitializeComponent();
        }

        private void btnAppClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCreditSales_Load(object sender, EventArgs e)
            {
            //var List = (from a in db.CREDITs
            //            select new
            //                {
            //                a.CREDITCODE,
            //                a.CREDITDESC

            //                }).ToList();

            //gridCredit.DataSource = List;
            }
        }
}
