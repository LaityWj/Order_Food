using System;
using Smobiler.Core;
namespace Order_Food_View.UserControl
{
    partial class OrderUserControl : Smobiler.Core.Controls.MobileUserControl
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
            this.lab_CName = new Smobiler.Core.Controls.Label();
            this.lab_Price = new Smobiler.Core.Controls.Label();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            // 
            // lab_CName
            // 
            this.lab_CName.Bold = true;
            this.lab_CName.DataMember = "MenuName";
            this.lab_CName.DisplayMember = "MenuName";
            this.lab_CName.FontSize = 14F;
            this.lab_CName.Location = new System.Drawing.Point(4, 6);
            this.lab_CName.Name = "lab_CName";
            this.lab_CName.Size = new System.Drawing.Size(90, 18);
            // 
            // lab_Price
            // 
            this.lab_Price.Bold = true;
            this.lab_Price.DataMember = "Price";
            this.lab_Price.DisplayMember = "Price";
            this.lab_Price.ForeColor = System.Drawing.Color.Red;
            this.lab_Price.Location = new System.Drawing.Point(4, 22);
            this.lab_Price.Name = "lab_Price";
            this.lab_Price.Size = new System.Drawing.Size(81, 21);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lab_CName,
            this.lab_Price,
            this.label1,
            this.label2,
            this.label3});
            this.panel4.Location = new System.Drawing.Point(82, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 80);
            // 
            // image1
            // 
            this.image1.DataMember = "Image";
            this.image1.DisplayMember = "Image";
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(82, 80);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Gainsboro;
            this.line1.Location = new System.Drawing.Point(1, 80);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(348, 1);
            // 
            // label1
            // 
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label1.Location = new System.Drawing.Point(103, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 18);
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.DataMember = "Number";
            this.label2.DisplayMember = "Number";
            this.label2.Location = new System.Drawing.Point(129, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.Text = "少盐，少油";
            // 
            // OrderUserControl
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel4,
            this.image1,
            this.line1});
            this.Size = new System.Drawing.Size(0, 82);
            this.Name = "OrderUserControl";

        }
        #endregion
        private Smobiler.Core.Controls.Label lab_CName;
        private Smobiler.Core.Controls.Label lab_Price;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
    }
}