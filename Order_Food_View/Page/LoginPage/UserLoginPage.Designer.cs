using System;
using Smobiler.Core;
namespace Order_Food_View.Page.LoginPage
{
    partial class UserLoginPage : Smobiler.Core.Controls.MobileForm
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.txtUserName = new Smobiler.Core.Controls.TextBox();
            this.txtUserPwd = new Smobiler.Core.Controls.TextBox();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btn_login = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtUserName,
            this.txtUserPwd,
            this.image1,
            this.label1,
            this.btn_login,
            this.label3,
            this.button1});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtUserName.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.BorderRadius = 8;
            this.txtUserName.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtUserName.Location = new System.Drawing.Point(15, 198);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(266, 40);
            this.txtUserName.WaterMarkText = "用户名";
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.BackColor = System.Drawing.Color.Transparent;
            this.txtUserPwd.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtUserPwd.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserPwd.BorderRadius = 8;
            this.txtUserPwd.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtUserPwd.Location = new System.Drawing.Point(15, 270);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.SecurityMode = true;
            this.txtUserPwd.Size = new System.Drawing.Size(266, 40);
            this.txtUserPwd.WaterMarkText = "密码";
            // 
            // image1
            // 
            this.image1.BorderColor = System.Drawing.Color.Transparent;
            this.image1.Location = new System.Drawing.Point(15, 36);
            this.image1.Name = "image1";
            this.image1.ResourceID = "Logo";
            this.image1.Size = new System.Drawing.Size(40, 72);
            this.image1.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Default;
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.BorderColor = System.Drawing.Color.Transparent;
            this.label1.FontSize = 20F;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(56, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 47);
            this.label1.Text = "HelloWord";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Cyan;
            this.btn_login.FontSize = 18F;
            this.btn_login.Location = new System.Drawing.Point(15, 359);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(270, 39);
            this.btn_login.Text = "登录";
            this.btn_login.Press += new System.EventHandler(this.btn_login_Press);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label3.Location = new System.Drawing.Point(0, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 35);
            this.label3.Text = "Copyright ©2015-2020 Laity. All rights reserved.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderRadius = 0;
            this.button1.FontSize = 15F;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(181, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 22);
            this.button1.Text = "新用户注册";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // UserLoginPage
            // 
            this.BackgroundImage = "back";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 600);
            this.Name = "UserLoginPage";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.TextBox txtUserName;
        private Smobiler.Core.Controls.TextBox txtUserPwd;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button btn_login;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Button button1;
    }
}