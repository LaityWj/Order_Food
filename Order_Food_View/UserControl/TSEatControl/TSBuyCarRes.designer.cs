using System;
using Smobiler.Core;
namespace Order_Food_View.UserControl.TSEatControl
{
    partial class TSBuyCarRes : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panbuy = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.labmoney = new Smobiler.Core.Controls.Label();
            this.btndes = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.btnplus = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.labid = new Smobiler.Core.Controls.Label();
            // 
            // panbuy
            // 
            this.panbuy.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.labmoney,
            this.btndes,
            this.textBox1,
            this.btnplus,
            this.label2,
            this.labid});
            this.panbuy.Name = "panbuy";
            this.panbuy.Size = new System.Drawing.Size(400, 89);
            // 
            // label1
            // 
            this.label1.FontSize = 17F;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 35);
            this.label1.Text = "label1";
            // 
            // labmoney
            // 
            this.labmoney.FontSize = 18F;
            this.labmoney.ForeColor = System.Drawing.Color.Red;
            this.labmoney.Location = new System.Drawing.Point(187, 16);
            this.labmoney.Name = "labmoney";
            this.labmoney.Size = new System.Drawing.Size(61, 35);
            this.labmoney.Text = "25";
            // 
            // btndes
            // 
            this.btndes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btndes.BorderRadius = 2;
            this.btndes.ForeColor = System.Drawing.Color.Black;
            this.btndes.Location = new System.Drawing.Point(283, 16);
            this.btndes.Name = "btndes";
            this.btndes.Size = new System.Drawing.Size(30, 30);
            this.btndes.Text = "-";
            this.btndes.Press += new System.EventHandler(this.button1_Press);
            // 
            // textBox1
            // 
            this.textBox1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.textBox1.Location = new System.Drawing.Point(319, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 30);
            this.textBox1.Text = "1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnplus.BorderRadius = 2;
            this.btnplus.ForeColor = System.Drawing.Color.Black;
            this.btnplus.Location = new System.Drawing.Point(356, 16);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(30, 30);
            this.btnplus.Text = "+";
            this.btnplus.Press += new System.EventHandler(this.button2_Press);
            // 
            // label2
            // 
            this.label2.FontSize = 18F;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(167, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 35);
            this.label2.Text = "￥";
            // 
            // labid
            // 
            this.labid.Location = new System.Drawing.Point(97, 51);
            this.labid.Name = "labid";
            this.labid.Size = new System.Drawing.Size(100, 35);
            this.labid.Text = "label3";
            this.labid.Visible = false;
            // 
            // TSBuyCarRes
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panbuy});
            this.Size = new System.Drawing.Size(400, 184);
            this.Load += new System.EventHandler(this.TSBuyCarRes_Load);
            this.Name = "TSBuyCarRes";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panbuy;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label labmoney;
        private Smobiler.Core.Controls.Button btndes;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Button btnplus;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label labid;
    }
}