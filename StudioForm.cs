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
    public partial class StudioForm : Form
    {
        animeEntities db;
        public StudioForm()
        {
            InitializeComponent();
            DateTimePicker dt = new DateTimePicker();
            dateTimeAdd.Value = DateTime.Now;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check if name is null or empty 
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name field cannot be empty!", "Required !");
                return;
            }
            // create new object of season
            studio studios = new studio();

            // set value for object by value from text boxes
            studios.name = txtName.Text;
            studios.created_at = DateTime.Today;

            // add new new data to datasource
            db.studios.Add(studios);

            // save changes to database
            db.SaveChanges();
            MessageBox.Show("Insert successful", "Sucessful");

            studioBindingSource1.DataSource = db.studios.ToList(); // update datasource
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // check if studio is null or empty
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name field cannot be empty!", "Required!");
                return;
            }

            int id = Convert.ToInt32(textBox1.Text); // cast value to int and set to ID
            studio studios = new studio(); // create new object of season
            studios = db.studios.FirstOrDefault(ss => ss.StudioID == id); // get the object season to update

            /* Update season properties */
            studios.StudioID = id;
            studios.name = txtName.Text;
            studios.created_at = Convert.ToDateTime(txtCreated_at.Text);

            // save changes to database
            db.SaveChanges();
            MessageBox.Show("Update successful", "Sucessful");

            studioBindingSource1.DataSource = db.studios.ToList(); // update datasource
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            db = new animeEntities();
            db.studios.Load();
            studioBindingSource1.DataSource = db.studios.Local;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            db = new animeEntities();
            db.studios.Load();
            studioBindingSource1.DataSource = db.studios.Local;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text); // cast value to int and set to ID

            // create new object of season
            studio studios = new studio();
            studios = db.studios.FirstOrDefault(ss => ss.StudioID == id);

            // find obj in datasource exist or not
            if (studios != null)
            {
                // call function remove
                db.studios.Remove(studios);
            }
            else
            {
                MessageBox.Show("Please enter another ID that doesn't exist in database!", "Not found ID!");
                return;
            }
            MessageBox.Show("Delete successful!", "Successful!");

            // save changes to database
            db.SaveChanges();

            studioBindingSource1.DataSource = db.studios.ToList(); // update datasource
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Bind data from cell to text boxes manually */
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCreated_at.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
