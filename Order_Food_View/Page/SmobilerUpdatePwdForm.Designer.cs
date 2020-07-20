using System;
using Smobiler.Core;
namespace Order_Food_View.Page
{
    partial class SmobilerUpdatePwdForm : Smobiler.Core.Controls.MobileForm
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
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btn_UpdatePwd = new Smobiler.Core.Controls.ImageButton();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.clean = new Smobiler.Core.Controls.ImageButton();
            this.back_shezhi = new Smobiler.Core.Controls.ImageButton();
            this.label3 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel1.BorderColor = System.Drawing.Color.Silver;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.btn_UpdatePwd});
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 57);
            // 
            // label2
            // 
            this.label2.FontSize = 22F;
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.Text = "修改密码";
            // 
            // btn_UpdatePwd
            // 
            this.btn_UpdatePwd.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.btn_UpdatePwd.Location = new System.Drawing.Point(246, 11);
            this.btn_UpdatePwd.Name = "btn_UpdatePwd";
            this.btn_UpdatePwd.ResourceID = "angle-right";
            this.btn_UpdatePwd.Size = new System.Drawing.Size(35, 35);
            this.btn_UpdatePwd.Press += new System.EventHandler(this.btn_UpdatePwd_Press);
            // 
            // panel2
            // 
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F, 0F, 1F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.clean});
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 52);
            // 
            // label1
            // 
            this.label1.FontSize = 22F;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "清除缓存";
            // 
            // clean
            // 
            this.clean.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.clean.Location = new System.Drawing.Point(246, 5);
            this.clean.Name = "clean";
            this.clean.ResourceID = "angle-right";
            this.clean.Size = new System.Drawing.Size(35, 35);
            // 
            // back_shezhi
            // 
            this.back_shezhi.IconColor = System.Drawing.Color.Gray;
            this.back_shezhi.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.back_shezhi.Name = "back_shezhi";
            this.back_shezhi.ResourceID = "ios-arrow-round-back";
            this.back_shezhi.Size = new System.Drawing.Size(37, 37);
            this.back_shezhi.Press += new System.EventHandler(this.back_my_Press);
            // 
            // label3
            // 
            this.label3.FontSize = 16F;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(27, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 40);
            this.label3.Text = "设置";
            // 
            // SmobilerUpdatePwdForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2,
            this.back_shezhi,
            this.label3});
            this.Name = "SmobilerUpdatePwdForm";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.ImageButton btn_UpdatePwd;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.ImageButton clean;
        private Smobiler.Core.Controls.ImageButton back_shezhi;
        private Smobiler.Core.Controls.Label label3;
    }
}