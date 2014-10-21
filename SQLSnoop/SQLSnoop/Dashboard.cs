using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLSnoop
{
    public partial class Dashboard : Form
    {
        public string connString;

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
            }
        }

        private void lnkRefreshDatabaseList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Repopulate CheckedListBox with a list of databases from the selected SQL Server.
            PopulateDatabaseList();
        }

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

        #endregion

        #region MenuStrip

        private void connectToMicrosoftSQLServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the Form named Connect where SQL Server connection information is obtained from.
            Connect connectForm = new Connect();
            connectForm.ShowDialog();

            // Get the connString variable containing the connection string built using the from connectForm.
            connString = connectForm.connString;
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

    }
}
