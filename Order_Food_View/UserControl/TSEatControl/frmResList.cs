﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Order_Food_View.HelperClass;
using Order_Food_View.ViewModel;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    //public delegate void MyFood();
    public delegate void MyFoof(DataTable table);
    partial class frmResList : Smobiler.Core.Controls.MobileUserControl
    {
        //public MyFood FoodType;
        public frmResList() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        //添加
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
                take_out_foodForm form = new take_out_foodForm();
                Button btn = (Button)form.Controls.Find("btn_order");
                btn.Text = "去支付";
                form.FoodType += LoadFood;
            }
        }
        //减少
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
                take_out_foodForm form = new take_out_foodForm();
                form.Controls.Find("btn_order");
            }
        }
        //值改变
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
        public void LoadFood()
        {
            take_out_foodForm form = new take_out_foodForm();
            Button btn = (Button)form.Controls.Find("btn_order");
            btn.Text = "去结算";
            btn.Enabled = true;
        }

        private void frmResList_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Press(object sender, EventArgs e)
        {
            UserBuyIdModel add = new UserBuyIdModel();
            add.menuId = int.Parse(label1.Text);
            add.count = int.Parse(textBox1.Text);
            //加入购物车
            HttpClientHelper http = new HttpClientHelper("http://192.168.43.51:8081/Menu/AddCar");
            string s = http.Post("http://192.168.43.51:8081/Menu/AddCar", JsonConvert.SerializeObject(add));
        }
    }
}