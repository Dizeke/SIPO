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
    public partial class FormPurchaseOrderReport : MetroFramework.Forms.MetroForm
    {
        int selectedIndex;
        List<PODetails> poDetails;

        public FormPurchaseOrderReport()
        {
            InitializeComponent();
            selectedIndex = -1;
            loadPurchaseOrders();
        }

        private void loadPurchaseOrders()
        {
            poDetails = new List<PODetails>();

            String query = "SELECT purchase_orders.po_id AS 'PO ID', clients.client_company AS 'Company', purchase_orders.po_datetime AS 'Added On', tblTotal.total AS 'Total', tblPaid.pop_amount AS 'Paid', (tblTotal.total - tblPaid.pop_amount) AS 'Balance' FROM purchase_orders INNER JOIN clients ON clients.client_id = purchase_orders.client_id, ( SELECT purchase_orders.po_id, COALESCE(SUM(pop_amount), 0) AS pop_amount FROM purchase_order_payments RIGHT JOIN purchase_orders ON purchase_order_payments.po_id = purchase_orders.po_id GROUP BY purchase_orders.po_id ) AS tblPaid, ( SELECT purchase_orders.po_id, SUM(products_finished.prodf_srp * purchase_order_batch_products.prodf_qty) AS total FROM purchase_order_batch_products INNER JOIN products_finished ON purchase_order_batch_products.prodf_id = products_finished.prodf_id INNER JOIN purchase_order_batches ON purchase_order_batch_products.pob_id = purchase_order_batches.pob_id INNER JOIN purchase_orders ON purchase_order_batches.po_id = purchase_orders.po_id GROUP BY purchase_orders.po_id ) AS tblTotal WHERE tblPaid.po_id = purchase_orders.po_id AND tblTotal.po_id = purchase_orders.po_id";
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();

            reader = com.ExecuteReader();
            while (reader.Read())
            {
                PODetails pod = new PODetails();
                pod.po_id = int.Parse(reader["PO ID"].ToString());
                pod.po_company = reader["Company"].ToString();
                pod.po_datetime = reader["Added On"].ToString();
                pod.po_total = double.Parse(reader["Total"].ToString());
                pod.po_paid = double.Parse(reader["Paid"].ToString());
                pod.po_balance = double.Parse(reader["Balance"].ToString());

                poDetails.Add(pod);
            }

            con.Close();
            displayPurchaseOrders();
        }

        private void displayPurchaseOrders()
        {
            int row = 0;
            foreach (PODetails pod in poDetails)
            {
                lvPurchaseOrders.Items.Add(pod.po_id.ToString());
                lvPurchaseOrders.Items[row].SubItems.Add(pod.po_company);
                lvPurchaseOrders.Items[row].SubItems.Add(pod.po_total.ToString());
                lvPurchaseOrders.Items[row].SubItems.Add(pod.po_paid.ToString());
                lvPurchaseOrders.Items[row].SubItems.Add(pod.po_balance.ToString());
                lvPurchaseOrders.Items[row].SubItems.Add(pod.po_datetime);

                row++;
            }

        }

        public partial class PODetails
        {
            private int _po_id;
            private string _po_company;
            private string _po_datetime;
            private double _po_total;
            private double _po_paid;
            private double _po_balance;

            public int po_id { get { return this._po_id; } set { this._po_id = value; } }
            public string po_company { get { return this._po_company; } set { this._po_company = value; } }
            public string po_datetime { get { return this._po_datetime; } set { this._po_datetime = value; } }
            public double po_total { get { return this._po_total; } set { this._po_total = value; } }
            public double po_paid { get { return this._po_paid; } set { this._po_paid = value; } }
            public double po_balance { get { return this._po_balance; } set { this._po_balance = value; } }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                int po_id = poDetails[selectedIndex].po_id;

                FormPurchaseOrderDetailsReport formPurchaseOrderDetailsReport = new FormPurchaseOrderDetailsReport(po_id);
                formPurchaseOrderDetailsReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a purchase order to view");
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
                Console.WriteLine(ex);
                selectedIndex = previousIndex;
            }
        }
    }
}
