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
    
    public partial class frmCheckPrice : Form
    {
        DBModelContext db = new DBModelContext(); 

        public frmCheckPrice()
        {
            InitializeComponent();
        }

        private void btnCheckPriceclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
            {
            var List = (from a in db.STOCKs
                        where a.PRDCODE == txtSearch.Text
                        select new
                            {
                            ProductCode = a.PRDCODE,
                            ProductName = a.PRDNAME,
                            UnitPrice = a.PRICE,


                            }).SingleOrDefault();

            if (List != null)
                {
                lblProductCode.Text = List.ProductCode;
                lblProductName.Text = List.ProductName;
                lblProductPrice.Text = List.UnitPrice.ToString();

                }
            }
        }
}
