using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FMSAPP
{
    public partial class AnimeForm : Form
    {
        string dateTimeUpdate;
        string dateTimeDelete;
        animeEntities db;
        int check_valid1, check_valid2, check_valid3, check_valid4, check_valid;
        public AnimeForm()
        {
            InitializeComponent();
            dateTimeAdd.Value = DateTime.Now;
            dateTimeUpdate = DateTime.Now.ToString();
            dateTimeDelete = DateTime.Now.ToString();
            this.WindowState = FormWindowState.Maximized;
        }
        // Regex contstraints
        static Regex LINK_REGEX = new Regex(@"^(https?\:\/\/)?(www\.)?((?:youtube\.com|youtu.be))(\/(?:[\w\-]+\?v=|embed\/|v\/)?)([\w\-]+)(\S+)|(\&[\w\-]+)(\S+)?$");
        static Regex DURATION_REGEX = new Regex(@"^\d{1,2}\s((min|sec|hour|hr){1})\s((per){1}|(\d{1,2}))\s((ep|min){1})?$");
        private void AnimeForm_Load(object sender, EventArgs e)
        {
            db = new animeEntities();
            db.animes.Load();
            animeBindingSource.DataSource = db.animes.Local;
            testpicturebox.Image = Image.FromFile(@"../../../FDMSWEB/Content/Images/Posters/" + Path.GetFileName(txtPoster.Text));
            var season = db.seasons;
            cbbSeason.DisplayMember = "SeasonID";
            cbbSeason.DataSource = season.ToList();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[14].Value == null)
                /* if (dataGridView1.Rows.Cast<DataGridViewRow>()
      .Any(c => string.IsNullOrWhiteSpace(c.Cells[13].Value?.ToString())))*/
                {
                    dataGridView1.Rows[i].Visible = true;
                }
                else if (dataGridView1.Rows.Cast<DataGridViewRow>()
     .Any(c => string.IsNullOrWhiteSpace(c.Cells[14].Value?.ToString())))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    dataGridView1.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
            /*            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[13].Value.ToString() != null)
            if (dataGridView1.Rows.Cast<DataGridViewRow>().Any(c => c.Cells[13].Value.ToString() != ""))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    dataGridView1.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }*/
        }

        private void txtName_Validating(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Name is empty");
                check_valid1 = 1;
            }
            else
            {
                check_valid1 = 0;
            }
        }

        private void txtEpi_Validating(object sender, EventArgs e)
        {
            if (txtEpi.Text.Length >= 4)
            {
                MessageBox.Show("Episode is too big (Not longger than 9999");
                check_valid2 = 1;
            }
            else
            {
                check_valid2 = 0;
            }
        }

        private void txtDes_Validating(object sender, EventArgs e)
        {
            if (txtDes.Text == string.Empty)
            {
                MessageBox.Show("Description is empty");
                check_valid3 = 1;
            }
            else
            {
                check_valid3 = 0;
            }
        }
        public int check_valid_all(object sender, EventArgs e)
        {
            txtName_Validating(sender, e);
            txtEpi_Validating(sender, e);
            txtDes_Validating(sender, e);
            txtDura_Validating(sender, e);
            txtTrailer_Validating(sender, e);
            check_valid = check_valid1 + check_valid2 + check_valid3 + check_valid4;
            return check_valid;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            check_valid_all(sender, e);
            if (check_valid != 0)
            {
                MessageBox.Show("There is something wrong in input! Please check again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                animeBindingSource.AddNew();
                int n = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows[n].Cells[13].Value = dateTimeAdd.Value.ToString();
            }
        }

        private void txtTrailer_Validating(object sender, EventArgs e)
        {
            if (!LINK_REGEX.IsMatch(txtTrailer.Text))
            {
                // Incorrect link format
                MessageBox.Show("A valid URL must be like this: https://www.youtube.com/embed/41Gj4Dri8wo?enablejsapi=1&wmode=opaque&autoplay=1");
                check_valid4 = 1;
            }
            else
            {
                check_valid4 = 0;
            }
        }

        private void txtDura_Validating(object sender, EventArgs e)
        {
            if (!DURATION_REGEX.IsMatch(txtDura.Text))
            {
                // Incorrect password format
                MessageBox.Show("The duration must begin with number . Ex:01 sec|min|hour per ep");
                check_valid4 = 2;
            }
            else
            {
                check_valid4 = 0;
            }
        }
        OpenFileDialog open;
        private void btnChoose_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "Images|*.jpg;*.jpeg;*.png";
            open.InitialDirectory = @"C:\";
            open.Title = "Please select an image to add or update.";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtPoster.Text = Path.GetFileName(open.FileName);
                try
                {
                    File.Copy(open.FileName, @"../../../FDMSWEB/Content/Images/Posters/" + Path.GetFileName(open.FileName), true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Don't change picture from the source file", "This admin is trying to change picture in source", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtPoster.Text == "")
            {
                testpicturebox.Image = null;
            }
            else
            {
                try
                {
                    testpicturebox.Image = Image.FromFile(@"../../../FDMSWEB/Content/Images/Posters/" + Path.GetFileName(txtPoster.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't not find the anime picture", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtFind.Text))
            {
                this.animeBindingSource.DataSource = db.animes.Local.ToBindingList();
            }
            else
            {
                var filteredData = db.animes.Local.ToBindingList()
                    .Where(x => x.name.Contains(this.txtFind.Text));
                this.animeBindingSource.DataSource = filteredData.Count() > 0 ?
                    filteredData : filteredData.ToArray();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[n].Cells[14].Value = dateTimeDelete;
            CurrencyManager currencyManager1 = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            currencyManager1.SuspendBinding();
            dataGridView1.Rows[n].Visible = false;
            currencyManager1.ResumeBinding();
            db.SaveChanges();
            MessageBox.Show("The selected anime has been successfully deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            check_valid_all(sender, e);
            if (check_valid != 0)
            {
                MessageBox.Show("There is something wrong in input! Please check again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int n = dataGridView1.CurrentRow.Index;
                //dataGridView1.Rows[n].Cells[15].Value = dateTimeUpdate;
                db.SaveChanges();
                MessageBox.Show("Your data has been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            animeBindingSource.ResetBindings(false);
        }

        private void AnimeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }
    }
}
