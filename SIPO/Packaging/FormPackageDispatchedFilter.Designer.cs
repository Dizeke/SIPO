namespace SIPO.Packaging
{
    partial class FormPackageDispatchedFilter
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
            this.btnFilterByCompany = new MetroFramework.Controls.MetroButton();
            this.cbCompanies = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnFilterByDate = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtTo = new MetroFramework.Controls.MetroDateTime();
            this.dtFrom = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // btnFilterByCompany
            // 
            this.btnFilterByCompany.Location = new System.Drawing.Point(452, 254);
            this.btnFilterByCompany.Name = "btnFilterByCompany";
            this.btnFilterByCompany.Size = new System.Drawing.Size(125, 23);
            this.btnFilterByCompany.TabIndex = 32;
            this.btnFilterByCompany.Text = "Filter by Company";
            this.btnFilterByCompany.UseSelectable = true;
            this.btnFilterByCompany.Click += new System.EventHandler(this.btnFilterByCompany_Click);
            // 
            // cbCompanies
            // 
            this.cbCompanies.AllowDrop = true;
            this.cbCompanies.FormattingEnabled = true;
            this.cbCompanies.ItemHeight = 23;
            this.cbCompanies.Location = new System.Drawing.Point(327, 190);
            this.cbCompanies.Name = "cbCompanies";
            this.cbCompanies.Size = new System.Drawing.Size(250, 29);
            this.cbCompanies.TabIndex = 31;
            this.cbCompanies.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(453, 168);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(124, 19);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "By Company Name";
            // 
            // btnFilterByDate
            // 
            this.btnFilterByDate.Location = new System.Drawing.Point(22, 243);
            this.btnFilterByDate.Name = "btnFilterByDate";
            this.btnFilterByDate.Size = new System.Drawing.Size(125, 23);
            this.btnFilterByDate.TabIndex = 29;
            this.btnFilterByDate.Text = "Filter by Date";
            this.btnFilterByDate.UseSelectable = true;
            this.btnFilterByDate.Click += new System.EventHandler(this.btnFilterByDate_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 168);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(22, 19);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "To";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "From";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "By Date";
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(22, 190);
            this.dtTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 29);
            this.dtTo.TabIndex = 25;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(22, 127);
            this.dtFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 29);
            this.dtFrom.TabIndex = 24;
            // 
            // PackageDispatchedFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.btnFilterByCompany);
            this.Controls.Add(this.cbCompanies);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnFilterByDate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Name = "PackageDispatchedFilter";
            this.Text = "PackageDispatchedFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnFilterByCompany;
        private MetroFramework.Controls.MetroComboBox cbCompanies;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnFilterByDate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtTo;
        private MetroFramework.Controls.MetroDateTime dtFrom;
    }
}