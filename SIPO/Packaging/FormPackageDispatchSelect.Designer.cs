namespace SIPO.Packaging
{
    partial class FormPackageDispatchSelect
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
            this.lvBatches = new MetroFramework.Controls.MetroListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDispatchPackage = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lvBatches
            // 
            this.lvBatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvBatches.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvBatches.FullRowSelect = true;
            this.lvBatches.Location = new System.Drawing.Point(23, 63);
            this.lvBatches.MultiSelect = false;
            this.lvBatches.Name = "lvBatches";
            this.lvBatches.OwnerDraw = true;
            this.lvBatches.Size = new System.Drawing.Size(554, 285);
            this.lvBatches.TabIndex = 0;
            this.lvBatches.UseCompatibleStateImageBehavior = false;
            this.lvBatches.UseSelectable = true;
            this.lvBatches.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PO ID";
            this.columnHeader3.Width = 141;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Batch ID";
            this.columnHeader4.Width = 163;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Delivery Date";
            this.columnHeader5.Width = 246;
            // 
            // btnDispatchPackage
            // 
            this.btnDispatchPackage.Location = new System.Drawing.Point(452, 354);
            this.btnDispatchPackage.Name = "btnDispatchPackage";
            this.btnDispatchPackage.Size = new System.Drawing.Size(125, 23);
            this.btnDispatchPackage.TabIndex = 1;
            this.btnDispatchPackage.Text = "Dispatch Package";
            this.btnDispatchPackage.UseSelectable = true;
            this.btnDispatchPackage.Click += new System.EventHandler(this.btnDispatchPackage_Click);
            // 
            // FormPackageDispatchSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnDispatchPackage);
            this.Controls.Add(this.lvBatches);
            this.Name = "FormPackageDispatchSelect";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Select Package to Dispatch";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lvBatches;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroButton btnDispatchPackage;
    }
}