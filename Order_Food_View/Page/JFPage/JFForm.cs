using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Order_Food_View.UserControl.CJControl;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page.JFPage
{
    partial class JFForm : Smobiler.Core.Controls.MobileForm
    {
        public JFForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void back_my_Press(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JFForm_Load(object sender, EventArgs e)
        {
            //绑定用户控件
            listView1.TemplateControl = new JFUserControl();
            listView2.TemplateControl = new JFUserControl();
            IntegralIncome();
            IntegralExpenditure();
        }
        /// <summary>
        /// 根据积分收入显示
        /// </summary>
        public void IntegralIncome()
        {
            DataTable table = new DataTable();
            table.Columns.Add("XFType", typeof(System.String));
            table.Columns.Add("XFTime", typeof(System.DateTime));
            table.Columns.Add("XFYe", typeof(System.String));
            for (int i = 1; i <= 7; i++)
            {
                table.Rows.Add("食堂消费（石佛营店）", DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss"), $"+{i * 10}");
            }
            if (table.Rows.Count > 0)
            {
                listView1.DataSource = table;
                listView1.DataBind();
            }
        }
        /// <summary>
        /// 根据积分支出显示
        /// </summary>
        public void IntegralExpenditure()
        {
            DataTable table = new DataTable();
            table.Columns.Add("XFType", typeof(System.String));
            table.Columns.Add("XFTime", typeof(System.DateTime));
            table.Columns.Add("XFYe", typeof(System.String));
            for (int i = 1; i <= 7; i++)
            {
                table.Rows.Add("食堂消费（石佛营店）", DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss"), $"-{i * 10}");
            }
            if (table.Rows.Count > 0)
            {
                listView2.DataSource = table;
                listView2.DataBind();
            }
        }
        /// <summary>
        /// 根据即将过期显示
        /// </summary>
        public void Soon()
        {
            
        }
        /// <summary>
        /// 弹出积分详情信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageButton1_Press(object sender, EventArgs e)
        {
            JFDetailUserControl jFDetail = new JFDetailUserControl();
            ShowDialog(jFDetail);
        }
    }
}