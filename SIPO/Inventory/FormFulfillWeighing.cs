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
    public partial class FormFulfillWeighing : MetroFramework.Forms.MetroForm
    {
        List<BatchProduct> batchProds;
        int selectedIndex = -1;

        int pob_id;
        public static bool
            isMoved = false;

        public FormFulfillWeighing(int _pob_id)
        {
            InitializeComponent();
            this.pob_id = _pob_id;

            loadBatchProducts();
        }

        private void loadBatchProducts()
        {
            batchProds = new List<BatchProduct>();

            String query = String.Format("SELECT pob_id, pobp_id, products_finished.prodf_id, prodf_name, purchase_order_batch_products.prodf_qty FROM purchase_order_batch_products INNER JOIN products_finished ON purchase_order_batch_products.prodf_id = products_finished.prodf_id WHERE pob_id = {0}",
                pob_id);
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            Console.WriteLine(query);
            con.Open();

            reader = com.ExecuteReader();
            while (reader.Read())
            {
                BatchProduct batchProd = new BatchProduct();
                batchProd.pob_id = int.Parse(reader["pob_id"].ToString());
                batchProd.pobp_id = int.Parse(reader["pobp_id"].ToString());
                batchProd.prodf_id = int.Parse(reader["prodf_id"].ToString());
                batchProd.prodf_name = reader["prodf_name"].ToString();
                batchProd.prodf_qty = int.Parse(reader["prodf_qty"].ToString());

                batchProd.gweight = 0;
                batchProd.nweight = 0;
                batchProd.qty_carton = 0;

                batchProds.Add(batchProd);
            }

            con.Close();
            displayBatchProducts();
        }

        private void displayBatchProducts()
        {
            int row = 0;
            foreach (BatchProduct prod in batchProds)
            {
                lvBatchProducts.Items.Add(prod.prodf_id.ToString());
                lvBatchProducts.Items[row].SubItems.Add(prod.prodf_name.ToString());
                lvBatchProducts.Items[row].SubItems.Add(prod.prodf_qty.ToString());
                lvBatchProducts.Items[row].SubItems.Add((0).ToString());
                lvBatchProducts.Items[row].SubItems.Add((0).ToString());
                lvBatchProducts.Items[row].SubItems.Add((0).ToString());

                row++;
            }
        }

        private bool isValidInput()
        {
            try
            {
                if (double.Parse(txtGrossWeight.Text.ToString()) < 1)
                {
                    MessageBox.Show("Please provide a valid Gross Weight");
                    return false;
                }
                else if (double.Parse(txtNetWeight.Text.ToString()) < 1)
                {
                    MessageBox.Show("Please provide a valid Net Weight");
                    return false;
                }
                else if (int.Parse(txtQtyPerCarton.Text.ToString()) < 1)
                {
                    MessageBox.Show("Please provide a valid value for Quantity per Carton");
                    return false;
                }
                else if (selectedIndex < 0)
                {
                    MessageBox.Show("Please select a product");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Please provide valid values to apply");
                return false;
            }
        }

        private bool isWeighingComplete()
        {
            try
            {
                bool isComplete = true;
                foreach (BatchProduct prod in batchProds)
                {
                    if (prod.gweight <= 0)
                    {
                        return false;
                    }
                    else if (prod.nweight <= 0)
                    {
                        return false;
                    }
                    else if (prod.qty_carton <= 0)
                    {
                        return false;
                    }
                }

                return isComplete;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            if (isValidInput())
            {
                double gwt = double.Parse(txtGrossWeight.Text.ToString());
                double nwt = double.Parse(txtNetWeight.Text.ToString());
                int qpc = int.Parse(txtQtyPerCarton.Text.ToString());

                batchProds[selectedIndex].gweight = gwt;
                batchProds[selectedIndex].nweight = nwt;
                batchProds[selectedIndex].qty_carton = qpc;

                lvBatchProducts.Items[selectedIndex].SubItems[3].Text = gwt.ToString();
                lvBatchProducts.Items[selectedIndex].SubItems[4].Text = nwt.ToString();
                lvBatchProducts.Items[selectedIndex].SubItems[5].Text = qpc.ToString();
            }
        }

        private void lvBatchProducts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            int lastIndex = selectedIndex;

            try
            {
                selectedIndex = lvBatchProducts.SelectedIndices[0];
                lblProductName.Text = batchProds[selectedIndex].prodf_name;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                if (lastIndex < 0)
                {
                    selectedIndex = -1;
                }
            }
        }

        private void btnMoveBatchToPackaging_Click(object sender, EventArgs e)
        {
            if (isWeighingComplete())
            {
                if (MessageBox.Show("Move Purchase Order Batch to Packaging?", "Confirm Batch Movement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String query = String.Format("INSERT INTO packages (pack_datetime, pob_id) VALUES ((SELECT NOW()), {0})",
                    pob_id);
                    MySqlConnection con = new MySqlConnection(ConString.getConString());
                    MySqlCommand com = new MySqlCommand(query, con);

                    con.Open();
                    com.ExecuteNonQuery();
                    long pack_id = com.LastInsertedId;

                    foreach (BatchProduct prod in batchProds)
                    {
                        query = String.Format("INSERT INTO package_details (pd_gweight, pd_nweight, pd_qty_carton, pob_id, pobp_id, pack_id) " +
                            "VALUES ({0}, {1}, {2}, {3}, {4}, {5})",
                            prod.gweight, prod.nweight, prod.qty_carton, pob_id, prod.pobp_id, pack_id);
                        com = new MySqlCommand(query, con);
                        com.ExecuteNonQuery();
                    }

                    con.Close();
                    query = String.Format("Update products_finished SET prodf_qty = prodf_qty - (Select prodf_qty from purchase_order_batch_products where pob_id = {0}) Where prodf_id = (Select prodf_id from purchase_order_batch_products where pob_id = {0})", pob_id);
                    isMoved = true;
                    MySqlConnection con2 = new MySqlConnection(ConString.getConString());
                    MySqlCommand com2 = new MySqlCommand(query, con);

                    con.Open();
                    com.ExecuteNonQuery();
                    MessageBox.Show("Purchase Order Batch moved to Packaging");
                    this.Close();
                }
            }
        }

        public partial class BatchProduct
        {
            private int _pob_id;
            private int _pobp_id;
            private int _prodf_id;
            private string _prodf_name;
            private int _prodf_qty;
            private int _pack_id;

            private double _gweight;
            private double _nweight;
            private int _qty_carton;

            public int pob_id { get { return this._pob_id; } set { this._pob_id = value; } }
            public int pobp_id { get { return this._pobp_id; } set { this._pobp_id = value; } }
            public int prodf_id { get { return this._prodf_id; } set { this._prodf_id = value; } }
            public string prodf_name { get { return this._prodf_name; } set { this._prodf_name = value; } }
            public int prodf_qty { get { return this._prodf_qty; } set { this._prodf_qty = value; } }

            public double gweight { get { return this._gweight; } set { this._gweight = value; } }
            public double nweight { get { return this._nweight; } set { this._nweight = value; } }
            public int qty_carton { get { return this._qty_carton; } set { this._qty_carton = value; } }
            public int pack_id { get { return this._pack_id; } set { this._pack_id = value; } }
        }

    }
}
