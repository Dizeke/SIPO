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

namespace SIPO.Manager
{
    public partial class FormPODiscountRequests : MetroFramework.Forms.MetroForm
    {
        List<PurchaseOrder> purchaseOrders;

        int selectedIndex;

        public FormPODiscountRequests()
        {
            InitializeComponent();
            selectedIndex = -1;

            loadPurchaseOrders();
        }

        protected void loadPurchaseOrders()
        {
            purchaseOrders = new List<PurchaseOrder>();

            String query = "SELECT purchase_orders.po_id, po_datetime, po_payment, po_status, po_discount, client_id, SUM(prodf_srp) AS total FROM purchase_orders INNER JOIN purchase_order_batches ON purchase_orders.po_id = purchase_order_batches.po_id INNER JOIN purchase_order_batch_products ON purchase_order_batches.pob_id = purchase_order_batch_products.pob_id INNER JOIN products_finished ON purchase_order_batch_products.prodf_id = products_finished.prodf_id WHERE po_status = 'Pending' GROUP BY purchase_orders.po_id";
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();

            reader = com.ExecuteReader();
            while (reader.Read())
            {
                PurchaseOrder po = new PurchaseOrder();
                po.id = int.Parse(reader["po_id"].ToString());
                po.datetime = reader["po_datetime"].ToString();
                po.payment = reader["po_payment"].ToString();
                po.status = reader["po_status"].ToString();
                po.discount = int.Parse(reader["po_discount"].ToString());
                po.total = double.Parse(reader["total"].ToString());

                purchaseOrders.Add(po);
            }

            con.Close();
            displayPurchaseOrders();
        }

        protected void displayPurchaseOrders()
        {
            int row = 0;
            foreach (PurchaseOrder po in purchaseOrders)
            {
                lvPurchaseOrders.Items.Add(po.id.ToString());
                lvPurchaseOrders.Items[row].SubItems.Add(po.discount.ToString());
                lvPurchaseOrders.Items[row].SubItems.Add(po.total.ToString());
                lvPurchaseOrders.Items[row].SubItems.Add((po.total - (po.total * (po.discount / 100))).ToString());
                lvPurchaseOrders.Items[row].SubItems.Add(po.datetime);
                row++;
            }
        }

        private void lvPurchaseOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            int previousIndex = selectedIndex;
            try
            {
                selectedIndex = lvPurchaseOrders.SelectedIndices[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                selectedIndex = previousIndex;
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                FormPODRDetails formPODRDetails = new FormPODRDetails(purchaseOrders[selectedIndex].id);
                formPODRDetails.ShowDialog();
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                if (MessageBox.Show("Approve Requested Discount?", "Discount Approval Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PurchaseOrder po = purchaseOrders[selectedIndex];

                    String query = String.Format("UPDATE purchase_orders SET po_discount_approved = {0}, po_status = '{1}' WHERE po_id = {2}",
                        po.discount, "Approved", po.id);
                    MySqlConnection con = new MySqlConnection(ConString.getConString());
                    MySqlCommand com = new MySqlCommand(query, con);

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();

                    lvPurchaseOrders.Items.RemoveAt(selectedIndex);
                    purchaseOrders.RemoveAt(selectedIndex);
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                if (MessageBox.Show("Reject Requested Discount?", "Discount Rejection Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PurchaseOrder po = purchaseOrders[selectedIndex];

                    String query = String.Format("UPDATE purchase_orders SET po_discount_approved = 0, po_status = '{0}' WHERE po_id = {1}",
                        "Rejected", po.id); ;
                    MySqlConnection con = new MySqlConnection(ConString.getConString());
                    MySqlCommand com = new MySqlCommand(query, con);

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();

                    lvPurchaseOrders.Items.RemoveAt(selectedIndex);
                    purchaseOrders.RemoveAt(selectedIndex);
                }
            }
        }
    }
}
