using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Order_Food_Model;
using Order_Food_View.HelperClass;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page.LoginPage
{
    partial class UserLoginPage : Smobiler.Core.Controls.MobileForm
    {
        HttpClientHelper helper = new HttpClientHelper("http://192.168.43.51:8081");
        public UserLoginPage() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void btn_login_Press(object sender, EventArgs e)
        {
            string json = helper.Get("/Menu/GetUser");
            Data data = JsonConvert.DeserializeObject<Data>(json);
            string stringJson = JsonConvert.SerializeObject(data.Result);
            List<Base_UserInfo> list = JsonConvert.DeserializeObject<List<Base_UserInfo>>(stringJson);

            string User_Name = txtUserName.Text;
            string pwd = txtUserPwd.Text; 
            Base_UserInfo base_UserInfo = list.Where(m => m.User_Name == User_Name && m.User_Pwd == pwd).FirstOrDefault();
            if (base_UserInfo == null)
            {
                MessageBox.Show("不存在");
                return;
            }
            else
            {
                //传递用户信息到首页
                SmobilerFirst smobilerFirst = new SmobilerFirst(base_UserInfo);
                Show(smobilerFirst);
            }


        }
        private void button1_Press(object sender, EventArgs e)
        {
            UserRegisterPage userRegister = new UserRegisterPage();
            Show(userRegister);
        }
    }
}