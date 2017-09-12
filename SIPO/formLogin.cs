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
using SIPO.Inventory;

namespace SIPO
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (isInputValid())
                {
                    Account account = new Account();
                    account.user = txtUsername.Text;
                    account.pass = txtPassword.Text;

                    String query = String.Format("SELECT accounts.acc_id, acc_user, acc_pass, account_types.acc_type  FROM accounts " +
                        "INNER JOIN account_types ON accounts.act_Id = account_types.act_id " +
                        "WHERE acc_user = '{0}' AND acc_pass = '{1}' ", account.user, account.pass);

                    MySqlConnection con = new MySqlConnection(ConString.getConString());
                    MySqlCommand com = new MySqlCommand(query, con);
                    MySqlDataReader reader;

                    con.Open();

                    bool loginSuccessful = false;
                    reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        if (account.user.Equals(reader["acc_user"]) && account.pass.Equals(reader["acc_pass"]))
                        {
                            loginSuccessful = true;
                            account.id = int.Parse(reader["acc_id"].ToString());
                            account.type = reader["acc_type"].ToString();
                            Account.loggedAccount = account;
                            break;
                        }
                    }

                    con.Close();

                    if (loginSuccessful)
                    {
                        MessageBox.Show("Login successful as " + account.user + " (" + account.type + ")");
                        FormInventory formInventory = new FormInventory();

                        this.Hide();
                        formInventory.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login failed");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private bool isInputValid()
        {
            try
            {
                if (txtUsername.Text.ToString().Trim().Length < 1)
                {
                    return false;
                }
                else if (txtPassword.Text.ToString().Trim().Length < 1)
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }
    }
}
