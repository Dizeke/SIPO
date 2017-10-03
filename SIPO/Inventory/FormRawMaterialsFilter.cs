using MySql.Data.MySqlClient;
using SIPO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPO.Inventory
{
    public partial class FormRawMaterialsFilter : MetroFramework.Forms.MetroForm
    {
        List<RawMaterials> prods;

        public static bool hasFilter = false;
        public static string filter;
        public FormRawMaterialsFilter()
        {
            InitializeComponent();
        }
        private void loadProducts()
        {
            prods = new List<RawMaterials>();

            String query = "SELECT * FROM products_finished";
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();

            reader = com.ExecuteReader();
            while (reader.Read())
            {
                RawMaterials prod = new RawMaterials();
                prod.Id = int.Parse(reader["prodf_id"].ToString());
                prod.Name = reader["prodf_name"].ToString();

                prods.Add(prod);
            }

            con.Close();
            displayProducts();
        }

        private void displayProducts()
        {
            int row = 0;
            foreach (RawMaterials finished in prods)
            {
                cbName.Items.Add(finished.Name);
                row++;
            }

            if (row > 0)
            {
                cbName.SelectedIndex = 0;
            }
        }

        private void btnFilterByDate_Click(object sender, EventArgs e)
        {
            hasFilter = true;
            filter = " AND prodr_r_date " + dtFrom.Value.ToShortDateString() + " AND " + dtTo.Value.ToShortDateString();
            this.Close();
        }

        private void btnFilterByCompany_Click(object sender, EventArgs e)
        {
            hasFilter = true;
            filter = " AND prodr_id = " + prods[cbName.SelectedIndex].Id;
            this.Close();
        }
    }
    
}
