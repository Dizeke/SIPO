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
    public partial class FormPackageDispatchSelect : MetroFramework.Forms.MetroForm
    {
        List<PurchaseOrderBatch> batches;

        public FormPackageDispatchSelect()
        {
            InitializeComponent();
            loadPackages();
        }

        private void loadPackages()
        {
            batches = new List<PurchaseOrderBatch>();

            String query = "SELECT purchase_order_batches.pob_id, purchase_orders.po_id, pob_datetime, packages.pack_id FROM purchase_order_batches INNER JOIN purchase_orders ON purchase_orders.po_id = purchase_order_batches.po_id INNER JOIN packages ON packages.pob_id = purchase_order_batches.pob_id WHERE pack_id NOT IN (SELECT pack_id FROM packages_dispatched)";
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();

            reader = com.ExecuteReader();
            while (reader.Read())
            {
                PurchaseOrderBatch batch = new PurchaseOrderBatch();
                batch.id = int.Parse(reader["pob_id"].ToString());
                batch.po_id = int.Parse(reader["po_id"].ToString());
                batch.datetime = reader["pob_datetime"].ToString();
                batch.pack_id = int.Parse(reader["pack_id"].ToString());

                batches.Add(batch);
            }

            con.Close();
            displayPackages();
        }

        private void displayPackages()
        {
            lvBatches.Items.Clear();

            int row = 0;
            foreach (PurchaseOrderBatch batch in batches)
            {
                lvBatches.Items.Add(batch.po_id.ToString());
                lvBatches.Items[row].SubItems.Add(batch.id.ToString());
                lvBatches.Items[row].SubItems.Add(batch.datetime);

                row++;
            }
        }

        private void btnDispatchPackage_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;
            try
            {
                selectedIndex = lvBatches.SelectedIndices[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Please select a Batch to Dispatch");
                return;
            }

            PurchaseOrderBatch dispatch = batches[selectedIndex];

            String query = String.Format("INSERT INTO packages_dispatched (packd_datetime, pack_id) VALUES ((SELECT NOW()), {0})",
                dispatch.pack_id);

            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Package has been dispatched");
            loadPackages();
        }
    }
}
