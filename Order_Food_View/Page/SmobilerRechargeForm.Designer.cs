using System;
using Smobiler.Core;
namespace Order_Food_View.Page
{
    partial class SmobilerRechargeForm : Smobiler.Core.Controls.MobileForm
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
            this.YuE = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btn_ChongZhi = new Smobiler.Core.Controls.Button();
            this.back_my = new Smobiler.Core.Controls.ImageButton();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.one = new Smobiler.Core.Controls.ImageButton();
            this.two = new Smobiler.Core.Controls.ImageButton();
            this.three = new Smobiler.Core.Controls.ImageButton();
            this.four = new Smobiler.Core.Controls.ImageButton();
            this.five = new Smobiler.Core.Controls.ImageButton();
            this.six = new Smobiler.Core.Controls.ImageButton();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.YuE,
            this.label1,
            this.label2});
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 169);
            // 
            // YuE
            // 
            this.YuE.Bold = true;
            this.YuE.FontSize = 25F;
            this.YuE.ForeColor = System.Drawing.Color.White;
            this.YuE.Location = new System.Drawing.Point(113, 50);
            this.YuE.Name = "YuE";
            this.YuE.Size = new System.Drawing.Size(100, 35);
            this.YuE.Text = "￥168";
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 35);
            this.label1.Text = "当前账户:";
            // 
            // label2
            // 
            this.label2.FontSize = 15F;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.Text = "159****4167";
            // 
            // btn_ChongZhi
            // 
            this.btn_ChongZhi.BackColor = System.Drawing.Color.Red;
            this.btn_ChongZhi.FontSize = 20F;
            this.btn_ChongZhi.Location = new System.Drawing.Point(52, 368);
            this.btn_ChongZhi.Name = "btn_ChongZhi";
            this.btn_ChongZhi.Size = new System.Drawing.Size(204, 42);
            this.btn_ChongZhi.Text = "立即充值";
            this.btn_ChongZhi.Press += new System.EventHandler(this.btn_ChongZhi_Press);
            // 
            // back_my
            // 
            this.back_my.IconColor = System.Drawing.Color.Gray;
            this.back_my.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.back_my.Location = new System.Drawing.Point(0, 1);
            this.back_my.Name = "back_my";
            this.back_my.ResourceID = "ios-arrow-round-back";
            this.back_my.Size = new System.Drawing.Size(37, 37);
            this.back_my.Press += new System.EventHandler(this.back_my_Press);
            // 
            // label3
            // 
            this.label3.FontSize = 16F;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(27, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 40);
            this.label3.Text = "充值";
            // 
            // one
            // 
            this.one.Border = new Smobiler.Core.Controls.Border(1F);
            this.one.BorderColor = System.Drawing.Color.Silver;
            this.one.FontSize = 15F;
            this.one.Location = new System.Drawing.Point(45, 233);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(60, 35);
            this.one.Text = "100";
            this.one.Press += new System.EventHandler(this.one_Press);
            // 
            // two
            // 
            this.two.Border = new Smobiler.Core.Controls.Border(1F);
            this.two.BorderColor = System.Drawing.Color.Silver;
            this.two.FontSize = 15F;
            this.two.Location = new System.Drawing.Point(124, 233);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(60, 35);
            this.two.Text = "200";
            this.two.Press += new System.EventHandler(this.two_Press);
            // 
            // three
            // 
            this.three.Border = new Smobiler.Core.Controls.Border(1F);
            this.three.BorderColor = System.Drawing.Color.Silver;
            this.three.FontSize = 15F;
            this.three.Location = new System.Drawing.Point(202, 233);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(60, 35);
            this.three.Text = "300";
            this.three.Press += new System.EventHandler(this.three_Press);
            // 
            // four
            // 
            this.four.Border = new Smobiler.Core.Controls.Border(1F);
            this.four.BorderColor = System.Drawing.Color.Silver;
            this.four.FontSize = 15F;
            this.four.Location = new System.Drawing.Point(45, 296);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(60, 35);
            this.four.Text = "500";
            this.four.Press += new System.EventHandler(this.four_Press);
            // 
            // five
            // 
            this.five.Border = new Smobiler.Core.Controls.Border(1F);
            this.five.BorderColor = System.Drawing.Color.Silver;
            this.five.FontSize = 15F;
            this.five.Location = new System.Drawing.Point(124, 296);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(60, 35);
            this.five.Text = "800";
            this.five.Press += new System.EventHandler(this.five_Press);
            // 
            // six
            // 
            this.six.Border = new Smobiler.Core.Controls.Border(1F);
            this.six.BorderColor = System.Drawing.Color.Silver;
            this.six.FontSize = 15F;
            this.six.Location = new System.Drawing.Point(202, 296);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(60, 35);
            this.six.Text = "1000";
            this.six.Press += new System.EventHandler(this.six_Press);
            // 
            // SmobilerRechargeForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.btn_ChongZhi,
            this.back_my,
            this.label3,
            this.one,
            this.two,
            this.three,
            this.four,
            this.five,
            this.six});
            this.Name = "SmobilerRechargeForm";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label YuE;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Button btn_ChongZhi;
        private Smobiler.Core.Controls.ImageButton back_my;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.ImageButton one;
        private Smobiler.Core.Controls.ImageButton two;
        private Smobiler.Core.Controls.ImageButton three;
        private Smobiler.Core.Controls.ImageButton four;
        private Smobiler.Core.Controls.ImageButton five;
        private Smobiler.Core.Controls.ImageButton six;
    }
}