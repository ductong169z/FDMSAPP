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
    /// <summary>
    /// Dashboard Form
    /// </summary>
    public partial class DashBoard : Form
    {
        animeEntities db; // database context to use
        string adminId; // logged in admin id

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="adminId"></param>
        public DashBoard(string adminId)
        {
            InitializeComponent();
            db = new animeEntities(); // instantiate new database context

            /* Set title and data for chart */
            typeChart.Titles.Add("Anime Types");
            typeChart.Series["s1"].IsValueShownAsLabel = true;
            typeChart.Series["s1"].Points.AddXY("TV", db.animes.Count(x => x.type == "TV"));
            typeChart.Series["s1"].Points.AddXY("ONA", db.animes.Count(x => x.type == "ONA"));
            typeChart.Series["s1"].Points.AddXY("Music", db.animes.Count(x => x.type == "Music"));
            typeChart.Series["s1"].Points.AddXY("Special", db.animes.Count(x => x.type == "Special"));
            typeChart.Series["s1"].Points.AddXY("OVA", db.animes.Count(x => x.type == "OVA"));
            typeChart.Series["s1"].Points.AddXY("Movie", db.animes.Count(x => x.type == "Movie"));
            this.adminId = adminId; // set admin id to pass to other forms
            this.CenterToScreen(); // center the form
        }

        /// <summary>
        /// Get data from data base upon loading dashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DashBoard_Load(object sender, EventArgs e)
        {
            //count user
            var countuser = db.accounts.Count(t => t.RoleID == 2 && t.deleted_at == null);
            lbUser.Text = countuser.ToString();
            
            //count admin
            var countadmin = db.accounts.Count(t => t.RoleID == 1 && t.deleted_at == null);
            lbAdmin.Text = countadmin.ToString();
            
            //count genre
            Int32 countgenre = db.genres.Count();
            lbGenre.Text = countgenre.ToString();
            
            //count season
            Int32 countseason = db.seasons.Count();
            lbSeason.Text = countseason.ToString();
            
            //count studio
            Int32 countstudio = db.studios.Count();
            lbStudio.Text = countstudio.ToString();
            
            //count anime
            Int32 countanime = db.animes.Count(t => t.deleted_at == null);
            lbAnime.Text = countanime.ToString();
        }

        /// <summary>
        /// Open User Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUser_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.ShowDialog();
        }

        /// <summary>
        /// Open Anime Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnime_Click(object sender, EventArgs e)
        {
            AnimeForm af = new AnimeForm(adminId);
            af.ShowDialog();
        }

        /// <summary>
        /// Log Out button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out!", "Logout Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            AdminLoginForm adminLogin = new AdminLoginForm();
            adminLogin.Show();
        }

        /// <summary>
        /// Open Admin Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.ShowDialog();
        }

        /// <summary>
        /// Open Season Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeason_Click(object sender, EventArgs e)
        {
            SeasonForm sf = new SeasonForm();
            sf.Show();
        }

        /// <summary>
        /// Open Genre Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenre_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Open Studio Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStudio_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Open User Report Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserReport_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Open Anime Report Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnimeReport_Click(object sender, EventArgs e)
        {

        }
    }
}
