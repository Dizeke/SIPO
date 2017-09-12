namespace SIPO.Inventory
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
            this.tileRaw = new MetroFramework.Controls.MetroTile();
            this.tileFinishedProducts = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileRaw
            // 
            this.tileRaw.ActiveControl = null;
            this.tileRaw.Enabled = false;
            this.tileRaw.Location = new System.Drawing.Point(23, 63);
            this.tileRaw.Name = "tileRaw";
            this.tileRaw.Size = new System.Drawing.Size(175, 90);
            this.tileRaw.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileRaw.TabIndex = 0;
            this.tileRaw.Text = "Raw Materials";
            this.tileRaw.UseSelectable = true;
            // 
            // tileFinishedProducts
            // 
            this.tileFinishedProducts.ActiveControl = null;
            this.tileFinishedProducts.Enabled = false;
            this.tileFinishedProducts.Location = new System.Drawing.Point(23, 159);
            this.tileFinishedProducts.Name = "tileFinishedProducts";
            this.tileFinishedProducts.Size = new System.Drawing.Size(175, 90);
            this.tileFinishedProducts.Style = MetroFramework.MetroColorStyle.Brown;
            this.tileFinishedProducts.TabIndex = 1;
            this.tileFinishedProducts.Text = "Finished Products";
            this.tileFinishedProducts.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(204, 63);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(90, 90);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Add";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(300, 63);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(90, 90);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Update";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(204, 159);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(90, 90);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile3.TabIndex = 4;
            this.metroTile3.Text = "Add";
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(300, 159);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(90, 90);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile4.TabIndex = 5;
            this.metroTile4.Text = "Update";
            this.metroTile4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile4.UseSelectable = true;
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.tileFinishedProducts);
            this.Controls.Add(this.tileRaw);
            this.Name = "FormInventory";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Inventory";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormInventory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileRaw;
        private MetroFramework.Controls.MetroTile tileFinishedProducts;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
    }
}