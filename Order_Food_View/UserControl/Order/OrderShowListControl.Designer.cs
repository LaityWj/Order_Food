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
            this.lab_Sumnumber = new Smobiler.Core.Controls.Label();
            this.imageButton2 = new Smobiler.Core.Controls.ImageButton();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.panel6 = new Smobiler.Core.Controls.Panel();
            this.lab_number = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.lab_num = new Smobiler.Core.Controls.Label();
            this.btn_successOrder = new Smobiler.Core.Controls.Button();
            this.btn_setOrder = new Smobiler.Core.Controls.Button();
            this.line2 = new Smobiler.Core.Controls.Line();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.lab_OrderNo,
            this.lab_state,
            this.imageButton1,
            this.lab_Sumnumber,
            this.imageButton2,
            this.label2,
            this.panel6,
            this.btn_successOrder,
            this.btn_setOrder,
            this.line2});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 217);
            // 
            // label1
            // 
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 35);
            this.label1.Text = "订单编号:";
            // 
            // lab_OrderNo
            // 
            this.lab_OrderNo.DataMember = "No";
            this.lab_OrderNo.DisplayMember = "No";
            this.lab_OrderNo.Location = new System.Drawing.Point(70, 2);
            this.lab_OrderNo.Name = "lab_OrderNo";
            this.lab_OrderNo.Size = new System.Drawing.Size(100, 35);
            this.lab_OrderNo.Text = "label2";
            // 
            // lab_state
            // 
            this.lab_state.DataMember = "state";
            this.lab_state.DisplayMember = "state";
            this.lab_state.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lab_state.Location = new System.Drawing.Point(170, 2);
            this.lab_state.Name = "lab_state";
            this.lab_state.Size = new System.Drawing.Size(130, 35);
            this.lab_state.Text = "label2";
            // 
            // imageButton1
            // 
            this.imageButton1.DataMember = "eatImg1";
            this.imageButton1.DisplayMember = "eatImg1";
            this.imageButton1.Location = new System.Drawing.Point(11, 40);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(70, 72);
            // 
            // lab_Sumnumber
            // 
            this.lab_Sumnumber.DataMember = "number1";
            this.lab_Sumnumber.DisplayMember = "number1";
            this.lab_Sumnumber.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lab_Sumnumber.Location = new System.Drawing.Point(11, 112);
            this.lab_Sumnumber.Name = "lab_Sumnumber";
            this.lab_Sumnumber.Size = new System.Drawing.Size(70, 35);
            this.lab_Sumnumber.Text = "label2";
            // 
            // imageButton2
            // 
            this.imageButton2.DataMember = "eatImg2";
            this.imageButton2.DisplayMember = "eatImg2";
            this.imageButton2.Location = new System.Drawing.Point(86, 41);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.Size = new System.Drawing.Size(70, 72);
            // 
            // label2
            // 
            this.label2.DataMember = "number2";
            this.label2.DisplayMember = "number2";
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(86, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 35);
            this.label2.Text = "label2";
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lab_number,
            this.label3,
            this.label4,
            this.lab_num});
            this.panel6.Location = new System.Drawing.Point(0, 148);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(294, 25);
            // 
            // lab_number
            // 
            this.lab_number.DataMember = "sum";
            this.lab_number.DisplayMember = "sum";
            this.lab_number.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lab_number.Location = new System.Drawing.Point(147, 3);
            this.lab_number.Name = "lab_number";
            this.lab_number.Size = new System.Drawing.Size(22, 22);
            this.lab_number.Text = "label7";
            // 
            // label3
            // 
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label3.Location = new System.Drawing.Point(125, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 22);
            this.label3.Text = "共";
            // 
            // label4
            // 
            this.label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label4.Location = new System.Drawing.Point(152, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.Text = "件，合计:￥";
            // 
            // lab_num
            // 
            this.lab_num.DataMember = "money";
            this.lab_num.DisplayMember = "money";
            this.lab_num.Location = new System.Drawing.Point(245, 3);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(56, 22);
            this.lab_num.Text = "label7";
            // 
            // btn_successOrder
            // 
            this.btn_successOrder.BackColor = System.Drawing.Color.Red;
            this.btn_successOrder.DataMember = "button2";
            this.btn_successOrder.DisplayMember = "button2";
            this.btn_successOrder.Location = new System.Drawing.Point(215, 184);
            this.btn_successOrder.Name = "btn_successOrder";
            this.btn_successOrder.Size = new System.Drawing.Size(77, 30);
            this.btn_successOrder.Text = "button1";
            // 
            // btn_setOrder
            // 
            this.btn_setOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_setOrder.BorderColor = System.Drawing.Color.White;
            this.btn_setOrder.DataMember = "button1";
            this.btn_setOrder.DisplayMember = "button1";
            this.btn_setOrder.ForeColor = System.Drawing.Color.Black;
            this.btn_setOrder.Location = new System.Drawing.Point(130, 184);
            this.btn_setOrder.Name = "btn_setOrder";
            this.btn_setOrder.Size = new System.Drawing.Size(77, 30);
            this.btn_setOrder.Text = "button2";
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.DarkGray;
            this.line2.Location = new System.Drawing.Point(0, 176);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            // 
            // OrderShowListControl
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 221);
            this.Load += new System.EventHandler(this.OrderShowListControl_Load);
            this.Name = "OrderShowListControl";

        }
        #endregion
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label lab_OrderNo;
        private Smobiler.Core.Controls.Label lab_state;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.Label lab_Sumnumber;
        private Smobiler.Core.Controls.ImageButton imageButton2;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Panel panel6;
        private Smobiler.Core.Controls.Label lab_number;
        private Smobiler.Core.Controls.Button btn_successOrder;
        private Smobiler.Core.Controls.Button btn_setOrder;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label lab_num;
    }
}