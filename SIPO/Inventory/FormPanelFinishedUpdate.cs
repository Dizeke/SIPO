using System;
using System.Windows.Forms;
using SIPO.Classes;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace SIPO.Inventory
{
    public partial class FormPanelFinishedUpdate : MetroFramework.Forms.MetroForm
    {
        List<RawMaterials> rawMaterials;
        List<RawMaterials> rawMaterialsUsed;
        FinishedProduct finished;
        public FormPanelFinishedUpdate()
        {
            InitializeComponent();
            loadMaterials();
            loadRawMaterials();
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
        private bool isValidInput()
        {
            try
            {
                if (txtDesc.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Description Cannot be empty");
                    return false;
                }
                else if (txtName.Text.ToString().Length < 4)
                {
                    MessageBox.Show("Name cannot be empty");
                    return false;
                }
                else if (txtNewSrp.Text.ToString().Length < 1)
                {
                    MessageBox.Show("New Price cannot be empty");
                    return false;
                }
                else if (txtQty.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Quantity Name cannot be empty");
                    return false;
                }
                else if (txtFinQty.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Finished Quantity Name cannot be empty");
                    return false;
                }
                



                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isValidInput())
            {
                MySqlConnection con = new MySqlConnection(ConString.getConString());

                finished.Name = txtName.Text;
                finished.Desc = txtDesc.Text;
                finished.Price = double.Parse(txtOldSrp.Text);
                finished.Newprice = double.Parse(txtNewSrp.Text);
                finished.FinQty = int.Parse(txtFinQty.Text);
                String query2 = null;
                String query = String.Format("UPDATE products_finished SET " +
                           "prodf_id =  '{0}', " +
                           "prodf_name = '{1}', " +
                           "prodf_desc = '{2}', " +
                           "prodf_qty = '{3}', " +
                           "prodf_srp = '{4}'" +
                           "WHERE prodf_id = {0};",
                       finished.Id,
                       finished.Name,
                       finished.Desc,
                       finished.FinQty,
                       finished.Newprice
                       );
                query += "Insert INTO products_finished_materials(prodf_f_id, prod_r_id, prod_r_qty) VALUES ";
                foreach (RawMaterials item in rawMaterialsUsed)
                {
                    query2 = "SELECT prodr_id FROM products_raw Where prodr_id NOT IN (SELECT prod_r_id FROM products_finished_materials);";
                    
                    MySqlCommand com2 = new MySqlCommand(query2, con);
                    MySqlDataReader reader;
                    con.Open();
                   
                    reader = com2.ExecuteReader();
                    
                    int row = 0;
                    while (reader.Read())

                    {
                        
                        if(row < rawMaterialsUsed.Count)
                        {
                            query += "('" + finished.Id + "', '" + lvRawMaterialsUsed.Items[row].Text + "' , '" + lvRawMaterialsUsed.Items[row].SubItems[2].Text + "' ),";

                        }
                        else
                        {
                            query += "('" + finished.Id + "', '" + lvRawMaterialsUsed.Items[row].Text + "' , '" + lvRawMaterialsUsed.Items[row].SubItems[2].Text + "' );";
                        }
                        row++;
                    }
                    con.Close();
                }
                MySqlCommand com = new MySqlCommand(query, con);
                
                con.Open();
                com.ExecuteNonQuery();

                con.Close();
                //  MessageBox.Show(query);
                MessageBox.Show("Item Successfully Updated");
                RawMaterialsUpdate.hasSelected = false;
            }
        }
        private void loadRawMaterials()
        {
            try
            {
                rawMaterials = new List<RawMaterials>();
                rawMaterialsUsed = new List<RawMaterials>();

                String query = "SELECT prodr_id,prodr_name,prodr_desc,prodr_size,prodr_qty,prodr_price FROM products_raw";
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
                    btnUpdate.Enabled = false;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
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

                if (row < 1)
                {
                    btnAddUsedMaterial.Enabled = false;
                    btnUpdate.Enabled = false;
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
                int index = lvRawMaterials.SelectedIndices[0];
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
