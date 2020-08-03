using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using Order_Food_Model;
using Order_Food_View.HelperClass;
using Order_Food_View.Layout;
using Order_Food_View.UserControl.TSEatControl;
using Order_Food_View.ViewModel;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Base_Food_Menus = Order_Food_Model.Base_Food_Menus;

namespace Order_Food_View.Page.TS_eat
{
    partial class TS_EatFormList : Smobiler.Core.Controls.MobileForm
    {
        HttpClientHelper httpClient = new HttpClientHelper("http://192.168.43.51:8081");
        private int h = 1;
        public TS_EatFormList() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        public TS_EatFormList(Base_UserInfo _UserId)
        {
            this.UserId = _UserId;
            InitializeComponent();
        }
        private Base_UserInfo UserId { get; set; }
        private void barcodeScannerButton1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {

        }

        private void barcodeScannerButton1_Press(object sender, EventArgs e)
        {

        }

        private void imageButton3_Press(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 初始化记载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TS_EatFormList_Load(object sender, EventArgs e)
        {
            //if (GetCar() > 0)
            //{

            //    button1.Text = "去支付";
            //    button1.Enabled = true;
            //    button1.BackColor = System.Drawing.Color.Red;
            //    btn_order.Enabled = false;
            //}
            //else
            //{
            //    btn_order.Text = "请点餐";
            //    btn_order.Enabled = true;
            //    btn_order.BackColor = System.Drawing.Color.Gray;
            //    button1.Enabled = false;
            //}
            FoodsTypeMenusLoad();
        }

        public void FoodsTypeMenusLoad()
        {
            #region 菜品类别 
            //菜品类别  动态生成button控件和text赋值
            string stringJson = httpClient.Get("/Menu/GetFoodsType");
            Data data = JsonConvert.DeserializeObject<Data>(stringJson);
            string json = JsonConvert.SerializeObject(data.Result);
            List<Base_Food_Menus> base_Foods = JsonConvert.DeserializeObject<List<Base_Food_Menus>>(json);
            DataTable table = GetListToDataTable.ListToDataTable(base_Foods);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int n = i % 1;
                if (n == 0 && i != 0) //这个条件语句的意思是：如果控件的数量正好是1的倍数的话那么tmp+1  这个是用于控制y轴的
                {
                    h++;
                }
                int x = n * 0, y = 65 * h;//这里定义的x和y便于控制控件在界面上的位置 
                Button btn = new Button();
                btn.Dock = System.Windows.Forms.DockStyle.Top;
                btn.BorderRadius = 0;
                btn.Location = new System.Drawing.Point(x + 0, y);
                btn.Name = table.Rows[i]["Food_Id"].ToString();
                btn.DataMember = table.Rows[i]["Food_Id"].ToString();
                btn.DisplayMember = table.Rows[i]["Food_Name"].ToString();
                btn.Size = new System.Drawing.Size(83, 85);
                btn.Text = table.Rows[i]["Food_Name"].ToString();
                btn.BackColor = System.Drawing.Color.WhiteSmoke;
                btn.ForeColor = System.Drawing.Color.Black;
                btn.Press += new EventHandler(btn_Click);//button的单击事件  
                panel2.Controls.Add(btn);
            }
            #endregion
            #region All菜品
            //所有菜品和类别id 给foods_listView绑定数据
            string stringJson1 = httpClient.Get("/Menu/GetMenus");
            Data data1 = JsonConvert.DeserializeObject<Data>(stringJson1);
            string json1 = JsonConvert.SerializeObject(data1.Result);
            List<Order_Food_Model.Base_Menus> base_Menus = JsonConvert.DeserializeObject<List<Order_Food_Model.Base_Menus>>(json1);
            if (base_Menus.Count > 0)
            {
                foods_listView.DataSource = base_Menus;
                foods_listView.DataBind();
            }
            #endregion 
        }
        //根据菜品分类id查询菜品
        public void TypeAndFoodsLoad(int type = 0)
        {
            //所有菜品和类别id 给foods_listView绑定数据
            string stringJson1 = httpClient.Get("/Menu/GetMenus?foodId=" + type);
            Data data1 = JsonConvert.DeserializeObject<Data>(stringJson1);
            string json1 = JsonConvert.SerializeObject(data1.Result);
            List<Order_Food_Model.Base_Menus> base_Menus = JsonConvert.DeserializeObject<List<Order_Food_Model.Base_Menus>>(json1);
            if (base_Menus.Count > 0)
            {
                foods_listView.DataSource = base_Menus;
                foods_listView.DataBind();
            }
        }
        /// <summary>
        /// 扫码获取堂食餐桌号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barcodeScannerButton1_BarcodeScanned_1(object sender, BarcodeResultArgs e)
        {
            if (string.IsNullOrEmpty(e.error))
            {
                lab_desk.Text = "桌";
                this.lab_table.Text = e.Value;
            }
        }
        /// <summary>
        /// 点击菜品类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TypeAndFoodsLoad(int.Parse(btn.Name));
        }
        private void imageButton4_Press(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 去支付
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_order_Press(object sender, EventArgs e)
        {
            //获取所有要的数据也就是购物车里的数据
            //string jsonHttp = httpClient.Get("/Menu/GetCars");
            //Data data = JsonConvert.DeserializeObject<Data>(jsonHttp);
            //if (data == null)
            //{
            //    MessageBox.Show("请点餐");
            //    return;
            //}
            //string json = JsonConvert.SerializeObject(data.Result);
            //List<ShowCarModel> showCars = JsonConvert.DeserializeObject<List<ShowCarModel>>(json);
            //UserBuyIdModel userBuy = new UserBuyIdModel
            //{
            //    UserId = UserId,
            //    tableNo = int.Parse(this.lab_table.Text)
            //};
            //OrderForm orderForm = new OrderForm(userBuy);
            //Show(orderForm);
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Press(object sender, EventArgs e)
        {
            #region 所有菜品和类别联表 给foods_listView绑定数据
            //所有菜品
            string stringJson1 = httpClient.Get("/Menu/GetMenus");
            Data data1 = JsonConvert.DeserializeObject<Data>(stringJson1);
            string json1 = JsonConvert.SerializeObject(data1.Result);
            List<Order_Food_Model.Base_Menus> base_Menus = JsonConvert.DeserializeObject<List<Order_Food_Model.Base_Menus>>(json1);
            #endregion
            //得到查询的菜品名称
            string FName = txt_name.Text;
            if (FName == "" || FName == null)
            {
                MessageBox.Show("您需要填入要查看的菜品");
                return;
            }
            else
            {
                var list = (from s in base_Menus
                            where s.Menu_Name.Contains(FName)
                            select new Order_Food_Model.Base_Menus
                            {
                                Food_Id = s.Food_Id,
                                Menu_Id = s.Menu_Id,
                                Menu_Name = s.Menu_Name,
                                Menu_Pecture = s.Menu_Pecture,
                                Menu_Price = s.Menu_Price,
                                Menu_YL = s.Menu_YL,
                                Dining_id = s.Dining_id,
                                Menu_Desc = s.Menu_Desc
                            }).ToList();
                if (list.Count > 0)
                {
                    foods_listView.DataSource = list;
                    foods_listView.DataBind();
                }
                else
                {
                    MessageBox.Show("没有您想要的菜品，请选择其他菜品");
                    return;
                }
            }


        }
        private void img_car_Press(object sender, EventArgs e)
        {
            TSBuyCar car = new TSBuyCar();
            DialogOptions footerDialogOptions;
            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Smobiler.Core.Controls.Padding.Empty, true);
            ShowDialog(car, footerDialogOptions);
        }
        //public int GetCar()
        //{
        //    TSBuyCar car = new TSBuyCar();
        //    decimal moneySum = 0;
        //    string s = httpClient.Get("/menu/GetCars");
        //    Data data = JsonConvert.DeserializeObject<Data>(s);
        //    if (data.Result != null)
        //    {
        //        string json = JsonConvert.SerializeObject(data.Result);
        //        List<ShowCarModel> list = JsonConvert.DeserializeObject<List<ShowCarModel>>(json);

        //        foreach (var item in list)
        //        {
        //            moneySum += item.Number * item.Price;
        //        }
        //        lab_summoney.Text = moneySum.ToString();
        //        if (list != null)
        //        {
        //            car.CarLoad();
        //            return list.Count;

        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //    else
        //    {
        //        FoodsTypeMenusLoad();
        //        return 0;
        //    }

        //}

        public void GetCarListNumber()
        {
            int s = 4;
            if (s > 0)
            {
                btn_order.Text = "去支付";
                btn_order.Enabled = true;
            }
        }

        private void imageButton1_Press(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}