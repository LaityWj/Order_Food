using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
            tb.Rows.Add(1, "2.png", "酸辣土豆丝", 30, 4000);

            tb.Rows.Add(2, "1.png", "Yes辣条", 20, 4000);

            tb.Rows.Add(3, "2.png", "Yes烧饭", 34, 1400);

            tb.Rows.Add(4, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(5, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(6, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(7, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(8, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(9, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(10, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(11, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(12, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(13, "1.png", "Yes炒饭", 20, 3000);
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
        private void CouPonClick()
        {
            DialogOptions footerDialogOptions;
            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Smobiler.Core.Controls.Padding.Empty, true);
            ShowDialog(new CouPonControl(), footerDialogOptions);
        }
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

        }
    }
}