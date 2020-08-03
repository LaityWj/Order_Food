using System;
using Smobiler.Core;
namespace Order_Food_View.Page.TS_eat
{
    partial class TS_EatFormList : Smobiler.Core.Controls.MobileForm
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
            this.title1 = new Smobiler.Core.Controls.Title();
            this.title2 = new Smobiler.Core.Controls.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.title3 = new Smobiler.Core.Controls.Title();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.lab_desk = new Smobiler.Core.Controls.Label();
            this.lab_table = new Smobiler.Core.Controls.Label();
            this.barcodeScannerButton1 = new Smobiler.Core.Controls.BarcodeScannerButton();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txt_name = new Smobiler.Core.Controls.TextBox();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.foods_listView = new Smobiler.Core.Controls.ListView();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.img_car = new Smobiler.Core.Controls.ImageButton();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lab_summoney = new Smobiler.Core.Controls.Label();
            this.btn_order = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.Location = new System.Drawing.Point(156, 66);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 47);
            // 
            // title2
            // 
            this.title2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.title2.Location = new System.Drawing.Point(194, 147);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(100, 75);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title3,
            this.image1,
            this.lab_desk,
            this.lab_table,
            this.barcodeScannerButton1,
            this.label2,
            this.txt_name,
            this.panel2,
            this.foods_listView,
            this.button1});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // title3
            // 
            this.title3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.title3.BorderColor = System.Drawing.Color.Gainsboro;
            this.title3.Location = new System.Drawing.Point(172, 34);
            this.title3.Name = "title3";
            this.title3.Size = new System.Drawing.Size(100, 53);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(15, 9);
            this.image1.Name = "image1";
            this.image1.ResourceID = "table";
            this.image1.Size = new System.Drawing.Size(35, 35);
            // 
            // lab_desk
            // 
            this.lab_desk.Bold = true;
            this.lab_desk.FontSize = 20F;
            this.lab_desk.Location = new System.Drawing.Point(99, 11);
            this.lab_desk.Name = "lab_desk";
            this.lab_desk.Size = new System.Drawing.Size(38, 35);
            // 
            // lab_table
            // 
            this.lab_table.Bold = true;
            this.lab_table.FontSize = 20F;
            this.lab_table.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lab_table.Location = new System.Drawing.Point(59, 11);
            this.lab_table.Name = "lab_table";
            this.lab_table.Size = new System.Drawing.Size(40, 35);
            // 
            // barcodeScannerButton1
            // 
            this.barcodeScannerButton1.Location = new System.Drawing.Point(254, 9);
            this.barcodeScannerButton1.Name = "barcodeScannerButton1";
            this.barcodeScannerButton1.ResourceID = "BarcodeScanner";
            this.barcodeScannerButton1.Size = new System.Drawing.Size(35, 35);
            this.barcodeScannerButton1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScannerButton1_BarcodeScanned_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(218, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 35);
            this.label2.Text = "扫码";
            // 
            // txt_name
            // 
            this.txt_name.Border = new Smobiler.Core.Controls.Border(1F);
            this.txt_name.BorderColor = System.Drawing.Color.Silver;
            this.txt_name.BorderRadius = 8;
            this.txt_name.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.txt_name.Location = new System.Drawing.Point(14, 60);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Search;
            this.txt_name.SelectOnFocus = true;
            this.txt_name.Size = new System.Drawing.Size(273, 33);
            this.txt_name.WaterMarkText = "请输入搜索内容";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Scrollable = true;
            this.panel2.ShowHorizontalScrollBar = false;
            this.panel2.ShowVerticalScrollBar = false;
            this.panel2.Size = new System.Drawing.Size(83, 384);
            this.panel2.Wrap = Smobiler.Core.Controls.LayoutWrap.Wrap;
            // 
            // foods_listView
            // 
            this.foods_listView.Location = new System.Drawing.Point(83, 93);
            this.foods_listView.Name = "foods_listView";
            this.foods_listView.RaiseRefresh = true;
            this.foods_listView.Size = new System.Drawing.Size(217, 384);
            this.foods_listView.TemplateControlName = "OrderResList";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BorderColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(15, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 31);
            this.button1.Text = "搜索";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // imageButton1
            // 
            this.imageButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton1.Location = new System.Drawing.Point(7, 7);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "angle-left";
            this.imageButton1.Size = new System.Drawing.Size(43, 34);
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // label1
            // 
            this.label1.FontSize = 20F;
            this.label1.Location = new System.Drawing.Point(92, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.Text = "堂食点餐";
            // 
            // img_car
            // 
            this.img_car.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.img_car.Location = new System.Drawing.Point(7, 533);
            this.img_car.Name = "img_car";
            this.img_car.ResourceID = "md-cart";
            this.img_car.Size = new System.Drawing.Size(59, 51);
            this.img_car.Press += new System.EventHandler(this.img_car_Press);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label3.Location = new System.Drawing.Point(66, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 31);
            this.label3.Text = "￥：";
            // 
            // lab_summoney
            // 
            this.lab_summoney.ForeColor = System.Drawing.Color.Red;
            this.lab_summoney.Location = new System.Drawing.Point(101, 549);
            this.lab_summoney.Name = "lab_summoney";
            this.lab_summoney.Size = new System.Drawing.Size(68, 35);
            this.lab_summoney.Text = "0";
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.Gray;
            this.btn_order.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_order.BorderRadius = 0;
            this.btn_order.FontSize = 18F;
            this.btn_order.Location = new System.Drawing.Point(182, 525);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(118, 75);
            this.btn_order.Text = "去点餐";
            this.btn_order.Press += new System.EventHandler(this.btn_order_Press);
            // 
            // TS_EatFormList
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.title2,
            this.panel1,
            this.imageButton1,
            this.label1,
            this.img_car,
            this.label3,
            this.lab_summoney,
            this.btn_order});
            this.Size = new System.Drawing.Size(300, 600);
            this.Load += new System.EventHandler(this.TS_EatFormList_Load);
            this.Name = "TS_EatFormList";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Title title2;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Title title3;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label lab_desk;
        private Smobiler.Core.Controls.Label lab_table;
        private Smobiler.Core.Controls.BarcodeScannerButton barcodeScannerButton1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox txt_name;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.ListView foods_listView;
        private Smobiler.Core.Controls.ImageButton img_car;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label lab_summoney;
        private Smobiler.Core.Controls.Button btn_order;
        private Smobiler.Core.Controls.Button button1;
    }
}