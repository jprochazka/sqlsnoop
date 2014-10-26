using SQLSnoop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SQLSnoop
{
    public partial class Dashboard : Form
    {
        public string connString;
        private SqlServerInformation sqlServerInfo = new SqlServerInformation();

        public Dashboard()
        {
            InitializeComponent();

            // Open the Form named Connect where SQL Server connection information is obtained from.
            Connect connectForm = new Connect();
            connectForm.ShowDialog();

            // Get the connString variable containing the connection string built using the from connectForm.
            connString = connectForm.connString;

            if (!string.IsNullOrWhiteSpace(connString))
            {
                // Populate CheckedListBox with a list of databases from the selected SQL Server.
                PopulateDatabaseList();

                // Get SQL Server information from the SQL Server itself.
                sqlServerInfo = GetSqlServerInformation();

                // Set label text.
                lblSqlServerName.Text = sqlServerInfo.ServerName;
                lblSqlServerVersion.Text = "Microsoft SQL Server " + sqlServerInfo.ProductVersion + " " + sqlServerInfo.ProductLevel + " " + sqlServerInfo.Edition;

                // Start the SQL Server CPU utilization timer.
                tmrSqlServerCpu.Start();
                tmrSqlServerCpu_Tick(null, EventArgs.Empty);
            }
        }

        private void lnkRefreshDatabaseList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Repopulate CheckedListBox with a list of databases from the selected SQL Server.
            PopulateDatabaseList();
        }

        private void lstDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Select the database tab automatically.
            tabControl1.SelectedTab = tabDatabase;

            // Get information pertaining to the selected database.
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand("sp_helpdb ", conn) { CommandType = CommandType.StoredProcedure })
            {
                cmd.Parameters.Add("@dbname", SqlDbType.NVarChar, 128).Value = lstDatabases.SelectedItem;
                try
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Populate labels with database information.
                            lblDatabaseName.Text = dr["name"].ToString().Trim();
                            lblDatabaseSize.Text = "Size: " + dr["db_size"].ToString().Trim();
                            lblDatabaseOwner.Text = "Owner: " + dr["owner"].ToString().Trim();
                            lblDatabaseCreated.Text = "Created: " + dr["created"].ToString().Trim();
                            lblDatabaseCompatibility.Text = "Compatability: " + (byte)dr["compatibility_level"];
                        }
                        
                        dr.NextResult();

                        // Populate the DataGridView with database file information.
                        BindingSource bs = new BindingSource();
                        bs.DataSource = dr;
                        dgdDatabaseFiles.DataSource = bs;

                        // Rename the DataGridView columns.
                        dgdDatabaseFiles.Columns["name"].HeaderText = "Name";
                        dgdDatabaseFiles.Columns["fileid"].HeaderText = "File ID";
                        dgdDatabaseFiles.Columns["filename"].HeaderText = "File Name";
                        dgdDatabaseFiles.Columns["filegroup"].HeaderText = "File Group";
                        dgdDatabaseFiles.Columns["size"].HeaderText = "Size";
                        dgdDatabaseFiles.Columns["maxsize"].HeaderText = "Maximum Size";
                        dgdDatabaseFiles.Columns["growth"].HeaderText = "Growth";
                        dgdDatabaseFiles.Columns["usage"].HeaderText = "Usage";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database List Population Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        #region MenuStrip

        private void connectToMicrosoftSQLServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the Form named Connect where SQL Server connection information is obtained from.
            Connect connectForm = new Connect();
            connectForm.ShowDialog();

            // Get the connString variable containing the connection string built using the from connectForm.
            connString = connectForm.connString;

            
            if (!string.IsNullOrWhiteSpace(connString))
            {
                // Populate CheckedListBox with a list of databases from the selected SQL Server.
                PopulateDatabaseList();

                // Get SQL Server information from the SQL Server itself.
                var sqlServerInfo = GetSqlServerInformation();

                // Set label text.
                lblSqlServerName.Text = sqlServerInfo.ServerName;
                lblSqlServerVersion.Text = "Microsoft SQL Server " + sqlServerInfo.ProductVersion + " " + sqlServerInfo.ProductLevel + " " + sqlServerInfo.Edition;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the application.
            Application.Exit();
        }

        private void aboutSQLSnoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the About Box.
            About aboutBox = new About();
            aboutBox.ShowDialog();
        }

        #endregion

        #region Functions

        private void PopulateDatabaseList()
        {
            // Remove the existing list of databases.
            lstDatabases.Items.Clear();

            // Connect to the currently selected SQL Server instance and get a list of databases.
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand("sp_databases", conn) { CommandType = CommandType.StoredProcedure })
            {
                try
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lstDatabases.Items.Add(dr["DATABASE_NAME"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database List Population Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private SqlServerInformation GetSqlServerInformation()
        {
            var sqlServerInfo = new SqlServerInformation();

            // Load the SQL query stored in the file named SqlServerInformation.sql.
            string sqlScript = File.ReadAllText(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Sqlscripts\SqlServerInformation.sql");

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(sqlScript, conn))
            {
                try
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            sqlServerInfo.BuildClrVersion = (string)dr["BuildClrVersion"];
                            sqlServerInfo.Collation = (string)dr["Collation"];
                            sqlServerInfo.CollationID = (int)dr["CollationID"];
                            sqlServerInfo.ComparisonStyle = (int)dr["ComparisonStyle"];
                            sqlServerInfo.ComputerNamePhysicalNetBIOS = (string)dr["ComputerNamePhysicalNetBIOS"];
                            sqlServerInfo.Edition = (string)dr["Edition"];
                            sqlServerInfo.EditionID = (int)dr["EditionID"];
                            sqlServerInfo.EngineEdition = (int)dr["EngineEdition"];
                            sqlServerInfo.FilestreamConfiguredLevel = (int)dr["FilestreamConfiguredLevel"];
                            sqlServerInfo.FilestreamEffectiveLevel = (int)dr["FilestreamEffectiveLevel"];
                            sqlServerInfo.FilestreamShareName = (string)dr["FilestreamShareName"];
                            if (!string.IsNullOrEmpty(dr["HadrManagerStatus"].ToString()))
                                sqlServerInfo.HadrManagerStatus = (int)dr["HadrManagerStatus"];
                            if (!string.IsNullOrEmpty(dr["InstanceName"].ToString()))
                                sqlServerInfo.InstanceName = (string)dr["InstanceName"];
                            sqlServerInfo.IsClustered = (int)dr["IsClustered"];
                            sqlServerInfo.IsFullTextInstalled = (int)dr["IsFullTextInstalled"];
                            if (!string.IsNullOrEmpty(dr["IsHadrEnabled"].ToString()))
                                sqlServerInfo.IsHadrEnabled = (int)dr["IsHadrEnabled"];
                            sqlServerInfo.IsIntegratedSecurityOnly = (int)dr["IsIntegratedSecurityOnly"];
                            if (!string.IsNullOrEmpty(dr["IsHadrEnabled"].ToString()))
                                sqlServerInfo.IsLocalDB = (int)dr["IsLocalDB"];
                            sqlServerInfo.IsSingleUser = (int)dr["IsSingleUser"];
                            if (!string.IsNullOrEmpty(dr["IsHadrEnabled"].ToString()))
                                sqlServerInfo.IsXTPSupported = (int)dr["IsXTPSupported"];
                            sqlServerInfo.LCID = (int)dr["LCID"];
                            sqlServerInfo.MachineName = (string)dr["MachineName"];
                            sqlServerInfo.ProcessID = (int)dr["ProcessID"];
                            sqlServerInfo.ProductLevel = (string)dr["ProductLevel"];
                            sqlServerInfo.ProductVersion = (string)dr["ProductVersion"];
                            sqlServerInfo.ResourceLastUpdateDateTime = (DateTime)dr["ResourceLastUpdateDateTime"];
                            sqlServerInfo.ResourceVersion = (string)dr["ResourceVersion"];
                            sqlServerInfo.ServerName = (string)dr["ServerName"];
                            sqlServerInfo.SqlCharSet = (byte)dr["SqlCharSet"];
                            sqlServerInfo.SqlCharSetName = (string)dr["SqlCharSetName"];
                            sqlServerInfo.SqlSortOrder = (byte)dr["SqlSortOrder"];
                            sqlServerInfo.SqlSortOrderName = (string)dr["SqlSortOrderName"];

                            // LicenseType always returned as DISABLED. (http://msdn.microsoft.com/en-us/library/ms174396.aspx)
                            //sqlServerInfo.LicenseType = (string)dr["LicenseType"];

                            // NumLicenses always returns NULL. (http://msdn.microsoft.com/en-us/library/ms174396.aspx)
                            //sqlServerInfo.NumLicenses = (int)dr["NumLicenses"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Server Information Retrieval", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                }
            }
            return sqlServerInfo;
        }

        #endregion

        #region Timers

        private void tmrSqlServerCpu_Tick(object sender, EventArgs e)
        {
            List<SqlServerCpuUtilization> sqlCpuUtilizations = new List<SqlServerCpuUtilization>();
            string sqlScript = null;

            // Choose script depending on the version of the SQL Server the application is connected to.
            if (Convert.ToInt32(sqlServerInfo.ProductVersion.Substring(0, sqlServerInfo.ProductVersion.IndexOf("."))) > 9)
            {
                // Load the SQL query stored in the file named SqlServerCpuUtilization2008.sql.
                sqlScript = File.ReadAllText(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Sqlscripts\SqlServerCpuUtilization2008.sql");
            }
            else
            {
                // Load the SQL query stored in the file named SqlServerCpuUtilization2005.sql.
                sqlScript = File.ReadAllText(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Sqlscripts\SqlServerCpuUtilization2005.sql");
            }
            
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(sqlScript, conn))
            {
                try
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            SqlServerCpuUtilization sqlCpuUtilization = new SqlServerCpuUtilization();
                            sqlCpuUtilization.SqlCpuUtilization = (int)dr["SQL Server Process CPU Utilization"];
                            sqlCpuUtilization.SystemIdleProcess = (int)dr["System Idle Process"];
                            sqlCpuUtilization.OtherCpuUtilization = (int)dr["Other Process CPU Utilization"];
                            sqlCpuUtilization.EventTime = (DateTime)dr["Event Time"];
                            sqlCpuUtilizations.Add(sqlCpuUtilization);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Server CPU Utilization Retrieval", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tmrSqlServerCpu.Stop();
                }
                finally
                {
                    conn.Close();
                }

                // Assign CPU utilization percentages to the appropriate TextBox.
                txtSqlCpuUtilization.Text = sqlCpuUtilizations.FirstOrDefault().SqlCpuUtilization.ToString();
                txtSystemIdleProcess.Text = sqlCpuUtilizations.FirstOrDefault().SystemIdleProcess.ToString();
                txtOtherCpuUtilization.Text = sqlCpuUtilizations.FirstOrDefault().OtherCpuUtilization.ToString();

                // Populate the line chart.
                chart1.Series["SQL Server Process"].Points.Clear();
                chart1.Series["System Idle Process"].Points.Clear();
                chart1.Series["Other Processes"].Points.Clear();

                foreach (SqlServerCpuUtilization sqlCpuUtilization in sqlCpuUtilizations.OrderBy(s => s.EventTime))
                {
                    chart1.Series["SQL Server Process"].Points.AddXY(sqlCpuUtilization.EventTime.ToString("h:mm tt"), sqlCpuUtilization.SqlCpuUtilization);
                    chart1.Series["System Idle Process"].Points.AddXY(sqlCpuUtilization.EventTime.ToString("h:mm tt"), sqlCpuUtilization.SystemIdleProcess);
                    chart1.Series["Other Processes"].Points.AddXY(sqlCpuUtilization.EventTime.ToString("h:mm tt"), sqlCpuUtilization.OtherCpuUtilization);
                }

                chart1.Series["SQL Server Process"].ChartType = SeriesChartType.FastLine;
                chart1.Series["SQL Server Process"].Color = Color.Red;

                chart1.Series["System Idle Process"].ChartType = SeriesChartType.FastLine;
                chart1.Series["System Idle Process"].Color = Color.Green;

                chart1.Series["Other Processes"].ChartType = SeriesChartType.FastLine;
                chart1.Series["Other Processes"].Color = Color.Yellow;
            }
        }

        #endregion

    }
}
