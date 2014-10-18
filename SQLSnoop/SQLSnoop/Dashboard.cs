using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

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
