using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSAPP
{
    public partial class UserForm : Form
    {
        animeEntities db; // database context to use
        OpenFileDialog open; // file chooser dialog

        /// <summary>
        /// Constructor
        /// </summary>
        public UserForm()
        {
            InitializeComponent();
            currentDate.Value = DateTime.Now; // set current date

            this.CenterToScreen(); // center the form
        }

        /// <summary>
        /// Load data to form when form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserForm_Load(object sender, EventArgs e)
        {
            db = new animeEntities(); // instantiate new database context
            db.accounts.Load(); // load from database
            accountBindingSource.DataSource = db.accounts.Local.ToBindingList().Where(a => a.deleted_at == null); // load accounts to data source (that are not deleted)

            // loads if there is avatar
            if (txtAvatar.Text != null && txtAvatar.Text != "")
            {
                pbAvatar.Image = Image.FromFile(@"../../../FDMSWEB/Content/Images/users/" + Path.GetFileName(txtAvatar.Text));
            }

            /* Load roles to combobox */
            var roleid = db.roles;
            cbbRoleID.DataSource = roleid.ToList();
        }

        /// <summary>
        /// Open new form for inputting and add new user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /* Instantiate new form and show the form */
            AddUserForm auf = new AddUserForm();
            auf.Show();
        }

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // check if user has selected a row
            if (userGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to delete!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int n = userGridView.CurrentRow.Index; // get current row index

            try
            {
                int deletedId = Convert.ToInt32(userGridView.Rows[n].Cells[0].Value); // get account ID
                account deletedUser = db.accounts.FirstOrDefault(a => a.AccountID == deletedId); // get account object using ID
                deletedUser.deleted_at = DateTime.Now; // update deleted_at date

                /* Updates to database */
                db.accounts.AddOrUpdate(deletedUser);
                db.SaveChanges();

                /* Empty the input fields and reset combo box to default value */
                cbbRoleID.SelectedIndex = 0;
                txtFullName.Text = "";
                txtEmail.Text = "";
                cbbGender.Text = "Male";
                txtAvatar.Text = "";
                pbAvatar.Image = null;

                // update binding source data
                accountBindingSource.DataSource = db.accounts.Local.ToBindingList().Where(a => a.deleted_at == null); // load accounts to data source (that are not deleted)

                /* Indicates successful deletion */
                MessageBox.Show("The user \"" + deletedUser.fullname + "\" has been successfully deleted!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot delete the selected user! Please try again!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Update a user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check if user has selected a row
            if (userGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to update!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int n = userGridView.CurrentRow.Index; // current row index
            int updateId = Convert.ToInt32(userGridView.Rows[n].Cells[0].Value); // get account ID
            account updateUser = db.accounts.FirstOrDefault(a => a.AccountID == updateId); // get account object using ID

            // update gender
            if (cbbGender.Text == "Male")
            {
                updateUser.gender = 1;
            } else if (cbbGender.Text == "Female")
            {
                updateUser.gender = 2;
            } else
            {
                updateUser.gender = 3;
            }

            updateUser.avatar = txtAvatar.Text;
            /* Updates to database */
            db.accounts.AddOrUpdate(updateUser);
            db.SaveChanges();

            // update binding source data
            accountBindingSource.DataSource = db.accounts.Local.ToBindingList().Where(a => a.deleted_at == null); // load accounts to data source (that are not deleted)

            MessageBox.Show("Selected user info has been successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /* Empty the input fields and reset combo box to default value */
            cbbRoleID.SelectedIndex = 0;
            txtFullName.Text = "";
            txtEmail.Text = "";
            cbbGender.Text = "Male";
            txtAvatar.Text = "";
            pbAvatar.Image = null;
        }

        /// <summary>
        /// Dispose database context when form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }

        /// <summary>
        /// Refresh user grid view and reload database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            userGridView.Refresh(); // refresh data grid view
            db.accounts.Load(); // reload database
            accountBindingSource.DataSource = db.accounts.Local.ToBindingList().Where(a => a.deleted_at == null); // load accounts to data source (that are not deleted)
            MessageBox.Show("The grid view has been refreshed and data has been reloaded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Choose user avatar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoose_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog(); // instantiate new instance
            /* Set some default properties */
            open.Filter = "Images|*.jpg;*.jpeg;*.png";
            open.InitialDirectory = @"C:\";
            open.Title = "Please select an image to update.";

            // if user clicks OK, load the image
            if (open.ShowDialog() == DialogResult.OK)
            {
                int count = 1;

                string fileNameOnly = Path.GetFileNameWithoutExtension(open.FileName);
                string extension = Path.GetExtension(open.FileName);
                string path = Path.GetDirectoryName(open.FileName);
                string newFullPath = open.FileName;
                if (txtAvatar.Text == "")
                {
                    txtAvatar.Text = Path.GetFileName(open.FileName);
                }
                while (File.Exists(@"../../../FDMSWEB/Content/Images/users/" + Path.GetFileName(txtAvatar.Text)))
                {
                    string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                    newFullPath = Path.Combine(@"../../../FDMSWEB/Content/Images/users/", tempFileName + extension);
                    txtAvatar.Text = Path.GetFileName(newFullPath);
                }
                File.Copy(open.FileName, @"../../../FDMSWEB/Content/Images/users/" + Path.GetFileName(newFullPath));
            }
        }

        /// <summary>
        /// Update data to gender combo box and picture box on cell click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Update combo box gender text */
            if (userGridView.Rows[e.RowIndex].Cells[6].Value.ToString().Equals("1"))
            {
                cbbGender.Text = "Male";
            }
            else if (userGridView.Rows[e.RowIndex].Cells[6].Value.ToString().Equals("2"))
            {
                cbbGender.Text = "Female";
            }
            else
            {
                cbbGender.Text = "Other";
            }

            // check if account has any avatar
            if (txtAvatar.Text == "")
            {
                pbAvatar.Image = null;
            }
            else
            {
                try
                {
                    // update account avatar to picture box to display
                    pbAvatar.Image = Image.FromFile(@"../../../FDMSWEB/Content/Images/users/" + Path.GetFileName(txtAvatar.Text));
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Can't not find the picture", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Find users whose username contains find value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            // if find value is null or empty, show all users
            if (string.IsNullOrEmpty(this.txtFind.Text))
            {
                accountBindingSource.DataSource = db.accounts.Local.ToBindingList().Where(a => a.deleted_at == null); // load all accounts to data source (that are not deleted)
            }
            else
            {
                // obtain list of accounts whose usernames contain find value and are not deleted
                var filteredData = db.accounts.Local.ToBindingList()
                    .Where(x => x.username.Contains(this.txtFind.Text) && x.deleted_at == null);

                // load filtered data to binding source
                accountBindingSource.DataSource = filteredData.Count() > 0 ?
                    filteredData : filteredData.ToArray();
            }
        }

        /// <summary>
        /// Format all numeric gender values to corresponding strings to display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // check if the column is gender
            if (userGridView.Columns[e.ColumnIndex].Index == 6)
            {
                // check if cell value is null
                if (e.Value != null)
                {
                    if (e.Value.ToString().Equals("1"))
                    {
                        e.Value = "Male";
                    }
                    else if (e.Value.ToString().Equals("2"))
                    {
                        e.Value = "Female";
                    }
                    else
                    {
                        e.Value = "Other";
                    }
                }
            }
        }
    }
}
