using System;
using Smobiler.Core;
namespace SmobilerApplication1.Layout
{
    partial class TableWare : Smobiler.Core.Controls.MobileUserControl
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
            this.picker1 = new Smobiler.Core.Controls.Picker();
            this.butNo = new Smobiler.Core.Controls.Button();
            this.butSure = new Smobiler.Core.Controls.Button();
            // 
            // picker1
            // 
            this.picker1.FontSize = 20F;
            this.picker1.Items = new string[] {
        "无需餐具",
        "一份",
        "两份",
        "三份"};
            this.picker1.Location = new System.Drawing.Point(0, 51);
            this.picker1.Name = "picker1";
            this.picker1.Size = new System.Drawing.Size(400, 227);
            // 
            // butNo
            // 
            this.butNo.BackColor = System.Drawing.Color.White;
            this.butNo.BorderRadius = 0;
            this.butNo.FontSize = 15F;
            this.butNo.ForeColor = System.Drawing.Color.Black;
            this.butNo.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.butNo.Location = new System.Drawing.Point(9, 11);
            this.butNo.Name = "butNo";
            this.butNo.Size = new System.Drawing.Size(66, 30);
            this.butNo.Text = "取消";
            this.butNo.Press += new System.EventHandler(this.butNo_Press);
            // 
            // butSure
            // 
            this.butSure.BackColor = System.Drawing.Color.White;
            this.butSure.BorderColor = System.Drawing.Color.White;
            this.butSure.BorderRadius = 0;
            this.butSure.FontSize = 15F;
            this.butSure.ForeColor = System.Drawing.Color.Red;
            this.butSure.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.butSure.Location = new System.Drawing.Point(322, 11);
            this.butSure.Name = "butSure";
            this.butSure.Size = new System.Drawing.Size(66, 30);
            this.butSure.Text = "确定";
            this.butSure.Press += new System.EventHandler(this.butSure_Press);
            // 
            // TableWare
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.picker1,
            this.butNo,
            this.butSure});
            this.Size = new System.Drawing.Size(400, 270);
            this.Name = "TableWare";

        }
        #endregion

        private Smobiler.Core.Controls.Picker picker1;
        private Smobiler.Core.Controls.Button butNo;
        private Smobiler.Core.Controls.Button butSure;
    }
}