using System;
using System.Windows.Forms;
using SIPO.Classes;
using MySql.Data.MySqlClient;

namespace SIPO.Inventory
{
    public partial class FormPanelFinishedUpdate : MetroFramework.Forms.MetroForm
    {
        FinishedProduct finished;
        public FormPanelFinishedUpdate()
        {
            InitializeComponent();
            loadMaterials();
        }

        private void loadMaterials()
        {
            if (FinishedProductUpdate.hasSelected)
            {

                FinishedProduct finished = new FinishedProduct();
                txtID.Text = finished.Id.ToString();
                txtName.Text = finished.Name;
                txtDesc.Text = finished.Desc;
                txtRawUsed.Text = finished.Raw;
                txtQty.Text = finished.Qty.ToString();
                txtPrice.Text = finished.Price.ToString();
                txtFinQty.Text = finished.FinQty.ToString();
            }
            else
            {
                this.Close();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            finished = new FinishedProduct();
            finished.Id = int.Parse(txtID.Text);
            finished.Name = txtName.Text.ToString();
            finished.Desc = txtDesc.Text.ToString();
            finished.Raw = txtRawUsed.Text.ToString();
            finished.Qty = int.Parse(txtQty.Text.ToString());
            finished.Price = int.Parse(txtPrice.Text.ToString());
            finished.FinQty = int.Parse(txtFinQty.Text.ToString());

            String query = String.Format("UPDATE products_finished SET " +
                       "prodf_id =  '{0}', " +
                       "prodf_name = '{1}', " +
                       "prodf_desc = '{2}', " +
                       "prodf_qty = '{3}', " +
                       "prodr_srp = '{4}', " +
                       "WHERE prodf_id = {0};" +
                       "Update products_finished_materials SET " +
                       "prodf_f_id = '{0}'" +
                       "prod_r_id = (Select prodr_id From products_raw where prodr_name = '{5}')" +
                       "prod_r_qty = '{6}'" +
                       "Where prodr_id = '{0}' ",
                   finished.Id,
                   finished.Name,
                   finished.Desc,
                   finished.FinQty,
                   finished.Price,
                   finished.Raw,
                   finished.Qty                   
                   );


            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Item Successfully Updated");
            RawMaterialsUpdate.hasSelected = false;
        }
    }
}
