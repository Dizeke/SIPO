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

namespace SIPO.Packaging
{
    public partial class FormPackageDispatch : MetroFramework.Forms.MetroForm
    {
        List<BatchProduct> batchProds;

        int pack_id;
        string pack_datetime;
        public static bool hasDispatched;

        public FormPackageDispatch(int _pack_id, string _pack_datetime)
        {
            InitializeComponent();
            this.pack_id = _pack_id;
            this.pack_datetime = _pack_datetime;
            lblDeliveryDate.Text = pack_datetime;

            loadPackageContents();
            hasDispatched = false;
        }

        private void loadPackageContents()
        {
            batchProds = new List<BatchProduct>();

            String query = String.Format("SELECT products_finished.prodf_id, products_finished.prodf_name, purchase_order_batch_products.prodf_qty, package_details.pd_gweight, package_details.pd_nweight, package_details.pd_qty_carton FROM packages INNER JOIN purchase_order_batches ON packages.pob_id = purchase_order_batches.pob_id INNER JOIN purchase_order_batch_products ON purchase_order_batch_products.pob_id = purchase_order_batches.pob_id INNER JOIN products_finished ON products_finished.prodf_id = purchase_order_batch_products.prodf_id INNER JOIN package_details ON package_details.pack_id = packages.pack_id WHERE packages.pack_id = {0}",
                pack_id
                );
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();

            reader = com.ExecuteReader();
            while (reader.Read())
            {
                BatchProduct prod = new BatchProduct();
                prod.prodf_id = int.Parse(reader["prodf_id"].ToString());
                prod.prodf_name = reader["prodf_name"].ToString();
                prod.prodf_qty = int.Parse(reader["prodf_qty"].ToString());
                prod.gweight = double.Parse(reader["pd_gweight"].ToString());
                prod.nweight = double.Parse(reader["pd_nweight"].ToString());
                prod.qty_carton = int.Parse(reader["pd_qty_carton"].ToString());

                batchProds.Add(prod);
            }

            con.Close();
            displayPackageContents();
        }

        private void displayPackageContents()
        {
            int row = 0;
            foreach (BatchProduct prod in batchProds)
            {
                lvProducts.Items.Add(prod.prodf_id.ToString());
                lvProducts.Items[row].SubItems.Add(prod.prodf_name);
                lvProducts.Items[row].SubItems.Add(prod.prodf_qty.ToString());
                lvProducts.Items[row].SubItems.Add(prod.gweight.ToString());
                lvProducts.Items[row].SubItems.Add(prod.nweight.ToString());
                lvProducts.Items[row].SubItems.Add(prod.qty_carton.ToString());
                row++;
            }
        }

        public partial class BatchProduct
        {
            private int _prodf_id;
            private string _prodf_name;
            private int _prodf_qty;
            private double _gweight;
            private double _nweight;
            private int _qty_carton;

            public int prodf_id { get { return this._prodf_id; } set { this._prodf_id = value; } }
            public string prodf_name { get { return this._prodf_name; } set { this._prodf_name = value; } }
            public int prodf_qty { get { return this._prodf_qty; } set { this._prodf_qty = value; } }
            public double gweight { get { return this._gweight; } set { this._gweight = value; } }
            public double nweight { get { return this._nweight; } set { this._nweight = value; } }
            public int qty_carton { get { return this._qty_carton; } set { this._qty_carton = value; } }
        }

        private void btnDispatch_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed with dispatching of package?", "Dispatch Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String query = String.Format("INSERT INTO packages_dispatched (packd_datetime, pack_id) VALUES ((SELECT NOW()), {0})",
              pack_id);

                MySqlConnection con = new MySqlConnection(ConString.getConString());
                MySqlCommand com = new MySqlCommand(query, con);

                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Package has been dispatched");
                hasDispatched = true;
                this.Close();
            }
        }
    }
}
