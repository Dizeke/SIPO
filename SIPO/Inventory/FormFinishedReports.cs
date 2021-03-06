﻿using Dapper;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using SIPO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPO.Inventory
{
    public partial class FormFinishedReports : MetroFramework.Forms.MetroForm
    {
        string filter;
        public FormFinishedReports()
        {
            InitializeComponent();
            BindGrid();
        }
        private void ExportToPDF()
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

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
            saveDialog.FileName = "Raw Materials " + String.Format("{0:F}", DateTime.Now);

            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
                MessageBox.Show("Export Successful");
            }

        }

        private void BindGrid()
        {
            String query = "SELECT a.prodf_id AS 'ID', a.prodf_name AS 'Name', a.prodf_desc AS 'Desc', a.prodf_qty AS 'FinQty', a.prodf_srp AS 'Price' FROM products_finished AS a Where (prodf_status = 'approved' OR (prodf_rQty > 0 AND prodf_status = 'pending' ) OR (prodf_rQty = 0 AND prodf_status = 'production'))";
            //String query = "SELECT DISTINCT a.prodf_id AS 'Product ID', a.prodf_name AS 'Product Name', a.prodf_desc AS 'Description', a.prodf_qty AS 'Product Quantity', a.prodf_srp AS 'Price/Srp' FROM products_finished AS a Where prodf_status = 'approved' OR (prodf_rQty > 0 AND prodf_status = 'pending' OR prodf_status = 'production')";
            if (FormFinishedReportFilter.hasFilter)
            {
                query += filter;
            }


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
            using (IDbConnection con = new MySqlConnection(ConString.getConString()))
            {
                finishedProductBindingSource.DataSource = con.Query<Package>(query, commandType: CommandType.Text);

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
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
                worksheet.Name = "Finished Products";

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
                saveDialog.FileName = "Finished Products " + String.Format("{0:F}", DateTime.Now);

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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            String query = "SELECT DISTINCT a.prodf_id AS 'Product ID', a.prodf_name AS 'Product Name', a.prodf_desc AS 'Description', a.prodf_qty AS 'Product Quantity', a.prodf_srp AS 'Price/Srp' FROM products_finished AS a Where prodf_status = 'approved' OR (prodf_rQty > 0 AND prodf_status = 'pending' OR prodf_status = 'production'";

            using (IDbConnection con = new MySqlConnection(ConString.getConString()))
            {
                List<FinishedProduct> list = con.Query<FinishedProduct>(query, commandType: CommandType.Text).ToList();

                //using (FormPackagePrint print = new FormPackagePrint(_obj, list))
                //{
                //    print.ShowDialog();
                //}
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FormFinishedReportFilter formPurchaseOrderReportFilter = new  FormFinishedReportFilter();
            formPurchaseOrderReportFilter.ShowDialog();

            if (FormFinishedReportFilter.hasFilter)
            {
                filter = FormFinishedReportFilter.filter;
            }
            else
            {
                filter = "";
            }
            BindGrid();
        }
    }
}
