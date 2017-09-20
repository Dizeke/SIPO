namespace SIPO.Inventory
{
    partial class FormFulfillSelect
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
            this.lvPurchaseOrders = new MetroFramework.Controls.MetroListView();
            this.btnSelectBatch = new MetroFramework.Controls.MetroButton();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvPurchaseOrders
            // 
            this.lvPurchaseOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvPurchaseOrders.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvPurchaseOrders.FullRowSelect = true;
            this.lvPurchaseOrders.Location = new System.Drawing.Point(23, 63);
            this.lvPurchaseOrders.Name = "lvPurchaseOrders";
            this.lvPurchaseOrders.OwnerDraw = true;
            this.lvPurchaseOrders.Size = new System.Drawing.Size(554, 285);
            this.lvPurchaseOrders.TabIndex = 0;
            this.lvPurchaseOrders.UseCompatibleStateImageBehavior = false;
            this.lvPurchaseOrders.UseSelectable = true;
            this.lvPurchaseOrders.View = System.Windows.Forms.View.Details;
            // 
            // btnSelectBatch
            // 
            this.btnSelectBatch.Location = new System.Drawing.Point(452, 354);
            this.btnSelectBatch.Name = "btnSelectBatch";
            this.btnSelectBatch.Size = new System.Drawing.Size(125, 23);
            this.btnSelectBatch.TabIndex = 1;
            this.btnSelectBatch.Text = "Select Batch";
            this.btnSelectBatch.UseSelectable = true;
            this.btnSelectBatch.Click += new System.EventHandler(this.btnSelectBatch_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PO ID";
            this.columnHeader4.Width = 81;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Batch ID";
            this.columnHeader5.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Delivery Date";
            this.columnHeader6.Width = 169;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Payment";
            this.columnHeader7.Width = 123;
            // 
            // FormFulfillSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnSelectBatch);
            this.Controls.Add(this.lvPurchaseOrders);
            this.Name = "FormFulfillSelect";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Select Purchase Order Batch";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lvPurchaseOrders;
        private MetroFramework.Controls.MetroButton btnSelectBatch;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}