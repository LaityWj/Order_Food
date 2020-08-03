using System;
using Smobiler.Core;
namespace Order_Food_View.UserControl.TSEatControl
{
    partial class TSBuyCar : Smobiler.Core.Controls.MobileUserControl
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lab_menusname = new Smobiler.Core.Controls.Label();
            this.lab_price = new Smobiler.Core.Controls.Label();
            this.btnplus = new Smobiler.Core.Controls.Button();
            this.text_number = new Smobiler.Core.Controls.TextBox();
            this.btndes = new Smobiler.Core.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.imageButton1});
            this.panel1.Location = new System.Drawing.Point(0, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 43);
            // 
            // label2
            // 
            this.label2.FontSize = 15F;
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.Text = "已选商品";
            // 
            // imageButton1
            // 
            this.imageButton1.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.imageButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton1.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton1.Location = new System.Drawing.Point(179, 6);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "trash-o";
            this.imageButton1.Size = new System.Drawing.Size(119, 31);
            this.imageButton1.Text = "清空购物车";
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.lab_menusname,
            this.lab_price,
            this.btnplus,
            this.text_number,
            this.btndes});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Scrollable = true;
            this.panel2.Size = new System.Drawing.Size(300, 184);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 35);
            this.label1.Text = "label1";
            // 
            // lab_menusname
            // 
            this.lab_menusname.Location = new System.Drawing.Point(10, 49);
            this.lab_menusname.Name = "lab_menusname";
            this.lab_menusname.Size = new System.Drawing.Size(100, 35);
            this.lab_menusname.Text = "label3";
            // 
            // lab_price
            // 
            this.lab_price.Location = new System.Drawing.Point(128, 49);
            this.lab_price.Name = "lab_price";
            this.lab_price.Size = new System.Drawing.Size(56, 35);
            this.lab_price.Text = "label3";
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnplus.BorderRadius = 2;
            this.btnplus.ForeColor = System.Drawing.Color.Black;
            this.btnplus.Location = new System.Drawing.Point(278, 57);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(16, 18);
            this.btnplus.Text = "+";
            this.btnplus.Press += new System.EventHandler(this.button2_Press);
            // 
            // text_number
            // 
            this.text_number.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.text_number.Location = new System.Drawing.Point(255, 57);
            this.text_number.Name = "text_number";
            this.text_number.Size = new System.Drawing.Size(20, 18);
            this.text_number.Text = "1";
            this.text_number.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btndes
            // 
            this.btndes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btndes.BorderRadius = 2;
            this.btndes.ForeColor = System.Drawing.Color.Black;
            this.btndes.Location = new System.Drawing.Point(235, 57);
            this.btndes.Name = "btndes";
            this.btndes.Size = new System.Drawing.Size(16, 18);
            this.btndes.Text = "-";
            this.btndes.Press += new System.EventHandler(this.button1_Press);
            // 
            // TSBuyCar
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2});
            this.Size = new System.Drawing.Size(300, 220);
            this.Load += new System.EventHandler(this.TSBuyCar_Load);
            this.Name = "TSBuyCar";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label lab_menusname;
        private Smobiler.Core.Controls.Label lab_price;
        private Smobiler.Core.Controls.Button btnplus;
        private Smobiler.Core.Controls.TextBox text_number;
        private Smobiler.Core.Controls.Button btndes;
    }
}