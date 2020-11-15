using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDMSAPP
{
    public partial class DashBoard : Form
    {
        animeEntities db;
        public DashBoard()
        {
            InitializeComponent();
            chart1.Titles.Add("Types");
            chart1.Series["s1"].IsValueShownAsLabel = true;
            chart1.Series["s1"].Points.AddXY("TV", 137);
            chart1.Series["s1"].Points.AddXY("ONA", 7);
            chart1.Series["s1"].Points.AddXY("Music", 1);
            chart1.Series["s1"].Points.AddXY("Special", 4);
            chart1.Series["s1"].Points.AddXY("OVA", 2);
            chart1.Series["s1"].Points.AddXY("Movie", 24);
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            db = new animeEntities();
            //count user
            var countuser = db.accounts.Count(t => t.RoleID == 2 && t.deleted_at == null);
            lblUser.Text = countuser.ToString();
            //count admin
            var countadmin = db.accounts.Count(t => t.RoleID == 1 && t.deleted_at == null);
            lblAdmin.Text = countadmin.ToString();
            //count genre
            Int32 countgenre = db.genres.Count();
            lblGenre.Text = countgenre.ToString();
            //count season
            Int32 countseason = db.seasons.Count();
            lblSeason.Text = countseason.ToString();
            //count studio
            Int32 countstudio = db.studios.Count();
            lblStudio.Text = countstudio.ToString();
            //count anime
            Int32 countanime = db.animes.Count();
            lblAnime.Text = countanime.ToString();
        }


        private void btnUser_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.ShowDialog();
        }

        private void btnAnime_Click(object sender, EventArgs e)
        {
            AnimeForm af = new AnimeForm();
            af.ShowDialog();
        }

        private void btnAdmin1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("じゃあまたね", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.whatsapp.com/");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }
    }
}
