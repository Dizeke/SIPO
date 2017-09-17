namespace SIPO.Sales
{
    partial class FormPurchaseOrderAdd
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
            this.lblClient = new MetroFramework.Controls.MetroLabel();
            this.cbClient = new MetroFramework.Controls.MetroComboBox();
            this.lblProduct = new MetroFramework.Controls.MetroLabel();
            this.lvProductList = new MetroFramework.Controls.MetroListView();
            this.lvPurchaseList = new MetroFramework.Controls.MetroListView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAddCustomProduct = new MetroFramework.Controls.MetroButton();
            this.btnAddPurchaseOrder = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(23, 60);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(80, 19);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Select Client";
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.ItemHeight = 23;
            this.cbClient.Location = new System.Drawing.Point(23, 82);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(121, 29);
            this.cbClient.TabIndex = 1;
            this.cbClient.UseSelectable = true;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(23, 114);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(98, 19);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Select Products";
            // 
            // lvProductList
            // 
            this.lvProductList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvProductList.FullRowSelect = true;
            this.lvProductList.Location = new System.Drawing.Point(23, 136);
            this.lvProductList.Name = "lvProductList";
            this.lvProductList.OwnerDraw = true;
            this.lvProductList.Size = new System.Drawing.Size(280, 150);
            this.lvProductList.TabIndex = 3;
            this.lvProductList.UseCompatibleStateImageBehavior = false;
            this.lvProductList.UseSelectable = true;
            // 
            // lvPurchaseList
            // 
            this.lvPurchaseList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvPurchaseList.FullRowSelect = true;
            this.lvPurchaseList.Location = new System.Drawing.Point(317, 136);
            this.lvPurchaseList.Name = "lvPurchaseList";
            this.lvPurchaseList.OwnerDraw = true;
            this.lvPurchaseList.Size = new System.Drawing.Size(280, 150);
            this.lvPurchaseList.TabIndex = 4;
            this.lvPurchaseList.UseCompatibleStateImageBehavior = false;
            this.lvPurchaseList.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(473, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Products For Order";
            // 
            // btnAddCustomProduct
            // 
            this.btnAddCustomProduct.Location = new System.Drawing.Point(23, 292);
            this.btnAddCustomProduct.Name = "btnAddCustomProduct";
            this.btnAddCustomProduct.Size = new System.Drawing.Size(121, 23);
            this.btnAddCustomProduct.TabIndex = 6;
            this.btnAddCustomProduct.Text = "Add Custom Product";
            this.btnAddCustomProduct.UseSelectable = true;
            // 
            // btnAddPurchaseOrder
            // 
            this.btnAddPurchaseOrder.Location = new System.Drawing.Point(473, 354);
            this.btnAddPurchaseOrder.Name = "btnAddPurchaseOrder";
            this.btnAddPurchaseOrder.Size = new System.Drawing.Size(124, 23);
            this.btnAddPurchaseOrder.TabIndex = 7;
            this.btnAddPurchaseOrder.Text = "Add Purchase Order";
            this.btnAddPurchaseOrder.UseSelectable = true;
            // 
            // FormPurchaseOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 400);
            this.Controls.Add(this.btnAddPurchaseOrder);
            this.Controls.Add(this.btnAddCustomProduct);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lvPurchaseList);
            this.Controls.Add(this.lvProductList);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.lblClient);
            this.Name = "FormPurchaseOrderAdd";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Add Purchase Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblClient;
        private MetroFramework.Controls.MetroComboBox cbClient;
        private MetroFramework.Controls.MetroLabel lblProduct;
        private MetroFramework.Controls.MetroListView lvProductList;
        private MetroFramework.Controls.MetroListView lvPurchaseList;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAddCustomProduct;
        private MetroFramework.Controls.MetroButton btnAddPurchaseOrder;
    }
}