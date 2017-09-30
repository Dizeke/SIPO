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
        double price = 0;
        double srp = 0;
        int totalQty = 0;
        List<RawMaterials> rawMaterials;
        List<RawMaterials> rawMaterialsUsed;

        public FormPanelFinishAdd()
        {
            InitializeComponent();
            loadRawMaterials();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidInput())
            {
                MySqlConnection con = new MySqlConnection(ConString.getConString());
                bool success = false;
                
                String query2;
                String query3;
                String query = String.Format("Insert INTO products_finished (prodf_name, prodf_desc, prodf_qty, prodf_srp, prodf_status) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');",
                    txtName.Text, txtDesc.Text, Convert.ToInt32(txtFinQty.Text), Convert.ToDouble(price * 1.5d), "pending");

                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                int id = (int)cmd.LastInsertedId;
                con.Close();

                query = "Insert INTO products_finished_convert (prodf_f_date, prodf_id) VALUES ( NOW(), '"+id+"' )";
                con.Open();
                MySqlCommand cmd3 = new MySqlCommand(query, con);
                cmd3.ExecuteNonQuery();
                con.Close();
                for (int i = 0; i < lvRawMaterialsUsed.Items.Count; i++)
                {
                    query3 = "Insert INTO products_finished_materials (prodf_f_id, prod_r_id, prod_r_qty)";
                    query3 += " VALUES ('"+id+"', '" + lvRawMaterialsUsed.Items[i].Text + "' , '" + lvRawMaterialsUsed.Items[i].SubItems[2].Text + "' )";
                    

                    query2 = "Update products_raw SET " +
                         "prodr_qty = prodr_qty - '" + lvRawMaterialsUsed.Items[i].SubItems[2].Text + "' " +
                         "WHERE prodr_id = '" + lvRawMaterialsUsed.Items[i].Text + "'";





                    MySqlCommand com = new MySqlCommand(query2, con);

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();

                    MySqlCommand cmd2 = new MySqlCommand(query3, con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }

                


                success = true;
                MessageBox.Show("Item Production Request has Been Sent!");

                if (!success)
                    MessageBox.Show("failed to add item");

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
                else if (txtName.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Name cannot be empty");
                    return false;
                }
                else if (txtQty.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Quantity Name cannot be empty");
                    return false;
                }
                else if (txtFinQty.Text.ToString().Length < 1)
                {
                    MessageBox.Show("New Price Name cannot be empty");
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
                            price += (rawMaterialsUsed[rmUsedIndex].Price * quantity);
                            totalQty += quantity;
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
                        price += (rawMaterialsUsed[rmUsedIndex].Price * quantity);
                        totalQty += quantity;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a quantity not more than the current stock");
                }
                srp = (price * 1.5d);
                lblSRP.Text = "SRP: " + srp.ToString();
                lblprice.Text = "Unit Cost: " + price.ToString();
                lbltotalQty.Text = "Total Quantity: " + totalQty.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar)) e.Handled = false;         //Letters And Numbers 
            else if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
            else if (e.KeyChar == (char)32) e.Handled = false;
            else e.Handled = true;
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar)) e.Handled = false;         //Letters And Numbers 
            else if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
            else if (e.KeyChar == (char)32) e.Handled = false;
            else e.Handled = true;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = false;        
            else if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
            else e.Handled = true;
        }

        private void txtFinQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = false;        
            else if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
            else e.Handled = true;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = false;      
            else if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
            else e.Handled = true;
        }
    }
}
