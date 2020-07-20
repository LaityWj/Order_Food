using System;
using Smobiler.Core;
namespace SmobilerApplication1.Layout
{
    partial class OrderType : Smobiler.Core.Controls.MobileUserControl
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
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.labmoney = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.labnumber = new Smobiler.Core.Controls.Label();
            this.line2 = new Smobiler.Core.Controls.Line();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label2,
            this.label3,
            this.label4,
            this.labmoney,
            this.label6,
            this.labnumber,
            this.line2});
            this.panel1.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 111);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(22, 15);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(125, 71);
            // 
            // label2
            // 
            this.label2.DataMember = "name";
            this.label2.DisplayMember = "name";
            this.label2.Location = new System.Drawing.Point(173, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.FontSize = 15F;
            this.label3.Location = new System.Drawing.Point(344, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 22);
            this.label3.Text = "×";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(173, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 21);
            this.label4.Text = "￥";
            // 
            // labmoney
            // 
            this.labmoney.DataMember = "money";
            this.labmoney.DisplayMember = "money";
            this.labmoney.ForeColor = System.Drawing.Color.Red;
            this.labmoney.Location = new System.Drawing.Point(187, 53);
            this.labmoney.Name = "labmoney";
            this.labmoney.Size = new System.Drawing.Size(26, 24);
            this.labmoney.Text = "25";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(205, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 25);
            this.label6.Text = "/份";
            // 
            // labnumber
            // 
            this.labnumber.DataMember = "number";
            this.labnumber.Location = new System.Drawing.Point(357, 50);
            this.labnumber.Name = "labnumber";
            this.labnumber.Size = new System.Drawing.Size(32, 20);
            this.labnumber.Text = "1";
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.Silver;
            this.line2.Location = new System.Drawing.Point(0, 106);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(400, 1);
            // 
            // OrderType
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(400, 111);
            this.Load += new System.EventHandler(this.OrderType_Load);
            this.Name = "OrderType";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label labmoney;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Label labnumber;
        private Smobiler.Core.Controls.Line line2;
    }
}