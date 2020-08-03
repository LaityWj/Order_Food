using System;
using Smobiler.Core;
namespace Order_Food_View.Page
{
    partial class SmobilerMyForm : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.ToolBarItem toolBarItem7 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem8 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem9 = new Smobiler.Core.Controls.ToolBarItem();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.user_Picture = new Smobiler.Core.Controls.Image();
            this.user_Name = new Smobiler.Core.Controls.Label();
            this.user_Phone = new Smobiler.Core.Controls.Label();
            this.btn_JiFen = new Smobiler.Core.Controls.ImageButton();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton2 = new Smobiler.Core.Controls.ImageButton();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btn_SetUp = new Smobiler.Core.Controls.ImageButton();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.imgbtn_address = new Smobiler.Core.Controls.ImageButton();
            this.label3 = new Smobiler.Core.Controls.Label();
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dotted;
            this.label1.FontSize = 20F;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 35);
            this.label1.Text = "我的";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.user_Picture,
            this.user_Name,
            this.user_Phone,
            this.btn_JiFen,
            this.imageButton1,
            this.imageButton2});
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 183);
            // 
            // user_Picture
            // 
            this.user_Picture.BorderRadius = 100;
            this.user_Picture.Location = new System.Drawing.Point(18, 29);
            this.user_Picture.Name = "user_Picture";
            this.user_Picture.ResourceID = "user";
            this.user_Picture.Size = new System.Drawing.Size(60, 60);
            this.user_Picture.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Default;
            // 
            // user_Name
            // 
            this.user_Name.FontSize = 18F;
            this.user_Name.ForeColor = System.Drawing.Color.White;
            this.user_Name.Location = new System.Drawing.Point(87, 22);
            this.user_Name.Name = "user_Name";
            this.user_Name.Size = new System.Drawing.Size(100, 35);
            this.user_Name.Text = "Cui Jie";
            // 
            // user_Phone
            // 
            this.user_Phone.FontSize = 18F;
            this.user_Phone.ForeColor = System.Drawing.Color.White;
            this.user_Phone.Location = new System.Drawing.Point(87, 57);
            this.user_Phone.Name = "user_Phone";
            this.user_Phone.Size = new System.Drawing.Size(100, 35);
            this.user_Phone.Text = "159****4167";
            // 
            // btn_JiFen
            // 
            this.btn_JiFen.ForeColor = System.Drawing.Color.White;
            this.btn_JiFen.Location = new System.Drawing.Point(42, 123);
            this.btn_JiFen.Name = "btn_JiFen";
            this.btn_JiFen.Size = new System.Drawing.Size(35, 35);
            this.btn_JiFen.Text = "1171积分";
            this.btn_JiFen.Press += new System.EventHandler(this.btn_JiFen_Press);
            // 
            // imageButton1
            // 
            this.imageButton1.ForeColor = System.Drawing.Color.White;
            this.imageButton1.Location = new System.Drawing.Point(130, 123);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(35, 35);
            this.imageButton1.Text = "2          优惠券";
            // 
            // imageButton2
            // 
            this.imageButton2.ForeColor = System.Drawing.Color.White;
            this.imageButton2.Location = new System.Drawing.Point(212, 118);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.Size = new System.Drawing.Size(58, 50);
            this.imageButton2.Text = "￥168    钱包·充值";
            this.imageButton2.Press += new System.EventHandler(this.imageButton2_Press);
            // 
            // toolBar1
            // 
            toolBarItem7.IconID = "home";
            toolBarItem7.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem7.Name = "Home";
            toolBarItem7.SelectIconColor = System.Drawing.Color.Red;
            toolBarItem7.SelectIconID = "home";
            toolBarItem7.Text = "主页";
            toolBarItem8.IconID = "file-text-o";
            toolBarItem8.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem8.Name = "Order";
            toolBarItem8.SelectIconColor = System.Drawing.Color.Red;
            toolBarItem8.SelectIconID = "file-text-o";
            toolBarItem8.Text = "订单";
            toolBarItem9.IconID = "user";
            toolBarItem9.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem9.Name = "My";
            toolBarItem9.SelectIconColor = System.Drawing.Color.Red;
            toolBarItem9.SelectIconID = "user";
            toolBarItem9.Text = "我的";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem7,
            toolBarItem8,
            toolBarItem9});
            this.toolBar1.ItemWidth = 40;
            this.toolBar1.Location = new System.Drawing.Point(162, 459);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(100, 50);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick);
            // 
            // panel2
            // 
            this.panel2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.btn_SetUp});
            this.panel2.Location = new System.Drawing.Point(0, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 62);
            // 
            // label2
            // 
            this.label2.FontSize = 20F;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.Text = "设置";
            // 
            // btn_SetUp
            // 
            this.btn_SetUp.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.btn_SetUp.Location = new System.Drawing.Point(241, 16);
            this.btn_SetUp.Name = "btn_SetUp";
            this.btn_SetUp.ResourceID = "angle-right";
            this.btn_SetUp.Size = new System.Drawing.Size(35, 35);
            this.btn_SetUp.Press += new System.EventHandler(this.btn_SetUp_Press);
            // 
            // panel3
            // 
            this.panel3.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel3.BorderColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.imgbtn_address});
            this.panel3.Location = new System.Drawing.Point(0, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 62);
            // 
            // imgbtn_address
            // 
            this.imgbtn_address.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imgbtn_address.Location = new System.Drawing.Point(241, 17);
            this.imgbtn_address.Name = "imgbtn_address";
            this.imgbtn_address.ResourceID = "angle-right";
            this.imgbtn_address.Size = new System.Drawing.Size(35, 35);
            // 
            // label3
            // 
            this.label3.FontSize = 20F;
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.Text = "收货地址";
            // 
            // SmobilerMyForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.panel1,
            this.toolBar1,
            this.panel2,
            this.panel3});
            this.Load += new System.EventHandler(this.SmobilerMyForm_Load);
            this.Name = "SmobilerMyForm";

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.ToolBar toolBar1;
        private Smobiler.Core.Controls.Image user_Picture;
        private Smobiler.Core.Controls.Label user_Name;
        private Smobiler.Core.Controls.Label user_Phone;
        private Smobiler.Core.Controls.ImageButton btn_JiFen;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.ImageButton imageButton2;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.ImageButton btn_SetUp;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.ImageButton imgbtn_address;
    }
}