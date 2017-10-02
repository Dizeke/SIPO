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
    public partial class FormPaymentAdd : MetroFramework.Forms.MetroForm
    {
        Client client;
        PurchaseOrderDetail purchaseOrderDetail;
        PurchaseOrderPayment purchaseOrderPayment;

        public FormPaymentAdd()
        {
            InitializeComponent();
            loadClientDetails();
        }

        private void loadClientDetails()
        {
            client = new Client();

            purchaseOrderDetail = PurchaseOrderPaymentHelper.purchaseOrderDetail;
            purchaseOrderPayment = PurchaseOrderPaymentHelper.purchaseOrderPayment;

            String query = "SELECT * FROM clients WHERE client_id  = " + purchaseOrderDetail.client_id;
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();

            reader = com.ExecuteReader();
            while (reader.Read())
            {
                client.id = purchaseOrderDetail.client_id;
                client.company = reader["client_company"].ToString();
                client.tin = reader["client_tin"].ToString();
                client.address = reader["client_address"].ToString();
                client.contact = reader["client_contact"].ToString();
                client.contact_number = reader["client_contact_number"].ToString();
            }

            con.Close();

            displayClientDetails();
        }

        private void displayClientDetails()
        {
            lblCompany.Text = client.company;
            lblContact.Text = client.contact;
            lblContactNumber.Text = client.contact_number;

            lblTotalPayableVal.Text = purchaseOrderDetail.originalTotal.ToString();
            lblBalance.Text = purchaseOrderDetail.balance.ToString();
            lblPaid.Text = purchaseOrderDetail.paid.ToString();
            lblDiscountPercent.Text = purchaseOrderDetail.po_discount.ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            double amount = 0;
            try
            {
                amount = double.Parse(txtPayment.Text.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Please provide a valid amount");
            }

            /**
             * Only accepts amount not more than remaining balance
             */
            if (amount <= purchaseOrderDetail.balance)
            {
                if (MessageBox.Show("Proceed with the payment?", "Payment Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    String query = String.Format("INSERT INTO purchase_order_payments (pop_datetime, pop_amount, po_id) " +
                    "VALUES ((SELECT NOW()), {0}, {1})",
                    amount, purchaseOrderDetail.po_id);
                    MySqlConnection con = new MySqlConnection(ConString.getConString());
                    MySqlCommand com = new MySqlCommand(query, con);

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();

                    if ((purchaseOrderDetail.balance - amount) == 0)
                    {
                        MessageBox.Show("Payment successful. Purchase order is now fully paid.");
                    }
                    else
                    {
                        MessageBox.Show("Payment successful");
                    }

                    updatePaymentStatus();
                    PurchaseOrderPaymentHelper.isComplete = true;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Payment cannot be more than the remaining balance");
            }
        }

        private void updatePaymentStatus()
        {
            String query = "SELECT COALESCE(SUM(pop_amount), 0) AS paid FROM purchase_order_payments WHERE po_id = " + purchaseOrderDetail.po_id;
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();

            bool isFullyPaid = false;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                if (purchaseOrderDetail.total == double.Parse(reader["paid"].ToString()))
                {
                    isFullyPaid = true;
                }
            }
            reader.Close();

            if (isFullyPaid)
            {
                query = "UPDATE purchase_orders SET po_payment = 'Complete' WHERE po_id = " + purchaseOrderDetail.po_id;

            }
            else
            {
                query = "UPDATE purchase_orders SET po_payment = 'Partial' WHERE po_id = " + purchaseOrderDetail.po_id;
            }

            com = new MySqlCommand(query, con);
            com.ExecuteNonQuery();

            con.Close();
        }

        private void btnProductsOrdered_Click(object sender, EventArgs e)
        {
            FormPaymentProductsOrdered formPaymentProductsOrdered = new FormPaymentProductsOrdered(PurchaseOrderPaymentHelper.purchaseOrderDetail.po_id);
            formPaymentProductsOrdered.ShowDialog();
        }
    }
}
