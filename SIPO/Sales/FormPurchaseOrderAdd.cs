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
        List<FinishedProduct> finishedProducts;
        List<FinishedProduct> requestedProducts;

        public FormPurchaseOrderAdd()
        {
            InitializeComponent();
            loadClients();
            loadProducts();
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

            if (clients.Count > 0)
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

        private void loadProducts()
        {
            finishedProducts = new List<FinishedProduct>();
            requestedProducts = new List<FinishedProduct>();

            try
            {
                String query = "SELECT * FROM products_finished";
                MySqlConnection con = new MySqlConnection(ConString.getConString());
                MySqlCommand com = new MySqlCommand(query, con);
                MySqlDataReader reader;

                con.Open();

                int row = 0;
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    FinishedProduct finishedProduct = new FinishedProduct();
                    finishedProduct.Id = int.Parse(reader["prodf_id"].ToString());
                    finishedProduct.Name = reader["prodf_name"].ToString();
                    finishedProduct.Desc = reader["prodf_desc"].ToString();
                    finishedProduct.Qty = int.Parse(reader["prodf_qty"].ToString());
                    finishedProduct.Price = double.Parse(reader["prodf_srp"].ToString());

                    finishedProducts.Add(finishedProduct);

                    lvProductList.Items.Add(finishedProduct.Id.ToString());
                    lvProductList.Items[row].SubItems.Add(finishedProduct.Name);
                    lvProductList.Items[row].SubItems.Add(finishedProduct.Qty.ToString());

                    row++;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int quantity = 0;
            int selectedFinishedProductIndex = 0;

            try
            {
                quantity = int.Parse(txtQuantity.Text.ToString());
                selectedFinishedProductIndex = lvProductList.Items.IndexOf(lvProductList.SelectedItems[0]);

                if (finishedProducts[selectedFinishedProductIndex].Qty >= quantity && quantity > 0)
                {
                    bool isAdded = false;
                    int prodIndex = 0;

                    FinishedProduct requestProduct = finishedProducts[selectedFinishedProductIndex];
                    foreach (FinishedProduct requestedProduct in requestedProducts)
                    {
                        if (requestedProduct.Id == requestProduct.Id)
                        {
                            isAdded = true;
                            requestedProducts[prodIndex].Qty += quantity;
                            break;
                        }
                        else
                        {
                            prodIndex++;
                        }
                    }

                    if (isAdded)
                    {
                        for (int i = 0; i < lvProductList.Items.Count; i++)
                        {
                            if (lvPurchaseList.Items[i].Text.Equals(finishedProducts[selectedFinishedProductIndex].Id.ToString()))
                            {
                                lvPurchaseList.Items[i].SubItems[2].Text = requestedProducts[prodIndex].Qty.ToString();
                                break;
                            }
                        }
                    }
                    else
                    {
                        requestProduct.Qty = quantity;
                        requestedProducts.Add(requestProduct);

                        lvPurchaseList.Items.Add(requestProduct.Id.ToString());
                        lvPurchaseList.Items[lvPurchaseList.Items.Count - 1].SubItems.Add(requestProduct.Name);
                        lvPurchaseList.Items[lvPurchaseList.Items.Count - 1].SubItems.Add(requestProduct.Qty.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void btnAddCustomProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;

            try
            {
                selectedIndex = lvPurchaseList.Items.IndexOf(lvPurchaseList.SelectedItems[0]);
                requestedProducts.RemoveAt(selectedIndex);
                lvPurchaseList.Items.RemoveAt(selectedIndex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void btnAddPurchaseOrder_Click(object sender, EventArgs e)
        {

        }

    }
}
