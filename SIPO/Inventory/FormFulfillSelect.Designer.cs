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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvPurchaseOrders
            // 
            this.lvPurchaseOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
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
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PO ID";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Delivery Date";
            this.columnHeader2.Width = 238;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Payment";
            this.columnHeader3.Width = 158;
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}