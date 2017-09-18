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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            raw = new RawMaterials();
            raw.Id = int.Parse(txtID.Text);
            raw.Name = txtName.Text.ToString();
            raw.Desc = txtDesc.Text.ToString();
            raw.Size = int.Parse(txtSizeComp.Text.ToString());
            raw.Qty = int.Parse(txtQty.Text.ToString());
            raw.Price = int.Parse(txtPrice.Text.ToString());
            raw.Received = dtpReceived.Value.ToString("yyyyMMDD");


            String query = String.Format("UPDATE products_raw SET " +
                       "prodr_id =  '{0}', " +
                       "prodr_name = '{1}', " +
                       "prodr_desc = '{2}', " +
                       "prodr_size = '{3}', " +
                       "prodr_qty = '{4}', " +
                       "prodr_price = '{5}' " +
                       "WHERE prodr_id = {0};" +
                       "Update products_raw_receive SET " +
                       "prodr_r_date = '{6}'" +
                       "Where prodr_id = '{0}' ",
                   raw.Id,
                   raw.Name,
                   raw.Desc,
                   raw.Size,
                   raw.Qty,
                   raw.Price,
                   raw.Received
                   );


           MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Item Successfully Updated");
            RawMaterialsUpdate.hasSelected = false;
           
        }
        private void loadMaterials()
        {
            if (RawMaterialsUpdate.hasSelected)
            {
                
                RawMaterials raw = RawMaterialsUpdate.raw;
                txtID.Text = raw.Id.ToString();
                txtName.Text = raw.Name;
                txtDesc.Text = raw.Desc;
                txtSizeComp.Text = raw.Size.ToString();
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
