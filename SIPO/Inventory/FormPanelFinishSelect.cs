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
            InitializeComponent();
            loadMaterials();

        }

        private void loadMaterials()
        {
            try
            {
                finished = new List<FinishedProduct>();

                String query = "SELECT DISTINCT * FROM products_finished AS a INNER JOIN products_finished_materials as c ON a.prodf_id = c.prodf_f_id INNER JOIN products_raw as b ON c.prod_r_id = b.prodr_id";

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

                    Finished.Raw = reader["prodr_name"].ToString();
                    Finished.Qty = int.Parse(reader["prod_r_qty"].ToString());

                    Finished.Price = int.Parse(reader["prodf_srp"].ToString());
                    Finished.FinQty = int.Parse(reader["prodf_qty"].ToString());

                    finished.Add(Finished);

                    lvFinished.Items.Add(Finished.Id.ToString());
                    lvFinished.Items[row].SubItems.Add(Finished.Name);
                    lvFinished.Items[row].SubItems.Add(Finished.Desc);
                    lvFinished.Items[row].SubItems.Add(Finished.Raw.ToString());
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

            //try
            //{
                int index = lvFinished.SelectedItems[0].Index;
                FinishedProductUpdate.finished = finished[index];
                FinishedProductUpdate.hasSelected = true;

                FormPanelFinishedUpdate formPanelFinishedUpdate = new FormPanelFinishedUpdate();
                formPanelFinishedUpdate.ShowDialog();

            loadMaterials();

                

        //}
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.StackTrace);
        //        MessageBox.Show("Please select a client to update");
        //    }
}

        private void btnClose_Click(object sender, EventArgs e)
        {
            FinishedProductUpdate.hasSelected = false;
            this.Close();
        }
    }
}
