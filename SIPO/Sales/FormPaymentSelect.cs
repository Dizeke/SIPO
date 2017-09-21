using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using SIPO.Classes;

namespace SIPO.Sales
{
    public partial class FormPaymentSelect : MetroFramework.Forms.MetroForm
    {
        List<PurchaseOrderDetail> purchaseOrderDetails;
        public FormPaymentSelect()
        {
            InitializeComponent();
            loadPurchaseOrders();
        }

        private void loadPurchaseOrders()
        {
            lvPurchaseOrders.Items.Clear();
            purchaseOrderDetails = new List<PurchaseOrderDetail>();

            MySqlConnection conPuchaseOrder = new MySqlConnection(ConString.getConString());
            MySqlCommand comPurchaseOrder;
            MySqlDataReader readerPurchaseOrder;

            conPuchaseOrder.Open();

            String queryPurchaseOrder = "SELECT * FROM purchase_orders WHERE po_id IN ( SELECT po_id FROM (SELECT purchase_orders.po_id, products_finished.prodf_srp FROM purchase_orders INNER JOIN purchase_order_batches ON purchase_orders.po_id = purchase_order_batches.po_id INNER JOIN purchase_order_batch_products ON purchase_order_batches.pob_id = purchase_order_batch_products.pobp_id INNER JOIN products_finished ON purchase_order_batch_products.prodf_id = products_finished.prodf_id HAVING products_finished.prodf_srp > 0) as tblUpdatedProductsOnly )";
            comPurchaseOrder = new MySqlCommand(queryPurchaseOrder, conPuchaseOrder);

            readerPurchaseOrder = comPurchaseOrder.ExecuteReader();
            while (readerPurchaseOrder.Read())
            {
                double total = 0;

                PurchaseOrderDetail purchaseOrderDetail = new PurchaseOrderDetail();
                purchaseOrderDetail.po_id = int.Parse(readerPurchaseOrder["po_id"].ToString());
                purchaseOrderDetail.po_datetime = readerPurchaseOrder["po_datetime"].ToString();
                purchaseOrderDetail.client_id = int.Parse(readerPurchaseOrder["client_id"].ToString());

                MySqlConnection conPurchaseOrderTotal = new MySqlConnection(ConString.getConString());
                conPurchaseOrderTotal.Open();

                String queryPurchaseOrderTotal = "SELECT products_finished.prodf_id, prodf_srp, purchase_order_batch_products.prodf_qty " +
                "FROM purchase_order_batch_products " +
                "INNER JOIN products_finished " +
                "ON purchase_order_batch_products.prodf_id = products_finished.prodf_id " +
                "WHERE pob_id IN(SELECT pob_id FROM purchase_order_batches WHERE po_id = " + purchaseOrderDetail.po_id + ")";

                MySqlCommand comPurchaseOrderTotal = new MySqlCommand(queryPurchaseOrderTotal, conPurchaseOrderTotal);
                MySqlDataReader readerPurchaseOrderTotal = comPurchaseOrderTotal.ExecuteReader();

                while (readerPurchaseOrderTotal.Read())
                {
                    double price = double.Parse(readerPurchaseOrderTotal["prodf_srp"].ToString());
                    int qty = int.Parse(readerPurchaseOrderTotal["prodf_qty"].ToString());
                    total += (price * qty);
                }

                purchaseOrderDetail.total = total;
                conPurchaseOrderTotal.Close();

                MySqlConnection conPurchaseOrderPaid = new MySqlConnection(ConString.getConString());
                conPurchaseOrderPaid.Open();

                String queryPurchaseOrderPaid = "SELECT COALESCE(SUM(pop_amount), 0) AS paid FROM purchase_order_payments WHERE po_id = " + purchaseOrderDetail.po_id;

                MySqlCommand comPurchaseOrderPaid = new MySqlCommand(queryPurchaseOrderPaid, conPurchaseOrderPaid);
                MySqlDataReader readerPurchaseOrderPaid = comPurchaseOrderPaid.ExecuteReader();

                while (readerPurchaseOrderPaid.Read())
                {
                    purchaseOrderDetail.paid = double.Parse(readerPurchaseOrderPaid["paid"].ToString());
                }

                purchaseOrderDetail.balance = purchaseOrderDetail.total - purchaseOrderDetail.paid;
                conPurchaseOrderPaid.Close();

                if (purchaseOrderDetail.balance > 0)
                    purchaseOrderDetails.Add(purchaseOrderDetail);
            }

            conPuchaseOrder.Close();
            displayPurchaseOrders();
        }

        private void displayPurchaseOrders()
        {
            int row = 0;
            foreach (PurchaseOrderDetail pod in purchaseOrderDetails)
            {
                lvPurchaseOrders.Items.Add(pod.po_id.ToString());
                lvPurchaseOrders.Items[row].SubItems.Add(pod.po_datetime);
                lvPurchaseOrders.Items[row].SubItems.Add(pod.total.ToString());
                lvPurchaseOrders.Items[row].SubItems.Add(pod.balance.ToString());

                row++;
            }
        }

        private void btnSelectPurchaseOrder_Click(object sender, EventArgs e)
        {
            int selectedIndex = 1;
            try
            {
                selectedIndex = lvPurchaseOrders.SelectedIndices[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Please select a purchase order");
                return;
            }

            PurchaseOrderPaymentHelper.purchaseOrderDetail = purchaseOrderDetails[selectedIndex];
            PurchaseOrderPaymentHelper.purchaseOrderPayment = new PurchaseOrderPayment();
            PurchaseOrderPaymentHelper.isComplete = false;

            FormPaymentAdd formPaymentAdd = new FormPaymentAdd();
            formPaymentAdd.ShowDialog();

            if (PurchaseOrderPaymentHelper.isComplete)
            {
                loadPurchaseOrders();
            }
        }
    }
}
