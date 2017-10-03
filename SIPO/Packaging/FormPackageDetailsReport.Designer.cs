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
            this.components = new System.ComponentModel.Container();
            this.lblDeliveryDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.grossDataGridViewTextBoxColumn,
            this.netDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.packageDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 92);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(654, 366);
            this.dataGridView1.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grossDataGridViewTextBoxColumn
            // 
            this.grossDataGridViewTextBoxColumn.DataPropertyName = "Gross";
            this.grossDataGridViewTextBoxColumn.HeaderText = "Gross";
            this.grossDataGridViewTextBoxColumn.Name = "grossDataGridViewTextBoxColumn";
            this.grossDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netDataGridViewTextBoxColumn
            // 
            this.netDataGridViewTextBoxColumn.DataPropertyName = "Net";
            this.netDataGridViewTextBoxColumn.HeaderText = "Net";
            this.netDataGridViewTextBoxColumn.Name = "netDataGridViewTextBoxColumn";
            this.netDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packageDetailsBindingSource
            // 
            this.packageDetailsBindingSource.DataSource = typeof(SIPO.Classes.PackageDetails);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(568, 464);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 26);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormPackageDetailsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 523);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FormPackageDetailsReport";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Package Contents";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblDeliveryDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtycartonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource packageDetailsBindingSource;
    }
}