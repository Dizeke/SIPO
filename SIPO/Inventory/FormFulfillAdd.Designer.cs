namespace SIPO.Inventory
{
    partial class FormFulfillAdd
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblBatchID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblDeliveryDate = new MetroFramework.Controls.MetroLabel();
            this.btnMoveToPackaging = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvProducts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.Location = new System.Drawing.Point(23, 105);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.OwnerDraw = true;
            this.lvProducts.Size = new System.Drawing.Size(554, 243);
            this.lvProducts.TabIndex = 0;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.UseSelectable = true;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 234;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stock";
            this.columnHeader4.Width = 97;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Batch ID";
            // 
            // lblBatchID
            // 
            this.lblBatchID.AutoSize = true;
            this.lblBatchID.Location = new System.Drawing.Point(23, 79);
            this.lblBatchID.Name = "lblBatchID";
            this.lblBatchID.Size = new System.Drawing.Size(21, 19);
            this.lblBatchID.TabIndex = 2;
            this.lblBatchID.Text = "ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(490, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Delivery Date";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDeliveryDate.Location = new System.Drawing.Point(350, 79);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(227, 23);
            this.lblDeliveryDate.TabIndex = 4;
            this.lblDeliveryDate.Text = "Date";
            this.lblDeliveryDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMoveToPackaging
            // 
            this.btnMoveToPackaging.Location = new System.Drawing.Point(427, 354);
            this.btnMoveToPackaging.Name = "btnMoveToPackaging";
            this.btnMoveToPackaging.Size = new System.Drawing.Size(150, 23);
            this.btnMoveToPackaging.TabIndex = 5;
            this.btnMoveToPackaging.Text = "Move to Packaging";
            this.btnMoveToPackaging.UseSelectable = true;
            this.btnMoveToPackaging.Click += new System.EventHandler(this.btnMoveToPackaging_Click);
            // 
            // FormFulfillAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnMoveToPackaging);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblBatchID);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lvProducts);
            this.Name = "FormFulfillAdd";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Move to Packaging";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView lvProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblBatchID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblDeliveryDate;
        private MetroFramework.Controls.MetroButton btnMoveToPackaging;
    }
}