using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQLSnoop
{
    public partial class Connect : Form
    {
        public string connString;

        public Connect()
        {
            InitializeComponent();

            // Populate the server name ComboBox.
            cmbServerName.Items.Add("<Search for SQL Server Instances>");

            // Populate the authentication ComboBox.
            cmbAuthentication.Items.Add("Windows Authentication");
            cmbAuthentication.Items.Add("SQL Server Authentication");
            cmbAuthentication.SelectedIndex = cmbAuthentication.Items.IndexOf("Windows Authentication");
        }

        private void cmbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable or disable authentication fields depending on the suthentication type selected.
            if ((string)cmbAuthentication.SelectedItem == "Windows Authentication")
            {
                lblUserName.Enabled = false;
                lblPassword.Enabled = false;
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
                chkRemeber.Enabled = false;
            }
            else
            {
                lblUserName.Enabled = true;
                lblPassword.Enabled = true;
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
                chkRemeber.Enabled = true;
            }
        }

        private void cmbServerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cmbServerName.SelectedItem == "<Search for SQL Server Instances>")
            {
                // Display searching text.
                cmbServerName.Text = "Searching for SQL Server instances...";

                // Remove all currently listed items from the ComboBox.
                cmbServerName.Items.Clear();

                // Add located servers to the ComboBox.
                DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
                for (int i = 0; i < servers.Rows.Count; i++)
                {
                    // If an instance name was returned add it to the server name.
                    if (!string.IsNullOrWhiteSpace(servers.Rows[i]["InstanceName"].ToString()))
                        cmbServerName.Items.Add(servers.Rows[i]["ServerName"].ToString() + "\\" + servers.Rows[i]["InstanceName"].ToString());
                    else
                        cmbServerName.Items.Add(servers.Rows[i]["ServerName"].ToString());
                }

                // Add the search option back into the ComboBox.
                cmbServerName.Items.Add("<Search for SQL Server Instances>");
                cmbServerName.Text = "";
                cmbServerName.DroppedDown = true;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // Build the connectionString to be used to connect to the SQL Server.
            if (!CreateConnectionString())
                return;

            // Try to connect to the SQL Server and report the results in a MessageBox.
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                // The connection to the SQL Server succeeded.
                MessageBox.Show("Connection Successful.", "Connection Test Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // The connection to the SQL Server failed.
                MessageBox.Show(ex.Message, "Connection Test Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Build the connectionString to be used to connect to the SQL Server.
            if (CreateConnectionString())
                this.Close();
        }

        private bool CreateConnectionString()
        {
            // Check that a server name was selected or supplied.
            if (string.IsNullOrWhiteSpace(cmbServerName.Text) || cmbServerName.Text == "<Search for SQL Server Instances>")
            {
                MessageBox.Show("You did not supply a server name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            if ((string)cmbAuthentication.SelectedItem == "SQL Server Authentication")
            {
                // Check that a user name and password was supplied.
                if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show(@"You did not supply a user name and\or password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                // Build the connection string to use for SQL Server authentication.
                connString = "Data Source=" + cmbServerName.Text + ";User ID=" + txtUserName.Text + ";Password=" + txtPassword.Text;
            }
            else
            {
                // Build the connection string to use for Windows authentication.
                connString = "Data Source=" + cmbServerName.Text + ";Trusted_Connection=yes;";
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
