using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

using SIPO.Classes;

namespace SIPO.Manager
{
    public partial class FormPanelAccountUpdate : Form
    {
        Account account;
        bool hasNewImage = false;
        FileStream fs;
        BinaryReader br;
        byte[] imageData;

        public FormPanelAccountUpdate()
        {
            InitializeComponent();
            loadDepartments();
            loadAccount();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            if (isValidInput())
            {
                String query = String.Format("UPDATE accounts SET " +
                    "acc_pass = '{0}', " +
                    "acc_fname = '{1}', " +
                    "acc_mname = '{2}', " +
                    "acc_lname = '{3}', " +
                    "acc_email = '{4}', " +
                    "acc_contact = '{5}', " +
                    "acc_position = '{6}', " +
                    "act_id = (SELECT act_id FROM account_types WHERE acc_type = '{7}') " +
                    "WHERE acc_id = {8}",
                    account.pass,
                    account.fname,
                    account.mname,
                    account.lname,
                    account.email,
                    account.contact,
                    account.position,
                    account.type,
                    account.id);

                MySqlConnection con = new MySqlConnection(ConString.getConString());
                MySqlCommand com = new MySqlCommand(query, con);

                con.Open();
                com.ExecuteNonQuery();

                if (hasNewImage)
                {
                    query = "UPDATE account_images SET aci_image = @aci_image WHERE acc_id = @acc_id";
                    com = new MySqlCommand(query, con);
                    com.Parameters.Add("@aci_image", MySqlDbType.MediumBlob);
                    com.Parameters.Add("@acc_id", MySqlDbType.Int32);
                    com.Parameters["@aci_image"].Value = imageData;
                    com.Parameters["@acc_id"].Value = account.id;
                    Console.WriteLine(account.id);
                    com.ExecuteNonQuery();
                    con.Close();
                }

                con.Close();

                MessageBox.Show("Account Successfully Updated");
                AccountUpdateHolder.hasSelected = false;
                this.Close();
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
                else
                {
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

                hasNewImage = true;
            }
            else
            {
                hasNewImage = false;
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
                btnUpdateAccount.Enabled = false;
            }
            else
            {
                cbDepartment.SelectedIndex = 0;
            }
        }

        private void loadAccount()
        {
            if (AccountUpdateHolder.hasSelected)
            {
                account = AccountUpdateHolder.account;

                txtUsername.Text = account.user;
                txtPassword.Text = account.pass;
                txtVerifyPassword.Text = account.pass;

                txtFirstName.Text = account.fname;
                txtMiddleName.Text = account.mname;
                txtLastName.Text = account.lname;

                txtEmail.Text = account.email;
                txtContact.Text = account.contact;

                txtPosition.Text = account.position;

                foreach (String department in Department.Departments)
                {
                    if (account.type.Equals(department))
                    {
                        cbDepartment.SelectedItem = department;
                        break;
                    }
                }

                if (account.image != null)
                {
                    if (account.image.Length > 0)
                    {
                        MemoryStream memoryStream = new MemoryStream();
                        memoryStream.Write(account.image, 0, account.image.Length);
                        pictureBox1.Image = Image.FromStream(memoryStream);
                    }
                }
            }
            else
            {
                this.Close();
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

        private void FormPanelAccountUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            AccountUpdateHolder.hasSelected = false;
        }


    }
}
