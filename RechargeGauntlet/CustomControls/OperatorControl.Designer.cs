namespace RechargeGauntlet.CustomControls
{
    partial class OperatorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureSignalBar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelCurrentAmount = new System.Windows.Forms.Label();
            this.PirtureOperatorLogo = new System.Windows.Forms.PictureBox();
            this.LabelMobileNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSignalBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PirtureOperatorLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureSignalBar
            // 
            this.PictureSignalBar.Image = global::RechargeGauntlet.Properties.Resources.sigbar5;
            this.PictureSignalBar.Location = new System.Drawing.Point(4, 4);
            this.PictureSignalBar.Name = "PictureSignalBar";
            this.PictureSignalBar.Size = new System.Drawing.Size(64, 64);
            this.PictureSignalBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureSignalBar.TabIndex = 0;
            this.PictureSignalBar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(76, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount";
            // 
            // LabelCurrentAmount
            // 
            this.LabelCurrentAmount.BackColor = System.Drawing.SystemColors.Control;
            this.LabelCurrentAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelCurrentAmount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrentAmount.ForeColor = System.Drawing.Color.Black;
            this.LabelCurrentAmount.Location = new System.Drawing.Point(74, 25);
            this.LabelCurrentAmount.Name = "LabelCurrentAmount";
            this.LabelCurrentAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelCurrentAmount.Size = new System.Drawing.Size(228, 45);
            this.LabelCurrentAmount.TabIndex = 2;
            this.LabelCurrentAmount.Text = "10000000.00";
            this.LabelCurrentAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PirtureOperatorLogo
            // 
            this.PirtureOperatorLogo.Image = global::RechargeGauntlet.Properties.Resources.teletalk;
            this.PirtureOperatorLogo.Location = new System.Drawing.Point(4, 74);
            this.PirtureOperatorLogo.Name = "PirtureOperatorLogo";
            this.PirtureOperatorLogo.Size = new System.Drawing.Size(48, 48);
            this.PirtureOperatorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PirtureOperatorLogo.TabIndex = 3;
            this.PirtureOperatorLogo.TabStop = false;
            // 
            // LabelMobileNumber
            // 
            this.LabelMobileNumber.BackColor = System.Drawing.SystemColors.Control;
            this.LabelMobileNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelMobileNumber.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMobileNumber.ForeColor = System.Drawing.Color.Black;
            this.LabelMobileNumber.Location = new System.Drawing.Point(58, 74);
            this.LabelMobileNumber.Name = "LabelMobileNumber";
            this.LabelMobileNumber.Size = new System.Drawing.Size(244, 49);
            this.LabelMobileNumber.TabIndex = 4;
            this.LabelMobileNumber.Text = "01XXXXXXXXX";
            this.LabelMobileNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OperatorControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LabelMobileNumber);
            this.Controls.Add(this.PirtureOperatorLogo);
            this.Controls.Add(this.LabelCurrentAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureSignalBar);
            this.Name = "OperatorControl";
            this.Size = new System.Drawing.Size(303, 126);
            this.Load += new System.EventHandler(this.OperatorControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureSignalBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PirtureOperatorLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureSignalBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelCurrentAmount;
        private System.Windows.Forms.PictureBox PirtureOperatorLogo;
        private System.Windows.Forms.Label LabelMobileNumber;
    }
}
