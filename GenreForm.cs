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
    /// Class for Genre Form
    /// </summary>
    public partial class GenreForm : Form
    {
        animeEntities db; // database context to use

        /// <summary>
        /// Constructor
        /// </summary>
        public GenreForm()
        {
            InitializeComponent();

            dateTimeAdd.Value = DateTime.Now; // set current date
            dateTimeAdd.Enabled = false; // disable editing
        }

        /// <summary>
        /// Update a genre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // check if genre is null or empty
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name field cannot be empty!", "Required!");
                return;
            }

            int id = Convert.ToInt32(textBox1.Text); // cast value to int and set to ID
            genre genres = new genre(); // create new object of season
            genres = db.genres.FirstOrDefault(ss => ss.GenreID == id); // get the object season to update

            /* Update season properties */
            genres.GenreID = id;
            genres.name = txtName.Text;
            genres.created_at = Convert.ToDateTime(txtCreated_at.Text);

            // save changes to database
            db.SaveChanges();
            MessageBox.Show("Update successful", "Sucessful");

            genreBindingSource2.DataSource = db.genres.ToList(); // update datasource
        }

        /// <summary>
        /// Remove a genre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text); // cast value to int and set to ID

            // create new object of season
            genre genres = new genre();
            genres = db.genres.FirstOrDefault(ss => ss.GenreID == id);

            // find obj in datasource exist or not
            if (genres != null)
            {
                // call function remove
                db.genres.Remove(genres);
            }
            else
            {
                MessageBox.Show("Please enter another ID that doesn't exist in database!", "Not found ID!");
                return;
            }
            MessageBox.Show("Delete successful!", "Successful!");

            // save changes to database
            db.SaveChanges();

            genreBindingSource2.DataSource = db.genres.ToList(); // update datasource
        }

        /// <summary>
        /// Add a genre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // check if name is null or empty 
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name field cannot be empty!", "Required !");
                return;
            }
            // create new object of genre
            genre genres = new genre();

            // set value for object by value from text boxes
            genres.name = txtName.Text;
            genres.created_at = DateTime.Today;

            // add new new data to datasource
            db.genres.Add(genres);

            // save changes to database
            db.SaveChanges();
            MessageBox.Show("Insert successful", "Sucessful");

            genreBindingSource2.DataSource = db.genres.ToList(); // update datasource
        }

        /// <summary>
        /// Load data to form on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new animeEntities(); // instantiate new instance
            db.genres.Load(); // load data from database
            genreBindingSource2.DataSource = db.genres.Local; // set datasource
            
        }

        /// <summary>
        /// Bind data to text boxes on cell click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Bind data from cell to text boxes manually */
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCreated_at.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
