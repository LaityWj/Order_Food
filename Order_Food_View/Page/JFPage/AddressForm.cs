using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using Order_Food_View.HelperClass;
using Order_Food_View.UserControl.CJControl;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page.JFPage
{
    partial class AddressForm : Smobiler.Core.Controls.MobileForm
    {
        public AddressForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        /// <summary>
        /// 返回我的页面
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
        private void AddressForm_Load(object sender, EventArgs e)
        {
            //绑定用户控件
            listView1.TemplateControl = new AddressControl();
            GetAddress();
        }
        /// <summary>
        /// 显示地址信息
        /// </summary>
        public void GetAddress()
        {
            DataTable table = new DataTable();
            HttpClientHelper httpClient = new HttpClientHelper("http://localhost:50872/Menu/GetAddressFirst");
            string shouhuo = httpClient.Get("");
            table.Columns.Add("User_Name",typeof(System.String));
            table.Columns.Add("User_Phone", typeof(System.String));
            table.Columns.Add("Address_Detail", typeof(System.String));
            for (int i = 0; i < 3; i++)
            {
                table.Rows.Add("崔杰","15951364167","上海八维宏烨教育");
            }
            if(table.Rows.Count > 0)
            {
                listView1.DataSource = table;
                listView1.DataBind();
            }
        }
    }
}