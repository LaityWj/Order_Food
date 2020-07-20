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
    partial class ShowCouPonControl : Smobiler.Core.Controls.MobileUserControl
    {
        public ShowCouPonControl() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void ShowCouPonControl_Load(object sender, EventArgs e)
        {
            
            this.btn_use.Text = "立即使用";
            if (this.lab_use.Text == "仅可购买套餐使用")
            {
                this.panel2.BackColor = System.Drawing.Color.Red;
            }
            if (this.lab_use.Text == "仅可购买主食使用")
            {
                this.panel2.BackColor = System.Drawing.Color.Orange;
            }
            if (this.lab_use.Text == "通用券")
            {
                this.panel2.BackColor = System.Drawing.Color.DarkGray;
            }
            
        }
    }
}