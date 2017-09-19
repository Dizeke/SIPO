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
        PurchaseOrder purchaseOrder;
        List<PurchaseOrderProduct> purchaseOrderProducts;
        List<PurchaseOrderProduct> batchProducts;

        public FormPurchaseOrderBatching()
        {
            InitializeComponent();
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

        private void btnProceed_Click(object sender, EventArgs e)
        {

        }
    }
}
