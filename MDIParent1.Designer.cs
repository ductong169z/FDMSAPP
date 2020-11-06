namespace FMSAPP
{
    partial class MDIParent1
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblID = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(930, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animeFormToolStripMenuItem,
            this.userFormToolStripMenuItem,
            this.adminFormToolStripMenuItem,
            this.closeAllFormToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // animeFormToolStripMenuItem
            // 
            this.animeFormToolStripMenuItem.Name = "animeFormToolStripMenuItem";
            this.animeFormToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.animeFormToolStripMenuItem.Text = "AnimeForm";
            this.animeFormToolStripMenuItem.Click += new System.EventHandler(this.animeFormToolStripMenuItem_Click);
            // 
            // userFormToolStripMenuItem
            // 
            this.userFormToolStripMenuItem.Name = "userFormToolStripMenuItem";
            this.userFormToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.userFormToolStripMenuItem.Text = "UserForm";
            this.userFormToolStripMenuItem.Click += new System.EventHandler(this.userFormToolStripMenuItem_Click);
            // 
            // adminFormToolStripMenuItem
            // 
            this.adminFormToolStripMenuItem.Name = "adminFormToolStripMenuItem";
            this.adminFormToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adminFormToolStripMenuItem.Text = "AdminForm";
            this.adminFormToolStripMenuItem.Click += new System.EventHandler(this.adminFormToolStripMenuItem_Click);
            // 
            // closeAllFormToolStripMenuItem
            // 
            this.closeAllFormToolStripMenuItem.Name = "closeAllFormToolStripMenuItem";
            this.closeAllFormToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeAllFormToolStripMenuItem.Text = "CloseAllForm";
            this.closeAllFormToolStripMenuItem.Click += new System.EventHandler(this.closeAllFormToolStripMenuItem_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(300, 241);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(129, 24);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "IDAdminLogin";
            this.lblID.Visible = false;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(930, 583);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animeFormToolStripMenuItem;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ToolStripMenuItem userFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminFormToolStripMenuItem;
    }
}



