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

namespace SIPO.Manager
{
    public partial class FormPanelClientSelect : MetroFramework.Forms.MetroForm
    {
        List<Client> clients;

        public FormPanelClientSelect()
        {
            InitializeComponent();
            ClientUpdateHolder.hasSelected = false;
            loadClients();
        }

        private void loadClients()
        {
            try
            {
                clients = new List<Client>();

                String query = "SELECT * FROM clients";

                MySqlConnection con = new MySqlConnection(ConString.getConString());
                MySqlCommand com = new MySqlCommand(query, con);
                MySqlDataReader reader;

                con.Open();

                int row = 0;
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

                    lvClients.Items.Add(client.id.ToString());
                    lvClients.Items[row].SubItems.Add(client.company);
                    lvClients.Items[row].SubItems.Add(client.contact);
                    lvClients.Items[row].SubItems.Add(client.contact_number);
                    lvClients.Items[row].SubItems.Add(client.tin);
                    lvClients.Items[row].SubItems.Add(client.address);
                    row++;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lvClients.SelectedItems[0].Index;
                ClientUpdateHolder.client = clients[index];
                ClientUpdateHolder.hasSelected = true;

                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Please select a client to update");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClientUpdateHolder.hasSelected = false;
            this.Close();
        }

    }
}
