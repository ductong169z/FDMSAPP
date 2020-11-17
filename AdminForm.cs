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
        animeEntities db; // database context to use

        /// <summary>
        /// Constructor
        /// </summary>
        public AdminForm()
        {
            InitializeComponent();

            this.CenterToScreen(); // center the form
        }

        /// <summary>
        /// Triggers when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminForm_Load(object sender, EventArgs e)
        {
            db = new animeEntities(); // instantiate new database context
            db.accounts.Load(); // load from database
            accountBindingSource.DataSource = db.accounts.Local.ToBindingList().Where(a => a.deleted_at == null && a.RoleID == 1); // load all admins that are not deleted
        }

        /// <summary>
        /// Format all numeric gender values to corresponding strings to display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adminGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // check if the column is gender
            if (this.adminGridView.Columns[e.ColumnIndex].Index == 6)
            {
                if (e.Value.ToString().Equals("1"))
                {
                    e.Value = "Male";
                }
                else if (e.Value.ToString().Equals("2"))
                {
                    e.Value = "Female";
                }
                else
                {
                    e.Value = "Other";
                }
            }
        }
    }
}
