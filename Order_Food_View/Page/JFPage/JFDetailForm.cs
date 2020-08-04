using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Order_Food_View.HelperClass;
using Order_Food_View.Models;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page.JFPage
{
    partial class JFDetailForm : Smobiler.Core.Controls.MobileForm
    {
        HttpClientHelper HttpClient = new HttpClientHelper("http://192.168.43.51:8081");
        public JFDetailForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        //接收Model类
        private shopDetail shoplist { get; set; }
        //构造函数
        public JFDetailForm(shopDetail _list)
        {
            this.shoplist = _list;
            InitializeComponent();
        }

        /// <summary>
        /// 返回积分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_my_Press(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 积分详情页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JFDetailForm_Load(object sender, EventArgs e)
        {
            //调用重新加载方法
            ReLoad();
        }
        /// <summary>
        /// 重新加载事件
        /// </summary>
        public void ReLoad()
        {
            this.lab_name.Text = shoplist.Menu_Name;
            this.lab_time.Text = shoplist.NeedDateTime;
            this.image1.ResourceID = shoplist.Menu_Pecture;
            this.lab_jf.Text = shoplist.Need_JF.ToString();
            this.lab_num.Text = shoplist.Number.ToString();
            this.Menu_Id.Text = shoplist.Menu_Id.ToString();
        }
        /// <summary>
        /// 点击立即兑换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Press(object sender, EventArgs e)
        {
            Chong chong = new Chong()
            {
                userID = 1,
                ypId = Convert.ToInt32(this.Menu_Id.Text)
            };
            string DH = HttpClient.Post("/Integral/ShopRecharge", JsonConvert.SerializeObject(chong));
            Data model = JsonConvert.DeserializeObject<Data>(DH);
            string result = JsonConvert.SerializeObject(model.Result);
            if (result == "1")
            {
                MessageBox.Show("兑换成功", "警告框", MessageBoxButtons.OKCancel, (obj, args) =>
                {
                    if (args.Result == ShowResult.No) { }
                });
                ReLoad();
            }
            else
            {
                MessageBox.Show("兑换失败", "警告框", MessageBoxButtons.OKCancel, (obj, args) =>
                {
                    if (args.Result == ShowResult.No) { }
                });
            }
        }
    }
}