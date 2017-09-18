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
    public partial class FormPanelFinishAdd : MetroFramework.Forms.MetroForm
    {
        List<RawMaterials> rawMaterials;
        List<RawMaterials> rawMaterialsUsed;

        public FormPanelFinishAdd()
        {
            InitializeComponent();
            loadRawMaterials();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(ConString.getConString());
            bool success = false;


            String query = String.Format("Insert INTO products_finished (prodf_id, prodf_name, prodf_desc, prodf_qty, prodf_srp) VALUES ('{0}', '{1}', '{2}', '{3}' , '{4}')",
                Convert.ToInt32(txtID.Text), txtName.Text, txtDesc.Text, Convert.ToInt32(txtFinQty.Text), Convert.ToInt32(txtPrice.Text));
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            success = true;

            if (success)
            {

                MySqlConnection con2 = new MySqlConnection(ConString.getConString());
                String query2 = String.Format("Insert INTO products_finished_convert (prodf_f_date, prodf_id) VALUES ( NOW(), '{0}')", Convert.ToInt32(txtID.Text));


                con2.Open();

                MySqlCommand cmd2 = new MySqlCommand(query2, con2);
                cmd2.ExecuteNonQuery();

                success = true;


            }
            else
            {
                success = false;


            }

            if (success)
            {
                String query1 = String.Format("Select * From products_raw Where prodr_name = '{0}'", txtRawUsed.Text);
                MySqlConnection con1 = new MySqlConnection(ConString.getConString());
                MySqlCommand com1 = new MySqlCommand(query1, con1);
                MySqlDataReader reader;

                con1.Open();

                reader = com1.ExecuteReader();
                while (reader.Read())
                {
                    if (txtRawUsed.Text.Equals(reader["prodr_name"]))
                    {
                        MySqlConnection con2 = new MySqlConnection(ConString.getConString());
                        String query2 = String.Format("Insert INTO products_finished_materials (prodf_f_id, prod_r_id, prod_r_qty) VALUES ('{0}', '{1}','{2}')", Convert.ToInt32(txtID.Text), reader["prodr_id"], Convert.ToInt32(txtQty.Text));


                        con2.Open();

                        MySqlCommand cmd2 = new MySqlCommand(query2, con2);
                        cmd2.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("Item Added Successfully");
            }
            else
            {
                success = false;
                MessageBox.Show("Failed to Add");
            }


        }

        private void loadRawMaterials()
        {
            try
            {
                rawMaterials = new List<RawMaterials>();
                rawMaterialsUsed = new List<RawMaterials>();

                String query = "SELECT * FROM products_raw";
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
                    rawMaterial.Desc = reader["prodr_desc"].ToString();
                    rawMaterial.Size = int.Parse(reader["prodr_size"].ToString());
                    rawMaterial.Qty = int.Parse(reader["prodr_qty"].ToString());
                    rawMaterial.Price = double.Parse(reader["prodr_price"].ToString());

                    rawMaterials.Add(rawMaterial);

                    lvRawMaterials.Items.Add(rawMaterial.Id.ToString());
                    lvRawMaterials.Items[row].SubItems.Add(rawMaterial.Name);
                    lvRawMaterials.Items[row].SubItems.Add(rawMaterial.Qty.ToString());
                    row++;
                }

                if (row < 1)
                {
                    btnAddUsedMaterial.Enabled = false;
                    btnAdd.Enabled = false;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void btnAddUsedMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lvRawMaterials.Items.IndexOf(lvRawMaterials.SelectedItems[0]);
                RawMaterials rawMaterialUsed = rawMaterials[index];

                int quantity = int.Parse(txtQty.Text.ToString());
                if ((rawMaterials[index].Qty >= quantity) && (quantity > 0))
                {
                    bool isAdded = false;
                    int rmUsedIndex = 0;
                    foreach (RawMaterials rmUsed in rawMaterialsUsed)
                    {
                        if (rmUsed.Id == rawMaterials[index].Id)
                        {
                            isAdded = true;
                            rawMaterialsUsed[rmUsedIndex].Qty += quantity;
                            break;
                        }
                        else
                        {
                            rmUsedIndex++;
                        }
                    }

                    if (isAdded)
                    {
                        for (int i = 0; i < lvRawMaterialsUsed.Items.Count; i++)
                        {
                            if (lvRawMaterialsUsed.Items[i].Text.Equals(rawMaterialsUsed[rmUsedIndex].Id.ToString()))
                            {
                                
                                lvRawMaterialsUsed.Items[i].SubItems[2].Text = rawMaterialsUsed[rmUsedIndex].Qty.ToString();
                                break;
                            }
                        }
                    }
                    else
                    {
                        rawMaterialUsed.Qty = int.Parse(txtQty.Text.ToString());
                        rawMaterialsUsed.Add(rawMaterialUsed);

                        lvRawMaterialsUsed.Items.Add(rawMaterialUsed.Id.ToString());
                        lvRawMaterialsUsed.Items[lvRawMaterialsUsed.Items.Count - 1].SubItems.Add(rawMaterialUsed.Name);
                        lvRawMaterialsUsed.Items[lvRawMaterialsUsed.Items.Count - 1].SubItems.Add(rawMaterialUsed.Qty.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please select a quantity not more than the current stock");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
