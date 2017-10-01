namespace SIPO.Inventory
{
    partial class FormPanelFinishedUpdate
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
            this.lblQty = new MetroFramework.Controls.MetroLabel();
            this.btnAddUsedMaterial = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRawMaterialsUsed = new MetroFramework.Controls.MetroListView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.lvRawMaterials = new MetroFramework.Controls.MetroListView();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.lblDesc = new MetroFramework.Controls.MetroLabel();
            this.txtDesc = new MetroFramework.Controls.MetroTextBox();
            this.txtFinQty = new MetroFramework.Controls.MetroTextBox();
            this.lblFinQTY = new MetroFramework.Controls.MetroLabel();
            this.lbltotalQty = new MetroFramework.Controls.MetroLabel();
            this.lblprice = new MetroFramework.Controls.MetroLabel();
            this.lblSRP = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(20, 470);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(58, 19);
            this.lblQty.TabIndex = 87;
            this.lblQty.Text = "Quantity";
            // 
            // btnAddUsedMaterial
            // 
            this.btnAddUsedMaterial.Location = new System.Drawing.Point(19, 441);
            this.btnAddUsedMaterial.Name = "btnAddUsedMaterial";
            this.btnAddUsedMaterial.Size = new System.Drawing.Size(125, 23);
            this.btnAddUsedMaterial.TabIndex = 85;
            this.btnAddUsedMaterial.Text = "Add as Used Material";
            this.btnAddUsedMaterial.UseSelectable = true;
            this.btnAddUsedMaterial.Click += new System.EventHandler(this.btnAddUsedMaterial_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(406, 208);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(123, 19);
            this.metroLabel2.TabIndex = 84;
            this.metroLabel2.Text = "Used Raw Materials";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Qty";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // lvRawMaterialsUsed
            // 
            this.lvRawMaterialsUsed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.lvRawMaterialsUsed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvRawMaterialsUsed.FullRowSelect = true;
            this.lvRawMaterialsUsed.Location = new System.Drawing.Point(281, 230);
            this.lvRawMaterialsUsed.MultiSelect = false;
            this.lvRawMaterialsUsed.Name = "lvRawMaterialsUsed";
            this.lvRawMaterialsUsed.OwnerDraw = true;
            this.lvRawMaterialsUsed.Size = new System.Drawing.Size(249, 205);
            this.lvRawMaterialsUsed.TabIndex = 83;
            this.lvRawMaterialsUsed.UseCompatibleStateImageBehavior = false;
            this.lvRawMaterialsUsed.UseSelectable = true;
            this.lvRawMaterialsUsed.View = System.Windows.Forms.View.Details;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 208);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 82;
            this.metroLabel1.Text = "Raw Materials";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qty";
            this.columnHeader4.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 58;
            // 
            // txtQty
            // 
            // 
            // 
            // 
            this.txtQty.CustomButton.Image = null;
            this.txtQty.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtQty.CustomButton.Name = "";
            this.txtQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQty.CustomButton.TabIndex = 1;
            this.txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQty.CustomButton.UseSelectable = true;
            this.txtQty.CustomButton.Visible = false;
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(19, 492);
            this.txtQty.MaxLength = 32;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(163, 23);
            this.txtQty.TabIndex = 86;
            this.txtQty.UseSelectable = true;
            this.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // lvRawMaterials
            // 
            this.lvRawMaterials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.lvRawMaterials.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvRawMaterials.FullRowSelect = true;
            this.lvRawMaterials.Location = new System.Drawing.Point(20, 230);
            this.lvRawMaterials.MultiSelect = false;
            this.lvRawMaterials.Name = "lvRawMaterials";
            this.lvRawMaterials.OwnerDraw = true;
            this.lvRawMaterials.Size = new System.Drawing.Size(250, 205);
            this.lvRawMaterials.TabIndex = 81;
            this.lvRawMaterials.UseCompatibleStateImageBehavior = false;
            this.lvRawMaterials.UseSelectable = true;
            this.lvRawMaterials.View = System.Windows.Forms.View.Details;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(415, 492);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 24);
            this.btnUpdate.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnUpdate.TabIndex = 74;
            this.btnUpdate.Text = "Update Material";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 80;
            this.lblName.Text = "Name";
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
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(20, 86);
            this.txtName.MaxLength = 32;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(168, 23);
            this.txtName.TabIndex = 69;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(20, 112);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(74, 19);
            this.lblDesc.TabIndex = 71;
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
            this.txtDesc.Lines = new string[0];
            this.txtDesc.Location = new System.Drawing.Point(20, 134);
            this.txtDesc.MaxLength = 64;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(171, 23);
            this.txtDesc.TabIndex = 70;
            this.txtDesc.UseSelectable = true;
            this.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesc_KeyPress);
            // 
            // txtFinQty
            // 
            // 
            // 
            // 
            this.txtFinQty.CustomButton.Image = null;
            this.txtFinQty.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtFinQty.CustomButton.Name = "";
            this.txtFinQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFinQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFinQty.CustomButton.TabIndex = 1;
            this.txtFinQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFinQty.CustomButton.UseSelectable = true;
            this.txtFinQty.CustomButton.Visible = false;
            this.txtFinQty.Lines = new string[0];
            this.txtFinQty.Location = new System.Drawing.Point(20, 187);
            this.txtFinQty.MaxLength = 32;
            this.txtFinQty.Name = "txtFinQty";
            this.txtFinQty.PasswordChar = '\0';
            this.txtFinQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFinQty.SelectedText = "";
            this.txtFinQty.SelectionLength = 0;
            this.txtFinQty.SelectionStart = 0;
            this.txtFinQty.ShortcutsEnabled = true;
            this.txtFinQty.Size = new System.Drawing.Size(163, 23);
            this.txtFinQty.TabIndex = 90;
            this.txtFinQty.UseSelectable = true;
            this.txtFinQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFinQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFinQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinQty_KeyPress);
            // 
            // lblFinQTY
            // 
            this.lblFinQTY.AutoSize = true;
            this.lblFinQTY.Location = new System.Drawing.Point(20, 165);
            this.lblFinQTY.Name = "lblFinQTY";
            this.lblFinQTY.Size = new System.Drawing.Size(109, 19);
            this.lblFinQTY.TabIndex = 91;
            this.lblFinQTY.Text = "Finished Quantity";
            // 
            // lbltotalQty
            // 
            this.lbltotalQty.AutoSize = true;
            this.lbltotalQty.Location = new System.Drawing.Point(406, 445);
            this.lbltotalQty.Name = "lbltotalQty";
            this.lbltotalQty.Size = new System.Drawing.Size(75, 19);
            this.lbltotalQty.TabIndex = 93;
            this.lbltotalQty.Text = "Total Qty: 0";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(281, 445);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(76, 19);
            this.lblprice.TabIndex = 92;
            this.lblprice.Text = "Unit Cost: 0";
            // 
            // lblSRP
            // 
            this.lblSRP.AutoSize = true;
            this.lblSRP.Location = new System.Drawing.Point(311, 186);
            this.lblSRP.Name = "lblSRP";
            this.lblSRP.Size = new System.Drawing.Size(46, 19);
            this.lblSRP.TabIndex = 94;
            this.lblSRP.Text = "SRP: 0";
            // 
            // FormPanelFinishedUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 538);
            this.Controls.Add(this.lblSRP);
            this.Controls.Add(this.lbltotalQty);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.txtFinQty);
            this.Controls.Add(this.lblFinQTY);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnAddUsedMaterial);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lvRawMaterialsUsed);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lvRawMaterials);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDesc);
            this.Name = "FormPanelFinishedUpdate";
            this.Text = "Update Finished Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblQty;
        private MetroFramework.Controls.MetroButton btnAddUsedMaterial;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroListView lvRawMaterialsUsed;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MetroFramework.Controls.MetroTextBox txtQty;
        private MetroFramework.Controls.MetroListView lvRawMaterials;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel lblDesc;
        private MetroFramework.Controls.MetroTextBox txtDesc;
        private MetroFramework.Controls.MetroTextBox txtFinQty;
        private MetroFramework.Controls.MetroLabel lblFinQTY;
        private MetroFramework.Controls.MetroLabel lbltotalQty;
        private MetroFramework.Controls.MetroLabel lblprice;
        private MetroFramework.Controls.MetroLabel lblSRP;
    }
}