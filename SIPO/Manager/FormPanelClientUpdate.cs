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
    public partial class FormPanelClientUpdate : Form
    {
        Client client;

        public FormPanelClientUpdate()
        {
            InitializeComponent();
            loadClient();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (isInputValid())
            {
                String query = String.Format("UPDATE clients SET " +
                    "client_company =  '{0}', " +
                    "client_tin = '{1}', " +
                    "client_address = '{2}', " +
                    "client_contact = '{3}', " +
                    "client_contact_number = '{4}' " +
                    "WHERE client_id = {5}",
                client.company,
                client.tin,
                client.address,
                client.contact,
                client.contact_number,
                client.id
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
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void loadClient()
        {
            client = new Client();
            if (ClientUpdateHolder.hasSelected)
            {
                Client client = ClientUpdateHolder.client;

                txtCompanyName.Text = client.company;
                txtCompanyContact.Text = client.contact;
                txtCompanyContactNumber.Text = client.contact_number;

                txtCompanyTin.Text = client.tin;
                txtCompanyAddress.Text = client.address;
            }
            else
            {
                this.Close();
            }
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
