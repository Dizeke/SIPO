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
    public partial class FormPaymentDetailsReport : MetroFramework.Forms.MetroForm
    {
        int po_id;
        string company; 

        public FormPaymentDetailsReport(int _po_id, string _company)
        {
            InitializeComponent();
            this.po_id = _po_id;
            this.company = _company;
            lblCompany.Text = company;

            BindGrid();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {

        }

        private void BindGrid()
        {
            String query = "SELECT pop_id AS 'Payment ID', pop_amount AS 'Amount Paid', pop_datetime AS 'Date Paid' FROM purchase_order_payments WHERE po_id = " + po_id;
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


    }
}
