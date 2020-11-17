namespace FMSAPP
{
    partial class SeasonForm
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
            this.seasonGridView = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCreated_at = new System.Windows.Forms.TextBox();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblSeasonId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblSearchCreatedAt = new System.Windows.Forms.Label();
            this.separator = new DevExpress.XtraEditors.SeparatorControl();
            this.searchDate = new System.Windows.Forms.DateTimePicker();
<<<<<<< HEAD
            this.bntSearch = new System.Windows.Forms.Button();
=======
            this.btnSearch = new System.Windows.Forms.Button();
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            this.seasonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonBindingSource = new System.Windows.Forms.BindingSource(this.components);
<<<<<<< HEAD
            this.bnt_searchdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.seasonGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // seasonGridView
            // 
            this.seasonGridView.AllowUserToAddRows = false;
            this.seasonGridView.AllowUserToDeleteRows = false;
            this.seasonGridView.AutoGenerateColumns = false;
            this.seasonGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.seasonGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seasonGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seasonIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn});
<<<<<<< HEAD
            this.dataGridView1.DataSource = this.seasonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(651, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(400, 428);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(425, 401);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 34);
=======
            this.seasonGridView.DataSource = this.seasonBindingSource;
            this.seasonGridView.Location = new System.Drawing.Point(654, 14);
            this.seasonGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seasonGridView.MultiSelect = false;
            this.seasonGridView.Name = "seasonGridView";
            this.seasonGridView.ReadOnly = true;
            this.seasonGridView.RowHeadersVisible = false;
            this.seasonGridView.RowHeadersWidth = 62;
            this.seasonGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.seasonGridView.Size = new System.Drawing.Size(498, 535);
            this.seasonGridView.TabIndex = 1;
            this.seasonGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(478, 502);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 43);
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCreated_at
            // 
<<<<<<< HEAD
            this.txtCreated_at.Location = new System.Drawing.Point(149, 316);
            this.txtCreated_at.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreated_at.Name = "txtCreated_at";
            this.txtCreated_at.ReadOnly = true;
            this.txtCreated_at.Size = new System.Drawing.Size(208, 22);
=======
            this.txtCreated_at.Location = new System.Drawing.Point(168, 395);
            this.txtCreated_at.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCreated_at.Name = "txtCreated_at";
            this.txtCreated_at.ReadOnly = true;
            this.txtCreated_at.Size = new System.Drawing.Size(234, 26);
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            this.txtCreated_at.TabIndex = 17;
            // 
            // lblCreatedAt
            // 
<<<<<<< HEAD
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Created_at";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 245);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 22);
=======
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(30, 400);
            this.lblCreatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(86, 20);
            this.lblCreatedAt.TabIndex = 18;
            this.lblCreatedAt.Text = "Created At";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 306);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 26);
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
<<<<<<< HEAD
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(149, 172);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(208, 22);
=======
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 311);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(168, 215);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(234, 26);
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            this.txtID.TabIndex = 10;
            // 
            // lblSeasonId
            // 
<<<<<<< HEAD
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "SeasonID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(292, 401);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 34);
=======
            this.lblSeasonId.AutoSize = true;
            this.lblSeasonId.Location = new System.Drawing.Point(30, 220);
            this.lblSeasonId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeasonId.Name = "lblSeasonId";
            this.lblSeasonId.Size = new System.Drawing.Size(81, 20);
            this.lblSeasonId.TabIndex = 14;
            this.lblSeasonId.Text = "SeasonID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(328, 502);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 43);
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
<<<<<<< HEAD
            this.btnUpdate.Location = new System.Drawing.Point(160, 401);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 34);
=======
            this.btnUpdate.Location = new System.Drawing.Point(180, 502);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 43);
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
<<<<<<< HEAD
            this.btnAdd.Location = new System.Drawing.Point(31, 401);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 34);
=======
            this.btnAdd.Location = new System.Drawing.Point(34, 502);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 43);
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
<<<<<<< HEAD
            this.txtSearch.Location = new System.Drawing.Point(149, 36);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(208, 22);
=======
            this.txtSearch.Location = new System.Drawing.Point(168, 45);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 26);
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            this.txtSearch.TabIndex = 20;
            // 
            // lblSearchName
            // 
<<<<<<< HEAD
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Name";
=======
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(30, 49);
            this.lblSearchName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(51, 20);
            this.lblSearchName.TabIndex = 21;
            this.lblSearchName.Text = "Name";
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            // 
            // lblSearchCreatedAt
            // 
<<<<<<< HEAD
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Created_at";
=======
            this.lblSearchCreatedAt.AutoSize = true;
            this.lblSearchCreatedAt.Location = new System.Drawing.Point(30, 120);
            this.lblSearchCreatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchCreatedAt.Name = "lblSearchCreatedAt";
            this.lblSearchCreatedAt.Size = new System.Drawing.Size(86, 20);
            this.lblSearchCreatedAt.TabIndex = 23;
            this.lblSearchCreatedAt.Text = "Created At";
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            // 
            // separator
            // 
<<<<<<< HEAD
            this.separatorControl1.Location = new System.Drawing.Point(17, 123);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.separatorControl1.Size = new System.Drawing.Size(625, 28);
            this.separatorControl1.TabIndex = 24;
=======
            this.separator.Location = new System.Drawing.Point(20, 150);
            this.separator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.separator.Name = "separator";
            this.separator.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.separator.Size = new System.Drawing.Size(603, 34);
            this.separator.TabIndex = 24;
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            // 
            // searchDate
            // 
            this.searchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
<<<<<<< HEAD
            this.searchDate.Location = new System.Drawing.Point(149, 91);
            this.searchDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(208, 22);
            this.searchDate.TabIndex = 25;
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(403, 39);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(111, 23);
            this.bntSearch.TabIndex = 26;
            this.bntSearch.Text = "Search name";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
=======
            this.searchDate.Location = new System.Drawing.Point(168, 114);
            this.searchDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(234, 26);
            this.searchDate.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(478, 108);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 43);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            // 
            // seasonIDDataGridViewTextBoxColumn
            // 
            this.seasonIDDataGridViewTextBoxColumn.DataPropertyName = "SeasonID";
<<<<<<< HEAD
            this.seasonIDDataGridViewTextBoxColumn.HeaderText = "SeasonID";
            this.seasonIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seasonIDDataGridViewTextBoxColumn.Name = "seasonIDDataGridViewTextBoxColumn";
            this.seasonIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.seasonIDDataGridViewTextBoxColumn.Width = 125;
=======
            this.seasonIDDataGridViewTextBoxColumn.HeaderText = "Season ID";
            this.seasonIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.seasonIDDataGridViewTextBoxColumn.Name = "seasonIDDataGridViewTextBoxColumn";
            this.seasonIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.seasonIDDataGridViewTextBoxColumn.Width = 150;
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
<<<<<<< HEAD
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
=======
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
<<<<<<< HEAD
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdatDataGridViewTextBoxColumn.Width = 125;
=======
            this.createdatDataGridViewTextBoxColumn.HeaderText = "Created At";
            this.createdatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdatDataGridViewTextBoxColumn.Width = 150;
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            // 
            // seasonBindingSource
            // 
            this.seasonBindingSource.DataSource = typeof(FMSAPP.season);
            // 
<<<<<<< HEAD
            // bnt_searchdate
            // 
            this.bnt_searchdate.Location = new System.Drawing.Point(403, 91);
            this.bnt_searchdate.Name = "bnt_searchdate";
            this.bnt_searchdate.Size = new System.Drawing.Size(111, 23);
            this.bnt_searchdate.TabIndex = 27;
            this.bnt_searchdate.Text = "Search Date";
            this.bnt_searchdate.UseVisualStyleBackColor = true;
            this.bnt_searchdate.Click += new System.EventHandler(this.bnt_searchdate_Click);
            // 
            // SeasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bnt_searchdate);
            this.Controls.Add(this.bntSearch);
=======
            // SeasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 577);
            this.Controls.Add(this.btnSearch);
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            this.Controls.Add(this.searchDate);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.lblSearchCreatedAt);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCreated_at);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblSeasonId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
<<<<<<< HEAD
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.Controls.Add(this.seasonGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
            this.MaximizeBox = false;
            this.Name = "SeasonForm";
            this.Text = "bu";
            this.Load += new System.EventHandler(this.SeasonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seasonGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView seasonGridView;
        private System.Windows.Forms.BindingSource seasonBindingSource;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtCreated_at;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblSeasonId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label lblSearchCreatedAt;
        private DevExpress.XtraEditors.SeparatorControl separator;
        private System.Windows.Forms.DateTimePicker searchDate;
<<<<<<< HEAD
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.Button bnt_searchdate;
=======
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
>>>>>>> 05fad2fdaf1d104d71d83cf7bbec4e826e45b7c0
    }
}