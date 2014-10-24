namespace SQLSnoop
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToMicrosoftSQLServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSQLSnoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstDatabases = new System.Windows.Forms.ListBox();
            this.lblDatabaseList = new System.Windows.Forms.Label();
            this.lnkRefreshDatabaseList = new System.Windows.Forms.LinkLabel();
            this.lblSqlServerVersion = new System.Windows.Forms.Label();
            this.lblSqlServerName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSqlServer = new System.Windows.Forms.TabPage();
            this.tabDatabase = new System.Windows.Forms.TabPage();
            this.dgvDatabaseFiles = new System.Windows.Forms.DataGridView();
            this.lblDatabaseCompatibility = new System.Windows.Forms.Label();
            this.lblDatabaseCreated = new System.Windows.Forms.Label();
            this.lblDatabaseOwner = new System.Windows.Forms.Label();
            this.lblDatabaseSize = new System.Windows.Forms.Label();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSqlServer.SuspendLayout();
            this.tabDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToMicrosoftSQLServerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // connectToMicrosoftSQLServerToolStripMenuItem
            // 
            this.connectToMicrosoftSQLServerToolStripMenuItem.Name = "connectToMicrosoftSQLServerToolStripMenuItem";
            this.connectToMicrosoftSQLServerToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.connectToMicrosoftSQLServerToolStripMenuItem.Text = "&Connect to Microsoft SQL Server";
            this.connectToMicrosoftSQLServerToolStripMenuItem.Click += new System.EventHandler(this.connectToMicrosoftSQLServerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSQLSnoopToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutSQLSnoopToolStripMenuItem
            // 
            this.aboutSQLSnoopToolStripMenuItem.Name = "aboutSQLSnoopToolStripMenuItem";
            this.aboutSQLSnoopToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.aboutSQLSnoopToolStripMenuItem.Text = "&About SQLSnoop";
            this.aboutSQLSnoopToolStripMenuItem.Click += new System.EventHandler(this.aboutSQLSnoopToolStripMenuItem_Click);
            // 
            // lstDatabases
            // 
            this.lstDatabases.FormattingEnabled = true;
            this.lstDatabases.Location = new System.Drawing.Point(12, 47);
            this.lstDatabases.Name = "lstDatabases";
            this.lstDatabases.Size = new System.Drawing.Size(169, 459);
            this.lstDatabases.TabIndex = 1;
            this.lstDatabases.SelectedIndexChanged += new System.EventHandler(this.lstDatabases_SelectedIndexChanged);
            // 
            // lblDatabaseList
            // 
            this.lblDatabaseList.AutoSize = true;
            this.lblDatabaseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseList.Location = new System.Drawing.Point(12, 31);
            this.lblDatabaseList.Name = "lblDatabaseList";
            this.lblDatabaseList.Size = new System.Drawing.Size(67, 13);
            this.lblDatabaseList.TabIndex = 2;
            this.lblDatabaseList.Text = "Databases";
            // 
            // lnkRefreshDatabaseList
            // 
            this.lnkRefreshDatabaseList.AutoSize = true;
            this.lnkRefreshDatabaseList.Location = new System.Drawing.Point(137, 31);
            this.lnkRefreshDatabaseList.Name = "lnkRefreshDatabaseList";
            this.lnkRefreshDatabaseList.Size = new System.Drawing.Size(44, 13);
            this.lnkRefreshDatabaseList.TabIndex = 3;
            this.lnkRefreshDatabaseList.TabStop = true;
            this.lnkRefreshDatabaseList.Text = "Refresh";
            this.lnkRefreshDatabaseList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefreshDatabaseList_LinkClicked);
            // 
            // lblSqlServerVersion
            // 
            this.lblSqlServerVersion.AutoSize = true;
            this.lblSqlServerVersion.Location = new System.Drawing.Point(6, 24);
            this.lblSqlServerVersion.Name = "lblSqlServerVersion";
            this.lblSqlServerVersion.Size = new System.Drawing.Size(268, 13);
            this.lblSqlServerVersion.TabIndex = 8;
            this.lblSqlServerVersion.Text = "Database information will be available once connected.";
            // 
            // lblSqlServerName
            // 
            this.lblSqlServerName.AutoSize = true;
            this.lblSqlServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSqlServerName.Location = new System.Drawing.Point(6, 3);
            this.lblSqlServerName.Name = "lblSqlServerName";
            this.lblSqlServerName.Size = new System.Drawing.Size(210, 17);
            this.lblSqlServerName.TabIndex = 7;
            this.lblSqlServerName.Text = "Not connected to a SQL Server.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSqlServer);
            this.tabControl1.Controls.Add(this.tabDatabase);
            this.tabControl1.Location = new System.Drawing.Point(196, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 459);
            this.tabControl1.TabIndex = 9;
            // 
            // tabSqlServer
            // 
            this.tabSqlServer.Controls.Add(this.lblSqlServerVersion);
            this.tabSqlServer.Controls.Add(this.lblSqlServerName);
            this.tabSqlServer.Location = new System.Drawing.Point(4, 22);
            this.tabSqlServer.Name = "tabSqlServer";
            this.tabSqlServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabSqlServer.Size = new System.Drawing.Size(732, 433);
            this.tabSqlServer.TabIndex = 0;
            this.tabSqlServer.Text = "SQL Server";
            this.tabSqlServer.UseVisualStyleBackColor = true;
            // 
            // tabDatabase
            // 
            this.tabDatabase.Controls.Add(this.dgvDatabaseFiles);
            this.tabDatabase.Controls.Add(this.lblDatabaseCompatibility);
            this.tabDatabase.Controls.Add(this.lblDatabaseCreated);
            this.tabDatabase.Controls.Add(this.lblDatabaseOwner);
            this.tabDatabase.Controls.Add(this.lblDatabaseSize);
            this.tabDatabase.Controls.Add(this.lblDatabaseName);
            this.tabDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatabase.Size = new System.Drawing.Size(732, 433);
            this.tabDatabase.TabIndex = 1;
            this.tabDatabase.Text = "Database";
            this.tabDatabase.UseVisualStyleBackColor = true;
            // 
            // dgvDatabaseFiles
            // 
            this.dgvDatabaseFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabaseFiles.Location = new System.Drawing.Point(9, 98);
            this.dgvDatabaseFiles.Name = "dgvDatabaseFiles";
            this.dgvDatabaseFiles.Size = new System.Drawing.Size(717, 97);
            this.dgvDatabaseFiles.TabIndex = 10;
            // 
            // lblDatabaseCompatibility
            // 
            this.lblDatabaseCompatibility.AutoSize = true;
            this.lblDatabaseCompatibility.Location = new System.Drawing.Point(6, 72);
            this.lblDatabaseCompatibility.Name = "lblDatabaseCompatibility";
            this.lblDatabaseCompatibility.Size = new System.Drawing.Size(138, 13);
            this.lblDatabaseCompatibility.TabIndex = 4;
            this.lblDatabaseCompatibility.Text = "Compatability: Not Available";
            // 
            // lblDatabaseCreated
            // 
            this.lblDatabaseCreated.AutoSize = true;
            this.lblDatabaseCreated.Location = new System.Drawing.Point(6, 56);
            this.lblDatabaseCreated.Name = "lblDatabaseCreated";
            this.lblDatabaseCreated.Size = new System.Drawing.Size(113, 13);
            this.lblDatabaseCreated.TabIndex = 3;
            this.lblDatabaseCreated.Text = "Created: Not Available";
            // 
            // lblDatabaseOwner
            // 
            this.lblDatabaseOwner.AutoSize = true;
            this.lblDatabaseOwner.Location = new System.Drawing.Point(6, 40);
            this.lblDatabaseOwner.Name = "lblDatabaseOwner";
            this.lblDatabaseOwner.Size = new System.Drawing.Size(107, 13);
            this.lblDatabaseOwner.TabIndex = 2;
            this.lblDatabaseOwner.Text = "Owner: Not Available";
            // 
            // lblDatabaseSize
            // 
            this.lblDatabaseSize.AutoSize = true;
            this.lblDatabaseSize.Location = new System.Drawing.Point(6, 24);
            this.lblDatabaseSize.Name = "lblDatabaseSize";
            this.lblDatabaseSize.Size = new System.Drawing.Size(96, 13);
            this.lblDatabaseSize.TabIndex = 1;
            this.lblDatabaseSize.Text = "Size: Not Available";
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseName.Location = new System.Drawing.Point(6, 3);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(247, 17);
            this.lblDatabaseName.TabIndex = 0;
            this.lblDatabaseName.Text = "Select a database to view information.";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 520);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lnkRefreshDatabaseList);
            this.Controls.Add(this.lblDatabaseList);
            this.Controls.Add(this.lstDatabases);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "SQL Snoop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSqlServer.ResumeLayout(false);
            this.tabSqlServer.PerformLayout();
            this.tabDatabase.ResumeLayout(false);
            this.tabDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToMicrosoftSQLServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSQLSnoopToolStripMenuItem;
        private System.Windows.Forms.ListBox lstDatabases;
        private System.Windows.Forms.Label lblDatabaseList;
        private System.Windows.Forms.LinkLabel lnkRefreshDatabaseList;
        private System.Windows.Forms.Label lblSqlServerVersion;
        private System.Windows.Forms.Label lblSqlServerName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSqlServer;
        private System.Windows.Forms.TabPage tabDatabase;
        private System.Windows.Forms.Label lblDatabaseCompatibility;
        private System.Windows.Forms.Label lblDatabaseCreated;
        private System.Windows.Forms.Label lblDatabaseOwner;
        private System.Windows.Forms.Label lblDatabaseSize;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.DataGridView dgvDatabaseFiles;
    }
}