using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Order_Food_Model;
using Order_Food_View.HelperClass;
using Order_Food_View.Page.TS_eat;
using Order_Food_View.UserControl;
using Order_Food_View.ViewModel;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page
{

    partial class OrderForm : Smobiler.Core.Controls.MobileForm
    {
        HttpClientHelper helper = new HttpClientHelper("http://192.168.43.51:8081");
        //支付是否成功状态
        private string successStateText = "";
        public OrderForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        public OrderForm(UserBuyIdModel _model)
        {
            InitializeComponent();
            this.model = _model;
        }
        private UserBuyIdModel model { get; set; }
        private void barcodeScannerButton1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {

        }

        private void barcodeScannerButton1_Press(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            string jsonHttp = helper.Get("/Integral/GetUserModel?UserId=" + model.UserId);
            Data data = JsonConvert.DeserializeObject<Data>(jsonHttp);
            string json = JsonConvert.SerializeObject(data.Result);
            Base_UserInfo base_Users = JsonConvert.DeserializeObject<Base_UserInfo>(json);

            lab_tab.Text = base_Users.User_Money.ToString();
            CouPonList();
        }

        public void CouPonList()
        {
            decimal money = 0;
            //得到所有购物车的数据 再绑到listview 
            string jsonHttp = helper.Post("/Menu/GetCars", null);
            Data data = JsonConvert.DeserializeObject<Data>(jsonHttp);
            string json = JsonConvert.SerializeObject(data.Result);
            List<ShowCarModel> showCars = JsonConvert.DeserializeObject<List<ShowCarModel>>(json);
            //桌
            lab_desk.Text = "桌";
            //件 
            int count = showCars.Count;
            foreach (var item in showCars)
            {
                money += item.Price * item.Number;
            }
            //合计
            lab_num.Text = money.ToString();
            if (showCars.Count > 0)
            {
                order_listview.DataSource = showCars;
                order_listview.DataBind();
            }
            else
            {
                TS_EatFormList tS_Eat = new TS_EatFormList();
                Show(tS_Eat);
            }
        }
        /// <summary>
        /// 弹出优惠券窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CouPon_Press(object sender, EventArgs e)
        {
            CouPonClick();
        }
        //查看可用优惠券
        private void CouPonClick()
        {
            DialogOptions footerDialogOptions;
            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Smobiler.Core.Controls.Padding.Empty, true);
            ShowDialog(new CouPonControl(), footerDialogOptions);
        }
        //查看可用优惠券
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
            if (qb.Checked==true)
            {
                //得到所有购物车的数据 再绑到listview  
                string jsonHttp = helper.Post("/Menu/GetCars", null);
                Data data = JsonConvert.DeserializeObject<Data>(jsonHttp);
                string json = JsonConvert.SerializeObject(data.Result);
                List<ShowCarModel> showCars = JsonConvert.DeserializeObject<List<ShowCarModel>>(json);
                //Data Orderdata = JsonConvert.DeserializeObject<Data>(OrderHttp);
                //string jsonOrder = JsonConvert.SerializeObject(data.Result); 
                Base_Order order = new Base_Order
                {
                    PayDateTime = DateTime.Parse(DateTime.Now.ToString("yyyyMMddHHssmm")),
                    Order_State = 1,
                    Price = decimal.Parse(lab_num.Text),
                    User_Id = model.UserId,
                };
                //保存订单
                string Orderjson = JsonConvert.SerializeObject(order);
                string OrderHttp = helper.Post("/Menu/CreateOrder", Orderjson);
                Data Orderdata = JsonConvert.DeserializeObject<Data>(OrderHttp);
                if (Orderdata.Code == 1)
                {
                    successStateText = "支付成功";
                    SuccessOrder success = new SuccessOrder(successStateText, decimal.Parse(lab_num.Text));
                    Show(success);
                }
                else
                {
                    successStateText = "支付失败";
                    SuccessOrder success = new SuccessOrder(successStateText, decimal.Parse(lab_num.Text));
                    Show(success);
                }
            }
            else
            {
                MessageBox.Show("请选择支付方式");
                return;
            }
           
        }

        //返回继续点餐
        private void imageButton1_Press(object sender, EventArgs e)
        {
            TS_EatFormList tS_In_Food = new TS_EatFormList();
            Show(tS_In_Food);
        }

        private void listView1_RowBind(object sender, ListViewTemplateBindEventArgs e)
        {
            object tempent = e.Data;
            string tableNo = tempent.Equals(lab_table).ToString();
            decimal money = decimal.Parse(tempent.Equals(lab_Lossmoney).ToString());

            MessageBox.Show(tableNo);

        }
    }
}