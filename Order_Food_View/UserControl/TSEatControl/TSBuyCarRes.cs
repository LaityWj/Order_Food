using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Order_Food_View.HelperClass;
using Order_Food_View.ViewModel;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.UserControl.TSEatControl
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class TSBuyCarRes : Smobiler.Core.Controls.MobileUserControl
    {
        public TSBuyCarRes() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public TSBuyCarRes(ShowCarModel models) 
        {
            this._models = models;
            InitializeComponent();
        }
        public ShowCarModel _models { get; set; }
        //减
        private void button1_Press(object sender, EventArgs e)
        {
            int id = int.Parse(labid.Text);
            decimal money = 0;
            textBox1.Text = (int.Parse(textBox1.Text) - 1).ToString();
            if (_models.MenuId == id)
            {
                money = _models.Price;
            }
            this.labmoney.Text = (decimal.Parse(labmoney.Text) - money).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //增
        private void button2_Press(object sender, EventArgs e)
        {
            int id = int.Parse(labid.Text);
            decimal money = 0;
            textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
            if (_models.MenuId == id)
            {
                money = _models.Price;
            }
            this.labmoney.Text = (decimal.Parse(labmoney.Text) + money).ToString();
            //重新添加数据
            UserBuyIdModel car = new UserBuyIdModel();
            car.menuId = int.Parse(labid.Text);
            car.count = int.Parse(textBox1.Text);

            HttpClientHelper http = new HttpClientHelper("http://192.168.43.51:8081/Menu/AddCar");
            http.Post("http://192.168.43.51:8081/Menu/AddCar", JsonConvert.SerializeObject(car));
        }

        private void TSBuyCarRes_Load(object sender, EventArgs e)
        {
            BuyLoad();
        }
        public void BuyLoad()
        {
            this.labid.Text = _models.MenuId.ToString();//.Rows[i]["MenuId"].ToString();
            this.label1.Text = _models.MenuName;
            this.labmoney.Text = (_models.Price * _models.Number).ToString();
            this.textBox1.Text = _models.Number.ToString();
        }
    }
}