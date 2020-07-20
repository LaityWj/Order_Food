using System;
using Smobiler.Core;
namespace Order_Food_View.Layout
{
    partial class frmResList : Smobiler.Core.Controls.MobileUserControl
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
            this.swipeView1 = new Smobiler.Core.Controls.SwipeView();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.labname = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.labMoney = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.labNumber = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.btndes = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.btnplus = new Smobiler.Core.Controls.Button();
            // 
            // swipeView1
            // 
            this.swipeView1.BorderColor = System.Drawing.Color.Silver;
            this.swipeView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.swipeView1.Name = "swipeView1";
            this.swipeView1.Size = new System.Drawing.Size(300, 100);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.labname,
            this.label2,
            this.labMoney,
            this.label4,
            this.label3,
            this.labNumber,
            this.label5,
            this.btndes,
            this.textBox1,
            this.btnplus});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // image1
            // 
            this.image1.DataMember = "Menu_Pecture";
            this.image1.DisplayMember = "Menu_Pecture";
            this.image1.Location = new System.Drawing.Point(3, 2);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(96, 94);
            // 
            // labname
            // 
            this.labname.DataMember = "Menu_Name";
            this.labname.DisplayMember = "Menu_Name";
            this.labname.FontSize = 18F;
            this.labname.Location = new System.Drawing.Point(111, 6);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(100, 35);
            this.labname.Text = "小炒菜";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(112, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 35);
            this.label2.Text = "￥";
            // 
            // labMoney
            // 
            this.labMoney.DataMember = "Menu_Price";
            this.labMoney.DisplayMember = "Menu_Price";
            this.labMoney.ForeColor = System.Drawing.Color.Red;
            this.labMoney.Location = new System.Drawing.Point(128, 41);
            this.labMoney.Name = "labMoney";
            this.labMoney.Size = new System.Drawing.Size(100, 35);
            this.labMoney.Text = "15";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(144, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 35);
            this.label4.Text = "/份";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(111, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.Text = "月销：";
            // 
            // labNumber
            // 
            this.labNumber.DataMember = "number";
            this.labNumber.DisplayMember = "number";
            this.labNumber.ForeColor = System.Drawing.Color.DimGray;
            this.labNumber.Location = new System.Drawing.Point(146, 65);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(100, 35);
            this.labNumber.Text = "400";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(171, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 35);
            this.label5.Text = "份";
            // 
            // btndes
            // 
            this.btndes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btndes.BorderRadius = 2;
            this.btndes.ForeColor = System.Drawing.Color.Black;
            this.btndes.Location = new System.Drawing.Point(216, 73);
            this.btndes.Name = "btndes";
            this.btndes.Size = new System.Drawing.Size(16, 18);
            this.btndes.Text = "-";
            this.btndes.Press += new System.EventHandler(this.button1_Press);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 18);
            this.textBox1.Text = "1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnplus.BorderRadius = 2;
            this.btnplus.ForeColor = System.Drawing.Color.Black;
            this.btnplus.Location = new System.Drawing.Point(266, 73);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(16, 18);
            this.btnplus.Text = "+";
            this.btnplus.Press += new System.EventHandler(this.button2_Press);
            // 
            // frmResList
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.swipeView1});
            this.Size = new System.Drawing.Size(300, 100);
            this.Load += new System.EventHandler(this.frmResList_Load);
            this.Name = "frmResList";

        }
        #endregion

        private Smobiler.Core.Controls.SwipeView swipeView1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label labname;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label labMoney;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label labNumber;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Button btndes;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Button btnplus;
    }
}