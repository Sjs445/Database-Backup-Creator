using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace Db_Backup_Job_Creator
{
    public partial class DB : Form
    {
        public DB()
        {
            InitializeComponent();
            tb_server.Text = Environment.MachineName;   //Initializes server name text box as local machine hostname
        }
        
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public void CreateConnection()
        {
            string username = tb_id.Text;
            string password = tb_password.Text;
            string connectionString = null;
            string serverName = tb_server.Text;

            connectionString = "Data source="+serverName+";User ID=" + username + ";Password=" + password;

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                MessageBox.Show("The database connection has been opened. \nSelect the database you want to create backups for. ", "Connection Open!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Combobox_db.Items.Clear();
                cmd = new SqlCommand("select * from sysdatabases order by name", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Combobox_db.Items.Add(dr[0]);
                }
                dr.Close();
                enableRight();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection!", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            if(isEmptyLeft())
            {
                return;
            }
            CreateConnection();
        }

        public void createJobs(string str)
        {
            if (isEmptyRight())
            {
                return;
            }
            else
            {
                createFolder();
                createDaysofweekPath();
                string dbname = Combobox_db.Text;
                string login = tb_id.Text;
                string servername = tb_server.Text;
                string pathname = tb_path.Text;
                string backupname = tb_backupname.Text;
                string time = dateTimePicker1.Text;

                if(str=="backup")
                {

                    query("use msdb;");
                    try
                    {   //Next feature to add is to specify how many days of the week you want to create backups for.
                        //Another feature could be to check off another database for backing up multiple databases.
                        //Create a folder called 'Failed Logs' or something in order to store why the program failed to backup/create jobs.
                       
                        for (int i = 0; i <= 4; i++)
                        {
                            string jobname = tb_backupname.Text + " " + day(i);

                            query("exec sp_add_job @job_name = N" + "'" + jobname + "'," +
                                    "@enabled=1," +
                                    "@description=N" + "'" + "Back up Database - " + dbname + "'," +
                                    "@owner_login_name=" + "'" + login + "', " +
                                    "@notify_level_eventlog=2," +
                                    "@notify_level_email=2," +
                                    "@notify_level_netsend=2," +
                                    "@notify_level_page=2");

                            query("exec sp_add_jobstep @job_name = N" + "'" + jobname + "'," +
                                    "@step_name=[" + dbname + "]," +
                                    "@subsystem='TSQL'," +
                                    "@command='BACKUP DATABASE [" + dbname + "] TO DISK=''" + pathname + "\\" + pathDay(i) + "\\" + backupname + ".bak '' WITH NOFORMAT, INIT,  NAME=''" + dbname + "-Full Database Backup'', SKIP, NOREWIND, NOUNLOAD,  STATS = 10'");

                            query("exec sp_add_jobschedule @job_name= N" + "'" + jobname + "'," +
                                    "@name = 'ScheduledBackup_msdb'," +
                                    "@freq_type = 8," +
                                    "@freq_interval = " + finterval(i) + "," +
                                    "@active_start_time ="+ time+"," +
                                    "@freq_recurrence_factor = 1");

                            query("exec sp_add_jobserver @job_name=N" + "'" + jobname + "'," +
                                "@server_name=N" + "'" + servername + "';");
                        }
                        MessageBox.Show("Created four jobs for " + dbname+".");
                        }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not create jobs.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void query(string que)
        {
            cmd = new SqlCommand(que, cnn);
            cmd.ExecuteNonQuery();
        }

        private void btn_path_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                tb_path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_jobs_Click(object sender, EventArgs e)
        {
            createJobs("backup");
        }
        
        public string day(int x)
        {
            switch (x)
            {
                case 0:
                    return "MON";
                case 1:
                    return "TUE";
                case 2:
                    return "WED";
                case 3:
                    return "THU";
                case 4:
                    return "FRI";
                default:
                    return "INVALID";
            }
        }
        
        public string finterval(int x)
        {
            switch(x)
            {
                case 0:
                    return "2";
                case 1:
                    return "4";
                case 2:
                    return "8";
                case 3:
                    return "16";
                case 4:
                    return "32";
                default:
                    return "INVALID";
            }
        }
        public string pathDay(int x)
        {
            switch(x)
            {
                case 0:
                    return "DB Backup Creator\\Monday\\";
                case 1:
                    return "DB Backup Creator\\Tuesday\\";
                case 2:
                    return "DB Backup Creator\\Wednesday\\";
                case 3:
                    return "DB Backup Creator\\Thursday\\";
                case 4:
                    return "DB Backup Creator\\Monday\\";
                default:
                    return "Error Log";

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Shane Spangenberg.", "Copyright 2018.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_backupfile_Click(object sender, EventArgs e)
        {
            string s = null;
            string n = null;
            string dbname = Combobox_db.Text;
            string login = tb_id.Text;
            string servername = tb_server.Text;


            s = tb_path.Text+"\\DB Backup Creator\\Backups\\";
            n = tb_backupname.Text;
            if (!isEmptyLeft() && !isEmptyRight())
            {
                createFolder();
                createBackupFolder();
                try
                {
                    query("backup database [" + dbname + "] to disk='" + s + "\\" + n + ".bak'");
                    MessageBox.Show("Created backup file for " + dbname + " in "+s, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not backup database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lnklbl_schedule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please enter time below in military time (HHMMSS). ", "Notice.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If the program fails to make the backup file or fails to create jobs make sure the following are true.\n" +
                "1. The program must be on the machine running the SQL server." +
                "\n2. The server name needs to be the hostname. It can't be 'localhost'.","Common Errors.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void createFolder()
        {
            string pathName = tb_path.Text+"DB Backup Creator\\";
            if(!Directory.Exists(pathName))
            {
                Directory.CreateDirectory(pathName);
                return;
            }
            return;
        }

        public void createBackupFolder()
        {
            if(!Directory.Exists(tb_path.Text+"DB Backup Creator\\Backups\\"))
            {
                Directory.CreateDirectory(tb_path.Text + "DB Backup Creator\\Backups\\");
                return;
            }
        }

        public void createDaysofweekPath()
        {
            string Monday = tb_path.Text + "DB Backup Creator\\Monday\\";
            string Tuesday = tb_path.Text + "DB Backup Creator\\Tuesday\\";
            string Wednesday = tb_path.Text + "DB Backup Creator\\Wednesday\\";
            string Thursday = tb_path.Text + "DB Backup Creator\\Thursday\\";
            string Friday = tb_path.Text + "DB Backup Creator\\Friday\\";
            if (!Directory.Exists(Monday))
            {
                Directory.CreateDirectory(Monday);
            }
            if(!Directory.Exists(Tuesday))
            {
                Directory.CreateDirectory(Tuesday);
            }
            if(!Directory.Exists(Wednesday))
            {
                Directory.CreateDirectory(Thursday);
            }
            if(!Directory.Exists(Friday))
            {
                Directory.CreateDirectory(Friday);
            }
            return;
        }

        public bool isEmptyLeft()
        {
            if (tb_server.Text == "")
            {
                MessageBox.Show("Please enter a server name and try again. ", "Missing Information!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            else if (tb_id.Text == "")
            {
                MessageBox.Show("Please enter a user ID and try again. ", "Missing Information!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            else if(tb_password.Text == "")
            {
                MessageBox.Show("Please enter a password and try again. ", "Missing Information!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isEmptyRight()
        {
            if (string.IsNullOrEmpty(tb_path.Text) | string.IsNullOrEmpty(tb_path.Text))
            {
                MessageBox.Show("Please enter a path and try again.", "Missing Information!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            else if (string.IsNullOrEmpty(tb_backupname.Text) | string.IsNullOrEmpty(tb_backupname.Text))
            {
                MessageBox.Show("Please enter a backup name and try again. ", "Missing Infromation!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            else if(Combobox_db.Text=="Database Name")
            {
                MessageBox.Show("Please select a Database and try again. ", "Missing Information!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void enableRight()
        {
            tb_path.ReadOnly = false;
            tb_backupname.ReadOnly = false;
            lnklbl_schedule.Visible = true;
            dateTimePicker1.Visible = true;
            btn_backupfile.Visible = true;
            btn_jobs.Visible = true;
            btn_path.Visible = true;
        }
    }
}
