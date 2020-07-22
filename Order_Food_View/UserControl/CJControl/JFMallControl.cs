using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Order_Food_View.Page.JFPage;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.UserControl.CJControl
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class JFMallControl : Smobiler.Core.Controls.MobileUserControl
    {
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
            JFDetailForm detailForm = new JFDetailForm();
            this.Form.Show(detailForm);
        }
    }
}