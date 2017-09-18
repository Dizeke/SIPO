﻿using MySql.Data.MySqlClient;
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
    public partial class FormPanelFinishAdd : Form
    {
        public FormPanelFinishAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(ConString.getConString());
            bool success = false;

            
            String query = String.Format("Insert INTO products_finished (prodf_id, prodf_name, prodf_desc, prodf_qty, prodf_srp) VALUES ('{0}', '{1}', '{2}', '{3}' , '{4}')",
                Convert.ToInt32(txtID.Text), txtName.Text, txtDesc.Text, Convert.ToInt32(txtQty.Text), Convert.ToInt32(txtPrice.Text));
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
          
            success = true;

            if (success)
            {

                MySqlConnection con2 = new MySqlConnection(ConString.getConString());
                String query2 = String.Format("Insert INTO products_finished_convert (prodf_f_date, prodf_id) VALUES ('{0}', '{1}')", Convert.ToDateTime(DateTime.Now.Date), Convert.ToInt32(txtID.Text));


                con2.Open();

                MySqlCommand cmd2 = new MySqlCommand(query2, con2);
                cmd2.ExecuteNonQuery();

                success = true;

               
            }
            else
            {
                success = false;
               

            }

            if (success)
            {
                String query1 = String.Format("Select * From products_raw Where prodr_name = '{0}'", txtRawUsed.Text);
                MySqlConnection con1 = new MySqlConnection(ConString.getConString());
                MySqlCommand com1 = new MySqlCommand(query1, con1);
                MySqlDataReader reader;

                con1.Open();

                reader = com1.ExecuteReader();
                while (reader.Read())
                {
                    if (txtRawUsed.Text.Equals(reader["prodr_name"]))
                    {
                        MySqlConnection con2 = new MySqlConnection(ConString.getConString());
                        String query2 = String.Format("Insert INTO products_finished_materials (prodf_f_id, prod_r_id, prod_r_qty) VALUES ('{0}', '{1}','{2}')", Convert.ToInt32(txtID.Text), reader["prodr_id"], Convert.ToInt32(txtQty.Text));


                        con2.Open();

                        MySqlCommand cmd2 = new MySqlCommand(query2, con2);
                        cmd2.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("Item Added Successfully");
            }
            else
            {
                success = false;
                MessageBox.Show("Failed to Add");
            }
           

        }
    }
}
