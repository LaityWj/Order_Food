using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page
{
    partial class SmobilerMyForm : Smobiler.Core.Controls.MobileForm
    {
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
            IntegralForm integral = new IntegralForm();
            Show(integral);
        }
    }
}