using System;
using Smobiler.Core;
namespace Order_Food_View.Page
{
    partial class SmobilerSetPwdForm : Smobiler.Core.Controls.MobileForm
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
            this.old_Pwd = new Smobiler.Core.Controls.TextBox();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.new_Pwd = new Smobiler.Core.Controls.TextBox();
            this.btn_save = new Smobiler.Core.Controls.Button();
            this.back_updatepwd = new Smobiler.Core.Controls.ImageButton();
            this.label3 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.panel1.BorderColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.old_Pwd,
            this.textBox1,
            this.new_Pwd,
            this.btn_save});
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 453);
            // 
            // old_Pwd
            // 
            this.old_Pwd.Border = new Smobiler.Core.Controls.Border(1F);
            this.old_Pwd.BorderColor = System.Drawing.Color.LightGray;
            this.old_Pwd.FontSize = 16F;
            this.old_Pwd.Location = new System.Drawing.Point(28, 61);
            this.old_Pwd.Name = "old_Pwd";
            this.old_Pwd.Size = new System.Drawing.Size(238, 39);
            this.old_Pwd.WaterMarkText = "输入旧密码";
            // 
            // textBox1
            // 
            this.textBox1.Border = new Smobiler.Core.Controls.Border(1F);
            this.textBox1.BorderColor = System.Drawing.Color.LightGray;
            this.textBox1.FontSize = 16F;
            this.textBox1.Location = new System.Drawing.Point(28, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 35);
            this.textBox1.WaterMarkText = "请再次输入新的登录密码";
            // 
            // new_Pwd
            // 
            this.new_Pwd.Border = new Smobiler.Core.Controls.Border(1F);
            this.new_Pwd.BorderColor = System.Drawing.Color.LightGray;
            this.new_Pwd.FontSize = 16F;
            this.new_Pwd.Location = new System.Drawing.Point(28, 135);
            this.new_Pwd.Name = "new_Pwd";
            this.new_Pwd.Size = new System.Drawing.Size(238, 35);
            this.new_Pwd.WaterMarkText = "请输入6-20位的新登录密码";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Red;
            this.btn_save.BorderRadius = 0;
            this.btn_save.FontSize = 18F;
            this.btn_save.Location = new System.Drawing.Point(28, 205);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(238, 36);
            this.btn_save.Text = "提交";
            this.btn_save.Press += new System.EventHandler(this.btn_save_Press);
            // 
            // back_updatepwd
            // 
            this.back_updatepwd.IconColor = System.Drawing.Color.Gray;
            this.back_updatepwd.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.back_updatepwd.Name = "back_updatepwd";
            this.back_updatepwd.ResourceID = "ios-arrow-round-back";
            this.back_updatepwd.Size = new System.Drawing.Size(37, 37);
            this.back_updatepwd.Press += new System.EventHandler(this.back_my_Press);
            // 
            // label3
            // 
            this.label3.FontSize = 16F;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(27, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 40);
            this.label3.Text = "修改密码";
            // 
            // SmobilerSetPwdForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.back_updatepwd,
            this.label3});
            this.Name = "SmobilerSetPwdForm";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.ImageButton back_updatepwd;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.TextBox old_Pwd;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.TextBox new_Pwd;
        private Smobiler.Core.Controls.Button btn_save;
    }
}