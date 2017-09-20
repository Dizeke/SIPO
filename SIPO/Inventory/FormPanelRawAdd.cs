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

namespace SIPO.Inventory
{
    public partial class FormPanelRawAdd : MetroFramework.Forms.MetroForm

    {
        public FormPanelRawAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidInput())
            {
                MySqlConnection con = new MySqlConnection(ConString.getConString());
                bool success = false;

                String query = String.Format("Insert INTO products_raw (prodr_name, prodr_desc, prodr_qty, prodr_price) VALUES ('{0}', '{1}', '{2}', '{3}')",
                    txtName.Text, txtDesc.Text, Convert.ToInt32(txtQty.Text), Convert.ToInt32(txtPrice.Text));
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Prepare();


                cmd.ExecuteNonQuery();

                success = true;

                if (success)
                {

                    MySqlConnection con2 = new MySqlConnection(ConString.getConString());
                    String query2 = String.Format("Insert INTO products_raw_receive (prodr_r_date, LAST_INSERT_ID()) VALUES ('{0}', '{1}')", dtpReceived.Value.ToString("yyyyMMdd"));


                    con2.Open();

                    MySqlCommand cmd2 = new MySqlCommand(query2, con2);

                    cmd2.ExecuteNonQuery();
                    success = true;

                }
                else
                {
                    MessageBox.Show("Failed to ADD");

                }
                if (success)

                    MessageBox.Show("Item Added Successfully");
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
                else if (txtPrice.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Price cannot be empty");
                    return false;
                }
                else if (txtQty.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Quantity Name cannot be empty");
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
    }
}
