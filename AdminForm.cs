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
    public partial class AdminForm : Form
    {
        animeEntities db;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            db = new animeEntities();
            db.accounts.Load();
            accountBindingSource.DataSource = db.accounts.Local;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[8].Value == null && dataGridView1.Rows[i].Cells[1].Value?.ToString() == "1")
                {
                    dataGridView1.Rows[i].Visible = true;
                }
                else if (dataGridView1.Rows.Cast<DataGridViewRow>()
.Any(c => string.IsNullOrWhiteSpace(c.Cells[8].Value?.ToString())))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    dataGridView1.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
        }
    }
}
