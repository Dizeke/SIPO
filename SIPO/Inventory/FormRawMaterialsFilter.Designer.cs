namespace SIPO.Inventory
{
    partial class FormRawMaterialsFilter
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
            this.cbName = new MetroFramework.Controls.MetroComboBox();
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
            this.btnFilterByCompany.Location = new System.Drawing.Point(462, 128);
            this.btnFilterByCompany.Name = "btnFilterByCompany";
            this.btnFilterByCompany.Size = new System.Drawing.Size(125, 23);
            this.btnFilterByCompany.TabIndex = 29;
            this.btnFilterByCompany.Text = "Filter by Name";
            this.btnFilterByCompany.UseSelectable = true;
            this.btnFilterByCompany.Click += new System.EventHandler(this.btnFilterByCompany_Click);
            // 
            // cbName
            // 
            this.cbName.AllowDrop = true;
            this.cbName.FormattingEnabled = true;
            this.cbName.ItemHeight = 23;
            this.cbName.Location = new System.Drawing.Point(337, 94);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(250, 29);
            this.cbName.TabIndex = 28;
            this.cbName.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(463, 67);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(113, 19);
            this.metroLabel4.TabIndex = 27;
            this.metroLabel4.Text = "By Product Name";
            // 
            // btnFilterByDate
            // 
            this.btnFilterByDate.Location = new System.Drawing.Point(33, 236);
            this.btnFilterByDate.Name = "btnFilterByDate";
            this.btnFilterByDate.Size = new System.Drawing.Size(125, 23);
            this.btnFilterByDate.TabIndex = 26;
            this.btnFilterByDate.Text = "Filter by Date";
            this.btnFilterByDate.UseSelectable = true;
            this.btnFilterByDate.Click += new System.EventHandler(this.btnFilterByDate_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(33, 161);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(22, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "To";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 98);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "From";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "By Date";
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(33, 183);
            this.dtTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 29);
            this.dtTo.TabIndex = 22;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(33, 120);
            this.dtFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 29);
            this.dtFrom.TabIndex = 21;
            // 
            // FormRawMaterialsFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 317);
            this.Controls.Add(this.btnFilterByCompany);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnFilterByDate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Name = "FormRawMaterialsFilter";
            this.Text = "Select Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnFilterByCompany;
        private MetroFramework.Controls.MetroComboBox cbName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnFilterByDate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtTo;
        private MetroFramework.Controls.MetroDateTime dtFrom;
    }
}