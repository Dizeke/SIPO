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
    public partial class FormPurchaseOrderCustomAdd : MetroFramework.Forms.MetroForm
    {
        public FormPurchaseOrderCustomAdd()
        {
            InitializeComponent();
        }

        private void btnAddCustomProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add this custom product?", "New Custom Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String prodName = txtName.Text.ToString().Trim();
                String prodDesc = txtDesc.Text.ToString().Trim();
                int prodQty = int.Parse(txtQty.Text.ToString());
                double prodPrice = double.Parse(txtEstPrice.Text.ToString());

                if (isValidInputs())
                {
                    String query = String.Format("INSERT INTO products_finished (prodf_name, prodf_desc, prodf_qty, prodf_srp) " +
                        "VALUES ('{0}', '{1}', {2}, {3})",
                        prodName, prodDesc, prodQty, prodPrice);
                    MySqlConnection con = new MySqlConnection(ConString.getConString());
                    MySqlCommand com = new MySqlCommand(query, con);

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    int prodId = (int)com.LastInsertedId;

                    FinishedProduct prod = new FinishedProduct();
                    prod.Id = prodId;
                    prod.Name = prodName;
                    prod.Desc = prodDesc;
                    prod.Qty = prodQty;
                    prod.Price = prodPrice;

                    ProductCustomHelper.finishedProduct = prod;
                    ProductCustomHelper.isComplete = true;

                    MessageBox.Show("Custom Product has been added");
                    this.Close();
                }
            }
        }

        private bool isValidInputs()
        {
            try
            {
                if (txtName.Text.ToString().Trim().Length < 1)
                {
                    MessageBox.Show("Product Name cannot be empty");
                    return false;
                }
                else if (txtDesc.Text.ToString().Trim().Length < 1)
                {
                    MessageBox.Show("Product Description cannot be empty");
                    return false;
                }
                else if (txtQty.Text.ToString().Trim().Length < 1)
                {
                    MessageBox.Show("Product Quantity cannot be empty");
                    return false;
                }
                else if (int.Parse(txtQty.Text.ToString()) < 1)
                {
                    MessageBox.Show("Product Quantity cannot be less than 1");
                    return false;
                }
                else if (txtEstPrice.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Product Price cannot be empty");
                    return false;
                }
                else if (double.Parse(txtEstPrice.Text.ToString()) < 1)
                {
                    MessageBox.Show("Product Price cannot be less than 1");
                    return false;
                }
                else if (hasDuplicate())
                {
                    MessageBox.Show("Product Name is already in use");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Please provide a valid quantity");
                return false;
            }
        }

        private bool hasDuplicate()
        {
            try
            {
                String prodName = txtName.Text.ToString().Trim();

                String query = String.Format("SELECT * FROM products_finished WHERE prodf_name = '{0}'", prodName);
                MySqlConnection con = new MySqlConnection(ConString.getConString());
                MySqlCommand com = new MySqlCommand(query, con);
                MySqlDataReader reader;

                con.Open();

                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    if (prodName.Equals(reader["prodf_name"].ToString()))
                    {
                        return true;
                    }
                }

                con.Close();

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return true;
            }
        }

    }
}
