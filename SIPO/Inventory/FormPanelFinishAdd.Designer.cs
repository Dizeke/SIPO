namespace SIPO.Inventory
{
    partial class FormPanelFinishAdd
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
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.lblDesc = new MetroFramework.Controls.MetroLabel();
            this.txtDesc = new MetroFramework.Controls.MetroTextBox();
            this.btnClearFields = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.txtFinQty = new MetroFramework.Controls.MetroTextBox();
            this.lblFinQTY = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lvRawMaterials = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lvRawMaterialsUsed = new MetroFramework.Controls.MetroListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAddUsedMaterial = new MetroFramework.Controls.MetroButton();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.lblQty = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(12, 166);
            this.txtPrice.MaxLength = 255;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(171, 23);
            this.txtPrice.TabIndex = 43;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(12, 70);
            this.txtName.MaxLength = 32;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(150, 23);
            this.txtName.TabIndex = 31;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 144);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(127, 19);
            this.lblPrice.TabIndex = 42;
            this.lblPrice.Text = "Estimated Price/SRP";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(12, 96);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(74, 19);
            this.lblDesc.TabIndex = 39;
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
            this.txtDesc.Location = new System.Drawing.Point(12, 118);
            this.txtDesc.MaxLength = 64;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(171, 23);
            this.txtDesc.TabIndex = 34;
            this.txtDesc.UseSelectable = true;
            this.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesc_KeyPress);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(403, 425);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(119, 24);
            this.btnClearFields.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnClearFields.TabIndex = 53;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseSelectable = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(273, 425);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 24);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add Material";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.txtFinQty.Location = new System.Drawing.Point(189, 166);
            this.txtFinQty.MaxLength = 32;
            this.txtFinQty.Name = "txtFinQty";
            this.txtFinQty.PasswordChar = '\0';
            this.txtFinQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFinQty.SelectedText = "";
            this.txtFinQty.SelectionLength = 0;
            this.txtFinQty.SelectionStart = 0;
            this.txtFinQty.ShortcutsEnabled = true;
            this.txtFinQty.Size = new System.Drawing.Size(163, 23);
            this.txtFinQty.TabIndex = 54;
            this.txtFinQty.UseSelectable = true;
            this.txtFinQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFinQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFinQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinQty_KeyPress);
            // 
            // lblFinQTY
            // 
            this.lblFinQTY.AutoSize = true;
            this.lblFinQTY.Location = new System.Drawing.Point(189, 144);
            this.lblFinQTY.Name = "lblFinQTY";
            this.lblFinQTY.Size = new System.Drawing.Size(109, 19);
            this.lblFinQTY.TabIndex = 55;
            this.lblFinQTY.Text = "Finished Quantity";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 61;
            this.lblName.Text = "Name";
            // 
            // lvRawMaterials
            // 
            this.lvRawMaterials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.lvRawMaterials.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvRawMaterials.FullRowSelect = true;
            this.lvRawMaterials.Location = new System.Drawing.Point(12, 214);
            this.lvRawMaterials.MultiSelect = false;
            this.lvRawMaterials.Name = "lvRawMaterials";
            this.lvRawMaterials.OwnerDraw = true;
            this.lvRawMaterials.Size = new System.Drawing.Size(250, 205);
            this.lvRawMaterials.TabIndex = 62;
            this.lvRawMaterials.UseCompatibleStateImageBehavior = false;
            this.lvRawMaterials.UseSelectable = true;
            this.lvRawMaterials.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 58;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qty";
            this.columnHeader4.Width = 71;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 192);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 63;
            this.metroLabel1.Text = "Raw Materials";
            // 
            // lvRawMaterialsUsed
            // 
            this.lvRawMaterialsUsed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.lvRawMaterialsUsed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvRawMaterialsUsed.FullRowSelect = true;
            this.lvRawMaterialsUsed.Location = new System.Drawing.Point(273, 214);
            this.lvRawMaterialsUsed.MultiSelect = false;
            this.lvRawMaterialsUsed.Name = "lvRawMaterialsUsed";
            this.lvRawMaterialsUsed.OwnerDraw = true;
            this.lvRawMaterialsUsed.Size = new System.Drawing.Size(249, 205);
            this.lvRawMaterialsUsed.TabIndex = 64;
            this.lvRawMaterialsUsed.UseCompatibleStateImageBehavior = false;
            this.lvRawMaterialsUsed.UseSelectable = true;
            this.lvRawMaterialsUsed.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Qty";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(398, 192);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(123, 19);
            this.metroLabel2.TabIndex = 65;
            this.metroLabel2.Text = "Used Raw Materials";
            // 
            // btnAddUsedMaterial
            // 
            this.btnAddUsedMaterial.Location = new System.Drawing.Point(11, 425);
            this.btnAddUsedMaterial.Name = "btnAddUsedMaterial";
            this.btnAddUsedMaterial.Size = new System.Drawing.Size(125, 23);
            this.btnAddUsedMaterial.TabIndex = 66;
            this.btnAddUsedMaterial.Text = "Add as Used Material";
            this.btnAddUsedMaterial.UseSelectable = true;
            this.btnAddUsedMaterial.Click += new System.EventHandler(this.btnAddUsedMaterial_Click);
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
            this.txtQty.Location = new System.Drawing.Point(11, 476);
            this.txtQty.MaxLength = 32;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(163, 23);
            this.txtQty.TabIndex = 67;
            this.txtQty.UseSelectable = true;
            this.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(12, 454);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(58, 19);
            this.lblQty.TabIndex = 68;
            this.lblQty.Text = "Quantity";
            // 
            // FormPanelFinishAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 522);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnAddUsedMaterial);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lvRawMaterialsUsed);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lvRawMaterials);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtFinQty);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblFinQTY);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDesc);
            this.Name = "FormPanelFinishAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Add Finished Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroLabel lblDesc;
        private MetroFramework.Controls.MetroTextBox txtDesc;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnClearFields;
        private MetroFramework.Controls.MetroTextBox txtFinQty;
        private MetroFramework.Controls.MetroLabel lblFinQTY;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroListView lvRawMaterials;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroListView lvRawMaterialsUsed;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnAddUsedMaterial;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroFramework.Controls.MetroTextBox txtQty;
        private MetroFramework.Controls.MetroLabel lblQty;
    }
}