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
    public partial class FormPaymentReport : MetroFramework.Forms.MetroForm
    {
        int selectedIndex;

        int po_id;
        string company;

        public FormPaymentReport()
        {
            InitializeComponent();
            selectedIndex = -1;
            po_id = -1;
            company = "";
            BindGrid();
        }

        private void BindGrid()
        {
            String query = "SELECT purchase_orders.po_id AS 'PO ID', po_datetime AS 'Date Created', po_payment AS 'Payment Status', clients.client_company FROM purchase_orders INNER JOIN clients ON purchase_orders.client_id = clients.client_id  WHERE po_id IN ( SELECT po_id FROM (SELECT purchase_orders.po_id, products_finished.prodf_srp FROM purchase_orders INNER JOIN purchase_order_batches ON purchase_orders.po_id = purchase_order_batches.po_id INNER JOIN purchase_order_batch_products ON purchase_order_batches.pob_id = purchase_order_batch_products.pobp_id INNER JOIN products_finished ON purchase_order_batch_products.prodf_id = products_finished.prodf_id HAVING products_finished.prodf_srp > 0) as tblUpdatedProductsOnly )";
            using (MySqlConnection con = new MySqlConnection(ConString.getConString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                FormPaymentDetailsReport formPaymentDetailsReport = new FormPaymentDetailsReport(po_id, company);
                formPaymentDetailsReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a payment to view");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int previousIndex = selectedIndex;
            int previousPO = po_id;
            string previousCompany = company;

            try
            {
                selectedIndex = dataGridView1.CurrentRow.Index;
                po_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                company = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                selectedIndex = previousIndex;
                po_id = previousPO;
                company = previousCompany;
            }
        }
    }
}
