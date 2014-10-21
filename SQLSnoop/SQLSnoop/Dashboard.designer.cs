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
            this.menuStrip1.SuspendLayout();
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 520);
            this.Controls.Add(this.lnkRefreshDatabaseList);
            this.Controls.Add(this.lblDatabaseList);
            this.Controls.Add(this.lstDatabases);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "SQL Snoop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}