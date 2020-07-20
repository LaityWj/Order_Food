using System;
using Smobiler.Core;
namespace SmobilerApplication1.Layout
{
    partial class LeaveTime : Smobiler.Core.Controls.MobileUserControl
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
            this.picKDay = new Smobiler.Core.Controls.Picker();
            this.pickTime = new Smobiler.Core.Controls.Picker();
            this.BtnNo = new Smobiler.Core.Controls.Button();
            this.BtnSure = new Smobiler.Core.Controls.Button();
            // 
            // picKDay
            // 
            this.picKDay.FontSize = 25F;
            this.picKDay.ForeColor = System.Drawing.Color.Gray;
            this.picKDay.Items = new string[] {
        "7.17",
        "7.18",
        "7.19",
        "7.20",
        "7.21"};
            this.picKDay.Location = new System.Drawing.Point(0, 45);
            this.picKDay.Name = "picKDay";
            this.picKDay.Size = new System.Drawing.Size(191, 195);
            // 
            // pickTime
            // 
            this.pickTime.FontSize = 25F;
            this.pickTime.Items = new string[] {
        "12：00",
        "12：15",
        "12：30",
        "12：45",
        "12：50",
        "13：00"};
            this.pickTime.Location = new System.Drawing.Point(191, 45);
            this.pickTime.Name = "pickTime";
            this.pickTime.Size = new System.Drawing.Size(209, 195);
            // 
            // BtnNo
            // 
            this.BtnNo.BackColor = System.Drawing.Color.White;
            this.BtnNo.BorderRadius = 0;
            this.BtnNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnNo.Location = new System.Drawing.Point(8, 10);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(50, 35);
            this.BtnNo.Text = "取消";
            this.BtnNo.Press += new System.EventHandler(this.BtnNo_Press);
            // 
            // BtnSure
            // 
            this.BtnSure.BackColor = System.Drawing.Color.White;
            this.BtnSure.BorderRadius = 0;
            this.BtnSure.ForeColor = System.Drawing.Color.Red;
            this.BtnSure.Location = new System.Drawing.Point(327, 15);
            this.BtnSure.Name = "BtnSure";
            this.BtnSure.Size = new System.Drawing.Size(48, 30);
            this.BtnSure.Text = "确定";
            this.BtnSure.Press += new System.EventHandler(this.BtnSure_Press);
            // 
            // LeaveTime
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.picKDay,
            this.pickTime,
            this.BtnNo,
            this.BtnSure});
            this.Size = new System.Drawing.Size(400, 270);
            this.Load += new System.EventHandler(this.LeaveTime_Load);
            this.Name = "LeaveTime";

        }
        #endregion

        private Smobiler.Core.Controls.Picker picKDay;
        private Smobiler.Core.Controls.Picker pickTime;
        private Smobiler.Core.Controls.Button BtnNo;
        private Smobiler.Core.Controls.Button BtnSure;
    }
}