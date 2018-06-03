namespace RechargeGauntlet.CustomUI
{
    partial class ModemLoading
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
            this.MSProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressText = new System.Windows.Forms.Label();
            this.ModemBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // MSProgressBar
            // 
            this.MSProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MSProgressBar.Location = new System.Drawing.Point(12, 80);
            this.MSProgressBar.Name = "MSProgressBar";
            this.MSProgressBar.Size = new System.Drawing.Size(376, 30);
            this.MSProgressBar.Step = 1;
            this.MSProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.MSProgressBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Searching...";
            // 
            // ProgressText
            // 
            this.ProgressText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressText.Location = new System.Drawing.Point(12, 30);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(376, 46);
            this.ProgressText.TabIndex = 2;
            this.ProgressText.Text = "Initialize Search";
            // 
            // ModemBackgroundWorker
            // 
            this.ModemBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ModemBackgroundWorker_DoWork);
            this.ModemBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ModemBackgroundWorker_RunWorkerCompleted);
            // 
            // ModemLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 121);
            this.Controls.Add(this.ProgressText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MSProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModemLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Searching Modem";
            this.Load += new System.EventHandler(this.ModemLoading_Load);
            this.Shown += new System.EventHandler(this.ModemLoading_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar MSProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProgressText;
        private System.ComponentModel.BackgroundWorker ModemBackgroundWorker;
    }
}