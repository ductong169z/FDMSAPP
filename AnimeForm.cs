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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FMSAPP
{
    public partial class AnimeForm : Form
    {
        DateTime dateTimeDelete;
        string adminId;
        animeEntities db;
        int check_valid1, check_valid2, check_valid3, check_valid4, check_valid;
        public AnimeForm(string adminId)
        {
            InitializeComponent();
            dateTimeDelete = DateTime.Now;  // set deleted date
            txtCurrentDate.Value = DateTime.Now; // set current date
            txtCurrentDate.Enabled = false; // disable editing

            txtUrAdminId.Text = adminId; // set own admin id
            this.adminId = adminId; // set admin id to global variable

            this.Width = Screen.PrimaryScreen.WorkingArea.Width; // set form width

            this.CenterToScreen(); // center form
        }
        // Regex constraints
        static Regex LINK_REGEX = new Regex(@"^(https?\:\/\/)?(www\.)?((?:youtube\.com|youtu.be))(\/(?:[\w\-]+\?v=|embed\/|v\/)?)([\w\-]+)(\S+)|(\&[\w\-]+)(\S+)?$");
        static Regex DURATION_REGEX = new Regex(@"^\d{1,2}\s((min|sec|hour|hr){1})\s((per){1}|(\d{1,2}))\s((ep|min){1})?$");
        private void AnimeForm_Load(object sender, EventArgs e)
        {
            db = new animeEntities();
            db.animes.Load(); // load from database
            animeBindingSource.DataSource = db.animes.Local.Where(a => a.deleted_at == null); // load animes to data source (that are not deleted)
                                                                                              //pbPoster.Image = Image.FromFile(@"../../../FDMSWEB/Content/Images/Posters/" + Path.GetFileName(txtPos.Text)); // load anime poster

            /* Load seasons to combo box */
            var season = db.seasons;
            cbbSeason.DataSource = season.ToList();
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
            if (txtEpi.Text.Length > 4)
            {
                MessageBox.Show("Episode is too big! (Not bigger than 9999)");
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
                anime obj = new anime();
                obj.AccountID = Convert.ToInt32(this.adminId);
                obj.created_at = txtCurrentDate.Value;
                obj.deleted_at = null;
                obj.description = txtDes.Text;
                obj.duration = txtDura.Text;
                obj.episodes = txtEpi.Text;
                obj.name = txtName.Text;
                obj.poster = txtPos.Text;
                obj.rating = cbbRating.GetItemText(cbbRating.SelectedItem);
                if (cbbSeason.SelectedItem != null)
                {
                    obj.SeasonID = Convert.ToInt32(cbbSeason.SelectedValue);
                }
                else
                {
                    obj.SeasonID = null;
                }
                obj.type = cbbRating.GetItemText(cbbType.SelectedItem);
                obj.releaseDate = txtReleaseDate.Value;
                obj.status = cbbStatus.GetItemText(cbbStatus.SelectedItem);
                obj.trailer = txtTrailer.Text;
                obj.episodes = txtEpi.Text;
                db.animes.Add(obj);
                db.SaveChanges();
                animeBindingSource.DataSource = db.animes.Local.ToBindingList().Where(a => a.deleted_at == null); // load animes to data source (that are not deleted)
                MessageBox.Show("You have successfully added the anime " + txtName.Text + "!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTrailer_Validating(object sender, EventArgs e)
        {
            if (!LINK_REGEX.IsMatch(txtTrailer.Text) && !txtTrailer.Text.Equals(""))
            {
                // Incorrect link format
                MessageBox.Show("A valid URL must be like this: https://www.youtube.com/embed/41Gj4Dri8wo?enablejsapi=1&wmode=opaque&autoplay=1 \n(or be left empty)");
                check_valid4 = 1;
            }
            else
            {
                check_valid4 = 0;
            }
        }

        private void txtDura_Validating(object sender, EventArgs e)
        {
            if (!DURATION_REGEX.IsMatch(txtDura.Text) && !txtDura.Text.Equals("Unknown"))
            {
                // Incorrect password format
                MessageBox.Show("The duration must begin with number or be \"Unknown\".\nEx: 01 sec|min|hour per ep or \"Unknown\"");
                check_valid4 = 2;
            }
            else
            {
                check_valid4 = 0;
            }
        }
        OpenFileDialog open;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtPos.Text == "")
            {
                pbPoster.Image = null;
            }
            else
            {
                try
                {
                    pbPoster.Image = Image.FromFile(@"../../../FDMSWEB/Content/Images/Posters/" + Path.GetFileName(txtPos.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't not find the anime picture", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFind.Text))
            {
                this.animeBindingSource.DataSource = db.animes.Local.ToBindingList();
            }
            else
            {
                IEnumerable<anime> filteredData = db.animes.Local.ToBindingList()
                    .Where(x => x.name.Contains(txtFind.Text));
                this.animeBindingSource.DataSource = filteredData.Count() > 0 ?
                    filteredData : filteredData.ToArray();
            }
        }

        private void btnChoose_Click_1(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "Images|*.jpg;*.jpeg;*.png";
            open.InitialDirectory = @"C:\";
            open.Title = "Please select an image to add or update.";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtPos.Text = Path.GetFileName(open.FileName);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (animeGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select an anime to delete!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int n = animeGridView.CurrentRow.Index;

            int deletedId = Convert.ToInt32(animeGridView.Rows[n].Cells[0].Value);
            anime deletedAnime = db.animes.FirstOrDefault(a => a.AnimeID == deletedId);
            deletedAnime.deleted_at = dateTimeDelete;
            CurrencyManager currencyManager1 = (CurrencyManager)animeGridView.BindingContext[animeGridView.DataSource];
            currencyManager1.SuspendBinding();
            animeGridView.Rows[n].Visible = false;
            currencyManager1.ResumeBinding();
            db.animes.AddOrUpdate(deletedAnime);
            db.SaveChanges();
            MessageBox.Show("The selected anime has been successfully deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtAnimeId.Text = "";
            txtAdminId.Text = "";
            txtName.Text = "";
            txtEpi.Text = "";
            txtDura.Text = "";
            txtDes.Text = "";
            txtTrailer.Text = "";
            cbbSeason.SelectedIndex = 0;
            cbbRating.SelectedIndex = 0;
            cbbStatus.SelectedIndex = 0;
            cbbType.SelectedIndex = 0;
            txtReleaseDate.Text = "";
            txtPos.Text = "";
            pbPoster.Image = null;
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
                if (animeGridView.CurrentRow == null)
                {
                    MessageBox.Show("Please select an anime to update!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int n = animeGridView.CurrentRow.Index;

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

    class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            DoubleBuffered = true;
        }
    }
}
