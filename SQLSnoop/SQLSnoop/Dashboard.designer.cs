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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToMicrosoftSQLServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSQLSnoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstDatabases = new System.Windows.Forms.ListBox();
            this.lblDatabaseList = new System.Windows.Forms.Label();
            this.lblRefreshDatabaseList = new System.Windows.Forms.LinkLabel();
            this.lblSqlServerVersion = new System.Windows.Forms.Label();
            this.lblSqlServerName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSqlServer = new System.Windows.Forms.TabPage();
            this.tabDatabase = new System.Windows.Forms.TabPage();
            this.dgdDatabaseFiles = new System.Windows.Forms.DataGridView();
            this.lblDatabaseCompatibility = new System.Windows.Forms.Label();
            this.lblDatabaseCreated = new System.Windows.Forms.Label();
            this.lblDatabaseOwner = new System.Windows.Forms.Label();
            this.lblDatabaseSize = new System.Windows.Forms.Label();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.lblSqlCpuUtilization = new System.Windows.Forms.Label();
            this.lblSystemIdleProcess = new System.Windows.Forms.Label();
            this.lblOtherCpuUtilization = new System.Windows.Forms.Label();
            this.txtSqlCpuUtilization = new System.Windows.Forms.TextBox();
            this.txtSystemIdleProcess = new System.Windows.Forms.TextBox();
            this.txtOtherCpuUtilization = new System.Windows.Forms.TextBox();
            this.tmrSqlServerCpu = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mnuTop.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSqlServer.SuspendLayout();
            this.tabDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDatabaseFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuTop
            // 
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuTop.Location = new System.Drawing.Point(0, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.Size = new System.Drawing.Size(948, 24);
            this.mnuTop.TabIndex = 0;
            this.mnuTop.Text = "menuStrip1";
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
            // lblRefreshDatabaseList
            // 
            this.lblRefreshDatabaseList.AutoSize = true;
            this.lblRefreshDatabaseList.Location = new System.Drawing.Point(137, 31);
            this.lblRefreshDatabaseList.Name = "lblRefreshDatabaseList";
            this.lblRefreshDatabaseList.Size = new System.Drawing.Size(44, 13);
            this.lblRefreshDatabaseList.TabIndex = 3;
            this.lblRefreshDatabaseList.TabStop = true;
            this.lblRefreshDatabaseList.Text = "Refresh";
            this.lblRefreshDatabaseList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefreshDatabaseList_LinkClicked);
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
            this.tabSqlServer.Controls.Add(this.chart1);
            this.tabSqlServer.Controls.Add(this.txtOtherCpuUtilization);
            this.tabSqlServer.Controls.Add(this.txtSystemIdleProcess);
            this.tabSqlServer.Controls.Add(this.txtSqlCpuUtilization);
            this.tabSqlServer.Controls.Add(this.lblOtherCpuUtilization);
            this.tabSqlServer.Controls.Add(this.lblSystemIdleProcess);
            this.tabSqlServer.Controls.Add(this.lblSqlCpuUtilization);
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
            this.tabDatabase.Controls.Add(this.dgdDatabaseFiles);
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
            // dgdDatabaseFiles
            // 
            this.dgdDatabaseFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDatabaseFiles.Location = new System.Drawing.Point(9, 98);
            this.dgdDatabaseFiles.Name = "dgdDatabaseFiles";
            this.dgdDatabaseFiles.Size = new System.Drawing.Size(717, 97);
            this.dgdDatabaseFiles.TabIndex = 10;
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
            // lblSqlCpuUtilization
            // 
            this.lblSqlCpuUtilization.AutoSize = true;
            this.lblSqlCpuUtilization.Location = new System.Drawing.Point(6, 391);
            this.lblSqlCpuUtilization.Name = "lblSqlCpuUtilization";
            this.lblSqlCpuUtilization.Size = new System.Drawing.Size(176, 13);
            this.lblSqlCpuUtilization.TabIndex = 9;
            this.lblSqlCpuUtilization.Text = "SQL Server Process CPU Utilization";
            // 
            // lblSystemIdleProcess
            // 
            this.lblSystemIdleProcess.AutoSize = true;
            this.lblSystemIdleProcess.Location = new System.Drawing.Point(185, 393);
            this.lblSystemIdleProcess.Name = "lblSystemIdleProcess";
            this.lblSystemIdleProcess.Size = new System.Drawing.Size(102, 13);
            this.lblSystemIdleProcess.TabIndex = 10;
            this.lblSystemIdleProcess.Text = "System Idle Process";
            // 
            // lblOtherCpuUtilization
            // 
            this.lblOtherCpuUtilization.AutoSize = true;
            this.lblOtherCpuUtilization.Location = new System.Drawing.Point(290, 393);
            this.lblOtherCpuUtilization.Name = "lblOtherCpuUtilization";
            this.lblOtherCpuUtilization.Size = new System.Drawing.Size(147, 13);
            this.lblOtherCpuUtilization.TabIndex = 11;
            this.lblOtherCpuUtilization.Text = "Other Process CPU Utilization";
            // 
            // txtSqlCpuUtilization
            // 
            this.txtSqlCpuUtilization.Enabled = false;
            this.txtSqlCpuUtilization.Location = new System.Drawing.Point(9, 407);
            this.txtSqlCpuUtilization.Name = "txtSqlCpuUtilization";
            this.txtSqlCpuUtilization.Size = new System.Drawing.Size(173, 20);
            this.txtSqlCpuUtilization.TabIndex = 12;
            // 
            // txtSystemIdleProcess
            // 
            this.txtSystemIdleProcess.Enabled = false;
            this.txtSystemIdleProcess.Location = new System.Drawing.Point(188, 407);
            this.txtSystemIdleProcess.Name = "txtSystemIdleProcess";
            this.txtSystemIdleProcess.Size = new System.Drawing.Size(99, 20);
            this.txtSystemIdleProcess.TabIndex = 13;
            // 
            // txtOtherCpuUtilization
            // 
            this.txtOtherCpuUtilization.Enabled = false;
            this.txtOtherCpuUtilization.Location = new System.Drawing.Point(293, 407);
            this.txtOtherCpuUtilization.Name = "txtOtherCpuUtilization";
            this.txtOtherCpuUtilization.Size = new System.Drawing.Size(144, 20);
            this.txtOtherCpuUtilization.TabIndex = 14;
            // 
            // tmrSqlServerCpu
            // 
            this.tmrSqlServerCpu.Interval = 60000;
            this.tmrSqlServerCpu.Tick += new System.EventHandler(this.tmrSqlServerCpu_Tick);
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGreen;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGreen;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BorderColor = System.Drawing.Color.DarkGreen;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 207);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "SQL Server Process";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "System Idle Process";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Other Processes";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(567, 172);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title1.Name = "Title1";
            title1.Text = "CPU %";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.Name = "Title2";
            title2.Text = "Time";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 520);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblRefreshDatabaseList);
            this.Controls.Add(this.lblDatabaseList);
            this.Controls.Add(this.lstDatabases);
            this.Controls.Add(this.mnuTop);
            this.MainMenuStrip = this.mnuTop;
            this.Name = "Dashboard";
            this.Text = "SQL Snoop";
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSqlServer.ResumeLayout(false);
            this.tabSqlServer.PerformLayout();
            this.tabDatabase.ResumeLayout(false);
            this.tabDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDatabaseFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuTop;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToMicrosoftSQLServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSQLSnoopToolStripMenuItem;
        private System.Windows.Forms.ListBox lstDatabases;
        private System.Windows.Forms.Label lblDatabaseList;
        private System.Windows.Forms.LinkLabel lblRefreshDatabaseList;
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
        private System.Windows.Forms.DataGridView dgdDatabaseFiles;
        private System.Windows.Forms.TextBox txtOtherCpuUtilization;
        private System.Windows.Forms.TextBox txtSystemIdleProcess;
        private System.Windows.Forms.TextBox txtSqlCpuUtilization;
        private System.Windows.Forms.Label lblOtherCpuUtilization;
        private System.Windows.Forms.Label lblSystemIdleProcess;
        private System.Windows.Forms.Label lblSqlCpuUtilization;
        private System.Windows.Forms.Timer tmrSqlServerCpu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}