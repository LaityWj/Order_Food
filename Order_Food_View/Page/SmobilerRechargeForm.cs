using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Order_Food_Model;
using Order_Food_View.HelperClass;
using Order_Food_View.Models;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page
{
    partial class SmobilerRechargeForm : Smobiler.Core.Controls.MobileForm
    {
        //实例化HttpClientHelper传递IP地址
        HttpClientHelper httpClient = new HttpClientHelper("http://192.168.43.51:8081");
        public SmobilerRechargeForm() : base()
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
        /// 点击100金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void one_Press(object sender, EventArgs e)
        {
            one.ForeColor = System.Drawing.Color.Red;
            one.BorderColor = System.Drawing.Color.Red;
            this.jine.Text = one.Text;
            three.ForeColor = System.Drawing.Color.Black;
            three.BorderColor = System.Drawing.Color.Silver;
            four.ForeColor = System.Drawing.Color.Black;
            four.BorderColor = System.Drawing.Color.Silver;
            five.ForeColor = System.Drawing.Color.Black;
            five.BorderColor = System.Drawing.Color.Silver;
            six.ForeColor = System.Drawing.Color.Black;
            six.BorderColor = System.Drawing.Color.Silver;
            two.ForeColor = System.Drawing.Color.Black;
            two.BorderColor = System.Drawing.Color.Silver;
        }
        /// <summary>
        /// 点击200金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void two_Press(object sender, EventArgs e)
        {
            two.ForeColor = System.Drawing.Color.Red;
            two.BorderColor = System.Drawing.Color.Red;
            this.jine.Text = two.Text;
            three.ForeColor = System.Drawing.Color.Black;
            three.BorderColor = System.Drawing.Color.Silver;
            four.ForeColor = System.Drawing.Color.Black;
            four.BorderColor = System.Drawing.Color.Silver;
            five.ForeColor = System.Drawing.Color.Black;
            five.BorderColor = System.Drawing.Color.Silver;
            six.ForeColor = System.Drawing.Color.Black;
            six.BorderColor = System.Drawing.Color.Silver;
            one.ForeColor = System.Drawing.Color.Black;
            one.BorderColor = System.Drawing.Color.Silver;
        }
        /// <summary>
        /// 充值金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ChongZhi_Press(object sender, EventArgs e)
        {
            Chong chong = new Chong()
            {
                money = Convert.ToDecimal(jine.Text),
                userID = 1
            };
            //返回POST
            string s = httpClient.Post("/Integral/WalletRecarge", JsonConvert.SerializeObject(chong));
            Data model = JsonConvert.DeserializeObject<Data>(s);
            int intJson = Convert.ToInt32(JsonConvert.SerializeObject(model.Result));
            if(intJson > 0)
            {
                MessageBox.Show("充值成功");
                GetUserModel();
            }
            else
            {
                MessageBox.Show("充值失败");
            }
            //SmobilerMyForm my = new SmobilerMyForm();
            //Show(my);
        }
        /// <summary>
        /// 点击300金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void three_Press(object sender, EventArgs e)
        {
            three.ForeColor = System.Drawing.Color.Red;
            three.BorderColor = System.Drawing.Color.Red;
            this.jine.Text = three.Text;
            two.ForeColor = System.Drawing.Color.Black;
            two.BorderColor = System.Drawing.Color.Silver;
            four.ForeColor = System.Drawing.Color.Black;
            four.BorderColor = System.Drawing.Color.Silver;
            five.ForeColor = System.Drawing.Color.Black;
            five.BorderColor = System.Drawing.Color.Silver;
            six.ForeColor = System.Drawing.Color.Black;
            six.BorderColor = System.Drawing.Color.Silver;
            one.ForeColor = System.Drawing.Color.Black;
            one.BorderColor = System.Drawing.Color.Silver;
        }
        /// <summary>
        /// 点击500金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void four_Press(object sender, EventArgs e)
        {
            four.ForeColor = System.Drawing.Color.Red;
            four.BorderColor = System.Drawing.Color.Red;
            this.jine.Text = four.Text;
            three.ForeColor = System.Drawing.Color.Black;
            three.BorderColor = System.Drawing.Color.Silver;
            two.ForeColor = System.Drawing.Color.Black;
            two.BorderColor = System.Drawing.Color.Silver;
            five.ForeColor = System.Drawing.Color.Black;
            five.BorderColor = System.Drawing.Color.Silver;
            six.ForeColor = System.Drawing.Color.Black;
            six.BorderColor = System.Drawing.Color.Silver;
            one.ForeColor = System.Drawing.Color.Black;
            one.BorderColor = System.Drawing.Color.Silver;
        }
        /// <summary>
        /// 点击800金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void five_Press(object sender, EventArgs e)
        {
            five.ForeColor = System.Drawing.Color.Red;
            five.BorderColor = System.Drawing.Color.Red;
            this.jine.Text = five.Text;
            three.ForeColor = System.Drawing.Color.Black;
            three.BorderColor = System.Drawing.Color.Silver;
            four.ForeColor = System.Drawing.Color.Black;
            four.BorderColor = System.Drawing.Color.Silver;
            two.ForeColor = System.Drawing.Color.Black;
            two.BorderColor = System.Drawing.Color.Silver;
            six.ForeColor = System.Drawing.Color.Black;
            six.BorderColor = System.Drawing.Color.Silver;
            one.ForeColor = System.Drawing.Color.Black;
            one.BorderColor = System.Drawing.Color.Silver;
        }
        /// <summary>
        /// 点击1000金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void six_Press(object sender, EventArgs e)
        {
            six.ForeColor = System.Drawing.Color.Red;
            six.BorderColor = System.Drawing.Color.Red;
            this.jine.Text = six.Text;
            three.ForeColor = System.Drawing.Color.Black;
            three.BorderColor = System.Drawing.Color.Silver;
            four.ForeColor = System.Drawing.Color.Black;
            four.BorderColor = System.Drawing.Color.Silver;
            five.ForeColor = System.Drawing.Color.Black;
            five.BorderColor = System.Drawing.Color.Silver;
            two.ForeColor = System.Drawing.Color.Black;
            two.BorderColor = System.Drawing.Color.Silver;
            one.ForeColor = System.Drawing.Color.Black;
            one.BorderColor = System.Drawing.Color.Silver;
        }
        /// <summary>
        /// 页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmobilerRechargeForm_Load(object sender, EventArgs e)
        {
            GetUserModel();
        }
        /// <summary>
        /// 显示查询用户信息
        /// </summary>
        public void GetUserModel()
        {
            string userList = httpClient.Get("/Integral/GetUserModel?userId=1");
            Data model = JsonConvert.DeserializeObject<Data>(userList);
            string itemJson = JsonConvert.SerializeObject(model.Result);
            Base_UserInfo userInfos = JsonConvert.DeserializeObject<Base_UserInfo>(itemJson);
            this.YuE.Text = "￥" + (userInfos.User_Money).ToString();
            string phone = userInfos.User_Phone;
            phone = phone.Replace(phone.Substring(3, 4), "****");
            this.lab_phone.Text = phone;
        }
    }
}