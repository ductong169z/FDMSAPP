using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSAPP
{
    using System.Diagnostics;
    using System.Security.Cryptography;
    public partial class AdminLoginForm : Form
    {
        animeEntities db;
        // Constructor
        public AdminLoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.CenterToScreen();
            this.FormClosing += delegate
            {
                Application.Exit();
            };
        }
        // Get MD5 from given string
        public static string GetMD5(string s)
        {
            byte[] encodedPassword = new UTF8Encoding().GetBytes(s);
            byte[] hash = ((HashAlgorithm)CryptoConfig
                .CreateFromName("MD5")).ComputeHash(encodedPassword);

            return BitConverter.ToString(hash)
                .Replace("-", string.Empty)
                .ToLower();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }
        // Reset input password
        public void ResetPassword()
        {
            txtPassword.Text = "";
        }
        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        // On Login button click
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            db = new animeEntities();

            // By default, show no errors
            lblError.Text = "";

            var existUser = db.accounts.FirstOrDefault(a => a.username.Equals(txtUsername.Text));
            if (existUser != null)
            {
                System.Diagnostics.Debug.WriteLine(existUser.password);
                System.Diagnostics.Debug.WriteLine(existUser.username);
                if (existUser.password.Equals(GetMD5(txtPassword.Text)))
                {
                    System.Diagnostics.Debug.WriteLine("CORRECT!");
                    if (existUser.RoleID.Equals(1))
                    {
                        //show id existUser
                        MessageBox.Show("You have been logged in!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Hide this form
                        this.Hide();
                        DashBoard db = new DashBoard(existUser.AccountID.ToString());
                        //show form MDI
                        //MDIParent1 mp = new MDIParent1(existUser.AccountID.ToString());
                        // Show info form
                        db.Show();
                        //this.Close();// This line stops the hidden form from running in the background, which can lead to memory leaks and performance issues.
                    }
                    else
                    {
                        // Show error
                        lblError.Text = "Username or Password is incorrect!";
                    }
                }
            }
            // Show error
            lblError.Text = "Username or Password is incorrect!";
        }
    }
}
