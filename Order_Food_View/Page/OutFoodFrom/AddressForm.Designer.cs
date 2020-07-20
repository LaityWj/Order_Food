using System;
using Smobiler.Core;
namespace Order_Food_View.OutFoodFrom
{
    partial class AddressForm : Smobiler.Core.Controls.MobileForm
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
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 44);
            this.listView1.Name = "listView1";
            this.listView1.ShowSplitLine = true;
            this.listView1.Size = new System.Drawing.Size(300, 456);
            this.listView1.TemplateControlName = "frmAddress";
            // 
            // imageButton1
            // 
            this.imageButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton1.Location = new System.Drawing.Point(4, 8);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "angle-left";
            this.imageButton1.Size = new System.Drawing.Size(53, 35);
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(47, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "收获地址 ";
            // 
            // AddressForm
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView1,
            this.imageButton1,
            this.label1});
            this.Load += new System.EventHandler(this.AddressForm_Load);
            this.Name = "AddressForm";

        }
        #endregion

        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.Label label1;
    }
}