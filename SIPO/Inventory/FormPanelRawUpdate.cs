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
    public partial class FormPanelRawUpdate : MetroFramework.Forms.MetroForm
    {
        RawMaterials raw;
        public FormPanelRawUpdate()
        {
            InitializeComponent();
            loadMaterials();
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isValidInput())
            {
                raw = new RawMaterials();
                raw.Name = txtName.Text.ToString();
                raw.Desc = txtDesc.Text.ToString();
                raw.Qty = int.Parse(txtQty.Text.ToString());
                raw.Price = int.Parse(txtPrice.Text.ToString());
                raw.Newprice = int.Parse(txtNewPrice.Text.ToString());
                raw.Received = dtpReceived.Value.ToString("yyyyMMDD");
                raw.Received = dtpNew.Value.ToString("yyyyMMDD");


                String query = String.Format("UPDATE products_raw SET " +
                           "prodr_id =  '{0}', " +
                           "prodr_name = '{1}', " +
                           "prodr_desc = '{2}', " +
                           "prodr_qty = '{3}', " +
                           "prodr_price = '{4}' " +
                           "WHERE prodr_id = {0};" +
                           "Update products_raw_receive SET " +
                           "prodr_r_date = '{5}'" +
                           "Where prodr_id = '{0}' ",
                       raw.Id,
                       raw.Name,
                       raw.Desc,
                       raw.Qty,
                       raw.Newprice,
                       raw.Newreceived
                       );


                MySqlConnection con = new MySqlConnection(ConString.getConString());
                MySqlCommand com = new MySqlCommand(query, con);

                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Item Successfully Updated");
                RawMaterialsUpdate.hasSelected = false;

                this.Close();
            }

        }
        private void loadMaterials()
        {
            if (RawMaterialsUpdate.hasSelected)
            {

                RawMaterials raw = RawMaterialsUpdate.raw;

                txtName.Text = raw.Name;
                txtDesc.Text = raw.Desc;
                txtQty.Text = raw.Qty.ToString();
                dtpReceived.Value = Convert.ToDateTime(raw.Received);
                txtPrice.Text = raw.Price.ToString();
            }
            else
            {
                this.Close();
            }
        }

    }
}
