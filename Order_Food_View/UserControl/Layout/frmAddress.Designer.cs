using System;
using Smobiler.Core;
namespace Order_Food_View.Layout
{
    partial class frmAddress : Smobiler.Core.Controls.MobileUserControl
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
            Smobiler.Core.Controls.RadioButton radioButton3 = new Smobiler.Core.Controls.RadioButton();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.labname = new Smobiler.Core.Controls.Label();
            this.radioGroup1 = new Smobiler.Core.Controls.RadioGroup();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.labphone = new Smobiler.Core.Controls.Label();
            this.labaddres = new Smobiler.Core.Controls.Label();
            this.btnupdate = new Smobiler.Core.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labname,
            this.radioGroup1,
            this.line1,
            this.labphone,
            this.labaddres,
            this.btnupdate});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // labname
            // 
            this.labname.DataMember = "name";
            this.labname.DisplayMember = "name";
            this.labname.FontSize = 16F;
            this.labname.Location = new System.Drawing.Point(58, 13);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(75, 35);
            this.labname.Text = "label1";
            // 
            // radioGroup1
            // 
            radioButton3.Checked = true;
            radioButton3.ID = null;
            radioButton3.Value = null;
            this.radioGroup1.Buttons.AddRange(new Smobiler.Core.Controls.RadioButton[] {
            radioButton3});
            this.radioGroup1.GridLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioGroup1.Location = new System.Drawing.Point(9, 39);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Size = new System.Drawing.Size(37, 27);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Gray;
            this.line1.Location = new System.Drawing.Point(239, 45);
            this.line1.Name = "line1";
            this.line1.Orientation = Smobiler.Core.Controls.OrientationAlignment.Vertical;
            this.line1.Size = new System.Drawing.Size(1, 20);
            // 
            // labphone
            // 
            this.labphone.DataMember = "phone";
            this.labphone.DisplayMember = "phone";
            this.labphone.FontSize = 16F;
            this.labphone.Location = new System.Drawing.Point(119, 13);
            this.labphone.Name = "labphone";
            this.labphone.Size = new System.Drawing.Size(100, 35);
            this.labphone.Text = "label2";
            // 
            // labaddres
            // 
            this.labaddres.BorderColor = System.Drawing.Color.Gray;
            this.labaddres.DataMember = "xiang";
            this.labaddres.DisplayMember = "xiang";
            this.labaddres.FontSize = 16F;
            this.labaddres.Location = new System.Drawing.Point(58, 52);
            this.labaddres.Name = "labaddres";
            this.labaddres.Size = new System.Drawing.Size(178, 35);
            this.labaddres.Text = "label3";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnupdate.BorderRadius = 0;
            this.btnupdate.ForeColor = System.Drawing.Color.DimGray;
            this.btnupdate.Location = new System.Drawing.Point(246, 39);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(38, 27);
            this.btnupdate.Text = "编辑";
            // 
            // frmAddress
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 100);
            this.Load += new System.EventHandler(this.frmAddress_Load);
            this.Name = "frmAddress";

        }
        #endregion
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label labname;
        private Smobiler.Core.Controls.RadioGroup radioGroup1;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Label labphone;
        private Smobiler.Core.Controls.Label labaddres;
        private Smobiler.Core.Controls.Button btnupdate;
    }
}