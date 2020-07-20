using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Order_Food_View.HelperClass;

namespace Order_Food_View.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmResType : Smobiler.Core.Controls.MobileUserControl
    {
        Helper helper = new Helper();
        public FrmResType() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        //菜品点击事件
        private void button1_Press(object sender, EventArgs e)
        {
           
            var type = button1.Text;
            switch (type)
            {
                case "精品推荐":
                   // Client.Share.SendURL("");
                    break;

                case "人气热卖":
                    break;

                case "精选套餐":
                    break;

                case "所有菜单":
                    break;

                case "主食":
                    break;
                case "酒水饮料":
                    break;

                default:
                    break;
            }
        }
    }
}