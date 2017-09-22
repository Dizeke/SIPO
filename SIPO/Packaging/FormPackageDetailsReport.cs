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

namespace SIPO.Packaging
{
    public partial class FormPackageDetailsReport : MetroFramework.Forms.MetroForm
    {
        int pack_id;
        string pack_datetime;
        public FormPackageDetailsReport(int _pack_id, string _pack_datetime)
        {
            InitializeComponent();
            this.pack_id = _pack_id;
            this.pack_datetime = _pack_datetime;
            lblDeliveryDate.Text = pack_datetime;

            BindGrid();
        }

        private void BindGrid()
        {
            String query = String.Format("SELECT products_finished.prodf_id AS 'Product ID', products_finished.prodf_name AS 'Name', purchase_order_batch_products.prodf_qty AS 'Quantity', package_details.pd_gweight AS 'Gross Weight', package_details.pd_nweight AS 'Net Weight', package_details.pd_qty_carton AS 'Qty/Carton' FROM packages INNER JOIN purchase_order_batches ON packages.pob_id = purchase_order_batches.pob_id INNER JOIN purchase_order_batch_products ON purchase_order_batch_products.pob_id = purchase_order_batches.pob_id INNER JOIN products_finished ON products_finished.prodf_id = purchase_order_batch_products.prodf_id INNER JOIN package_details ON package_details.pack_id = packages.pack_id WHERE packages.pack_id = {0} GROUP BY purchase_order_batch_products.prodf_id",
                pack_id
                );
            Console.WriteLine(query);

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
