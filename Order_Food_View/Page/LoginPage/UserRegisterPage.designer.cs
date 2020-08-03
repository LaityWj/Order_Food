using System;
using Smobiler.Core;
namespace Order_Food_View.Page.LoginPage
{
    partial class UserRegisterPage : Smobiler.Core.Controls.MobileForm
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
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btn_login = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.txt_pwd = new Smobiler.Core.Controls.TextBox();
            this.txt_againpwd = new Smobiler.Core.Controls.TextBox();
            this.txt_name = new Smobiler.Core.Controls.TextBox();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtUserName,
            this.image1,
            this.label1,
            this.btn_login,
            this.label3,
            this.txt_pwd,
            this.txt_againpwd,
            this.txt_name});
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
            this.txtUserName.BorderRadius = 12;
            this.txtUserName.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtUserName.Location = new System.Drawing.Point(15, 218);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(266, 40);
            this.txtUserName.WaterMarkText = "手机号";
            // 
            // image1
            // 
            this.image1.BorderColor = System.Drawing.Color.Transparent;
            this.image1.Location = new System.Drawing.Point(15, 47);
            this.image1.Name = "image1";
            this.image1.ResourceID = "Logo";
            this.image1.Size = new System.Drawing.Size(40, 61);
            this.image1.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Default;
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.BorderColor = System.Drawing.Color.Transparent;
            this.label1.FontSize = 20F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 47);
            this.label1.Text = "HelloWord";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Cyan;
            this.btn_login.BorderRadius = 12;
            this.btn_login.FontSize = 18F;
            this.btn_login.Location = new System.Drawing.Point(15, 409);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(270, 37);
            this.btn_login.Text = "注册";
            this.btn_login.Press += new System.EventHandler(this.btn_login_Press);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label3.Location = new System.Drawing.Point(0, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 35);
            this.label3.Text = "Copyright ©2020-2021 Laity. All rights reserved.";
            // 
            // txt_pwd
            // 
            this.txt_pwd.BackColor = System.Drawing.Color.Transparent;
            this.txt_pwd.Border = new Smobiler.Core.Controls.Border(1F);
            this.txt_pwd.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pwd.BorderRadius = 12;
            this.txt_pwd.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txt_pwd.Location = new System.Drawing.Point(15, 278);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.SecurityMode = true;
            this.txt_pwd.Size = new System.Drawing.Size(266, 40);
            this.txt_pwd.WaterMarkText = "密码";
            // 
            // txt_againpwd
            // 
            this.txt_againpwd.BackColor = System.Drawing.Color.Transparent;
            this.txt_againpwd.Border = new Smobiler.Core.Controls.Border(1F);
            this.txt_againpwd.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txt_againpwd.BorderRadius = 12;
            this.txt_againpwd.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txt_againpwd.Location = new System.Drawing.Point(15, 338);
            this.txt_againpwd.Name = "txt_againpwd";
            this.txt_againpwd.SecurityMode = true;
            this.txt_againpwd.Size = new System.Drawing.Size(266, 40);
            this.txt_againpwd.WaterMarkText = "确认密码";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_name.Border = new Smobiler.Core.Controls.Border(1F);
            this.txt_name.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txt_name.BorderRadius = 12;
            this.txt_name.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txt_name.Location = new System.Drawing.Point(15, 161);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(266, 40);
            this.txt_name.WaterMarkText = "用户名";
            // 
            // UserRegisterPage
            // 
            this.BackgroundImage = "back";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 600);
            this.Name = "UserRegisterPage";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.TextBox txtUserName;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button btn_login;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.TextBox txt_pwd;
        private Smobiler.Core.Controls.TextBox txt_againpwd;
        private Smobiler.Core.Controls.TextBox txt_name;
    }
}