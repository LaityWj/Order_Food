using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Order_Food_Model;
using Order_Food_View.HelperClass;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page.LoginPage
{
    partial class UserRegisterPage : Smobiler.Core.Controls.MobileForm
    {
        HttpClientHelper helper = new HttpClientHelper("http://192.168.43.51:8081");

        public UserRegisterPage() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void textBox1_SubmitEditing(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Press(object sender, EventArgs e)
        {
            string userName = txt_name.Text;
            string phoneNumber = txtUserName.Text;
            string pwd = txt_pwd.Text;
            string againName = txt_againpwd.Text;
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("用户名不能为空");
                return;
            }
            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("手机号不能为空");
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("密码不能为空");
                return;
            }

            if (pwd != againName)
            {
                MessageBox.Show("两次密码不一致");
                return;
            }
            Base_UserInfo userInfo = new Base_UserInfo
            {
                User_Name = userName,
                User_Pwd = pwd,
                User_Phone = phoneNumber,
                User_Money = 0,
                User_JFNumber = 10
            };
           string json= helper.Post("/Menu/AddUser", JsonConvert.SerializeObject(userInfo));
            if (json != null)
            {
                UserLoginPage userLoginPage = new UserLoginPage();
                Show(userLoginPage);
            }
            else
            {
                MessageBox.Show("注册失败");
                return;
            }
        }
    }
}