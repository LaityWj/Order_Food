using System;
using Smobiler.Core;
namespace Order_Food_View.Page.TS_eat
{
    partial class TS_In_FoodForm : Smobiler.Core.Controls.MobileForm
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.lab_table = new Smobiler.Core.Controls.Label();
            this.barcodeScannerButton1 = new Smobiler.Core.Controls.BarcodeScannerButton();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.lab_desk = new Smobiler.Core.Controls.Label();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.Restaurant = new Smobiler.Core.Controls.ListView();
            this.BtnClient = new Smobiler.Core.Controls.Button();
            this.imageButton4 = new Smobiler.Core.Controls.ImageButton();
            this.title2 = new Smobiler.Core.Controls.Title();
            this.txt_name = new Smobiler.Core.Controls.TextBox();
            this.imageButton3 = new Smobiler.Core.Controls.ImageButton();
            // 
            // title1
            // 
            this.title1.Location = new System.Drawing.Point(24, 27);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 63);
            // 
            // label1
            // 
            this.label1.FontSize = 20F;
            this.label1.Location = new System.Drawing.Point(163, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.Text = "堂食点餐";
            // 
            // imageButton1
            // 
            this.imageButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton1.Location = new System.Drawing.Point(7, 14);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "angle-left";
            this.imageButton1.Size = new System.Drawing.Size(43, 34);
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.lab_table,
            this.barcodeScannerButton1,
            this.label3,
            this.line1,
            this.lab_desk});
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 57);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(15, 9);
            this.image1.Name = "image1";
            this.image1.ResourceID = "table";
            this.image1.Size = new System.Drawing.Size(35, 35);
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
            this.barcodeScannerButton1.Location = new System.Drawing.Point(361, 11);
            this.barcodeScannerButton1.Name = "barcodeScannerButton1";
            this.barcodeScannerButton1.ResourceID = "BarcodeScanner";
            this.barcodeScannerButton1.Size = new System.Drawing.Size(35, 35);
            this.barcodeScannerButton1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScannerButton1_BarcodeScanned);
            this.barcodeScannerButton1.Press += new System.EventHandler(this.barcodeScannerButton1_Press);
            // 
            // label3
            // 
            this.label3.FontSize = 14F;
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label3.Location = new System.Drawing.Point(326, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 35);
            this.label3.Text = "扫码";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.line1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.line1.Location = new System.Drawing.Point(2, 56);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(398, 1);
            // 
            // lab_desk
            // 
            this.lab_desk.Bold = true;
            this.lab_desk.FontSize = 20F;
            this.lab_desk.Location = new System.Drawing.Point(99, 11);
            this.lab_desk.Name = "lab_desk";
            this.lab_desk.Size = new System.Drawing.Size(38, 35);
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.line2.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.line2.Location = new System.Drawing.Point(2, 62);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(398, 1);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 185);
            this.listView1.Name = "listView1";
            this.listView1.ShowSplitLine = true;
            this.listView1.Size = new System.Drawing.Size(97, 552);
            this.listView1.TemplateControlName = "FrmResType";
            // 
            // Restaurant
            // 
            this.Restaurant.BackColor = System.Drawing.Color.Linen;
            this.Restaurant.BorderColor = System.Drawing.Color.DarkGray;
            this.Restaurant.Location = new System.Drawing.Point(97, 185);
            this.Restaurant.Name = "Restaurant";
            this.Restaurant.ShowSplitLine = true;
            this.Restaurant.Size = new System.Drawing.Size(303, 552);
            this.Restaurant.TemplateControlName = "frmResList";
            // 
            // BtnClient
            // 
            this.BtnClient.BackColor = System.Drawing.Color.Gray;
            this.BtnClient.BorderRadius = 0;
            this.BtnClient.FontSize = 25F;
            this.BtnClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClient.Location = new System.Drawing.Point(221, 737);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(193, 101);
            this.BtnClient.Press += new System.EventHandler(this.BtnClient_Press);
            // 
            // imageButton4
            // 
            this.imageButton4.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton4.Location = new System.Drawing.Point(16, 759);
            this.imageButton4.Name = "imageButton4";
            this.imageButton4.ResourceID = "md-cart";
            this.imageButton4.Size = new System.Drawing.Size(59, 51);
            this.imageButton4.Press += new System.EventHandler(this.imageButton4_Press);
            // 
            // title2
            // 
            this.title2.BackColor = System.Drawing.Color.Transparent;
            this.title2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.title2.Location = new System.Drawing.Point(7, 862);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(100, 163);
            // 
            // txt_name
            // 
            this.txt_name.Border = new Smobiler.Core.Controls.Border(1F);
            this.txt_name.BorderColor = System.Drawing.Color.Silver;
            this.txt_name.BorderRadius = 8;
            this.txt_name.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.txt_name.Location = new System.Drawing.Point(56, 136);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Search;
            this.txt_name.SelectOnFocus = true;
            this.txt_name.Size = new System.Drawing.Size(273, 33);
            this.txt_name.WaterMarkText = "请输入搜索内容";
            // 
            // imageButton3
            // 
            this.imageButton3.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton3.Location = new System.Drawing.Point(62, 140);
            this.imageButton3.Name = "imageButton3";
            this.imageButton3.ResourceID = "search";
            this.imageButton3.Size = new System.Drawing.Size(35, 23);
            this.imageButton3.Press += new System.EventHandler(this.imageButton3_Press);
            // 
            // TS_In_FoodForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.label1,
            this.imageButton1,
            this.panel1,
            this.line2,
            this.listView1,
            this.Restaurant,
            this.BtnClient,
            this.imageButton4,
            this.title2,
            this.txt_name,
            this.imageButton3});
            this.Size = new System.Drawing.Size(400, 800);
            this.Name = "TS_In_FoodForm";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label lab_table;
        private Smobiler.Core.Controls.BarcodeScannerButton barcodeScannerButton1;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.ListView Restaurant;
        private Smobiler.Core.Controls.Button BtnClient;
        private Smobiler.Core.Controls.ImageButton imageButton4;
        private Smobiler.Core.Controls.Title title2;
        private Smobiler.Core.Controls.Label lab_desk;
        private Smobiler.Core.Controls.TextBox txt_name;
        private Smobiler.Core.Controls.ImageButton imageButton3;
    }
}