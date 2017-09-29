using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIPO.Classes;
using MySql.Data.MySqlClient;

namespace SIPO.Inventory
{
    public partial class FormProductionRequest : MetroFramework.Forms.MetroForm
    {
        List<RawMaterials> rawMaterialsUsed;
        FinishedProduct finished;
        public FormProductionRequest()
        {
            InitializeComponent();
            loadMaterials();
            loadUsedRawMaterials();
        }
        private void loadMaterials()
        {
            if (FinishedProductUpdate.hasSelected)
            {

                finished = FinishedProductUpdate.finished;
                txtName.Text = finished.Name;
                txtDesc.Text = finished.Desc;
                txtOldSrp.Text = finished.Price.ToString();
                txtFinQty.Text = finished.FinQty.ToString();

            }
            else
            {
                this.Close();
            }
        }
        private void loadUsedRawMaterials()
        {
            try
            {
                rawMaterialsUsed = new List<RawMaterials>();
                String query = String.Format("SELECT products_raw.prodr_id, products_raw.prodr_name, products_finished_materials.prod_r_qty FROM products_finished_materials INNER JOIN products_raw ON products_finished_materials.prod_r_id = products_raw.prodr_id WHERE prodf_f_id = {0}", finished.Id);
                MySqlConnection con = new MySqlConnection(ConString.getConString());
                MySqlCommand com = new MySqlCommand(query, con);
                MySqlDataReader reader;

                con.Open();

                int row = 0;
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    RawMaterials rawMaterial = new RawMaterials();
                    rawMaterial.Id = int.Parse(reader["prodr_id"].ToString());
                    rawMaterial.Name = reader["prodr_name"].ToString();
                    rawMaterial.Qty = int.Parse(reader["prod_r_qty"].ToString());

                    rawMaterialsUsed.Add(rawMaterial);

                    lvRawMaterialsUsed.Items.Add(rawMaterial.Id.ToString());
                    lvRawMaterialsUsed.Items[row].SubItems.Add(rawMaterial.Name);
                    lvRawMaterialsUsed.Items[row].SubItems.Add(rawMaterial.Qty.ToString());
                    row++;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(ConString.getConString());
                String query = "UPDATE products_finished SET prodf_status = 'approved' where prodf_id = '" + finished.Id + "' ";
                con.Open();
                MySqlCommand com = new MySqlCommand(query, con);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            MessageBox.Show("Product Has been Added!");
            FinishedProductUpdate.isCompleted = true;
            this.Close();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(ConString.getConString());
                String query = "UPDATE products_finished SET prodf_status = 'disapproved' where prodf_id = '" + finished.Id + "' ";
                con.Open();
                MySqlCommand com = new MySqlCommand(query, con);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            MessageBox.Show("Item Production Has been Declined");
            FinishedProductUpdate.isCompleted = true;
            this.Close();
        }
    }

}
