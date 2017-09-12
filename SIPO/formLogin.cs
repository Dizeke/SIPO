using System;
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

namespace SIPO
{
    public partial class formLogin : Form
    {
        public formLogin()
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

                    String query = String.Format("SELECT * FROM accounts WHERE acc_user = '{0}' AND acc_pass = '{1}'", account.user, account.pass);

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
                            break;
                        }
                    }

                    con.Close();

                    if (loginSuccessful)
                    {
                        MessageBox.Show("Login successful");
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
