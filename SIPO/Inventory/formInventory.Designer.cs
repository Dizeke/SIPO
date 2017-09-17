﻿namespace SIPO.Inventory
{
    partial class FormInventory
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
            this.panelLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnFinishedProducts = new MetroFramework.Controls.MetroTile();
            this.btnRawMaterials = new MetroFramework.Controls.MetroTile();
            this.panelLayoutRawMaterials = new System.Windows.Forms.TableLayoutPanel();
            this.btnRawMaterialUpdate = new MetroFramework.Controls.MetroTile();
            this.btnRawMaterialAdd = new MetroFramework.Controls.MetroTile();
            this.panelLayoutFinishedProducts = new System.Windows.Forms.TableLayoutPanel();
            this.btnFinishedProductUpdate = new MetroFramework.Controls.MetroTile();
            this.btnFinishedProductAdd = new MetroFramework.Controls.MetroTile();
            this.panelHolder = new System.Windows.Forms.Panel();
            this.panelLayoutMain.SuspendLayout();
            this.panelLayoutRawMaterials.SuspendLayout();
            this.panelLayoutFinishedProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLayoutMain
            // 
            this.panelLayoutMain.ColumnCount = 3;
            this.panelLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 567F));
            this.panelLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelLayoutMain.Controls.Add(this.btnFinishedProducts, 0, 1);
            this.panelLayoutMain.Controls.Add(this.btnRawMaterials, 0, 0);
            this.panelLayoutMain.Controls.Add(this.panelLayoutRawMaterials, 1, 0);
            this.panelLayoutMain.Controls.Add(this.panelLayoutFinishedProducts, 1, 1);
            this.panelLayoutMain.Controls.Add(this.panelHolder, 2, 0);
            this.panelLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLayoutMain.Location = new System.Drawing.Point(20, 60);
            this.panelLayoutMain.Name = "panelLayoutMain";
            this.panelLayoutMain.RowCount = 2;
            this.panelLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.28249F));
            this.panelLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.71751F));
            this.panelLayoutMain.Size = new System.Drawing.Size(879, 354);
            this.panelLayoutMain.TabIndex = 6;
            // 
            // btnFinishedProducts
            // 
            this.btnFinishedProducts.ActiveControl = null;
            this.btnFinishedProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinishedProducts.Enabled = false;
            this.btnFinishedProducts.Location = new System.Drawing.Point(3, 184);
            this.btnFinishedProducts.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnFinishedProducts.Name = "btnFinishedProducts";
            this.btnFinishedProducts.Size = new System.Drawing.Size(150, 164);
            this.btnFinishedProducts.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnFinishedProducts.TabIndex = 3;
            this.btnFinishedProducts.Text = "Finished Products";
            this.btnFinishedProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinishedProducts.TileImage = global::SIPO.Properties.Resources.icon_finished_product;
            this.btnFinishedProducts.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinishedProducts.UseSelectable = true;
            this.btnFinishedProducts.UseTileImage = true;
            // 
            // btnRawMaterials
            // 
            this.btnRawMaterials.ActiveControl = null;
            this.btnRawMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRawMaterials.Enabled = false;
            this.btnRawMaterials.Location = new System.Drawing.Point(3, 6);
            this.btnRawMaterials.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnRawMaterials.Name = "btnRawMaterials";
            this.btnRawMaterials.Size = new System.Drawing.Size(150, 166);
            this.btnRawMaterials.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnRawMaterials.TabIndex = 2;
            this.btnRawMaterials.Text = "Raw Materials";
            this.btnRawMaterials.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRawMaterials.TileImage = global::SIPO.Properties.Resources.icon_raw_product;
            this.btnRawMaterials.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRawMaterials.UseSelectable = true;
            this.btnRawMaterials.UseTileImage = true;
            // 
            // panelLayoutRawMaterials
            // 
            this.panelLayoutRawMaterials.ColumnCount = 1;
            this.panelLayoutRawMaterials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutRawMaterials.Controls.Add(this.btnRawMaterialUpdate, 0, 1);
            this.panelLayoutRawMaterials.Controls.Add(this.btnRawMaterialAdd, 0, 0);
            this.panelLayoutRawMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLayoutRawMaterials.Location = new System.Drawing.Point(159, 3);
            this.panelLayoutRawMaterials.Name = "panelLayoutRawMaterials";
            this.panelLayoutRawMaterials.RowCount = 2;
            this.panelLayoutRawMaterials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutRawMaterials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutRawMaterials.Size = new System.Drawing.Size(150, 172);
            this.panelLayoutRawMaterials.TabIndex = 0;
            // 
            // btnRawMaterialUpdate
            // 
            this.btnRawMaterialUpdate.ActiveControl = null;
            this.btnRawMaterialUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRawMaterialUpdate.Location = new System.Drawing.Point(3, 89);
            this.btnRawMaterialUpdate.Name = "btnRawMaterialUpdate";
            this.btnRawMaterialUpdate.Size = new System.Drawing.Size(144, 80);
            this.btnRawMaterialUpdate.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnRawMaterialUpdate.TabIndex = 4;
            this.btnRawMaterialUpdate.Text = "Update";
            this.btnRawMaterialUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRawMaterialUpdate.UseSelectable = true;
            // 
            // btnRawMaterialAdd
            // 
            this.btnRawMaterialAdd.ActiveControl = null;
            this.btnRawMaterialAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRawMaterialAdd.Location = new System.Drawing.Point(3, 3);
            this.btnRawMaterialAdd.Name = "btnRawMaterialAdd";
            this.btnRawMaterialAdd.Size = new System.Drawing.Size(144, 80);
            this.btnRawMaterialAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.btnRawMaterialAdd.TabIndex = 3;
            this.btnRawMaterialAdd.Text = "Add";
            this.btnRawMaterialAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRawMaterialAdd.UseSelectable = true;
            this.btnRawMaterialAdd.Click += new System.EventHandler(this.btnRawMaterialAdd_Click);
            // 
            // panelLayoutFinishedProducts
            // 
            this.panelLayoutFinishedProducts.ColumnCount = 1;
            this.panelLayoutFinishedProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutFinishedProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelLayoutFinishedProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelLayoutFinishedProducts.Controls.Add(this.btnFinishedProductUpdate, 0, 1);
            this.panelLayoutFinishedProducts.Controls.Add(this.btnFinishedProductAdd, 0, 0);
            this.panelLayoutFinishedProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLayoutFinishedProducts.Location = new System.Drawing.Point(159, 181);
            this.panelLayoutFinishedProducts.Name = "panelLayoutFinishedProducts";
            this.panelLayoutFinishedProducts.RowCount = 2;
            this.panelLayoutFinishedProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutFinishedProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutFinishedProducts.Size = new System.Drawing.Size(150, 170);
            this.panelLayoutFinishedProducts.TabIndex = 1;
            // 
            // btnFinishedProductUpdate
            // 
            this.btnFinishedProductUpdate.ActiveControl = null;
            this.btnFinishedProductUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinishedProductUpdate.Location = new System.Drawing.Point(3, 88);
            this.btnFinishedProductUpdate.Name = "btnFinishedProductUpdate";
            this.btnFinishedProductUpdate.Size = new System.Drawing.Size(144, 79);
            this.btnFinishedProductUpdate.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnFinishedProductUpdate.TabIndex = 6;
            this.btnFinishedProductUpdate.Text = "Update";
            this.btnFinishedProductUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnFinishedProductUpdate.UseSelectable = true;
            // 
            // btnFinishedProductAdd
            // 
            this.btnFinishedProductAdd.ActiveControl = null;
            this.btnFinishedProductAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinishedProductAdd.Location = new System.Drawing.Point(3, 3);
            this.btnFinishedProductAdd.Name = "btnFinishedProductAdd";
            this.btnFinishedProductAdd.Size = new System.Drawing.Size(144, 79);
            this.btnFinishedProductAdd.Style = MetroFramework.MetroColorStyle.Red;
            this.btnFinishedProductAdd.TabIndex = 5;
            this.btnFinishedProductAdd.Text = "Add";
            this.btnFinishedProductAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnFinishedProductAdd.UseSelectable = true;
            this.btnFinishedProductAdd.Click += new System.EventHandler(this.btnFinishedProductAdd_Click);
            // 
            // panelHolder
            // 
            this.panelHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHolder.Location = new System.Drawing.Point(315, 3);
            this.panelHolder.Name = "panelHolder";
            this.panelLayoutMain.SetRowSpan(this.panelHolder, 2);
            this.panelHolder.Size = new System.Drawing.Size(561, 348);
            this.panelHolder.TabIndex = 4;
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 434);
            this.Controls.Add(this.panelLayoutMain);
            this.Name = "FormInventory";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Inventory";
            this.SizeChanged += new System.EventHandler(this.FormInventory_SizeChanged);
            this.panelLayoutMain.ResumeLayout(false);
            this.panelLayoutRawMaterials.ResumeLayout(false);
            this.panelLayoutFinishedProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelLayoutMain;
        private MetroFramework.Controls.MetroTile btnFinishedProducts;
        private MetroFramework.Controls.MetroTile btnRawMaterials;
        private System.Windows.Forms.TableLayoutPanel panelLayoutRawMaterials;
        private MetroFramework.Controls.MetroTile btnRawMaterialUpdate;
        private MetroFramework.Controls.MetroTile btnRawMaterialAdd;
        private System.Windows.Forms.TableLayoutPanel panelLayoutFinishedProducts;
        private MetroFramework.Controls.MetroTile btnFinishedProductUpdate;
        private MetroFramework.Controls.MetroTile btnFinishedProductAdd;
        private System.Windows.Forms.Panel panelHolder;
    }
}