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
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            bool success = false;

            String query = String.Format("Insert INTO products_raw (prodr_id, prodr_name, prodr_desc, prodr_qty, prodr_price) VALUES ('{0}', '{1}', '{2}', '{3}' , '{4}')",
                Convert.ToInt32(txtID.Text), txtName.Text, txtDesc.Text, Convert.ToInt32(txtQty.Text), Convert.ToInt32(txtPrice.Text));
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Prepare();


            cmd.ExecuteNonQuery();

            success = true;

            if (success)
            {

                MySqlConnection con2 = new MySqlConnection(ConString.getConString());
                String query2 = String.Format("Insert INTO products_raw_receive (prodr_r_date, prodr_id) VALUES ('{0}', '{1}')", dtpReceived.Value.ToString("yyyyMMdd"), Convert.ToInt32(txtID.Text));


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
}
