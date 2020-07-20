using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.UserControl
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class OrderShowListControl : Smobiler.Core.Controls.MobileUserControl
    {
        public OrderShowListControl() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        //初始化加载
        private void OrderShowListControl_Load(object sender, EventArgs e)
        {
            //堂食---1待付款 -1已取消  2 已取消  0全部
            //外卖---1待付款 -1待收取  2 已完成  0全部 
            //堂食
            if (lab_state.Text == "待付款")
            {
                btn_setOrder.Text = "取消订单";
                btn_successOrder.Text = "立即付款";
            }
            else if (lab_state.Text == "已完成")
            {
                btn_setOrder.Text = "删除订单";
                btn_successOrder.Text = "再次购买"; 
            }
            else if (lab_state.Text == "待收取")
            {
                btn_setOrder.Visible = false;
                btn_successOrder.Text = "确认收货";
            }
            else if (lab_state.Text == "已取消")
            {
                btn_setOrder.Text = "删除订单";
                btn_successOrder.Text = "再次购买";
            }
            else
            {
                btn_setOrder.Text = "删除订单";
                btn_successOrder.Text = "再次购买";
            }
        }
    }
}