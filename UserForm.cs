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
        animeEntities db;
        OpenFileDialog open; 
        public UserForm()
        {
            InitializeComponent();
            currentDate.Value = DateTime.Now; // set current date

            this.CenterToScreen(); // center the form
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            db = new animeEntities(); // instantiate new database context
            db.accounts.Load(); // load from database
            accountBindingSource.DataSource = db.accounts.Local.ToBindingList().Where(a => a.deleted_at == null && a.RoleID == 2); // load users to data source (that are not deleted)

            // loads if there is avatar
            if (txtAvatar.Text != null && txtAvatar.Text != "")
            {
                pbAvatar.Image = Image.FromFile(@"../../../FDMSWEB/Content/Images/Avatar/" + Path.GetFileName(txtAvatar.Text));
            }

            /* Load roles to combobox */
            var roleid = db.roles;
            cbbRoleID.DataSource = roleid.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserForm auf = new AddUserForm();
            auf.Show();
        }

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
                accountBindingSource.DataSource = db.accounts.Local.ToBindingList().Where(a => a.deleted_at == null && a.RoleID == 2); // load users to data source (that are not deleted)

                /* Indicates successful deletion */
                MessageBox.Show("The user \"" + deletedUser.fullname + "\" has been successfully deleted!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot delete the selected user! Please try again!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check if user has selected a row
            if (userGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to update!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            db.SaveChanges();

            // update binding source data
            accountBindingSource.DataSource = db.accounts.Local.ToBindingList().Where(a => a.deleted_at == null && a.RoleID == 2); // load users to data source (that are not deleted)

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

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            userGridView.Refresh();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "Images|*.jpg;*.jpeg;*.png";
            open.InitialDirectory = @"C:\";
            open.Title = "Please select an image to update.";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtAvatar.Text = Path.GetFileName(open.FileName);
                try
                {
                    File.Copy(open.FileName, @"../../../FDMSWEB/Content/Images/Avatar/" + Path.GetFileName(open.FileName), true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Don't change picture from the source file", "This admin is trying to change picture in source", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbbGender.Text == "1")
            {
                cbbGender.Text = "Male";
            }
            else if (cbbGender.Text == "2")
            {
                cbbGender.Text = "Female";
            }

            if (txtAvatar.Text == "")
            {
                pbAvatar.Image = null;
            }
            else
            {
                try
                {
                    pbAvatar.Image = Image.FromFile(@"../../../FDMSWEB/Content/Images/Avatar/" + Path.GetFileName(txtAvatar.Text));
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Can't not find the picture", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtFind.Text))
            {
                this.accountBindingSource.DataSource = db.accounts.Local.ToBindingList().Where(a => a.deleted_at == null && a.RoleID == 2); // load all users to data source (that are not deleted)
            }
            else
            {
                var filteredData = db.accounts.Local.ToBindingList()
                    .Where(x => x.username.Contains(this.txtFind.Text) && x.deleted_at == null && x.RoleID == 2);
                this.accountBindingSource.DataSource = filteredData.Count() > 0 ?
                    filteredData : filteredData.ToArray();
            }
        }
    }
}
