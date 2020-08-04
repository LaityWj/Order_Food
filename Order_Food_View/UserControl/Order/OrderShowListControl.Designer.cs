using System;
using Smobiler.Core;
namespace Order_Food_View.UserControl
{
    partial class OrderShowListControl : Smobiler.Core.Controls.MobileUserControl
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lab_OrderNo = new Smobiler.Core.Controls.Label();
            this.lab_state = new Smobiler.Core.Controls.Label();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton2 = new Smobiler.Core.Controls.ImageButton();
            this.lab_Sumnumber = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.btn_setOrder = new Smobiler.Core.Controls.Button();
            this.btn_successOrder = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lab_sum = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.lab_money = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.lab_OrderNo,
            this.lab_state,
            this.imageButton1,
            this.imageButton2,
            this.lab_Sumnumber,
            this.label2,
            this.line2,
            this.btn_setOrder,
            this.btn_successOrder,
            this.label3,
            this.lab_sum,
            this.label4,
            this.label5,
            this.lab_money,
            this.label6,
            this.label7,
            this.label8});
            this.panel1.Name = "panel1";
            this.panel1.RaiseReachEnd = true;
            this.panel1.Size = new System.Drawing.Size(300, 172);
            // 
            // label1
            // 
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.Text = "订单编号:";
            // 
            // lab_OrderNo
            // 
            this.lab_OrderNo.DataMember = "Order_No";
            this.lab_OrderNo.DisplayMember = "Order_No";
            this.lab_OrderNo.Location = new System.Drawing.Point(67, 2);
            this.lab_OrderNo.Name = "lab_OrderNo";
            this.lab_OrderNo.Size = new System.Drawing.Size(100, 26);
            this.lab_OrderNo.Text = "label2";
            // 
            // lab_state
            // 
            this.lab_state.DataMember = "strState";
            this.lab_state.DisplayMember = "strState";
            this.lab_state.ForeColor = System.Drawing.Color.Gainsboro;
            this.lab_state.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lab_state.Location = new System.Drawing.Point(219, 5);
            this.lab_state.Name = "lab_state";
            this.lab_state.Size = new System.Drawing.Size(82, 26);
            this.lab_state.Text = "label2";
            // 
            // imageButton1
            // 
            this.imageButton1.DataMember = "Menu_Pecture";
            this.imageButton1.DisplayMember = "Menu_Pecture";
            this.imageButton1.Location = new System.Drawing.Point(5, 32);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(53, 60);
            // 
            // imageButton2
            // 
            this.imageButton2.DataMember = "Menu_Pecture";
            this.imageButton2.DisplayMember = "Menu_Pecture";
            this.imageButton2.Location = new System.Drawing.Point(68, 32);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.Size = new System.Drawing.Size(53, 60);
            // 
            // lab_Sumnumber
            // 
            this.lab_Sumnumber.DataMember = "Number";
            this.lab_Sumnumber.DisplayMember = "Number";
            this.lab_Sumnumber.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lab_Sumnumber.Location = new System.Drawing.Point(22, 74);
            this.lab_Sumnumber.Name = "lab_Sumnumber";
            this.lab_Sumnumber.Size = new System.Drawing.Size(31, 35);
            this.lab_Sumnumber.Text = "label2";
            // 
            // label2
            // 
            this.label2.DataMember = "Number";
            this.label2.DisplayMember = "Number";
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(87, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 35);
            this.label2.Text = "label2";
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.DarkGray;
            this.line2.Location = new System.Drawing.Point(0, 127);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            // 
            // btn_setOrder
            // 
            this.btn_setOrder.BackColor = System.Drawing.Color.White;
            this.btn_setOrder.Border = new Smobiler.Core.Controls.Border(1F);
            this.btn_setOrder.BorderColor = System.Drawing.Color.Red;
            this.btn_setOrder.BorderRadius = 0;
            this.btn_setOrder.DataMember = "btn1";
            this.btn_setOrder.DisplayMember = "btn1";
            this.btn_setOrder.ForeColor = System.Drawing.Color.Black;
            this.btn_setOrder.Location = new System.Drawing.Point(138, 132);
            this.btn_setOrder.Name = "btn_setOrder";
            this.btn_setOrder.Size = new System.Drawing.Size(77, 30);
            this.btn_setOrder.Text = "button2";
            this.btn_setOrder.Press += new System.EventHandler(this.btn_setOrder_Press);
            // 
            // btn_successOrder
            // 
            this.btn_successOrder.BackColor = System.Drawing.Color.Red;
            this.btn_successOrder.BorderRadius = 0;
            this.btn_successOrder.DataMember = "btn2";
            this.btn_successOrder.DisplayMember = "btn2";
            this.btn_successOrder.Location = new System.Drawing.Point(219, 132);
            this.btn_successOrder.Name = "btn_successOrder";
            this.btn_successOrder.Size = new System.Drawing.Size(77, 30);
            this.btn_successOrder.Text = "button1";
            this.btn_successOrder.Press += new System.EventHandler(this.btn_successOrder_Press);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(166, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.Text = "共";
            // 
            // lab_sum
            // 
            this.lab_sum.DataMember = "sum";
            this.lab_sum.DisplayMember = "sum";
            this.lab_sum.ForeColor = System.Drawing.Color.Gray;
            this.lab_sum.Location = new System.Drawing.Point(182, 103);
            this.lab_sum.Name = "lab_sum";
            this.lab_sum.Size = new System.Drawing.Size(20, 20);
            this.lab_sum.Text = "label4";
            // 
            // label4
            // 
            this.label4.BorderColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(194, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.Text = "件，合计：";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(250, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.Text = "￥";
            // 
            // lab_money
            // 
            this.lab_money.DataMember = "money";
            this.lab_money.DisplayMember = "money";
            this.lab_money.ForeColor = System.Drawing.Color.Red;
            this.lab_money.Location = new System.Drawing.Point(261, 102);
            this.lab_money.Name = "lab_money";
            this.lab_money.Size = new System.Drawing.Size(20, 20);
            this.lab_money.Text = "label6";
            // 
            // label6
            // 
            this.label6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label6.Location = new System.Drawing.Point(12, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 35);
            this.label6.Text = "×";
            // 
            // label7
            // 
            this.label7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label7.Location = new System.Drawing.Point(76, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 35);
            this.label7.Text = "×";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(179, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // OrderShowListControl
            // 
            this.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 10F);
            this.BorderColor = System.Drawing.Color.Gainsboro;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 172);
            this.Load += new System.EventHandler(this.OrderShowListControl_Load);
            this.Name = "OrderShowListControl";

        }
        #endregion
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label lab_OrderNo;
        private Smobiler.Core.Controls.Label lab_state;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.ImageButton imageButton2;
        private Smobiler.Core.Controls.Label lab_Sumnumber;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Button btn_setOrder;
        private Smobiler.Core.Controls.Button btn_successOrder;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label lab_sum;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label lab_money;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Label label8;
    }
}