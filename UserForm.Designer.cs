namespace FMSAPP
{
    partial class UserForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbRoleID = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animeDataSet1 = new FMSAPP.animeDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.roleTableAdapter = new FMSAPP.animeDataSet1TableAdapters.roleTableAdapter();
            this.dateTimeUpdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDelete = new System.Windows.Forms.DateTimePicker();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.roleIDDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.avatarDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.deletedatDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(324, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(464, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "roleID:";
            // 
            // cbbRoleID
            // 
            this.cbbRoleID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "RoleID", true));
            this.cbbRoleID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roleBindingSource, "RoleID", true));
            this.cbbRoleID.FormattingEnabled = true;
            this.cbbRoleID.Location = new System.Drawing.Point(95, 63);
            this.cbbRoleID.Name = "cbbRoleID";
            this.cbbRoleID.Size = new System.Drawing.Size(174, 24);
            this.cbbRoleID.TabIndex = 6;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "role";
            this.roleBindingSource.DataSource = this.animeDataSet1;
            // 
            // animeDataSet1
            // 
            this.animeDataSet1.DataSetName = "animeDataSet1";
            this.animeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "fullname:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "fullname", true));
            this.textBox2.Location = new System.Drawing.Point(95, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 22);
            this.textBox2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "avatar:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "avatar", true));
            this.textBox3.Location = new System.Drawing.Point(95, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 22);
            this.textBox3.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "email:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "email", true));
            this.textBox5.Location = new System.Drawing.Point(95, 186);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(174, 22);
            this.textBox5.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "gender", true));
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accountBindingSource, "gender", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBox2.Location = new System.Drawing.Point(95, 232);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(174, 24);
            this.comboBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "USERFORM";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.DeepPink;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(158, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.DeepPink;
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(21, 365);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.DeepPink;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(158, 298);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Plum;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.DeepPink;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(21, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimeUpdate
            // 
            this.dateTimeUpdate.Location = new System.Drawing.Point(527, 269);
            this.dateTimeUpdate.Name = "dateTimeUpdate";
            this.dateTimeUpdate.Size = new System.Drawing.Size(200, 22);
            this.dateTimeUpdate.TabIndex = 35;
            this.dateTimeUpdate.Value = new System.DateTime(2020, 11, 1, 0, 0, 0, 0);
            this.dateTimeUpdate.Visible = false;
            // 
            // dateTimeDelete
            // 
            this.dateTimeDelete.Location = new System.Drawing.Point(502, 201);
            this.dateTimeDelete.Name = "dateTimeDelete";
            this.dateTimeDelete.Size = new System.Drawing.Size(200, 22);
            this.dateTimeDelete.TabIndex = 34;
            this.dateTimeDelete.Value = new System.DateTime(2020, 11, 1, 0, 0, 0, 0);
            this.dateTimeDelete.Visible = false;
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRefesh.FlatAppearance.BorderSize = 0;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.ForeColor = System.Drawing.Color.DeepPink;
            this.btnRefesh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefesh.Location = new System.Drawing.Point(85, 416);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(75, 32);
            this.btnRefesh.TabIndex = 36;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(FMSAPP.account);
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleIDDataGridViewTextBoxColumn
            // 
            this.roleIDDataGridViewTextBoxColumn.DataPropertyName = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.HeaderText = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleIDDataGridViewTextBoxColumn.Name = "roleIDDataGridViewTextBoxColumn";
            this.roleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // avatarDataGridViewTextBoxColumn
            // 
            this.avatarDataGridViewTextBoxColumn.DataPropertyName = "avatar";
            this.avatarDataGridViewTextBoxColumn.HeaderText = "avatar";
            this.avatarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.avatarDataGridViewTextBoxColumn.Name = "avatarDataGridViewTextBoxColumn";
            this.avatarDataGridViewTextBoxColumn.ReadOnly = true;
            this.avatarDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdatDataGridViewTextBoxColumn.Width = 125;
            // 
            // deletedatDataGridViewTextBoxColumn
            // 
            this.deletedatDataGridViewTextBoxColumn.DataPropertyName = "deleted_at";
            this.deletedatDataGridViewTextBoxColumn.HeaderText = "deleted_at";
            this.deletedatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deletedatDataGridViewTextBoxColumn.Name = "deletedatDataGridViewTextBoxColumn";
            this.deletedatDataGridViewTextBoxColumn.ReadOnly = true;
            this.deletedatDataGridViewTextBoxColumn.Width = 125;
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            this.updatedatDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedatDataGridViewTextBoxColumn.Width = 125;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.dateTimeUpdate);
            this.Controls.Add(this.dateTimeDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cbbRoleID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbRoleID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private animeDataSet1 animeDataSet1;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private animeDataSet1TableAdapters.roleTableAdapter roleTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimeUpdate;
        private System.Windows.Forms.DateTimePicker dateTimeDelete;
        private System.Windows.Forms.Button btnRefesh;
    }
}