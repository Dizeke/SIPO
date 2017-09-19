namespace SIPO.Sales
{
    partial class FormPurchaseOrderBatching
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBatchList = new MetroFramework.Controls.MetroListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddToBatch = new MetroFramework.Controls.MetroButton();
            this.btnRemoveFromBatch = new MetroFramework.Controls.MetroButton();
            this.btnProceed = new MetroFramework.Controls.MetroButton();
            this.dtBatchDate = new MetroFramework.Controls.MetroDateTime();
            this.lblBatchDate = new MetroFramework.Controls.MetroLabel();
            this.dtBatchTime = new System.Windows.Forms.DateTimePicker();
            this.lblBatchTime = new MetroFramework.Controls.MetroLabel();
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
            this.lvPurchaseOrders.MultiSelect = false;
            this.lvPurchaseOrders.Name = "lvPurchaseOrders";
            this.lvPurchaseOrders.OwnerDraw = true;
            this.lvPurchaseOrders.Size = new System.Drawing.Size(320, 200);
            this.lvPurchaseOrders.TabIndex = 4;
            this.lvPurchaseOrders.UseCompatibleStateImageBehavior = false;
            this.lvPurchaseOrders.UseSelectable = true;
            this.lvPurchaseOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 183;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 63;
            // 
            // lvBatchList
            // 
            this.lvBatchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvBatchList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvBatchList.FullRowSelect = true;
            this.lvBatchList.Location = new System.Drawing.Point(357, 63);
            this.lvBatchList.MultiSelect = false;
            this.lvBatchList.Name = "lvBatchList";
            this.lvBatchList.OwnerDraw = true;
            this.lvBatchList.Size = new System.Drawing.Size(320, 200);
            this.lvBatchList.TabIndex = 5;
            this.lvBatchList.UseCompatibleStateImageBehavior = false;
            this.lvBatchList.UseSelectable = true;
            this.lvBatchList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 183;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Qty";
            this.columnHeader6.Width = 63;
            // 
            // btnAddToBatch
            // 
            this.btnAddToBatch.Location = new System.Drawing.Point(218, 269);
            this.btnAddToBatch.Name = "btnAddToBatch";
            this.btnAddToBatch.Size = new System.Drawing.Size(125, 23);
            this.btnAddToBatch.TabIndex = 6;
            this.btnAddToBatch.Text = "Add to Batch";
            this.btnAddToBatch.UseSelectable = true;
            this.btnAddToBatch.Click += new System.EventHandler(this.btnAddToBatch_Click);
            // 
            // btnRemoveFromBatch
            // 
            this.btnRemoveFromBatch.Location = new System.Drawing.Point(552, 269);
            this.btnRemoveFromBatch.Name = "btnRemoveFromBatch";
            this.btnRemoveFromBatch.Size = new System.Drawing.Size(125, 23);
            this.btnRemoveFromBatch.TabIndex = 7;
            this.btnRemoveFromBatch.Text = "Remove from Batch";
            this.btnRemoveFromBatch.UseSelectable = true;
            this.btnRemoveFromBatch.Click += new System.EventHandler(this.btnRemoveFromBatch_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(602, 329);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 8;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseSelectable = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // dtBatchDate
            // 
            this.dtBatchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBatchDate.Location = new System.Drawing.Point(23, 323);
            this.dtBatchDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtBatchDate.Name = "dtBatchDate";
            this.dtBatchDate.Size = new System.Drawing.Size(157, 29);
            this.dtBatchDate.TabIndex = 9;
            // 
            // lblBatchDate
            // 
            this.lblBatchDate.AutoSize = true;
            this.lblBatchDate.Location = new System.Drawing.Point(23, 301);
            this.lblBatchDate.Name = "lblBatchDate";
            this.lblBatchDate.Size = new System.Drawing.Size(72, 19);
            this.lblBatchDate.TabIndex = 10;
            this.lblBatchDate.Text = "Batch Date";
            // 
            // dtBatchTime
            // 
            this.dtBatchTime.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBatchTime.Location = new System.Drawing.Point(186, 323);
            this.dtBatchTime.Name = "dtBatchTime";
            this.dtBatchTime.Size = new System.Drawing.Size(157, 29);
            this.dtBatchTime.TabIndex = 11;
            // 
            // lblBatchTime
            // 
            this.lblBatchTime.AutoSize = true;
            this.lblBatchTime.Location = new System.Drawing.Point(269, 301);
            this.lblBatchTime.Name = "lblBatchTime";
            this.lblBatchTime.Size = new System.Drawing.Size(74, 19);
            this.lblBatchTime.TabIndex = 12;
            this.lblBatchTime.Text = "Batch Time";
            // 
            // FormPurchaseOrderBatching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 375);
            this.Controls.Add(this.lblBatchTime);
            this.Controls.Add(this.dtBatchTime);
            this.Controls.Add(this.lblBatchDate);
            this.Controls.Add(this.dtBatchDate);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnRemoveFromBatch);
            this.Controls.Add(this.btnAddToBatch);
            this.Controls.Add(this.lvBatchList);
            this.Controls.Add(this.lvPurchaseOrders);
            this.Name = "FormPurchaseOrderBatching";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Purchase Order Batching";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView lvPurchaseOrders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroListView lvBatchList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroFramework.Controls.MetroButton btnAddToBatch;
        private MetroFramework.Controls.MetroButton btnRemoveFromBatch;
        private MetroFramework.Controls.MetroButton btnProceed;
        private MetroFramework.Controls.MetroDateTime dtBatchDate;
        private MetroFramework.Controls.MetroLabel lblBatchDate;
        private System.Windows.Forms.DateTimePicker dtBatchTime;
        private MetroFramework.Controls.MetroLabel lblBatchTime;
    }
}