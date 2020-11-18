using MySql.Data.MySqlClient;
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
    public partial class FormReportAnime : Form
    {
        animeEntities db; // database context to use

        /// <summary>
        /// Constructor
        /// </summary>
        public FormReportAnime()
        {
            InitializeComponent();

            this.CenterToScreen(); // center the form
        }

        /// <summary>
        /// Anime details
        /// </summary>
        public class AnimeRemake
        {
            public int AnimeID { get; set; }
            public int AccountID { get; set; }
            public int SeasonID { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public DateTime releaseDate { get; set; }
            public string rating { get; set; }
            public string episodes { get; set; }
            public string status { get; set; }
            public string duration { get; set; }
            public string description { get; set; }
            public string poster { get; set; }
            public string trailer { get; set; }
        }

        /// <summary>
        /// Load data to report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            db = new animeEntities();
            db.animes.Load();
            CrystalReportAnime anime = new CrystalReportAnime();
            anime.SetDataSource(db.animes.Select(p => new AnimeRemake
            {
                AnimeID = p.AnimeID,
                AccountID = p.AccountID,
                SeasonID = p.SeasonID ?? -1,
                type = p.type,
                name = p.name,
                releaseDate = p.releaseDate??DateTime.MinValue,
                rating = p.rating,
                episodes = p.episodes,
                status = p.status,
                duration = p.duration,
                description = p.description,
                poster = p.poster,
                trailer = p.trailer
            }).ToList());
            crystalReportViewer1.ReportSource = anime;
        }

        /// <summary>
        /// Load data to report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            db = new animeEntities();
            string accountid = textBox1.Text.ToString();
            string animeid = textBox1.Text.ToString();
            string season = textBox1.Text.ToString();

            db.accounts.Load();
            CrystalReportAnime anime = new CrystalReportAnime();
            anime.SetDataSource(db.animes.Select(p => new AnimeRemake
            {
                AnimeID = p.AnimeID,
                AccountID = p.AccountID,
                SeasonID = p.SeasonID ?? -1,
                type = p.type,
                name = p.name,
                releaseDate = p.releaseDate??DateTime.MinValue,
                rating = p.rating,
                episodes = p.episodes,
                status = p.status,
                duration = p.duration,
                description = p.description,
                poster = p.poster,
                trailer = p.trailer
            }).ToList());
            crystalReportViewer1.ReportSource = anime;
            crystalReportViewer1.SelectionFormula = "{anime.AnimeID} =" + animeid;
            crystalReportViewer1.SelectionFormula = "{anime.SeasonID} =" + accountid;
            crystalReportViewer1.SelectionFormula = "{anime.SeasonID} =" + season;
            crystalReportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Load grid data
        /// </summary>
        public void LoadGridData()
        {
            db = new animeEntities();
            db.animes.Load();
            CrystalReportAnime anime = new CrystalReportAnime();
            anime.SetDataSource(db.animes.Select(p => new AnimeRemake
            {
                AnimeID = p.AnimeID,
                AccountID = p.AccountID,
                SeasonID = p.SeasonID ?? -1,
                type = p.type,
                name = p.name,
                releaseDate = p.releaseDate ??DateTime.MinValue,
                rating = p.rating,
                episodes = p.episodes,
                status = p.status,
                duration = p.duration,
                description = p.description,
                poster = p.poster,
                trailer = p.trailer
            }).ToList());
            crystalReportViewer1.ReportSource = anime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void FormReportAnime_Load(object sender, EventArgs e)
        {

        }

        private void FormReportAnime_Load_1(object sender, EventArgs e)
        {

        }
    }
}
