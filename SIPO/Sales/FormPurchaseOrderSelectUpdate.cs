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
    public partial class FormPurchaseOrderSelectUpdate : MetroFramework.Forms.MetroForm
    {
        List<PurchaseOrder> pos;
        List<Client> clients;

        int selectedIndex;

        public FormPurchaseOrderSelectUpdate()
        {
            InitializeComponent();
            selectedIndex = -1;

            loadPurchaseOrders();
        }

        private void loadPurchaseOrders()
        {
            pos = new List<PurchaseOrder>();
            clients = new List<Client>();

            String queryPO = "SELECT * FROM purchase_orders";
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand comPO = new MySqlCommand(queryPO, con);
            MySqlDataReader reader;

            con.Open();

            reader = comPO.ExecuteReader();
            while (reader.Read())
            {
                PurchaseOrder po = new PurchaseOrder();
                po.id = int.Parse(reader["po_id"].ToString());
                po.datetime = reader["po_datetime"].ToString();
                po.client_id = int.Parse(reader["client_id"].ToString());
                po.payment = reader["po_payment"].ToString();

                MySqlConnection conClient = new MySqlConnection(ConString.getConString());
                String queryClient = "SELECT * FROM clients WHERE client_id = " + po.client_id;
                MySqlCommand comClient = new MySqlCommand(queryClient, conClient);

                conClient.Open();
                MySqlDataReader readerClient = comClient.ExecuteReader();

                while (readerClient.Read())
                {
                    Client client = new Client();
                    client.id = po.client_id;
                    client.company = readerClient["client_company"].ToString();
                    client.tin = readerClient["client_tin"].ToString();
                    client.address = readerClient["client_address"].ToString();
                    client.contact = readerClient["client_contact"].ToString();
                    client.contact_number = readerClient["client_contact_number"].ToString();

                    clients.Add(client);
                }
                readerClient.Close();
                conClient.Close();

                pos.Add(po);
            }

            con.Close();
            displayPurchaseOrders();
        }

        private void displayPurchaseOrders()
        {
            int index = 0;
            int row = 0;
            foreach (PurchaseOrder po in pos)
            {
                lvPurchaseOrders.Items.Add(po.id.ToString());
                lvPurchaseOrders.Items[row].SubItems.Add(clients[index].company);
                lvPurchaseOrders.Items[row].SubItems.Add(clients[index].tin);
                lvPurchaseOrders.Items[row].SubItems.Add(po.payment);
                lvPurchaseOrders.Items[row].SubItems.Add(po.datetime.ToString());

                index++;
                row++;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectedIndex.ToString());
            MessageBox.Show(pos[selectedIndex].id.ToString());
        }

        private void lvPurchaseOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            int previousIndex = selectedIndex;
            try
            {
                selectedIndex = lvPurchaseOrders.SelectedIndices[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                selectedIndex = previousIndex;
            }
        }
    }
}
