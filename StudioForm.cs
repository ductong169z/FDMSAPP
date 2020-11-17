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
        int check_valid1, check_valid;
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
            check_valid_all();
            if (check_valid != 0)
            {
                MessageBox.Show("Have something wrong in input! Plz check again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                studioBindingSource.AddNew();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
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
            studioBindingSource1.RemoveCurrent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Name is empty");
                check_valid1 = 1;
            }
            else
            {
                check_valid1 = 0;
            }
        }

        public int check_valid_all()
        {
            check_valid = check_valid1;
            return check_valid;
        }
    }
}
