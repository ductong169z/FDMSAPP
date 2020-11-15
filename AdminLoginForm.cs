using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDMSAPP
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
        // On Login button click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            db = new animeEntities();

            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                var exituser = db.accounts.FirstOrDefault(a => a.username.Equals(txtUsername.Text));
                if (exituser != null)
                {
                    txtPassword.Text = GetMD5(txtPassword.Text);
                    if (exituser.password.Equals(txtPassword.Text))
                    {
                        if (exituser.RoleID.Equals(1))
                        {
                            // Succeed
                            lblError.Text = "";
                            //show id admin
                            MessageBox.Show("ID Admin: "+exituser.AccountID.ToString(), "Message ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Hide this form
                            this.Hide();
                            DashBoard db = new DashBoard();
                            //show form MDI
                            //MDIParent1 mp = new MDIParent1(exituser.AccountID.ToString());
                            // Show info form
                            db.Show();
                            //this.Close();// This line stops the hidden form from running in the background, which can lead to memory leaks and performance issues.
                        }
                        else
                        {
                            // Show error
                            lblError.Text = "Goto napthe.vn";
                        }
                    }
                }
                // Show error
                lblError.Text = "Goto napthe.vn";
            }
            // Show error
            lblError.Text = "Goto napthe.vn";
        }
        // Reset input password
        public void ResetPassword()
        {
            txtPassword.Text = "";
        }
        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void linkpaypay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.napthe.vn/app");
        }
    }
}
