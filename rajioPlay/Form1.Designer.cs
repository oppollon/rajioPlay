namespace rajioPlay
{
    partial class rajio
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rajio));
            this.ntfPlayer = new System.Windows.Forms.NotifyIcon(this.components);
            this.rajioMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.radioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.edenOfTheWestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listenmoeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duckDuckGoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rajioMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ntfPlayer
            // 
            this.ntfPlayer.ContextMenuStrip = this.rajioMenu;
            this.ntfPlayer.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfPlayer.Icon")));
            this.ntfPlayer.Text = "uwu I\'m currently watching you, sicko pedo";
            this.ntfPlayer.Visible = true;
            // 
            // rajioMenu
            // 
            this.rajioMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radioToolStripMenuItem,
            this.currentSongToolStripMenuItem,
            this.playToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.rajioMenu.Name = "rajioMenu";
            this.rajioMenu.Size = new System.Drawing.Size(181, 114);
            // 
            // radioToolStripMenuItem
            // 
            this.radioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radioToolStripMenuItem1,
            this.edenOfTheWestToolStripMenuItem,
            this.listenmoeToolStripMenuItem});
            this.radioToolStripMenuItem.Name = "radioToolStripMenuItem";
            this.radioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.radioToolStripMenuItem.Text = "Radio";
            // 
            // radioToolStripMenuItem1
            // 
            this.radioToolStripMenuItem1.Name = "radioToolStripMenuItem1";
            this.radioToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.radioToolStripMenuItem1.Text = "r/a/dio";
            this.radioToolStripMenuItem1.Click += new System.EventHandler(this.radioToolStripMenuItem1_Click);
            // 
            // edenOfTheWestToolStripMenuItem
            // 
            this.edenOfTheWestToolStripMenuItem.Name = "edenOfTheWestToolStripMenuItem";
            this.edenOfTheWestToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.edenOfTheWestToolStripMenuItem.Text = "eden";
            this.edenOfTheWestToolStripMenuItem.Click += new System.EventHandler(this.edenOfTheWestToolStripMenuItem_Click);
            // 
            // listenmoeToolStripMenuItem
            // 
            this.listenmoeToolStripMenuItem.Name = "listenmoeToolStripMenuItem";
            this.listenmoeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.listenmoeToolStripMenuItem.Text = "listen.moe";
            this.listenmoeToolStripMenuItem.Click += new System.EventHandler(this.listenmoeToolStripMenuItem_Click);
            // 
            // currentSongToolStripMenuItem
            // 
            this.currentSongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.currentSongToolStripMenuItem.Name = "currentSongToolStripMenuItem";
            this.currentSongToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.currentSongToolStripMenuItem.Text = "Current song";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duckDuckGoToolStripMenuItem,
            this.youTubeToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // duckDuckGoToolStripMenuItem
            // 
            this.duckDuckGoToolStripMenuItem.Name = "duckDuckGoToolStripMenuItem";
            this.duckDuckGoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.duckDuckGoToolStripMenuItem.Text = "DuckDuckGo";
            this.duckDuckGoToolStripMenuItem.Click += new System.EventHandler(this.duckDuckGoToolStripMenuItem_Click);
            // 
            // youTubeToolStripMenuItem
            // 
            this.youTubeToolStripMenuItem.Name = "youTubeToolStripMenuItem";
            this.youTubeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.youTubeToolStripMenuItem.Text = "YouTube";
            this.youTubeToolStripMenuItem.Click += new System.EventHandler(this.youTubeToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playToolStripMenuItem.Text = "Stop";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // rajio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 96);
            this.Name = "rajio";
            this.Text = "rajio";
            this.rajioMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ntfPlayer;
        private System.Windows.Forms.ContextMenuStrip rajioMenu;
        private System.Windows.Forms.ToolStripMenuItem radioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem edenOfTheWestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listenmoeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duckDuckGoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youTubeToolStripMenuItem;
    }
}

