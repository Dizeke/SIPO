using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPO.Sales
{
    public partial class FormSales : MetroFramework.Forms.MetroForm
    {
        public FormSales()
        {
            InitializeComponent();
            loadClients();
        }

        private void loadClients()
        {

        }

        private void btnPurchaseOrderAdd_Click(object sender, EventArgs e)
        {
            FormPurchaseOrderAdd formPurchaseOrderAdd = new FormPurchaseOrderAdd();
            formPurchaseOrderAdd.ShowDialog();
        }

    }
}
