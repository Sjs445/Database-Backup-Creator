namespace Db_Backup_Job_Creator
{
    partial class DB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DB));
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.Combobox_db = new System.Windows.Forms.ComboBox();
            this.btn_list = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_path = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_backupname = new System.Windows.Forms.TextBox();
            this.btn_jobs = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_server = new System.Windows.Forms.Label();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_backupfile = new System.Windows.Forms.Button();
            this.lnklbl_schedule = new System.Windows.Forms.LinkLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(26, 30);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(53, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Database";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(26, 110);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(43, 13);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "User ID";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(29, 126);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(121, 20);
            this.tb_id.TabIndex = 3;
            this.tb_id.Text = "sa";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(29, 165);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(121, 20);
            this.tb_password.TabIndex = 4;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(26, 149);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(53, 13);
            this.lbl_Pass.TabIndex = 5;
            this.lbl_Pass.Text = "Password";
            // 
            // Combobox_db
            // 
            this.Combobox_db.FormattingEnabled = true;
            this.Combobox_db.Location = new System.Drawing.Point(29, 46);
            this.Combobox_db.Name = "Combobox_db";
            this.Combobox_db.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Combobox_db.Size = new System.Drawing.Size(121, 21);
            this.Combobox_db.TabIndex = 8;
            this.Combobox_db.Text = "Database Name";
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(29, 195);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(121, 28);
            this.btn_list.TabIndex = 7;
            this.btn_list.Text = "List Databases";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Path";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(218, 47);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(121, 20);
            this.tb_path.TabIndex = 9;
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(343, 47);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(41, 20);
            this.btn_path.TabIndex = 10;
            this.btn_path.Text = "...";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Visible = false;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(215, 71);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(97, 13);
            this.lbl_name.TabIndex = 11;
            this.lbl_name.Text = "Backup/Job Name";
            // 
            // tb_backupname
            // 
            this.tb_backupname.Location = new System.Drawing.Point(218, 87);
            this.tb_backupname.Name = "tb_backupname";
            this.tb_backupname.ReadOnly = true;
            this.tb_backupname.Size = new System.Drawing.Size(121, 20);
            this.tb_backupname.TabIndex = 12;
            // 
            // btn_jobs
            // 
            this.btn_jobs.Location = new System.Drawing.Point(191, 195);
            this.btn_jobs.Name = "btn_jobs";
            this.btn_jobs.Size = new System.Drawing.Size(121, 28);
            this.btn_jobs.TabIndex = 15;
            this.btn_jobs.Text = "Create Jobs";
            this.btn_jobs.UseVisualStyleBackColor = true;
            this.btn_jobs.Visible = false;
            this.btn_jobs.Click += new System.EventHandler(this.btn_jobs_Click);
            // 
            // lbl_server
            // 
            this.lbl_server.AutoSize = true;
            this.lbl_server.Location = new System.Drawing.Point(26, 71);
            this.lbl_server.Name = "lbl_server";
            this.lbl_server.Size = new System.Drawing.Size(69, 13);
            this.lbl_server.TabIndex = 14;
            this.lbl_server.Text = "Server Name";
            // 
            // tb_server
            // 
            this.tb_server.Location = new System.Drawing.Point(29, 87);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(121, 20);
            this.tb_server.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // btn_backupfile
            // 
            this.btn_backupfile.Location = new System.Drawing.Point(343, 195);
            this.btn_backupfile.Name = "btn_backupfile";
            this.btn_backupfile.Size = new System.Drawing.Size(121, 28);
            this.btn_backupfile.TabIndex = 16;
            this.btn_backupfile.Text = "Create Backup File";
            this.btn_backupfile.UseVisualStyleBackColor = true;
            this.btn_backupfile.Visible = false;
            this.btn_backupfile.Click += new System.EventHandler(this.btn_backupfile_Click);
            // 
            // lnklbl_schedule
            // 
            this.lnklbl_schedule.AutoSize = true;
            this.lnklbl_schedule.Location = new System.Drawing.Point(215, 109);
            this.lnklbl_schedule.Name = "lnklbl_schedule";
            this.lnklbl_schedule.Size = new System.Drawing.Size(118, 13);
            this.lnklbl_schedule.TabIndex = 13;
            this.lnklbl_schedule.TabStop = true;
            this.lnklbl_schedule.Text = "Backup Schedule Time";
            this.lnklbl_schedule.Visible = false;
            this.lnklbl_schedule.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_schedule_LinkClicked);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HHmmss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(218, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            // 
            // DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(491, 290);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lnklbl_schedule);
            this.Controls.Add(this.btn_backupfile);
            this.Controls.Add(this.tb_server);
            this.Controls.Add(this.lbl_server);
            this.Controls.Add(this.btn_jobs);
            this.Controls.Add(this.tb_backupname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_path);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.Combobox_db);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DB";
            this.Text = "Shane DB Backup Job Creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.ComboBox Combobox_db;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_backupname;
        private System.Windows.Forms.Button btn_jobs;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lbl_server;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn_backupfile;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnklbl_schedule;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

