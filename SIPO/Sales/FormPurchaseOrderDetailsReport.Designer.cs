namespace SIPO.Sales
{
    partial class FormPurchaseOrderDetailsReport
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
            this.lvProducts = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExportToExcel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvProducts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.Location = new System.Drawing.Point(23, 92);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.OwnerDraw = true;
            this.lvProducts.Size = new System.Drawing.Size(654, 285);
            this.lvProducts.TabIndex = 0;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.UseSelectable = true;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Prod ID";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prod Name";
            this.columnHeader2.Width = 221;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prod Price";
            this.columnHeader3.Width = 109;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prod Qty";
            this.columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Subtotal";
            this.columnHeader5.Width = 110;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(552, 63);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(125, 23);
            this.btnExportToExcel.TabIndex = 1;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseSelectable = true;
            // 
            // FormPurchaseOrderDetailsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.lvProducts);
            this.Name = "FormPurchaseOrderDetailsReport";
            this.Text = "Ordered Products";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lvProducts;
        private MetroFramework.Controls.MetroButton btnExportToExcel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}