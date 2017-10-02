namespace SIPO.Packaging
{
    partial class FormPackageReceiveDispatched
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
            this.lvPackages = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMarkAsReceived = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lvPackages
            // 
            this.lvPackages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvPackages.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvPackages.FullRowSelect = true;
            this.lvPackages.Location = new System.Drawing.Point(23, 63);
            this.lvPackages.Name = "lvPackages";
            this.lvPackages.OwnerDraw = true;
            this.lvPackages.Size = new System.Drawing.Size(754, 285);
            this.lvPackages.TabIndex = 0;
            this.lvPackages.UseCompatibleStateImageBehavior = false;
            this.lvPackages.UseSelectable = true;
            this.lvPackages.View = System.Windows.Forms.View.Details;
            this.lvPackages.SelectedIndexChanged += new System.EventHandler(this.lvPackages_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PO ID";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Batch ID";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Company";
            this.columnHeader3.Width = 183;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Payment";
            this.columnHeader4.Width = 126;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ETA";
            this.columnHeader5.Width = 220;
            // 
            // btnMarkAsReceived
            // 
            this.btnMarkAsReceived.Location = new System.Drawing.Point(627, 354);
            this.btnMarkAsReceived.Name = "btnMarkAsReceived";
            this.btnMarkAsReceived.Size = new System.Drawing.Size(150, 23);
            this.btnMarkAsReceived.TabIndex = 1;
            this.btnMarkAsReceived.Text = "Mark as Received by Client";
            this.btnMarkAsReceived.UseSelectable = true;
            this.btnMarkAsReceived.Click += new System.EventHandler(this.btnMarkAsReceived_Click);
            // 
            // FormPackageReceiveDispatched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnMarkAsReceived);
            this.Controls.Add(this.lvPackages);
            this.Name = "FormPackageReceiveDispatched";
            this.Text = "Packages Dispatched";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lvPackages;
        private MetroFramework.Controls.MetroButton btnMarkAsReceived;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}