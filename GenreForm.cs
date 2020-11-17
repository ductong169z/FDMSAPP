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
    public partial class GenreForm : Form
    {
        animeEntities db;
        int check_valid1, check_valid2, check_valid3, check_valid4, check_valid;

        public GenreForm()
        {
            InitializeComponent();
            DateTimePicker dt = new DateTimePicker();
            dateTimeAdd.Value = DateTime.Now;

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            genreBindingSource2.RemoveCurrent();
        }

        private void dateTimeAdd_ValueChanged(object sender, EventArgs e)
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
                genreBindingSource2.AddNew();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new animeEntities();
            db.genres.Load();
            genreBindingSource2.DataSource = db.genres.Local;
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
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
            check_valid = check_valid1 + check_valid2 + check_valid3 + check_valid4;
            return check_valid;
        }
    }
}
