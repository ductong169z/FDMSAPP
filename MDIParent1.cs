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
    public partial class MDIParent1 : Form
    {
        public MDIParent1(string id)
        {
            InitializeComponent();
            lblID.Text = id;
        }
        private void animeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            UserForm uf = new UserForm();
            uf.MdiParent = this;
            uf.Show();
        }

        private void adminFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.MdiParent = this;
            af.Show();
        }
    }
}
