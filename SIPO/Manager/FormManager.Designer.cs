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
            this.panelLayoutReports = new System.Windows.Forms.TableLayoutPanel();
            this.btnRawMaterials = new MetroFramework.Controls.MetroTile();
            this.btnFinishedProducts = new MetroFramework.Controls.MetroTile();
            this.btnPurchaseOrders = new MetroFramework.Controls.MetroTile();
            this.btnPayments = new MetroFramework.Controls.MetroTile();
            this.btnPackages = new MetroFramework.Controls.MetroTile();
            this.panelLayoutMain.SuspendLayout();
            this.panelLayoutManagement.SuspendLayout();
            this.panelLayoutAccountManagement.SuspendLayout();
            this.panelLayoutClientManagement.SuspendLayout();
            this.panelLayoutReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLayoutMain
            // 
            this.panelLayoutMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLayoutMain.ColumnCount = 2;
            this.panelLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.panelLayoutMain.Controls.Add(this.panelLayoutManagement, 0, 0);
            this.panelLayoutMain.Controls.Add(this.panelHolder, 1, 0);
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
            this.btnAccountAdd.Text = "Create";
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
            this.btnClientAdd.Text = "Create";
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
            // panelLayoutReports
            // 
            this.panelLayoutReports.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.panelLayoutReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLayoutReports.ColumnCount = 6;
            this.panelLayoutReports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelLayoutReports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelLayoutReports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelLayoutReports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelLayoutReports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelLayoutReports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelLayoutReports.Controls.Add(this.btnPackages, 4, 0);
            this.panelLayoutReports.Controls.Add(this.btnPayments, 3, 0);
            this.panelLayoutReports.Controls.Add(this.btnPurchaseOrders, 2, 0);
            this.panelLayoutReports.Controls.Add(this.btnFinishedProducts, 1, 0);
            this.panelLayoutReports.Controls.Add(this.btnRawMaterials, 0, 0);
            this.panelLayoutReports.Location = new System.Drawing.Point(20, 361);
            this.panelLayoutReports.Name = "panelLayoutReports";
            this.panelLayoutReports.RowCount = 1;
            this.panelLayoutReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelLayoutReports.Size = new System.Drawing.Size(610, 116);
            this.panelLayoutReports.TabIndex = 3;
            // 
            // btnRawMaterials
            // 
            this.btnRawMaterials.ActiveControl = null;
            this.btnRawMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRawMaterials.Location = new System.Drawing.Point(3, 3);
            this.btnRawMaterials.Name = "btnRawMaterials";
            this.btnRawMaterials.Size = new System.Drawing.Size(95, 110);
            this.btnRawMaterials.TabIndex = 0;
            this.btnRawMaterials.Text = "Raw Materials";
            this.btnRawMaterials.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRawMaterials.TileImage = global::SIPO.Properties.Resources.icon_raw_product;
            this.btnRawMaterials.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRawMaterials.UseSelectable = true;
            this.btnRawMaterials.UseTileImage = true;
            this.btnRawMaterials.Click += new System.EventHandler(this.btnRawMaterials_Click);
            // 
            // btnFinishedProducts
            // 
            this.btnFinishedProducts.ActiveControl = null;
            this.btnFinishedProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinishedProducts.Location = new System.Drawing.Point(104, 3);
            this.btnFinishedProducts.Name = "btnFinishedProducts";
            this.btnFinishedProducts.Size = new System.Drawing.Size(95, 110);
            this.btnFinishedProducts.TabIndex = 1;
            this.btnFinishedProducts.Text = "Finishe Products";
            this.btnFinishedProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinishedProducts.TileImage = global::SIPO.Properties.Resources.icon_finished_product;
            this.btnFinishedProducts.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinishedProducts.UseSelectable = true;
            this.btnFinishedProducts.UseTileImage = true;
            this.btnFinishedProducts.Click += new System.EventHandler(this.btnFinishedProducts_Click);
            // 
            // btnPurchaseOrders
            // 
            this.btnPurchaseOrders.ActiveControl = null;
            this.btnPurchaseOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPurchaseOrders.Location = new System.Drawing.Point(205, 3);
            this.btnPurchaseOrders.Name = "btnPurchaseOrders";
            this.btnPurchaseOrders.Size = new System.Drawing.Size(95, 110);
            this.btnPurchaseOrders.TabIndex = 2;
            this.btnPurchaseOrders.Text = "Purchase Orders";
            this.btnPurchaseOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPurchaseOrders.TileImage = global::SIPO.Properties.Resources.icon_purchase_order;
            this.btnPurchaseOrders.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPurchaseOrders.UseSelectable = true;
            this.btnPurchaseOrders.UseTileImage = true;
            this.btnPurchaseOrders.Click += new System.EventHandler(this.btnPurchaseOrders_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.ActiveControl = null;
            this.btnPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPayments.Location = new System.Drawing.Point(306, 3);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(95, 110);
            this.btnPayments.TabIndex = 3;
            this.btnPayments.Text = "Payments";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPayments.TileImage = global::SIPO.Properties.Resources.icon_payment_method;
            this.btnPayments.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayments.UseSelectable = true;
            this.btnPayments.UseTileImage = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnPackages
            // 
            this.btnPackages.ActiveControl = null;
            this.btnPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPackages.Location = new System.Drawing.Point(407, 3);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(95, 110);
            this.btnPackages.TabIndex = 4;
            this.btnPackages.Text = "Packages";
            this.btnPackages.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPackages.TileImage = global::SIPO.Properties.Resources.icon_packaging;
            this.btnPackages.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPackages.UseSelectable = true;
            this.btnPackages.UseTileImage = true;
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.panelLayoutReports);
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
            this.panelLayoutReports.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel panelLayoutReports;
        private MetroFramework.Controls.MetroTile btnRawMaterials;
        private MetroFramework.Controls.MetroTile btnFinishedProducts;
        private MetroFramework.Controls.MetroTile btnPurchaseOrders;
        private MetroFramework.Controls.MetroTile btnPayments;
        private MetroFramework.Controls.MetroTile btnPackages;
    }
}