using System;
using Smobiler.Core;
namespace Order_Food_View.Page.JFPage
{
    partial class JFDetailForm : Smobiler.Core.Controls.MobileForm
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
            this.back_jfdetail = new Smobiler.Core.Controls.ImageButton();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.lab_name = new Smobiler.Core.Controls.Label();
            this.lab_jf = new Smobiler.Core.Controls.Label();
            this.lab_num = new Smobiler.Core.Controls.Label();
            this.lab_time = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.Menu_Id = new Smobiler.Core.Controls.TextBox();
            // 
            // back_jfdetail
            // 
            this.back_jfdetail.IconColor = System.Drawing.Color.Gray;
            this.back_jfdetail.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.back_jfdetail.Name = "back_jfdetail";
            this.back_jfdetail.ResourceID = "ios-arrow-round-back";
            this.back_jfdetail.Size = new System.Drawing.Size(40, 40);
            this.back_jfdetail.Press += new System.EventHandler(this.back_my_Press);
            // 
            // label3
            // 
            this.label3.FontSize = 18F;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(34, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 40);
            this.label3.Text = "详情";
            // 
            // panel1
            // 
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label2,
            this.label4,
            this.label5,
            this.lab_name,
            this.lab_jf,
            this.lab_num,
            this.lab_time});
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 371);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(75, 12);
            this.image1.Name = "image1";
            this.image1.ResourceID = "kele";
            this.image1.Size = new System.Drawing.Size(257, 182);
            // 
            // label2
            // 
            this.label2.FontSize = 18F;
            this.label2.Location = new System.Drawing.Point(75, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.Text = "所需积分：";
            // 
            // label4
            // 
            this.label4.FontSize = 18F;
            this.label4.Location = new System.Drawing.Point(75, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.Text = "剩余数量：";
            // 
            // label5
            // 
            this.label5.FontSize = 18F;
            this.label5.Location = new System.Drawing.Point(75, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.Text = "兑换日期：";
            // 
            // lab_name
            // 
            this.lab_name.DataMember = "Name";
            this.lab_name.DisplayMember = "Name";
            this.lab_name.FontSize = 18F;
            this.lab_name.Location = new System.Drawing.Point(75, 207);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(228, 19);
            this.lab_name.Text = "200ML可口可乐";
            // 
            // lab_jf
            // 
            this.lab_jf.DataMember = "JF";
            this.lab_jf.DisplayMember = "JF";
            this.lab_jf.FontSize = 18F;
            this.lab_jf.ForeColor = System.Drawing.Color.Red;
            this.lab_jf.Location = new System.Drawing.Point(146, 243);
            this.lab_jf.Name = "lab_jf";
            this.lab_jf.Size = new System.Drawing.Size(67, 19);
            this.lab_jf.Text = "20";
            // 
            // lab_num
            // 
            this.lab_num.DataMember = "num";
            this.lab_num.DisplayMember = "num";
            this.lab_num.FontSize = 18F;
            this.lab_num.ForeColor = System.Drawing.Color.Red;
            this.lab_num.Location = new System.Drawing.Point(146, 281);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(67, 19);
            this.lab_num.Text = "234";
            // 
            // lab_time
            // 
            this.lab_time.DataMember = "time";
            this.lab_time.DisplayMember = "time";
            this.lab_time.FontSize = 18F;
            this.lab_time.Location = new System.Drawing.Point(146, 316);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(185, 19);
            this.lab_time.Text = "2020-07-21~2020-10-21";
            // 
            // label1
            // 
            this.label1.FontSize = 16F;
            this.label1.Location = new System.Drawing.Point(79, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 148);
            this.label1.Text = "使用须知\r\n\r\n1、产品以餐厅食物为准\r\n\r\n2、兑换成功后，扣除的积分不予退还\r\n\r\n3、每个用户只能兑换一次";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BorderRadius = 0;
            this.button1.FontSize = 20F;
            this.button1.Location = new System.Drawing.Point(66, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 36);
            this.button1.Text = "立即兑换";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // Menu_Id
            // 
            this.Menu_Id.Location = new System.Drawing.Point(237, 12);
            this.Menu_Id.Name = "Menu_Id";
            this.Menu_Id.Size = new System.Drawing.Size(100, 20);
            // 
            // JFDetailForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.back_jfdetail,
            this.label3,
            this.panel1,
            this.label1,
            this.button1,
            this.Menu_Id});
            this.Size = new System.Drawing.Size(400, 800);
            this.Load += new System.EventHandler(this.JFDetailForm_Load);
            this.Name = "JFDetailForm";

        }
        #endregion

        private Smobiler.Core.Controls.ImageButton back_jfdetail;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label lab_name;
        private Smobiler.Core.Controls.Label lab_jf;
        private Smobiler.Core.Controls.Label lab_num;
        private Smobiler.Core.Controls.Label lab_time;
        private Smobiler.Core.Controls.TextBox Menu_Id;
    }
}