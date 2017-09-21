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
                int id = (int)cmd.LastInsertedId;

                success = true;

                if (success)
                {

                    MySqlConnection con2 = new MySqlConnection(ConString.getConString());
                    String query2 = String.Format("Insert INTO products_raw_receive (prodr_r_date, prodr_id ) VALUES ('{0}', '{1}')", dtpReceived.Value.ToString("yyyyMMdd"),id);

                    
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

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = false;         //Just Digits
            else if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
            else e.Handled = true;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = false;         //Just Digits
            else if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
            else e.Handled = true;
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar)) e.Handled = false;         //Letters And Numbers 
            else if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
            else if (e.KeyChar == (char)32) e.Handled = false;
            else e.Handled = true;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar)) e.Handled = false;         //Letters And Numbers 
            else if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
            else if (e.KeyChar == (char)32) e.Handled = false;
            else e.Handled = true;
        }
    }
}
