﻿using System;
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
using Dapper;

namespace SIPO.Packaging
{
    public partial class FormPackageDispatchedReport : MetroFramework.Forms.MetroForm
    {
        int selectedIndex;
        int pack_id;
        string pack_datetime;
        String filter = "";

        public FormPackageDispatchedReport()
        {
            InitializeComponent();
            selectedIndex = -1;
            pack_id = -1;
            pack_datetime = "";
            BindGrid();
        }

        private void BindGrid()
        {
            String query = "SELECT purchase_order_batches.pob_id AS 'BatchID', clients.client_company AS 'Company', purchase_orders.po_id AS 'POID', pob_datetime AS 'ETA' , packages.pack_id AS 'PackageID' FROM purchase_order_batches INNER JOIN purchase_orders ON purchase_orders.po_id = purchase_order_batches.po_id INNER JOIN packages ON packages.pob_id = purchase_order_batches.pob_id INNER JOIN clients ON purchase_orders.client_id = clients.client_id WHERE pack_id IN (SELECT pack_id FROM packages_dispatched)";
            if (FormPackageDispatchedFilter.hasFilter)
            {
                query += FormPackageDispatchedFilter.filter;
            }

            using (IDbConnection con = new MySqlConnection(ConString.getConString()))
            {
                packageBindingSource.DataSource = con.Query<Package>(query, commandType: CommandType.Text);
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

                worksheet.Name = "Packages";

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
                saveDialog.FileName = "Packages " + String.Format("{0:F}", DateTime.Now);

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
            int previousPackage = pack_id;
            string previousDateTime = pack_datetime;

            try
            {
                selectedIndex = dataGridView1.CurrentRow.Index;
                pack_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                pack_datetime = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                selectedIndex = previousIndex;
                pack_id = previousPackage;
                pack_datetime = previousDateTime;
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                Package obj = packageBindingSource.Current as Package;
                FormPackageDetailsReport formPackageDetailsReport = new FormPackageDetailsReport(pack_id, pack_datetime, obj);
                formPackageDetailsReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a package to view");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = "";

            FormPackageDispatchedFilter formFilter = new FormPackageDispatchedFilter();
            formFilter.ShowDialog();

            if (FormPackageDispatchedFilter.hasFilter)
            {
                filter = FormPackageDispatchedFilter.filter;
            }

            BindGrid();
        }
    }
}
