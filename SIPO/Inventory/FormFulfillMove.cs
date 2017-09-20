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
    public partial class FormFulfillMove : MetroFramework.Forms.MetroForm
    {
        List<BatchProduct> batchProducts;

        int pob_id;
        string pob_datetime;
        public FormFulfillMove(int _pob_id, string _pob_datetime)
        {
            InitializeComponent();
            this.pob_id = _pob_id;
            this.pob_datetime = _pob_datetime;

            loadProducts();
        }

        private void loadProducts()
        {
            batchProducts = new List<BatchProduct>();

            String query = String.Format("SELECT products_finished.prodf_id, prodf_name, purchase_order_batch_products.prodf_qty, products_finished.prodf_qty AS prodf_stock FROM purchase_orders INNER JOIN purchase_order_batches ON purchase_order_batches.po_id = purchase_orders.po_id INNER JOIN purchase_order_batch_products ON purchase_order_batch_products.pob_id = purchase_order_batches.pob_id INNER JOIN products_finished ON purchase_order_batch_products.prodf_id = products_finished.prodf_id WHERE purchase_order_batches.pob_id = {0}",
                pob_id);
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();

            reader = com.ExecuteReader();
            while (reader.Read())
            {
                BatchProduct batchProd = new BatchProduct();
                batchProd.prodf_id = int.Parse(reader["prodf_id"].ToString());
                batchProd.prodf_name = reader["prodf_name"].ToString();
                batchProd.prodf_qty = int.Parse(reader["prodf_qty"].ToString());
                batchProd.prodf_stock = int.Parse(reader["prodf_stock"].ToString());

                batchProducts.Add(batchProd);
            }

            con.Close();
            displayProducts();
        }

        private void displayProducts()
        {
            int row = 0;
            foreach (BatchProduct prod in batchProducts)
            {
                lvProducts.Items.Add(prod.prodf_id.ToString());
                lvProducts.Items[row].SubItems.Add(prod.prodf_name);
                lvProducts.Items[row].SubItems.Add(prod.prodf_qty.ToString());
                lvProducts.Items[row].SubItems.Add(prod.prodf_stock.ToString());

                row++;
            }

            lblBatchID.Text = pob_id.ToString();
            lblDeliveryDate.Text = pob_datetime;
        }

        partial class BatchProduct
        {
            private int _prodf_id;
            private string _prodf_name;
            private int _prodf_qty;
            private int _prodf_stock;

            public int prodf_id { get { return this._prodf_id; } set { this._prodf_id = value; } }
            public string prodf_name { get { return this._prodf_name; } set { this._prodf_name = value; } }
            public int prodf_qty { get { return this._prodf_qty; } set { this._prodf_qty = value; } }
            public int prodf_stock { get { return this._prodf_stock; } set { this._prodf_stock = value; } }
        }

        private void btnMoveToPackaging_Click(object sender, EventArgs e)
        {
            FormFulfillWeighing formFulfillWeighing = new FormFulfillWeighing(pob_id);
            formFulfillWeighing.ShowDialog();

            if (FormFulfillWeighing.isMoved)
            {
                this.Close();
            }
        }

    }
}
