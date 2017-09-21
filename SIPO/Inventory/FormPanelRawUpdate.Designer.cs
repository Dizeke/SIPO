namespace SIPO.Inventory
{
    partial class FormPanelRawUpdate
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
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.lblReceived = new MetroFramework.Controls.MetroLabel();
            this.lblDesc = new MetroFramework.Controls.MetroLabel();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.lblQty = new MetroFramework.Controls.MetroLabel();
            this.txtDesc = new MetroFramework.Controls.MetroTextBox();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnClearFields = new MetroFramework.Controls.MetroButton();
            this.panelLayoutRawAdd = new System.Windows.Forms.TableLayoutPanel();
            this.dtpReceived = new MetroFramework.Controls.MetroDateTime();
            this.dtpNew = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblNewPrice = new MetroFramework.Controls.MetroLabel();
            this.txtNewPrice = new MetroFramework.Controls.MetroTextBox();
            this.panelLayoutRawAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(209, 118);
            this.txtPrice.MaxLength = 13;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(184, 23);
            this.txtPrice.TabIndex = 45;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(200, 19);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Type or Name";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(3, 22);
            this.txtName.MaxLength = 32;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 31;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrice.Location = new System.Drawing.Point(209, 96);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(184, 19);
            this.lblPrice.TabIndex = 44;
            this.lblPrice.Text = "Old Price";
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceived.Location = new System.Drawing.Point(3, 96);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(200, 19);
            this.lblReceived.TabIndex = 42;
            this.lblReceived.Text = "Old Received Date";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDesc.Location = new System.Drawing.Point(3, 48);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(200, 19);
            this.lblDesc.TabIndex = 39;
            this.lblDesc.Text = "Description";
            // 
            // txtQty
            // 
            // 
            // 
            // 
            this.txtQty.CustomButton.Image = null;
            this.txtQty.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txtQty.CustomButton.Name = "";
            this.txtQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQty.CustomButton.TabIndex = 1;
            this.txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQty.CustomButton.UseSelectable = true;
            this.txtQty.CustomButton.Visible = false;
            this.txtQty.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(399, 70);
            this.txtQty.MaxLength = 32;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(252, 23);
            this.txtQty.TabIndex = 37;
            this.txtQty.UseSelectable = true;
            this.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQty.Location = new System.Drawing.Point(399, 48);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(252, 19);
            this.lblQty.TabIndex = 41;
            this.lblQty.Text = "Quantity";
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.CustomButton.Image = null;
            this.txtDesc.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtDesc.CustomButton.Name = "";
            this.txtDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc.CustomButton.TabIndex = 1;
            this.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc.CustomButton.UseSelectable = true;
            this.txtDesc.CustomButton.Visible = false;
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDesc.Lines = new string[0];
            this.txtDesc.Location = new System.Drawing.Point(3, 70);
            this.txtDesc.MaxLength = 64;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(200, 23);
            this.txtDesc.TabIndex = 34;
            this.txtDesc.UseSelectable = true;
            this.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.Location = new System.Drawing.Point(209, 239);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 24);
            this.btnUpdate.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "Update Material";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearFields.Location = new System.Drawing.Point(399, 239);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(252, 24);
            this.btnClearFields.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnClearFields.TabIndex = 53;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseSelectable = true;
            // 
            // panelLayoutRawAdd
            // 
            this.panelLayoutRawAdd.ColumnCount = 3;
            this.panelLayoutRawAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelLayoutRawAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelLayoutRawAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelLayoutRawAdd.Controls.Add(this.txtPrice, 1, 8);
            this.panelLayoutRawAdd.Controls.Add(this.lblName, 0, 3);
            this.panelLayoutRawAdd.Controls.Add(this.txtName, 0, 4);
            this.panelLayoutRawAdd.Controls.Add(this.lblPrice, 1, 7);
            this.panelLayoutRawAdd.Controls.Add(this.lblReceived, 0, 7);
            this.panelLayoutRawAdd.Controls.Add(this.lblDesc, 0, 5);
            this.panelLayoutRawAdd.Controls.Add(this.txtQty, 2, 6);
            this.panelLayoutRawAdd.Controls.Add(this.lblQty, 2, 5);
            this.panelLayoutRawAdd.Controls.Add(this.txtDesc, 0, 6);
            this.panelLayoutRawAdd.Controls.Add(this.dtpReceived, 0, 8);
            this.panelLayoutRawAdd.Controls.Add(this.dtpNew, 0, 12);
            this.panelLayoutRawAdd.Controls.Add(this.btnUpdate, 1, 15);
            this.panelLayoutRawAdd.Controls.Add(this.btnClearFields, 2, 15);
            this.panelLayoutRawAdd.Controls.Add(this.metroLabel1, 0, 11);
            this.panelLayoutRawAdd.Controls.Add(this.lblNewPrice, 1, 11);
            this.panelLayoutRawAdd.Controls.Add(this.txtNewPrice, 1, 12);
            this.panelLayoutRawAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLayoutRawAdd.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelLayoutRawAdd.Location = new System.Drawing.Point(20, 60);
            this.panelLayoutRawAdd.Name = "panelLayoutRawAdd";
            this.panelLayoutRawAdd.RowCount = 16;
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelLayoutRawAdd.Size = new System.Drawing.Size(639, 284);
            this.panelLayoutRawAdd.TabIndex = 56;
            // 
            // dtpReceived
            // 
            this.dtpReceived.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpReceived.Enabled = false;
            this.dtpReceived.Location = new System.Drawing.Point(3, 118);
            this.dtpReceived.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpReceived.Name = "dtpReceived";
            this.dtpReceived.Size = new System.Drawing.Size(200, 29);
            this.dtpReceived.TabIndex = 54;
            // 
            // dtpNew
            // 
            this.dtpNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpNew.Location = new System.Drawing.Point(3, 178);
            this.dtpNew.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpNew.Name = "dtpNew";
            this.dtpNew.Size = new System.Drawing.Size(200, 29);
            this.dtpNew.TabIndex = 55;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel1.Location = new System.Drawing.Point(3, 150);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(200, 19);
            this.metroLabel1.TabIndex = 56;
            this.metroLabel1.Text = "New Received Date";
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNewPrice.Location = new System.Drawing.Point(209, 150);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(184, 19);
            this.lblNewPrice.TabIndex = 57;
            this.lblNewPrice.Text = "New Price";
            // 
            // txtNewPrice
            // 
            // 
            // 
            // 
            this.txtNewPrice.CustomButton.Image = null;
            this.txtNewPrice.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtNewPrice.CustomButton.Name = "";
            this.txtNewPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPrice.CustomButton.TabIndex = 1;
            this.txtNewPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPrice.CustomButton.UseSelectable = true;
            this.txtNewPrice.CustomButton.Visible = false;
            this.txtNewPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNewPrice.Lines = new string[0];
            this.txtNewPrice.Location = new System.Drawing.Point(209, 178);
            this.txtNewPrice.MaxLength = 32767;
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.PasswordChar = '\0';
            this.txtNewPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPrice.SelectedText = "";
            this.txtNewPrice.SelectionLength = 0;
            this.txtNewPrice.SelectionStart = 0;
            this.txtNewPrice.ShortcutsEnabled = true;
            this.txtNewPrice.Size = new System.Drawing.Size(184, 23);
            this.txtNewPrice.TabIndex = 58;
            this.txtNewPrice.UseSelectable = true;
            this.txtNewPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormPanelRawUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 364);
            this.Controls.Add(this.panelLayoutRawAdd);
            this.Name = "FormPanelRawUpdate";
            this.Text = "Update Raw Materials";
            this.panelLayoutRawAdd.ResumeLayout(false);
            this.panelLayoutRawAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroLabel lblReceived;
        private MetroFramework.Controls.MetroLabel lblDesc;
        private MetroFramework.Controls.MetroTextBox txtQty;
        private MetroFramework.Controls.MetroLabel lblQty;
        private MetroFramework.Controls.MetroTextBox txtDesc;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnClearFields;
        private System.Windows.Forms.TableLayoutPanel panelLayoutRawAdd;
        private MetroFramework.Controls.MetroDateTime dtpReceived;
        private MetroFramework.Controls.MetroDateTime dtpNew;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblNewPrice;
        private MetroFramework.Controls.MetroTextBox txtNewPrice;
    }
}