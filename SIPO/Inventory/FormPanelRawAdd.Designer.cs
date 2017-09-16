namespace SIPO.Inventory
{
    partial class FormPanelRawAdd
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
            this.panelLayoutRawAdd = new System.Windows.Forms.TableLayoutPanel();
            this.lblAccountAddTitle = new MetroFramework.Controls.MetroLabel();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtContact = new MetroFramework.Controls.MetroTextBox();
            this.txtReceived = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.lblReceived = new MetroFramework.Controls.MetroLabel();
            this.lblDesc = new MetroFramework.Controls.MetroLabel();
            this.txtSizeComp = new MetroFramework.Controls.MetroTextBox();
            this.lblSizeComp = new MetroFramework.Controls.MetroLabel();
            this.txtDesc = new MetroFramework.Controls.MetroTextBox();
            this.btnCreateAccount = new MetroFramework.Controls.MetroButton();
            this.btnClearFields = new MetroFramework.Controls.MetroButton();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.lblQty = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLayoutRawAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLayoutRawAdd
            // 
            this.panelLayoutRawAdd.ColumnCount = 5;
            this.panelLayoutRawAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelLayoutRawAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelLayoutRawAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelLayoutRawAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelLayoutRawAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelLayoutRawAdd.Controls.Add(this.lblAccountAddTitle, 0, 0);
            this.panelLayoutRawAdd.Controls.Add(this.lblID, 0, 1);
            this.panelLayoutRawAdd.Controls.Add(this.txtUsername, 0, 2);
            this.panelLayoutRawAdd.Controls.Add(this.txtContact, 1, 8);
            this.panelLayoutRawAdd.Controls.Add(this.txtReceived, 0, 8);
            this.panelLayoutRawAdd.Controls.Add(this.lblName, 0, 3);
            this.panelLayoutRawAdd.Controls.Add(this.txtName, 0, 4);
            this.panelLayoutRawAdd.Controls.Add(this.lblPrice, 1, 7);
            this.panelLayoutRawAdd.Controls.Add(this.lblReceived, 0, 7);
            this.panelLayoutRawAdd.Controls.Add(this.lblDesc, 0, 5);
            this.panelLayoutRawAdd.Controls.Add(this.txtQty, 2, 6);
            this.panelLayoutRawAdd.Controls.Add(this.lblQty, 2, 5);
            this.panelLayoutRawAdd.Controls.Add(this.txtSizeComp, 1, 6);
            this.panelLayoutRawAdd.Controls.Add(this.lblSizeComp, 1, 5);
            this.panelLayoutRawAdd.Controls.Add(this.txtDesc, 0, 6);
            this.panelLayoutRawAdd.Controls.Add(this.btnCreateAccount, 3, 11);
            this.panelLayoutRawAdd.Controls.Add(this.btnClearFields, 4, 11);
            this.panelLayoutRawAdd.Controls.Add(this.panel1, 4, 0);
            this.panelLayoutRawAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLayoutRawAdd.Location = new System.Drawing.Point(0, 0);
            this.panelLayoutRawAdd.Name = "panelLayoutRawAdd";
            this.panelLayoutRawAdd.RowCount = 12;
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
            this.panelLayoutRawAdd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLayoutRawAdd.Size = new System.Drawing.Size(754, 315);
            this.panelLayoutRawAdd.TabIndex = 55;
            // 
            // lblAccountAddTitle
            // 
            this.lblAccountAddTitle.AutoSize = true;
            this.lblAccountAddTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccountAddTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAccountAddTitle.Location = new System.Drawing.Point(3, 0);
            this.lblAccountAddTitle.Name = "lblAccountAddTitle";
            this.lblAccountAddTitle.Size = new System.Drawing.Size(149, 25);
            this.lblAccountAddTitle.TabIndex = 39;
            this.lblAccountAddTitle.Text = "Add New Account";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblID.Location = new System.Drawing.Point(3, 57);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(149, 19);
            this.lblID.TabIndex = 29;
            this.lblID.Text = "Raw materal ID";
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(3, 79);
            this.txtUsername.MaxLength = 32;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(149, 23);
            this.txtUsername.TabIndex = 30;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContact
            // 
            // 
            // 
            // 
            this.txtContact.CustomButton.Image = null;
            this.txtContact.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtContact.CustomButton.Name = "";
            this.txtContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContact.CustomButton.TabIndex = 1;
            this.txtContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContact.CustomButton.UseSelectable = true;
            this.txtContact.CustomButton.Visible = false;
            this.txtContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtContact.Lines = new string[0];
            this.txtContact.Location = new System.Drawing.Point(158, 223);
            this.txtContact.MaxLength = 13;
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContact.SelectedText = "";
            this.txtContact.SelectionLength = 0;
            this.txtContact.SelectionStart = 0;
            this.txtContact.ShortcutsEnabled = true;
            this.txtContact.Size = new System.Drawing.Size(144, 23);
            this.txtContact.TabIndex = 45;
            this.txtContact.UseSelectable = true;
            this.txtContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtReceived
            // 
            // 
            // 
            // 
            this.txtReceived.CustomButton.Image = null;
            this.txtReceived.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtReceived.CustomButton.Name = "";
            this.txtReceived.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReceived.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReceived.CustomButton.TabIndex = 1;
            this.txtReceived.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReceived.CustomButton.UseSelectable = true;
            this.txtReceived.CustomButton.Visible = false;
            this.txtReceived.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReceived.Lines = new string[0];
            this.txtReceived.Location = new System.Drawing.Point(3, 223);
            this.txtReceived.MaxLength = 255;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.PasswordChar = '\0';
            this.txtReceived.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReceived.SelectedText = "";
            this.txtReceived.SelectionLength = 0;
            this.txtReceived.SelectionStart = 0;
            this.txtReceived.ShortcutsEnabled = true;
            this.txtReceived.Size = new System.Drawing.Size(149, 23);
            this.txtReceived.TabIndex = 43;
            this.txtReceived.UseSelectable = true;
            this.txtReceived.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReceived.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Location = new System.Drawing.Point(3, 105);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 19);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Type or Name";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(3, 127);
            this.txtName.MaxLength = 32;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(149, 23);
            this.txtName.TabIndex = 31;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrice.Location = new System.Drawing.Point(158, 201);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(144, 19);
            this.lblPrice.TabIndex = 44;
            this.lblPrice.Text = "Mag Kano BILI ? HAHA";
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceived.Location = new System.Drawing.Point(3, 201);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(149, 19);
            this.lblReceived.TabIndex = 42;
            this.lblReceived.Text = "Received Date";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDesc.Location = new System.Drawing.Point(3, 153);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(149, 19);
            this.lblDesc.TabIndex = 39;
            this.lblDesc.Text = "Description";
            // 
            // txtSizeComp
            // 
            // 
            // 
            // 
            this.txtSizeComp.CustomButton.Image = null;
            this.txtSizeComp.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtSizeComp.CustomButton.Name = "";
            this.txtSizeComp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSizeComp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSizeComp.CustomButton.TabIndex = 1;
            this.txtSizeComp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSizeComp.CustomButton.UseSelectable = true;
            this.txtSizeComp.CustomButton.Visible = false;
            this.txtSizeComp.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSizeComp.Lines = new string[0];
            this.txtSizeComp.Location = new System.Drawing.Point(158, 175);
            this.txtSizeComp.MaxLength = 32;
            this.txtSizeComp.Name = "txtSizeComp";
            this.txtSizeComp.PasswordChar = '\0';
            this.txtSizeComp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSizeComp.SelectedText = "";
            this.txtSizeComp.SelectionLength = 0;
            this.txtSizeComp.SelectionStart = 0;
            this.txtSizeComp.ShortcutsEnabled = true;
            this.txtSizeComp.Size = new System.Drawing.Size(144, 23);
            this.txtSizeComp.TabIndex = 35;
            this.txtSizeComp.UseSelectable = true;
            this.txtSizeComp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSizeComp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSizeComp
            // 
            this.lblSizeComp.AutoSize = true;
            this.lblSizeComp.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSizeComp.Location = new System.Drawing.Point(158, 153);
            this.lblSizeComp.Name = "lblSizeComp";
            this.lblSizeComp.Size = new System.Drawing.Size(144, 19);
            this.lblSizeComp.TabIndex = 40;
            this.lblSizeComp.Text = "Size Computation";
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.CustomButton.Image = null;
            this.txtDesc.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtDesc.CustomButton.Name = "";
            this.txtDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc.CustomButton.TabIndex = 1;
            this.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc.CustomButton.UseSelectable = true;
            this.txtDesc.CustomButton.Visible = false;
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDesc.Lines = new string[0];
            this.txtDesc.Location = new System.Drawing.Point(3, 175);
            this.txtDesc.MaxLength = 64;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(149, 23);
            this.txtDesc.TabIndex = 34;
            this.txtDesc.UseSelectable = true;
            this.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateAccount.Location = new System.Drawing.Point(458, 252);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(144, 24);
            this.btnCreateAccount.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCreateAccount.TabIndex = 52;
            this.btnCreateAccount.Text = "Add Material";
            this.btnCreateAccount.UseSelectable = true;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearFields.Location = new System.Drawing.Point(608, 252);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(146, 24);
            this.btnClearFields.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnClearFields.TabIndex = 53;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseSelectable = true;
            // 
            // txtQty
            // 
            // 
            // 
            // 
            this.txtQty.CustomButton.Image = null;
            this.txtQty.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtQty.CustomButton.Name = "";
            this.txtQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQty.CustomButton.TabIndex = 1;
            this.txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQty.CustomButton.UseSelectable = true;
            this.txtQty.CustomButton.Visible = false;
            this.txtQty.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(308, 175);
            this.txtQty.MaxLength = 32;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(144, 23);
            this.txtQty.TabIndex = 37;
            this.txtQty.UseSelectable = true;
            this.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQty.Location = new System.Drawing.Point(308, 153);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(144, 19);
            this.lblQty.TabIndex = 41;
            this.lblQty.Text = "Quantity";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(608, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 51);
            this.panel1.TabIndex = 54;
            // 
            // FormPanelRawAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 315);
            this.Controls.Add(this.panelLayoutRawAdd);
            this.Name = "FormPanelRawAdd";
            this.Text = "Add Raw Materials";
            this.panelLayoutRawAdd.ResumeLayout(false);
            this.panelLayoutRawAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelLayoutRawAdd;
        private MetroFramework.Controls.MetroLabel lblAccountAddTitle;
        private MetroFramework.Controls.MetroLabel lblID;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtContact;
        private MetroFramework.Controls.MetroTextBox txtReceived;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroLabel lblReceived;
        private MetroFramework.Controls.MetroLabel lblDesc;
        private MetroFramework.Controls.MetroTextBox txtSizeComp;
        private MetroFramework.Controls.MetroLabel lblSizeComp;
        private MetroFramework.Controls.MetroTextBox txtDesc;
        private MetroFramework.Controls.MetroButton btnCreateAccount;
        private MetroFramework.Controls.MetroButton btnClearFields;
        private MetroFramework.Controls.MetroTextBox txtQty;
        private MetroFramework.Controls.MetroLabel lblQty;
        private System.Windows.Forms.Panel panel1;
    }
}