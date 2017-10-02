using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIPO.Classes;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIPO.Inventory
{
    public partial class FormFinishedSelectRequest : MetroFramework.Forms.MetroForm
    {

        List<FinishedProduct> finished;
        public FormFinishedSelectRequest()
        {

            InitializeComponent();
            FinishedProductUpdate.hasSelected = false;
            FinishedProductUpdate.isCompleted = false;
            loadMaterials();
        }

        private void loadMaterials()
        {
            try
            {
                finished = new List<FinishedProduct>();

                String query = "SELECT * FROM products_finished AS a Where prodf_status = 'pending'";

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
                    Finished.Newprice = int.Parse(reader["prodf_rSrp"].ToString());
                    Finished.Qty = int.Parse(reader["prodf_rQty"].ToString());
                    Finished.Price = int.Parse(reader["prodf_srp"].ToString());
                    Finished.FinQty = int.Parse(reader["prodf_qty"].ToString());
                    Finished.RDate = reader["prodf_rDate"].ToString();

                    finished.Add(Finished);

                    lvRequest.Items.Add(Finished.Id.ToString());
                    lvRequest.Items[row].SubItems.Add(Finished.Name);
                    lvRequest.Items[row].SubItems.Add(Finished.Desc);
                    if(reader["prodf_rQty"].ToString() == "0" && reader["prodf_rSrp"].ToString() == "0")
                    {
                        lvRequest.Items[row].SubItems.Add(Finished.FinQty.ToString());
                        lvRequest.Items[row].SubItems.Add(Finished.Price.ToString());
                    }
                    else
                    {
                        lvRequest.Items[row].SubItems.Add(Finished.Qty.ToString());
                        lvRequest.Items[row].SubItems.Add(Finished.Newprice.ToString());
                        
                    }
                    lvRequest.Items[row].SubItems.Add(Finished.RDate.ToString());

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
                int index = lvRequest.SelectedItems[0].Index;
                FinishedProductUpdate.finished = finished[index];
                FinishedProductUpdate.hasSelected = true;
                FinishedProductUpdate.isCompleted = false;
                FormRequest selectRequest = new FormRequest();
                selectRequest.ShowDialog();
                if (FinishedProductUpdate.isCompleted)
                {
                    lvRequest.Items.Clear();
                    loadMaterials();
                }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //    MessageBox.Show("Please select an Item");
            //}

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvRequest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
