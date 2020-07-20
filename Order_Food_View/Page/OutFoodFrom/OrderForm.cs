using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmobilerApplication1.Layout;

namespace Order_Food_View.OutFoodFrom
{
    partial class OrderForm : Smobiler.Core.Controls.MobileForm
    {
        public OrderForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void imageButton2_Press(object sender, EventArgs e)
        {
            DialogOptions footerDialogOptions;
            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Smobiler.Core.Controls.Padding.Empty, true);
            ShowDialog(new LeaveTime(), footerDialogOptions);
         //   ShowDialog(new LeaveTime());
        
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("name", typeof(string));
            tb.Columns.Add("money", typeof(string));
            tb.Columns.Add("number", typeof(int));
            tb.Rows.Add("火锅肉", "25", 1);
            tb.Rows.Add("火锅肉", "30", 2);
            tb.Rows.Add("火锅肉", "40", 3);
            if (tb.Rows.Count > 0)
            {
                listOrder.DataSource = tb;
                listOrder.DataBind();
            }
        }
        //选择餐具数量
        private void imageButton4_Press(object sender, EventArgs e)
        {
            DialogOptions footerDialogOptions;
            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Smobiler.Core.Controls.Padding.Empty, true);
            ShowDialog(new TableWare(), footerDialogOptions);
        }
    }
}