using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Newtonsoft.Json;
using Order_Food_View.HelperClass;
using Order_Food_View.Models;
using Order_Food_View.UserControl.CJControl;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page.JFPage
{
    partial class JFMallForm : Smobiler.Core.Controls.MobileForm
    {
        //实例化HttpClientHelper传递IP地址
        HttpClientHelper httpClient = new HttpClientHelper("http://192.168.43.51:8081");
        public JFMallForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        /// <summary>
        /// 跳转到首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_my_Press(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JFMallForm_Load(object sender, EventArgs e)
        {
            //绑定积分商城的用户控件
            listView1.TemplateControl = new JFMallControl();
            JFMallControl jFMall = new JFMallControl();
            ExchangeProduct();
        }
        /// <summary>
        /// 显示兑换的商品信息
        /// </summary>
        public void ExchangeProduct()
        {
            string shopDetail = httpClient.Get("/Integral/ShopDetail");
            Data model = JsonConvert.DeserializeObject<Data>(shopDetail);
            string itemJson = JsonConvert.SerializeObject(model.Result);
            List<shopDetail> shoplist = JsonConvert.DeserializeObject<List<shopDetail>>(itemJson);
            DataTable table = new DataTable();
            table.Columns.Add("Menu_Id", typeof(System.Int32));
            table.Columns.Add("Menu_Pecture", typeof(System.String));
            table.Columns.Add("Menu_Name", typeof(System.String));
            table.Columns.Add("Need_JF", typeof(System.Int32));
            table.Columns.Add("Number", typeof(System.Int32));
            table.Columns.Add("NeedDateTime", typeof(System.String));
            foreach (var item in shoplist)
            {
                table.Rows.Add(item.Menu_Id,item.Menu_Pecture, item.Menu_Name, item.Need_JF, item.Number, item.NeedDateTime);
            }
            //for (int i = 0; i < 5; i++)
            //{
            //    table.Rows.Add("kele.png", "200ML可口可乐",20,234, date1.ToString("yyyy-MM-dd") + "~" + date2);
            //    table.Rows.Add("smt.png", "酸梅汤", 30, 234, date1.ToString("yyyy-MM-dd") + "~" + date2);
            //}
            if(table.Rows.Count > 0)
            {
                listView1.DataSource = table;
                listView1.DataBind();
            }
            
        }
    }
}