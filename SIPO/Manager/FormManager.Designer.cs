namespace SIPO.Manager
{
    partial class FormManager
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
            this.panelLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelLayoutManagement = new System.Windows.Forms.TableLayoutPanel();
            this.btnAccountManagement = new MetroFramework.Controls.MetroTile();
            this.btnClientManagement = new MetroFramework.Controls.MetroTile();
            this.panelLayoutAccountManagement = new System.Windows.Forms.TableLayoutPanel();
            this.btnAccountAdd = new MetroFramework.Controls.MetroTile();
            this.btnAccountUpdate = new MetroFramework.Controls.MetroTile();
            this.panelLayoutClientManagement = new System.Windows.Forms.TableLayoutPanel();
            this.btnClientAdd = new MetroFramework.Controls.MetroTile();
            this.btnClientUpdate = new MetroFramework.Controls.MetroTile();
            this.panelHolder = new System.Windows.Forms.Panel();
            this.panelLayoutMain.SuspendLayout();
            this.panelLayoutManagement.SuspendLayout();
            this.panelLayoutAccountManagement.SuspendLayout();
            this.panelLayoutClientManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLayoutMain
            // 
            this.panelLayoutMain.ColumnCount = 2;
            this.panelLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.panelLayoutMain.Controls.Add(this.panelLayoutManagement, 0, 0);
            this.panelLayoutMain.Controls.Add(this.panelHolder, 1, 0);
            this.panelLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLayoutMain.Location = new System.Drawing.Point(20, 60);
            this.panelLayoutMain.Name = "panelLayoutMain";
            this.panelLayoutMain.RowCount = 1;
            this.panelLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelLayoutMain.Size = new System.Drawing.Size(610, 295);
            this.panelLayoutMain.TabIndex = 2;
            // 
            // panelLayoutManagement
            // 
            this.panelLayoutManagement.ColumnCount = 2;
            this.panelLayoutManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutManagement.Controls.Add(this.btnAccountManagement, 0, 0);
            this.panelLayoutManagement.Controls.Add(this.btnClientManagement, 0, 1);
            this.panelLayoutManagement.Controls.Add(this.panelLayoutAccountManagement, 1, 0);
            this.panelLayoutManagement.Controls.Add(this.panelLayoutClientManagement, 1, 1);
            this.panelLayoutManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLayoutManagement.Location = new System.Drawing.Point(3, 3);
            this.panelLayoutManagement.Name = "panelLayoutManagement";
            this.panelLayoutManagement.RowCount = 2;
            this.panelLayoutManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutManagement.Size = new System.Drawing.Size(197, 289);
            this.panelLayoutManagement.TabIndex = 1;
            // 
            // btnAccountManagement
            // 
            this.btnAccountManagement.ActiveControl = null;
            this.btnAccountManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccountManagement.Location = new System.Drawing.Point(3, 6);
            this.btnAccountManagement.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnAccountManagement.Name = "btnAccountManagement";
            this.btnAccountManagement.Size = new System.Drawing.Size(92, 132);
            this.btnAccountManagement.TabIndex = 0;
            this.btnAccountManagement.Text = "Account";
            this.btnAccountManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccountManagement.TileImage = global::SIPO.Properties.Resources.icon_account;
            this.btnAccountManagement.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccountManagement.UseSelectable = true;
            this.btnAccountManagement.UseTileImage = true;
            // 
            // btnClientManagement
            // 
            this.btnClientManagement.ActiveControl = null;
            this.btnClientManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientManagement.Location = new System.Drawing.Point(3, 150);
            this.btnClientManagement.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnClientManagement.Name = "btnClientManagement";
            this.btnClientManagement.Size = new System.Drawing.Size(92, 133);
            this.btnClientManagement.TabIndex = 1;
            this.btnClientManagement.Text = "Client";
            this.btnClientManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientManagement.TileImage = global::SIPO.Properties.Resources.icon_manager;
            this.btnClientManagement.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientManagement.UseSelectable = true;
            this.btnClientManagement.UseTileImage = true;
            // 
            // panelLayoutAccountManagement
            // 
            this.panelLayoutAccountManagement.ColumnCount = 1;
            this.panelLayoutAccountManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutAccountManagement.Controls.Add(this.btnAccountAdd, 0, 0);
            this.panelLayoutAccountManagement.Controls.Add(this.btnAccountUpdate, 0, 1);
            this.panelLayoutAccountManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLayoutAccountManagement.Location = new System.Drawing.Point(101, 3);
            this.panelLayoutAccountManagement.Name = "panelLayoutAccountManagement";
            this.panelLayoutAccountManagement.RowCount = 2;
            this.panelLayoutAccountManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutAccountManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutAccountManagement.Size = new System.Drawing.Size(93, 138);
            this.panelLayoutAccountManagement.TabIndex = 2;
            // 
            // btnAccountAdd
            // 
            this.btnAccountAdd.ActiveControl = null;
            this.btnAccountAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccountAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAccountAdd.Name = "btnAccountAdd";
            this.btnAccountAdd.Size = new System.Drawing.Size(87, 63);
            this.btnAccountAdd.TabIndex = 0;
            this.btnAccountAdd.Text = "Add";
            this.btnAccountAdd.UseSelectable = true;
            this.btnAccountAdd.Click += new System.EventHandler(this.btnAccountAdd_Click);
            // 
            // btnAccountUpdate
            // 
            this.btnAccountUpdate.ActiveControl = null;
            this.btnAccountUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccountUpdate.Location = new System.Drawing.Point(3, 72);
            this.btnAccountUpdate.Name = "btnAccountUpdate";
            this.btnAccountUpdate.Size = new System.Drawing.Size(87, 63);
            this.btnAccountUpdate.TabIndex = 1;
            this.btnAccountUpdate.Text = "Update";
            this.btnAccountUpdate.UseSelectable = true;
            this.btnAccountUpdate.Click += new System.EventHandler(this.btnAccountUpdate_Click);
            // 
            // panelLayoutClientManagement
            // 
            this.panelLayoutClientManagement.ColumnCount = 1;
            this.panelLayoutClientManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutClientManagement.Controls.Add(this.btnClientAdd, 0, 0);
            this.panelLayoutClientManagement.Controls.Add(this.btnClientUpdate, 0, 1);
            this.panelLayoutClientManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLayoutClientManagement.Location = new System.Drawing.Point(101, 147);
            this.panelLayoutClientManagement.Name = "panelLayoutClientManagement";
            this.panelLayoutClientManagement.RowCount = 2;
            this.panelLayoutClientManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutClientManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutClientManagement.Size = new System.Drawing.Size(93, 139);
            this.panelLayoutClientManagement.TabIndex = 3;
            // 
            // btnClientAdd
            // 
            this.btnClientAdd.ActiveControl = null;
            this.btnClientAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientAdd.Location = new System.Drawing.Point(3, 3);
            this.btnClientAdd.Name = "btnClientAdd";
            this.btnClientAdd.Size = new System.Drawing.Size(87, 63);
            this.btnClientAdd.TabIndex = 0;
            this.btnClientAdd.Text = "Add";
            this.btnClientAdd.UseSelectable = true;
            this.btnClientAdd.Click += new System.EventHandler(this.btnClientAdd_Click);
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.ActiveControl = null;
            this.btnClientUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientUpdate.Location = new System.Drawing.Point(3, 72);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(87, 64);
            this.btnClientUpdate.TabIndex = 1;
            this.btnClientUpdate.Text = "Update";
            this.btnClientUpdate.UseSelectable = true;
            this.btnClientUpdate.Click += new System.EventHandler(this.btnClientUpdate_Click);
            // 
            // panelHolder
            // 
            this.panelHolder.AutoScroll = true;
            this.panelHolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHolder.Location = new System.Drawing.Point(203, 9);
            this.panelHolder.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.panelHolder.Name = "panelHolder";
            this.panelHolder.Padding = new System.Windows.Forms.Padding(20);
            this.panelHolder.Size = new System.Drawing.Size(407, 277);
            this.panelHolder.TabIndex = 2;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 375);
            this.Controls.Add(this.panelLayoutMain);
            this.Name = "FormManager";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.FormManager_SizeChanged);
            this.panelLayoutMain.ResumeLayout(false);
            this.panelLayoutManagement.ResumeLayout(false);
            this.panelLayoutAccountManagement.ResumeLayout(false);
            this.panelLayoutClientManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel panelLayoutMain;
        private System.Windows.Forms.TableLayoutPanel panelLayoutManagement;
        private MetroFramework.Controls.MetroTile btnAccountManagement;
        private MetroFramework.Controls.MetroTile btnClientManagement;
        private System.Windows.Forms.TableLayoutPanel panelLayoutAccountManagement;
        private MetroFramework.Controls.MetroTile btnAccountAdd;
        private MetroFramework.Controls.MetroTile btnAccountUpdate;
        private System.Windows.Forms.TableLayoutPanel panelLayoutClientManagement;
        private MetroFramework.Controls.MetroTile btnClientAdd;
        private MetroFramework.Controls.MetroTile btnClientUpdate;
        private System.Windows.Forms.Panel panelHolder;
    }
}