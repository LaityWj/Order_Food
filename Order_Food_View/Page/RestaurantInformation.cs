using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page
{
    partial class RestaurantInformation : Smobiler.Core.Controls.MobileForm
    {
        public RestaurantInformation() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        /// <summary>
        /// 返回首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_my_Press(object sender, EventArgs e)
        {
            SmobilerFirst first = new SmobilerFirst();
            Show(first);
        }
    }
}