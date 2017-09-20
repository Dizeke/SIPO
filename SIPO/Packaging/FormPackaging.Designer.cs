namespace SIPO.Packaging
{
    partial class FormPackaging
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panelLayoutPackages = new System.Windows.Forms.TableLayoutPanel();
            this.btnDispatchPackages = new MetroFramework.Controls.MetroTile();
            this.panelLayoutMain.SuspendLayout();
            this.panelLayoutPackages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLayoutMain
            // 
            this.panelLayoutMain.ColumnCount = 2;
            this.panelLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutMain.Controls.Add(this.metroTile1, 0, 0);
            this.panelLayoutMain.Controls.Add(this.panelLayoutPackages, 1, 0);
            this.panelLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLayoutMain.Location = new System.Drawing.Point(20, 60);
            this.panelLayoutMain.Name = "panelLayoutMain";
            this.panelLayoutMain.RowCount = 1;
            this.panelLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutMain.Size = new System.Drawing.Size(410, 420);
            this.panelLayoutMain.TabIndex = 3;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile1.Enabled = false;
            this.metroTile1.Location = new System.Drawing.Point(3, 6);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(199, 408);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Packages";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileImage = global::SIPO.Properties.Resources.icon_packaging;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // panelLayoutPackages
            // 
            this.panelLayoutPackages.ColumnCount = 1;
            this.panelLayoutPackages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutPackages.Controls.Add(this.btnDispatchPackages, 0, 0);
            this.panelLayoutPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLayoutPackages.Location = new System.Drawing.Point(208, 3);
            this.panelLayoutPackages.Name = "panelLayoutPackages";
            this.panelLayoutPackages.RowCount = 2;
            this.panelLayoutPackages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutPackages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLayoutPackages.Size = new System.Drawing.Size(199, 414);
            this.panelLayoutPackages.TabIndex = 2;
            // 
            // btnDispatchPackages
            // 
            this.btnDispatchPackages.ActiveControl = null;
            this.btnDispatchPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDispatchPackages.Location = new System.Drawing.Point(3, 3);
            this.btnDispatchPackages.Name = "btnDispatchPackages";
            this.btnDispatchPackages.Size = new System.Drawing.Size(193, 201);
            this.btnDispatchPackages.TabIndex = 4;
            this.btnDispatchPackages.Text = "Dispatch Packages";
            this.btnDispatchPackages.UseSelectable = true;
            this.btnDispatchPackages.Click += new System.EventHandler(this.btnDispatchPackages_Click);
            // 
            // FormPackaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.panelLayoutMain);
            this.Name = "FormPackaging";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Packaging";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.panelLayoutMain.ResumeLayout(false);
            this.panelLayoutPackages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelLayoutMain;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.TableLayoutPanel panelLayoutPackages;
        private MetroFramework.Controls.MetroTile btnDispatchPackages;
    }
}