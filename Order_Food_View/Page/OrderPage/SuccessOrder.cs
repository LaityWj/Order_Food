﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Order_Food_View.Page.TS_eat;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page
{
    partial class SuccessOrder : Smobiler.Core.Controls.MobileForm
    {
        public SuccessOrder() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        public SuccessOrder(string _orderStateText, decimal Summoney)
        {
            this.SuccessOrderText = _orderStateText;
            this.GetMoney = Summoney;
        }
        private string SuccessOrderText { get; set; }
        private decimal GetMoney { get; set; }
        private void SuccessOrder_Load(object sender, EventArgs e)
        { 
            this.lab_Topsuccess.Text = SuccessOrderText;
            if (this.lab_Topsuccess.Text == "支付成功")
            {
                this.lab_cuccess.Text = "支付成功";
                //得到积分
                this.lab_getjf.Visible = true;
                this.lab_getjf.Text = Math.Floor(GetMoney).ToString(); ;
                this.img_back.Visible = false;
                this.img_top.Visible = false;
                this.img_success.Visible = true;
                this.btn_success.Text = "继续点餐";
                this.btn_orderList.Text = "查看订单";
            }
            if (this.lab_Topsuccess.Text == "支付失败")
            {
                this.lab_cuccess.Text = "支付失败";
                this.img_back.Visible = true;
                this.img_top.Visible = true;

                this.img_success.Visible = false;
                //积分
                this.lab_jftext.Visible = false;
                this.lab_getjf.Visible = false;
                this.btn_success.Text = "继续支付";
                this.btn_orderList.Text = "继续点餐";
            }
        }
        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageButton1_Press(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            Show(orderForm);
        }
        /// <summary>
        /// 支付成功后继续点餐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_success_Press(object sender, EventArgs e)
        {

            this.lab_Topsuccess.Text = SuccessOrderText;
            //判断是否支付成功否则失败
            if (this.lab_Topsuccess.Text == "支付成功")
            {
                //到继续点餐页面
                TS_EatFormList tS_Eat = new TS_EatFormList();
                Show(tS_Eat);
                //到菜品页 
            }
            //失败
            else
            {
                //到继续去支付页面 
                Show(new OrderForm());

            } 
        } 
        private void btn_orderList_Press(object sender, EventArgs e)
        {
            this.lab_Topsuccess.Text = SuccessOrderText;
            //成功否则失败
            if (this.lab_Topsuccess.Text == "支付成功")
            {
                //成功看订单 
                Show(new OrderListForm());
                //到订单详情页面
            }//失败
            else
            {
                //到继续菜品页面
                TS_EatFormList tS_Eat = new TS_EatFormList();
                Show(tS_Eat);
                //到菜品也
            }

        }
    }
}