using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSAPP
{
    public partial class AddUserForm : Form
    {
        animeEntities db; // database context to use
        OpenFileDialog open; // file chooser dialog
        int check_valid1, check_valid2, check_valid3, check_valid4, check_valid;
        /* Regex constraints */
        static Regex EMAIL_REGEX = new Regex(@"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+");
        static Regex PHONE_REGEX = new Regex(@"^[0-9]{10,11}$");
        static Regex PASS_REGEX = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$= %^&*-]).{8,32}$");
        public AddUserForm()
        {
            InitializeComponent();
            currentDate.Value = DateTime.Now; // set current date to date time picker
            this.AcceptButton = btnAdd; // set enter button to add
            this.CenterToScreen(); // center the form
        }

        /// <summary>
        /// Load data to form when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            db = new animeEntities(); // instantiate database context
            db.accounts.Load(); // load data to database
            accountBindingSource.DataSource = db.accounts.Local; // load data to data source

            /* Load data to role combo box */
            var roleid = db.roles;
            cbbRoleID.DataSource = roleid.ToList();

            /* Load data to gender combo box */
            cmbgender.Items.Add("Male");
            cmbgender.Items.Add("Female");
            cmbgender.SelectedIndex = 0; // by default gender is male
        }

        /// <summary>
        /// MD5 hashing process
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetMD5(string s)
        {
            byte[] encodedPassword = new UTF8Encoding().GetBytes(s);
            byte[] hash = ((HashAlgorithm)CryptoConfig
                .CreateFromName("MD5")).ComputeHash(encodedPassword);

            return BitConverter.ToString(hash)
                .Replace("-", string.Empty)
                .ToLower();
        }

        /// <summary>
        /// Add the user to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            check_valid_all(sender, e);
            var existingUser = db.accounts.FirstOrDefault(a => a.username.Equals(txtusername.Text));
            if (existingUser != null)
            {
                MessageBox.Show("This username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbbRoleID.SelectedIndex == -1) //Nothing selected
            {
                MessageBox.Show("You must select a role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (check_valid == 0)
            {
                account obj = new account(); // create new account object to add to database

                /* Assign details for new account before adding */
                obj.avatar = txtavatar.Text;
                obj.created_at = DateTime.Now;
                obj.deleted_at = null;
                obj.email = txtemail.Text;
                obj.fullname = txtfullname.Text;

                // assign gender depends on text
                if (cmbgender.Text == "Male")
                {
                    obj.gender = 1;
                } else if (cmbgender.Text == "Female")
                {
                    obj.gender = 2;
                } else
                {
                    obj.gender = 3;
                }
                obj.password = GetMD5(txtPassword.Text);
                obj.RoleID = cbbRoleID.Text == "Admin" ? 1 : 2;
                obj.username = txtusername.Text;

                // add to database and save changes
                db.accounts.Add(obj);
                db.SaveChanges();

                MessageBox.Show("New user has been successfully added to database!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Have something wrong in input! Please check again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        /// <summary>
        /// Choose avatar for user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoose_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog(); // instantiate new instance
            /* Set some basic properties for dialog */
            open.Filter = "Images|*.jpg;*.jpeg;*.png";
            open.InitialDirectory = @"C:\";
            open.Title = "Please select an image to add.";

            // if user clicks OK, proceed to upload avatar
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtavatar.Text = Path.GetFileName(open.FileName);
                try
                {
                    File.Copy(open.FileName, @"../../../FDMSWEB/Content/Images/users/" + Path.GetFileName(open.FileName), true);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Don't choose picture from the source file", "This admin is trying to change picture in source",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtavatar.Text = "";
                }
            }
        }

        /// <summary>
        /// Calculate and check for all fields
        /// </summary>
        /// <returns></returns>
        public int check_valid_all(object sender, EventArgs e)
        {
            txtusername_Validating(sender, e);
            txtPassword_Validating(sender, e);
            txtre_pass_Validating(sender, e);
            txtemail_Validating(sender, e);
            check_valid = check_valid1 + check_valid2 + check_valid3 + check_valid4;
            return check_valid;
        }

        /// <summary>
        /// Validate username field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtusername_Validating(object sender, EventArgs e)
        {
            /* Check if username is empty or has less than 5 characters */
            if (txtusername.Text == string.Empty)
            {
                MessageBox.Show("Username must not be empty!\nPlease input username again!", "Invalid username input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check_valid1 = 1;
            }
            else if (txtusername.Text.Length <= 4)
            {
                MessageBox.Show("Username length must be above 4 characters!\nPlease input username again!", "Invalid username input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check_valid1 = 1;
            }
            else
            {
                check_valid1 = 0;
            }
        }

        /// <summary>
        /// Validate password field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_Validating(object sender, EventArgs e)
        {
            /* Check if password is empty or not match regex */
            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Password must not be empty!\nPlease input password again!", "Invalid password input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check_valid2 = 1;
            }
            else if(!PASS_REGEX.IsMatch(txtPassword.Text))
            {
                // Incorrect password format
                MessageBox.Show("Password length must be equal or above 8 characters and must have one normal, uppercase, special character and one number!\nPlease input password again!", "Invalid password input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check_valid2 = 1;
            }
            else
            {
                check_valid2 = 0;
            }
        }

        /// <summary>
        /// Validate re-password field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtre_pass_Validating(object sender, EventArgs e)
        {
            /* Check if re-password is empty or doesn't match password */
            if (txtre_pass.Text != txtPassword.Text)
            {
                MessageBox.Show("Re-Password must match Password!\nPlease input re-password again!", "Invalid re-password input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check_valid3 = 1;
            }
            else if (txtre_pass.Text == string.Empty)
            {
                MessageBox.Show("Re-Password must not be empty!\nPlease input re-password again!", "Invalid re-password input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check_valid3 = 1;
            }
            else
            {
                check_valid3 = 0;
            }
        }

        /// <summary>
        /// Validate email field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtemail_Validating(object sender, EventArgs e)
        {
            /* Check if email doesn't match regex */
            if (!EMAIL_REGEX.IsMatch(txtemail.Text) && txtemail.Text != "")
            {
                MessageBox.Show("Invalid email format!\nPlease input email again in valid format or left blank!\nExample Format: abc@gmail.com", "Invalid email input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check_valid4 = 1;
            }
            else
            {
                check_valid4 = 0;
            }
        }
    }
}
