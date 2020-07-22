using System;
using Smobiler.Core;
namespace Order_Food_View.Page.JFPage
{
    partial class JFForm : Smobiler.Core.Controls.MobileForm
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.lab_Integral = new Smobiler.Core.Controls.Label();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl1 = new Smobiler.Core.Controls.TabPageControl();
            this.tabPageControl2 = new Smobiler.Core.Controls.TabPageControl();
            this.tabPageControl3 = new Smobiler.Core.Controls.TabPageControl();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.listView2 = new Smobiler.Core.Controls.ListView();
            this.panel4 = new Smobiler.Core.Controls.Panel();
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
            this.label3.Text = "积分";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lab_Integral,
            this.imageButton1,
            this.label1});
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 112);
            // 
            // lab_Integral
            // 
            this.lab_Integral.Bold = true;
            this.lab_Integral.FontSize = 20F;
            this.lab_Integral.ForeColor = System.Drawing.Color.White;
            this.lab_Integral.Location = new System.Drawing.Point(126, 23);
            this.lab_Integral.Name = "lab_Integral";
            this.lab_Integral.Size = new System.Drawing.Size(47, 35);
            this.lab_Integral.Text = "1171";
            // 
            // imageButton1
            // 
            this.imageButton1.ForeColor = System.Drawing.Color.White;
            this.imageButton1.IconColor = System.Drawing.Color.White;
            this.imageButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton1.Location = new System.Drawing.Point(161, 26);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "question-circle-o";
            this.imageButton1.Size = new System.Drawing.Size(30, 30);
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // label1
            // 
            this.label1.FontSize = 16F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 35);
            this.label1.Text = "当前积分";
            // 
            // tabPageView1
            // 
            this.tabPageView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageControl1,
            this.tabPageControl2,
            this.tabPageControl3});
            this.tabPageView1.Location = new System.Drawing.Point(0, 161);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(300, 339);
            this.tabPageView1.Titles = new string[] {
        "积分收入",
        "积分支出",
        "即将过期"};
            this.tabPageView1.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.Transparent, System.Drawing.Color.Black, System.Drawing.Color.Red, 13F, System.Drawing.Color.Red, 2);
            // 
            // tabPageControl1
            // 
            this.tabPageControl1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.tabPageControl1.Name = "tabPageControl1";
            // 
            // tabPageControl2
            // 
            this.tabPageControl2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel3});
            this.tabPageControl2.Name = "tabPageControl2";
            // 
            // tabPageControl3
            // 
            this.tabPageControl3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel4});
            this.tabPageControl3.Name = "tabPageControl3";
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView1});
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 338);
            // 
            // listView1
            // 
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 338);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView2});
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 339);
            // 
            // listView2
            // 
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(300, 339);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 338);
            // 
            // JFForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.back_my,
            this.label3,
            this.panel1,
            this.tabPageView1});
            this.Load += new System.EventHandler(this.JFForm_Load);
            this.Name = "JFForm";

        }
        #endregion

        private Smobiler.Core.Controls.ImageButton back_my;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label lab_Integral;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl2;
        private Smobiler.Core.Controls.TabPageControl tabPageControl3;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.ListView listView2;
        private Smobiler.Core.Controls.Panel panel4;
    }
}