using System;
using Smobiler.Core;
namespace Order_Food_View.Page
{
    partial class SuccessOrder : Smobiler.Core.Controls.MobileForm
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
            this.lab_Topsuccess = new Smobiler.Core.Controls.Label();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.img_success = new Smobiler.Core.Controls.Image();
            this.lab_jftext = new Smobiler.Core.Controls.Label();
            this.lab_getjf = new Smobiler.Core.Controls.Label();
            this.lab_cuccess = new Smobiler.Core.Controls.Label();
            this.btn_success = new Smobiler.Core.Controls.Button();
            this.btn_orderList = new Smobiler.Core.Controls.Button();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.img_back = new Smobiler.Core.Controls.ImageButton();
            this.img_top = new Smobiler.Core.Controls.ImageButton();
            // 
            // lab_Topsuccess
            // 
            this.lab_Topsuccess.FontSize = 18F;
            this.lab_Topsuccess.Location = new System.Drawing.Point(28, 11);
            this.lab_Topsuccess.Name = "lab_Topsuccess";
            this.lab_Topsuccess.Size = new System.Drawing.Size(119, 22);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderColor = System.Drawing.Color.White;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lab_Topsuccess,
            this.line1,
            this.imageButton1});
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 44);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.DarkGray;
            this.line1.Location = new System.Drawing.Point(0, 44);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.img_success,
            this.lab_jftext,
            this.lab_getjf,
            this.lab_cuccess,
            this.btn_success,
            this.btn_orderList,
            this.img_back,
            this.img_top});
            this.panel1.Horizontal = true;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 456);
            // 
            // img_success
            // 
            this.img_success.Location = new System.Drawing.Point(125, 70);
            this.img_success.Name = "img_success";
            this.img_success.ResourceID = "u913";
            this.img_success.Size = new System.Drawing.Size(50, 50);
            // 
            // lab_jftext
            // 
            this.lab_jftext.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lab_jftext.Location = new System.Drawing.Point(0, 165);
            this.lab_jftext.Name = "lab_jftext";
            this.lab_jftext.Size = new System.Drawing.Size(170, 35);
            this.lab_jftext.Text = "获得积分:";
            // 
            // lab_getjf
            // 
            this.lab_getjf.Location = new System.Drawing.Point(169, 165);
            this.lab_getjf.Name = "lab_getjf";
            this.lab_getjf.Size = new System.Drawing.Size(130, 35);
            this.lab_getjf.Text = "label3";
            // 
            // lab_cuccess
            // 
            this.lab_cuccess.FontSize = 16F;
            this.lab_cuccess.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lab_cuccess.Location = new System.Drawing.Point(0, 123);
            this.lab_cuccess.Name = "lab_cuccess";
            this.lab_cuccess.Size = new System.Drawing.Size(300, 35);
            this.lab_cuccess.Text = "label4";
            // 
            // btn_success
            // 
            this.btn_success.BackColor = System.Drawing.Color.Red;
            this.btn_success.Location = new System.Drawing.Point(26, 228);
            this.btn_success.Name = "btn_success";
            this.btn_success.Size = new System.Drawing.Size(250, 30);
            this.btn_success.Text = "button1";
            this.btn_success.Press += new System.EventHandler(this.btn_success_Press);
            // 
            // btn_orderList
            // 
            this.btn_orderList.BackColor = System.Drawing.Color.Red;
            this.btn_orderList.Location = new System.Drawing.Point(26, 282);
            this.btn_orderList.Name = "btn_orderList";
            this.btn_orderList.Size = new System.Drawing.Size(250, 30);
            this.btn_orderList.Text = "button2";
            this.btn_orderList.Press += new System.EventHandler(this.btn_orderList_Press);
            // 
            // imageButton1
            // 
            this.imageButton1.Location = new System.Drawing.Point(2, 11);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(24, 22);
            this.imageButton1.Text = "＜";
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // img_back
            // 
            this.img_back.Location = new System.Drawing.Point(125, 70);
            this.img_back.Name = "img_back";
            this.img_back.ResourceID = "u938";
            this.img_back.Size = new System.Drawing.Size(50, 50);
            // 
            // img_top
            // 
            this.img_top.Location = new System.Drawing.Point(131, 76);
            this.img_top.Name = "img_top";
            this.img_top.ResourceID = "u939";
            this.img_top.Size = new System.Drawing.Size(38, 38);
            // 
            // SuccessOrder
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2,
            this.panel1});
            this.Load += new System.EventHandler(this.SuccessOrder_Load);
            this.Name = "SuccessOrder";

        }
        #endregion
        private Smobiler.Core.Controls.Label lab_Topsuccess;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image img_success;
        private Smobiler.Core.Controls.Label lab_jftext;
        private Smobiler.Core.Controls.Label lab_getjf;
        private Smobiler.Core.Controls.Label lab_cuccess;
        private Smobiler.Core.Controls.Button btn_success;
        private Smobiler.Core.Controls.Button btn_orderList;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.ImageButton img_back;
        private Smobiler.Core.Controls.ImageButton img_top;
    }
}