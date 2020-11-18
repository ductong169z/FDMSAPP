using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSAPP
{
    public partial class FormReportUser : Form
    {
        animeEntities db; // database context

        /// <summary>
        /// Constructor
        /// </summary>
        public FormReportUser()
        {
            InitializeComponent();

            this.CenterToScreen(); // center the form
        }
        
        /// <summary>
        /// Account details
        /// </summary>
        public class UserRemake
        {
            public int AccountID { get; set; }
            public int RoleID { get; set; }
            public string username { get; set; }
            public string fullname { get; set; }
            public string avatar { get; set; }
            public string email { get; set; }
            public int gender { get; set; }
        }

        /// <summary>
        /// Load data to report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            db = new animeEntities();
            db.accounts.Load();
            CrystalReportUser user = new CrystalReportUser();
            user.SetDataSource(db.accounts.Select(p => new UserRemake
            {
                AccountID = p.AccountID,
                RoleID = p.RoleID,
                username = p.username,
                fullname = p.fullname,
                avatar = p.avatar,
                email = p.email,
                gender = p.gender ?? 0
            }).ToList());
            crystalReportViewer1.ReportSource = user;
        }

        /// <summary>
        /// Find accounts with account id in report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            db = new animeEntities();
            string id = textBox1.Text.ToString();
            string tipe = textBox1.Text.ToString();
         
            db.accounts.Load();
            CrystalReportUser user = new CrystalReportUser();
            user.SetDataSource(db.accounts.Select(p => new UserRemake
            {
                AccountID = p.AccountID,
                RoleID = p.RoleID,
                username = p.username,
                fullname = p.fullname,
                avatar = p.avatar,
                email = p.email,
                gender = p.gender ?? 0
            }).ToList());
            crystalReportViewer1.ReportSource = user;
            crystalReportViewer1.SelectionFormula = "{account.AccountID} =" +id;
            crystalReportViewer1.SelectionFormula = "{account.RoleID} =" + tipe ;
            crystalReportViewer1.RefreshReport();
        }
        public void LoadGridData()
        {
            db = new animeEntities();
            db.accounts.Load();
            CrystalReportUser user = new CrystalReportUser();
            user.SetDataSource(db.accounts.Select(p => new UserRemake
            {
                AccountID = p.AccountID,
                RoleID = p.RoleID,
                username = p.username,
                fullname = p.fullname,
                avatar = p.avatar,
                email = p.email,
                gender = p.gender ?? 0
            }).ToList());
            crystalReportViewer1.ReportSource = user;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LoadGridData();
        }
    }
}
