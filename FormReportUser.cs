﻿using System;
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
        animeEntities db;
        public FormReportUser()
        {
            InitializeComponent();
        }
        //Viewmodel
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

        private void FormReportUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new animeEntities();
            string id = textBox1.Text.ToString();
            //"Select * from  account where AccountID = `" + id + "`"
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
            crystalReportViewer1.RefreshReport();
        }
    }
}