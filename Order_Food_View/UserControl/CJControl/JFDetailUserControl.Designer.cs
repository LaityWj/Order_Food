using System;
using Smobiler.Core;
namespace Order_Food_View.UserControl.CJControl
{
    partial class JFDetailUserControl : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            // 
            // label1
            // 
            this.label1.FontSize = 20F;
            this.label1.Location = new System.Drawing.Point(108, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 35);
            this.label1.Text = "积分说明";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 35);
            this.label2.Text = "    1、用户在本餐厅外卖或堂食消费都可获得积分，每消费1元便可获得1积分";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 35);
            this.label3.Text = "    2、积分的有效期为1年";
            // 
            // imageButton1
            // 
            this.imageButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton1.Location = new System.Drawing.Point(259, 5);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "ios-close-circle-outline";
            this.imageButton1.Size = new System.Drawing.Size(35, 35);
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // JFDetailUserControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.label3,
            this.imageButton1});
            this.Size = new System.Drawing.Size(300, 200);
            this.Name = "JFDetailUserControl";

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.ImageButton imageButton1;
    }
}