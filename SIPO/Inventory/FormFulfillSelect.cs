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

namespace SIPO.Inventory
{
    public partial class FormFulfillSelect : MetroFramework.Forms.MetroForm
    {
        List<POBatchDetail> poBatchDetails;

        public FormFulfillSelect()
        {
            InitializeComponent();
            loadPurchaseOrderBatch();
        }

        private void loadPurchaseOrderBatch()
        {
            poBatchDetails = new List<POBatchDetail>();

            String query = "SELECT purchase_orders.po_id, pob_id, po_payment, pob_datetime FROM purchase_orders INNER JOIN purchase_order_batches ON purchase_order_batches.po_id = purchase_orders.po_id WHERE purchase_orders.po_id NOT IN (SELECT po_id FROM (SELECT products_finished.prodf_id, products_finished.prodf_qty AS stock, purchase_order_batch_products.prodf_qty AS ordered, purchase_orders.po_id FROM purchase_orders INNER JOIN purchase_order_batches ON purchase_orders.po_id = purchase_order_batches.po_id INNER JOIN purchase_order_batch_products ON purchase_order_batch_products.pob_id = purchase_order_batches.pob_id INNER JOIN products_finished ON purchase_order_batch_products.prodf_id = products_finished.prodf_id HAVING purchase_order_batch_products.prodf_qty >= products_finished.prodf_qty) AS tblExceedCounter) AND pob_id NOT IN (SELECT pob_id FROM packages) AND purchase_orders.po_id IN (SELECT po_id FROM (SELECT tblPaid.po_id, tblPaid.paid, tblTotal.total FROM (SELECT purchase_order_payments.po_id, SUM(pop_amount) AS paid FROM purchase_orders INNER JOIN purchase_order_payments ON purchase_orders.po_id = purchase_order_payments.po_id GROUP BY purchase_order_payments.po_id ) AS tblPaid INNER JOIN (SELECT purchase_orders.po_id, SUM(purchase_order_batch_products.prodf_qty * products_finished.prodf_srp) AS total FROM purchase_order_batch_products INNER JOIN purchase_order_batches ON purchase_order_batches.pob_id = purchase_order_batch_products.pob_id INNER JOIN purchase_orders ON purchase_order_batches.po_id = purchase_orders.po_id INNER JOIN products_finished ON products_finished.prodf_id = purchase_order_batch_products.prodf_id GROUP BY purchase_orders.po_id) AS tblTotal ON tblPaid.po_id = tblTotal.po_id HAVING tblPaid.paid >= (tblTotal.total * 0.3) ) AS tblMinimumPaid)";
            Console.WriteLine(query);

            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();

            reader = com.ExecuteReader();
            while (reader.Read())
            {
                POBatchDetail pob = new POBatchDetail();
                pob.po_id = int.Parse(reader["po_id"].ToString());
                pob.pob_id = int.Parse(reader["pob_id"].ToString());
                pob.po_payment = reader["po_payment"].ToString();
                pob.pob_datetime = reader["pob_datetime"].ToString();

                poBatchDetails.Add(pob);
            }

            con.Close();
            displayPurchaseOrderBatch();
        }

        private void displayPurchaseOrderBatch()
        {
            lvPurchaseOrders.Items.Clear();

            int row = 0;
            foreach (POBatchDetail pob in poBatchDetails)
            {
                lvPurchaseOrders.Items.Add(pob.po_id.ToString());
                lvPurchaseOrders.Items[row].SubItems.Add(pob.pob_id.ToString());
                lvPurchaseOrders.Items[row].SubItems.Add(pob.pob_datetime);
                lvPurchaseOrders.Items[row].SubItems.Add(pob.po_payment);

                row++;
            }
        }

        public partial class POBatchDetail
        {
            private int _po_id;
            private int _pob_id;
            private string _po_payment;
            private string _pob_datetime;

            public int po_id { get { return this._po_id; } set { this._po_id = value; } }
            public int pob_id { get { return this._pob_id; } set { this._pob_id = value; } }
            public string po_payment { get { return this._po_payment; } set { this._po_payment = value; } }
            public string pob_datetime { get { return this._pob_datetime; } set { this._pob_datetime = value; } }
        }

        private void btnSelectBatch_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;
            try
            {
                selectedIndex = lvPurchaseOrders.SelectedIndices[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return;
            }

            int pob_id = poBatchDetails[selectedIndex].pob_id;
            string pob_datetime = poBatchDetails[selectedIndex].pob_datetime;

            FormFulfillMove formFulfillAdd = new FormFulfillMove(pob_id, pob_datetime);
            formFulfillAdd.ShowDialog();

            if (FormFulfillWeighing.isMoved)
            {
                loadPurchaseOrderBatch();
            }
        }
    }
}
