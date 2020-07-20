using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using Order_Food_View.Page;
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
                    this.Show(my);
                    break;
                case "Order":
                    OrderListForm orderForm = new OrderListForm();
                    Show(orderForm);
                    break;
                case "Home":
                    SmobilerFirst first = new SmobilerFirst();
                    this.Show(first);
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

        }
    }
}