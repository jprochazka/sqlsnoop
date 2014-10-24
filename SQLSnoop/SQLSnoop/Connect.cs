using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using System.Diagnostics;

namespace SQLSnoop
{
    public partial class Connect : Form
    {
        public string connString;

        public Connect()
        {
            InitializeComponent();

            // Populate the server name ComboBox with all saved connections from the appdata.xml file. 
            try
            {
                string path = Application.UserAppDataPath + @"\appdata.xml";
                if (File.Exists(path))
                {
                    XDocument appDataXml = XDocument.Load(path);
                    var connections = appDataXml.Descendants("connection").OrderByDescending(x => x.Element("lastConnection").Value).Select(x => new
                    {
                        serverName = x.Element("serverName").Value
                    });

                    foreach (var connection in connections)
                    {
                        cmbServerName.Items.Add(connection.serverName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "XML File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Add the "Search for SQL Server Instances" selection.
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
                chkRemember.Enabled = false;
            }
            else
            {
                lblUserName.Enabled = true;
                lblPassword.Enabled = true;
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
                chkRemember.Enabled = true;
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

                // Add located servers to the ComboBox if they are not already in the list.
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
            {
                // Save connection data that is to remain persitant.
                SaveConnection();

                // Close this form.
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Functions

        private void SaveConnection()
        {
            string path = Application.UserAppDataPath + @"\appdata.xml";

            // Create the users application data file if it does not exist.
            if (!File.Exists(path))
            {
                try
                {
                    XElement appDataXml = new XElement("connections");
                    XDocument xmlDoc = new XDocument(new XDeclaration("1.0", "utf-8", "true"), appDataXml);
                    xmlDoc.Save(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "XML File Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            // Add the current connection information to the users application data file.
            string userName = (!chkRemember.Checked || cmbAuthentication.Text == "Windows Authentication" ? "" : txtUserName.Text);
            string password = (!chkRemember.Checked || cmbAuthentication.Text == "Windows Authentication" ? "" : txtPassword.Text);

            // Check if the serverName already exists in the XML file.
            bool serverNameExists = false;
            try
            {
                XDocument appDataXml = XDocument.Load(path);
                serverNameExists = appDataXml.Descendants("connection").Where(x => x.Element("serverName").Value == cmbServerName.Text).Any();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "XML File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            // If the serverName already update the connection information.
            if (serverNameExists)
            {
                try
                {
                    XDocument appDataXml = XDocument.Load(path);
                    XElement existingConnection = appDataXml.Descendants("connection").Where(x => x.Element("serverName").Value == cmbServerName.Text).FirstOrDefault();
                    existingConnection.Element("sqlAuthentication").Value = (cmbAuthentication.Text == "SQL Server Authentication" ? "true" : "false");
                    existingConnection.Element("userName").Value = userName;
                    existingConnection.Element("password").Value = password;
                    existingConnection.Element("lastConnection").Value = DateTime.Now.ToString();
                    appDataXml.Save(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "XML File Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                try
                {
                    // Insert new connection information.
                    XDocument appDataXml = XDocument.Load(path);
                    XElement newConnection = new XElement("connection");
                    newConnection.SetElementValue("serverName", cmbServerName.Text);
                    newConnection.SetElementValue("sqlAuthentication", (cmbAuthentication.Text == "SQL Server Authentication" ? "true" : "false"));
                    newConnection.SetElementValue("userName", userName);
                    newConnection.SetElementValue("password", password);
                    newConnection.SetElementValue("lastConnection", DateTime.Now.ToString());
                    appDataXml.Element("connections").Add(newConnection);
                    appDataXml.Save(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "XML File Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
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

        #endregion

    }
}
