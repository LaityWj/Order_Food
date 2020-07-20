using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Order_Food_View.Layout;
using Order_Food_View.OutFoodFrom;
using System.Net;
using System.IO;
using Order_Food_View.HelperClass;
using Newtonsoft.Json;

namespace Order_Food_View
{
    public delegate void MyFood();
    partial class take_out_foodForm : Smobiler.Core.Controls.MobileForm
    {
        public event MyFood FoodType;
        HelperClass.Helper helper = new HelperClass.Helper();
        public take_out_foodForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        public void LoadFood()
        {
            //take_out_foodForm form = new take_out_foodForm();
            //Button btn = (Button)form.Controls.Find("BtnClient");
            //btn.Text = "去结算";
            //btn.Enabled = true;
            this.BtnClient.Text = "去结算";
        }
        private void Loads()
        {
           // //动态绑定菜品 --默认显示精品推荐
           // DataTable table = new DataTable();
           // table.Columns.Add("Menu_Name", typeof(string));//菜名
           // table.Columns.Add("Menu_Pecture", typeof(string));//菜品图片
           // table.Columns.Add("Menu_Price", typeof(decimal));//价格
           // table.Columns.Add("number", typeof(int));//月销
           // HttpClientHelper http = new HttpClientHelper("http://localhost:54043/api/Default/menu");
           // List<Base_Menus> menu = JsonConvert.DeserializeObject<List<Base_Menus>>(http.Get(""));
           // foreach (var item in menu)
           // {
           //     table.Rows.Add(item.Menu_Name, item.Menu_Pecture, item.Menu_Price);
           // }
           // //table.Rows.Add("cy1", "蛋炒饭", "10", "500");
           // //table.Rows.Add("cy2", "炸酱面", "20", "600");
           // //table.Rows.Add("cy3", "蛋炒饭", "30", "500");
           // //table.Rows.Add("cy1", "麻辣烫", "60", "500");
           // //table.Rows.Add("cy2", "蛋炒饭", "10", "500");
           // //table.Rows.Add("cy3", "蛋炒饭", "10", "500");
           // if (table.Rows.Count > 0)
           // {
           //     Restaurant.DataSource = table;
           //     Restaurant.DataBind();
           // }

           // //动态绑定菜品类别
           // DataTable tb = new DataTable();
           // HttpClientHelper h = new HttpClientHelper("http://localhost:54043/api/Default/type"); //调用api获取数据
           // string s= h.Get("");
           // List<Base_Food_Menus> type = JsonConvert.DeserializeObject<List<Base_Food_Menus>>(s);
           // tb.Columns.Add("Food_Name", typeof(string));
           // foreach (var item in type)
           // {
           //     tb.Rows.Add(item.Food_Name);
           // }
           // if (tb.Rows.Count > 0)
           // {
           //     listView1.DataSource = tb;
           //     listView1.DataMember = "Food_Name";
           //     listView1.DataBind();
           // }


           // frmAddress frm = new frmAddress();
           // textBox1.Text = frm.addres;
           //// BtnClient.Enabled = false;
           // BtnClient.Text = "请点餐";

        }
        //页面初始化绑定数据
        private void take_out_foodForm_Load(object sender, EventArgs e)
        {
             Loads();
            frmResList s = new frmResList();
           //t s.FoodType;


        }
        //文本框
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Press(object sender, EventArgs e)
        {

        }
        //定位图标
        private void imageButton2_Press(object sender, EventArgs e)
        {
            AddressForm form = new AddressForm();
            Show(form);
        }
        //请点餐按钮
        private void BtnClient_Press(object sender, EventArgs e)
        {

            Show(new OrderForm());
        }
        //购物车图片事件
        private void imageButton4_Press(object sender, EventArgs e)
        {
            DialogOptions footerDialogOptions;
            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Smobiler.Core.Controls.Padding.Empty, true);
            ShowDialog(new BuyCar(), footerDialogOptions);
           // ShowDialog(new BuyCar());
        }

        private void button1_Press(object sender, EventArgs e)
        {
            FoodType();
        }
    }
}