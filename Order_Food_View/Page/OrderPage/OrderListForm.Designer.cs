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
            Smobiler.Core.Controls.ToolBarItem toolBarItem1 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem2 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem3 = new Smobiler.Core.Controls.ToolBarItem();
            this.tab_orderlist = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl1 = new Smobiler.Core.Controls.TabPageControl();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl3 = new Smobiler.Core.Controls.TabPageControl();
            this.tabPageControl4 = new Smobiler.Core.Controls.TabPageControl();
            this.tabPageControl5 = new Smobiler.Core.Controls.TabPageControl();
            this.tabPageControl6 = new Smobiler.Core.Controls.TabPageControl();
            this.tabPageControl2 = new Smobiler.Core.Controls.TabPageControl();
            this.tabPageView2 = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl7 = new Smobiler.Core.Controls.TabPageControl();
            this.pageView2 = new Smobiler.Core.Controls.PageView();
            this.listView2 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl8 = new Smobiler.Core.Controls.TabPageControl();
            this.listView3 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl9 = new Smobiler.Core.Controls.TabPageControl();
            this.tabPageControl10 = new Smobiler.Core.Controls.TabPageControl();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.listView1 = new Smobiler.Core.Controls.ListView();
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
            this.tab_orderlist.Size = new System.Drawing.Size(300, 410);
            this.tab_orderlist.Titles = new string[] {
        "堂食订单",
        "外卖订单"};
            this.tab_orderlist.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Red, 13F, System.Drawing.Color.Red, 2);
            this.tab_orderlist.TitleWidth = 150;
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
            this.tabPageView1.Size = new System.Drawing.Size(300, 408);
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
            // tabPageControl4
            // 
            this.tabPageControl4.Name = "tabPageControl4";
            // 
            // tabPageControl5
            // 
            this.tabPageControl5.Name = "tabPageControl5";
            // 
            // tabPageControl6
            // 
            this.tabPageControl6.Name = "tabPageControl6";
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
            this.tabPageView2.Size = new System.Drawing.Size(300, 436);
            this.tabPageView2.Titles = new string[] {
        "全部",
        "待付款",
        "待收取",
        "已完成"};
            this.tabPageView2.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Red);
            // 
            // tabPageControl7
            // 
            this.tabPageControl7.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.pageView2,
            this.listView2});
            this.tabPageControl7.Name = "tabPageControl7";
            // 
            // pageView2
            // 
            this.pageView2.Location = new System.Drawing.Point(0, 27);
            this.pageView2.Name = "pageView2";
            this.pageView2.Size = new System.Drawing.Size(300, 409);
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(0, 27);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(300, 409);
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
            this.listView3.Location = new System.Drawing.Point(0, 27);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(300, 409);
            this.listView3.TemplateControlName = "OrderShowListControl";
            // 
            // tabPageControl9
            // 
            this.tabPageControl9.Name = "tabPageControl9";
            // 
            // tabPageControl10
            // 
            this.tabPageControl10.Name = "tabPageControl10";
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
            // listView1
            // 
            this.listView1.Flex = 1;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 407);
            this.listView1.TemplateControlName = "OrderShowListControl";
            // 
            // toolBar1
            // 
            toolBarItem1.IconID = "home";
            toolBarItem1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem1.Name = "Home";
            toolBarItem1.SelectIconColor = System.Drawing.Color.Red;
            toolBarItem1.SelectIconID = "home";
            toolBarItem1.Text = "首页";
            toolBarItem2.IconID = "file-text-o";
            toolBarItem2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem2.Name = "Order";
            toolBarItem2.SelectIconColor = System.Drawing.Color.Red;
            toolBarItem2.SelectIconID = "file-text-o";
            toolBarItem2.Text = "订单";
            toolBarItem3.IconID = "user";
            toolBarItem3.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem3.Name = "My";
            toolBarItem3.SelectIconColor = System.Drawing.Color.Red;
            toolBarItem3.SelectIconID = "user";
            toolBarItem3.Text = "我的";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1,
            toolBarItem2,
            toolBarItem3});
            this.toolBar1.Location = new System.Drawing.Point(214, 469);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(100, 50);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick_1);
            // 
            // OrderListForm
            // 
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
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl3;
        private Smobiler.Core.Controls.TabPageControl tabPageControl4;
        private Smobiler.Core.Controls.TabPageControl tabPageControl5;
        private Smobiler.Core.Controls.TabPageControl tabPageControl6;
        private Smobiler.Core.Controls.TabPageView tabPageView2;
        private Smobiler.Core.Controls.TabPageControl tabPageControl7;
        private Smobiler.Core.Controls.PageView pageView2;
        private Smobiler.Core.Controls.ListView listView2;
        private Smobiler.Core.Controls.TabPageControl tabPageControl8;
        private Smobiler.Core.Controls.TabPageControl tabPageControl9;
        private Smobiler.Core.Controls.TabPageControl tabPageControl10;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.ListView listView3;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.ToolBar toolBar1;
    }
}