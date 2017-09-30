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
    public partial class FormPurchaseOrderBatching : MetroFramework.Forms.MetroForm
    {
        PurchaseOrder purchaseOrder; //Current Purchase Order Detail
        List<PurchaseOrderProduct> purchaseOrderProducts; //Request Purchase Order
        List<PurchaseOrderProduct> batchProducts; //Batch of Purchase Order

        public FormPurchaseOrderBatching()
        {
            InitializeComponent();
            dtBatchTime.Format = DateTimePickerFormat.Time;
            dtBatchTime.ShowUpDown = true;
            loadPurchaseOrders();
        }

        private void loadPurchaseOrders()
        {
            purchaseOrder = PurchaseOrderHelper.purchaseOrder;
            purchaseOrderProducts = PurchaseOrderHelper.purchaseOrderProducts;
            batchProducts = new List<PurchaseOrderProduct>();

            int row = 0;
            foreach (PurchaseOrderProduct product in purchaseOrderProducts)
            {
                lvPurchaseOrders.Items.Add(product.finishedProduct.Id.ToString());
                lvPurchaseOrders.Items[row].SubItems.Add(product.finishedProduct.Name);
                lvPurchaseOrders.Items[row].SubItems.Add(product.finishedProduct.Qty.ToString());
                row++;
            }
        }

        private void btnAddToBatch_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;
            try
            {
                selectedIndex = lvPurchaseOrders.SelectedItems.IndexOf(lvPurchaseOrders.SelectedItems[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Please select a product to add to the batch");
                return;
            }

            try
            {
                PurchaseOrderProduct targetRemove = new PurchaseOrderProduct();
                foreach (PurchaseOrderProduct product in purchaseOrderProducts)
                {
                    if (product.prodf_id == int.Parse(lvPurchaseOrders.Items[selectedIndex].Text.ToString()))
                    {
                        PurchaseOrderProduct batchProduct = new PurchaseOrderProduct();
                        batchProduct.prodf_id = product.prodf_id;
                        batchProduct.prodf_quantity = product.prodf_quantity;
                        batchProduct.finishedProduct = product.finishedProduct;

                        batchProducts.Add(batchProduct);

                        lvBatchList.Items.Add(batchProduct.finishedProduct.Id.ToString());
                        lvBatchList.Items[lvBatchList.Items.Count - 1].SubItems.Add(batchProduct.finishedProduct.Name);
                        lvBatchList.Items[lvBatchList.Items.Count - 1].SubItems.Add(batchProduct.finishedProduct.Qty.ToString());
                        lvPurchaseOrders.Items.RemoveAt(selectedIndex);

                        targetRemove = product;
                        break;
                    }
                }

                purchaseOrderProducts.Remove(targetRemove);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void btnRemoveFromBatch_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;
            try
            {
                selectedIndex = lvBatchList.SelectedItems.IndexOf(lvBatchList.SelectedItems[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Please select a product to remove from the batch");
                return;
            }

            try
            {
                PurchaseOrderProduct targetRemove = new PurchaseOrderProduct();
                foreach (PurchaseOrderProduct batchProduct in batchProducts)
                {
                    if (batchProduct.prodf_id == int.Parse(lvBatchList.Items[selectedIndex].Text.ToString()))
                    {
                        PurchaseOrderProduct product = new PurchaseOrderProduct();
                        product.prodf_id = batchProduct.prodf_id;
                        product.prodf_quantity = batchProduct.prodf_quantity;
                        product.finishedProduct = batchProduct.finishedProduct;

                        purchaseOrderProducts.Add(batchProduct);

                        lvPurchaseOrders.Items.Add(product.finishedProduct.Id.ToString());
                        lvPurchaseOrders.Items[lvPurchaseOrders.Items.Count - 1].SubItems.Add(product.finishedProduct.Name);
                        lvPurchaseOrders.Items[lvPurchaseOrders.Items.Count - 1].SubItems.Add(product.finishedProduct.Qty.ToString());
                        lvBatchList.Items.RemoveAt(selectedIndex);

                        targetRemove = product;
                        break;
                    }
                }

                batchProducts.Remove(targetRemove);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        //purchaseOrder; Current Purchase Order Detail
        //purchaseOrderProducts; Request Purchase Order
        //batchProducts; Batch of Purchase Order

        private void btnProceed_Click(object sender, EventArgs e)
        {
            string date = dtBatchDate.Value.ToString("yyyy-MM-dd");
            string time = dtBatchTime.Value.ToString("HH:mm:ss");
            PurchaseOrderBatch purchaseOrderBatch = new PurchaseOrderBatch();
            purchaseOrderBatch.datetime = date + " " + time;
            purchaseOrderBatch.purchaseOrderProducts = batchProducts;

            /**
             * Proceed only if there are products added to the batch
             */
            if (lvBatchList.Items.Count > 0)
            {
                PurchaseOrderHelper.purchaseOrderBatches.Add(purchaseOrderBatch);
                //MessageBox.Show("PO Products Size: " + purchaseOrderProducts.Count + " Batch Products Size: " + batchProducts.Count + " Batch Count: " + PurchaseOrderHelper.purchaseOrderBatches.Count);
            }
            else
            {
                MessageBox.Show("Please add a product to the batch list before proceeding");
                return;
            }

            /* If there are no more products to add to batch
             * Means adding of batch is complete
             */
            if (purchaseOrderProducts.Count < 1)
            {
                MySqlConnection con = new MySqlConnection(ConString.getConString());
                MySqlCommand com;

                con.Open();

                /**
                 * Insert the Purchase Order
                 */
                String queryInsertPurchaseOrder = String.Format("INSERT INTO purchase_orders (po_datetime, po_discount, client_id) " +
                    "VALUES ((SELECT NOW()), {0}, {1})", purchaseOrder.discount, purchaseOrder.client_id);
                com = new MySqlCommand(queryInsertPurchaseOrder, con);
                com.ExecuteNonQuery();
                long po_id = com.LastInsertedId;

                /**
                 * Insert the the Purchase Order Products by Batch
                 */
                foreach (PurchaseOrderBatch batch in PurchaseOrderHelper.purchaseOrderBatches)
                {
                    /**
                     * Inserts the Batch
                     */
                    String queryInsertPurchaseOrderBatch = String.Format("INSERT INTO purchase_order_batches (pob_datetime, po_id) " +
                        "VALUES ('{0}', {1})", batch.datetime, po_id);
                    com = new MySqlCommand(queryInsertPurchaseOrderBatch, con);
                    com.ExecuteNonQuery();
                    long pob_id = com.LastInsertedId;

                    /**
                     * Inserts the Products in the Batch
                     */
                    int counter = 1;
                    String queryInsertPuchaseOrderBatchProducts = "INSERT INTO purchase_order_batch_products (prodf_id, prodf_qty, pob_id) VALUES ";
                    foreach (PurchaseOrderProduct product in batch.purchaseOrderProducts)
                    {
                        queryInsertPuchaseOrderBatchProducts += String.Format("({0}, {1}, {2})",
                            product.prodf_id, product.prodf_quantity, pob_id);

                        if (counter < batch.purchaseOrderProducts.Count)
                            queryInsertPuchaseOrderBatchProducts += ",";
                        counter++;
                    }
                    com = new MySqlCommand(queryInsertPuchaseOrderBatchProducts, con);
                    com.ExecuteNonQuery();
                }

                con.Close();

                MessageBox.Show("Product batching complete. Purchase Order has been created.", "Purchase Order Created");
                PurchaseOrderHelper.isComplete = true;
                this.Close();
            }
            else
            {
                this.Hide();

                FormPurchaseOrderBatching formPurchaseOrderBatching = new FormPurchaseOrderBatching();
                formPurchaseOrderBatching.ShowDialog();

                this.Close();
            }
        }
    }
}
