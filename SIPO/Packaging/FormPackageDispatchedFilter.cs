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
    public partial class FormPackageDispatchedFilter : MetroFramework.Forms.MetroForm
    {
        List<Client> clients;
        public static bool hasFilter = false;
        public static string filter;

        public FormPackageDispatchedFilter()
        {
            InitializeComponent();
            loadClients();

            hasFilter = false;
        }

        private void loadClients()
        {
            clients = new List<Client>();

            String query = "SELECT * FROM clients";
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();

            reader = com.ExecuteReader();
            while (reader.Read())
            {
                Client client = new Client();
                client.id = int.Parse(reader["client_id"].ToString());
                client.company = reader["client_company"].ToString();
                client.contact = reader["client_contact"].ToString();

                clients.Add(client);
            }

            con.Close();
            displayClients();
        }

        private void displayClients()
        {
            int row = 0;
            foreach (Client client in clients)
            {
                cbCompanies.Items.Add(client.company);
                row++;
            }

            if (row > 0)
            {
                cbCompanies.SelectedIndex = 0;
            }
        }

        private void btnFilterByDate_Click(object sender, EventArgs e)
        {
            String from = dtFrom.Value.ToString("yyyy-MM-dd");
            String to = dtTo.Value.ToString("yyyy-MM-dd");

            hasFilter = true;
            filter = String.Format(" AND po_datetime >= '{0}' AND po_datetime <= '{1}'",
                from, to);
            Console.WriteLine(filter);
            this.Close();
        }

        private void btnFilterByCompany_Click(object sender, EventArgs e)
        {
            hasFilter = true;
            filter = " AND clients.client_id = " + clients[cbCompanies.SelectedIndex].id;
            this.Close();
        }
    }
}
