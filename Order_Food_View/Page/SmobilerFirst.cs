using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using Order_Food_View.Page;
using Order_Food_View.Page.JFPage;
using Order_Food_View.Page.TS_eat;
using RestSharp;
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
        public SmobilerFirst(Base_UserInfo userInfo)
        {
            InitializeComponent();
            this._userInfo = userInfo;

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
            //调用餐厅信息
            GetRestaurantList();
        }
        /// <summary>
        /// 获取餐厅信息
        /// </summary>
        public void GetRestaurantList()
        {
            //调用HttpClientHelper参数控制器名和方法名
            string RestaurantList = httpClient.Get("/Integral/GetRestaurantList");
            //获取列表数据
            Data model = JsonConvert.DeserializeObject<Data>(RestaurantList);
            string itemJson = JsonConvert.SerializeObject(model.Result);
            List<Base_Dining_Room> list;
            list = JsonConvert.DeserializeObject<List<Base_Dining_Room>>(itemJson);
            foreach (var item in list)
            {
                this.Address.Text = item.Dining_Address;
                this.Phone.Text = item.Order_Number;
                this.Dobusiness_Time.Text = item.Businss_Time;
                if(DateTime.Now < Convert.ToDateTime("7:00") || DateTime.Now > Convert.ToDateTime("23:00"))
                {
                    this.State.Text = "休息中";
                }
                else
                {
                    this.State.Text = "营业中";
                }
            }
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
            TS_EatFormList tS_In_Food = new TS_EatFormList(_userInfo);
            Show(tS_In_Food);
        }
        /// <summary>
        /// 积分商城
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void jifen_Press(object sender, EventArgs e)
        {
            JFMallForm jFMall = new JFMallForm();
            Show(jFMall);
        }
    }
}