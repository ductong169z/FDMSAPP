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
            this.bntSearch = new System.Windows.Forms.Button();
            this.bnt_searchdate = new System.Windows.Forms.Button();
            this.seasonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.seasonGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
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
            this.seasonGridView.DataSource = this.seasonBindingSource;
            this.seasonGridView.Location = new System.Drawing.Point(699, 15);
            this.seasonGridView.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.seasonGridView.MultiSelect = false;
            this.seasonGridView.Name = "seasonGridView";
            this.seasonGridView.ReadOnly = true;
            this.seasonGridView.RowHeadersVisible = false;
            this.seasonGridView.RowHeadersWidth = 62;
            this.seasonGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.seasonGridView.Size = new System.Drawing.Size(488, 669);
            this.seasonGridView.TabIndex = 1;
            this.seasonGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(532, 595);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 42);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCreated_at
            // 
            this.txtCreated_at.Location = new System.Drawing.Point(189, 497);
            this.txtCreated_at.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCreated_at.Name = "txtCreated_at";
            this.txtCreated_at.ReadOnly = true;
            this.txtCreated_at.Size = new System.Drawing.Size(263, 26);
            this.txtCreated_at.TabIndex = 17;
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(34, 500);
            this.lblCreatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(86, 20);
            this.lblCreatedAt.TabIndex = 18;
            this.lblCreatedAt.Text = "Created At";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(189, 386);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 26);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 389);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(189, 272);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(263, 26);
            this.txtID.TabIndex = 10;
            // 
            // lblSeasonId
            // 
            this.lblSeasonId.AutoSize = true;
            this.lblSeasonId.Location = new System.Drawing.Point(34, 275);
            this.lblSeasonId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeasonId.Name = "lblSeasonId";
            this.lblSeasonId.Size = new System.Drawing.Size(81, 20);
            this.lblSeasonId.TabIndex = 14;
            this.lblSeasonId.Text = "SeasonID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(364, 595);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 42);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(189, 595);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 42);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(22, 595);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 42);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(168, 45);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 26);
            this.txtSearch.TabIndex = 20;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(34, 48);
            this.lblSearchName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(51, 20);
            this.lblSearchName.TabIndex = 21;
            this.lblSearchName.Text = "Name";
            // 
            // lblSearchCreatedAt
            // 
            this.lblSearchCreatedAt.AutoSize = true;
            this.lblSearchCreatedAt.Location = new System.Drawing.Point(34, 119);
            this.lblSearchCreatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchCreatedAt.Name = "lblSearchCreatedAt";
            this.lblSearchCreatedAt.Size = new System.Drawing.Size(86, 20);
            this.lblSearchCreatedAt.TabIndex = 23;
            this.lblSearchCreatedAt.Text = "Created At";
            // 
            // separator
            // 
            this.separator.Location = new System.Drawing.Point(13, 184);
            this.separator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.separator.Name = "separator";
            this.separator.Padding = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.separator.Size = new System.Drawing.Size(678, 42);
            this.separator.TabIndex = 24;
            // 
            // searchDate
            // 
            this.searchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.searchDate.Location = new System.Drawing.Point(168, 114);
            this.searchDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(234, 26);
            this.searchDate.TabIndex = 25;
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(453, 44);
            this.bntSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(125, 29);
            this.bntSearch.TabIndex = 26;
            this.bntSearch.Text = "Search Name";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // bnt_searchdate
            // 
            this.bnt_searchdate.Location = new System.Drawing.Point(453, 115);
            this.bnt_searchdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bnt_searchdate.Name = "bnt_searchdate";
            this.bnt_searchdate.Size = new System.Drawing.Size(125, 29);
            this.bnt_searchdate.TabIndex = 27;
            this.bnt_searchdate.Text = "Search Date";
            this.bnt_searchdate.UseVisualStyleBackColor = true;
            this.bnt_searchdate.Click += new System.EventHandler(this.bnt_searchdate_Click);
            // 
            // seasonIDDataGridViewTextBoxColumn
            // 
            this.seasonIDDataGridViewTextBoxColumn.DataPropertyName = "SeasonID";
            this.seasonIDDataGridViewTextBoxColumn.HeaderText = "Season ID";
            this.seasonIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.seasonIDDataGridViewTextBoxColumn.Name = "seasonIDDataGridViewTextBoxColumn";
            this.seasonIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.seasonIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "Created At";
            this.createdatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdatDataGridViewTextBoxColumn.Width = 150;
            // 
            // seasonBindingSource
            // 
            this.seasonBindingSource.DataSource = typeof(FMSAPP.season);
            // 
            // SeasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.bnt_searchdate);
            this.Controls.Add(this.bntSearch);
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
            this.Controls.Add(this.seasonGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "SeasonForm";
            this.Text = "Season Form";
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
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.Button bnt_searchdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
    }
}