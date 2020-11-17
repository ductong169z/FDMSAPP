using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSAPP
{
    public partial class SeasonForm : Form
    {
        animeEntities db;

        public SeasonForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCreated_at.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        DataTable dt = new DataTable("Season");
        private void SeasonForm_Load(object sender, EventArgs e)
        {

            db = new animeEntities();
            db.seasons.Load();
            seasonBindingSource.DataSource = db.seasons.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name field cannot be empty!", "Required !");
                return;
            }
            //create new object of season
            season seasons = new season();
            // set value for object by value from texeditor
            //cast value to int and set to ID
            seasons.name = txtName.Text;
            seasons.created_at = DateTime.Today;
            //add new new data to datasource
            db.seasons.Add(seasons);
            //save change action
            db.SaveChanges();
            MessageBox.Show("Insert successfull", "Sucessfull");
            dataGridView1.DataSource = db.seasons.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text)) 
                {
                MessageBox.Show("Name field cannot be empty!", "Required !");
                return;
            }
            int id = Convert.ToInt32(txtID.Text);
            season seasons = new season();
            seasons = db.seasons.FirstOrDefault(ss => ss.SeasonID == id);
            seasons.SeasonID = id;
            seasons.name = txtName.Text;
            seasons.created_at = Convert.ToDateTime(txtCreated_at.Text);
            db.SaveChanges();
            dataGridView1.DataSource = db.seasons.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            //create new object of season
            season seasons = new season();
            seasons = db.seasons.FirstOrDefault(ss => ss.SeasonID == id);
            // find obj in datasource exist or not
            if (seasons != null)
            {
                // call function remove
                db.seasons.Remove(seasons);
            }
            else
            {
                MessageBox.Show("Please enter another ID that doesn't exist in database!", "Not found ID!");
                return;

            }
            MessageBox.Show("Delete successfull!", "Successfull!");

            //save change action
            db.SaveChanges();
            dataGridView1.DataSource = db.seasons.ToList();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtName.Text = null;
            txtCreated_at.Text = null;
            btnAdd.Enabled = true;
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            if (!txtSearch.Text.Equals(""))
            {
                dataGridView1.DataSource = db.seasons.Where(x => x.name.Contains(txtSearch.Text)).ToList();
            }
            else
            {
                MessageBox.Show("Input in search name is null ! Please enter the name of season !!");
            }
            
            
        }

        private void bnt_searchdate_Click(object sender, EventArgs e)
        {
            DateTime dt = searchDate.Value;
            dataGridView1.DataSource = db.seasons.Where(t => DbFunctions.TruncateTime(t.created_at) >= dt);
            
        }
    }
}
