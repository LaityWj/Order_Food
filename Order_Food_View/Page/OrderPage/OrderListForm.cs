using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page
{
    partial class OrderListForm : Smobiler.Core.Controls.MobileForm
    {

        public OrderListForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {

            tab_orderlist.ScrollEnabled = true;
            tab_orderlist.PageIndex = 0;
            ////食堂的订单列表
            //OrderList();


            ////外卖的订单列表


        }
        public void OrderList()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("No", typeof(System.String));
            tb.Columns.Add("state", typeof(System.String));
            tb.Columns.Add("eatImg1", typeof(System.String));
            tb.Columns.Add("eatImg2", typeof(System.String));
            tb.Columns.Add("number1", typeof(System.Int32));
            tb.Columns.Add("number2", typeof(System.Int32));
            tb.Columns.Add("sum", typeof(System.Int32));
            tb.Columns.Add("money", typeof(System.Decimal));
            tb.Columns.Add("button1", typeof(System.String));
            tb.Columns.Add("button2", typeof(System.String));
            for (int i = 0; i < 5; i++)
            {

            }
            tb.Rows.Add("FF20200303", "待付款", "cy2.png", "cy1.png", 1, 2, 3, 85, "取消订单", "立即付款");
            tb.Rows.Add("FF20200303", "待收取", "cy2.png", "cy2.png", 1, 2, 3, 85, null, "确认收货");
            tb.Rows.Add("FF20200303", "已完成", "cy2.png", "cy2.png", 1, 2, 3, 85, "删除订单", "再次购买");
            tb.Rows.Add("FF20200303", "已取消", "cy2.png", "cy2.png", 1, 2, 3, 85, "删除订单", "再次购买");

            if (tb.Rows.Count > 0)
            {
                listView1.DataSource = tb;
                listView1.DataBind();
            }
            Session["User_Name"] = "张三";

        }

        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            switch (e.Name)
            {
                case "My":
                    SmobilerMyForm my = new SmobilerMyForm();
                    this.Show(my);
                    break;
                case "Order":
                    OrderListForm listForm = new OrderListForm();
                    Show(listForm);
                    break;
                case "Home":
                    SmobilerFirst first = new SmobilerFirst();
                    this.Show(first);
                    break;
            }
        }

        private void toolBar1_ToolbarItemClick_1(object sender, ToolbarClickEventArgs e)
        {
            switch (e.Name)
            {
                case "My":
                    SmobilerMyForm my = new SmobilerMyForm();
                    this.Show(my, (obj, arage) => { this.Close(); });
                    //this.Show(my);
                    break;
                case "Order":
                    OrderListForm orderForm1 = new OrderListForm();
                    this.Show(orderForm1, (obj, arage) => { this.Close(); });
                    //Show(orderForm1);
                    break;
                case "Home":
                    SmobilerFirst first = new SmobilerFirst();
                    this.Show(first, (obj, arage) => { this.Close(); });
                    //this.Show(first);
                    break;
            }
        }
        /// <summary>
        /// 根据索引显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab_orderlist_PageIndexChanged(object sender, EventArgs e)
        {

            if (tab_orderlist.PageIndex == 0)
            {
                //食堂的订单列表
                OrderList();
            }
            else
            {
                //外卖的订单列表
                OrderList();
            }
        }
    }
}