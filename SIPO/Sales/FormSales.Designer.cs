namespace SIPO.Sales
{
    partial class FormSales
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
            this.btnPurchaseOrder = new MetroFramework.Controls.MetroTile();
            this.btnPurchaseOrderAdd = new MetroFramework.Controls.MetroTile();
            this.btnPurchaseOrderEdit = new MetroFramework.Controls.MetroTile();
            this.layoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.layoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.ActiveControl = null;
            this.btnPurchaseOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPurchaseOrder.Location = new System.Drawing.Point(3, 3);
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            this.layoutPanelMain.SetRowSpan(this.btnPurchaseOrder, 2);
            this.btnPurchaseOrder.Size = new System.Drawing.Size(199, 414);
            this.btnPurchaseOrder.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPurchaseOrder.TabIndex = 2;
            this.btnPurchaseOrder.Text = "Purchase Order";
            this.btnPurchaseOrder.UseSelectable = true;
            // 
            // btnPurchaseOrderAdd
            // 
            this.btnPurchaseOrderAdd.ActiveControl = null;
            this.btnPurchaseOrderAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPurchaseOrderAdd.Location = new System.Drawing.Point(208, 3);
            this.btnPurchaseOrderAdd.Name = "btnPurchaseOrderAdd";
            this.btnPurchaseOrderAdd.Size = new System.Drawing.Size(199, 204);
            this.btnPurchaseOrderAdd.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPurchaseOrderAdd.TabIndex = 1;
            this.btnPurchaseOrderAdd.Text = "Add";
            this.btnPurchaseOrderAdd.UseSelectable = true;
            this.btnPurchaseOrderAdd.Click += new System.EventHandler(this.btnPurchaseOrderAdd_Click);
            // 
            // btnPurchaseOrderEdit
            // 
            this.btnPurchaseOrderEdit.ActiveControl = null;
            this.btnPurchaseOrderEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPurchaseOrderEdit.Location = new System.Drawing.Point(208, 213);
            this.btnPurchaseOrderEdit.Name = "btnPurchaseOrderEdit";
            this.btnPurchaseOrderEdit.Size = new System.Drawing.Size(199, 204);
            this.btnPurchaseOrderEdit.TabIndex = 0;
            this.btnPurchaseOrderEdit.Text = "Edit";
            this.btnPurchaseOrderEdit.UseSelectable = true;
            // 
            // layoutPanelMain
            // 
            this.layoutPanelMain.ColumnCount = 2;
            this.layoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanelMain.Controls.Add(this.btnPurchaseOrderEdit, 1, 1);
            this.layoutPanelMain.Controls.Add(this.btnPurchaseOrderAdd, 1, 0);
            this.layoutPanelMain.Controls.Add(this.btnPurchaseOrder, 0, 0);
            this.layoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelMain.Location = new System.Drawing.Point(20, 60);
            this.layoutPanelMain.Name = "layoutPanelMain";
            this.layoutPanelMain.RowCount = 2;
            this.layoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelMain.Size = new System.Drawing.Size(410, 420);
            this.layoutPanelMain.TabIndex = 0;
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.layoutPanelMain);
            this.Name = "FormSales";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Sales";
            this.layoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnPurchaseOrder;
        private System.Windows.Forms.TableLayoutPanel layoutPanelMain;
        private MetroFramework.Controls.MetroTile btnPurchaseOrderEdit;
        private MetroFramework.Controls.MetroTile btnPurchaseOrderAdd;
    }
}