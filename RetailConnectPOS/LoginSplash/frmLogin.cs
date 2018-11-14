using RetailConnectPOS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailConnectPOS.LoginSplash
{
    public partial class frmLogin : Form
    {
        DBModelContext db = new DBModelContext();

        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
            lblPasswordError.Hide();
            pbPasswordError.Hide();
            lblUsernameError.Hide();
            pbUsernameError.Hide();

            }
        internal class UserInformation
            {
            public static string CurrentLoggedInUser
                {
                get;
                set;
                }
            }

        public void Splash()
        {
            Application.Run(new LoginSplash.frmSplash());
        }        

        private void btnLogin_Click(object sender, EventArgs e)
            {
            if (string.IsNullOrEmpty(txtUsername.Text))
                {
                lblUsernameError.Show();
                lblUsernameError.Text = "Username Required";
                pbUsernameError.Show();
                txtUsername.Focus();
                return;
                }
            if (string.IsNullOrEmpty(txtPassword.Text))
                {
                lblPasswordError.Show();
                lblPasswordError.Text = "Password Required";
                pbPasswordError.Show();
                txtPassword.Focus();
                }
                try
                {               
                    
                    var List = (from u in db.PUSERs
                                where u.UserName == txtUsername.Text && u.UserPassword == txtPassword.Text
                                select u).SingleOrDefault();

                if (List != null)
                    {
                    MessageBox.Show("Succesvol! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard.frmCashier Cashier = new Dashboard.frmCashier();
                    Cashier.Show();
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
                }

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
        
        }
}
