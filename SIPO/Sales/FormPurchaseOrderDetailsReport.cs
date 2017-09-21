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
    public partial class FormPurchaseOrderDetailsReport : MetroFramework.Forms.MetroForm
    {
        List<FinishedProduct> products;

        int po_id;
        public FormPurchaseOrderDetailsReport(int _po_id)
        {
            InitializeComponent();
            this.po_id = _po_id;

            loadProducts();
        }

        private void loadProducts()
        {
            products = new List<FinishedProduct>();

            String query = String.Format("SELECT products_finished.prodf_id, prodf_name, prodf_desc, prodf_srp, purchase_order_batch_products.prodf_qty, (prodf_srp * purchase_order_batch_products.prodf_qty) AS subtotal FROM purchase_orders INNER JOIN purchase_order_batches ON purchase_orders.po_id = purchase_order_batches.po_id INNER JOIN purchase_order_batch_products ON purchase_order_batches.pob_id = purchase_order_batch_products.pob_id INNER JOIN products_finished ON purchase_order_batch_products.prodf_id = products_finished.prodf_id WHERE purchase_orders.po_id = {0}",
                po_id);
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();

            reader = com.ExecuteReader();
            while (reader.Read())
            {
                FinishedProduct prod = new FinishedProduct();
                prod.Id = int.Parse(reader["prodf_id"].ToString());
                prod.Name = reader["prodf_name"].ToString();
                prod.Desc = reader["prodf_desc"].ToString();
                prod.Qty = int.Parse(reader["prodf_qty"].ToString());
                prod.Price = double.Parse(reader["prodf_srp"].ToString());
                prod.Newprice = double.Parse(reader["subtotal"].ToString());

                products.Add(prod);
            }

            con.Close();
            displayProducts();
        }

        private void displayProducts()
        {
            int row = 0;
            foreach (FinishedProduct prod in products)
            {
                lvProducts.Items.Add(prod.Id.ToString());
                lvProducts.Items[row].SubItems.Add(prod.Name);
                lvProducts.Items[row].SubItems.Add(prod.Price.ToString());
                lvProducts.Items[row].SubItems.Add(prod.Qty.ToString());
                lvProducts.Items[row].SubItems.Add(prod.Newprice.ToString());

                row++;
            }
        }
    }
}
