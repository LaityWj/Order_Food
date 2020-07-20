using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page
{
    partial class SmobilerRechargeForm : Smobiler.Core.Controls.MobileForm
    {
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
            SmobilerMyForm my = new SmobilerMyForm();
            Show(my);
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
            MessageBox.Show(one.Text);
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
            MessageBox.Show(one.Text);
        }
        /// <summary>
        /// 点击充值跳转到我的页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ChongZhi_Press(object sender, EventArgs e)
        {
            SmobilerMyForm my = new SmobilerMyForm();
            Show(my);
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
            MessageBox.Show(one.Text);
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
            MessageBox.Show(one.Text);
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
            MessageBox.Show(one.Text);
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
            MessageBox.Show(one.Text);
        }
    }
}