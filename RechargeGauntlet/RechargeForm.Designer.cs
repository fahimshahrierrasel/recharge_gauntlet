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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnPhoneBook = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.txtSummery = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdbPostpaid = new System.Windows.Forms.RadioButton();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.PBOperatorLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOperatorLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(12, 11);
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
            this.lblMultiply.Location = new System.Drawing.Point(92, 89);
            this.lblMultiply.Name = "lblMultiply";
            this.lblMultiply.Size = new System.Drawing.Size(31, 32);
            this.lblMultiply.TabIndex = 100;
            this.lblMultiply.Text = "X";
            this.lblMultiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(120, 75);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(179, 61);
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
            this.rdbPrepaid.Location = new System.Drawing.Point(12, 142);
            this.rdbPrepaid.Name = "rdbPrepaid";
            this.rdbPrepaid.Size = new System.Drawing.Size(126, 41);
            this.rdbPrepaid.TabIndex = 4;
            this.rdbPrepaid.TabStop = true;
            this.rdbPrepaid.Text = "P&repaid";
            this.rdbPrepaid.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(12, 189);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(290, 60);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnPhoneBook
            // 
            this.btnPhoneBook.AutoSize = true;
            this.btnPhoneBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnPhoneBook.FlatAppearance.BorderSize = 0;
            this.btnPhoneBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoneBook.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoneBook.ForeColor = System.Drawing.Color.White;
            this.btnPhoneBook.Location = new System.Drawing.Point(12, 255);
            this.btnPhoneBook.Name = "btnPhoneBook";
            this.btnPhoneBook.Size = new System.Drawing.Size(290, 60);
            this.btnPhoneBook.TabIndex = 4;
            this.btnPhoneBook.Text = "Phone &Book";
            this.btnPhoneBook.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(12, 321);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(290, 60);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "&Report";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // txtSummery
            // 
            this.txtSummery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSummery.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummery.Location = new System.Drawing.Point(347, 11);
            this.txtSummery.Name = "txtSummery";
            this.txtSummery.Size = new System.Drawing.Size(594, 32);
            this.txtSummery.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 328);
            this.dataGridView1.TabIndex = 13;
            // 
            // rdbPostpaid
            // 
            this.rdbPostpaid.AutoSize = true;
            this.rdbPostpaid.BackColor = System.Drawing.SystemColors.Control;
            this.rdbPostpaid.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPostpaid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbPostpaid.Location = new System.Drawing.Point(161, 142);
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
            this.txtQuantity.Location = new System.Drawing.Point(12, 75);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(80, 61);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // PBOperatorLogo
            // 
            this.PBOperatorLogo.BackColor = System.Drawing.Color.Transparent;
            this.PBOperatorLogo.InitialImage = null;
            this.PBOperatorLogo.Location = new System.Drawing.Point(305, 11);
            this.PBOperatorLogo.Name = "PBOperatorLogo";
            this.PBOperatorLogo.Size = new System.Drawing.Size(36, 36);
            this.PBOperatorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBOperatorLogo.TabIndex = 15;
            this.PBOperatorLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 147);
            this.panel1.TabIndex = 17;
            // 
            // RechargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(953, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.PBOperatorLogo);
            this.Controls.Add(this.rdbPostpaid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSummery);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnPhoneBook);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rdbPrepaid);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblMultiply);
            this.Controls.Add(this.txtNumber);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RechargeForm";
            this.Text = "Recharge";
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
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnPhoneBook;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txtSummery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdbPostpaid;
        private System.Windows.Forms.PictureBox PBOperatorLogo;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Panel panel1;
    }
}