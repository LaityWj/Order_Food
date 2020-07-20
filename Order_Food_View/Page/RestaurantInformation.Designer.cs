using System;
using Smobiler.Core;
namespace Order_Food_View.Page
{
    partial class RestaurantInformation : Smobiler.Core.Controls.MobileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantInformation));
            this.image1 = new Smobiler.Core.Controls.Image();
            this.image2 = new Smobiler.Core.Controls.Image();
            this.Address = new Smobiler.Core.Controls.Label();
            this.phoneButton1 = new Smobiler.Core.Controls.PhoneButton();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.back_frist = new Smobiler.Core.Controls.ImageButton();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(0, 62);
            this.image1.Name = "image1";
            this.image1.ResourceID = "u1079";
            this.image1.Size = new System.Drawing.Size(300, 136);
            // 
            // image2
            // 
            this.image2.Location = new System.Drawing.Point(29, 440);
            this.image2.Name = "image2";
            this.image2.ResourceID = "dz";
            this.image2.Size = new System.Drawing.Size(16, 16);
            // 
            // Address
            // 
            this.Address.FontSize = 16F;
            this.Address.Location = new System.Drawing.Point(47, 439);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(215, 23);
            this.Address.Text = "地址：北京市朝阳区石佛营路x号";
            // 
            // phoneButton1
            // 
            this.phoneButton1.Location = new System.Drawing.Point(29, 463);
            this.phoneButton1.Name = "phoneButton1";
            this.phoneButton1.PhoneNumber = "15951364167";
            this.phoneButton1.ResourceID = "4";
            this.phoneButton1.Size = new System.Drawing.Size(20, 20);
            // 
            // label2
            // 
            this.label2.FontSize = 16F;
            this.label2.Location = new System.Drawing.Point(48, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.Text = "15951364167";
            // 
            // back_frist
            // 
            this.back_frist.IconColor = System.Drawing.Color.Gray;
            this.back_frist.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.back_frist.Name = "back_frist";
            this.back_frist.ResourceID = "ios-arrow-round-back";
            this.back_frist.Size = new System.Drawing.Size(37, 37);
            this.back_frist.Press += new System.EventHandler(this.back_my_Press);
            // 
            // label3
            // 
            this.label3.FontSize = 16F;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(27, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 40);
            this.label3.Text = "餐厅介绍";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1});
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 239);
            // 
            // label1
            // 
            this.label1.FontSize = 14F;
            this.label1.Location = new System.Drawing.Point(29, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 236);
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // RestaurantInformation
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.image2,
            this.Address,
            this.phoneButton1,
            this.label2,
            this.back_frist,
            this.label3,
            this.panel1});
            this.Name = "RestaurantInformation";

        }
        #endregion

        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Image image2;
        private Smobiler.Core.Controls.Label Address;
        private Smobiler.Core.Controls.PhoneButton phoneButton1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.ImageButton back_frist;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label1;
    }
}