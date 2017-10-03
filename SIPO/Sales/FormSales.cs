using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SIPO.Manager;
using SIPO.Classes;

namespace SIPO.Sales
{
    public partial class FormSales : MetroFramework.Forms.MetroForm
    {
        public FormSales()
        {
            InitializeComponent();
        }

        private void btnPurchaseOrderAdd_Click(object sender, EventArgs e)
        {
            FormPurchaseOrderAdd formPurchaseOrderAdd = new FormPurchaseOrderAdd();
            formPurchaseOrderAdd.ShowDialog();
        }

        private void btnPaymentAdd_Click(object sender, EventArgs e)
        {
            FormPaymentSelect formPaymentAdd = new FormPaymentSelect();
            formPaymentAdd.ShowDialog();
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            FormPurchaseOrderReport formPurchaseOrderReport = new FormPurchaseOrderReport();
            formPurchaseOrderReport.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            FormPaymentReport formPaymentReport = new FormPaymentReport();
            formPaymentReport.ShowDialog();
        }

        private void btnPurchaseOrderUpdate_Click(object sender, EventArgs e)
        {
            FormPurchaseOrderSelectUpdate formPurchaseOrderSelectUpdate = new FormPurchaseOrderSelectUpdate();
            formPurchaseOrderSelectUpdate.ShowDialog();
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            FormPanelClientAdd formPanelClientAdd = new FormPanelClientAdd();
            formPanelClientAdd.ShowDialog();
        }

        private void btnClientUpdate_Click(object sender, EventArgs e)
        {
            FormPanelAccountSelect formPanelAccountSelect = new FormPanelAccountSelect();
            formPanelAccountSelect.ShowDialog();

            if (AccountUpdateHolder.hasSelected)
            {
                FormPanelAccountUpdate formPanelAccountUpdate = new FormPanelAccountUpdate();
                formPanelAccountUpdate.ShowDialog();
            }
        }

        private void btnClientManagement_Click(object sender, EventArgs e)
        {

        }
    }
}
