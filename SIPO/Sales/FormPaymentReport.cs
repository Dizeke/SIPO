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
        String filter = "";

        int po_id;
        string company;

        public FormPaymentReport()
        {
            InitializeComponent();
            filter = "";
            selectedIndex = -1;
            po_id = -1;
            company = "";
            BindGrid();
        }

        private void BindGrid()
        {
            String query = "SELECT purchase_orders.po_id AS 'PO ID', po_datetime AS 'Date Created', po_payment AS 'Payment Status', clients.client_company AS 'Company' FROM purchase_orders INNER JOIN clients ON purchase_orders.client_id = clients.client_id  WHERE po_id IN ( SELECT po_id FROM (SELECT purchase_orders.po_id, products_finished.prodf_srp FROM purchase_orders INNER JOIN purchase_order_batches ON purchase_orders.po_id = purchase_order_batches.po_id INNER JOIN purchase_order_batch_products ON purchase_order_batches.pob_id = purchase_order_batch_products.pobp_id INNER JOIN products_finished ON purchase_order_batch_products.prodf_id = products_finished.prodf_id HAVING products_finished.prodf_srp > 0) as tblUpdatedProductsOnly ) " + filter;
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
        private void ExportToExcel()
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Payment Report";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {

                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex].Font.Bold = true;
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Rows[i - 1].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                ;
                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;
                saveDialog.FileName = "Payment Report " + String.Format("{0:F}", DateTime.Now);

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = "";

            FormPaymentReportFilter formPaymentReportFilter = new FormPaymentReportFilter();
            formPaymentReportFilter.ShowDialog();

            if (FormPaymentReportFilter.hasFilter)
            {
                filter = FormPaymentReportFilter.filter;
            }

            BindGrid();
        }
    }
}
