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
    partial class LeaveTime : Smobiler.Core.Controls.MobileUserControl
    {
        public LeaveTime() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void LeaveTime_Load(object sender, EventArgs e)
        {
            string[] time = new string[30];
            for (int i = 0; i < 30; i++)
            {
                time[i]=  DateTime.Now.AddDays(+i).ToString("MM-dd");
            }
            picKDay.Items = time;
            string[] time1 = new string[30];
            //for (int i = 0; i < 100; i++)
            //{
            //    time1[i] = DateTime.Now.ToShortTimeString().ToString()+15;
            //}
        }
        //确定按钮
        private void BtnSure_Press(object sender, EventArgs e)
        {
            this.Close();
        }
        //取消按钮
        private void BtnNo_Press(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}