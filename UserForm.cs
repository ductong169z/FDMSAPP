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
            dateTimeUpdate.Value = DateTime.Now;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            db = new animeEntities();
            db.accounts.Load();
            accountBindingSource.DataSource = db.accounts.Local;
            //testpicturebox.Image = Image.FromFile(@"../../../FDMSWEB/Content/Images/Avatar/" + Path.GetFileName(txtAvatar.Text));
            var roleid = db.roles;
            cbbRoleID.DataSource = roleid.ToList();
            cbbRoleID.DisplayMember = "RoleID";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[8].Value == null && dataGridView1.Rows[i].Cells[2].Value?.ToString() == "2")
                /* if (dataGridView1.Rows.Cast<DataGridViewRow>()
      .Any(c => string.IsNullOrWhiteSpace(c.Cells[13].Value?.ToString())))*/
                {
                    dataGridView1.Rows[i].Visible = true;
                }
                else if (dataGridView1.Rows.Cast<DataGridViewRow>()
     .Any(c => string.IsNullOrWhiteSpace(c.Cells[8].Value?.ToString())))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    dataGridView1.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserForm auf = new AddUserForm();
            auf.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[n].Cells[8].Value = dateTimeDelete.Value.ToString();
            CurrencyManager currencyManager1 = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            currencyManager1.SuspendBinding();
            dataGridView1.Rows[n].Visible = false;
            currencyManager1.ResumeBinding();
            db.SaveChanges();
            MessageBox.Show("Your data has been successfully delete(or you really think that is)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                int n = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows[n].Cells[9].Value = dateTimeUpdate.Value.ToString();
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
            dataGridView1.Refresh();
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
                File.Copy(open.FileName, @"../../../FDMSWEB/Content/Images/Avatar/" + Path.GetFileName(open.FileName), true);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //testpicturebox.Image = Image.FromFile(@"../../../FDMSWEB/Content/Images/Avatar/" + Path.GetFileName(txtAvatar.Text));
        }
    }
}
