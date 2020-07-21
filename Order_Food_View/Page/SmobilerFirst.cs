using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using Order_Food_View.Page;
using Order_Food_View.Page.TS_eat;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View
{
    partial class SmobilerFirst : Smobiler.Core.Controls.MobileForm
    {
        public SmobilerFirst() : base()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 轮播图实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmobilerFirst_Load(object sender, EventArgs e)
        {
            this.pageView1.AutoPlay = true;
            this.pageView1.IsLoop = true;
            pageView1.TemplateControl = new SmobilerFirstControl();
            DataTable pageTable = new DataTable();
            pageTable.Columns.Add("Picture");
            pageTable.Rows.Add("u102.png");
            pageTable.Rows.Add("u103.png");
            pageTable.Rows.Add("u106.png");
            pageTable.Rows.Add("u107.png");
            pageView1.DataSource = pageTable;
            pageView1.DataBind();
        }
        /// <summary>
        /// 外卖点餐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageButton1_Press(object sender, EventArgs e)
        {
            take_out_foodForm take_Out_Food = new take_out_foodForm();
            Show(take_Out_Food);
        }
        /// <summary>
        /// ToolBar点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            switch (e.Name)
            {
                case "My":
                    SmobilerMyForm my = new SmobilerMyForm();
                    this.Form.Show(my, (obj, arage) => { this.Close(); });
                    // this.Show(my);
                    break;
                case "Order":
                    OrderListForm orderForm1 = new OrderListForm();
                    this.Form.Show(orderForm1, (obj, arage) => { this.Close(); });
                    //Show(orderForm1);
                    break;
                case "Home":
                    SmobilerFirst first = new SmobilerFirst();
                    this.Form.Show(first, (obj, arage) => { this.Close(); });
                    //this.Show(first);
                    break;
            }
        }
        /// <summary>
        /// 跳转到餐厅信息页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void canting_Press(object sender, EventArgs e)
        {
            RestaurantInformation restaurantInformation = new RestaurantInformation();
            Show(restaurantInformation);
        }
        /// <summary>
        /// 到食堂点餐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShiTang_Press(object sender, EventArgs e)
        {
            TS_In_FoodForm tS_In_Food = new TS_In_FoodForm();
            Show(tS_In_Food);
        }
    }
}