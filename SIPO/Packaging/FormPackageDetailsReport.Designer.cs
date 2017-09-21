namespace SIPO.Packaging
{
    partial class FormPackageDetailsReport
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
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDeliveryDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvProducts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.Location = new System.Drawing.Point(23, 92);
            this.lvProducts.MultiSelect = false;
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.OwnerDraw = true;
            this.lvProducts.Size = new System.Drawing.Size(654, 366);
            this.lvProducts.TabIndex = 4;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.UseSelectable = true;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 183;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gross Wt";
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Net Wt";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Qty/Carton";
            this.columnHeader6.Width = 109;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(59, 461);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(87, 19);
            this.lblDeliveryDate.TabIndex = 7;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 461);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(30, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "ETA";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(552, 63);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(125, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Export to Excel";
            this.metroButton1.UseSelectable = true;
            // 
            // FormPackageDetailsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FormPackageDetailsReport";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Package Contents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView lvProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroFramework.Controls.MetroLabel lblDeliveryDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}