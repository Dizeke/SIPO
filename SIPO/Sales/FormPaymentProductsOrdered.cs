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
    public partial class FormPaymentProductsOrdered : MetroFramework.Forms.MetroForm
    {
        List<PurchaseOrderProduct> po_prods;

        int po_id;
        double total = 0;

        public FormPaymentProductsOrdered(int _po_id)
        {
            InitializeComponent();
            this.po_id = _po_id;

            loadProductsOrdered();
        }

        private void loadProductsOrdered()
        {
            po_prods = new List<PurchaseOrderProduct>();

            string query = String.Format("SELECT products_finished.prodf_id, prodf_name, prodf_desc, purchase_order_batch_products.prodf_qty, products_finished.prodf_srp, purchase_orders.po_id, po_discount_approved FROM purchase_orders INNER JOIN purchase_order_batches ON purchase_orders.po_id = purchase_order_batches.po_id INNER JOIN purchase_order_batch_products ON purchase_order_batches.pob_id = purchase_order_batch_products.pob_id INNER JOIN products_finished ON purchase_order_batch_products.prodf_id = products_finished.prodf_id WHERE purchase_orders.po_id = {0}",
                po_id);
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();

            reader = com.ExecuteReader();
            while (reader.Read())
            {
                PurchaseOrderProduct pop = new PurchaseOrderProduct();
                pop.po_id = int.Parse(reader["po_id"].ToString());
                pop.discount_approved = double.Parse(reader["po_discount_approved"].ToString());
                pop.prodf_id = int.Parse(reader["prodf_id"].ToString());
                pop.prodf_name = reader["prodf_name"].ToString();
                pop.prodf_desc = reader["prodf_desc"].ToString();
                pop.prodf_quantity = int.Parse(reader["prodf_qty"].ToString());
                pop.prodf_srp = double.Parse(reader["prodf_srp"].ToString());

                po_prods.Add(pop);
            }

            con.Close();
            displayProductsOrdered();
        }

        private void displayProductsOrdered()
        {
            int row = 0;
            foreach (PurchaseOrderProduct pop in po_prods)
            {
                lvProducts.Items.Add(pop.prodf_id.ToString());
                lvProducts.Items[row].SubItems.Add(pop.prodf_name);
                lvProducts.Items[row].SubItems.Add(pop.prodf_desc);
                lvProducts.Items[row].SubItems.Add(pop.prodf_quantity.ToString());
                lvProducts.Items[row].SubItems.Add(pop.prodf_srp.ToString());

                double discount = pop.discount_approved;
                double discountedPrice = pop.prodf_srp - (pop.prodf_srp * (discount / 100));

                double subTotal = (pop.prodf_srp * pop.prodf_quantity);
                double discountedSubtotal = subTotal - (subTotal * (discount / 100));

                lvProducts.Items[row].SubItems.Add(discountedPrice.ToString());
                lvProducts.Items[row].SubItems.Add(discount.ToString());
                lvProducts.Items[row].SubItems.Add(subTotal.ToString());
                lvProducts.Items[row].SubItems.Add(discountedSubtotal.ToString());

                total += discountedSubtotal;

                lblTotalVal.Text = total.ToString();
                row++;
            }
        }

    }
}
