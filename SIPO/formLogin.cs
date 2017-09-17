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
using SIPO.Manager;
using SIPO.Packaging;
using SIPO.Sales;

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
            Account account = new Account();
            bool loginSuccessful = false;

            try
            {
                if (isInputValid())
                {
                    account.user = txtUsername.Text;
                    account.pass = txtPassword.Text;

                    String query = String.Format("SELECT accounts.acc_id, acc_user, acc_pass, account_types.acc_type  FROM accounts " +
                        "INNER JOIN account_types ON accounts.act_Id = account_types.act_id " +
                        "WHERE acc_user = '{0}' AND acc_pass = '{1}' ", account.user, account.pass);

                    MySqlConnection con = new MySqlConnection(ConString.getConString());
                    MySqlCommand com = new MySqlCommand(query, con);
                    MySqlDataReader reader;

                    con.Open();

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
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }


            if (loginSuccessful)
            {
                MessageBox.Show("Login successful as " + account.user + " (" + account.type + ")");

                this.Hide();
                if (account.type.Equals(AccountType.Inventory))
                {
                    FormInventory formInventory = new FormInventory();
                    formInventory.ShowDialog();
                }
                else if (account.type.Equals(AccountType.Sales))
                {
                    FormSales formSales = new FormSales();
                    formSales.ShowDialog();
                }
                else if (account.type.Equals(AccountType.Packaging))
                {
                    FormPackaging formPackaging = new FormPackaging();
                    formPackaging.ShowDialog();
                }
                else if (account.type.Equals(AccountType.Manager))
                {
                    FormManager formManager = new FormManager();
                    formManager.ShowDialog();
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("Login failed");
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
