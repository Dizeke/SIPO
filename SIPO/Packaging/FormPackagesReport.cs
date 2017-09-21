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
    public partial class FormPackagesReport : MetroFramework.Forms.MetroForm
    {
        List<PurchaseOrderBatch> batches;

        public FormPackagesReport()
        {
            InitializeComponent();
            loadPackages();
        }

        private void loadPackages()
        {
            batches = new List<PurchaseOrderBatch>();

            String query = "SELECT purchase_order_batches.pob_id, clients.client_company, purchase_orders.po_id, pob_datetime, packages.pack_id FROM purchase_order_batches INNER JOIN purchase_orders ON purchase_orders.po_id = purchase_order_batches.po_id INNER JOIN packages ON packages.pob_id = purchase_order_batches.pob_id INNER JOIN clients ON purchase_orders.client_id = clients.client_id WHERE pack_id NOT IN (SELECT pack_id FROM packages_dispatched)";
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
                batch.company_name = reader["client_company"].ToString();
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
                lvBatches.Items[row].SubItems.Add(batch.company_name);
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
                MessageBox.Show("Please select a Batch to to view");
                return;
            }

            PurchaseOrderBatch dispatch = batches[selectedIndex];

            FormPackageDetailsReport formPackageDetailsReport = new FormPackageDetailsReport(dispatch.pack_id, dispatch.datetime);
            formPackageDetailsReport.ShowDialog();
        }
    }
}
