namespace SIPO.Sales
{
    partial class FormPurchaseOrderAdd
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
            this.lblClient = new MetroFramework.Controls.MetroLabel();
            this.cbClient = new MetroFramework.Controls.MetroComboBox();
            this.lblProduct = new MetroFramework.Controls.MetroLabel();
            this.lvProductList = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPurchaseList = new MetroFramework.Controls.MetroListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAddCustomProduct = new MetroFramework.Controls.MetroButton();
            this.btnAddPurchaseOrder = new MetroFramework.Controls.MetroButton();
            this.lblQuantity = new MetroFramework.Controls.MetroLabel();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.btnAddProduct = new MetroFramework.Controls.MetroButton();
            this.rbtnDisc0 = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnDisc5 = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnDisc10 = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnDisc15 = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnDisc20 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(23, 60);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(80, 19);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Select Client";
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.ItemHeight = 23;
            this.cbClient.Location = new System.Drawing.Point(23, 82);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(373, 29);
            this.cbClient.TabIndex = 1;
            this.cbClient.UseSelectable = true;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(23, 114);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(98, 19);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Select Products";
            // 
            // lvProductList
            // 
            this.lvProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvProductList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvProductList.FullRowSelect = true;
            this.lvProductList.Location = new System.Drawing.Point(23, 136);
            this.lvProductList.Name = "lvProductList";
            this.lvProductList.OwnerDraw = true;
            this.lvProductList.Size = new System.Drawing.Size(373, 150);
            this.lvProductList.TabIndex = 3;
            this.lvProductList.UseCompatibleStateImageBehavior = false;
            this.lvProductList.UseSelectable = true;
            this.lvProductList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 208;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 79;
            // 
            // lvPurchaseList
            // 
            this.lvPurchaseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvPurchaseList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvPurchaseList.FullRowSelect = true;
            this.lvPurchaseList.Location = new System.Drawing.Point(403, 136);
            this.lvPurchaseList.Name = "lvPurchaseList";
            this.lvPurchaseList.OwnerDraw = true;
            this.lvPurchaseList.Size = new System.Drawing.Size(374, 150);
            this.lvPurchaseList.TabIndex = 5;
            this.lvPurchaseList.UseCompatibleStateImageBehavior = false;
            this.lvPurchaseList.UseSelectable = true;
            this.lvPurchaseList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 198;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Qty";
            this.columnHeader6.Width = 85;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(653, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Products For Order";
            // 
            // btnAddCustomProduct
            // 
            this.btnAddCustomProduct.Location = new System.Drawing.Point(338, 292);
            this.btnAddCustomProduct.Name = "btnAddCustomProduct";
            this.btnAddCustomProduct.Size = new System.Drawing.Size(121, 23);
            this.btnAddCustomProduct.TabIndex = 7;
            this.btnAddCustomProduct.Text = "Add Custom Product";
            this.btnAddCustomProduct.UseSelectable = true;
            this.btnAddCustomProduct.Click += new System.EventHandler(this.btnAddCustomProduct_Click);
            // 
            // btnAddPurchaseOrder
            // 
            this.btnAddPurchaseOrder.Location = new System.Drawing.Point(653, 354);
            this.btnAddPurchaseOrder.Name = "btnAddPurchaseOrder";
            this.btnAddPurchaseOrder.Size = new System.Drawing.Size(124, 23);
            this.btnAddPurchaseOrder.TabIndex = 11;
            this.btnAddPurchaseOrder.Text = "Create Purchase Order";
            this.btnAddPurchaseOrder.UseSelectable = true;
            this.btnAddPurchaseOrder.Click += new System.EventHandler(this.btnAddPurchaseOrder_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(23, 332);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 19);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(23, 354);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(121, 23);
            this.txtQuantity.TabIndex = 10;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(702, 292);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(23, 292);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 23);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseSelectable = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // rbtnDisc0
            // 
            this.rbtnDisc0.AutoSize = true;
            this.rbtnDisc0.Checked = true;
            this.rbtnDisc0.Location = new System.Drawing.Point(403, 341);
            this.rbtnDisc0.Name = "rbtnDisc0";
            this.rbtnDisc0.Size = new System.Drawing.Size(39, 15);
            this.rbtnDisc0.TabIndex = 12;
            this.rbtnDisc0.TabStop = true;
            this.rbtnDisc0.Text = "0%";
            this.rbtnDisc0.UseSelectable = true;
            // 
            // rbtnDisc5
            // 
            this.rbtnDisc5.AutoSize = true;
            this.rbtnDisc5.Location = new System.Drawing.Point(448, 341);
            this.rbtnDisc5.Name = "rbtnDisc5";
            this.rbtnDisc5.Size = new System.Drawing.Size(39, 15);
            this.rbtnDisc5.TabIndex = 13;
            this.rbtnDisc5.Text = "5%";
            this.rbtnDisc5.UseSelectable = true;
            // 
            // rbtnDisc10
            // 
            this.rbtnDisc10.AutoSize = true;
            this.rbtnDisc10.Location = new System.Drawing.Point(448, 362);
            this.rbtnDisc10.Name = "rbtnDisc10";
            this.rbtnDisc10.Size = new System.Drawing.Size(45, 15);
            this.rbtnDisc10.TabIndex = 14;
            this.rbtnDisc10.Text = "10%";
            this.rbtnDisc10.UseSelectable = true;
            // 
            // rbtnDisc15
            // 
            this.rbtnDisc15.AutoSize = true;
            this.rbtnDisc15.Location = new System.Drawing.Point(500, 341);
            this.rbtnDisc15.Name = "rbtnDisc15";
            this.rbtnDisc15.Size = new System.Drawing.Size(45, 15);
            this.rbtnDisc15.TabIndex = 15;
            this.rbtnDisc15.Text = "15%";
            this.rbtnDisc15.UseSelectable = true;
            // 
            // rbtnDisc20
            // 
            this.rbtnDisc20.AutoSize = true;
            this.rbtnDisc20.Location = new System.Drawing.Point(500, 362);
            this.rbtnDisc20.Name = "rbtnDisc20";
            this.rbtnDisc20.Size = new System.Drawing.Size(45, 15);
            this.rbtnDisc20.TabIndex = 16;
            this.rbtnDisc20.Text = "20%";
            this.rbtnDisc20.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(300, 338);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Select Discount";
            // 
            // FormPurchaseOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.rbtnDisc20);
            this.Controls.Add(this.rbtnDisc15);
            this.Controls.Add(this.rbtnDisc10);
            this.Controls.Add(this.rbtnDisc5);
            this.Controls.Add(this.rbtnDisc0);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAddPurchaseOrder);
            this.Controls.Add(this.btnAddCustomProduct);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lvPurchaseList);
            this.Controls.Add(this.lvProductList);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.lblClient);
            this.Name = "FormPurchaseOrderAdd";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Add Purchase Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblClient;
        private MetroFramework.Controls.MetroComboBox cbClient;
        private MetroFramework.Controls.MetroLabel lblProduct;
        private MetroFramework.Controls.MetroListView lvProductList;
        private MetroFramework.Controls.MetroListView lvPurchaseList;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAddCustomProduct;
        private MetroFramework.Controls.MetroButton btnAddPurchaseOrder;
        private MetroFramework.Controls.MetroLabel lblQuantity;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroButton btnRemove;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroFramework.Controls.MetroButton btnAddProduct;
        private MetroFramework.Controls.MetroRadioButton rbtnDisc0;
        private MetroFramework.Controls.MetroRadioButton rbtnDisc5;
        private MetroFramework.Controls.MetroRadioButton rbtnDisc10;
        private MetroFramework.Controls.MetroRadioButton rbtnDisc15;
        private MetroFramework.Controls.MetroRadioButton rbtnDisc20;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}