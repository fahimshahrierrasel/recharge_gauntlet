namespace RechargeGauntlet
{
    partial class MainWindow
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
            this.MainWindowMenuStrip = new System.Windows.Forms.MenuStrip();
            this.rechargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainWindowMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindowMenuStrip
            // 
            this.MainWindowMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechargeToolStripMenuItem,
            this.phoneBookToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainWindowMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainWindowMenuStrip.Name = "MainWindowMenuStrip";
            this.MainWindowMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MainWindowMenuStrip.TabIndex = 1;
            this.MainWindowMenuStrip.Text = "menuStrip";
            // 
            // rechargeToolStripMenuItem
            // 
            this.rechargeToolStripMenuItem.Name = "rechargeToolStripMenuItem";
            this.rechargeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.rechargeToolStripMenuItem.Text = "Recharge";
            this.rechargeToolStripMenuItem.Click += new System.EventHandler(this.rechargeToolStripMenuItem_Click);
            // 
            // phoneBookToolStripMenuItem
            // 
            this.phoneBookToolStripMenuItem.Name = "phoneBookToolStripMenuItem";
            this.phoneBookToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.phoneBookToolStripMenuItem.Text = "Phone Book";
            this.phoneBookToolStripMenuItem.Click += new System.EventHandler(this.phoneBookToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainWindowMenuStrip);
            this.MainMenuStrip = this.MainWindowMenuStrip;
            this.Name = "MainWindow";
            this.Text = "Recharge Gauntlet";
            this.MainWindowMenuStrip.ResumeLayout(false);
            this.MainWindowMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainWindowMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem rechargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

