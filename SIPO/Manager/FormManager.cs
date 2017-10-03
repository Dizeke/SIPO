using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using SIPO.Classes;
using SIPO.Inventory;
using SIPO.Manager;
using SIPO.Packaging;
using SIPO.Sales;

namespace SIPO.Manager
{
    public partial class FormManager : MetroFramework.Forms.MetroForm
    {
        enum Panel
        {
            AccountAdd,
            AccountUpdate,
            ClientAdd,
            ClientUpdate
        };

        FormPanelAccountAdd formPanelAccountAdd;

        FormPanelClientAdd formPanelClientAdd;

        bool hasOpenPanel = false;
        int openPanel = 0;

        public FormManager()
        {
            InitializeComponent();
            loadAccountDetails();
        }

        private void loadAccountDetails()
        {
            Account account = new Account();
            account = Account.loggedAccount;
            String name = account.lname + ", " + account.fname + " " + account.mname;
            lblAccName.Text = name;
            lblAccPosition.Text = account.position;

            if (account.image != null)
            {
                if (account.image.Length > 0)
                {
                    MemoryStream memoryStream = new MemoryStream();
                    memoryStream.Write(account.image, 0, account.image.Length);
                    pbAccImage.Image = Image.FromStream(memoryStream);
                }
            }
        }

        private void FormManager_SizeChanged(object sender, EventArgs e)
        {
            if (hasOpenPanel)
            {
                if (openPanel == (int)Panel.AccountAdd)
                {
                    formPanelAccountAdd.AutoScrollMinSize = new Size(770, 450);
                    formPanelAccountAdd.MaximumSize = panelHolder.Size;
                    formPanelAccountAdd.Size = panelHolder.Size;
                }

                else if (openPanel == (int)Panel.ClientAdd)
                {
                    formPanelClientAdd.AutoScrollMinSize = new Size(770, 450);
                    formPanelClientAdd.MaximumSize = panelHolder.Size;
                    formPanelClientAdd.Size = panelHolder.Size;
                }
            }
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            panelHolder.Controls.Clear();

            formPanelAccountAdd = new FormPanelAccountAdd();
            formPanelAccountAdd.TopLevel = false;
            formPanelAccountAdd.FormBorderStyle = FormBorderStyle.None;

            formPanelAccountAdd.MaximumSize = panelHolder.Size;
            formPanelAccountAdd.Dock = DockStyle.Fill;

            hasOpenPanel = true;
            openPanel = (int)Panel.AccountAdd;

            panelHolder.Controls.Add(formPanelAccountAdd);
            formPanelAccountAdd.Show();
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            panelHolder.Controls.Clear();

            formPanelClientAdd = new FormPanelClientAdd();
            formPanelClientAdd.TopLevel = false;
            formPanelClientAdd.FormBorderStyle = FormBorderStyle.None;

            formPanelClientAdd.MaximumSize = panelHolder.Size;
            formPanelClientAdd.Dock = DockStyle.Fill;

            hasOpenPanel = true;
            openPanel = (int)Panel.ClientAdd;

            panelHolder.Controls.Add(formPanelClientAdd);
            formPanelClientAdd.Show();
        }

        private void btnAccountUpdate_Click(object sender, EventArgs e)
        {
            FormPanelAccountSelect formPanelAccountSelect = new FormPanelAccountSelect();
            formPanelAccountSelect.ShowDialog();

            if (AccountUpdateHolder.hasSelected)
            {
                panelHolder.Controls.Clear();

                FormPanelAccountUpdate formPanelAccountUpdate = new FormPanelAccountUpdate();
                formPanelAccountUpdate.TopLevel = false;
                formPanelAccountUpdate.FormBorderStyle = FormBorderStyle.None;

                formPanelAccountUpdate.MaximumSize = panelHolder.Size;
                formPanelAccountUpdate.Dock = DockStyle.Fill;

                hasOpenPanel = true;
                openPanel = (int)Panel.AccountUpdate;

                panelHolder.Controls.Add(formPanelAccountUpdate);
                formPanelAccountUpdate.Show();
            }
        }

        private void btnClientUpdate_Click(object sender, EventArgs e)
        {
            FormPanelClientSelect formPanelClientSelect = new FormPanelClientSelect();
            formPanelClientSelect.ShowDialog();

            if (ClientUpdateHolder.hasSelected)
            {
                panelHolder.Controls.Clear();

                FormPanelClientUpdate formPanelClientUpdate = new FormPanelClientUpdate();
                formPanelClientUpdate.TopLevel = false;
                formPanelClientUpdate.FormBorderStyle = FormBorderStyle.None;

                formPanelClientUpdate.MaximumSize = panelHolder.Size;
                formPanelClientUpdate.Dock = DockStyle.Fill;

                hasOpenPanel = true;
                openPanel = (int)Panel.ClientUpdate;

                panelHolder.Controls.Add(formPanelClientUpdate);
                formPanelClientUpdate.Show();
            }
        }

        private void btnRawMaterials_Click(object sender, EventArgs e)
        {
            FormRawReports formRawReports = new FormRawReports();
            formRawReports.ShowDialog();
        }

        private void btnFinishedProducts_Click(object sender, EventArgs e)
        {
            FormFinishedReports formFinishedReports = new FormFinishedReports();
            formFinishedReports.ShowDialog();
        }

        private void btnPurchaseOrders_Click(object sender, EventArgs e)
        {
            FormPurchaseOrderReport formPurchaseOrderReport = new FormPurchaseOrderReport();
            formPurchaseOrderReport.ShowDialog();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            FormPaymentReport formPaymentReport = new FormPaymentReport();
            formPaymentReport.ShowDialog();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            FormPackageReport formPackagesReport = new FormPackageReport();
            formPackagesReport.ShowDialog();
        }

        private void btnDispatchedPackages_Click(object sender, EventArgs e)
        {
            FormPackageDispatchedReport formPackageDispatchedReport = new FormPackageDispatchedReport();
            formPackageDispatchedReport.ShowDialog();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            FormFinishedSelectRequest select = new FormFinishedSelectRequest();
            select.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            FormFinishedSelectPending sel = new FormFinishedSelectPending();
            sel.ShowDialog();
        }

        private void btnPODiscountRequests_Click(object sender, EventArgs e)
        {
            FormPODiscountRequests formPODiscountRequests = new FormPODiscountRequests();
            formPODiscountRequests.ShowDialog();
        }

        private void btnAccountManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnProductsRequest_Click(object sender, EventArgs e)
        {
            FormRequest formProductionRequest = new FormRequest();
            formProductionRequest.ShowDialog();
        }

        private void btnPendingProduction_Click(object sender, EventArgs e)
        {
            FormFinishedSelectPending formFinishedSelectPending = new FormFinishedSelectPending();
            formFinishedSelectPending.ShowDialog();
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            FormFinishedSelectRequest select = new FormFinishedSelectRequest();
            select.ShowDialog();
        }
    }
}
