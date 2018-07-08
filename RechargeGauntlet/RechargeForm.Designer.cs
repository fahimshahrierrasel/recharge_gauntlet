namespace RechargeGauntlet
{
    partial class RechargeForm
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblMultiply = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.rdbPrepaid = new System.Windows.Forms.RadioButton();
            this.txtSummery = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdbPostpaid = new System.Windows.Forms.RadioButton();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.PBOperatorLogo = new System.Windows.Forms.PictureBox();
            this.PanelModemConnection = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnPhonebook = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOperatorLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(11, 119);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(287, 61);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.Text = "01XXXXXXXXX";
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            this.txtNumber.Enter += new System.EventHandler(this.txtNumber_Enter);
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            this.txtNumber.Leave += new System.EventHandler(this.txtNumber_Leave);
            // 
            // lblMultiply
            // 
            this.lblMultiply.AutoSize = true;
            this.lblMultiply.BackColor = System.Drawing.Color.Transparent;
            this.lblMultiply.Enabled = false;
            this.lblMultiply.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiply.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMultiply.Location = new System.Drawing.Point(123, 203);
            this.lblMultiply.Name = "lblMultiply";
            this.lblMultiply.Size = new System.Drawing.Size(31, 32);
            this.lblMultiply.TabIndex = 100;
            this.lblMultiply.Text = "X";
            this.lblMultiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(160, 186);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(209, 61);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.Text = "100.00";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.Enter += new System.EventHandler(this.txtAmount_Enter);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // rdbPrepaid
            // 
            this.rdbPrepaid.AutoSize = true;
            this.rdbPrepaid.Checked = true;
            this.rdbPrepaid.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPrepaid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbPrepaid.Location = new System.Drawing.Point(44, 250);
            this.rdbPrepaid.Name = "rdbPrepaid";
            this.rdbPrepaid.Size = new System.Drawing.Size(126, 41);
            this.rdbPrepaid.TabIndex = 4;
            this.rdbPrepaid.TabStop = true;
            this.rdbPrepaid.Text = "P&repaid";
            this.rdbPrepaid.UseVisualStyleBackColor = true;
            // 
            // txtSummery
            // 
            this.txtSummery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSummery.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummery.Location = new System.Drawing.Point(375, 11);
            this.txtSummery.Name = "txtSummery";
            this.txtSummery.Size = new System.Drawing.Size(665, 32);
            this.txtSummery.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 328);
            this.dataGridView1.TabIndex = 13;
            // 
            // rdbPostpaid
            // 
            this.rdbPostpaid.AutoSize = true;
            this.rdbPostpaid.BackColor = System.Drawing.SystemColors.Control;
            this.rdbPostpaid.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPostpaid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbPostpaid.Location = new System.Drawing.Point(193, 250);
            this.rdbPostpaid.Name = "rdbPostpaid";
            this.rdbPostpaid.Size = new System.Drawing.Size(138, 41);
            this.rdbPostpaid.TabIndex = 14;
            this.rdbPostpaid.TabStop = true;
            this.rdbPostpaid.Text = "P&ostpaid";
            this.rdbPostpaid.UseVisualStyleBackColor = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(12, 183);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(105, 61);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // PBOperatorLogo
            // 
            this.PBOperatorLogo.BackColor = System.Drawing.Color.Transparent;
            this.PBOperatorLogo.InitialImage = global::RechargeGauntlet.Properties.Resources.dialpad;
            this.PBOperatorLogo.Location = new System.Drawing.Point(11, 11);
            this.PBOperatorLogo.Name = "PBOperatorLogo";
            this.PBOperatorLogo.Size = new System.Drawing.Size(106, 102);
            this.PBOperatorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBOperatorLogo.TabIndex = 15;
            this.PBOperatorLogo.TabStop = false;
            // 
            // PanelModemConnection
            // 
            this.PanelModemConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelModemConnection.AutoScroll = true;
            this.PanelModemConnection.Location = new System.Drawing.Point(12, 396);
            this.PanelModemConnection.Name = "PanelModemConnection";
            this.PanelModemConnection.Size = new System.Drawing.Size(1028, 147);
            this.PanelModemConnection.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Recharge"});
            this.comboBox1.Location = new System.Drawing.Point(123, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 45);
            this.comboBox1.TabIndex = 101;
            // 
            // BtnPhonebook
            // 
            this.BtnPhonebook.BackgroundImage = global::RechargeGauntlet.Properties.Resources.contact;
            this.BtnPhonebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPhonebook.FlatAppearance.BorderSize = 0;
            this.BtnPhonebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPhonebook.Location = new System.Drawing.Point(305, 119);
            this.BtnPhonebook.Name = "BtnPhonebook";
            this.BtnPhonebook.Size = new System.Drawing.Size(64, 61);
            this.BtnPhonebook.TabIndex = 102;
            this.BtnPhonebook.UseVisualStyleBackColor = true;
            // 
            // BtnSend
            // 
            this.BtnSend.BackgroundImage = global::RechargeGauntlet.Properties.Resources.sendmoney;
            this.BtnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSend.FlatAppearance.BorderSize = 0;
            this.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.Location = new System.Drawing.Point(264, 297);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(105, 80);
            this.BtnSend.TabIndex = 103;
            this.BtnSend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.BackgroundImage = global::RechargeGauntlet.Properties.Resources.report;
            this.BtnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.Location = new System.Drawing.Point(12, 297);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(105, 80);
            this.BtnReport.TabIndex = 104;
            this.BtnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnReport.UseVisualStyleBackColor = true;
            // 
            // RechargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1052, 546);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.BtnPhonebook);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PanelModemConnection);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.PBOperatorLogo);
            this.Controls.Add(this.rdbPostpaid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSummery);
            this.Controls.Add(this.rdbPrepaid);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblMultiply);
            this.Controls.Add(this.txtNumber);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RechargeForm";
            this.Text = "Recharge";
            this.Shown += new System.EventHandler(this.RechargeForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOperatorLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblMultiply;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.RadioButton rdbPrepaid;
        private System.Windows.Forms.TextBox txtSummery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdbPostpaid;
        private System.Windows.Forms.PictureBox PBOperatorLogo;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Panel PanelModemConnection;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnPhonebook;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnReport;
    }
}