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
    /// <summary>
    /// Class for Season Form
    /// </summary>
    public partial class SeasonForm : Form
    {
        animeEntities db; // database context to use

        /// <summary>
        /// Constructor
        /// </summary>
        public SeasonForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load data from cell to text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Bind data from cell to text boxes manually */
            txtID.Text = seasonGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = seasonGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCreated_at.Text = seasonGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        /// <summary>
        /// Load data to form when form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeasonForm_Load(object sender, EventArgs e)
        {
            db = new animeEntities(); // instantiate new database context
            db.seasons.Load(); // load seasons to form
            seasonBindingSource.DataSource = db.seasons.ToList(); // update binding source data source
        }

        /// <summary>
        /// Add new season to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check if name is null or empty 
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name field cannot be empty!", "Required !");
                return;
            }
            // create new object of season
            season seasons = new season();

            // set value for object by value from text boxes
            seasons.name = txtName.Text;
            seasons.created_at = DateTime.Today;

            // add new new data to datasource
            db.seasons.Add(seasons);

            // save changes to database
            db.SaveChanges();
            MessageBox.Show("Insert successful", "Sucessful");

            seasonGridView.DataSource = db.seasons.ToList(); // update datasource
        }

        /// <summary>
        /// Update a season
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check if season is null or empty
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name field cannot be empty!", "Required!");
                return;
            }

            int id = Convert.ToInt32(txtID.Text); // cast value to int and set to ID
            season seasons = new season(); // create new object of season
            seasons = db.seasons.FirstOrDefault(ss => ss.SeasonID == id); // get the object season to update
            
            /* Update season properties */
            seasons.SeasonID = id;
            seasons.name = txtName.Text;
            seasons.created_at = Convert.ToDateTime(txtCreated_at.Text);

            // save changes to database
            db.SaveChanges();
            MessageBox.Show("Update successful", "Sucessful");

            seasonGridView.DataSource = db.seasons.ToList(); // update datasource
        }

        /// <summary>
        /// Delete a season
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text); // cast value to int and set to ID
            
            // create new object of season
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

            // save changes to database
            db.SaveChanges();

            seasonGridView.DataSource = db.seasons.ToList(); // update datasource
        }

        /// <summary>
        /// Clear all text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtName.Text = null;
            txtCreated_at.Text = null;
            btnAdd.Enabled = true;
        }

        /// <summary>
        /// Search for a season
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
