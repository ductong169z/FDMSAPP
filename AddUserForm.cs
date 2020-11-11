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
        animeEntities db;
        DateTime today = DateTime.Today;
        int check_valid1, check_valid2, check_valid3, check_valid4, check_valid5, check_valid;
        public AddUserForm()
        {
            InitializeComponent();
            DateTimePicker dt = new DateTimePicker();
            dateTimeAdd.Value = DateTime.Now;
            this.AcceptButton = btnAdd;
            this.CenterToScreen();
            this.FormClosing += delegate
            {
                Application.Exit();
            };
        }
        // Regex contstraints
        static Regex EMAIL_REGEX = new Regex(@"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+");
        static Regex PHONE_REGEX = new Regex(@"^[0-9]{10,11}$");
        static Regex PASS_REGEX = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$= %^&*-]).{8,32}$");
        public static string GetMD5(string s)
        {
            byte[] encodedPassword = new UTF8Encoding().GetBytes(s);
            byte[] hash = ((HashAlgorithm)CryptoConfig
                .CreateFromName("MD5")).ComputeHash(encodedPassword);

            return BitConverter.ToString(hash)
                .Replace("-", string.Empty)
                .ToLower();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            db = new animeEntities();
            db.accounts.Load();
            accountBindingSource.DataSource = db.accounts.Local;
            var roleid = db.roles;
            cbbRoleID.DataSource = roleid.ToList();
            cbbRoleID.DisplayMember = "RoleID";
            // Add a DemoUser to cause a row to be displayed.
            this.accountBindingSource.AddNew();
        }
        public int check_valid_all()
        {
            check_valid = check_valid1 + check_valid2 + check_valid3 + check_valid4 + check_valid5;
            return check_valid;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            check_valid_all();
            var exituser = db.accounts.FirstOrDefault(a => a.username.Equals(txtusername.Text));
            if (exituser != null)
            {
                MessageBox.Show("This username already have", "Error");
            }
            else if (cbbRoleID.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show("You must select a role", "Error");
            }
            else if (check_valid == 0)
            {
                txtPassword.Text = GetMD5(txtPassword.Text);
                db.SaveChanges();
                MessageBox.Show("Your data has been successfully Add(or you really think that is)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Have something wrong in input! Plz check again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        OpenFileDialog open;
        private void btnChoose_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "Images|*.jpg;*.jpeg;*.png";
            open.InitialDirectory = @"C:\";
            open.Title = "Please select an image to add.";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtavatar.Text = Path.GetFileName(open.FileName);
                File.Copy(open.FileName, @"../../../FDMSWEB/Content/Images/Avatar/" + Path.GetFileName(open.FileName), true);
            }
        }

        private void txtusername_Validating(object sender, CancelEventArgs e)
        {
            if (txtusername.Text == string.Empty)
            {
                MessageBox.Show("Username is empty");
                check_valid1 = 1;
            }
            else if (txtusername.Text.Length <= 4)
            {
                MessageBox.Show("Username is smaller than 4");
                check_valid1 = 1;
            }
            else
            {
                check_valid1 = 0;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Password is empty");
                check_valid2 = 1;
            }
            else if(!PASS_REGEX.IsMatch(txtPassword.Text))
            {
                // Incorrect password format
                MessageBox.Show("Password must have one normal, special, and upper-char!");
                check_valid2 = 1;
            }
            else
            {
                check_valid2 = 0;
            }
        }

        private void txtre_pass_Validating(object sender, CancelEventArgs e)
        {
            if (txtre_pass.Text != txtPassword.Text)
            {
                MessageBox.Show("Re-Password is not the same");
                check_valid3 = 1;
            }
            else if (txtre_pass.Text == string.Empty)
            {
                MessageBox.Show("Re-Password is empty");
                check_valid3 = 1;
            }
            else
            {
                check_valid3 = 0;
            }
        }
        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            if (!EMAIL_REGEX.IsMatch(txtemail.Text))
            {
                MessageBox.Show("Email is wrong, Plz check again");
                check_valid4 = 1;
            }
            else
            {
                check_valid4 = 0;
            }
        }
        private void dateTimeAdd_Validating(object sender, CancelEventArgs e)
        {
            if(DateTime.Compare(dateTimeAdd.Value, today) != 0) 
            {
                MessageBox.Show("Date Add not today, Plz choose again");
                check_valid5 = 1;
            }
            else
            {
                check_valid5 = 0;
            }
        }
    }
}
