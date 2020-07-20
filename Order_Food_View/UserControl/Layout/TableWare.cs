using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerApplication1.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class TableWare : Smobiler.Core.Controls.MobileUserControl
    {
        public TableWare() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        //点击确定按钮获取选的值并关闭
        private void butSure_Press(object sender, EventArgs e)
        {
          var a=  picker1.SelectedItem;
          this.Close();
        }
        //点击取消按钮关闭页面并且不选择值
        private void butNo_Press(object sender, EventArgs e)
        {

        }
    }
}