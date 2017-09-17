using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using SIPO.Classes;

namespace SIPO.Manager
{
    public partial class FormPanelClientAdd : Form
    {
        Client client;
        public FormPanelClientAdd()
        {
            InitializeComponent();
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            if (isInputValid())
            {
                if (isUsernameValid())
                {
                    String query = String.Format("INSERT INTO clients (client_company, client_tin, client_address, client_contact, client_contact_number) " +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",
                    client.company,
                    client.tin,
                    client.address,
                    client.contact,
                    client.contact_number
                );

                    MySqlConnection con = new MySqlConnection(ConString.getConString());
                    MySqlCommand com = new MySqlCommand(query, con);

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Client Successfully Added");
                    clearFields();
                }
            }
        }


        private void btnClearFields_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private bool isInputValid()
        {
            try
            {
                if (txtCompanyName.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Company Name cannot be empty");
                    return false;
                }
                else if (txtCompanyContact.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Company Contact cannot be empty");
                    return false;
                }
                else if (txtCompanyContactNumber.Text.ToString().Length < 11)
                {
                    MessageBox.Show("Invalid Contact Number");
                    return false;
                }
                else if (txtCompanyTin.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Company TIN cannot be empty");
                    return false;
                }
                else if (txtCompanyAddress.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Company Address cannot be empty");
                    return false;
                }
                else
                {
                    client = new Client();
                    client.company = txtCompanyName.Text.ToString();
                    client.contact = txtCompanyContact.Text.ToString();
                    client.contact_number = txtCompanyContactNumber.Text.ToString();
                    client.tin = txtCompanyTin.Text.ToString();
                    client.address = txtCompanyAddress.Text.ToString();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

        private bool isUsernameValid()
        {
            try
            {
                bool isExisting = false;
                String query = String.Format("SELECT * FROM clients WHERE client_company = '{0}'", client.company);

                MySqlConnection con = new MySqlConnection(ConString.getConString());
                MySqlCommand com = new MySqlCommand(query, con);
                MySqlDataReader reader;

                con.Open();

                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    if (client.company.Equals((reader["client_company"]).ToString()))
                    {
                        isExisting = true;
                        break;
                    }
                }

                con.Close();

                if (isExisting)
                {
                    MessageBox.Show("Username already in use. Please use a different username.");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

        private void clearFields()
        {
            txtCompanyName.Clear();
            txtCompanyContact.Clear();
            txtCompanyContactNumber.Clear();
            txtCompanyTin.Clear();
            txtCompanyAddress.Clear();
        }

    }
}
