using System;
using Smobiler.Core;
namespace Order_Food_View.Layout
{
    partial class BuyCar : Smobiler.Core.Controls.MobileUserControl
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.labmoney = new Smobiler.Core.Controls.Label();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.CarListView = new Smobiler.Core.Controls.ListView();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 30);
            this.label1.Text = "起送价 ￥25，满80免配送费";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.label3,
            this.labmoney,
            this.imageButton1});
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 43);
            // 
            // label2
            // 
            this.label2.FontSize = 15F;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.Text = "已选商品 包装费";
            // 
            // label3
            // 
            this.label3.FontSize = 15F;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(127, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.Text = "￥";
            // 
            // labmoney
            // 
            this.labmoney.BorderColor = System.Drawing.Color.Red;
            this.labmoney.FontSize = 15F;
            this.labmoney.ForeColor = System.Drawing.Color.Red;
            this.labmoney.Location = new System.Drawing.Point(143, 10);
            this.labmoney.Name = "labmoney";
            this.labmoney.Size = new System.Drawing.Size(52, 18);
            this.labmoney.Text = "3";
            // 
            // imageButton1
            // 
            this.imageButton1.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.imageButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton1.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton1.Location = new System.Drawing.Point(265, 4);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "trash-o";
            this.imageButton1.Size = new System.Drawing.Size(119, 31);
            this.imageButton1.Text = "清空购物车";
            // 
            // CarListView
            // 
            this.CarListView.Location = new System.Drawing.Point(0, 105);
            this.CarListView.Name = "CarListView";
            this.CarListView.Size = new System.Drawing.Size(400, 185);
            // 
            // BuyCar
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.panel1,
            this.CarListView});
            this.Horizontal = true;
            this.JustifyAlign = Smobiler.Core.Controls.LayoutJustifyAlign.FlexEnd;
            this.Padding = new Smobiler.Core.Controls.Padding(70F, 50F, 70F, 0F);
            this.Size = new System.Drawing.Size(400, 290);
            this.Name = "BuyCar";

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label labmoney;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.ListView CarListView;
    }
}