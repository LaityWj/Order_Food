using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page.JFPage
{
    partial class JFDetailForm : Smobiler.Core.Controls.MobileForm
    {
        public JFDetailForm() : base()
        {
            //This call is required by the SmobilerForm.
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

        }
    }
}