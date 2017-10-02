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
        List<FinishedProduct> finishedProducts; // Products List
        List<FinishedProduct> requestedProducts; //Requested Products List

        bool hasFilter;
        String filter = "";

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
            lvProductList.Items.Clear();

            try
            {
                String query = "SELECT * FROM products_finished";
                if (hasFilter)
                {
                    query += filter;
                }

                Console.WriteLine(query);

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
            try
            {
                quantity = int.Parse(txtQuantity.Text.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Please provide a valid quantity");
                return;
            }

            int selectedFinishedProductIndex = 0;
            try
            {
                selectedFinishedProductIndex = lvProductList.Items.IndexOf(lvProductList.SelectedItems[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Please select a product to add to purchase order");
                return;
            }

            try
            {
                //if ((finishedProducts[selectedFinishedProductIndex].Qty) >= quantity && quantity > 0)
                //{
                bool isAdded = false;
                int prodIndex = 0;

                FinishedProduct requestProduct = new FinishedProduct();
                requestProduct.Id = finishedProducts[selectedFinishedProductIndex].Id;
                requestProduct.Name = finishedProducts[selectedFinishedProductIndex].Name;
                requestProduct.Desc = finishedProducts[selectedFinishedProductIndex].Desc;
                requestProduct.Qty = finishedProducts[selectedFinishedProductIndex].Qty;
                requestProduct.Price = finishedProducts[selectedFinishedProductIndex].Price;

                foreach (FinishedProduct requestedProduct in requestedProducts)
                {
                    if (requestedProduct.Id == requestProduct.Id)
                    {
                        //if (quantity > 0 && requestProduct.Qty >= requestedProduct.Qty + quantity)
                        //{
                        isAdded = true;
                        requestedProducts[prodIndex].Qty += quantity;
                        break;
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Please provide a quantity not more than the available stock");
                        //    return;
                        //}
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
                    //if ((finishedProducts[selectedFinishedProductIndex].Qty) >= quantity && quantity > 0)
                    //{
                    requestProduct.Qty = quantity;
                    requestedProducts.Add(requestProduct);

                    lvPurchaseList.Items.Add(requestProduct.Id.ToString());
                    lvPurchaseList.Items[lvPurchaseList.Items.Count - 1].SubItems.Add(requestProduct.Name);
                    lvPurchaseList.Items[lvPurchaseList.Items.Count - 1].SubItems.Add(requestProduct.Qty.ToString());
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Please provide a quantity not more than the available stock");
                    //    return;
                    //}
                }
                //}
                //else
                //{
                //    MessageBox.Show("Please provide a quantity not more than the available stock");
                //    return;
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void btnAddCustomProduct_Click(object sender, EventArgs e)
        {
            ProductCustomHelper.finishedProduct = new FinishedProduct();
            ProductCustomHelper.isComplete = false;

            FormPurchaseOrderCustomAdd formPurchaseOrderCustomAdd = new FormPurchaseOrderCustomAdd();
            formPurchaseOrderCustomAdd.ShowDialog();

            if (ProductCustomHelper.isComplete)
            {
                FinishedProduct customProduct = ProductCustomHelper.finishedProduct;

                requestedProducts.Add(customProduct);
                lvPurchaseList.Items.Add(customProduct.Id.ToString());
                lvPurchaseList.Items[lvPurchaseList.Items.Count - 1].SubItems.Add(customProduct.Name);
                lvPurchaseList.Items[lvPurchaseList.Items.Count - 1].SubItems.Add(customProduct.Qty.ToString());
            }
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
            PurchaseOrderHelper.isComplete = false;

            if (requestedProducts.Count > 0)
            {
                Client selectedClient = new Client();
                foreach (Client client in clients)
                {
                    if (cbClient.SelectedItem.Equals(client.company))
                    {
                        selectedClient = client;
                        break;
                    }
                }

                List<PurchaseOrderProduct> purchaseOrderProducts = new List<PurchaseOrderProduct>();
                foreach (FinishedProduct product in requestedProducts)
                {
                    PurchaseOrderProduct purchaseOrderProduct = new PurchaseOrderProduct();
                    purchaseOrderProduct.prodf_id = product.Id;
                    purchaseOrderProduct.prodf_quantity = product.Qty;
                    purchaseOrderProduct.finishedProduct = product;

                    purchaseOrderProducts.Add(purchaseOrderProduct);
                }

                PurchaseOrder purchaseOrder = new PurchaseOrder();
                purchaseOrder.client_id = selectedClient.id;
                purchaseOrder.status = "Pending";

                if (rbtnDisc0.Checked)
                {
                    purchaseOrder.discount = 0;
                }
                else if (rbtnDisc5.Checked)
                {
                    purchaseOrder.discount = 5;
                }
                else if (rbtnDisc10.Checked)
                {
                    purchaseOrder.discount = 10;
                }
                else if (rbtnDisc15.Checked)
                {
                    purchaseOrder.discount = 15;
                }
                else if (rbtnDisc20.Checked)
                {
                    purchaseOrder.discount = 20;
                }

                PurchaseOrderHelper.purchaseOrder = purchaseOrder;
                PurchaseOrderHelper.purchaseOrderProducts = purchaseOrderProducts;
                PurchaseOrderHelper.purchaseOrderBatches = new List<PurchaseOrderBatch>();

                FormPurchaseOrderBatching formPurchaseOrderBatching = new FormPurchaseOrderBatching();
                formPurchaseOrderBatching.ShowDialog();

                if (PurchaseOrderHelper.isComplete)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please add products for purchase order before you proceed");
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilter.Text.ToString().Trim().Length > 0)
                {
                    filter = " WHERE prodf_name LIKE '%" + txtFilter.Text.ToString().Trim() + "%'";
                    hasFilter = true;
                }
                else
                {
                    hasFilter = false;
                }

                loadProducts();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                hasFilter = false;
            }
        }
    }
}
