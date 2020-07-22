using System;
using Smobiler.Core;
namespace Order_Food_View.UserControl.CJControl
{
    partial class JFMallControl : Smobiler.Core.Controls.MobileUserControl
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btn_DH = new Smobiler.Core.Controls.Button();
            this.lab_name = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lab_jf = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lab_num = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lab_time = new Smobiler.Core.Controls.Label();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            // 
            // panel1
            // 
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 10F);
            this.panel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btn_DH,
            this.lab_name,
            this.label1,
            this.lab_jf,
            this.label2,
            this.lab_num,
            this.label3,
            this.lab_time,
            this.imageButton1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 190);
            // 
            // btn_DH
            // 
            this.btn_DH.BackColor = System.Drawing.Color.Red;
            this.btn_DH.BorderRadius = 0;
            this.btn_DH.FontSize = 18F;
            this.btn_DH.Location = new System.Drawing.Point(291, 133);
            this.btn_DH.Name = "btn_DH";
            this.btn_DH.Size = new System.Drawing.Size(92, 33);
            this.btn_DH.Text = "立即兑换";
            // 
            // lab_name
            // 
            this.lab_name.DataMember = "Name";
            this.lab_name.DisplayMember = "Name";
            this.lab_name.FontSize = 18F;
            this.lab_name.Location = new System.Drawing.Point(142, 23);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(228, 19);
            this.lab_name.Text = "label1";
            // 
            // label1
            // 
            this.label1.FontSize = 18F;
            this.label1.Location = new System.Drawing.Point(142, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.Text = "所需积分：";
            // 
            // lab_jf
            // 
            this.lab_jf.DataMember = "JF";
            this.lab_jf.DisplayMember = "JF";
            this.lab_jf.FontSize = 18F;
            this.lab_jf.ForeColor = System.Drawing.Color.Red;
            this.lab_jf.Location = new System.Drawing.Point(215, 52);
            this.lab_jf.Name = "lab_jf";
            this.lab_jf.Size = new System.Drawing.Size(67, 19);
            this.lab_jf.Text = "label2";
            // 
            // label2
            // 
            this.label2.FontSize = 18F;
            this.label2.Location = new System.Drawing.Point(142, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.Text = "剩余数量：";
            // 
            // lab_num
            // 
            this.lab_num.DataMember = "num";
            this.lab_num.DisplayMember = "num";
            this.lab_num.FontSize = 18F;
            this.lab_num.ForeColor = System.Drawing.Color.Red;
            this.lab_num.Location = new System.Drawing.Point(215, 78);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(67, 19);
            this.lab_num.Text = "label2";
            // 
            // label3
            // 
            this.label3.FontSize = 18F;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(142, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.Text = "兑换日期：";
            // 
            // lab_time
            // 
            this.lab_time.DataMember = "time";
            this.lab_time.DisplayMember = "time";
            this.lab_time.FontSize = 18F;
            this.lab_time.ForeColor = System.Drawing.Color.Silver;
            this.lab_time.Location = new System.Drawing.Point(215, 104);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(185, 19);
            this.lab_time.Text = "label2";
            // 
            // imageButton1
            // 
            this.imageButton1.DataMember = "img";
            this.imageButton1.DisplayMember = "img";
            this.imageButton1.Location = new System.Drawing.Point(13, 17);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(116, 116);
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // JFMallControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.Gainsboro;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(400, 190);
            this.Name = "JFMallControl";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Button btn_DH;
        private Smobiler.Core.Controls.Label lab_name;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label lab_jf;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label lab_num;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label lab_time;
        private Smobiler.Core.Controls.ImageButton imageButton1;
    }
}