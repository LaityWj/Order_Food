using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page
{
    partial class SmobilerUpdatePwdForm : Smobiler.Core.Controls.MobileForm
    {
        public SmobilerUpdatePwdForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        /// <summary>
        /// 跳转到设置页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_my_Press(object sender, EventArgs e)
        {
            SmobilerMyForm  myForm = new SmobilerMyForm();
            Show(myForm);
        }
        /// <summary>
        /// 跳转到修改密码页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UpdatePwd_Press(object sender, EventArgs e)
        {
            SmobilerSetPwdForm set = new SmobilerSetPwdForm();
            Show(set);
        }
    }
}