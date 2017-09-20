namespace SIPO.Inventory
{
    partial class FormFulfillWeighing
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
            this.lvBatchProducts = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtGrossWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNetWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtQtyPerCarton = new MetroFramework.Controls.MetroTextBox();
            this.lblProductName = new MetroFramework.Controls.MetroLabel();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.btnMoveBatchToPackaging = new System.Windows.Forms.Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lvBatchProducts
            // 
            this.lvBatchProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvBatchProducts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvBatchProducts.FullRowSelect = true;
            this.lvBatchProducts.Location = new System.Drawing.Point(23, 63);
            this.lvBatchProducts.MultiSelect = false;
            this.lvBatchProducts.Name = "lvBatchProducts";
            this.lvBatchProducts.OwnerDraw = true;
            this.lvBatchProducts.Size = new System.Drawing.Size(654, 196);
            this.lvBatchProducts.TabIndex = 0;
            this.lvBatchProducts.UseCompatibleStateImageBehavior = false;
            this.lvBatchProducts.UseSelectable = true;
            this.lvBatchProducts.View = System.Windows.Forms.View.Details;
            this.lvBatchProducts.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvBatchProducts_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 396;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gross Wt";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Net Wt";
            this.columnHeader5.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Qty/Carton";
            this.columnHeader6.Width = 106;
            // 
            // txtGrossWeight
            // 
            // 
            // 
            // 
            this.txtGrossWeight.CustomButton.Image = null;
            this.txtGrossWeight.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txtGrossWeight.CustomButton.Name = "";
            this.txtGrossWeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGrossWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGrossWeight.CustomButton.TabIndex = 1;
            this.txtGrossWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGrossWeight.CustomButton.UseSelectable = true;
            this.txtGrossWeight.CustomButton.Visible = false;
            this.txtGrossWeight.Lines = new string[0];
            this.txtGrossWeight.Location = new System.Drawing.Point(23, 315);
            this.txtGrossWeight.MaxLength = 32767;
            this.txtGrossWeight.Name = "txtGrossWeight";
            this.txtGrossWeight.PasswordChar = '\0';
            this.txtGrossWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGrossWeight.SelectedText = "";
            this.txtGrossWeight.SelectionLength = 0;
            this.txtGrossWeight.SelectionStart = 0;
            this.txtGrossWeight.ShortcutsEnabled = true;
            this.txtGrossWeight.Size = new System.Drawing.Size(175, 23);
            this.txtGrossWeight.TabIndex = 1;
            this.txtGrossWeight.UseSelectable = true;
            this.txtGrossWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGrossWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 293);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Gross Weight (KG)";
            // 
            // txtNetWeight
            // 
            // 
            // 
            // 
            this.txtNetWeight.CustomButton.Image = null;
            this.txtNetWeight.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txtNetWeight.CustomButton.Name = "";
            this.txtNetWeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNetWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNetWeight.CustomButton.TabIndex = 1;
            this.txtNetWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNetWeight.CustomButton.UseSelectable = true;
            this.txtNetWeight.CustomButton.Visible = false;
            this.txtNetWeight.Lines = new string[0];
            this.txtNetWeight.Location = new System.Drawing.Point(204, 315);
            this.txtNetWeight.MaxLength = 32767;
            this.txtNetWeight.Name = "txtNetWeight";
            this.txtNetWeight.PasswordChar = '\0';
            this.txtNetWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNetWeight.SelectedText = "";
            this.txtNetWeight.SelectionLength = 0;
            this.txtNetWeight.SelectionStart = 0;
            this.txtNetWeight.ShortcutsEnabled = true;
            this.txtNetWeight.Size = new System.Drawing.Size(175, 23);
            this.txtNetWeight.TabIndex = 2;
            this.txtNetWeight.UseSelectable = true;
            this.txtNetWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNetWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(204, 293);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Net Weight (KG)";
            // 
            // txtQtyPerCarton
            // 
            // 
            // 
            // 
            this.txtQtyPerCarton.CustomButton.Image = null;
            this.txtQtyPerCarton.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txtQtyPerCarton.CustomButton.Name = "";
            this.txtQtyPerCarton.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQtyPerCarton.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQtyPerCarton.CustomButton.TabIndex = 1;
            this.txtQtyPerCarton.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQtyPerCarton.CustomButton.UseSelectable = true;
            this.txtQtyPerCarton.CustomButton.Visible = false;
            this.txtQtyPerCarton.Lines = new string[0];
            this.txtQtyPerCarton.Location = new System.Drawing.Point(502, 315);
            this.txtQtyPerCarton.MaxLength = 32767;
            this.txtQtyPerCarton.Name = "txtQtyPerCarton";
            this.txtQtyPerCarton.PasswordChar = '\0';
            this.txtQtyPerCarton.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQtyPerCarton.SelectedText = "";
            this.txtQtyPerCarton.SelectionLength = 0;
            this.txtQtyPerCarton.SelectionStart = 0;
            this.txtQtyPerCarton.ShortcutsEnabled = true;
            this.txtQtyPerCarton.Size = new System.Drawing.Size(175, 23);
            this.txtQtyPerCarton.TabIndex = 3;
            this.txtQtyPerCarton.UseSelectable = true;
            this.txtQtyPerCarton.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQtyPerCarton.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(23, 262);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(95, 19);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Product Name";
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.Location = new System.Drawing.Point(23, 354);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(175, 23);
            this.btnApplyChanges.TabIndex = 4;
            this.btnApplyChanges.Text = "Apply Changes";
            this.btnApplyChanges.UseVisualStyleBackColor = true;
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // btnMoveBatchToPackaging
            // 
            this.btnMoveBatchToPackaging.Location = new System.Drawing.Point(502, 354);
            this.btnMoveBatchToPackaging.Name = "btnMoveBatchToPackaging";
            this.btnMoveBatchToPackaging.Size = new System.Drawing.Size(175, 23);
            this.btnMoveBatchToPackaging.TabIndex = 5;
            this.btnMoveBatchToPackaging.Text = "Move Batch to Packaging";
            this.btnMoveBatchToPackaging.UseVisualStyleBackColor = true;
            this.btnMoveBatchToPackaging.Click += new System.EventHandler(this.btnMoveBatchToPackaging_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(502, 293);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(127, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Quantity per Carton";
            // 
            // FormFulfillWeighing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnMoveBatchToPackaging);
            this.Controls.Add(this.btnApplyChanges);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtQtyPerCarton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNetWeight);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtGrossWeight);
            this.Controls.Add(this.lvBatchProducts);
            this.Name = "FormFulfillWeighing";
            this.Text = "Weigh Batch Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView lvBatchProducts;
        private MetroFramework.Controls.MetroTextBox txtGrossWeight;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNetWeight;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtQtyPerCarton;
        private MetroFramework.Controls.MetroLabel lblProductName;
        private System.Windows.Forms.Button btnApplyChanges;
        private System.Windows.Forms.Button btnMoveBatchToPackaging;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}