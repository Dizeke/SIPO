namespace SIPO.Sales
{
    partial class FormSales
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
            this.layoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.layoutPanelPayment = new System.Windows.Forms.TableLayoutPanel();
            this.btnPaymentAdd = new MetroFramework.Controls.MetroTile();
            this.btnPayment = new MetroFramework.Controls.MetroTile();
            this.btnPurchaseOrder = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPurchaseOrderUpdate = new MetroFramework.Controls.MetroTile();
            this.btnPurchaseOrderAdd = new MetroFramework.Controls.MetroTile();
            this.btnClientManagement = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClientAdd = new MetroFramework.Controls.MetroTile();
            this.btnClientUpdate = new MetroFramework.Controls.MetroTile();
            this.layoutPanelMain.SuspendLayout();
            this.layoutPanelPayment.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanelMain
            // 
            this.layoutPanelMain.ColumnCount = 2;
            this.layoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelMain.Controls.Add(this.layoutPanelPayment, 1, 1);
            this.layoutPanelMain.Controls.Add(this.btnPayment, 0, 1);
            this.layoutPanelMain.Controls.Add(this.btnPurchaseOrder, 0, 0);
            this.layoutPanelMain.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.layoutPanelMain.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.layoutPanelMain.Controls.Add(this.btnClientManagement, 0, 2);
            this.layoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelMain.Location = new System.Drawing.Point(20, 60);
            this.layoutPanelMain.Name = "layoutPanelMain";
            this.layoutPanelMain.RowCount = 3;
            this.layoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutPanelMain.Size = new System.Drawing.Size(410, 420);
            this.layoutPanelMain.TabIndex = 0;
            // 
            // layoutPanelPayment
            // 
            this.layoutPanelPayment.ColumnCount = 1;
            this.layoutPanelPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelPayment.Controls.Add(this.btnPaymentAdd, 0, 0);
            this.layoutPanelPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelPayment.Location = new System.Drawing.Point(208, 142);
            this.layoutPanelPayment.Name = "layoutPanelPayment";
            this.layoutPanelPayment.RowCount = 2;
            this.layoutPanelPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelPayment.Size = new System.Drawing.Size(199, 133);
            this.layoutPanelPayment.TabIndex = 3;
            // 
            // btnPaymentAdd
            // 
            this.btnPaymentAdd.ActiveControl = null;
            this.btnPaymentAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPaymentAdd.Location = new System.Drawing.Point(3, 3);
            this.btnPaymentAdd.Name = "btnPaymentAdd";
            this.btnPaymentAdd.Size = new System.Drawing.Size(193, 60);
            this.btnPaymentAdd.TabIndex = 0;
            this.btnPaymentAdd.Text = "New Payment";
            this.btnPaymentAdd.UseSelectable = true;
            this.btnPaymentAdd.Click += new System.EventHandler(this.btnPaymentAdd_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.ActiveControl = null;
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPayment.Location = new System.Drawing.Point(3, 145);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(199, 127);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPayment.TileImage = global::SIPO.Properties.Resources.icon_payment_method;
            this.btnPayment.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayment.UseSelectable = true;
            this.btnPayment.UseTileImage = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.ActiveControl = null;
            this.btnPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPurchaseOrder.Location = new System.Drawing.Point(3, 6);
            this.btnPurchaseOrder.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            this.btnPurchaseOrder.Size = new System.Drawing.Size(199, 127);
            this.btnPurchaseOrder.TabIndex = 5;
            this.btnPurchaseOrder.Text = "Purchase Order";
            this.btnPurchaseOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPurchaseOrder.TileImage = global::SIPO.Properties.Resources.icon_purchase_order;
            this.btnPurchaseOrder.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPurchaseOrder.UseSelectable = true;
            this.btnPurchaseOrder.UseTileImage = true;
            this.btnPurchaseOrder.Click += new System.EventHandler(this.btnPurchaseOrder_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnPurchaseOrderUpdate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPurchaseOrderAdd, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(208, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(199, 133);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnPurchaseOrderUpdate
            // 
            this.btnPurchaseOrderUpdate.ActiveControl = null;
            this.btnPurchaseOrderUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPurchaseOrderUpdate.Location = new System.Drawing.Point(3, 69);
            this.btnPurchaseOrderUpdate.Name = "btnPurchaseOrderUpdate";
            this.btnPurchaseOrderUpdate.Size = new System.Drawing.Size(193, 61);
            this.btnPurchaseOrderUpdate.TabIndex = 7;
            this.btnPurchaseOrderUpdate.Text = "Update Purchase Order";
            this.btnPurchaseOrderUpdate.UseSelectable = true;
            this.btnPurchaseOrderUpdate.Click += new System.EventHandler(this.btnPurchaseOrderUpdate_Click);
            // 
            // btnPurchaseOrderAdd
            // 
            this.btnPurchaseOrderAdd.ActiveControl = null;
            this.btnPurchaseOrderAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPurchaseOrderAdd.Location = new System.Drawing.Point(3, 3);
            this.btnPurchaseOrderAdd.Name = "btnPurchaseOrderAdd";
            this.btnPurchaseOrderAdd.Size = new System.Drawing.Size(193, 60);
            this.btnPurchaseOrderAdd.TabIndex = 6;
            this.btnPurchaseOrderAdd.Text = "Create Purchase Order";
            this.btnPurchaseOrderAdd.UseSelectable = true;
            this.btnPurchaseOrderAdd.Click += new System.EventHandler(this.btnPurchaseOrderAdd_Click);
            // 
            // btnClientManagement
            // 
            this.btnClientManagement.ActiveControl = null;
            this.btnClientManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientManagement.Location = new System.Drawing.Point(3, 284);
            this.btnClientManagement.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnClientManagement.Name = "btnClientManagement";
            this.btnClientManagement.Size = new System.Drawing.Size(199, 130);
            this.btnClientManagement.TabIndex = 8;
            this.btnClientManagement.Text = "Client";
            this.btnClientManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientManagement.TileImage = global::SIPO.Properties.Resources.icon_manager;
            this.btnClientManagement.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientManagement.UseSelectable = true;
            this.btnClientManagement.UseTileImage = true;
            this.btnClientManagement.Click += new System.EventHandler(this.btnClientManagement_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnClientAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClientUpdate, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(208, 281);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(199, 136);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btnClientAdd
            // 
            this.btnClientAdd.ActiveControl = null;
            this.btnClientAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientAdd.Location = new System.Drawing.Point(3, 3);
            this.btnClientAdd.Name = "btnClientAdd";
            this.btnClientAdd.Size = new System.Drawing.Size(193, 62);
            this.btnClientAdd.TabIndex = 10;
            this.btnClientAdd.Text = "Create";
            this.btnClientAdd.UseSelectable = true;
            this.btnClientAdd.Click += new System.EventHandler(this.btnClientAdd_Click);
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.ActiveControl = null;
            this.btnClientUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientUpdate.Location = new System.Drawing.Point(3, 71);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(193, 62);
            this.btnClientUpdate.TabIndex = 11;
            this.btnClientUpdate.Text = "Update";
            this.btnClientUpdate.UseSelectable = true;
            this.btnClientUpdate.Click += new System.EventHandler(this.btnClientUpdate_Click);
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.layoutPanelMain);
            this.Name = "FormSales";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Sales";
            this.layoutPanelMain.ResumeLayout(false);
            this.layoutPanelPayment.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel layoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel layoutPanelPayment;
        private MetroFramework.Controls.MetroTile btnPaymentAdd;
        private MetroFramework.Controls.MetroTile btnPayment;
        private MetroFramework.Controls.MetroTile btnPurchaseOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTile btnPurchaseOrderUpdate;
        private MetroFramework.Controls.MetroTile btnPurchaseOrderAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroTile btnClientAdd;
        private MetroFramework.Controls.MetroTile btnClientUpdate;
        private MetroFramework.Controls.MetroTile btnClientManagement;
    }
}