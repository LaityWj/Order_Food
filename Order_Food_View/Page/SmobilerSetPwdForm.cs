using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page
{
    partial class SmobilerSetPwdForm : Smobiler.Core.Controls.MobileForm
    {
        public SmobilerSetPwdForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        /// <summary>
        /// 返回到设置页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_my_Press(object sender, EventArgs e)
        {
            SmobilerUpdatePwdForm pwd = new SmobilerUpdatePwdForm();
            Show(pwd);
        }
        /// <summary>
        /// 提交成功跳转到我的页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Press(object sender, EventArgs e)
        {
            SmobilerMyForm my = new SmobilerMyForm();
            Show(my);
        }
    }
}