using System;
using Smobiler.Core;
namespace Order_Food_View.Page.JFPage
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
            this.back_my = new Smobiler.Core.Controls.ImageButton();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btn_insertAddress = new Smobiler.Core.Controls.Button();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            // 
            // back_my
            // 
            this.back_my.IconColor = System.Drawing.Color.Gray;
            this.back_my.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.back_my.Name = "back_my";
            this.back_my.ResourceID = "ios-arrow-round-back";
            this.back_my.Size = new System.Drawing.Size(40, 40);
            this.back_my.Press += new System.EventHandler(this.back_my_Press);
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
            // btn_insertAddress
            // 
            this.btn_insertAddress.BackColor = System.Drawing.Color.Red;
            this.btn_insertAddress.FontSize = 20F;
            this.btn_insertAddress.Location = new System.Drawing.Point(31, 368);
            this.btn_insertAddress.Name = "btn_insertAddress";
            this.btn_insertAddress.Size = new System.Drawing.Size(241, 46);
            this.btn_insertAddress.Text = "➕ 新增地址";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 300);
            // 
            // AddressForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.back_my,
            this.label3,
            this.btn_insertAddress,
            this.listView1});
            this.Load += new System.EventHandler(this.AddressForm_Load);
            this.Name = "AddressForm";

        }
        #endregion

        private Smobiler.Core.Controls.ImageButton back_my;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Button btn_insertAddress;
        private Smobiler.Core.Controls.ListView listView1;
    }
}