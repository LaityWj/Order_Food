using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Order_Food_View.HelperClass;
using Order_Food_View.ViewModel;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.UserControl
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class OrderShowListControl : Smobiler.Core.Controls.MobileUserControl
    {
        HttpClientHelper helper = new HttpClientHelper("http://192.168.43.51:8081");
        public OrderShowListControl() : base()
        {

            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public OrderShowListControl(List<OrderViewModel> orderViews)
        {
            this.orders = orderViews;
            InitializeComponent();
        }
        public OrderShowListControl(string _page/*TabPageView _titles*/)
        {
            //this.Titles = _titles;
            this.page = _page;
            InitializeComponent();
        }
        private string page { get; set; }
        private TabPageView Titles { get; set; }
        private List<OrderViewModel> orders { get; set; }
        //初始化加载
        private void OrderShowListControl_Load(object sender, EventArgs e)
        {
            int  state = 3;
            OrderState state1 = new OrderState()
            {
                Order_State = state,
                order_Id = 15
            };
            string json = helper.Post("/Order/GetOrders", JsonConvert.SerializeObject(state1));
            Data data = JsonConvert.DeserializeObject<Data>(json);
            string orderData = JsonConvert.SerializeObject(data.Result);
            List<OrderViewModel> orders = JsonConvert.DeserializeObject<List<OrderViewModel>>(json);

            List<OrderViewModel> list = orders;
            //DataTable table = HelperClass.GetListToDataTable.ListToDataTable(list);
            //table.Columns.Add("Order_No", typeof(System.String));
            //table.Columns.Add("strState", typeof(System.String));
            //table.Columns.Add("Menu_Pecture", typeof(System.String));
            //table.Columns.Add("Number", typeof(System.Int32));
            //table.Columns.Add("sum", typeof(System.Int32));
            //table.Columns.Add("money", typeof(System.Decimal));
            if (page == "堂食订单")
            {
                foreach (var item in list)
                {
                    if (item.Order_State == 1)
                    {
                        item.strState = lab_state.Text = "全部";
                        // table.Rows.Add(item.Order_No, item.strState, item.Menu_Pecture, item.Number, item.Number + item.Number, item.Number * item.Price + item.Number * item.Price);
                    }
                    else if (item.Order_State == 2)
                    {
                        item.strState = lab_state.Text = "待付款";
                        // table.Rows.Add(item.Order_No, item.strState, item.Menu_Pecture, item.Number, item.Number + item.Number, item.Number * item.Price + item.Number * item.Price);
                    }
                    else if (item.Order_State == 3)
                    {
                        item.strState = lab_state.Text = "已完成";
                        //table.Rows.Add(item.Order_No, item.strState, item.Menu_Pecture, item.Number, item.Number + item.Number, item.Number * item.Price + item.Number * item.Price);
                    }
                    else
                    {
                        item.strState = lab_state.Text = "已取消";
                        //table.Rows.Add(item.Order_No, item.strState, item.Menu_Pecture, item.Number, item.Number + item.Number, item.Number * item.Price + item.Number * item.Price);
                    }

                }
            }
            else
            {
                foreach (var item in list)
                {
                    if (item.Order_State == 1)
                    {
                        item.strState = lab_state.Text = "全部";
                        //table.Rows.Add(item.Order_No, item.strState, item.Menu_Pecture, item.Number, item.Number + item.Number, item.Number * item.Price + item.Number * item.Price);
                    }
                    else if (item.Order_State == 2)
                    {
                        item.strState = lab_state.Text = "待付款";
                        // table.Rows.Add(item.Order_No, item.strState, item.Menu_Pecture, item.Number, item.Number + item.Number, item.Number * item.Price + item.Number * item.Price);
                    }
                    else if (item.Order_State == 3)
                    {
                        item.strState = lab_state.Text = "已完成";
                        // table.Rows.Add(item.Order_No, item.strState, item.Menu_Pecture, item.Number, item.Number + item.Number, item.Number * item.Price + item.Number * item.Price);
                    }
                    else
                    {
                        item.strState = lab_state.Text = "代收取";
                        // table.Rows.Add(item.Order_No, item.strState, item.Menu_Pecture, item.Number, item.Number + item.Number, item.Number * item.Price + item.Number * item.Price);
                    }

                }
            }

            if (lab_state.Text == "待付款")
            {
                btn_setOrder.Text = "取消订单";

                btn_successOrder.Text = "立即付款";
            }
            else if (lab_state.Text == "已完成")
            {
                btn_setOrder.Text = "删除订单";
                btn_successOrder.Text = "再次购买";
            }
            else if (lab_state.Text == "待收取")
            {
                btn_setOrder.Visible = false;
                btn_successOrder.Text = "确认收货";
            }
            else if (lab_state.Text == "已取消")
            {
                btn_setOrder.Text = "删除订单";
                btn_successOrder.Text = "再次购买";
            }
            else
            {
                btn_setOrder.Text = "删除订单";
                btn_successOrder.Text = "再次购买";
            }
        }

        private void btn_setOrder_Press(object sender, EventArgs e)
        {
            //堂食
            if (lab_state.Text == "待付款")
            {
                btn_setOrder.Text = "取消订单";
                OrderViewModel model = new OrderViewModel();
                model.OrderId = int.Parse(label8.Text);
                if (btn_setOrder.Text == "取消订单")
                {
                    string json = helper.Post("Order/ResetOrder", model.ToString());
                    Data data = JsonConvert.DeserializeObject<Data>(json);
                    if (JsonConvert.SerializeObject(data.Result) == "1")
                    {


                    }
                }
                else
                {
                    btn_successOrder.Text = "立即付款";
                    helper.Post("Order/ResetOrder", model.ToString());
                }
            }
            else if (lab_state.Text == "已完成")
            {
                btn_setOrder.Text = "删除订单";
                btn_successOrder.Text = "再次购买";
            }
            else if (lab_state.Text == "待收取")
            {
                btn_setOrder.Visible = false;
                btn_successOrder.Text = "确认收货";
            }
            else if (lab_state.Text == "已取消")
            {
                btn_setOrder.Text = "删除订单";
                btn_successOrder.Text = "再次购买";
            }
            else
            {
                btn_setOrder.Text = "删除订单";
                btn_successOrder.Text = "再次购买";
            }
        }

        private void btn_successOrder_Press(object sender, EventArgs e)
        {
            //堂食
            if (lab_state.Text == "待付款")
            {
                btn_setOrder.Text = "取消订单";

                btn_successOrder.Text = "立即付款";
            }
            else if (lab_state.Text == "已完成")
            {
                btn_setOrder.Text = "删除订单";
                btn_successOrder.Text = "再次购买";
            }
            else if (lab_state.Text == "待收取")
            {
                btn_setOrder.Visible = false;
                btn_successOrder.Text = "确认收货";
            }
            else if (lab_state.Text == "已取消")
            {
                btn_setOrder.Text = "删除订单";
                btn_successOrder.Text = "再次购买";
            }
            else
            {
                btn_setOrder.Text = "删除订单";
                btn_successOrder.Text = "再次购买";
            }
        }
    }
}