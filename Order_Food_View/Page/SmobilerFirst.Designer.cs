using Smobiler.Core;

namespace Order_Food_View
{
    partial class SmobilerFirst : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Smobiler.Core.Controls.ToolBarItem toolBarItem1 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem2 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem3 = new Smobiler.Core.Controls.ToolBarItem();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.restaurant_Name = new Smobiler.Core.Controls.Label();
            this.Dobusiness_Time = new Smobiler.Core.Controls.Label();
            this.State = new Smobiler.Core.Controls.Button();
            this.Address = new Smobiler.Core.Controls.Label();
            this.Phone = new Smobiler.Core.Controls.Label();
            this.pageView1 = new Smobiler.Core.Controls.PageView();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.ShiTang = new Smobiler.Core.Controls.ImageButton();
            this.canting = new Smobiler.Core.Controls.ImageButton();
            this.jifen = new Smobiler.Core.Controls.ImageButton();
            this.youhui = new Smobiler.Core.Controls.ImageButton();
            this.phoneButton1 = new Smobiler.Core.Controls.PhoneButton();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.image2 = new Smobiler.Core.Controls.Image();
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dotted;
            this.label1.FontSize = 20F;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 35);
            this.label1.Text = "首页";
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(10, 45);
            this.image1.Name = "image1";
            this.image1.ResourceID = "u123";
            this.image1.Size = new System.Drawing.Size(45, 45);
            // 
            // restaurant_Name
            // 
            this.restaurant_Name.FontSize = 16F;
            this.restaurant_Name.Location = new System.Drawing.Point(62, 45);
            this.restaurant_Name.Name = "restaurant_Name";
            this.restaurant_Name.Size = new System.Drawing.Size(136, 25);
            this.restaurant_Name.Text = "某某餐厅石佛营店";
            // 
            // Dobusiness_Time
            // 
            this.Dobusiness_Time.ForeColor = System.Drawing.Color.Gray;
            this.Dobusiness_Time.Location = new System.Drawing.Point(62, 63);
            this.Dobusiness_Time.Name = "Dobusiness_Time";
            this.Dobusiness_Time.Size = new System.Drawing.Size(100, 35);
            this.Dobusiness_Time.Text = "10:00-23:00";
            // 
            // State
            // 
            this.State.BackColor = System.Drawing.Color.LimeGreen;
            this.State.FontSize = 14F;
            this.State.Location = new System.Drawing.Point(237, 50);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(50, 20);
            this.State.Text = "营业中";
            // 
            // Address
            // 
            this.Address.FontSize = 12F;
            this.Address.ForeColor = System.Drawing.Color.Gray;
            this.Address.Location = new System.Drawing.Point(62, 90);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(127, 16);
            this.Address.Text = "北京市朝阳区石佛营路x号";
            // 
            // Phone
            // 
            this.Phone.ForeColor = System.Drawing.Color.Gray;
            this.Phone.Location = new System.Drawing.Point(224, 78);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(76, 35);
            this.Phone.Text = "15951364167";
            // 
            // pageView1
            // 
            this.pageView1.Interval = 2;
            this.pageView1.IsLoop = true;
            this.pageView1.Location = new System.Drawing.Point(0, 113);
            this.pageView1.Name = "pageView1";
            this.pageView1.Size = new System.Drawing.Size(300, 127);
            // 
            // imageButton1
            // 
            this.imageButton1.Border = new Smobiler.Core.Controls.Border(1F, 0F, 1F, 1F);
            this.imageButton1.BorderColor = System.Drawing.Color.LightGray;
            this.imageButton1.Location = new System.Drawing.Point(0, 240);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "wm";
            this.imageButton1.Size = new System.Drawing.Size(149, 115);
            this.imageButton1.Text = "外卖点餐";
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // ShiTang
            // 
            this.ShiTang.Border = new Smobiler.Core.Controls.Border(0F, 0F, 1F, 1F);
            this.ShiTang.BorderColor = System.Drawing.Color.LightGray;
            this.ShiTang.Location = new System.Drawing.Point(149, 240);
            this.ShiTang.Name = "ShiTang";
            this.ShiTang.ResourceID = "dc";
            this.ShiTang.Size = new System.Drawing.Size(151, 115);
            this.ShiTang.Text = "食堂点餐";
            this.ShiTang.Press += new System.EventHandler(this.ShiTang_Press);
            // 
            // canting
            // 
            this.canting.Location = new System.Drawing.Point(0, 355);
            this.canting.Name = "canting";
            this.canting.ResourceID = "ct1";
            this.canting.Size = new System.Drawing.Size(102, 80);
            this.canting.Text = "餐厅信息";
            this.canting.Press += new System.EventHandler(this.canting_Press);
            // 
            // jifen
            // 
            this.jifen.Location = new System.Drawing.Point(102, 355);
            this.jifen.Name = "jifen";
            this.jifen.ResourceID = "jf";
            this.jifen.Size = new System.Drawing.Size(104, 80);
            this.jifen.Text = "积分商城";
            // 
            // youhui
            // 
            this.youhui.Location = new System.Drawing.Point(206, 355);
            this.youhui.Name = "youhui";
            this.youhui.ResourceID = "yhq";
            this.youhui.Size = new System.Drawing.Size(94, 80);
            this.youhui.Text = "优惠券";
            // 
            // phoneButton1
            // 
            this.phoneButton1.Location = new System.Drawing.Point(208, 85);
            this.phoneButton1.Name = "phoneButton1";
            this.phoneButton1.PhoneNumber = "15951364167";
            this.phoneButton1.ResourceID = "4";
            this.phoneButton1.Size = new System.Drawing.Size(20, 20);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dotted;
            this.line1.Location = new System.Drawing.Point(0, 442);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            // 
            // toolBar1
            // 
            toolBarItem1.IconID = "home";
            toolBarItem1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem1.Name = "Home";
            toolBarItem1.SelectIconColor = System.Drawing.Color.Red;
            toolBarItem1.SelectIconID = "home";
            toolBarItem1.Text = "主页";
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
            this.toolBar1.ItemWidth = 40;
            this.toolBar1.Location = new System.Drawing.Point(162, 459);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(100, 50);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick);
            // 
            // image2
            // 
            this.image2.Location = new System.Drawing.Point(48, 89);
            this.image2.Name = "image2";
            this.image2.ResourceID = "dz";
            this.image2.Size = new System.Drawing.Size(16, 16);
            // 
            // SmobilerFirst
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.image1,
            this.restaurant_Name,
            this.Dobusiness_Time,
            this.State,
            this.Address,
            this.Phone,
            this.pageView1,
            this.imageButton1,
            this.ShiTang,
            this.canting,
            this.jifen,
            this.youhui,
            this.phoneButton1,
            this.line1,
            this.toolBar1,
            this.image2});
            this.DrawerPosition = Smobiler.Core.Controls.DrawerPosition.Right;
            this.Load += new System.EventHandler(this.SmobilerFirst_Load);
            this.Name = "SmobilerFirst";

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label restaurant_Name;
        private Smobiler.Core.Controls.Label Dobusiness_Time;
        private Smobiler.Core.Controls.Button State;
        private Smobiler.Core.Controls.Label Address;
        private Smobiler.Core.Controls.Label Phone;
        private Smobiler.Core.Controls.PageView pageView1;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.ImageButton ShiTang;
        private Smobiler.Core.Controls.ImageButton canting;
        private Smobiler.Core.Controls.ImageButton jifen;
        private Smobiler.Core.Controls.ImageButton youhui;
        private Smobiler.Core.Controls.PhoneButton phoneButton1;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.ToolBar toolBar1;
        private Smobiler.Core.Controls.Image image2;
    }
}