using System;
using Smobiler.Core;
namespace Order_Food_View
{
    partial class SmobilerFirstControl : Smobiler.Core.Controls.MobileUserControl
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
            this.image1 = new Smobiler.Core.Controls.Image();
            // 
            // image1
            // 
            this.image1.DisplayMember = "Picture";
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(300, 150);
            this.image1.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // SmobilerFirstControl
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1});
            this.Size = new System.Drawing.Size(300, 150);
            this.Name = "SmobilerFirstControl";

        }
        #endregion

        private Smobiler.Core.Controls.Image image1;
    }
}