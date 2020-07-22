using System;
using Smobiler.Core;
namespace Order_Food_View.Page
{
    partial class OrderListForm : Smobiler.Core.Controls.MobileForm
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
            this.tab_orderlist = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl1 = new Smobiler.Core.Controls.TabPageControl();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl3 = new Smobiler.Core.Controls.TabPageControl();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl4 = new Smobiler.Core.Controls.TabPageControl();
            this.listView4 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl5 = new Smobiler.Core.Controls.TabPageControl();
            this.listView5 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl6 = new Smobiler.Core.Controls.TabPageControl();
            this.listView6 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl2 = new Smobiler.Core.Controls.TabPageControl();
            this.tabPageView2 = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl7 = new Smobiler.Core.Controls.TabPageControl();
            this.listView2 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl8 = new Smobiler.Core.Controls.TabPageControl();
            this.listView3 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl9 = new Smobiler.Core.Controls.TabPageControl();
            this.listView7 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl10 = new Smobiler.Core.Controls.TabPageControl();
            this.listView8 = new Smobiler.Core.Controls.ListView();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            // 
            // tab_orderlist
            // 
            this.tab_orderlist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_orderlist.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tab_orderlist.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dotted;
            this.tab_orderlist.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageControl1,
            this.tabPageControl2});
            this.tab_orderlist.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.tab_orderlist.Location = new System.Drawing.Point(0, 36);
            this.tab_orderlist.Name = "tab_orderlist";
            this.tab_orderlist.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tab_orderlist.Size = new System.Drawing.Size(300, 522);
            this.tab_orderlist.Titles = new string[] {
        "堂食订单",
        "外卖订单"};
            this.tab_orderlist.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Red, 13F, System.Drawing.Color.Red, 2);
            this.tab_orderlist.TitleWidth = 150;
            this.tab_orderlist.PageIndexChanged += new System.EventHandler(this.tab_orderlist_PageIndexChanged);
            // 
            // tabPageControl1
            // 
            this.tabPageControl1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageView1});
            this.tabPageControl1.Name = "tabPageControl1";
            // 
            // tabPageView1
            // 
            this.tabPageView1.BackColor = System.Drawing.Color.White;
            this.tabPageView1.BorderColor = System.Drawing.Color.White;
            this.tabPageView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageControl3,
            this.tabPageControl4,
            this.tabPageControl5,
            this.tabPageControl6});
            this.tabPageView1.Location = new System.Drawing.Point(0, 1);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(300, 534);
            this.tabPageView1.Titles = new string[] {
        "全部",
        "待付款",
        "已完成",
        "已取消"};
            this.tabPageView1.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Red, 13F, System.Drawing.Color.Red, 2);
            // 
            // tabPageControl3
            // 
            this.tabPageControl3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView1});
            this.tabPageControl3.Name = "tabPageControl3";
            // 
            // listView1
            // 
            this.listView1.Flex = 1;
            this.listView1.Location = new System.Drawing.Point(0, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 398);
            this.listView1.TemplateControlName = "OrderShowListControl";
            // 
            // tabPageControl4
            // 
            this.tabPageControl4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView4});
            this.tabPageControl4.Name = "tabPageControl4";
            // 
            // listView4
            // 
            this.listView4.Flex = 1;
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(300, 521);
            this.listView4.TemplateControlName = "OrderShowListControl";
            // 
            // tabPageControl5
            // 
            this.tabPageControl5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView5});
            this.tabPageControl5.Name = "tabPageControl5";
            // 
            // listView5
            // 
            this.listView5.Flex = 1;
            this.listView5.Location = new System.Drawing.Point(0, 14);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(300, 513);
            this.listView5.TemplateControlName = "OrderShowListControl";
            // 
            // tabPageControl6
            // 
            this.tabPageControl6.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView6});
            this.tabPageControl6.Name = "tabPageControl6";
            // 
            // listView6
            // 
            this.listView6.Flex = 1;
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(300, 513);
            this.listView6.TemplateControlName = "OrderShowListControl";
            // 
            // tabPageControl2
            // 
            this.tabPageControl2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageView2});
            this.tabPageControl2.Name = "tabPageControl2";
            // 
            // tabPageView2
            // 
            this.tabPageView2.BackColor = System.Drawing.Color.White;
            this.tabPageView2.BorderColor = System.Drawing.Color.White;
            this.tabPageView2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageControl7,
            this.tabPageControl8,
            this.tabPageControl9,
            this.tabPageControl10});
            this.tabPageView2.Location = new System.Drawing.Point(0, 1);
            this.tabPageView2.Name = "tabPageView2";
            this.tabPageView2.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tabPageView2.Size = new System.Drawing.Size(300, 520);
            this.tabPageView2.Titles = new string[] {
        "全部",
        "待付款",
        "待收取",
        "已完成"};
            this.tabPageView2.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Red, 13F, System.Drawing.Color.Red, 2);
            // 
            // tabPageControl7
            // 
            this.tabPageControl7.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView2});
            this.tabPageControl7.Name = "tabPageControl7";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(0, 20);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(300, 401);
            this.listView2.TemplateControlName = "OrderShowListControl";
            // 
            // tabPageControl8
            // 
            this.tabPageControl8.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView3});
            this.tabPageControl8.Name = "tabPageControl8";
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(0, 24);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(300, 498);
            this.listView3.TemplateControlName = "OrderShowListControl";
            // 
            // tabPageControl9
            // 
            this.tabPageControl9.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView7});
            this.tabPageControl9.Name = "tabPageControl9";
            // 
            // listView7
            // 
            this.listView7.Location = new System.Drawing.Point(0, 24);
            this.listView7.Name = "listView7";
            this.listView7.Size = new System.Drawing.Size(300, 496);
            this.listView7.TemplateControlName = "OrderShowListControl";
            // 
            // tabPageControl10
            // 
            this.tabPageControl10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView8});
            this.tabPageControl10.Name = "tabPageControl10";
            // 
            // listView8
            // 
            this.listView8.Location = new System.Drawing.Point(0, 24);
            this.listView8.Name = "listView8";
            this.listView8.Size = new System.Drawing.Size(300, 497);
            this.listView8.TemplateControlName = "OrderShowListControl";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Bold = true;
            this.label1.FontSize = 20F;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 36);
            this.label1.Text = "订单";
            // 
            // toolBar1
            // 
            toolBarItem7.IconID = "home";
            toolBarItem7.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem7.Name = "Home";
            toolBarItem7.SelectIconColor = System.Drawing.Color.Red;
            toolBarItem7.SelectIconID = "home";
            toolBarItem7.Text = "首页";
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
            this.toolBar1.Location = new System.Drawing.Point(214, 469);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(300, 42);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick_1);
            // 
            // OrderListForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tab_orderlist,
            this.label1,
            this.toolBar1});
            this.IOSBottomHidden = true;
            this.Load += new System.EventHandler(this.OrderListForm_Load);
            this.Name = "OrderListForm";

        }
        #endregion
        private Smobiler.Core.Controls.TabPageView tab_orderlist;
        private Smobiler.Core.Controls.TabPageControl tabPageControl2;
        private Smobiler.Core.Controls.TabPageControl tabPageControl1;
        private Smobiler.Core.Controls.TabPageView tabPageView2;
        private Smobiler.Core.Controls.TabPageControl tabPageControl7;
        private Smobiler.Core.Controls.TabPageControl tabPageControl8;
        private Smobiler.Core.Controls.TabPageControl tabPageControl9;
        private Smobiler.Core.Controls.TabPageControl tabPageControl10;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.ToolBar toolBar1;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl3;
        private Smobiler.Core.Controls.TabPageControl tabPageControl4;
        private Smobiler.Core.Controls.ListView listView4;
        private Smobiler.Core.Controls.TabPageControl tabPageControl5;
        private Smobiler.Core.Controls.ListView listView5;
        private Smobiler.Core.Controls.TabPageControl tabPageControl6;
        private Smobiler.Core.Controls.ListView listView6;
        private Smobiler.Core.Controls.ListView listView2;
        private Smobiler.Core.Controls.ListView listView3;
        private Smobiler.Core.Controls.ListView listView7;
        private Smobiler.Core.Controls.ListView listView8;
        private Smobiler.Core.Controls.ListView listView1;
    }
}