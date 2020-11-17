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
        animeEntities db; // database context to use
        /// <summary>
        /// Constructor
        /// </summary>
        public AdminLoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin; // bind Enter to Login button
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // set picture box size mode
            this.CenterToScreen(); // center the form

            // close this form equals exit the app
            this.FormClosing += delegate
            {
                Application.Exit();
            };
        }

        /// <summary>
        /// Get MD5 from given string
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
        /// Login the Admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            db = new animeEntities(); // instantiate new database context

            // by default, show no errors
            lblError.Text = "";

            var existUser = db.accounts.FirstOrDefault(a => a.username.Equals(txtUsername.Text)); // check if user exists in database

            // if user exists in database
            if (existUser != null)
            {
                // if password matches one in database
                if (existUser.password.Equals(GetMD5(txtPassword.Text)))
                {
                    // if user is admin
                    if (existUser.RoleID.Equals(1))
                    {
                        // show message indicates successful login
                        MessageBox.Show("You have been logged in!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // hide the form
                        this.Hide();

                        /* Instantiate and show dash board */
                        DashBoard db = new DashBoard(existUser.AccountID.ToString());
                        db.Show();
                    }
                    else
                    {
                        // show error
                        lblError.Text = "Username or Password is incorrect!";
                    }
                }
            }
            // show error
            lblError.Text = "Username or Password is incorrect!";
        }
    }
}
