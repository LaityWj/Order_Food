using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.UserControl
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class CouPonControl : Smobiler.Core.Controls.MobileUserControl
    {
        public CouPonControl() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_X_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CouPonControl_Load(object sender, EventArgs e)
        { 
            YesOrderCouPonList();

        } 
        public void YesOrderCouPonList()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("money", typeof(System.String));
            tb.Columns.Add("TypeName", typeof(System.String));
            tb.Columns.Add("UseType", typeof(System.String));
            tb.Columns.Add("UseDate", typeof(System.String));
            tb.Rows.Add("￥ 5", "现金券", "仅可购买套餐使用", "有效期2019-08-01-2019-09-30");
            tb.Rows.Add("￥ 50", "满199可用", "仅可购买主食使用", "有效期2019-08-01-2019-09-30");
            tb.Rows.Add(null, "5折", "通用券", "有效期2019-08-01-2019-09-30");

            if (tb.Rows.Count>0)
            {
                listView1.DataSource = tb;
                listView1.DataBind();
            }

        }

    }
}