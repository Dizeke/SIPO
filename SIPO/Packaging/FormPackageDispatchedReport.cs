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
    public partial class FormPackageDispatchedReport : MetroFramework.Forms.MetroForm
    {
        int selectedIndex;
        int pack_id;
        string pack_datetime;

        public FormPackageDispatchedReport()
        {
            InitializeComponent();
            selectedIndex = -1;
            pack_id = -1;
            pack_datetime = "";
            BindGrid();
        }

        private void BindGrid()
        {
            String query = "SELECT purchase_order_batches.pob_id AS 'Batch ID', clients.client_company AS 'Company', purchase_orders.po_id AS 'PO ID', pob_datetime AS 'ETA' , packages.pack_id AS 'Package ID' FROM purchase_order_batches INNER JOIN purchase_orders ON purchase_orders.po_id = purchase_order_batches.po_id INNER JOIN packages ON packages.pob_id = purchase_order_batches.pob_id INNER JOIN clients ON purchase_orders.client_id = clients.client_id WHERE pack_id IN (SELECT pack_id FROM packages_dispatched)";

            using (MySqlConnection con = new MySqlConnection(ConString.getConString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int previousIndex = selectedIndex;
            int previousPackage = pack_id;
            string previousDateTime = pack_datetime;

            try
            {
                selectedIndex = dataGridView1.CurrentRow.Index;
                pack_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                pack_datetime = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                selectedIndex = previousIndex;
                pack_id = previousPackage;
                pack_datetime = previousDateTime;
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                FormPackageDetailsReport formPackageDetailsReport = new FormPackageDetailsReport(pack_id, pack_datetime);
                formPackageDetailsReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a package to view");
            }
        }
    }
}
