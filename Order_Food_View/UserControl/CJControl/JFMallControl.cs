using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls.Adapters;
using Newtonsoft.Json;
using Order_Food_View.HelperClass;
using Order_Food_View.Models;
using Order_Food_View.Page.JFPage;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.UserControl.CJControl
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class JFMallControl : Smobiler.Core.Controls.MobileUserControl
    {
        HttpClientHelper HttpClient = new HttpClientHelper("http://192.168.43.51:8081");
        public JFMallControl() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        /// <summary>
        /// 点击panel跳转积分详情页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageButton1_Press(object sender, EventArgs e)
        {
            shopDetail model = new shopDetail
            {
                Menu_Id = Convert.ToInt32(this.txt_Id.Text),
                Menu_Name = this.lab_name.Text,
                Menu_Pecture = this.imageButton1.ResourceID,
                NeedDateTime = this.lab_time.Text,
                Need_JF = Convert.ToInt32(this.lab_jf.Text),
                Number = Convert.ToInt32(this.lab_num.Text)
            };
            JFDetailForm detailForm = new JFDetailForm(model);
            this.Form.Show(detailForm);
        }
        /// <summary>
        /// 点击立即兑换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DH_Press(object sender, EventArgs e)
        {
            Chong chong = new Chong()
            {
                userID = 1,
                ypId = Convert.ToInt32(txt_Id.Text)
            };
            string DH = HttpClient.Post("/Integral/ShopRecharge",JsonConvert.SerializeObject(chong));
            Data model = JsonConvert.DeserializeObject<Data>(DH);
            string result = JsonConvert.SerializeObject(model.Result);
            if (result == "1")
            {
                MessageBox.Show("兑换成功", "警告框", MessageBoxButtons.OKCancel, (obj, args) =>
                {
                    if (args.Result == ShowResult.No) { }
                });
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