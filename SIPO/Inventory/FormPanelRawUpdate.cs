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
                else if (txtName.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Name cannot be empty");
                    return false;
                }
                else if (txtNewPrice.Text.ToString().Length < 1)
                {
                    MessageBox.Show("New Price cannot be empty");
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
                raw.Id = int.Parse(lblID.Text);
                raw.Name = txtName.Text.ToString();
                raw.Desc = txtDesc.Text.ToString();
                raw.Qty = int.Parse(txtQty.Text.ToString());
                raw.Price = int.Parse(txtPrice.Text.ToString());
                raw.Newprice = int.Parse(txtNewPrice.Text.ToString());
                raw.Received = dtpReceived.Value.ToString("yyyy-MM-dd");
                raw.Newreceived = dtpNew.Value.ToString("yyyy-MM-dd");


                String query = String.Format("UPDATE products_raw SET " +
                           "prodr_name = '{1}', " +
                           "prodr_desc = '{2}', " +
                           "prodr_qty = '{3}', " +
                           "prodr_price = '{4}' " +
                           "WHERE prodr_id = '{0}';" +
                           "Update products_raw_receive SET " +
                           "prodr_r_date = '{5}'" +
                           "Where prodr_id = '{0}'; ",
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
              //  MessageBox.Show(query);
                MessageBox.Show("Item Successfully Updated");
                RawMaterialsUpdate.hasSelected = false;
                RawMaterialsUpdate.isCompleted = true;
                this.Close();
            }

        }
        private void loadMaterials()
        {
            if (RawMaterialsUpdate.hasSelected)
            {

                RawMaterials raw = RawMaterialsUpdate.raw;
                lblID.Text = raw.Id.ToString();
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

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            else if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
            else e.Handled = false;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = false;
            else if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
            else e.Handled = true;
        }

        private void txtNewPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = false;
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
