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
    public partial class FormPanelAccountSelect : MetroFramework.Forms.MetroForm
    {
        List<Account> accounts;

        public FormPanelAccountSelect()
        {
            InitializeComponent();
            AccountUpdateHolder.hasSelected = false;
            loadAccounts();
        }

        private void btnSelectAccount_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lvAccounts.SelectedItems[0].Index;
                AccountUpdateHolder.account = accounts[index];
                AccountUpdateHolder.hasSelected = true;

                this.Close();
            } catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Please select an account to update");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AccountUpdateHolder.hasSelected = false;
            this.Close();
        }

        private void loadAccounts()
        {
            try
            {
                accounts = new List<Account>();

                String query = "SELECT accounts.acc_id, aci_image, acc_user, acc_pass, acc_fname, acc_mname, acc_lname, acc_email, acc_contact, acc_position, acc_type " +
                    "FROM accounts INNER JOIN account_types ON accounts.act_id = account_types.act_id  INNER JOIN account_images ON accounts.acc_id = account_images.acc_id";

                MySqlConnection con = new MySqlConnection(ConString.getConString());
                MySqlCommand com = new MySqlCommand(query, con);
                MySqlDataReader reader;

                con.Open();

                int row = 0;
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Account account = new Account();
                    account.id = int.Parse(reader["acc_id"].ToString());
                    account.image = (byte[]) reader["aci_image"];

                    account.user = reader["acc_user"].ToString();
                    account.pass = reader["acc_pass"].ToString();

                    account.fname = reader["acc_fname"].ToString();
                    account.mname = reader["acc_mname"].ToString();
                    account.lname = reader["acc_lname"].ToString();

                    account.email = reader["acc_email"].ToString();
                    account.contact = reader["acc_contact"].ToString();

                    account.position = reader["acc_position"].ToString();
                    account.type = reader["acc_type"].ToString();

                    accounts.Add(account);

                    lvAccounts.Items.Add(account.id.ToString());
                    lvAccounts.Items[row].SubItems.Add(account.lname + ", " + account.fname + " " + account.mname);
                    lvAccounts.Items[row].SubItems.Add(account.user);
                    lvAccounts.Items[row].SubItems.Add(account.email);
                    lvAccounts.Items[row].SubItems.Add(account.contact);
                    lvAccounts.Items[row].SubItems.Add(account.position);
                    lvAccounts.Items[row].SubItems.Add(account.type);
                    row++;
                }

                con.Close();
            } catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

    }
}
