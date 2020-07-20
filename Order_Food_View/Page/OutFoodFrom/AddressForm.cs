using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.OutFoodFrom
{
    partial class AddressForm : Smobiler.Core.Controls.MobileForm
    {
        public AddressForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        //页面初始化显示地址数据
        private void AddressForm_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("name",typeof(string));
            tb.Columns.Add("phone", typeof(string));
            tb.Columns.Add("xiang",typeof(string));
            tb.Rows.Add("张三", "13195969632", "上海市奉贤区海湾镇五四公路3389号");
           
            if (tb.Rows.Count>0)
            {
                listView1.DataSource = tb;
                listView1.DataBind();
            }
        }

        private void imageButton1_Press(object sender, EventArgs e)
        {
            take_out_foodForm from = new take_out_foodForm();
            Show(from);
        }
    }
}