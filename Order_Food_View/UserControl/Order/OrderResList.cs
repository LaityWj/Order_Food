using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Order_Food_View.Page.TS_eat;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.UserControl.Order
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class OrderResList : Smobiler.Core.Controls.MobileUserControl
    {
        public OrderResList() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox1.Text.Equals("1"))
            {
                btndes.Enabled = false;
            }
            else
            {
                btndes.Enabled = true;
                textBox1.Text = (int.Parse(textBox1.Text) - 1).ToString();
                TS_EatFormList form = new TS_EatFormList();
                form.Controls.Find("btn_order");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            bool isNumber = System.Text.RegularExpressions.Regex.IsMatch(textBox1.ToString(), "^[1-9]/d*$");
            if (isNumber)
            {
                var num = textBox1.Text; // 是正du整数zhi
            }
            else
            {
                // 不是dao
                textBox1.Text = "1";
            }
        }
        //add
        private void button2_Press(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            else
            {
                btndes.Enabled = true;
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();


                
            }
        }
        public void BtnPay()
        {
            TS_EatFormList form = new TS_EatFormList();
            Button btn = (Button)form.Controls.Find("btn_order");
            btn.Text = "请支付";
            btn.Enabled = true; 
        }

        private void OrderResList_Load(object sender, EventArgs e)
        {
            BtnPay();

        }
    }
}