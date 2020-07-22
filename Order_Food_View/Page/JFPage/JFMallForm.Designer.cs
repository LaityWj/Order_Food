using System;
using Smobiler.Core;
namespace Order_Food_View.Page.JFPage
{
    partial class JFMallForm : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.back_updatepwd = new Smobiler.Core.Controls.ImageButton();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            // 
            // back_updatepwd
            // 
            this.back_updatepwd.IconColor = System.Drawing.Color.Gray;
            this.back_updatepwd.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.back_updatepwd.Name = "back_updatepwd";
            this.back_updatepwd.ResourceID = "ios-arrow-round-back";
            this.back_updatepwd.Size = new System.Drawing.Size(40, 40);
            this.back_updatepwd.Press += new System.EventHandler(this.back_my_Press);
            // 
            // label3
            // 
            this.label3.FontSize = 18F;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(34, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 40);
            this.label3.Text = "积分商城";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView1});
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 631);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 632);
            // 
            // JFMallForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.back_updatepwd,
            this.label3,
            this.panel1});
            this.Size = new System.Drawing.Size(400, 800);
            this.Load += new System.EventHandler(this.JFMallForm_Load);
            this.Name = "JFMallForm";

        }
        #endregion

        private Smobiler.Core.Controls.ImageButton back_updatepwd;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.ListView listView1;
    }
}