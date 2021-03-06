﻿namespace SIPO.Packaging
{
    partial class FormReceivedPackagesReport
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
            this.btnExport = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.batchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnViewDetails = new MetroFramework.Controls.MetroButton();
            this.btnFilter = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.Location = new System.Drawing.Point(531, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(126, 20);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseSelectable = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnExport, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnViewDetails, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFilter, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 320);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchIdDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.pOIDDataGridViewTextBoxColumn,
            this.etaDataGridViewTextBoxColumn,
            this.packageIdDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.DataSource = this.packageBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(654, 260);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // batchIdDataGridViewTextBoxColumn
            // 
            this.batchIdDataGridViewTextBoxColumn.DataPropertyName = "BatchId";
            this.batchIdDataGridViewTextBoxColumn.HeaderText = "BatchId";
            this.batchIdDataGridViewTextBoxColumn.Name = "batchIdDataGridViewTextBoxColumn";
            this.batchIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pOIDDataGridViewTextBoxColumn
            // 
            this.pOIDDataGridViewTextBoxColumn.DataPropertyName = "POID";
            this.pOIDDataGridViewTextBoxColumn.HeaderText = "POID";
            this.pOIDDataGridViewTextBoxColumn.Name = "pOIDDataGridViewTextBoxColumn";
            this.pOIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etaDataGridViewTextBoxColumn
            // 
            this.etaDataGridViewTextBoxColumn.DataPropertyName = "Eta";
            this.etaDataGridViewTextBoxColumn.HeaderText = "Eta";
            this.etaDataGridViewTextBoxColumn.Name = "etaDataGridViewTextBoxColumn";
            this.etaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packageIdDataGridViewTextBoxColumn
            // 
            this.packageIdDataGridViewTextBoxColumn.DataPropertyName = "PackageId";
            this.packageIdDataGridViewTextBoxColumn.HeaderText = "PackageId";
            this.packageIdDataGridViewTextBoxColumn.Name = "packageIdDataGridViewTextBoxColumn";
            this.packageIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(SIPO.Classes.Package);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewDetails.Location = new System.Drawing.Point(531, 295);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(126, 22);
            this.btnViewDetails.TabIndex = 2;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseSelectable = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(3, 295);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 22);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseSelectable = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // FormReceivedPackagesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormReceivedPackagesReport";
            this.Text = "Received Packages";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnExport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private MetroFramework.Controls.MetroButton btnViewDetails;
        private MetroFramework.Controls.MetroButton btnFilter;
    }
}