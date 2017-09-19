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
using System.IO;

using SIPO.Classes;

namespace SIPO.Manager
{
    public partial class FormPanelAccountAdd : Form
    {
        Account account;

        bool hasImage = false;
        FileStream fs;
        BinaryReader br;
        byte[] imageData;

        public FormPanelAccountAdd()
        {
            InitializeComponent();
            loadDepartments();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (isValidInput())
            {
                if (isValidUsername())
                {
                    String query = String.Format("INSERT INTO accounts (acc_user, acc_pass, acc_fname, acc_mname, acc_lname, acc_email, acc_contact, acc_position, act_id) " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', (SELECT act_id FROM account_types WHERE acc_type  = '{8}'))",
                    account.user,
                    account.pass,
                    account.fname,
                    account.mname,
                    account.lname,
                    account.email,
                    account.contact,
                    account.position,
                    account.type);

                    MySqlConnection con = new MySqlConnection(ConString.getConString());
                    MySqlCommand com = new MySqlCommand(query, con);

                    con.Open();
                    com.ExecuteNonQuery();
                    long acc_id = com.LastInsertedId;

                    query = "INSERT INTO account_images (aci_image, acc_id) VALUES (@aci_image, @acc_id)";
                    com = new MySqlCommand(query, con);
                    com.Parameters.Add("@aci_image", MySqlDbType.MediumBlob);
                    com.Parameters.Add("@acc_id", MySqlDbType.Int32);
                    com.Parameters["@aci_image"].Value = imageData;
                    com.Parameters["@acc_id"].Value = acc_id;
                    com.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Account Successfully Added");
                    clearFields();
                }
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox PictureBox1 = new PictureBox();
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);

                fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                imageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();

                hasImage = true;
            }
            else
            {
                hasImage = false;
            }
        }

        private void loadDepartments()
        {
            cbDepartment.Items.Clear();
            foreach (String department in Department.Departments)
            {
                cbDepartment.Items.Add(department);
            }

            if (cbDepartment.Items.Count < 1)
            {
                btnCreateAccount.Enabled = false;
            }
            else
            {
                cbDepartment.SelectedIndex = 0;
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private bool isValidInput()
        {
            try
            {
                if (txtUsername.Text.ToString().Length < 4)
                {
                    MessageBox.Show("Username must be at least 4 characters");
                    return false;
                }
                else if (txtPassword.Text.ToString().Length < 4)
                {
                    MessageBox.Show("Password must be at least 4 characters");
                    return false;
                }
                else if (txtVerifyPassword.Text.ToString().Length < 4)
                {
                    MessageBox.Show("Verify Password must be at least 4 characters");
                    return false;
                }
                else if (!txtPassword.Text.ToString().Equals(txtVerifyPassword.Text.ToString()))
                {
                    MessageBox.Show("Passwords do not match");
                    return false;
                }
                else if (txtFirstName.Text.ToString().Length < 1)
                {
                    MessageBox.Show("First Name cannot be empty");
                    return false;
                }
                else if (txtMiddleName.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Middle Name cannot be empty");
                    return false;
                }
                else if (txtLastName.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Last Name cannot be empty");
                    return false;
                }
                else if (txtEmail.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Email cannot be empty");
                    return false;
                }
                else if (txtContact.Text.ToString().Length < 11)
                {
                    MessageBox.Show("Invalid Contact Number");
                    return false;
                }
                else if (txtPosition.Text.ToString().Length < 1)
                {
                    MessageBox.Show("Position cannot be empty");
                    return false;
                }
                else if (!hasImage)
                {
                    MessageBox.Show("Please add an image for the user");
                    return false;
                }
                else
                {
                    account = new Account();
                    account.user = txtUsername.Text.ToString();
                    account.pass = txtPassword.Text.ToString();
                    account.vpass = txtVerifyPassword.Text.ToString();
                    account.fname = txtFirstName.Text.ToString();
                    account.mname = txtMiddleName.Text.ToString();
                    account.lname = txtLastName.Text.ToString();
                    account.email = txtEmail.Text.ToString();
                    account.contact = txtContact.Text.ToString();
                    account.position = txtPosition.Text.ToString();
                    account.type = cbDepartment.SelectedItem.ToString();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

        private bool isValidUsername()
        {
            try
            {
                bool isExisting = false;
                String query = String.Format("SELECT * FROM accounts WHERE acc_user = '{0}'", account.user);

                MySqlConnection con = new MySqlConnection(ConString.getConString());
                MySqlCommand com = new MySqlCommand(query, con);
                MySqlDataReader reader;

                con.Open();

                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    if (account.user.Equals((reader["acc_user"]).ToString()))
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
            txtUsername.Clear();
            txtPassword.Clear();
            txtVerifyPassword.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            txtPosition.Clear();
            pictureBox1.Image = null;

            if (cbDepartment.Items.Count > 0)
            {
                cbDepartment.SelectedIndex = 0;
            }
        }

    }
}
