using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAddress : Smobiler.Core.Controls.MobileUserControl
    {
        public frmAddress() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public string addres { get; set; }
        private void frmAddress_Load(object sender, EventArgs e)
        {
           addres= labaddres.Text;
            var s=  labaddres.Text;
              
        }
    }
}