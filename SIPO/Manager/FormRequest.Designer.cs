﻿namespace SIPO.Inventory
{
    partial class FormRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFinQty = new MetroFramework.Controls.MetroTextBox();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFinQTY = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lvRawMaterialsUsed = new MetroFramework.Controls.MetroListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtOldSrp = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.lblDesc = new MetroFramework.Controls.MetroLabel();
            this.txtDesc = new MetroFramework.Controls.MetroTextBox();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnDecline = new MetroFramework.Controls.MetroButton();
            this.txtUnitCost = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtpRequest = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtFinQty
            // 
            // 
            // 
            // 
            this.txtFinQty.CustomButton.Image = null;
            this.txtFinQty.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.txtFinQty.CustomButton.Name = "";
            this.txtFinQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFinQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFinQty.CustomButton.TabIndex = 1;
            this.txtFinQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFinQty.CustomButton.UseSelectable = true;
            this.txtFinQty.CustomButton.Visible = false;
            this.txtFinQty.Enabled = false;
            this.txtFinQty.Lines = new string[0];
            this.txtFinQty.Location = new System.Drawing.Point(315, 176);
            this.txtFinQty.MaxLength = 32;
            this.txtFinQty.Name = "txtFinQty";
            this.txtFinQty.PasswordChar = '\0';
            this.txtFinQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFinQty.SelectedText = "";
            this.txtFinQty.SelectionLength = 0;
            this.txtFinQty.SelectionStart = 0;
            this.txtFinQty.ShortcutsEnabled = true;
            this.txtFinQty.Size = new System.Drawing.Size(109, 23);
            this.txtFinQty.TabIndex = 109;
            this.txtFinQty.UseSelectable = true;
            this.txtFinQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFinQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // lblFinQTY
            // 
            this.lblFinQTY.AutoSize = true;
            this.lblFinQTY.Location = new System.Drawing.Point(315, 154);
            this.lblFinQTY.Name = "lblFinQTY";
            this.lblFinQTY.Size = new System.Drawing.Size(109, 19);
            this.lblFinQTY.TabIndex = 110;
            this.lblFinQTY.Text = "Finished Quantity";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 202);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(123, 19);
            this.metroLabel2.TabIndex = 103;
            this.metroLabel2.Text = "Used Raw Materials";
            // 
            // lvRawMaterialsUsed
            // 
            this.lvRawMaterialsUsed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.lvRawMaterialsUsed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvRawMaterialsUsed.FullRowSelect = true;
            this.lvRawMaterialsUsed.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRawMaterialsUsed.Location = new System.Drawing.Point(22, 221);
            this.lvRawMaterialsUsed.MultiSelect = false;
            this.lvRawMaterialsUsed.Name = "lvRawMaterialsUsed";
            this.lvRawMaterialsUsed.OwnerDraw = true;
            this.lvRawMaterialsUsed.Size = new System.Drawing.Size(249, 205);
            this.lvRawMaterialsUsed.TabIndex = 102;
            this.lvRawMaterialsUsed.UseCompatibleStateImageBehavior = false;
            this.lvRawMaterialsUsed.UseSelectable = true;
            this.lvRawMaterialsUsed.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Qty";
            // 
            // txtOldSrp
            // 
            // 
            // 
            // 
            this.txtOldSrp.CustomButton.Image = null;
            this.txtOldSrp.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtOldSrp.CustomButton.Name = "";
            this.txtOldSrp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOldSrp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOldSrp.CustomButton.TabIndex = 1;
            this.txtOldSrp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOldSrp.CustomButton.UseSelectable = true;
            this.txtOldSrp.CustomButton.Visible = false;
            this.txtOldSrp.Enabled = false;
            this.txtOldSrp.Lines = new string[0];
            this.txtOldSrp.Location = new System.Drawing.Point(23, 176);
            this.txtOldSrp.MaxLength = 255;
            this.txtOldSrp.Name = "txtOldSrp";
            this.txtOldSrp.PasswordChar = '\0';
            this.txtOldSrp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOldSrp.SelectedText = "";
            this.txtOldSrp.SelectionLength = 0;
            this.txtOldSrp.SelectionStart = 0;
            this.txtOldSrp.ShortcutsEnabled = true;
            this.txtOldSrp.Size = new System.Drawing.Size(123, 23);
            this.txtOldSrp.TabIndex = 96;
            this.txtOldSrp.UseSelectable = true;
            this.txtOldSrp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOldSrp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 99;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(23, 154);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(32, 19);
            this.lblPrice.TabIndex = 95;
            this.lblPrice.Text = "SRP";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Enabled = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(22, 80);
            this.txtName.MaxLength = 32;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(168, 23);
            this.txtName.TabIndex = 92;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(23, 106);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(74, 19);
            this.lblDesc.TabIndex = 94;
            this.lblDesc.Text = "Description";
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.CustomButton.Image = null;
            this.txtDesc.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtDesc.CustomButton.Name = "";
            this.txtDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc.CustomButton.TabIndex = 1;
            this.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc.CustomButton.UseSelectable = true;
            this.txtDesc.CustomButton.Visible = false;
            this.txtDesc.Enabled = false;
            this.txtDesc.Lines = new string[0];
            this.txtDesc.Location = new System.Drawing.Point(23, 128);
            this.txtDesc.MaxLength = 64;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(171, 23);
            this.txtDesc.TabIndex = 93;
            this.txtDesc.UseSelectable = true;
            this.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(265, 446);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 24);
            this.btnUpdate.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnUpdate.TabIndex = 97;
            this.btnUpdate.Text = "Accept";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(394, 446);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(119, 24);
            this.btnDecline.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnDecline.TabIndex = 111;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseSelectable = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // txtUnitCost
            // 
            // 
            // 
            // 
            this.txtUnitCost.CustomButton.Image = null;
            this.txtUnitCost.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.txtUnitCost.CustomButton.Name = "";
            this.txtUnitCost.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUnitCost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnitCost.CustomButton.TabIndex = 1;
            this.txtUnitCost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnitCost.CustomButton.UseSelectable = true;
            this.txtUnitCost.CustomButton.Visible = false;
            this.txtUnitCost.Enabled = false;
            this.txtUnitCost.Lines = new string[0];
            this.txtUnitCost.Location = new System.Drawing.Point(171, 176);
            this.txtUnitCost.MaxLength = 32;
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.PasswordChar = '\0';
            this.txtUnitCost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnitCost.SelectedText = "";
            this.txtUnitCost.SelectionLength = 0;
            this.txtUnitCost.SelectionStart = 0;
            this.txtUnitCost.ShortcutsEnabled = true;
            this.txtUnitCost.Size = new System.Drawing.Size(109, 23);
            this.txtUnitCost.TabIndex = 112;
            this.txtUnitCost.UseSelectable = true;
            this.txtUnitCost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnitCost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(171, 154);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 113;
            this.metroLabel1.Text = "Unit Cost";
            // 
            // dtpRequest
            // 
            this.dtpRequest.Enabled = false;
            this.dtpRequest.Location = new System.Drawing.Point(313, 122);
            this.dtpRequest.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpRequest.Name = "dtpRequest";
            this.dtpRequest.Size = new System.Drawing.Size(200, 29);
            this.dtpRequest.TabIndex = 114;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(315, 97);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 19);
            this.metroLabel3.TabIndex = 115;
            this.metroLabel3.Text = "Date of Request";
            // 
            // FormRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 493);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dtpRequest);
            this.Controls.Add(this.txtUnitCost);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.txtFinQty);
            this.Controls.Add(this.lblFinQTY);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lvRawMaterialsUsed);
            this.Controls.Add(this.txtOldSrp);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnUpdate);
            this.Name = "FormRequest";
            this.Text = "Request for Production";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtFinQty;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroLabel lblFinQTY;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroListView lvRawMaterialsUsed;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroFramework.Controls.MetroTextBox txtOldSrp;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel lblDesc;
        private MetroFramework.Controls.MetroTextBox txtDesc;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnDecline;
        private MetroFramework.Controls.MetroTextBox txtUnitCost;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtpRequest;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}