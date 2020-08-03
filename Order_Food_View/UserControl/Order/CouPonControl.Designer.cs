using System;
using Smobiler.Core;
namespace Order_Food_View.UserControl
{
    partial class CouPonControl : Smobiler.Core.Controls.MobileUserControl
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
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.lan_coupon = new Smobiler.Core.Controls.Label();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl1 = new Smobiler.Core.Controls.TabPageControl();
            this.tabPageControl2 = new Smobiler.Core.Controls.TabPageControl();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.btn_X = new Smobiler.Core.Controls.Button();
            this.listView2 = new Smobiler.Core.Controls.ListView();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lan_coupon,
            this.tabPageView1,
            this.btn_X});
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 350);
            // 
            // lan_coupon
            // 
            this.lan_coupon.BackColor = System.Drawing.Color.White;
            this.lan_coupon.FontSize = 15F;
            this.lan_coupon.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lan_coupon.Location = new System.Drawing.Point(0, 3);
            this.lan_coupon.Name = "lan_coupon";
            this.lan_coupon.Size = new System.Drawing.Size(300, 30);
            this.lan_coupon.Text = "优惠券";
            // 
            // tabPageView1
            // 
            this.tabPageView1.BackColor = System.Drawing.Color.White;
            this.tabPageView1.BorderColor = System.Drawing.Color.White;
            this.tabPageView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageControl1,
            this.tabPageControl2});
            this.tabPageView1.Location = new System.Drawing.Point(0, 33);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(300, 317);
            this.tabPageView1.Titles = new string[] {
        "可用优惠券(0)",
        "不可用优惠券(3)"};
            this.tabPageView1.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Blue);
            // 
            // tabPageControl1
            // 
            this.tabPageControl1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView2});
            this.tabPageControl1.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.tabPageControl1.Name = "tabPageControl1";
            // 
            // tabPageControl2
            // 
            this.tabPageControl2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView1});
            this.tabPageControl2.Name = "tabPageControl2";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 293);
            this.listView1.TemplateControlName = "ShowCouPonControl";
            // 
            // btn_X
            // 
            this.btn_X.BackColor = System.Drawing.Color.White;
            this.btn_X.FontSize = 24F;
            this.btn_X.ForeColor = System.Drawing.Color.Black;
            this.btn_X.Location = new System.Drawing.Point(274, 3);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(30, 28);
            this.btn_X.Text = "×";
            this.btn_X.Press += new System.EventHandler(this.btn_X_Press);
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(0, 24);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(300, 293);
            this.listView2.TemplateControlName = "ShowCouPonControl";
            // 
            // CouPonControl
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel5});
            this.Padding = new Smobiler.Core.Controls.Padding(70F, 15F, 70F, 0F);
            this.SelfAlign = Smobiler.Core.Controls.LayoutSelfAlign.FlexEnd;
            this.Size = new System.Drawing.Size(300, 350);
            this.Load += new System.EventHandler(this.CouPonControl_Load);
            this.Name = "CouPonControl";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel5;
        private Smobiler.Core.Controls.Label lan_coupon;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl2;
        private Smobiler.Core.Controls.Button btn_X;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.ListView listView2;
    }
}