using System;
using Smobiler.Core;
namespace Order_Food_View.Page
{
    partial class OrderForm : Smobiler.Core.Controls.MobileForm
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
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.btn_CouPon = new Smobiler.Core.Controls.Button();
            this.panel6 = new Smobiler.Core.Controls.Panel();
            this.lab_number = new Smobiler.Core.Controls.Label();
            this.lab_num = new Smobiler.Core.Controls.Label();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.wx = new Smobiler.Core.Controls.CheckBox();
            this.qb = new Smobiler.Core.Controls.CheckBox();
            this.image2 = new Smobiler.Core.Controls.Image();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.panel7 = new Smobiler.Core.Controls.Panel();
            this.lab_money = new Smobiler.Core.Controls.Label();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.btn_Pay = new Smobiler.Core.Controls.Button();
            this.image3 = new Smobiler.Core.Controls.Image();
            this.barcodeScannerButton1 = new Smobiler.Core.Controls.BarcodeScannerButton();
            this.lab_table = new Smobiler.Core.Controls.Label();
            this.lab_desk = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.barcodeScannerButton1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5,
            this.label8,
            this.wx,
            this.qb,
            this.image2,
            this.label9,
            this.label10,
            this.label6,
            this.label7,
            this.panel7,
            this.image3});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 580);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderColor = System.Drawing.Color.White;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.imageButton1});
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 44);
            // 
            // label1
            // 
            this.label1.FontSize = 18F;
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.Text = "确认订单";
            // 
            // imageButton1
            // 
            this.imageButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton1.Location = new System.Drawing.Point(3, 11);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "md-arrow-back";
            this.imageButton1.Size = new System.Drawing.Size(24, 22);
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.lab_table,
            this.lab_desk});
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 57);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(13, 11);
            this.image1.Name = "image1";
            this.image1.ResourceID = "table";
            this.image1.Size = new System.Drawing.Size(35, 35);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3});
            this.panel4.Location = new System.Drawing.Point(0, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 26);
            // 
            // label3
            // 
            this.label3.FontSize = 12F;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(50, 4);
            this.label3.Name = "label3";
            this.label3.SelfAlign = Smobiler.Core.Controls.LayoutSelfAlign.Center;
            this.label3.Size = new System.Drawing.Size(258, 19);
            this.label3.Text = "温馨提示:30分钟内未付款订单将自动取消";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label4,
            this.listView1,
            this.label5,
            this.btn_CouPon,
            this.panel6,
            this.textBox1});
            this.panel5.Location = new System.Drawing.Point(0, 147);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 286);
            // 
            // label4
            // 
            this.label4.FontSize = 16F;
            this.label4.Location = new System.Drawing.Point(13, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.Text = "订单详情";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 160);
            this.listView1.TemplateControlName = "OrderUserControl";
            // 
            // label5
            // 
            this.label5.FontSize = 16F;
            this.label5.Location = new System.Drawing.Point(13, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.Text = "优惠券";
            // 
            // btn_CouPon
            // 
            this.btn_CouPon.BackColor = System.Drawing.Color.White;
            this.btn_CouPon.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dashed;
            this.btn_CouPon.FontSize = 18F;
            this.btn_CouPon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CouPon.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btn_CouPon.Location = new System.Drawing.Point(207, 215);
            this.btn_CouPon.Name = "btn_CouPon";
            this.btn_CouPon.Size = new System.Drawing.Size(92, 26);
            this.btn_CouPon.Text = ">";
            this.btn_CouPon.Press += new System.EventHandler(this.btn_CouPon_Press);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lab_number,
            this.lab_num});
            this.panel6.Location = new System.Drawing.Point(86, 260);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(213, 25);
            // 
            // lab_number
            // 
            this.lab_number.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lab_number.Location = new System.Drawing.Point(65, 4);
            this.lab_number.Name = "lab_number";
            this.lab_number.Size = new System.Drawing.Size(75, 18);
            this.lab_number.Text = "label7";
            // 
            // lab_num
            // 
            this.lab_num.Location = new System.Drawing.Point(140, 4);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(64, 18);
            this.lab_num.Text = "label7";
            // 
            // textBox1
            // 
            this.textBox1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox1.Location = new System.Drawing.Point(218, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(59, 24);
            this.textBox1.Text = "无可用";
            this.textBox1.SubmitEditing += new System.EventHandler(this.textBox1_SubmitEditing);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 76);
            // 
            // wx
            // 
            this.wx.Location = new System.Drawing.Point(266, 447);
            this.wx.Name = "wx";
            this.wx.Size = new System.Drawing.Size(15, 15);
            this.wx.Style = Smobiler.Core.Controls.CheckBoxStyle.Circular;
            this.wx.TintColor = System.Drawing.Color.Black;
            // 
            // qb
            // 
            this.qb.Location = new System.Drawing.Point(266, 477);
            this.qb.Name = "qb";
            this.qb.Size = new System.Drawing.Size(15, 15);
            this.qb.Style = Smobiler.Core.Controls.CheckBoxStyle.Circular;
            this.qb.TintColor = System.Drawing.Color.Black;
            // 
            // image2
            // 
            this.image2.Location = new System.Drawing.Point(6, 445);
            this.image2.Name = "image2";
            this.image2.ResourceID = "wx";
            this.image2.Size = new System.Drawing.Size(22, 22);
            // 
            // label9
            // 
            this.label9.FontSize = 15F;
            this.label9.Location = new System.Drawing.Point(34, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.Text = "微信支付";
            // 
            // label10
            // 
            this.label10.FontSize = 15F;
            this.label10.Location = new System.Drawing.Point(33, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 22);
            this.label10.Text = "会员钱包支付（余额：100）";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.Text = "开票方式";
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(182, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 15);
            this.label7.Text = "餐厅提供电子发票";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lab_money,
            this.label11,
            this.btn_Pay});
            this.panel7.Location = new System.Drawing.Point(0, 520);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 70);
            // 
            // lab_money
            // 
            this.lab_money.FontSize = 16F;
            this.lab_money.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lab_money.Name = "lab_money";
            this.lab_money.Size = new System.Drawing.Size(67, 73);
            this.lab_money.Text = "应付:";
            // 
            // label11
            // 
            this.label11.FontSize = 16F;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(68, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 72);
            this.label11.Text = "￥150";
            // 
            // btn_Pay
            // 
            this.btn_Pay.BackColor = System.Drawing.Color.Red;
            this.btn_Pay.FontSize = 16F;
            this.btn_Pay.Location = new System.Drawing.Point(158, 0);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(142, 60);
            this.btn_Pay.Text = "去支付";
            this.btn_Pay.Press += new System.EventHandler(this.btn_Pay_Press);
            // 
            // image3
            // 
            this.image3.Location = new System.Drawing.Point(5, 472);
            this.image3.Name = "image3";
            this.image3.ResourceID = "qb";
            this.image3.Size = new System.Drawing.Size(22, 22);
            // 
            // barcodeScannerButton1
            // 
            this.barcodeScannerButton1.Location = new System.Drawing.Point(317, 12);
            this.barcodeScannerButton1.Name = "barcodeScannerButton1";
            this.barcodeScannerButton1.ResourceID = "BarcodeScanner";
            this.barcodeScannerButton1.Size = new System.Drawing.Size(35, 35);
            this.barcodeScannerButton1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScannerButton1_BarcodeScanned);
            this.barcodeScannerButton1.Press += new System.EventHandler(this.barcodeScannerButton1_Press);
            // 
            // lab_table
            // 
            this.lab_table.Bold = true;
            this.lab_table.FontSize = 20F;
            this.lab_table.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lab_table.Location = new System.Drawing.Point(53, 13);
            this.lab_table.Name = "lab_table";
            this.lab_table.Size = new System.Drawing.Size(40, 35);
            // 
            // lab_desk
            // 
            this.lab_desk.Bold = true;
            this.lab_desk.FontSize = 20F;
            this.lab_desk.Location = new System.Drawing.Point(93, 13);
            this.lab_desk.Name = "lab_desk";
            this.lab_desk.Size = new System.Drawing.Size(38, 35);
            // 
            // OrderForm
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 580);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.Name = "OrderForm";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Panel panel5;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Button btn_CouPon;
        private Smobiler.Core.Controls.Panel panel6;
        private Smobiler.Core.Controls.Label lab_number;
        private Smobiler.Core.Controls.Label lab_num;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.CheckBox wx;
        private Smobiler.Core.Controls.CheckBox qb;
        private Smobiler.Core.Controls.Image image2;
        private Smobiler.Core.Controls.Label label9;
        private Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Panel panel7;
        private Smobiler.Core.Controls.Label lab_money;
        private Smobiler.Core.Controls.Label label11;
        private Smobiler.Core.Controls.Button btn_Pay;
        private Smobiler.Core.Controls.Image image3;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.BarcodeScannerButton barcodeScannerButton1;
        private Smobiler.Core.Controls.Label lab_table;
        private Smobiler.Core.Controls.Label lab_desk;
    }
}