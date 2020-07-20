using System;
using Smobiler.Core;
namespace Order_Food_View.Layout
{
    partial class FrmResType : Smobiler.Core.Controls.MobileUserControl
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
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 108);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BorderRadius = 0;
            this.button1.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dashed;
            this.button1.DataMember = "Food_Name";
            this.button1.DisplayMember = "Food_Name";
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 108);
            this.button1.Text = "精品推荐";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // FrmResType
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(100, 108);
            this.Name = "FrmResType";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Button button1;
    }
}