namespace SIPO.Sales
{
    partial class FormPurchaseOrderReport
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
            this.btnExport = new MetroFramework.Controls.MetroButton();
            this.btnViewDetails = new MetroFramework.Controls.MetroButton();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvPurchaseOrders
            // 
            this.lvPurchaseOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvPurchaseOrders.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvPurchaseOrders.FullRowSelect = true;
            this.lvPurchaseOrders.Location = new System.Drawing.Point(23, 92);
            this.lvPurchaseOrders.Name = "lvPurchaseOrders";
            this.lvPurchaseOrders.OwnerDraw = true;
            this.lvPurchaseOrders.Size = new System.Drawing.Size(554, 256);
            this.lvPurchaseOrders.TabIndex = 0;
            this.lvPurchaseOrders.UseCompatibleStateImageBehavior = false;
            this.lvPurchaseOrders.UseSelectable = true;
            this.lvPurchaseOrders.View = System.Windows.Forms.View.Details;
            this.lvPurchaseOrders.SelectedIndexChanged += new System.EventHandler(this.lvPurchaseOrders_SelectedIndexChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(459, 63);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(125, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseSelectable = true;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(452, 354);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(125, 23);
            this.btnViewDetails.TabIndex = 2;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseSelectable = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 116;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total";
            this.columnHeader6.Width = 103;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Paid";
            this.columnHeader7.Width = 106;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Balance";
            this.columnHeader8.Width = 98;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Added On";
            this.columnHeader9.Width = 127;
            // 
            // FormPurchaseOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lvPurchaseOrders);
            this.Name = "FormPurchaseOrderReport";
            this.Text = "Purchase Orders";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lvPurchaseOrders;
        private MetroFramework.Controls.MetroButton btnExport;
        private MetroFramework.Controls.MetroButton btnViewDetails;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}