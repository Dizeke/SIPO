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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SIPO.Sales
{
    public partial class FormPurchaseOrderReport : MetroFramework.Forms.MetroForm
    {

        int selectedIndex;
        int po_id;

        public FormPurchaseOrderReport()
        {
            InitializeComponent();
            selectedIndex = -1;
            po_id = -1;
            BindGrid();
        }
        

        private void BindGrid()
        {
            String query = "SELECT purchase_orders.po_id AS 'PO ID', clients.client_company AS 'Company', purchase_orders.po_datetime AS 'Added On', tblTotal.total AS 'Total', tblPaid.pop_amount AS 'Paid', (tblTotal.total - tblPaid.pop_amount) AS 'Balance' FROM purchase_orders INNER JOIN clients ON clients.client_id = purchase_orders.client_id, ( SELECT purchase_orders.po_id, COALESCE(SUM(pop_amount), 0) AS pop_amount FROM purchase_order_payments RIGHT JOIN purchase_orders ON purchase_order_payments.po_id = purchase_orders.po_id GROUP BY purchase_orders.po_id ) AS tblPaid, ( SELECT purchase_orders.po_id, SUM(products_finished.prodf_srp * purchase_order_batch_products.prodf_qty) AS total FROM purchase_order_batch_products INNER JOIN products_finished ON purchase_order_batch_products.prodf_id = products_finished.prodf_id INNER JOIN purchase_order_batches ON purchase_order_batch_products.pob_id = purchase_order_batches.pob_id INNER JOIN purchase_orders ON purchase_order_batches.po_id = purchase_orders.po_id GROUP BY purchase_orders.po_id ) AS tblTotal WHERE tblPaid.po_id = purchase_orders.po_id AND tblTotal.po_id = purchase_orders.po_id";
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


        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
        private void ExportToPDF()
        {
            PdfPTable pdfTable1 = new PdfPTable(1);//Here 1 is Used For Count of Column 
            PdfPTable pdfTable2 = new PdfPTable(1);
            PdfPTable pdfTable3 = new PdfPTable(2);


            Chunk c1 = new Chunk("Purhcase Order", FontFactory.GetFont("Times New Roman"));
            c1.Font.Color = new iTextSharp.text.Color(0, 0, 0);
            c1.Font.SetStyle(0);
            c1.Font.Size = 14;
            Phrase p1 = new Phrase();
            p1.Add(c1);
            pdfTable1.AddCell(p1);
            Chunk c2 = new Chunk("", FontFactory.GetFont("Times New Roman"));
            c2.Font.Color = new iTextSharp.text.Color(0, 0, 0);
            c2.Font.SetStyle(0);//0 For Normal Font 
            c2.Font.Size = 11;
            Phrase p2 = new Phrase();
            p2.Add(c2);
            pdfTable2.AddCell(p2);
            Chunk c3 = new Chunk("", FontFactory.GetFont("Times New Roman"));
            c3.Font.Color = new iTextSharp.text.Color(0, 0, 0);
            c3.Font.SetStyle(0);
            c3.Font.Size = 11;
            Phrase p3 = new Phrase();
            p3.Add(c3);
            pdfTable2.AddCell(p3);

            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.Padding = 5;
            pdfTable.WidthPercentage = 80;
            pdfTable.DefaultCell.BorderWidth = 0.0f;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {

                    }
                    else
                    {
                       
                        pdfTable.AddCell(cell.Value.ToString());
                    }


                }
            }


            //Exporting to PDF
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Pdf Files|*.pdf";
            saveDialog.FilterIndex = 2;
            saveDialog.FileName = "Purchase Order " + String.Format("{0:F}", DateTime.Now);

            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    
                    
                    pdfDoc.Add(pdfTable1);
                    pdfDoc.Add(pdfTable2);
                    pdfDoc.Add(pdfTable3);
                    pdfDoc.Add(pdfTable);
                    pdfDoc.NewPage();
                    pdfDoc.Close();
                    stream.Close();
                }
                MessageBox.Show("Export Successful");
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

                worksheet.Name = "Purchase Order";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
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

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;
                saveDialog.FileName = "Purchase Order " + String.Format("{0:F}", DateTime.Now);

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int previousIndex = selectedIndex;
            int previousPO = po_id;
            try
            {
                selectedIndex = dataGridView1.CurrentRow.Index;
                po_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                selectedIndex = previousIndex;
                po_id = previousPO;
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                FormPurchaseOrderDetailsReport formPurchaseOrderDetailsReport = new FormPurchaseOrderDetailsReport(po_id);
                formPurchaseOrderDetailsReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a purchase order to view");
            }
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }
        
    }
}
