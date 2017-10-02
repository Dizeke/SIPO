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
    public partial class FormPODRDetails : MetroFramework.Forms.MetroForm
    {
        List<PurchaseOrderProduct> po_products;

        int po_id;
        double total = 0;

        public FormPODRDetails(int _po_id)
        {
            InitializeComponent();
            this.po_id = _po_id;

            loadProducts();
        }

        private void loadProducts()
        {
            po_products = new List<PurchaseOrderProduct>();

            String query = String.Format("SELECT purchase_orders.po_id, purchase_orders.po_discount_approved, products_finished.prodf_name, purchase_order_batch_products.prodf_id, purchase_order_batch_products.prodf_qty, prodf_srp FROM purchase_orders INNER JOIN purchase_order_batches ON purchase_orders.po_id = purchase_order_batches.po_id INNER JOIN purchase_order_batch_products ON purchase_order_batches.pob_id = purchase_order_batch_products.pob_id INNER JOIN products_finished ON purchase_order_batch_products.prodf_id = products_finished.prodf_id WHERE purchase_orders.po_id = {0}",
                po_id);

            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();

            reader = com.ExecuteReader();
            while (reader.Read())
            {
                PurchaseOrderProduct prod = new PurchaseOrderProduct();
                prod.prodf_id = int.Parse(reader["prodf_id"].ToString());
                prod.discount_approved = double.Parse(reader["po_discount_approved"].ToString());
                prod.prodf_name = reader["prodf_name"].ToString();
                prod.prodf_quantity = int.Parse(reader["prodf_qty"].ToString());

                double price = double.Parse(reader["prodf_srp"].ToString());
                price = (price - (price * (prod.discount_approved / 100)));
                prod.prodf_srp = price;

                total += (price * prod.prodf_quantity);
                po_products.Add(prod);
            }

            con.Close();
            displayProducts();
        }

        private void displayProducts()
        {
            int row = 0;
            foreach (PurchaseOrderProduct prod in po_products)
            {
                lvPurchaseOrderProducts.Items.Add(prod.prodf_id.ToString());
                lvPurchaseOrderProducts.Items[row].SubItems.Add(prod.prodf_name);
                lvPurchaseOrderProducts.Items[row].SubItems.Add(prod.prodf_quantity.ToString());
                lvPurchaseOrderProducts.Items[row].SubItems.Add(prod.prodf_srp.ToString());
                lvPurchaseOrderProducts.Items[row].SubItems.Add((prod.prodf_srp * prod.prodf_quantity).ToString());

                row++;
            }

            lblTotalVal.Text = total.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
