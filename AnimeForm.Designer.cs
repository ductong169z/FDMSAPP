namespace FMSAPP
{
    partial class AnimeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimeForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.animeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.episodesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trailerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEpi = new System.Windows.Forms.TextBox();
            this.lbEp = new System.Windows.Forms.Label();
            this.txtDura = new System.Windows.Forms.TextBox();
            this.lbDu = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lbDes = new System.Windows.Forms.Label();
            this.txtTrailer = new System.Windows.Forms.TextBox();
            this.lbTrailer = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbSea = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbRa = new System.Windows.Forms.Label();
            this.lbSta = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.cbbRating = new System.Windows.Forms.ComboBox();
            this.cbbSeason = new System.Windows.Forms.ComboBox();
            this.seasonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbPos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimeAdd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDelete = new System.Windows.Forms.DateTimePicker();
            this.dateTimeUpdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDAdmin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animeIDDataGridViewTextBoxColumn,
            this.accountIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.episodesDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.trailerDataGridViewTextBoxColumn,
            this.seasonIDDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.posterDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.deletedatDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.animeBindingSource;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // animeIDDataGridViewTextBoxColumn
            // 
            this.animeIDDataGridViewTextBoxColumn.DataPropertyName = "AnimeID";
            resources.ApplyResources(this.animeIDDataGridViewTextBoxColumn, "animeIDDataGridViewTextBoxColumn");
            this.animeIDDataGridViewTextBoxColumn.Name = "animeIDDataGridViewTextBoxColumn";
            this.animeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            resources.ApplyResources(this.accountIDDataGridViewTextBoxColumn, "accountIDDataGridViewTextBoxColumn");
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // episodesDataGridViewTextBoxColumn
            // 
            this.episodesDataGridViewTextBoxColumn.DataPropertyName = "episodes";
            resources.ApplyResources(this.episodesDataGridViewTextBoxColumn, "episodesDataGridViewTextBoxColumn");
            this.episodesDataGridViewTextBoxColumn.Name = "episodesDataGridViewTextBoxColumn";
            this.episodesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            resources.ApplyResources(this.durationDataGridViewTextBoxColumn, "durationDataGridViewTextBoxColumn");
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            resources.ApplyResources(this.descriptionDataGridViewTextBoxColumn, "descriptionDataGridViewTextBoxColumn");
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trailerDataGridViewTextBoxColumn
            // 
            this.trailerDataGridViewTextBoxColumn.DataPropertyName = "trailer";
            resources.ApplyResources(this.trailerDataGridViewTextBoxColumn, "trailerDataGridViewTextBoxColumn");
            this.trailerDataGridViewTextBoxColumn.Name = "trailerDataGridViewTextBoxColumn";
            this.trailerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seasonIDDataGridViewTextBoxColumn
            // 
            this.seasonIDDataGridViewTextBoxColumn.DataPropertyName = "SeasonID";
            resources.ApplyResources(this.seasonIDDataGridViewTextBoxColumn, "seasonIDDataGridViewTextBoxColumn");
            this.seasonIDDataGridViewTextBoxColumn.Name = "seasonIDDataGridViewTextBoxColumn";
            this.seasonIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            resources.ApplyResources(this.typeDataGridViewTextBoxColumn, "typeDataGridViewTextBoxColumn");
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            resources.ApplyResources(this.ratingDataGridViewTextBoxColumn, "ratingDataGridViewTextBoxColumn");
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            resources.ApplyResources(this.statusDataGridViewTextBoxColumn, "statusDataGridViewTextBoxColumn");
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // posterDataGridViewTextBoxColumn
            // 
            this.posterDataGridViewTextBoxColumn.DataPropertyName = "poster";
            resources.ApplyResources(this.posterDataGridViewTextBoxColumn, "posterDataGridViewTextBoxColumn");
            this.posterDataGridViewTextBoxColumn.Name = "posterDataGridViewTextBoxColumn";
            this.posterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "releaseDate";
            resources.ApplyResources(this.releaseDateDataGridViewTextBoxColumn, "releaseDateDataGridViewTextBoxColumn");
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            resources.ApplyResources(this.createdatDataGridViewTextBoxColumn, "createdatDataGridViewTextBoxColumn");
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deletedatDataGridViewTextBoxColumn
            // 
            this.deletedatDataGridViewTextBoxColumn.DataPropertyName = "deleted_at";
            resources.ApplyResources(this.deletedatDataGridViewTextBoxColumn, "deletedatDataGridViewTextBoxColumn");
            this.deletedatDataGridViewTextBoxColumn.Name = "deletedatDataGridViewTextBoxColumn";
            this.deletedatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            resources.ApplyResources(this.updatedatDataGridViewTextBoxColumn, "updatedatDataGridViewTextBoxColumn");
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            this.updatedatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animeBindingSource
            // 
            this.animeBindingSource.DataSource = typeof(FMSAPP.anime);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BackColor = System.Drawing.Color.Plum;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.ForeColor = System.Drawing.Color.DeepPink;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeBindingSource, "name", true));
            this.txtName.Name = "txtName";
            // 
            // txtEpi
            // 
            resources.ApplyResources(this.txtEpi, "txtEpi");
            this.txtEpi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeBindingSource, "episodes", true));
            this.txtEpi.Name = "txtEpi";
            // 
            // lbEp
            // 
            resources.ApplyResources(this.lbEp, "lbEp");
            this.lbEp.Name = "lbEp";
            // 
            // txtDura
            // 
            resources.ApplyResources(this.txtDura, "txtDura");
            this.txtDura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeBindingSource, "duration", true));
            this.txtDura.Name = "txtDura";
            this.txtDura.Validating += new System.ComponentModel.CancelEventHandler(this.txtDura_Validating);
            // 
            // lbDu
            // 
            resources.ApplyResources(this.lbDu, "lbDu");
            this.lbDu.Name = "lbDu";
            // 
            // txtDes
            // 
            resources.ApplyResources(this.txtDes, "txtDes");
            this.txtDes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeBindingSource, "description", true));
            this.txtDes.Name = "txtDes";
            this.txtDes.Validating += new System.ComponentModel.CancelEventHandler(this.txtDes_Validating);
            // 
            // lbDes
            // 
            resources.ApplyResources(this.lbDes, "lbDes");
            this.lbDes.Name = "lbDes";
            // 
            // txtTrailer
            // 
            resources.ApplyResources(this.txtTrailer, "txtTrailer");
            this.txtTrailer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeBindingSource, "trailer", true));
            this.txtTrailer.Name = "txtTrailer";
            this.txtTrailer.Validating += new System.ComponentModel.CancelEventHandler(this.txtTrailer_Validating);
            // 
            // lbTrailer
            // 
            resources.ApplyResources(this.lbTrailer, "lbTrailer");
            this.lbTrailer.Name = "lbTrailer";
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.ForeColor = System.Drawing.Color.DeepPink;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.ForeColor = System.Drawing.Color.DeepPink;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.DeepPink;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbSea
            // 
            resources.ApplyResources(this.lbSea, "lbSea");
            this.lbSea.Name = "lbSea";
            // 
            // lbType
            // 
            resources.ApplyResources(this.lbType, "lbType");
            this.lbType.Name = "lbType";
            // 
            // lbRa
            // 
            resources.ApplyResources(this.lbRa, "lbRa");
            this.lbRa.Name = "lbRa";
            // 
            // lbSta
            // 
            resources.ApplyResources(this.lbSta, "lbSta");
            this.lbSta.Name = "lbSta";
            // 
            // cbbType
            // 
            resources.ApplyResources(this.cbbType, "cbbType");
            this.cbbType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animeBindingSource, "type", true));
            this.cbbType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeBindingSource, "type", true));
            this.cbbType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.animeBindingSource, "type", true));
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            resources.GetString("cbbType.Items"),
            resources.GetString("cbbType.Items1"),
            resources.GetString("cbbType.Items2"),
            resources.GetString("cbbType.Items3"),
            resources.GetString("cbbType.Items4"),
            resources.GetString("cbbType.Items5")});
            this.cbbType.Name = "cbbType";
            // 
            // cbbStatus
            // 
            resources.ApplyResources(this.cbbStatus, "cbbStatus");
            this.cbbStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeBindingSource, "status", true));
            this.cbbStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animeBindingSource, "status", true));
            this.cbbStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.animeBindingSource, "status", true));
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            resources.GetString("cbbStatus.Items"),
            resources.GetString("cbbStatus.Items1")});
            this.cbbStatus.Name = "cbbStatus";
            // 
            // cbbRating
            // 
            resources.ApplyResources(this.cbbRating, "cbbRating");
            this.cbbRating.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.animeBindingSource, "rating", true));
            this.cbbRating.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animeBindingSource, "rating", true));
            this.cbbRating.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeBindingSource, "rating", true));
            this.cbbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRating.FormattingEnabled = true;
            this.cbbRating.Items.AddRange(new object[] {
            resources.GetString("cbbRating.Items"),
            resources.GetString("cbbRating.Items1"),
            resources.GetString("cbbRating.Items2"),
            resources.GetString("cbbRating.Items3"),
            resources.GetString("cbbRating.Items4")});
            this.cbbRating.Name = "cbbRating";
            // 
            // cbbSeason
            // 
            resources.ApplyResources(this.cbbSeason, "cbbSeason");
            this.cbbSeason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeBindingSource, "SeasonID", true));
            this.cbbSeason.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.seasonBindingSource, "SeasonID", true));
            this.cbbSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeason.FormattingEnabled = true;
            this.cbbSeason.Name = "cbbSeason";
            // 
            // seasonBindingSource
            // 
            this.seasonBindingSource.DataSource = typeof(FMSAPP.season);
            // 
            // lbPos
            // 
            resources.ApplyResources(this.lbPos, "lbPos");
            this.lbPos.Name = "lbPos";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.animeBindingSource, "releaseDate", true));
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeBindingSource, "poster", true));
            this.textBox1.Name = "textBox1";
            // 
            // dateTimeAdd
            // 
            resources.ApplyResources(this.dateTimeAdd, "dateTimeAdd");
            this.dateTimeAdd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.animeBindingSource, "created_at", true));
            this.dateTimeAdd.Name = "dateTimeAdd";
            this.dateTimeAdd.Value = new System.DateTime(2020, 11, 4, 13, 19, 56, 0);
            // 
            // dateTimeDelete
            // 
            resources.ApplyResources(this.dateTimeDelete, "dateTimeDelete");
            this.dateTimeDelete.Name = "dateTimeDelete";
            this.dateTimeDelete.Value = new System.DateTime(2020, 11, 4, 0, 0, 0, 0);
            // 
            // dateTimeUpdate
            // 
            resources.ApplyResources(this.dateTimeUpdate, "dateTimeUpdate");
            this.dateTimeUpdate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.animeBindingSource, "updated_at", true));
            this.dateTimeUpdate.Name = "dateTimeUpdate";
            this.dateTimeUpdate.Value = new System.DateTime(2020, 11, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtIDAdmin
            // 
            resources.ApplyResources(this.txtIDAdmin, "txtIDAdmin");
            this.txtIDAdmin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeBindingSource, "AccountID", true));
            this.txtIDAdmin.Name = "txtIDAdmin";
            // 
            // AnimeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtIDAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeUpdate);
            this.Controls.Add(this.dateTimeDelete);
            this.Controls.Add(this.dateTimeAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPos);
            this.Controls.Add(this.cbbSeason);
            this.Controls.Add(this.cbbRating);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.lbSta);
            this.Controls.Add(this.lbRa);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbSea);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTrailer);
            this.Controls.Add(this.lbTrailer);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.txtDura);
            this.Controls.Add(this.lbDu);
            this.Controls.Add(this.txtEpi);
            this.Controls.Add(this.lbEp);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AnimeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimeForm_FormClosing);
            this.Load += new System.EventHandler(this.AnimeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource animeBindingSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEpi;
        private System.Windows.Forms.Label lbEp;
        private System.Windows.Forms.TextBox txtDura;
        private System.Windows.Forms.Label lbDu;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.TextBox txtTrailer;
        private System.Windows.Forms.Label lbTrailer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbSea;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbRa;
        private System.Windows.Forms.Label lbSta;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.ComboBox cbbRating;
        private System.Windows.Forms.ComboBox cbbSeason;
        private System.Windows.Forms.Label lbPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimeAdd;
        private System.Windows.Forms.DateTimePicker dateTimeDelete;
        private System.Windows.Forms.DateTimePicker dateTimeUpdate;
        private System.Windows.Forms.BindingSource seasonBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn animeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn episodesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trailerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
    }
}