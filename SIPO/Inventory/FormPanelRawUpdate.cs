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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String query = String.Format("UPDATE products_raw SET " +
                       "prodr_id =  '{0}', " +
                       "prodr_name = '{1}', " +
                       "prodr_desc = '{2}', " +
                       "prodr_size = '{3}', " +
                       "prodr_qty = '{4}' " +
                       "prodr_price = '{5}' " +
                       "WHERE prodr_id = {0}",
                   raw.Id,
                   raw.Name,
                   raw.Desc,
                   raw.Size,
                   raw.Qty,
                   raw.Received,
                   raw.Price
                   );


           MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Client Successfully Updated");
            ClientUpdateHolder.hasSelected = false;
            this.Close();
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
                txtReceived.Text = raw.Received.ToString();
                txtPrice.Text = raw.Price.ToString();
            }
            else
            {
                this.Close();
            }
        }

    }
}
