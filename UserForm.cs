using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        public UserForm()
        {
            InitializeComponent();
            DateTimePicker dt = new DateTimePicker();
            dateTimeDelete.Value = DateTime.Now;
            currentDate.Value = DateTime.Now;
            this.WindowState = FormWindowState.Normal;
            this.CenterToScreen();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            db = new animeEntities();
            db.accounts.Load();
            accountBindingSource.DataSource = db.accounts.Local.ToBindingList().Where(a => a.deleted_at == null && a.RoleID == 2);

            //testpicturebox.Image = Image.FromFile(@"../../../FDMSWEB/Content/Images/Avatar/" + Path.GetFileName(txtAvatar.Text));
            var roleid = db.roles;
            cbbRoleID.DataSource = roleid.ToList();
            cbbRoleID.DisplayMember = "RoleID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserForm auf = new AddUserForm();
            auf.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int n = userGridView.CurrentRow.Index;
            userGridView.Rows[n].Cells[8].Value = dateTimeDelete.Value.ToString();
            CurrencyManager currencyManager1 = (CurrencyManager)userGridView.BindingContext[userGridView.DataSource];
            currencyManager1.SuspendBinding();
            userGridView.Rows[n].Visible = false;
            currencyManager1.ResumeBinding();
            db.SaveChanges();
            MessageBox.Show("Your data has been successfully deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int n = userGridView.CurrentRow.Index;
            userGridView.Rows[n].Cells[9].Value = currentDate.Value.ToString();
            db.SaveChanges();
            MessageBox.Show("Your data has been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var changed = db.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();
            foreach (var obj in changed)
            {
                switch (obj.State)
                {
                    case EntityState.Modified:
                        obj.CurrentValues.SetValues(obj.OriginalValues);
                        obj.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        obj.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        obj.State = EntityState.Unchanged;
                        break;

                }
            }
            accountBindingSource.ResetBindings(false);
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            userGridView.Refresh();
        }
        OpenFileDialog open;
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
                this.accountBindingSource.DataSource = db.accounts.Local.ToBindingList();
            }
            else
            {
                var filteredData = db.accounts.Local.ToBindingList()
                    .Where(x => x.username.Contains(this.txtFind.Text));
                this.accountBindingSource.DataSource = filteredData.Count() > 0 ?
                    filteredData : filteredData.ToArray();
            }
        }
    }
}
