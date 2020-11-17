﻿using System;
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
        DateTime dateTimeDelete; // deleted date
        string adminId; // current logged in admin id
        animeEntities db; // database context
        int check_valid1, check_valid2, check_valid3, check_valid4, check_valid; // validate inputs
        /* Regex constraints */
        static Regex LINK_REGEX = new Regex(@"^(https?\:\/\/)?(www\.)?((?:youtube\.com|youtu.be))(\/(?:[\w\-]+\?v=|embed\/|v\/)?)([\w\-]+)(\S+)|(\&[\w\-]+)(\S+)?$");
        static Regex DURATION_REGEX = new Regex(@"^\d{1,2}\s((min|sec|hour|hr){1})\s((per){1}|(\d{1,2}))\s((ep|min){1})?$");
        OpenFileDialog open; // file chooser dialog

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="adminId"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimeForm_Load(object sender, EventArgs e)
        {
            db = new animeEntities(); // instantiate new database context
            db.animes.Load(); // load from database
            animeBindingSource.DataSource = db.animes.Local.Where(a => a.deleted_at == null); // load animes to data source (that are not deleted)                                                                   

            /* Load seasons to combo box */
            var season = db.seasons;
            cbbSeason.DataSource = season.ToList();
        }

        /* Text box validators */
        /// <summary>
        /// Validate anime name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_Validating(object sender, EventArgs e)
        {
            // name cannot be empty
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Anime name must not be empty!\n Please input anime name again!", "Invalid name input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check_valid1 = 1;
            }
            else
            {
                check_valid1 = 0;
            }
        }

        /// <summary>
        /// Validate anime episodes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEpi_Validating(object sender, EventArgs e)
        {
            // check if episodes is more than 4 numbers
            if (txtEpi.Text.Length > 4)
            {
                MessageBox.Show("The number of episodes is too big! (Not bigger than 9999)", "Invalid episode input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check_valid2 = 1;
            }
            else
            {
                check_valid2 = 0;
            }
        }

        /// <summary>
        /// Validate anime description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDes_Validating(object sender, EventArgs e)
        {
            // check if description is empty
            if (txtDes.Text == string.Empty)
            {
                MessageBox.Show("Description must not be empty!\nPlease input description again!", "Invalid description input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check_valid3 = 1;
            }
            else
            {
                check_valid3 = 0;
            }
        }

        /// <summary>
        /// Validate anime trailer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTrailer_Validating(object sender, EventArgs e)
        {
            // Check invalid link format when user doesn't left it blank
            if (!LINK_REGEX.IsMatch(txtTrailer.Text) && !txtTrailer.Text.Equals(""))
            {
                MessageBox.Show("A valid URL must be like this: https://www.youtube.com/embed/41Gj4Dri8wo?enablejsapi=1&wmode=opaque&autoplay=1 or be left empty!\nPlease input trailer again!", "Invalid trailer input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check_valid4 = 1;
            }
            else
            {
                check_valid4 = 0;
            }
        }

        /// <summary>
        /// Validate anime duration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDura_Validating(object sender, EventArgs e)
        {
            // Check invalid duration when user doesn't left it blank
            if (!DURATION_REGEX.IsMatch(txtDura.Text) && !txtDura.Text.Equals("Unknown"))
            {
                MessageBox.Show("The duration must begin with number or be \"Unknown\".\nEx: 01 sec|min|hour per ep or \"Unknown\"\nPlease input duration again!", "Invalid duration input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check_valid4 = 2;
            }
            else
            {
                check_valid4 = 0;
            }
        }

        /// <summary>
        /// Call all other validators
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public int check_valid_all(object sender, EventArgs e)
        {
            /* Call other validators */
            txtName_Validating(sender, e);
            txtEpi_Validating(sender, e);
            txtDes_Validating(sender, e);
            txtDura_Validating(sender, e);
            txtTrailer_Validating(sender, e);

            // calculate and check
            check_valid = check_valid1 + check_valid2 + check_valid3 + check_valid4;
            return check_valid;
        }

        /// <summary>
        /// Validate inputs and add new anime to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            check_valid_all(sender, e); // validate all inputs

            // only add if validation succeeds
            if (check_valid != 0)
            {
                return;
            }
            else
            {
                try
                {
                    anime obj = new anime(); // create new anime object to add to database

                    /* Assign details for new anime before adding */
                    obj.AccountID = Convert.ToInt32(this.adminId); // admin Id who adds the anime
                    obj.created_at = txtCurrentDate.Value;
                    obj.deleted_at = null;
                    obj.description = txtDes.Text;
                    obj.duration = txtDura.Text;
                    obj.episodes = txtEpi.Text;
                    obj.name = txtName.Text;
                    obj.poster = txtPos.Text;
                    obj.rating = cbbRating.GetItemText(cbbRating.SelectedItem);

                    // check if season is null (no info)
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

                    // add to database and save changes
                    db.animes.Add(obj);
                    db.SaveChanges();

                    // update binding source data
                    animeBindingSource.DataSource = db.animes.Local.ToBindingList().Where(a => a.deleted_at == null); // load animes to data source (that are not deleted)

                    // message indicates successful operation
                    MessageBox.Show("You have successfully added the anime \"" + txtName.Text + "\"!", "Add Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot add the anime! Please try again!", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Loads poster to picture box when user click on cells in data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if anime has any posters
            if (txtPos.Text == "")
            {
                pbPoster.Image = null;
            }
            else
            {
                try
                {
                    // update anime poster to picture box
                    pbPoster.Image = Image.FromFile(@"../../../FDMSWEB/Content/Images/Posters/" + Path.GetFileName(txtPos.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't not find the selected anime poster", "Loading Poster Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Find animes having find value in name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            // if nothing is inputted, all animes are shown
            if (string.IsNullOrEmpty(txtFind.Text))
            {
                this.animeBindingSource.DataSource = db.animes.Local.ToBindingList().Where(a => a.deleted_at == null); // load animes to data source (that are not deleted)
            }
            else
            {
                // load filtered data to binding source
                IEnumerable<anime> filteredData = db.animes.Local.ToBindingList()
                    .Where(x => x.name.Contains(txtFind.Text));
                animeBindingSource.DataSource = filteredData.Count() > 0 ?
                    filteredData : filteredData.ToArray();
            }
        }

        /// <summary>
        /// Open file chooser for users to choose poster to add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoose_Click_1(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "Images|*.jpg;*.jpeg;*.png";
            open.InitialDirectory = @"C:\";
            open.Title = "Please select an image to add or update";

            // if user clicks OK, load the image
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtPos.Text = Path.GetFileName(open.FileName);
                try
                {
                    File.Copy(open.FileName, @"../../../FDMSWEB/Content/Images/Posters/" + Path.GetFileName(open.FileName), true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Don't change picture from the source file!", "This admin is trying to change picture in source", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Delete an anime in database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // check if user has selected a row
            if (animeGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select an anime to delete!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int n = animeGridView.CurrentRow.Index; // get current row index

            try
            {
                int deletedId = Convert.ToInt32(animeGridView.Rows[n].Cells[0].Value); // get anime ID
                anime deletedAnime = db.animes.FirstOrDefault(a => a.AnimeID == deletedId); // get anime object using ID
                deletedAnime.deleted_at = dateTimeDelete; // update deleted_at date

                /* Updates to database */
                db.animes.AddOrUpdate(deletedAnime);
                db.SaveChanges();

                /* Indicates successful deletion */
                MessageBox.Show("The selected anime has been successfully deleted!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /* Empty the input fields */
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
            catch (Exception ex)
            {
                MessageBox.Show("Cannot delete the selected anime! Please try again!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Update an anime in database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            check_valid_all(sender, e); // validate all input fields

            // only update after all fields are validated
            if (check_valid != 0)
            {
                MessageBox.Show("There is something wrong in input! Please check again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // check if user has selected a row
                if (animeGridView.CurrentRow == null)
                {
                    MessageBox.Show("Please select an anime to update!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    db.SaveChanges(); // save changes to database
                    MessageBox.Show("The selected anime has been successfully updated!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot update the selected anime! Please try again!", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Undo the changes made
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Triggers when form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }
    }

    /// <summary>
    /// Class for custom data grid view
    /// </summary>
    class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            DoubleBuffered = true; // enable double buffered
        }
    }
}
