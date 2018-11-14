namespace RetailConnectPOS.Options
{
    partial class frmPrintInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintInvoice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPOSReportclose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBarcodeReaderBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new RetailConnect.Classes.CurveButton();
            this.curveButton1 = new RetailConnect.Classes.CurveButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.btnPOSReportclose);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 30);
            this.panel1.TabIndex = 19;
            // 
            // btnPOSReportclose
            // 
            this.btnPOSReportclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPOSReportclose.BackgroundImage")));
            this.btnPOSReportclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPOSReportclose.FlatAppearance.BorderSize = 0;
            this.btnPOSReportclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOSReportclose.Location = new System.Drawing.Point(473, 2);
            this.btnPOSReportclose.Name = "btnPOSReportclose";
            this.btnPOSReportclose.Size = new System.Drawing.Size(30, 25);
            this.btnPOSReportclose.TabIndex = 4;
            this.btnPOSReportclose.UseVisualStyleBackColor = false;
            this.btnPOSReportclose.Click += new System.EventHandler(this.btnPOSReportclose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Re-Print Invoice";
            // 
            // txtBarcodeReaderBox
            // 
            this.txtBarcodeReaderBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcodeReaderBox.ForeColor = System.Drawing.Color.Black;
            this.txtBarcodeReaderBox.Location = new System.Drawing.Point(116, 255);
            this.txtBarcodeReaderBox.Name = "txtBarcodeReaderBox";
            this.txtBarcodeReaderBox.Size = new System.Drawing.Size(273, 33);
            this.txtBarcodeReaderBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Invoice No.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(9, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 208);
            this.dataGridView1.TabIndex = 20;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Gold;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(393, 36);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 45);
            this.btnRefresh.TabIndex = 47;
            this.btnRefresh.Text = "OK";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // curveButton1
            // 
            this.curveButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.curveButton1.BackColor = System.Drawing.Color.Gold;
            this.curveButton1.FlatAppearance.BorderSize = 0;
            this.curveButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curveButton1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curveButton1.Location = new System.Drawing.Point(393, 184);
            this.curveButton1.Name = "curveButton1";
            this.curveButton1.Size = new System.Drawing.Size(110, 107);
            this.curveButton1.TabIndex = 48;
            this.curveButton1.Text = "Full Tax\r\nInvoice";
            this.curveButton1.UseVisualStyleBackColor = false;
            // 
            // frmPrintInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(506, 300);
            this.Controls.Add(this.curveButton1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBarcodeReaderBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrintInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrintInvoice";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPOSReportclose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBarcodeReaderBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RetailConnect.Classes.CurveButton btnRefresh;
        private RetailConnect.Classes.CurveButton curveButton1;
    }
}