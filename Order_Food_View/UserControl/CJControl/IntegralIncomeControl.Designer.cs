using System;
using Smobiler.Core;
namespace Order_Food_View.UserControl
{
    partial class IntegralIncomeControl : Smobiler.Core.Controls.MobileUserControl
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
            this.lab_XFType = new Smobiler.Core.Controls.Label();
            this.lab_XFTime = new Smobiler.Core.Controls.Label();
            this.lab_XFYe = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lab_XFType,
            this.lab_XFTime,
            this.lab_XFYe});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 46);
            // 
            // lab_XFType
            // 
            this.lab_XFType.DataMember = "XFType";
            this.lab_XFType.DisplayMember = "XFType";
            this.lab_XFType.Name = "lab_XFType";
            this.lab_XFType.Size = new System.Drawing.Size(143, 20);
            this.lab_XFType.Text = "label1";
            // 
            // lab_XFTime
            // 
            this.lab_XFTime.DataMember = "XFTime";
            this.lab_XFTime.DisplayMember = "XFTime";
            this.lab_XFTime.ForeColor = System.Drawing.Color.DarkGray;
            this.lab_XFTime.Location = new System.Drawing.Point(0, 27);
            this.lab_XFTime.Name = "lab_XFTime";
            this.lab_XFTime.Size = new System.Drawing.Size(175, 18);
            this.lab_XFTime.Text = "label1";
            // 
            // lab_XFYe
            // 
            this.lab_XFYe.DataMember = "XFYe";
            this.lab_XFYe.DisplayMember = "XFYe";
            this.lab_XFYe.FontSize = 14F;
            this.lab_XFYe.ForeColor = System.Drawing.Color.Red;
            this.lab_XFYe.Location = new System.Drawing.Point(252, 0);
            this.lab_XFYe.Name = "lab_XFYe";
            this.lab_XFYe.Size = new System.Drawing.Size(60, 27);
            this.lab_XFYe.Text = "label1";
            // 
            // IntegralIncomeControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 46);
            this.Name = "IntegralIncomeControl";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label lab_XFType;
        private Smobiler.Core.Controls.Label lab_XFTime;
        private Smobiler.Core.Controls.Label lab_XFYe;
    }
}