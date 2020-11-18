namespace FMSAPP
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.typeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSeason = new System.Windows.Forms.Button();
            this.btnStudio = new System.Windows.Forms.Button();
            this.btnGenre = new System.Windows.Forms.Button();
            this.btnAnime = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDashboard = new System.Windows.Forms.Label();
            this.lbAnime = new System.Windows.Forms.Label();
            this.lbTotalAnimes = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbTotalUsers = new System.Windows.Forms.Label();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.lbTotalAds = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbTotalGenres = new System.Windows.Forms.Label();
            this.lbSeason = new System.Windows.Forms.Label();
            this.lbTotalSeasons = new System.Windows.Forms.Label();
            this.lbStudio = new System.Windows.Forms.Label();
            this.lbTotalStudios = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUserReport = new System.Windows.Forms.Button();
            this.btnAnimeReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pbAnime = new System.Windows.Forms.PictureBox();
            this.pbSeasons = new System.Windows.Forms.PictureBox();
            this.pbStudios = new System.Windows.Forms.PictureBox();
            this.pbGenres = new System.Windows.Forms.PictureBox();
            this.pbAdmins = new System.Windows.Forms.PictureBox();
            this.pbUsers = new System.Windows.Forms.PictureBox();
            this.animeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeasons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.typeChart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(374, -59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 725);
            this.panel2.TabIndex = 3;
            // 
            // typeChart
            // 
            chartArea1.Name = "ChartArea1";
            this.typeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.typeChart.Legends.Add(legend1);
            this.typeChart.Location = new System.Drawing.Point(128, 0);
            this.typeChart.Name = "typeChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            series1.XValueMember = "type";
            series1.YValueMembers = "0";
            this.typeChart.Series.Add(series1);
            this.typeChart.Size = new System.Drawing.Size(501, 319);
            this.typeChart.TabIndex = 5;
            this.typeChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSeason);
            this.panel1.Controls.Add(this.btnStudio);
            this.panel1.Controls.Add(this.btnGenre);
            this.panel1.Controls.Add(this.btnAnime);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 666);
            this.panel1.TabIndex = 2;
            // 
            // btnSeason
            // 
            this.btnSeason.FlatAppearance.BorderSize = 0;
            this.btnSeason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeason.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSeason.ForeColor = System.Drawing.Color.White;
            this.btnSeason.Image = ((System.Drawing.Image)(resources.GetObject("btnSeason.Image")));
            this.btnSeason.Location = new System.Drawing.Point(0, 577);
            this.btnSeason.Name = "btnSeason";
            this.btnSeason.Size = new System.Drawing.Size(163, 89);
            this.btnSeason.TabIndex = 4;
            this.btnSeason.Text = "Season";
            this.btnSeason.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeason.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSeason.UseVisualStyleBackColor = true;
            this.btnSeason.Click += new System.EventHandler(this.btnSeason_Click);
            // 
            // btnStudio
            // 
            this.btnStudio.FlatAppearance.BorderSize = 0;
            this.btnStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudio.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStudio.ForeColor = System.Drawing.Color.White;
            this.btnStudio.Image = ((System.Drawing.Image)(resources.GetObject("btnStudio.Image")));
            this.btnStudio.Location = new System.Drawing.Point(0, 465);
            this.btnStudio.Name = "btnStudio";
            this.btnStudio.Size = new System.Drawing.Size(163, 106);
            this.btnStudio.TabIndex = 3;
            this.btnStudio.Text = "Studio";
            this.btnStudio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStudio.UseVisualStyleBackColor = true;
            this.btnStudio.Click += new System.EventHandler(this.btnStudio_Click);
            // 
            // btnGenre
            // 
            this.btnGenre.FlatAppearance.BorderSize = 0;
            this.btnGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenre.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGenre.ForeColor = System.Drawing.Color.White;
            this.btnGenre.Image = ((System.Drawing.Image)(resources.GetObject("btnGenre.Image")));
            this.btnGenre.Location = new System.Drawing.Point(0, 358);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(163, 101);
            this.btnGenre.TabIndex = 2;
            this.btnGenre.Text = "Genre";
            this.btnGenre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenre.UseVisualStyleBackColor = true;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // btnAnime
            // 
            this.btnAnime.FlatAppearance.BorderSize = 0;
            this.btnAnime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnime.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAnime.ForeColor = System.Drawing.Color.White;
            this.btnAnime.Image = ((System.Drawing.Image)(resources.GetObject("btnAnime.Image")));
            this.btnAnime.Location = new System.Drawing.Point(0, 252);
            this.btnAnime.Name = "btnAnime";
            this.btnAnime.Size = new System.Drawing.Size(163, 100);
            this.btnAnime.TabIndex = 1;
            this.btnAnime.Text = "Anime";
            this.btnAnime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnime.UseVisualStyleBackColor = true;
            this.btnAnime.Click += new System.EventHandler(this.btnAnime_Click);
            // 
            // btnUser
            // 
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUser.Location = new System.Drawing.Point(0, 167);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(163, 90);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.Location = new System.Drawing.Point(0, 82);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(163, 79);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.lbDashboard);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 76);
            this.panel3.TabIndex = 0;
            // 
            // lbDashboard
            // 
            this.lbDashboard.AutoSize = true;
            this.lbDashboard.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDashboard.ForeColor = System.Drawing.Color.Black;
            this.lbDashboard.Location = new System.Drawing.Point(12, 9);
            this.lbDashboard.Name = "lbDashboard";
            this.lbDashboard.Size = new System.Drawing.Size(141, 56);
            this.lbDashboard.TabIndex = 0;
            this.lbDashboard.Text = "Admin\r\nDashboard\r\n";
            this.lbDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAnime
            // 
            this.lbAnime.AutoSize = true;
            this.lbAnime.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbAnime.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbAnime.Location = new System.Drawing.Point(126, 30);
            this.lbAnime.Name = "lbAnime";
            this.lbAnime.Size = new System.Drawing.Size(71, 25);
            this.lbAnime.TabIndex = 10;
            this.lbAnime.Text = "lorem";
            // 
            // lbTotalAnimes
            // 
            this.lbTotalAnimes.AutoSize = true;
            this.lbTotalAnimes.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTotalAnimes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTotalAnimes.Location = new System.Drawing.Point(7, 3);
            this.lbTotalAnimes.Name = "lbTotalAnimes";
            this.lbTotalAnimes.Size = new System.Drawing.Size(159, 25);
            this.lbTotalAnimes.TabIndex = 9;
            this.lbTotalAnimes.Text = "Total Animes:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbUser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbUser.Location = new System.Drawing.Point(121, 29);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(71, 25);
            this.lbUser.TabIndex = 12;
            this.lbUser.Text = "lorem";
            // 
            // lbTotalUsers
            // 
            this.lbTotalUsers.AutoSize = true;
            this.lbTotalUsers.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTotalUsers.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTotalUsers.Location = new System.Drawing.Point(8, 5);
            this.lbTotalUsers.Name = "lbTotalUsers";
            this.lbTotalUsers.Size = new System.Drawing.Size(145, 25);
            this.lbTotalUsers.TabIndex = 11;
            this.lbTotalUsers.Text = "Total Users:";
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbAdmin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbAdmin.Location = new System.Drawing.Point(135, 28);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(71, 25);
            this.lbAdmin.TabIndex = 14;
            this.lbAdmin.Text = "lorem";
            // 
            // lbTotalAds
            // 
            this.lbTotalAds.AutoSize = true;
            this.lbTotalAds.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTotalAds.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTotalAds.Location = new System.Drawing.Point(4, 4);
            this.lbTotalAds.Name = "lbTotalAds";
            this.lbTotalAds.Size = new System.Drawing.Size(159, 25);
            this.lbTotalAds.TabIndex = 13;
            this.lbTotalAds.Text = "Total Admins:";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbGenre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbGenre.Location = new System.Drawing.Point(126, 28);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(71, 25);
            this.lbGenre.TabIndex = 16;
            this.lbGenre.Text = "lorem";
            // 
            // lbTotalGenres
            // 
            this.lbTotalGenres.AutoSize = true;
            this.lbTotalGenres.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTotalGenres.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTotalGenres.Location = new System.Drawing.Point(5, 0);
            this.lbTotalGenres.Name = "lbTotalGenres";
            this.lbTotalGenres.Size = new System.Drawing.Size(159, 25);
            this.lbTotalGenres.TabIndex = 15;
            this.lbTotalGenres.Text = "Total Genres:";
            // 
            // lbSeason
            // 
            this.lbSeason.AutoSize = true;
            this.lbSeason.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbSeason.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbSeason.Location = new System.Drawing.Point(121, 28);
            this.lbSeason.Name = "lbSeason";
            this.lbSeason.Size = new System.Drawing.Size(71, 25);
            this.lbSeason.TabIndex = 18;
            this.lbSeason.Text = "lorem";
            // 
            // lbTotalSeasons
            // 
            this.lbTotalSeasons.AutoSize = true;
            this.lbTotalSeasons.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTotalSeasons.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTotalSeasons.Location = new System.Drawing.Point(3, 5);
            this.lbTotalSeasons.Name = "lbTotalSeasons";
            this.lbTotalSeasons.Size = new System.Drawing.Size(172, 25);
            this.lbTotalSeasons.TabIndex = 17;
            this.lbTotalSeasons.Text = "Total Seasons:";
            // 
            // lbStudio
            // 
            this.lbStudio.AutoSize = true;
            this.lbStudio.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbStudio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbStudio.Location = new System.Drawing.Point(135, 28);
            this.lbStudio.Name = "lbStudio";
            this.lbStudio.Size = new System.Drawing.Size(71, 25);
            this.lbStudio.TabIndex = 20;
            this.lbStudio.Text = "lorem";
            // 
            // lbTotalStudios
            // 
            this.lbTotalStudios.AutoSize = true;
            this.lbTotalStudios.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTotalStudios.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTotalStudios.Location = new System.Drawing.Point(3, 4);
            this.lbTotalStudios.Name = "lbTotalStudios";
            this.lbTotalStudios.Size = new System.Drawing.Size(162, 25);
            this.lbTotalStudios.TabIndex = 19;
            this.lbTotalStudios.Text = "Total Studios:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.btnUserReport);
            this.panel4.Controls.Add(this.btnAnimeReport);
            this.panel4.Controls.Add(this.btnLogout);
            this.panel4.Location = new System.Drawing.Point(172, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(733, 55);
            this.panel4.TabIndex = 21;
            // 
            // btnUserReport
            // 
            this.btnUserReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnUserReport.FlatAppearance.BorderSize = 0;
            this.btnUserReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserReport.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUserReport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUserReport.Image = ((System.Drawing.Image)(resources.GetObject("btnUserReport.Image")));
            this.btnUserReport.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnUserReport.Location = new System.Drawing.Point(38, 3);
            this.btnUserReport.Name = "btnUserReport";
            this.btnUserReport.Size = new System.Drawing.Size(202, 49);
            this.btnUserReport.TabIndex = 2;
            this.btnUserReport.Text = "User Report";
            this.btnUserReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUserReport.UseVisualStyleBackColor = true;
            this.btnUserReport.Click += new System.EventHandler(this.btnUserReport_Click);
            // 
            // btnAnimeReport
            // 
            this.btnAnimeReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnAnimeReport.FlatAppearance.BorderSize = 0;
            this.btnAnimeReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimeReport.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAnimeReport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnimeReport.Image = ((System.Drawing.Image)(resources.GetObject("btnAnimeReport.Image")));
            this.btnAnimeReport.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAnimeReport.Location = new System.Drawing.Point(283, 3);
            this.btnAnimeReport.Name = "btnAnimeReport";
            this.btnAnimeReport.Size = new System.Drawing.Size(222, 49);
            this.btnAnimeReport.TabIndex = 1;
            this.btnAnimeReport.Text = "Anime Report";
            this.btnAnimeReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnimeReport.UseVisualStyleBackColor = true;
            this.btnAnimeReport.Click += new System.EventHandler(this.btnAnimeReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLogout.Location = new System.Drawing.Point(543, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(178, 49);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lbTotalAnimes);
            this.panel5.Controls.Add(this.lbAnime);
            this.panel5.Location = new System.Drawing.Point(197, 111);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 55);
            this.panel5.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lbTotalUsers);
            this.panel6.Controls.Add(this.lbUser);
            this.panel6.Location = new System.Drawing.Point(431, 111);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(203, 55);
            this.panel6.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lbTotalAds);
            this.panel7.Controls.Add(this.lbAdmin);
            this.panel7.Location = new System.Drawing.Point(661, 111);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(216, 55);
            this.panel7.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.lbTotalStudios);
            this.panel8.Controls.Add(this.lbStudio);
            this.panel8.Location = new System.Drawing.Point(661, 195);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(216, 55);
            this.panel8.TabIndex = 23;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.lbTotalSeasons);
            this.panel9.Controls.Add(this.lbSeason);
            this.panel9.Location = new System.Drawing.Point(431, 195);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(203, 55);
            this.panel9.TabIndex = 23;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.lbTotalGenres);
            this.panel10.Controls.Add(this.lbGenre);
            this.panel10.Location = new System.Drawing.Point(197, 195);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(211, 55);
            this.panel10.TabIndex = 23;
            // 
            // pbAnime
            // 
            this.pbAnime.BackColor = System.Drawing.Color.White;
            this.pbAnime.Image = ((System.Drawing.Image)(resources.GetObject("pbAnime.Image")));
            this.pbAnime.Location = new System.Drawing.Point(356, 93);
            this.pbAnime.Name = "pbAnime";
            this.pbAnime.Size = new System.Drawing.Size(32, 32);
            this.pbAnime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAnime.TabIndex = 24;
            this.pbAnime.TabStop = false;
            // 
            // pbSeasons
            // 
            this.pbSeasons.BackColor = System.Drawing.Color.White;
            this.pbSeasons.Image = ((System.Drawing.Image)(resources.GetObject("pbSeasons.Image")));
            this.pbSeasons.Location = new System.Drawing.Point(443, 236);
            this.pbSeasons.Name = "pbSeasons";
            this.pbSeasons.Size = new System.Drawing.Size(32, 32);
            this.pbSeasons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSeasons.TabIndex = 19;
            this.pbSeasons.TabStop = false;
            // 
            // pbStudios
            // 
            this.pbStudios.BackColor = System.Drawing.Color.White;
            this.pbStudios.Image = ((System.Drawing.Image)(resources.GetObject("pbStudios.Image")));
            this.pbStudios.Location = new System.Drawing.Point(670, 236);
            this.pbStudios.Name = "pbStudios";
            this.pbStudios.Size = new System.Drawing.Size(32, 32);
            this.pbStudios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbStudios.TabIndex = 21;
            this.pbStudios.TabStop = false;
            // 
            // pbGenres
            // 
            this.pbGenres.BackColor = System.Drawing.Color.White;
            this.pbGenres.Image = ((System.Drawing.Image)(resources.GetObject("pbGenres.Image")));
            this.pbGenres.Location = new System.Drawing.Point(209, 236);
            this.pbGenres.Name = "pbGenres";
            this.pbGenres.Size = new System.Drawing.Size(32, 32);
            this.pbGenres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbGenres.TabIndex = 27;
            this.pbGenres.TabStop = false;
            // 
            // pbAdmins
            // 
            this.pbAdmins.BackColor = System.Drawing.Color.White;
            this.pbAdmins.Image = ((System.Drawing.Image)(resources.GetObject("pbAdmins.Image")));
            this.pbAdmins.Location = new System.Drawing.Point(829, 93);
            this.pbAdmins.Name = "pbAdmins";
            this.pbAdmins.Size = new System.Drawing.Size(32, 32);
            this.pbAdmins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAdmins.TabIndex = 26;
            this.pbAdmins.TabStop = false;
            // 
            // pbUsers
            // 
            this.pbUsers.BackColor = System.Drawing.Color.White;
            this.pbUsers.Image = ((System.Drawing.Image)(resources.GetObject("pbUsers.Image")));
            this.pbUsers.Location = new System.Drawing.Point(585, 93);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(32, 32);
            this.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUsers.TabIndex = 25;
            this.pbUsers.TabStop = false;
            // 
            // animeBindingSource
            // 
            this.animeBindingSource.DataSource = typeof(FMSAPP.anime);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(905, 666);
            this.Controls.Add(this.pbAnime);
            this.Controls.Add(this.pbSeasons);
            this.Controls.Add(this.pbStudios);
            this.Controls.Add(this.pbGenres);
            this.Controls.Add(this.pbAdmins);
            this.Controls.Add(this.pbUsers);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel8);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typeChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeasons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnime;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDashboard;
        private System.Windows.Forms.Label lbAnime;
        private System.Windows.Forms.Label lbTotalAnimes;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbTotalUsers;
        private System.Windows.Forms.Label lbAdmin;
        private System.Windows.Forms.Label lbTotalAds;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbTotalGenres;
        private System.Windows.Forms.Label lbSeason;
        private System.Windows.Forms.Label lbTotalSeasons;
        private System.Windows.Forms.Label lbStudio;
        private System.Windows.Forms.Label lbTotalStudios;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pbAnime;
        private System.Windows.Forms.PictureBox pbUsers;
        private System.Windows.Forms.PictureBox pbAdmins;
        private System.Windows.Forms.PictureBox pbGenres;
        private System.Windows.Forms.PictureBox pbSeasons;
        private System.Windows.Forms.PictureBox pbStudios;
        private System.Windows.Forms.DataVisualization.Charting.Chart typeChart;
        private System.Windows.Forms.BindingSource animeBindingSource;
        private System.Windows.Forms.Button btnSeason;
        private System.Windows.Forms.Button btnStudio;
        private System.Windows.Forms.Button btnGenre;
        private System.Windows.Forms.Button btnUserReport;
        private System.Windows.Forms.Button btnAnimeReport;
    }
}
