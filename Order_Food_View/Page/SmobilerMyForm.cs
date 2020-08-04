using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Order_Food_Model;
using Order_Food_View.HelperClass;
using Order_Food_View.Page.JFPage;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page
{
    partial class SmobilerMyForm : Smobiler.Core.Controls.MobileForm
    {
        HttpClientHelper HttpClient = new HttpClientHelper("http://192.168.43.51:8081");
        public SmobilerMyForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        //定义一个变量,判断是否被选中
        public bool _isshow = true;
        public SmobilerMyForm(bool isShowToolbar) : base()
        {
            _isshow = isShowToolbar;
            InitializeComponent();
        }

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
        /// 点击充值事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageButton2_Press(object sender, EventArgs e)
        {
            SmobilerRechargeForm recharge = new SmobilerRechargeForm();
            Show(recharge);
        }
        /// <summary>
        /// 跳转到修改密码页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SetUp_Press(object sender, EventArgs e)
        {
            SmobilerUpdatePwdForm updatePwd = new SmobilerUpdatePwdForm();
            Show(updatePwd);
        }
        /// <summary>
        /// 跳转到积分列表显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_JiFen_Press(object sender, EventArgs e)
        {
            JFForm integral = new JFForm();
            Show(integral);
        }
        /// <summary>
        /// 页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmobilerMyForm_Load(object sender, EventArgs e)
        {
            //调用用户信息
            GetUserModel();
        }
        /// <summary>
        /// 显示查询用户信息
        /// </summary>
        public void GetUserModel()
        {
            string userList = HttpClient.Get("/Integral/GetUserModel?userId=1");
            Data model = JsonConvert.DeserializeObject<Data>(userList);
            string itemJson = JsonConvert.SerializeObject(model.Result);
            Base_UserInfo userInfos = JsonConvert.DeserializeObject<Base_UserInfo>(itemJson);
            this.user_Name.Text = userInfos.User_Name;
            this.user_Picture.ResourceID = userInfos.User_Picture;
            string phone = userInfos.User_Phone.Replace(userInfos.User_Phone.Substring(3, 4), "****");
            this.user_Phone.Text = phone;
            this.imageButton2.Text = "￥" + userInfos.User_Money + "          钱包·充值";
            this.btn_JiFen.Text = userInfos.User_JFNumber.ToString() + "         积分";
        }
    }
}