using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Order_Food_View.Page.TS_eat;
using Order_Food_View.UserControl;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page
{
    partial class OrderForm : Smobiler.Core.Controls.MobileForm
    {
        public OrderForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void barcodeScannerButton1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {

        }

        private void barcodeScannerButton1_Press(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            lab_desk.Text = "桌";
            CouPonList();
            int s = 3;
            decimal n = 39;
            lab_number.Text = $"共{s}件，";
            lab_num.Text = $"小计" + $"￥{n}";

        }

        public void CouPonList()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("id", typeof(System.Int32));
            tb.Columns.Add("Pricture", typeof(System.String));
            tb.Columns.Add("conPonName", typeof(System.String));
            tb.Columns.Add("price", typeof(System.Decimal));
            tb.Columns.Add("number", typeof(System.Int32));
            for (int i = 1; i <= 10; i++)
            {
                tb.Rows.Add(i+1, "2.png", "酸辣土豆丝", 30, 4000);
            } 
            listView1.Rows.Clear();
            if (tb.Rows.Count > 0)
            {
                listView1.DataSource = tb;
                listView1.DataBind();
            }


        }

        private void btn_CouPon_Press(object sender, EventArgs e)
        {
            MessageBox.Show("Hello word");
            CouPonClick();
        }
        //查看可用优惠券
        private void CouPonClick()
        {
            DialogOptions footerDialogOptions;
            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Smobiler.Core.Controls.Padding.Empty, true);
            ShowDialog(new CouPonControl(), footerDialogOptions);
        }
        //查看可用优惠券
        private void textBox1_SubmitEditing(object sender, EventArgs e)
        {
            CouPonClick();
        }
        /// <summary>
        /// //去支付
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Pay_Press(object sender, EventArgs e)
        { 
            SuccessOrder success = new SuccessOrder();
            Show(success);
        }
        //返回继续点餐
        private void imageButton1_Press(object sender, EventArgs e)
        {
            TS_In_FoodForm tS_In_Food = new TS_In_FoodForm();
            Show(tS_In_Food);
        }
    }
}