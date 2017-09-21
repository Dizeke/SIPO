using MySql.Data.MySqlClient;
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


namespace SIPO.Inventory
{
    public partial class FormPanelRawSelect : MetroFramework.Forms.MetroForm
    {
        List<RawMaterials> raws;
        public FormPanelRawSelect()
        {
            RawMaterialsUpdate.hasSelected = false;
            InitializeComponent();
            loadMaterials();
        }
        private void loadMaterials()
        {
            try
            {
               raws = new List<RawMaterials>();

                String query = "SELECT * FROM products_raw AS a Inner Join products_raw_receive as b ON a.prodr_id = b.prodr_id";

                MySqlConnection con = new MySqlConnection(ConString.getConString());
                MySqlCommand com = new MySqlCommand(query, con);
                MySqlDataReader reader;

                con.Open();

                int row = 0;
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    RawMaterials raw = new RawMaterials();
                    raw.Id = int.Parse(reader["prodr_id"].ToString());
                    raw.Name = reader["prodr_name"].ToString();
                    raw.Desc = reader["prodr_desc"].ToString();

                    raw.Size = int.Parse(reader["prodr_size"].ToString());
                    raw.Qty = int.Parse(reader["prodr_qty"].ToString());
                    raw.Received =reader["prodr_r_date"].ToString();
                    raw.Price = int.Parse(reader["prodr_price"].ToString());

                    raws.Add(raw);

                    lvRaw.Items.Add(raw.Id.ToString());
                    lvRaw.Items[row].SubItems.Add(raw.Name);
                    lvRaw.Items[row].SubItems.Add(raw.Desc);
                    lvRaw.Items[row].SubItems.Add(raw.Size.ToString());
                    lvRaw.Items[row].SubItems.Add(raw.Qty.ToString());
                    lvRaw.Items[row].SubItems.Add(raw.Received.ToString());
                    lvRaw.Items[row].SubItems.Add(raw.Price.ToString());
                    row++;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lvRaw.SelectedItems[0].Index;
                RawMaterialsUpdate.raw = raws[index];
                RawMaterialsUpdate.hasSelected = true;
                              

                
                FormPanelRawUpdate formPanelRawUpdate = new FormPanelRawUpdate();
               formPanelRawUpdate.ShowDialog();
                if (RawMaterialsUpdate.hasSelected == false)
                {
                    loadMaterials();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Please select a client to update");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            RawMaterialsUpdate.hasSelected = false;
            this.Close();
        }
    }
}
