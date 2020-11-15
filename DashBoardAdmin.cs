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
    public partial class MDIParent1 : Form
    {
        animeEntities db;
        public MDIParent1(string id)
        {
            InitializeComponent();
            lblID.Text = id;
        }
        private void animeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            AnimeForm af = new AnimeForm();
            af.MdiParent = this;
            af.Dock = DockStyle.Fill;
            af.WindowState = FormWindowState.Maximized;
            af.Show();
        }
        private void MDIParent1_Load(object sender, EventArgs e)
        {
        }

    /**    private void userFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.MdiParent = this;
            uf.Show();
        } **/

        private void closeAllFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form form in this.MdiChildren)
            {
                if (!form.Focused)
                {
                    form.Visible = false;
                    form.Dispose();
                }
            }
        }

        private void userFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            UserForm uf = new UserForm();
            uf.MdiParent = this;
            uf.Show();
        }

        private void adminFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            AdminForm af = new AdminForm();
            af.MdiParent = this;
            af.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("じゃあまたね", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            AdminLoginForm adminLogin = new AdminLoginForm();
            adminLogin.Show();
        }

        private void showTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void totalUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db = new animeEntities();
            var countuser = db.accounts.Count(t => t.RoleID == 2);
            lblUser.Text = countuser.ToString();
            panelTotalUser.Show();
        }
        private void totalAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db = new animeEntities();
            var countadmin = db.accounts.Count(t => t.RoleID == 1);
            lblAdmin.Text = countadmin.ToString();
            panelTotalAdmin.Show();
        }
        private void totalGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db = new animeEntities();
            Int32 countgenre = db.genres.Count();
            lblGenre.Text = countgenre.ToString();
            panelTotalGenre.Show();
        }

        private void totalSeasonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db = new animeEntities();
            Int32 countseason = db.seasons.Count();
            lblSeason.Text = countseason.ToString();
            panelTotalSeason.Show();
        }

        private void totalStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db = new animeEntities();
            Int32 countstudio = db.studios.Count();
            lblStudio.Text = countstudio.ToString();
            panelTotalStudio.Show();
        }

        private void totalAnimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db = new animeEntities();
            Int32 countanime = db.animes.Count();
            lblAnime.Text = countanime.ToString();
            panelTotalAnime.Show();
        }
        //HideAll 
        public void HideAllPanel()
        {
            panelTotalUser.Hide();
            panelTotalAdmin.Hide();
            panelTotalGenre.Hide();
            panelTotalSeason.Hide();
            panelTotalStudio.Hide();
            panelTotalAnime.Hide();
        }
        private void hideAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanel();
        }

        private void MDIParent1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
