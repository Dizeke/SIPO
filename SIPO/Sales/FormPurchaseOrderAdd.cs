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
    public partial class FormPurchaseOrderAdd : MetroFramework.Forms.MetroForm
    {
        List<Client> clients;

        public FormPurchaseOrderAdd()
        {
            InitializeComponent();
            loadClients();
        }

        private void loadClients()
        {
            bool hasItems = false;

            try
            {
                clients = new List<Client>();

                String query = "SELECT * FROM clients";
                MySqlConnection con = new MySqlConnection(ConString.getConString());
                MySqlCommand com = new MySqlCommand(query, con);
                MySqlDataReader reader;

                con.Open();

                cbClient.Items.Clear();
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Client client = new Client();
                    client.id = int.Parse(reader["client_id"].ToString());
                    client.company = reader["client_company"].ToString();
                    client.tin = reader["client_tin"].ToString();
                    client.address = reader["client_address"].ToString();
                    client.contact = reader["client_contact"].ToString();
                    client.contact_number = reader["client_contact_number"].ToString();

                    clients.Add(client);
                    cbClient.Items.Add(client.company);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            if(clients.Count > 0)
            {
                hasItems = true;
            }

            if (hasItems)
            {
                cbClient.SelectedIndex = 0;
            }
            else
            {
                cbClient.Enabled = false;
                btnAddCustomProduct.Enabled = false;
                btnAddPurchaseOrder.Enabled = false;
            }
        }

    }
}
