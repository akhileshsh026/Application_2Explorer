namespace Application_2Explorer
{
    partial class Akhilesh_Explorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Akhilesh_Explorer));
            this.Select = new System.Windows.Forms.ListBox();
            this.lstDrives = new System.Windows.Forms.ComboBox();
            this.lstDirectories = new System.Windows.Forms.ListBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.x = new System.Windows.Forms.PictureBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.NewFolder = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteDirectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.x)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Select
            // 
            this.Select.BackColor = System.Drawing.SystemColors.Menu;
            this.Select.FormattingEnabled = true;
            this.Select.ItemHeight = 20;
            this.Select.Location = new System.Drawing.Point(70, 48);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(322, 124);
            this.Select.TabIndex = 0;
            this.Select.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstDrives
            // 
            this.lstDrives.FormattingEnabled = true;
            this.lstDrives.Location = new System.Drawing.Point(118, 88);
            this.lstDrives.Name = "lstDrives";
            this.lstDrives.Size = new System.Drawing.Size(230, 28);
            this.lstDrives.TabIndex = 1;
            this.lstDrives.Text = "              Select a Drive";
            this.lstDrives.SelectedIndexChanged += new System.EventHandler(this.lstDrives_SelectedIndexChanged);
            // 
            // lstDirectories
            // 
            this.lstDirectories.BackColor = System.Drawing.SystemColors.Menu;
            this.lstDirectories.FormattingEnabled = true;
            this.lstDirectories.ItemHeight = 20;
            this.lstDirectories.Location = new System.Drawing.Point(70, 273);
            this.lstDirectories.Name = "lstDirectories";
            this.lstDirectories.Size = new System.Drawing.Size(322, 404);
            this.lstDirectories.TabIndex = 2;
            this.lstDirectories.SelectedIndexChanged += new System.EventHandler(this.lstDirectories_SelectedIndexChanged);
            // 
            // lstFiles
            // 
            this.lstFiles.BackColor = System.Drawing.SystemColors.Menu;
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 20;
            this.lstFiles.Location = new System.Drawing.Point(517, 273);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(322, 404);
            this.lstFiles.TabIndex = 3;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(889, 273);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(350, 404);
            this.x.TabIndex = 4;
            this.x.TabStop = false;
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(517, 77);
            this.txtFolder.Multiline = true;
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(291, 56);
            this.txtFolder.TabIndex = 7;
            // 
            // NewFolder
            // 
            this.NewFolder.Location = new System.Drawing.Point(837, 77);
            this.NewFolder.Name = "NewFolder";
            this.NewFolder.Size = new System.Drawing.Size(160, 56);
            this.NewFolder.TabIndex = 8;
            this.NewFolder.Text = "Create New Folder";
            this.NewFolder.UseVisualStyleBackColor = true;
            this.NewFolder.Click += new System.EventHandler(this.NewFolder_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDirectorToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 64);
            // 
            // deleteDirectorToolStripMenuItem
            // 
            this.deleteDirectorToolStripMenuItem.Name = "deleteDirectorToolStripMenuItem";
            this.deleteDirectorToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.deleteDirectorToolStripMenuItem.Text = "delete Director";
            this.deleteDirectorToolStripMenuItem.Click += new System.EventHandler(this.deleteDirectorToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.refreshToolStripMenuItem.Text = "refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Explorer Designed By Akhilesh";
            this.notifyIcon1.BalloonTipTitle = "Akhilesh Explorer";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Akhilesh_Explorer";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yellowToolStripMenuItem,
            this.redToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(212, 127);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.redToolStripMenuItem.Text = "Red";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Akhilesh_Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1270, 750);
            this.Controls.Add(this.NewFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.x);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.lstDirectories);
            this.Controls.Add(this.lstDrives);
            this.Controls.Add(this.Select);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Akhilesh_Explorer";
            this.Text = "Akhilesh_Explorer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Akhilesh_Explorer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.x)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Select;
        private System.Windows.Forms.ComboBox lstDrives;
        private System.Windows.Forms.ListBox lstDirectories;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.PictureBox x;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button NewFolder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteDirectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

