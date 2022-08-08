namespace FavCat_Browser
{
    partial class Browser
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avatarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avatarsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.avatarsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vRCTrackerExportOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Magenta;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(691, 426);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.worldsToolStripMenuItem,
            this.avatarsToolStripMenuItem,
            this.socialToolStripMenuItem});
            this.modeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // worldsToolStripMenuItem
            // 
            this.worldsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.worldsToolStripMenuItem.CheckOnClick = true;
            this.worldsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.worldsToolStripMenuItem.Name = "worldsToolStripMenuItem";
            this.worldsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.worldsToolStripMenuItem.Text = "Worlds";
            this.worldsToolStripMenuItem.Click += new System.EventHandler(this.worldsToolStripMenuItem_Click);
            // 
            // avatarsToolStripMenuItem
            // 
            this.avatarsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.avatarsToolStripMenuItem.Checked = true;
            this.avatarsToolStripMenuItem.CheckOnClick = true;
            this.avatarsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.avatarsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.avatarsToolStripMenuItem.Name = "avatarsToolStripMenuItem";
            this.avatarsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.avatarsToolStripMenuItem.Text = "Avatars";
            this.avatarsToolStripMenuItem.Click += new System.EventHandler(this.avatarsToolStripMenuItem_Click);
            // 
            // socialToolStripMenuItem
            // 
            this.socialToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.socialToolStripMenuItem.CheckOnClick = true;
            this.socialToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.socialToolStripMenuItem.Name = "socialToolStripMenuItem";
            this.socialToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.socialToolStripMenuItem.Text = "Social";
            this.socialToolStripMenuItem.Click += new System.EventHandler(this.socialToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avatarsToolStripMenuItem1,
            this.avatarsToolStripMenuItem2,
            this.playersToolStripMenuItem,
            this.vRCTrackerExportOptionsToolStripMenuItem});
            this.exportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.exportToolStripMenuItem.Text = "Export To JSON";
            // 
            // avatarsToolStripMenuItem1
            // 
            this.avatarsToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.avatarsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.avatarsToolStripMenuItem1.Name = "avatarsToolStripMenuItem1";
            this.avatarsToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.avatarsToolStripMenuItem1.Text = "Worlds";
            this.avatarsToolStripMenuItem1.Click += new System.EventHandler(this.avatarsToolStripMenuItem1_Click);
            // 
            // avatarsToolStripMenuItem2
            // 
            this.avatarsToolStripMenuItem2.BackColor = System.Drawing.Color.Black;
            this.avatarsToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.avatarsToolStripMenuItem2.Name = "avatarsToolStripMenuItem2";
            this.avatarsToolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.avatarsToolStripMenuItem2.Text = "Avatars";
            this.avatarsToolStripMenuItem2.Click += new System.EventHandler(this.avatarsToolStripMenuItem2_Click);
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.playersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.playersToolStripMenuItem.Text = "Players";
            this.playersToolStripMenuItem.Click += new System.EventHandler(this.playersToolStripMenuItem_Click);
            // 
            // vRCTrackerExportOptionsToolStripMenuItem
            // 
            this.vRCTrackerExportOptionsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.vRCTrackerExportOptionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vRCTrackerExportOptionsToolStripMenuItem.Name = "vRCTrackerExportOptionsToolStripMenuItem";
            this.vRCTrackerExportOptionsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.vRCTrackerExportOptionsToolStripMenuItem.Text = "VRC Tracker Export";
            this.vRCTrackerExportOptionsToolStripMenuItem.Click += new System.EventHandler(this.vRCTrackerExportOptionsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "FavCat Store DB|favcat-store.db";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Black;
            this.toolTip1.ForeColor = System.Drawing.Color.Magenta;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Browser";
            this.Text = "FavCat Browser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Browser_FormClosed);
            this.Load += new System.EventHandler(this.Browser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avatarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem socialToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avatarsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem avatarsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vRCTrackerExportOptionsToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

