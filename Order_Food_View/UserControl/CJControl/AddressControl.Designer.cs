﻿using System;
using Smobiler.Core;
namespace Order_Food_View.UserControl.CJControl
{
    partial class AddressControl : Smobiler.Core.Controls.MobileUserControl
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.ck_state = new Smobiler.Core.Controls.CheckBox();
            this.lab_user_name = new Smobiler.Core.Controls.Label();
            this.lab_User_Phone = new Smobiler.Core.Controls.Label();
            this.lab_Address_Detail = new Smobiler.Core.Controls.Label();
            this.imgbtn_detail = new Smobiler.Core.Controls.ImageButton();
            // 
            // panel1
            // 
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.panel1.BorderColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ck_state,
            this.lab_user_name,
            this.lab_User_Phone,
            this.lab_Address_Detail,
            this.imgbtn_detail});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // ck_state
            // 
            this.ck_state.Location = new System.Drawing.Point(24, 38);
            this.ck_state.Name = "ck_state";
            this.ck_state.Size = new System.Drawing.Size(15, 15);
            this.ck_state.Style = Smobiler.Core.Controls.CheckBoxStyle.Circular;
            this.ck_state.TintColor = System.Drawing.Color.Black;
            // 
            // lab_user_name
            // 
            this.lab_user_name.DataMember = "User_Name";
            this.lab_user_name.DisplayMember = "User_Name";
            this.lab_user_name.FontSize = 15F;
            this.lab_user_name.Location = new System.Drawing.Point(52, 25);
            this.lab_user_name.Name = "lab_user_name";
            this.lab_user_name.Size = new System.Drawing.Size(100, 19);
            this.lab_user_name.Text = "label1";
            // 
            // lab_User_Phone
            // 
            this.lab_User_Phone.DataMember = "User_Phone";
            this.lab_User_Phone.DisplayMember = "User_Phone";
            this.lab_User_Phone.FontSize = 15F;
            this.lab_User_Phone.Location = new System.Drawing.Point(139, 25);
            this.lab_User_Phone.Name = "lab_User_Phone";
            this.lab_User_Phone.Size = new System.Drawing.Size(100, 19);
            this.lab_User_Phone.Text = "label1";
            // 
            // lab_Address_Detail
            // 
            this.lab_Address_Detail.DataMember = "Address_Detail";
            this.lab_Address_Detail.DisplayMember = "Address_Detail";
            this.lab_Address_Detail.FontSize = 15F;
            this.lab_Address_Detail.Location = new System.Drawing.Point(52, 61);
            this.lab_Address_Detail.Name = "lab_Address_Detail";
            this.lab_Address_Detail.Size = new System.Drawing.Size(162, 21);
            this.lab_Address_Detail.Text = "label1";
            // 
            // imgbtn_detail
            // 
            this.imgbtn_detail.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imgbtn_detail.Location = new System.Drawing.Point(259, 36);
            this.imgbtn_detail.Name = "imgbtn_detail";
            this.imgbtn_detail.ResourceID = "ios-options";
            this.imgbtn_detail.Size = new System.Drawing.Size(30, 30);
            // 
            // AddressControl
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 100);
            this.Name = "AddressControl";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.CheckBox ck_state;
        private Smobiler.Core.Controls.Label lab_user_name;
        private Smobiler.Core.Controls.Label lab_User_Phone;
        private Smobiler.Core.Controls.Label lab_Address_Detail;
        private Smobiler.Core.Controls.ImageButton imgbtn_detail;
    }
}