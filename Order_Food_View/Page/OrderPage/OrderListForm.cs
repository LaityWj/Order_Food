using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Order_Food_Model;
using Order_Food_View.HelperClass;
using Order_Food_View.UserControl;
using Order_Food_View.ViewModel;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page
{
    partial class OrderListForm : Smobiler.Core.Controls.MobileForm
    {
        HttpClientHelper helper = new HttpClientHelper("http://192.168.43.51:8081");
        private Base_UserInfo _userInfo;
        private int state { get; set; }
        public OrderListForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        //List<OrderViewModel> orders = new List<OrderViewModel>()
        //{
        //   new OrderViewModel{  order_Id=1, Order_No="FF202008040858", strState="待付款", Menu_Name="酱香排骨", Menu_Pecture="menu3", Number=1, Menu_Price=25 },
        //    new OrderViewModel{  order_Id=1, Order_No="FF202008040855", strState="待付款", Food_Name="炒年糕", Menu_Pecture="cy1", Number=1, Menu_Price=25 },
        //};
        public OrderListForm(Base_UserInfo userInfo)
        {
            this._userInfo = userInfo;
            InitializeComponent();
        }
        private void OrderListForm_Load(object sender, EventArgs e)
        {
            tab_orderlist.ScrollEnabled = true;
            tab_orderlist.PageIndex = 0;
            //食堂的订单列表
            TsStateOrderList();
            //外卖的订单/2 3 7 8
            WmStateOrderList();
            //state = 3;
            //OrderState state1 = new OrderState()
            //{
            //    Order_State = state,
            //    order_Id = 15
            //};

            //string json = helper.Post("/Order/GetOrders", JsonConvert.SerializeObject(state1));
            //Data data = JsonConvert.DeserializeObject<Data>(json);
            //string orderData = JsonConvert.SerializeObject(data.Result);
            //List<OrderViewModel> orders = JsonConvert.DeserializeObject<List<OrderViewModel>>(orderData); 
            DataTable table = new DataTable();
            table.Columns.Add("Order_No", typeof(System.String));
            table.Columns.Add("strState", typeof(System.String));
            table.Columns.Add("Menu_Name", typeof(System.String));
            table.Columns.Add("Menu_Pecture", typeof(System.String));
            table.Columns.Add("Number", typeof(System.Int32));
            table.Columns.Add("Menu_Price", typeof(System.Decimal));
            table.Columns.Add("sum", typeof(System.Int32));
            table.Columns.Add("money", typeof(System.Decimal));
            table.Columns.Add("btn1", typeof(System.String));
            table.Columns.Add("btn2", typeof(System.String));

            table.Rows.Add("FF202008040858", "待付款", "酱香排骨", "menu3", 1, 25, 2, 50, "取消订单", "立即付款");
            table.Rows.Add("FF202008040855", "待付款", "炒年糕", "cy1", 1, 25, 2, 50, "取消订单", "立即付款");
            table.Rows.Add("FF202008040853", "已完成", "酱香排骨", "menu3", 1, 25, 2, 50, "删除订单", "再次购买");
            table.Rows.Add("FF202008040853", "已完成", "酱香排骨", "menu3", 1, 25, 2, 50, "删除订单", "再次购买");
            table.Rows.Add("FF202008040853", "已完成", "酱香排骨", "menu3", 1, 25, 2, 50, "删除订单", "再次购买");
            table.Rows.Add("FF202008040851", "待收货", "炒年糕", "cy1", 1, 25, 2, 50, "", "确认收货");

            if (table.Rows.Count > 0)
            {
                listView1.DataSource = table;
                listView1.DataBind();
                listView5.DataSource = table;
                listView5.DataBind();
                listView4.DataSource = table;
                listView4.DataBind();
            }
            //rderShowListControl orderShowList = new OrderShowListControl(orders);

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
                    OrderListForm orderForm1 = new OrderListForm(_userInfo);
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
            TabPage page = sender as TabPage;
            MessageBox.Show(page.Text);
            foreach (var item in tab_orderlist.Titles)
            {
                if (tab_orderlist.Titles[0] == "堂食订单")
                {
                    OrderShowListControl orderShowList = new OrderShowListControl(page.Text);
                    //食堂的订单列表
                    TsStateOrderList();
                }
                else
                {

                    //外卖的订单/2 3 7 8
                    WmStateOrderList();
                }
            }

        }
        public void TsStateOrderList()
        {
            foreach (var item in tabPageView1.Titles)
            {
                if (item.Length == 1)
                {
                    state = item.Length;
                    OrderState state1 = new OrderState()
                    {
                        Order_State = state
                    };
                    string json = helper.Post("/Order/GetOrders", JsonConvert.SerializeObject(state1));
                    Data data = JsonConvert.DeserializeObject<Data>(json);
                    string orderData = JsonConvert.SerializeObject(data.Result);
                    List<OrderViewModel> orders = JsonConvert.DeserializeObject<List<OrderViewModel>>(orderData);
                    if (orders.Count > 0)
                    {
                        listView1.DataSource = orders;
                        listView1.DataBind();
                    }
                    OrderShowListControl orderShowList = new OrderShowListControl(orders);
                }
                else if (item.Length == 2)
                {
                    state = item.Length;
                    OrderState state1 = new OrderState()
                    {
                        Order_State = state
                    };

                    string stringJson1 = helper.Post("/Order/GetOrders", JsonConvert.SerializeObject(state1));
                    Data data1 = JsonConvert.DeserializeObject<Data>(stringJson1);
                    string json1 = JsonConvert.SerializeObject(data1.Result);
                    List<OrderViewModel> orders = JsonConvert.DeserializeObject<List<OrderViewModel>>(json1);
                    if (orders.Count > 0)
                    {
                        //listView1.DataSource = orders;
                        //listView1.DataBind();
                        listView4.DataSource = orders;
                        listView4.DataBind();
                    }
                }
                else if (item.Length == 3)
                {
                    state = item.Length;
                    OrderState state1 = new OrderState()
                    {
                        Order_State = state
                    };
                    string json = helper.Post("/Order/GetOrders", JsonConvert.SerializeObject(state1));
                    Data data = JsonConvert.DeserializeObject<Data>(json);
                    string orderData = JsonConvert.SerializeObject(data.Result);
                    List<OrderViewModel> orders = JsonConvert.DeserializeObject<List<OrderViewModel>>(orderData);
                    if (orders.Count > 0)
                    {
                        listView5.DataSource = orders;
                        listView5.DataBind();
                    }
                }
                else
                {
                    state = item.Length;
                    OrderState state1 = new OrderState()
                    {
                        Order_State = state
                    };
                    string json = helper.Post("/Order/GetOrders", JsonConvert.SerializeObject(state1));
                    Data data = JsonConvert.DeserializeObject<Data>(json);
                    string orderData = JsonConvert.SerializeObject(data.Result);
                    List<OrderViewModel> orders = JsonConvert.DeserializeObject<List<OrderViewModel>>(orderData);
                    if (orders.Count > 0)
                    {
                        listView6.DataSource = orders;
                        listView6.DataBind();
                    }
                }
            }
        }
        public void WmStateOrderList()
        {
            foreach (var item in tabPageView2.Titles)
            {
                if (item.Length == 1)
                {
                    state = item.Length;
                    OrderState state1 = new OrderState()
                    {
                        Order_State = state
                    };
                    string json = helper.Post("/Order/GetOrders", JsonConvert.SerializeObject(state1));
                    Data data = JsonConvert.DeserializeObject<Data>(json);
                    string orderData = JsonConvert.SerializeObject(data.Result);
                    List<OrderViewModel> orders = JsonConvert.DeserializeObject<List<OrderViewModel>>(orderData);
                    if (orders.Count > 0)
                    {
                        listView2.DataSource = orders;
                        listView2.DataBind();
                    }
                }
                else if (item.Length == 2)
                {
                    state = item.Length;
                    OrderState state1 = new OrderState()
                    {
                        Order_State = state
                    };
                    string json = helper.Post("/Order/GetOrders", JsonConvert.SerializeObject(state1));
                    Data data = JsonConvert.DeserializeObject<Data>(json);
                    string orderData = JsonConvert.SerializeObject(data.Result);
                    List<OrderViewModel> orders = JsonConvert.DeserializeObject<List<OrderViewModel>>(orderData);
                    if (orders.Count > 0)
                    {
                        listView3.DataSource = orders;
                        listView3.DataBind();
                    }
                }
                else if (item.Length == 3)
                {
                    state = item.Length;
                    OrderState state1 = new OrderState()
                    {
                        Order_State = state
                    };
                    string json = helper.Post("/Order/GetOrders", JsonConvert.SerializeObject(state1));
                    Data data = JsonConvert.DeserializeObject<Data>(json);
                    string orderData = JsonConvert.SerializeObject(data.Result);
                    List<OrderViewModel> orders = JsonConvert.DeserializeObject<List<OrderViewModel>>(orderData);
                    if (orders.Count > 0)
                    {
                        listView7.DataSource = orders;
                        listView7.DataBind();
                    }
                }
                else
                {
                    state = item.Length;
                    OrderState state1 = new OrderState()
                    {
                        Order_State = state
                    };
                    string json = helper.Post("/Order/GetOrders", JsonConvert.SerializeObject(state1));
                    Data data = JsonConvert.DeserializeObject<Data>(json);
                    string orderData = JsonConvert.SerializeObject(data.Result);
                    List<OrderViewModel> orders = JsonConvert.DeserializeObject<List<OrderViewModel>>(orderData);
                    if (orders.Count > 0)
                    {
                        listView8.DataSource = orders;
                        listView8.DataBind();
                    }
                }
            }
        }

    }
}