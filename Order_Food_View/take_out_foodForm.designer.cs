using System;
using Smobiler.Core;
namespace Order_Food_View
{
    partial class take_out_foodForm : Smobiler.Core.Controls.MobileForm
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
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.imageButton2 = new Smobiler.Core.Controls.ImageButton();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.SelectRes = new Smobiler.Core.Controls.TextBox();
            this.imageButton3 = new Smobiler.Core.Controls.ImageButton();
            this.Restaurant = new Smobiler.Core.Controls.ListView();
            this.title2 = new Smobiler.Core.Controls.Title();
            this.imageButton4 = new Smobiler.Core.Controls.ImageButton();
            this.BtnClient = new Smobiler.Core.Controls.Button();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.labMoney = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.listView1 = new Smobiler.Core.Controls.ListView();
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
            this.label1.Text = "外卖点餐";
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
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.Silver;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.label3,
            this.textBox1,
            this.imageButton2,
            this.textBox2});
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 65);
            // 
            // label2
            // 
            this.label2.FontSize = 15F;
            this.label2.Location = new System.Drawing.Point(26, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 31);
            this.label2.Text = "配送至：";
            // 
            // label3
            // 
            this.label3.FontSize = 12F;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(26, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 35);
            this.label3.Text = "起送价 ￥25 ,满80配送";
            // 
            // textBox1
            // 
            this.textBox1.Border = new Smobiler.Core.Controls.Border(1F);
            this.textBox1.BorderColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(85, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(136, 24);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // imageButton2
            // 
            this.imageButton2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton2.Location = new System.Drawing.Point(76, 8);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.ResourceID = "ios-pin";
            this.imageButton2.Size = new System.Drawing.Size(49, 24);
            this.imageButton2.Press += new System.EventHandler(this.imageButton2_Press);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 35);
            // 
            // SelectRes
            // 
            this.SelectRes.Border = new Smobiler.Core.Controls.Border(1F);
            this.SelectRes.BorderColor = System.Drawing.Color.Silver;
            this.SelectRes.ForeColor = System.Drawing.Color.DarkGray;
            this.SelectRes.Location = new System.Drawing.Point(80, 134);
            this.SelectRes.Name = "SelectRes";
            this.SelectRes.Size = new System.Drawing.Size(258, 40);
            this.SelectRes.WaterMarkText = "        请输入要搜索的菜品";
            this.SelectRes.WaterMarkTextColor = System.Drawing.Color.DarkGray;
            // 
            // imageButton3
            // 
            this.imageButton3.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton3.Location = new System.Drawing.Point(84, 142);
            this.imageButton3.Name = "imageButton3";
            this.imageButton3.ResourceID = "search";
            this.imageButton3.Size = new System.Drawing.Size(35, 23);
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
            // title2
            // 
            this.title2.BackColor = System.Drawing.Color.Transparent;
            this.title2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.title2.Location = new System.Drawing.Point(7, 862);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(100, 163);
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
            // label4
            // 
            this.label4.FontSize = 15F;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(79, 770);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 31);
            this.label4.Text = "配送费：";
            // 
            // labMoney
            // 
            this.labMoney.ForeColor = System.Drawing.Color.Red;
            this.labMoney.Location = new System.Drawing.Point(129, 768);
            this.labMoney.Name = "labMoney";
            this.labMoney.Size = new System.Drawing.Size(100, 35);
            this.labMoney.Text = "2";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(138, 768);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 35);
            this.label5.Text = "元";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 185);
            this.listView1.Name = "listView1";
            this.listView1.ShowSplitLine = true;
            this.listView1.Size = new System.Drawing.Size(97, 552);
            this.listView1.TemplateControlName = "FrmResType";
            // 
            // take_out_foodForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.label1,
            this.imageButton1,
            this.panel1,
            this.SelectRes,
            this.imageButton3,
            this.Restaurant,
            this.title2,
            this.imageButton4,
            this.BtnClient,
            this.label4,
            this.labMoney,
            this.label5,
            this.listView1});
            this.Size = new System.Drawing.Size(400, 800);
            this.Load += new System.EventHandler(this.take_out_foodForm_Load);
            this.Name = "take_out_foodForm";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.ImageButton imageButton2;
        private Smobiler.Core.Controls.TextBox textBox2;
        private Smobiler.Core.Controls.TextBox SelectRes;
        private Smobiler.Core.Controls.ImageButton imageButton3;
        private Smobiler.Core.Controls.ListView Restaurant;
        private Smobiler.Core.Controls.Title title2;
        private Smobiler.Core.Controls.ImageButton imageButton4;
        private Smobiler.Core.Controls.Button BtnClient;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label labMoney;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.TextBox textBox1;
    }
}