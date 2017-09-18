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
            this.panelLayoutFinishAdd = new System.Windows.Forms.TableLayoutPanel();
            this.lblAccountAddTitle = new MetroFramework.Controls.MetroLabel();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.lblDesc = new MetroFramework.Controls.MetroLabel();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.lblQty = new MetroFramework.Controls.MetroLabel();
            this.txtRawUsed = new MetroFramework.Controls.MetroTextBox();
            this.lblRawUsed = new MetroFramework.Controls.MetroLabel();
            this.txtDesc = new MetroFramework.Controls.MetroTextBox();
            this.btnClearFields = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.panelLayoutFinishAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLayoutFinishAdd
            // 
            this.panelLayoutFinishAdd.ColumnCount = 4;
            this.panelLayoutFinishAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelLayoutFinishAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelLayoutFinishAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelLayoutFinishAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelLayoutFinishAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelLayoutFinishAdd.Controls.Add(this.lblAccountAddTitle, 0, 0);
            this.panelLayoutFinishAdd.Controls.Add(this.lblID, 0, 1);
            this.panelLayoutFinishAdd.Controls.Add(this.txtID, 0, 2);
            this.panelLayoutFinishAdd.Controls.Add(this.txtPrice, 0, 8);
            this.panelLayoutFinishAdd.Controls.Add(this.lblName, 0, 3);
            this.panelLayoutFinishAdd.Controls.Add(this.txtName, 0, 4);
            this.panelLayoutFinishAdd.Controls.Add(this.lblPrice, 0, 7);
            this.panelLayoutFinishAdd.Controls.Add(this.lblDesc, 0, 5);
            this.panelLayoutFinishAdd.Controls.Add(this.txtQty, 2, 6);
            this.panelLayoutFinishAdd.Controls.Add(this.lblQty, 2, 5);
            this.panelLayoutFinishAdd.Controls.Add(this.txtRawUsed, 1, 6);
            this.panelLayoutFinishAdd.Controls.Add(this.lblRawUsed, 1, 5);
            this.panelLayoutFinishAdd.Controls.Add(this.txtDesc, 0, 6);
            this.panelLayoutFinishAdd.Controls.Add(this.btnClearFields, 2, 14);
            this.panelLayoutFinishAdd.Controls.Add(this.btnAdd, 1, 14);
            this.panelLayoutFinishAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLayoutFinishAdd.Location = new System.Drawing.Point(0, 0);
            this.panelLayoutFinishAdd.Name = "panelLayoutFinishAdd";
            this.panelLayoutFinishAdd.RowCount = 15;
            this.panelLayoutFinishAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutFinishAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutFinishAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutFinishAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutFinishAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutFinishAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutFinishAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutFinishAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutFinishAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutFinishAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutFinishAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutFinishAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutFinishAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelLayoutFinishAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelLayoutFinishAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelLayoutFinishAdd.Size = new System.Drawing.Size(500, 310);
            this.panelLayoutFinishAdd.TabIndex = 56;
            // 
            // lblAccountAddTitle
            // 
            this.lblAccountAddTitle.AutoSize = true;
            this.lblAccountAddTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccountAddTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAccountAddTitle.Location = new System.Drawing.Point(3, 0);
            this.lblAccountAddTitle.Name = "lblAccountAddTitle";
            this.lblAccountAddTitle.Size = new System.Drawing.Size(171, 25);
            this.lblAccountAddTitle.TabIndex = 39;
            this.lblAccountAddTitle.Text = "AddFinished Material";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblID.Location = new System.Drawing.Point(3, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(171, 19);
            this.lblID.TabIndex = 29;
            this.lblID.Text = "Finished product ID";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(3, 47);
            this.txtID.MaxLength = 32;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(171, 23);
            this.txtID.TabIndex = 30;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(3, 191);
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
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Location = new System.Drawing.Point(3, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(171, 19);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(3, 95);
            this.txtName.MaxLength = 32;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(171, 23);
            this.txtName.TabIndex = 31;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrice.Location = new System.Drawing.Point(3, 169);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(171, 19);
            this.lblPrice.TabIndex = 42;
            this.lblPrice.Text = "Estimated Price/SRP";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDesc.Location = new System.Drawing.Point(3, 121);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(171, 19);
            this.lblDesc.TabIndex = 39;
            this.lblDesc.Text = "Description";
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
            this.txtQty.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(330, 143);
            this.txtQty.MaxLength = 32;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(163, 23);
            this.txtQty.TabIndex = 37;
            this.txtQty.UseSelectable = true;
            this.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQty.Location = new System.Drawing.Point(330, 121);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(163, 19);
            this.lblQty.TabIndex = 41;
            this.lblQty.Text = "Quantity";
            // 
            // txtRawUsed
            // 
            // 
            // 
            // 
            this.txtRawUsed.CustomButton.Image = null;
            this.txtRawUsed.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtRawUsed.CustomButton.Name = "";
            this.txtRawUsed.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRawUsed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRawUsed.CustomButton.TabIndex = 1;
            this.txtRawUsed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRawUsed.CustomButton.UseSelectable = true;
            this.txtRawUsed.CustomButton.Visible = false;
            this.txtRawUsed.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRawUsed.Lines = new string[0];
            this.txtRawUsed.Location = new System.Drawing.Point(180, 143);
            this.txtRawUsed.MaxLength = 32;
            this.txtRawUsed.Name = "txtRawUsed";
            this.txtRawUsed.PasswordChar = '\0';
            this.txtRawUsed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRawUsed.SelectedText = "";
            this.txtRawUsed.SelectionLength = 0;
            this.txtRawUsed.SelectionStart = 0;
            this.txtRawUsed.ShortcutsEnabled = true;
            this.txtRawUsed.Size = new System.Drawing.Size(144, 23);
            this.txtRawUsed.TabIndex = 35;
            this.txtRawUsed.UseSelectable = true;
            this.txtRawUsed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRawUsed.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblRawUsed
            // 
            this.lblRawUsed.AutoSize = true;
            this.lblRawUsed.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRawUsed.Location = new System.Drawing.Point(180, 121);
            this.lblRawUsed.Name = "lblRawUsed";
            this.lblRawUsed.Size = new System.Drawing.Size(144, 19);
            this.lblRawUsed.TabIndex = 40;
            this.lblRawUsed.Text = "Raw Material Used";
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
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDesc.Lines = new string[0];
            this.txtDesc.Location = new System.Drawing.Point(3, 143);
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
            // 
            // btnClearFields
            // 
            this.btnClearFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearFields.Location = new System.Drawing.Point(330, 260);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(163, 24);
            this.btnClearFields.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnClearFields.TabIndex = 53;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseSelectable = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(180, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 24);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add Material";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormPanelFinishAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 310);
            this.Controls.Add(this.panelLayoutFinishAdd);
            this.Name = "FormPanelFinishAdd";
            this.Text = "FormPanelFinishAdd";
            this.panelLayoutFinishAdd.ResumeLayout(false);
            this.panelLayoutFinishAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelLayoutFinishAdd;
        private MetroFramework.Controls.MetroLabel lblAccountAddTitle;
        private MetroFramework.Controls.MetroLabel lblID;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroLabel lblDesc;
        private MetroFramework.Controls.MetroTextBox txtQty;
        private MetroFramework.Controls.MetroLabel lblQty;
        private MetroFramework.Controls.MetroTextBox txtRawUsed;
        private MetroFramework.Controls.MetroLabel lblRawUsed;
        private MetroFramework.Controls.MetroTextBox txtDesc;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnClearFields;
    }
}