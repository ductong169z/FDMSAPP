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
            this.seasonBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.seasonGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
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
            this.seasonGridView.Location = new System.Drawing.Point(482, 8);
            this.seasonGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seasonGridView.MultiSelect = false;
            this.seasonGridView.Name = "seasonGridView";
            this.seasonGridView.ReadOnly = true;
            this.seasonGridView.RowHeadersVisible = false;
            this.seasonGridView.RowHeadersWidth = 62;
            this.seasonGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.seasonGridView.Size = new System.Drawing.Size(315, 435);
            this.seasonGridView.TabIndex = 1;
            this.seasonGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // seasonBindingSource
            // 
            this.seasonBindingSource.DataSource = typeof(FMSAPP.season);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(358, 408);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCreated_at
            // 
            this.txtCreated_at.Location = new System.Drawing.Point(126, 321);
            this.txtCreated_at.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCreated_at.Name = "txtCreated_at";
            this.txtCreated_at.ReadOnly = true;
            this.txtCreated_at.Size = new System.Drawing.Size(176, 20);
            this.txtCreated_at.TabIndex = 17;
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(22, 325);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(57, 13);
            this.lblCreatedAt.TabIndex = 18;
            this.lblCreatedAt.Text = "Created At";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 249);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 253);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(126, 175);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(176, 20);
            this.txtID.TabIndex = 10;
            // 
            // lblSeasonId
            // 
            this.lblSeasonId.AutoSize = true;
            this.lblSeasonId.Location = new System.Drawing.Point(22, 179);
            this.lblSeasonId.Name = "lblSeasonId";
            this.lblSeasonId.Size = new System.Drawing.Size(54, 13);
            this.lblSeasonId.TabIndex = 14;
            this.lblSeasonId.Text = "SeasonID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(246, 408);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(135, 408);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(26, 408);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(126, 37);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 20);
            this.txtSearch.TabIndex = 20;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(22, 40);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(35, 13);
            this.lblSearchName.TabIndex = 21;
            this.lblSearchName.Text = "Name";
            // 
            // lblSearchCreatedAt
            // 
            this.lblSearchCreatedAt.AutoSize = true;
            this.lblSearchCreatedAt.Location = new System.Drawing.Point(22, 98);
            this.lblSearchCreatedAt.Name = "lblSearchCreatedAt";
            this.lblSearchCreatedAt.Size = new System.Drawing.Size(57, 13);
            this.lblSearchCreatedAt.TabIndex = 23;
            this.lblSearchCreatedAt.Text = "Created At";
            // 
            // separator
            // 
            this.separator.Location = new System.Drawing.Point(15, 122);
            this.separator.Name = "separator";
            this.separator.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.separator.Size = new System.Drawing.Size(452, 28);
            this.separator.TabIndex = 24;
            // 
            // searchDate
            // 
            this.searchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.searchDate.Location = new System.Drawing.Point(112, 74);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(157, 20);
            this.searchDate.TabIndex = 25;
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(302, 32);
            this.bntSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(83, 19);
            this.bntSearch.TabIndex = 26;
            this.bntSearch.Text = "Search name";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // bnt_searchdate
            // 
            this.bnt_searchdate.Location = new System.Drawing.Point(302, 74);
            this.bnt_searchdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnt_searchdate.Name = "bnt_searchdate";
            this.bnt_searchdate.Size = new System.Drawing.Size(83, 19);
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
            this.seasonIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "Created At";
            this.createdatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SeasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SeasonForm";
            this.Text = "bu";
            this.Load += new System.EventHandler(this.SeasonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seasonGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
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