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
    public partial class FormPackageReceiveDispatched : MetroFramework.Forms.MetroForm
    {
        List<PackageDispatched> packagesDispatched;
        int selectedIndex;

        public FormPackageReceiveDispatched()
        {
            InitializeComponent();
            selectedIndex = -1;

            loadDispatchedPackages();
        }

        private void loadDispatchedPackages()
        {
            packagesDispatched = new List<PackageDispatched>();

            MySqlConnection con = new MySqlConnection(ConString.getConString());
            con.Open();

            String query = String.Format("SELECT packd_id, packages.pack_id, purchase_order_batches.pob_id, packd_datetime, pob_datetime, packd_status, pack_datetime, purchase_orders.po_id, po_payment, po_status, po_discount, po_datetime, clients.client_id, client_company FROM packages_dispatched INNER JOIN packages ON packages_dispatched.pack_id = packages.pack_id INNER JOIN purchase_order_batches ON purchase_order_batches.pob_id = packages.pob_id INNER JOIN purchase_orders ON purchase_order_batches.po_id = purchase_orders.po_id INNER JOIN clients ON purchase_orders.client_id = clients.client_id WHERE packd_status = 'Dispatched'");
            MySqlCommand com = new MySqlCommand(query, con);

            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                PackageDispatched pd = new PackageDispatched();
                pd.packd_id = int.Parse(reader["packd_id"].ToString());
                pd.pack_id = int.Parse(reader["pack_id"].ToString());
                pd.po_id = int.Parse(reader["po_id"].ToString());
                pd.pob_id = int.Parse(reader["pob_id"].ToString());
                pd.client_id = int.Parse(reader["client_id"].ToString());

                pd.pack_datetime = reader["pack_datetime"].ToString();
                pd.packd_datetime = reader["packd_datetime"].ToString();
                pd.packd_status = reader["packd_status"].ToString();
                pd.client_company = reader["client_company"].ToString();
                pd.po_status = reader["po_status"].ToString();
                pd.po_payment = reader["po_payment"].ToString();
                pd.pob_datetime = reader["pob_datetime"].ToString();

                packagesDispatched.Add(pd);
            }

            con.Close();
            displayDispatchedPackages();
        }

        private void displayDispatchedPackages()
        {
            int row = 0;
            foreach (PackageDispatched pd in packagesDispatched)
            {
                lvPackages.Items.Add(pd.po_id.ToString());
                lvPackages.Items[row].SubItems.Add(pd.pob_id.ToString());
                lvPackages.Items[row].SubItems.Add(pd.client_company);
                lvPackages.Items[row].SubItems.Add(pd.po_payment);
                lvPackages.Items[row].SubItems.Add(pd.pob_datetime);

                row++;
            }
        }

        private void lvPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int previousIndex = selectedIndex;
            try
            {
                selectedIndex = lvPackages.SelectedIndices[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                selectedIndex = previousIndex;
            }
        }

        private void btnMarkAsReceived_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                if (MessageBox.Show("Mark package as received?", "Package Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    String query = String.Format("UPDATE packages_dispatched SET packd_status = 'Received' WHERE packd_id = {0}",
                        packagesDispatched[selectedIndex].pack_id);
                    MySqlConnection con = new MySqlConnection(ConString.getConString());
                    MySqlCommand com = new MySqlCommand(query, con);

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();

                    lvPackages.Items.RemoveAt(selectedIndex);
                    packagesDispatched.RemoveAt(selectedIndex);
                    selectedIndex = -1;
                }
            }
        }
    }
}
