﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIPO.Classes;
using MySql.Data.MySqlClient;

namespace SIPO.Inventory
{
    public partial class FormFinishedSelectPending : MetroFramework.Forms.MetroForm
    {
        List<FinishedProduct> finished;
        public FormFinishedSelectPending()
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

                String query = "SELECT * FROM products_finished AS a Where prodf_status = 'production'";

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

                    lvRequest.Items.Add(Finished.Id.ToString());
                    lvRequest.Items[row].SubItems.Add(Finished.Name);
                    lvRequest.Items[row].SubItems.Add(Finished.Desc);
                    lvRequest.Items[row].SubItems.Add(Finished.FinQty.ToString());
                    lvRequest.Items[row].SubItems.Add(Finished.Price.ToString());

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
                int index = lvRequest.SelectedItems[0].Index;
                FinishedProductUpdate.finished = finished[index];
                FinishedProductUpdate.hasSelected = true;
                FinishedProductUpdate.isCompleted = false;
                FormProductionRequest selectRequest = new FormProductionRequest();
                selectRequest.ShowDialog();
                if (FinishedProductUpdate.isCompleted)
                {
                    lvRequest.Items.Clear();
                    loadMaterials();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Please select an Item");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
