using System;
using Smobiler.Core;
namespace Order_Food_View.UserControl
{
    partial class ShowCouPonControl : Smobiler.Core.Controls.MobileUserControl
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
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.lab_ym = new Smobiler.Core.Controls.Label();
            this.lab_type = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lab_use = new Smobiler.Core.Controls.Label();
            this.btn_use = new Smobiler.Core.Controls.Button();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lab_ym,
            this.lab_type,
            this.line1});
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 74);
            // 
            // lab_ym
            // 
            this.lab_ym.DataMember = "money";
            this.lab_ym.DisplayMember = "money";
            this.lab_ym.FontSize = 18F;
            this.lab_ym.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lab_ym.Name = "lab_ym";
            this.lab_ym.Size = new System.Drawing.Size(125, 38);
            this.lab_ym.Text = "label1";
            // 
            // lab_type
            // 
            this.lab_type.DataMember = "TypeName";
            this.lab_type.DisplayMember = "TypeName";
            this.lab_type.FontSize = 16F;
            this.lab_type.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lab_type.Location = new System.Drawing.Point(0, 31);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(125, 35);
            this.lab_type.Text = "label2";
            // 
            // label1
            // 
            this.label1.DataMember = "UseDate";
            this.label1.DisplayMember = "UseDate";
            this.label1.FontSize = 12F;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(127, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.Text = "label1";
            // 
            // lab_use
            // 
            this.lab_use.DataMember = "UseType";
            this.lab_use.DisplayMember = "UseType";
            this.lab_use.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lab_use.Location = new System.Drawing.Point(127, 0);
            this.lab_use.Name = "lab_use";
            this.lab_use.Size = new System.Drawing.Size(100, 32);
            this.lab_use.Text = "label3";
            // 
            // btn_use
            // 
            this.btn_use.FontSize = 12F;
            this.btn_use.Location = new System.Drawing.Point(237, 0);
            this.btn_use.Name = "btn_use";
            this.btn_use.Size = new System.Drawing.Size(58, 23);
            // 
            // listView1
            // 
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(295, 74);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Gainsboro;
            this.line1.Location = new System.Drawing.Point(0, 74);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(320, 1);
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.Silver;
            this.line2.Location = new System.Drawing.Point(0, 77);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(298, 1);
            // 
            // ShowCouPonControl
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView1,
            this.panel2,
            this.label1,
            this.lab_use,
            this.btn_use,
            this.line2});
            this.Size = new System.Drawing.Size(297, 77);
            this.Load += new System.EventHandler(this.ShowCouPonControl_Load);
            this.Name = "ShowCouPonControl";

        }
        #endregion
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label lab_use;
        private Smobiler.Core.Controls.Button btn_use;
        private Smobiler.Core.Controls.Label lab_ym;
        private Smobiler.Core.Controls.Label lab_type;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
    }
}