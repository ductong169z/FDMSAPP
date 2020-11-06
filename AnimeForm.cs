﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FMSAPP
{
    public partial class AnimeForm : Form
    {

        animeEntities db;
        int check_valid1, check_valid2, check_valid3, check_valid4, check_valid;
        public AnimeForm()
        {
            InitializeComponent();
            DateTimePicker dt = new DateTimePicker();
            dateTimeAdd.Value = DateTime.Now;
            dateTimeDelete.Value = DateTime.Now;
            dateTimeUpdate.Value = DateTime.Now;
        }
        // Regex contstraints
        static Regex LINK_REGEX = new Regex(@"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_]*)?$");
        static Regex DURATION_REGEX = new Regex(@"^\d{1,2}\s((min|sec|hour){1})\s((per){1})\s((ep){1})?$");
        private void AnimeForm_Load(object sender, EventArgs e)
        {
            db = new animeEntities();
            db.animes.Load();
            animeBindingSource.DataSource = db.animes.Local;
            var season = db.seasons;
            cbbSeason.DataSource = season.ToList();
            cbbSeason.DisplayMember = "SeasonID";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[14].Value == null)
                /* if (dataGridView1.Rows.Cast<DataGridViewRow>()
      .Any(c => string.IsNullOrWhiteSpace(c.Cells[13].Value?.ToString())))*/
                {
                    dataGridView1.Rows[i].Visible = true;
                }
                else if (dataGridView1.Rows.Cast<DataGridViewRow>()
     .Any(c => string.IsNullOrWhiteSpace(c.Cells[14].Value?.ToString())))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    dataGridView1.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
            /*            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[13].Value.ToString() != null)
            if (dataGridView1.Rows.Cast<DataGridViewRow>().Any(c => c.Cells[13].Value.ToString() != ""))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    dataGridView1.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }*/
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
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

        private void txtEpi_Validating(object sender, CancelEventArgs e)
        {
            if (txtEpi.Text.Length >= 5)
            {
                MessageBox.Show("Episode is too big(Not longger than 99999");
                check_valid2 = 1;
            }
            else
            {
                check_valid2 = 0;
            }
        }

        private void txtDes_Validating(object sender, CancelEventArgs e)
        {
            if (txtDes.Text == string.Empty)
            {
                MessageBox.Show("Description is empty");
                check_valid3 = 1;
            }
            else
            {
                check_valid3 = 0;
            }
        }
        public int check_valid_all()
        {
            check_valid = check_valid1 + check_valid2 + check_valid3 + check_valid4;
            return check_valid;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            check_valid_all();
            if (check_valid != 0)
            {
                MessageBox.Show("Have something wrong in input! Plz check again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int n = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows[n].Cells[13].Value = dateTimeAdd.Value.ToString();
                animeBindingSource.AddNew();
       //         txtIDAdmin.Text = ((Form)this.MdiParent).Controls["lblID"].Text;
            }
        }

        private void txtTrailer_Validating(object sender, CancelEventArgs e)
        {
            if (!LINK_REGEX.IsMatch(txtTrailer.Text))
            {
                // Incorrect password format
                MessageBox.Show("The true URL must begin with https://");
                check_valid4 = 1;
            }
            else
            {
                check_valid4 = 0;
            }
        }

        private void txtDura_Validating(object sender, CancelEventArgs e)
        {
            if (!DURATION_REGEX.IsMatch(txtDura.Text))
            {
                // Incorrect password format
                MessageBox.Show("The duration must begin with number . Ex:01 sec|min|hour per ep");
                check_valid4 = 2;
            }
            else
            {
                check_valid4 = 0;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[n].Cells[14].Value = dateTimeDelete.Value.ToString();
            CurrencyManager currencyManager1 = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            currencyManager1.SuspendBinding();
            dataGridView1.Rows[n].Visible = false;
            currencyManager1.ResumeBinding();
            db.SaveChanges();
            MessageBox.Show("Your data has been successfully delete(or you really think that is)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            check_valid_all();
            if (check_valid != 0)
            {
                MessageBox.Show("Have something wrong in input! Plz check again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int n = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows[n].Cells[15].Value = dateTimeUpdate.Value.ToString();
                db.SaveChanges();
                MessageBox.Show("Your data has been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var changed = db.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();
            foreach (var obj in changed)
            {
                switch (obj.State)
                {
                    case EntityState.Modified:
                        obj.CurrentValues.SetValues(obj.OriginalValues);
                        obj.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        obj.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        obj.State = EntityState.Unchanged;
                        break;

                }
            }
            animeBindingSource.ResetBindings(false);
        }

        private void AnimeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }
    }
}