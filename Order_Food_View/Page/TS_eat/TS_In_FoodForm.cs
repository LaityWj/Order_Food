using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Page.TS_eat
{
    partial class TS_In_FoodForm : Smobiler.Core.Controls.MobileForm
    {
        public TS_In_FoodForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void barcodeScannerButton1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            if (string.IsNullOrEmpty(e.error))
            {
                lab_desk.Text = "桌";
                this.lab_table.Text = e.Value;
            }
        }

        private void barcodeScannerButton1_Press(object sender, EventArgs e)
        {

        }

        private void BtnClient_Press(object sender, EventArgs e)
        {

        }

        private void imageButton4_Press(object sender, EventArgs e)
        {

        }

        private void button10_Press(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 查找菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageButton3_Press(object sender, EventArgs e)
        {
          string CName=  this.txt_name.Text;
            MessageBox.Show(CName);
        }
    }
}