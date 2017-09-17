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
    public partial class FormPanelRawAdd : Form

    {
        public FormPanelRawAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            bool success = false;

            String query = "Insert INTO products_raw (prodr_id, prodr_name, prodr_desc, prodr_size, prodr_qty, prodr_price) VALUES ('@prodID', '@name', '@desc', '@size' , '@qty', '@price')";

            
            

            con.Open();


           MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Prepare();

                cmd.Parameters.AddWithValue("@prodID", Convert.ToInt32(txtID.Text));
                cmd.Parameters.AddWithValue("@name",txtName.Text);
                cmd.Parameters.AddWithValue("@desc", txtDesc.Text);
                cmd.Parameters.AddWithValue("@size", Convert.ToInt32(txtSizeComp.Text));
                cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(txtQty.Text));
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32( txtPrice.Text));
                cmd.ExecuteNonQuery();

                success = true;
            
            if (success)
            {

                MySqlConnection con2 = new MySqlConnection(ConString.getConString());
                String query2 ="Insert INTO products_raw_receive (prodr_r_date, prodr_id) VALUES ('@date', '@prodID')";
                

                con2.Open();

                MySqlCommand cmd2 = new MySqlCommand(query2, con2);

                cmd.Prepare();
                    cmd2.Parameters.AddWithValue("@date", txtReceived.Text);
                    cmd2.Parameters.AddWithValue("@prodID", Convert.ToInt32(txtID.Text));

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
}
