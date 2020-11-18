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
            public string releaseDate { get; set; }
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
                releaseDate = p.releaseDate.ToString(),
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
    }
}
