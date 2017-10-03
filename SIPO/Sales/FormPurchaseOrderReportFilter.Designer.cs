namespace SIPO.Sales
{
    partial class FormPurchaseOrderReportFilter
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
            this.dtFrom = new MetroFramework.Controls.MetroDateTime();
            this.dtTo = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnFilterByDate = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbCompanies = new MetroFramework.Controls.MetroComboBox();
            this.btnFilterByCompany = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbContacts = new MetroFramework.Controls.MetroComboBox();
            this.btnFilterByContact = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(23, 113);
            this.dtFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 29);
            this.dtFrom.TabIndex = 0;
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(23, 176);
            this.dtTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 29);
            this.dtTo.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "By Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 91);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "From";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(22, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "To";
            // 
            // btnFilterByDate
            // 
            this.btnFilterByDate.Location = new System.Drawing.Point(23, 229);
            this.btnFilterByDate.Name = "btnFilterByDate";
            this.btnFilterByDate.Size = new System.Drawing.Size(125, 23);
            this.btnFilterByDate.TabIndex = 5;
            this.btnFilterByDate.Text = "Filter by Date";
            this.btnFilterByDate.UseSelectable = true;
            this.btnFilterByDate.Click += new System.EventHandler(this.btnFilterByDate_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(453, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(124, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "By Company Name";
            // 
            // cbCompanies
            // 
            this.cbCompanies.AllowDrop = true;
            this.cbCompanies.FormattingEnabled = true;
            this.cbCompanies.ItemHeight = 23;
            this.cbCompanies.Location = new System.Drawing.Point(327, 87);
            this.cbCompanies.Name = "cbCompanies";
            this.cbCompanies.Size = new System.Drawing.Size(250, 29);
            this.cbCompanies.TabIndex = 7;
            this.cbCompanies.UseSelectable = true;
            // 
            // btnFilterByCompany
            // 
            this.btnFilterByCompany.Location = new System.Drawing.Point(452, 121);
            this.btnFilterByCompany.Name = "btnFilterByCompany";
            this.btnFilterByCompany.Size = new System.Drawing.Size(125, 23);
            this.btnFilterByCompany.TabIndex = 8;
            this.btnFilterByCompany.Text = "Filter by Company";
            this.btnFilterByCompany.UseSelectable = true;
            this.btnFilterByCompany.Click += new System.EventHandler(this.btnFilterByCompany_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(445, 172);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(133, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "By Company Contact";
            // 
            // cbContacts
            // 
            this.cbContacts.AllowDrop = true;
            this.cbContacts.FormattingEnabled = true;
            this.cbContacts.ItemHeight = 23;
            this.cbContacts.Location = new System.Drawing.Point(328, 194);
            this.cbContacts.Name = "cbContacts";
            this.cbContacts.Size = new System.Drawing.Size(250, 29);
            this.cbContacts.TabIndex = 10;
            this.cbContacts.UseSelectable = true;
            // 
            // btnFilterByContact
            // 
            this.btnFilterByContact.Location = new System.Drawing.Point(453, 229);
            this.btnFilterByContact.Name = "btnFilterByContact";
            this.btnFilterByContact.Size = new System.Drawing.Size(125, 23);
            this.btnFilterByContact.TabIndex = 11;
            this.btnFilterByContact.Text = "Filter by Contact";
            this.btnFilterByContact.UseSelectable = true;
            this.btnFilterByContact.Click += new System.EventHandler(this.btnFilterByContact_Click);
            // 
            // FormPurchaseOrderReportFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 275);
            this.Controls.Add(this.btnFilterByContact);
            this.Controls.Add(this.cbContacts);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnFilterByCompany);
            this.Controls.Add(this.cbCompanies);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnFilterByDate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Name = "FormPurchaseOrderReportFilter";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Select Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dtFrom;
        private MetroFramework.Controls.MetroDateTime dtTo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnFilterByDate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbCompanies;
        private MetroFramework.Controls.MetroButton btnFilterByCompany;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cbContacts;
        private MetroFramework.Controls.MetroButton btnFilterByContact;
    }
}