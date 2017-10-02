using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SIPO.Classes;
using MySql.Data.MySqlClient;

namespace SIPO.Inventory
{
    public partial class FormPanelFinishSelect : MetroFramework.Forms.MetroForm
    {
        List<FinishedProduct> finished;
        public FormPanelFinishSelect()
        {
            FinishedProductUpdate.hasSelected = false;
            FinishedProductUpdate.isCompleted = false;
            InitializeComponent();
            loadMaterials();

        }

        private void loadMaterials()
        {
            try
            {
                finished = new List<FinishedProduct>();

                String query = "SELECT * FROM products_finished AS a Where prodf_status = 'approved' OR (prodf_rQty > 0 AND prodf_status = 'pending' ) OR (prodf_rQty > 0 AND prodf_status = 'production')";

                MySqlConnection con = new MySqlConnection(ConString.getConString());
                MySqlCommand com = new MySqlCommand(query, con);
                MySqlDataReader reader;

                con.Open();

                int row = 0;
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    FinishedProduct Finished = new FinishedProduct();
                    Finished.Id = int.Parse(reader["prodf_id"].ToString());
                    Finished.Name = reader["prodf_name"].ToString();
                    Finished.Desc = reader["prodf_desc"].ToString();

                    Finished.Price = int.Parse(reader["prodf_srp"].ToString());
                    Finished.FinQty = int.Parse(reader["prodf_qty"].ToString());

                    finished.Add(Finished);

                    lvFinished.Items.Add(Finished.Id.ToString());
                    lvFinished.Items[row].SubItems.Add(Finished.Name);
                    lvFinished.Items[row].SubItems.Add(Finished.Desc);
                    lvFinished.Items[row].SubItems.Add(Finished.FinQty.ToString());
                    lvFinished.Items[row].SubItems.Add(Finished.Price.ToString());

                    row++;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {

            try
            {
                int index = lvFinished.SelectedItems[0].Index;
                FinishedProductUpdate.finished = finished[index];
                FinishedProductUpdate.hasSelected = true;
                FinishedProductUpdate.isCompleted = false;
                FormPanelFinishedUpdate formPanelFinishedUpdate = new FormPanelFinishedUpdate();
                formPanelFinishedUpdate.ShowDialog();
                if(FinishedProductUpdate.isCompleted)
                {
                    lvFinished.Items.Clear();
                    loadMaterials();
                }

        }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Please select a product to update");
            }
}

        private void btnClose_Click(object sender, EventArgs e)
        {
            FinishedProductUpdate.hasSelected = false;
            this.Close();
        }
    }
}
