namespace SIPO.Sales
{
    partial class FormPaymentSelect
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
            this.btnSelectPurchaseOrder = new MetroFramework.Controls.MetroButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPurchaseOrders = new MetroFramework.Controls.MetroListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSelectPurchaseOrder
            // 
            this.btnSelectPurchaseOrder.Location = new System.Drawing.Point(452, 354);
            this.btnSelectPurchaseOrder.Name = "btnSelectPurchaseOrder";
            this.btnSelectPurchaseOrder.Size = new System.Drawing.Size(125, 23);
            this.btnSelectPurchaseOrder.TabIndex = 1;
            this.btnSelectPurchaseOrder.Text = "Select Purchase Order ";
            this.btnSelectPurchaseOrder.UseSelectable = true;
            this.btnSelectPurchaseOrder.Click += new System.EventHandler(this.btnSelectPurchaseOrder_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Balance";
            this.columnHeader4.Width = 123;
            // 
            // lvPurchaseOrders
            // 
            this.lvPurchaseOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvPurchaseOrders.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvPurchaseOrders.FullRowSelect = true;
            this.lvPurchaseOrders.Location = new System.Drawing.Point(23, 63);
            this.lvPurchaseOrders.MultiSelect = false;
            this.lvPurchaseOrders.Name = "lvPurchaseOrders";
            this.lvPurchaseOrders.OwnerDraw = true;
            this.lvPurchaseOrders.Size = new System.Drawing.Size(554, 285);
            this.lvPurchaseOrders.TabIndex = 0;
            this.lvPurchaseOrders.UseCompatibleStateImageBehavior = false;
            this.lvPurchaseOrders.UseSelectable = true;
            this.lvPurchaseOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Company";
            this.columnHeader5.Width = 220;
            // 
            // FormPaymentSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnSelectPurchaseOrder);
            this.Controls.Add(this.lvPurchaseOrders);
            this.Name = "FormPaymentSelect";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Select Purchase Order for Payment";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnSelectPurchaseOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroListView lvPurchaseOrders;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}