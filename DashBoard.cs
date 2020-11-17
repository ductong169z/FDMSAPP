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
    public partial class DashBoard : Form
    {
        animeEntities db;
        string adminId;
        public DashBoard(string adminId)
        {
            InitializeComponent();
            db = new animeEntities();
            typeChart.Titles.Add("Types");
            typeChart.Series["s1"].IsValueShownAsLabel = true;
            typeChart.Series["s1"].Points.AddXY("TV", db.animes.Count(x => x.type == "TV"));
            typeChart.Series["s1"].Points.AddXY("ONA", db.animes.Count(x => x.type == "ONA"));
            typeChart.Series["s1"].Points.AddXY("Music", db.animes.Count(x => x.type == "Music"));
            typeChart.Series["s1"].Points.AddXY("Special", db.animes.Count(x => x.type == "Special"));
            typeChart.Series["s1"].Points.AddXY("OVA", db.animes.Count(x => x.type == "OVA"));
            typeChart.Series["s1"].Points.AddXY("Movie", db.animes.Count(x => x.type == "Movie"));
            this.adminId = adminId;
            this.CenterToScreen();
        }

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
            Int32 countanime = db.animes.Count();
            lbAnime.Text = countanime.ToString();
        }


        private void btnUser_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.ShowDialog();
        }

        private void btnAnime_Click(object sender, EventArgs e)
        {
            AnimeForm af = new AnimeForm(adminId);
            af.ShowDialog();
        }

        private void btnAdmin1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out!", "Logout Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            AdminLoginForm adminLogin = new AdminLoginForm();
            adminLogin.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSeason_Click(object sender, EventArgs e)
        {
            SeasonForm sf = new SeasonForm();
            sf.Show();
        }
    }
}
