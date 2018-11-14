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
using PagedList;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RetailConnectPOS.Dashboard
{
    /* Author :    Moreheahs Inc, Indore, MP, India.
       Email:      info@moreyeahs.Com
       Advance POS : http://www.moreyeahs.com  
   */

    public partial class frmCashier : Form
    {
        DBModelContext db = new DBModelContext();
        //String connection = ConfigurationManager.ConnectionStrings["PschoolString"].ConnectionString;
        SqlConnection con = new SqlConnection(@"Data Source = MDEVPC-25\SQLEXPRESS;initial catalog = PosLocal; User = sa; Password = sa@123");

        public frmCashier()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime showDateTime = DateTime.Now;
            this.lalbelDateTime.Text = showDateTime.ToString();
        }

        private void frmCashier_Load(object sender, EventArgs e)
        {

            string ScreenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string ScreenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            lblReso.Text = (ScreenWidth + "X" + ScreenHeight);
            fillsku();
            fillitemmaster();
            CalculateItem();
        }
        void fillitemmaster()
        {
            SqlCommand cmd = new SqlCommand("select * from Sales", con);
            //con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count>0)
            {
                double cost;
                for(int i=0; i<= dt.Rows.Count-1; i++)
                {
                    cost =Convert.ToDouble(dt.Rows[i]["QTY"]) *Convert.ToDouble(dt.Rows[i]["PRICE"]);
                    dt.Rows[i]["COST"] = cost;
                }
            }
            con.Close();
            gridItemMaster.DataSource = dt;
            gridItemMaster.Columns["SeqNo"].Visible = false;
            gridItemMaster.Columns["CREATEDATE"].Visible = false;
            gridItemMaster.Columns["STORECODE"].Visible = false;
            gridItemMaster.Columns["DESCCODE"].Visible = false;
            gridItemMaster.Columns["ORGPRICE"].Visible = false;
            gridItemMaster.Columns["REGPRICE"].Visible = false;
            gridItemMaster.Columns["DISCOUNT"].Visible = false;
            gridItemMaster.Columns["PRKEY"].Visible = false;
            gridItemMaster.Columns["REGPRKEY"].Visible = false;
            gridItemMaster.Columns["PRNO"].Visible = false;
            gridItemMaster.Columns["PRTYPECODE"].Visible = false;
            gridItemMaster.Columns["TPRICE"].Visible = false;
            gridItemMaster.Columns["STYPE"].Visible = false;
            gridItemMaster.Columns["USERID"].Visible = false;
            gridItemMaster.Columns["CUSTOMERCODE"].Visible = false;
            gridItemMaster.Columns["STAFFCODE"].Visible = false;
            gridItemMaster.Columns["COMMISION"].Visible = false;
            gridItemMaster.Columns["REMARK"].Visible = false;
            gridItemMaster.Columns["ALTCODE"].Visible = false;
            gridItemMaster.Columns["PRICECHG"].Visible = false;
            gridItemMaster.Columns["SALPOINT"].Visible = false;
            gridItemMaster.Columns["TNOW"].Visible = false;
            gridItemMaster.Columns["AUTHID"].Visible = false;
            gridItemMaster.Columns["GROUPID"].Visible = false;
            gridItemMaster.Columns["GROUPID2"].Visible = false;
            gridItemMaster.Columns["LINKID"].Visible = false;
            gridItemMaster.Columns["CREDITCARDNAME"].Visible = false;
            gridItemMaster.Columns["VATPRICE"].Visible = false;
            gridItemMaster.Columns["VATIN"].Visible = false;
            gridItemMaster.Columns["PRICELVL"].Visible = false;
            gridItemMaster.Columns["VAT"].Visible = false;
            gridItemMaster.Columns["GSTPRICE"].Visible = false;
            gridItemMaster.Columns["UNITGSTPRICE"].Visible = false;
            gridItemMaster.Columns["GSTDISCOUNT"].Visible = false;
            gridItemMaster.Columns["ITEMDISCGST"].Visible = false;
            gridItemMaster.Columns["GSTAmtR4"].Visible = false;
            gridItemMaster.Columns["PRDNAME2"].Visible = false;
            gridItemMaster.Columns["XYSET"].Visible = false;

        }
        void fillsku()
        {
            //var List = (from a in db.STOCKs
            //            select new
            //            {
            //                ProductCode = a.PRDCODE,
            //                ProductName = a.PRDNAME,
            //                GSTPrice = a.REGPRICE,
            //                AltCode = a.ALTCODE,
            //                GSTCode = a.VATIN,
            //                UOMCODE= a.UOMCODE,
            //                PH1CODE=a.PH1CODE,
            //                PH2CODE=a.PH2CODE,
            //                PH3CODE=a.PH3CODE,
            //                PH4CODE=a.PH4CODE,
            //                PH5CODE = a.PH5CODE,
            //                PH6CODE = a.PH6CODE,
            //                OHB=a.OHB,
            //                COST=a.COST,
            //                NEWCOST=a.NEWCOST,
            //                CDATE=a.CDATE,
            //                     //STATUSCODE
            //            }).ToList();

            //gridSKU.DataSource = List;
            //gridSKU.Columns["UOMCODE"].Visible = false;
            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand("select PRDCODE,PRDNAME,REGPRICE,ALTCODE,VATIN from STOCK", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            gridSKU.DataSource = dt;
            //gridSKU.Columns["PH1CODE"].Visible = false;
            //gridSKU.Columns["PH2CODE"].Visible = false;
            //gridSKU.Columns["PH3CODE"].Visible = false;
            //gridSKU.Columns["PH4CODE"].Visible = false;
            //gridSKU.Columns["PH5CODE"].Visible = false;
            //gridSKU.Columns["PH6CODE"].Visible = false;
            //gridSKU.Columns["OHB"].Visible = false;
            //gridSKU.Columns["COST"].Visible = false;
            //gridSKU.Columns["NEWCOST"].Visible = false;
            //gridSKU.Columns["CDATE"].Visible = false;
            //gridSKU.Columns["STATUSCODE"].Visible = false;
            //gridSKU.Columns["CREATEDATE"].Visible = false;
            //gridSKU.Columns["MODIFYDATE"].Visible = false;
            //gridSKU.Columns["FRACTION"].Visible = false;
            //gridSKU.Columns["MINQTY"].Visible = false;
            //gridSKU.Columns["MAXQTY"].Visible = false;
            //gridSKU.Columns["DELETEDATE"].Visible = false;
            //gridSKU.Columns["PRICE"].Visible = false;
            //gridSKU.Columns["DESCCODE"].Visible = false;
            //gridSKU.Columns["ARTICLE"].Visible = false;
            //gridSKU.Columns["COLORCODE"].Visible = false;
            //gridSKU.Columns["SIZECODE"].Visible = false;
            //gridSKU.Columns["COUNTRYCODE"].Visible = false;
            //gridSKU.Columns["BRANDCODE"].Visible = false;
            //gridSKU.Columns["UOMCODE"].Visible = false;
            //gridSKU.Columns["CCODE"].Visible = false;
            //gridSKU.Columns["FRESH"].Visible = false;
            //gridSKU.Columns["PRKEY"].Visible = false;
            //gridSKU.Columns["REGPRKEY"].Visible = false;
            //gridSKU.Columns["PRNO"].Visible = false;
            //gridSKU.Columns["PRTYPECODE"].Visible = false;
            //gridSKU.Columns["DBCMFIELD1"].Visible = false;
            //gridSKU.Columns["DBCMFIELD2"].Visible = false;
            //gridSKU.Columns["DBCMFIELD3"].Visible = false;
            //gridSKU.Columns["UPDATENO"].Visible = false;
            //gridSKU.Columns["UPDATEDATE"].Visible = false;
            //gridSKU.Columns["DCCOST"].Visible = false;
            //gridSKU.Columns["OLDPRICE"].Visible = false;
            //gridSKU.Columns["OLDPRICEDATE"].Visible = false;
            //gridSKU.Columns["TCOST"].Visible = false;
            //gridSKU.Columns["PRICETYPECODE"].Visible = false;
            //gridSKU.Columns["GP"].Visible = false;
            //gridSKU.Columns["LASTPURCHDATE"].Visible = false;
            //gridSKU.Columns["LASTSALEDATE"].Visible = false;
            //gridSKU.Columns["LASTTRANINDATE"].Visible = false;
            //gridSKU.Columns["LASTTRANOUTDATE"].Visible = false;
            //gridSKU.Columns["LASTVENDOR"].Visible = false;
            //gridSKU.Columns["WAC"].Visible = false;
            //gridSKU.Columns["VATOUT"].Visible = false;
            //gridSKU.Columns["UPDATEOHB"].Visible = false;
            //gridSKU.Columns["OPENPRICE"].Visible = false;
            //gridSKU.Columns["VATPRICE"].Visible = false;
            //gridSKU.Columns["OPBAL_DATE"].Visible = false;
            //gridSKU.Columns["OPBAL_QTY"].Visible = false;
            //gridSKU.Columns["OPBAL_COST"].Visible = false;
            //gridSKU.Columns["OPBAL_EDATE"].Visible = false;
            //gridSKU.Columns["OPBAL_PRICE"].Visible = false;
            //gridSKU.Columns["VAT"].Visible = false;
            //gridSKU.Columns["PRDNAME2"].Visible = false;

        }
        private void btnAppClose_Click(object sender, EventArgs e)
        {
            if
               (
                   MessageBox.Show
                   (
                       "Quit the Application",
                       "Exit Application Dialog",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button2 // hit Enter == No !
                   )
                   == DialogResult.Yes
               )
            {
                Application.Exit();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text == "00" || lblTotal.Text == "0.00")
            {
                MessageBox.Show("Sorry ! You don't have enough product in Item cart \n  Please Add to cart", "Yes or No", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }
            else
            {
                Options.Pay Pay = new Options.Pay();
                Pay.Show();
            }

        }

        private void btnPay_MouseEnter(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.MediumSeaGreen;
            btnPay.ForeColor = Color.White;
        }

        private void btnPay_MouseLeave(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.Gold;
            btnPay.ForeColor = Color.Black;
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            gridItemMaster.Refresh();
            gridItemMaster.Rows.Clear();
            lblqty.Text = "00";
            lblTotal.Text = "0.00";
            txtBarcodeReaderBox.Text = "";
            a = 1;
            txtQuantity.Text = a.ToString();

        }
        private void btnCancelOrder_MouseEnter(object sender, EventArgs e)
        {
            btnCancelOrder.BackColor = Color.MediumSeaGreen;
            btnCancelOrder.ForeColor = Color.White;
        }

        private void btnCancelOrder_MouseLeave(object sender, EventArgs e)
        {
            btnCancelOrder.BackColor = Color.Gold;
            btnCancelOrder.ForeColor = Color.Black;
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnNewOrder_MouseEnter(object sender, EventArgs e)
        {
            btnNewOrder.BackColor = Color.MediumSeaGreen;
            btnNewOrder.ForeColor = Color.White;
        }

        private void btnNewOrder_MouseLeave(object sender, EventArgs e)
        {
            btnNewOrder.BackColor = Color.Gold;
            btnNewOrder.ForeColor = Color.Black;
        }

        private void btnSKU_Click(object sender, EventArgs e)
        {
            panelSKU.Show();
            panelBottom2.Hide();
        }

        private void btnSKU_MouseEnter(object sender, EventArgs e)
        {
            btnSKU.BackColor = Color.MediumSeaGreen;
            btnSKU.ForeColor = Color.White;
        }

        private void btnSKU_MouseLeave(object sender, EventArgs e)
        {
            btnSKU.BackColor = Color.Gold;
            btnSKU.ForeColor = Color.Black;
        }
        private void btnSKUClose_Click(object sender, EventArgs e)
        {
            panelSKU.Hide();
            panelBottom2.Show();
        }


        private void btnPOSReport_Click(object sender, EventArgs e)
        {
            Options.frmPOSReport POSReport = new Options.frmPOSReport();
            POSReport.Show();
        }

        private void btnPOSReport_MouseEnter(object sender, EventArgs e)
        {
            btnPOSReport.BackColor = Color.MediumSeaGreen;
            btnPOSReport.ForeColor = Color.White;
        }

        private void btnPOSReport_MouseLeave(object sender, EventArgs e)
        {
            btnPOSReport.BackColor = Color.Gold;
            btnPOSReport.ForeColor = Color.Black;
        }

        private void btnCheckPrice_Click(object sender, EventArgs e)
        {
            Options.frmCheckPrice CheckPrice = new Options.frmCheckPrice();
            CheckPrice.Show();
        }

        private void btnCheckPrice_MouseEnter(object sender, EventArgs e)
        {
            btnCheckPrice.BackColor = Color.MediumSeaGreen;
            btnCheckPrice.ForeColor = Color.White;
        }

        private void btnCheckPrice_MouseLeave(object sender, EventArgs e)
        {
            btnCheckPrice.BackColor = Color.Gold;
            btnCheckPrice.ForeColor = Color.Black;
        }

        private void btnSeekResume_Click(object sender, EventArgs e)
        {
            Options.frmSeekResume SeeRkResume = new Options.frmSeekResume();
            SeeRkResume.Show();
        }

        private void btnSeekResume_MouseEnter(object sender, EventArgs e)
        {
            btnSeekResume.BackColor = Color.MediumSeaGreen;
            btnSeekResume.ForeColor = Color.White;
        }

        private void btnSeekResume_MouseLeave(object sender, EventArgs e)
        {
            btnSeekResume.BackColor = Color.Gold;
            btnSeekResume.ForeColor = Color.Black;
        }

        private void btnOpenDrawer_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenDrawer_MouseEnter(object sender, EventArgs e)
        {
            btnOpenDrawer.BackColor = Color.MediumSeaGreen;
            btnOpenDrawer.ForeColor = Color.White;
        }

        private void btnOpenDrawer_MouseLeave(object sender, EventArgs e)
        {
            btnOpenDrawer.BackColor = Color.Gold;
            btnOpenDrawer.ForeColor = Color.Black;
        }

        private void btnPWP_Click(object sender, EventArgs e)
        {

        }

        private void btnPWP_MouseEnter(object sender, EventArgs e)
        {
            btnPWP.BackColor = Color.MediumSeaGreen;
            btnPWP.ForeColor = Color.White;
        }

        private void btnPWP_MouseLeave(object sender, EventArgs e)
        {
            btnPWP.BackColor = Color.Gold;
            btnPWP.ForeColor = Color.Black;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {

        }

        private void btnCash_MouseEnter(object sender, EventArgs e)
        {
            btnCash.BackColor = Color.MediumSeaGreen;
            btnCash.ForeColor = Color.White;
        }

        private void btnCash_MouseLeave(object sender, EventArgs e)
        {
            btnCash.BackColor = Color.Gold;
            btnCash.ForeColor = Color.Black;
        }

        private void btnChnagePrice_Click(object sender, EventArgs e)
        {

        }

        private void btnChnagePrice_MouseEnter(object sender, EventArgs e)
        {
            btnChnagePrice.BackColor = Color.MediumSeaGreen;
            btnChnagePrice.ForeColor = Color.White;
        }

        private void btnChnagePrice_MouseLeave(object sender, EventArgs e)
        {
            btnChnagePrice.BackColor = Color.Gold;
            btnChnagePrice.ForeColor = Color.Black;
        }

        private void btnCreditSales_Click(object sender, EventArgs e)
        {
            Options.frmCreditSales CreditSales = new Options.frmCreditSales();
            CreditSales.Show();
        }

        private void btnCreditSales_MouseEnter(object sender, EventArgs e)
        {
            btnCreditSales.BackColor = Color.MediumSeaGreen;
            btnCreditSales.ForeColor = Color.White;
        }

        private void btnCreditSales_MouseLeave(object sender, EventArgs e)
        {
            btnCreditSales.BackColor = Color.Gold;
            btnCreditSales.ForeColor = Color.Black;
        }

        private void btnReprintInvoice_Click(object sender, EventArgs e)
        {
            Options.frmPrintInvoice ReprintInvoice = new Options.frmPrintInvoice();
            ReprintInvoice.Show();
        }

        private void btnReprintInvoice_MouseEnter(object sender, EventArgs e)
        {
            btnReprintInvoice.BackColor = Color.MediumSeaGreen;
            btnReprintInvoice.ForeColor = Color.White;
        }

        private void btnReprintInvoice_MouseLeave(object sender, EventArgs e)
        {
            btnReprintInvoice.BackColor = Color.Gold;
            btnReprintInvoice.ForeColor = Color.Black;
        }

        private void btnSalesReturn_Click(object sender, EventArgs e)
        {
            Options.frmSalesReturn SalesReturn = new Options.frmSalesReturn();
            SalesReturn.Show();
        }

        private void btnSalesReturn_MouseEnter(object sender, EventArgs e)
        {
            btnSalesReturn.BackColor = Color.MediumSeaGreen;
            btnSalesReturn.ForeColor = Color.White;
        }

        private void btnSalesReturn_MouseLeave(object sender, EventArgs e)
        {
            btnSalesReturn.BackColor = Color.Gold;
            btnSalesReturn.ForeColor = Color.Black;
        }


        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            int selectedCount = gridItemMaster.SelectedRows.Count;
            while (selectedCount > 0)
            {
                if (!gridItemMaster.SelectedRows[0].IsNewRow)
                    gridItemMaster.Rows.RemoveAt(gridItemMaster.SelectedRows[0].Index);
                selectedCount--;
            }
            CalculateItem();
            txtQuantity.Text ="1";
        }
        void CalculateItem()
        {
            if(gridItemMaster.RowCount > 0)
            {
                double tot = 0;

                for (int i = 0; i <= gridItemMaster.RowCount - 1; i++)
                {
                    tot += Convert.ToDouble(gridItemMaster.Rows[i].Cells["COST"].Value);
                }
                lblTotal.Text = tot.ToString();

                int qty = 0;
                for (int x = 0; x < gridItemMaster.Rows.Count; x++)
                {
                    qty += Convert.ToInt32(gridItemMaster.Rows[x].Cells["QTY"].Value);
                }
                lblqty.Text = qty.ToString();
            }

        }

        private void btnCancelItem_MouseEnter(object sender, EventArgs e)
        {
            btnCancelItem.BackColor = Color.MediumSeaGreen;
            btnCancelItem.ForeColor = Color.White;
        }

        private void btnCancelItem_MouseLeave(object sender, EventArgs e)
        {
            btnCancelItem.BackColor = Color.Gold;
            btnCancelItem.ForeColor = Color.Black;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsDebug.frmSettings Setting = new SettingsDebug.frmSettings();
            Setting.Show();

        }


        private void btnPanelPayShow_Click(object sender, EventArgs e)
        {
            panelPay.Width = 373;
            btnPanelPayHide.Show();
            btnPanelPayShow.Hide();
        }

        private void btnPanelPayHide_Click(object sender, EventArgs e)
        {
            panelPay.Width = 35;
            btnPanelPayHide.Hide();
            btnPanelPayShow.Show();
        }

        private int a = 1;
        private void btnQuanIncrease_Click(object sender, EventArgs e)
        {
            a++;
            pbError.Hide();
            lblQuantError.Hide();
            txtQuantity.Text = a.ToString();
        }

        private void btnQuantityDecrease_Click(object sender, EventArgs e)
        {
            if (a >= 2)
            {
                a--;
                txtQuantity.Text = a.ToString();
            }
            else
            {
                pbError.Show();
                lblQuantError.Show();
                lblQuantError.Text = "Quantity cannot be less than one";
            }
        }

        public int Finditem(string item)
        {
            int k = -1;
            if (gridItemMaster.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in gridItemMaster.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if (row.Cells[0].Value.ToString().Equals(item))
                        {
                            k = row.Index;
                            break;
                        }
                    }
                }
            }
            return k;
        }
        private void txtBarcodeReaderBox_Enter(object sender, EventArgs e)
        {
            {
                if (txtBarcodeReaderBox.Text == "Please Enter Barcode To Add Item In Cart")
                {
                    txtBarcodeReaderBox.Text = "";
                    txtBarcodeReaderBox.ForeColor = SystemColors.WindowText;
                }
            }
        }

        private void txtBarcodeReaderBox_Leave(object sender, EventArgs e)
        {
            {
                if (txtBarcodeReaderBox.Text.Length == 0)
                {
                    txtBarcodeReaderBox.Text = "Please Enter Barcode To Add Item In Cart";
                    txtBarcodeReaderBox.ForeColor = SystemColors.GrayText;
                }
            }
        }

        private void txtBarcodeReaderBox_TextChanged(object sender, EventArgs e)
        {
            {
                SqlCommand cmd = new SqlCommand("select * from STOCK where PRDCODE= '" +txtBarcodeReaderBox.Text+ "' ", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    cmd = new SqlCommand("select * from SALES where PRDCODE = @PRDCODE", con);
                    cmd.Parameters.AddWithValue("@PRDCODE", dt.Rows[0]["PRDCODE"].ToString());
                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        sdr.Close();
                        cmd = new SqlCommand("Update SALES set QTY=@QTY Where PRDCODE= '" + dt.Rows[0]["PRDCODE"] + "'", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@QTY", Convert.ToInt32(dt1.Rows[0]["QTY"]) + Convert.ToInt32(txtQuantity.Text));
                        //cmd.Parameters.AddWithValue("@COST", Convert.ToDouble(dt1.Rows[0]["COST"]) *(Convert.ToInt32(dt1.Rows[0]["QTY"])+ Convert.ToDouble(txtQuantity.Text)));
                        cmd.ExecuteNonQuery();
                        CalculateItem();
                    }
                    else
                    {
                        sdr.Close();
                        cmd = new SqlCommand("insert into SALES(PRDCODE,PRDNAME,QTY,PRICE,COST)Values(@PRDCODE,@PRDNAME,@QTY,@PRICE,@COST)", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@PRDCODE", dt.Rows[0]["PRDCODE"].ToString());
                        cmd.Parameters.AddWithValue("@PRDNAME", dt.Rows[0]["PRDNAME"].ToString());
                        cmd.Parameters.AddWithValue("@QTY", Convert.ToInt32(txtQuantity.Text));
                        cmd.Parameters.AddWithValue("@PRICE", Convert.ToDouble(dt.Rows[0]["PRICE"]));
                        cmd.Parameters.AddWithValue("@COST", Convert.ToDouble(dt.Rows[0]["PRICE"]) * Convert.ToDouble(txtQuantity.Text));
                        cmd.ExecuteNonQuery();
                    }







                    //cmd = new SqlCommand("select * from SALES ", con);
                    //SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                    //DataTable dt1 = new DataTable();
                    //sda1.Fill(dt1);
                    //if (dt1.Rows.Count>0)
                    //{
                    //for (int i = 0; i>=dt1.Rows.Count-1; i++)
                    //{
                    //    if (dt.Rows[0]["PRDCODE"].ToString() == dt1.Rows[i]["PRDCODE"].ToString())
                    //    {
                    //        cmd = new SqlCommand("Update SALES set QTY=@QTY Where PRDCODE= '" + dt.Rows[0]["PRDCODE"] + "'", con);
                    //        cmd.CommandType = CommandType.Text;
                    //        cmd.Parameters.AddWithValue("@QTY", Convert.ToInt32(dt1.Rows[i]["QTY"]) + Convert.ToInt32(txtQuantity.Text));
                    //        //cmd.Parameters.AddWithValue("@COST", Convert.ToDouble(dt1.Rows[0]["COST"]) + Convert.ToInt32(txtQuantity.Text));
                    //        cmd.ExecuteNonQuery();
                    //    }
                    //    else
                    //    {
                    //        cmd = new SqlCommand("insert into SALES(PRDCODE,PRDNAME,QTY,PRICE,COST)Values(@PRDCODE,@PRDNAME,@QTY,@PRICE,@COST)", con);
                    //        cmd.CommandType = CommandType.Text;
                    //        cmd.Parameters.AddWithValue("@PRDCODE", dt.Rows[0]["PRDCODE"].ToString());
                    //        cmd.Parameters.AddWithValue("@PRDNAME", dt.Rows[0]["PRDNAME"].ToString());
                    //        cmd.Parameters.AddWithValue("@QTY", Convert.ToInt32(txtQuantity.Text));
                    //        cmd.Parameters.AddWithValue("@PRICE", Convert.ToDouble(dt.Rows[0]["PRICE"]));
                    //        cmd.Parameters.AddWithValue("@COST", Convert.ToDouble(dt.Rows[0]["PRICE"]) * Convert.ToDouble(txtQuantity.Text));
                    //        cmd.ExecuteNonQuery();
                    //    }
                    //}

                    // }

                    // else
                    //{
                    //cmd = new SqlCommand("insert into SALES(PRDCODE,PRDNAME,QTY,PRICE,COST)Values(@PRDCODE,@PRDNAME,@QTY,@PRICE,@COST)", con);
                    //cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@PRDCODE", dt.Rows[0]["PRDCODE"].ToString());
                    //cmd.Parameters.AddWithValue("@PRDNAME", dt.Rows[0]["PRDNAME"].ToString());
                    //cmd.Parameters.AddWithValue("@QTY", Convert.ToInt32(txtQuantity.Text));
                    //cmd.Parameters.AddWithValue("@PRICE", Convert.ToDouble(dt.Rows[0]["PRICE"]));
                    //cmd.Parameters.AddWithValue("@COST", Convert.ToDouble(dt.Rows[0]["PRICE"]) * Convert.ToDouble(txtQuantity.Text));
                    //cmd.ExecuteNonQuery();
                    // }
                }
                fillitemmaster();
                con.Close();
                //gridSKU.DataSource = dt;
                //{
                //    var List = (from a in db.STOCKs
                //                where a.PRDCODE == txtBarcodeReaderBox.Text
                //                select new
                //                {
                //                    ProductCode = a.PRDCODE,
                //                    ProductName = a.PRDNAME,
                //                    UnitPrice = a.PRICE,
                //                    Quantity = txtQuantity.Text,
                //                }).SingleOrDefault();
                //    if (List != null)
                //    {

                //        int n = Finditem(List.ProductCode);
                //        if (n == -1)  //If new item
                //        {

                //            double TotalAmountProduct = Convert.ToDouble(List.UnitPrice) * Convert.ToDouble(List.Quantity);
                //            gridItemMaster.Rows.Add(List.ProductCode, List.ProductName, List.UnitPrice, List.Quantity, TotalAmountProduct);
                //            a = 1;
                //            txtQuantity.Text = a.ToString();
                //            txtBarcodeReaderBox.Text = "";
                //        }
                //        else
                //        {
                //            int QtyInc = Convert.ToInt32(gridItemMaster.Rows[n].Cells["Quantity"].Value);
                //            double UnitP = Convert.ToDouble(gridItemMaster.Rows[n].Cells["UnitPrice"].Value);
                //            gridItemMaster.Rows[n].Cells["Quantity"].Value = (QtyInc + 1);  //Qty Increase by MinOrderQty....as needed...
                //            gridItemMaster.Rows[n].Cells["Total"].Value = (UnitP * Convert.ToDouble(gridItemMaster.Rows[n].Cells["Quantity"].Value));
                //            a = 1;
                //            txtQuantity.Text = a.ToString();
                //            txtBarcodeReaderBox.Text = "";
                //        }
                //        //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
                //        //SqlConnection con = new SqlConnection(@"Data Source = MDEVPC-42\SQLEXPRESS;initial catalog = PosLocal; User = sa; Password = sa@123");

                //        //SqlCommand cmd = new SqlCommand("insert into SALES(PRDCODE,PRDNAME)Values(@PRDCODE,@PRDNAME)", con);
                //        //cmd.CommandType = CommandType.Text;
                //        //cmd.Parameters.AddWithValue("@PRDCODE", "1");
                //        //cmd.Parameters.AddWithValue("@PRDNAME", "1");
                //        //con.Open();
                //        //int i = cmd.ExecuteNonQuery();

                //        //con.Close();

                //        //if (i != 0)
                //        //{
                //        //    MessageBox.Show(i + "Data Saved");
                //        //}
                //    }
                //    CalculateItem();

                //}                
                //gridItemMaster.ClearSelection();
            }
            CalculateItem();
        }

        private void gridSKU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = gridSKU.Rows[index];
            txtBarcodeReaderBox.Text = selectedRow.Cells["PRDCODE"].Value.ToString();
            panelSKU.Hide();
            panelBottom2.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                btnAppClose.PerformClick(); //Closes the Applicat
            }
            if (keyData == (Keys.Enter))
            {
                btnPay.PerformClick();  //Shift+P for Open Payment Page 
            }
            else if (keyData == (Keys.F5))
            {
                btnCancelOrder.PerformClick(); // Shift+S -> Suspen
            }
            else if (keyData == (Keys.Shift | Keys.Up))
            {
                btnQuanIncrease.PerformClick(); //Increase Quantity Value 
            }
            else if (keyData == (Keys.Shift | Keys.Down))
            {
                btnQuantityDecrease.PerformClick(); //Increase Quantity Value 
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBarcodeReaderBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }

}