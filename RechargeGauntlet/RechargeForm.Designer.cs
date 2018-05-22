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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblMultiply = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.rdbPrepaid = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnPhoneBook = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.txtSummery = new System.Windows.Forms.TextBox();
            this.lblSummery = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdbPostpaid = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(13, 13);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(171, 36);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.Text = "017XXXXXXXX";
            this.txtNumber.Enter += new System.EventHandler(this.txtNumberFocus);
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            this.txtNumber.Leave += new System.EventHandler(this.txtNumber_Leave);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(12, 55);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(41, 36);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Text = "1";
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // lblMultiply
            // 
            this.lblMultiply.AutoSize = true;
            this.lblMultiply.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiply.Location = new System.Drawing.Point(59, 56);
            this.lblMultiply.Name = "lblMultiply";
            this.lblMultiply.Size = new System.Drawing.Size(31, 32);
            this.lblMultiply.TabIndex = 2;
            this.lblMultiply.Text = "X";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(93, 55);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(91, 36);
            this.txtAmount.TabIndex = 3;
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
            this.rdbPrepaid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPrepaid.ForeColor = System.Drawing.Color.White;
            this.rdbPrepaid.Location = new System.Drawing.Point(12, 94);
            this.rdbPrepaid.Name = "rdbPrepaid";
            this.rdbPrepaid.Size = new System.Drawing.Size(73, 23);
            this.rdbPrepaid.TabIndex = 4;
            this.rdbPrepaid.TabStop = true;
            this.rdbPrepaid.Text = "Prepaid";
            this.rdbPrepaid.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(12, 123);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(172, 35);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnPhoneBook
            // 
            this.btnPhoneBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnPhoneBook.FlatAppearance.BorderSize = 0;
            this.btnPhoneBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoneBook.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoneBook.ForeColor = System.Drawing.Color.White;
            this.btnPhoneBook.Location = new System.Drawing.Point(12, 164);
            this.btnPhoneBook.Name = "btnPhoneBook";
            this.btnPhoneBook.Size = new System.Drawing.Size(172, 35);
            this.btnPhoneBook.TabIndex = 7;
            this.btnPhoneBook.Text = "Phone Book";
            this.btnPhoneBook.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(12, 205);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(172, 35);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.DarkCyan;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Location = new System.Drawing.Point(191, 13);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(40, 32);
            this.btn.TabIndex = 9;
            this.btn.UseVisualStyleBackColor = false;
            // 
            // txtSummery
            // 
            this.txtSummery.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummery.Location = new System.Drawing.Point(347, 11);
            this.txtSummery.Name = "txtSummery";
            this.txtSummery.Size = new System.Drawing.Size(412, 32);
            this.txtSummery.TabIndex = 10;
            // 
            // lblSummery
            // 
            this.lblSummery.AutoSize = true;
            this.lblSummery.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummery.ForeColor = System.Drawing.Color.White;
            this.lblSummery.Location = new System.Drawing.Point(243, 13);
            this.lblSummery.Name = "lblSummery";
            this.lblSummery.Size = new System.Drawing.Size(95, 25);
            this.lblSummery.TabIndex = 11;
            this.lblSummery.Text = "Summary";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImage = global::RechargeGauntlet.Properties.Resources.Screenshot_3;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.Location = new System.Drawing.Point(765, 11);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(40, 32);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 192);
            this.dataGridView1.TabIndex = 13;
            // 
            // rdbPostpaid
            // 
            this.rdbPostpaid.AutoSize = true;
            this.rdbPostpaid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPostpaid.ForeColor = System.Drawing.Color.White;
            this.rdbPostpaid.Location = new System.Drawing.Point(92, 94);
            this.rdbPostpaid.Name = "rdbPostpaid";
            this.rdbPostpaid.Size = new System.Drawing.Size(79, 23);
            this.rdbPostpaid.TabIndex = 14;
            this.rdbPostpaid.TabStop = true;
            this.rdbPostpaid.Text = "Postpaid";
            this.rdbPostpaid.UseVisualStyleBackColor = true;
            // 
            // RechargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(810, 303);
            this.Controls.Add(this.rdbPostpaid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblSummery);
            this.Controls.Add(this.txtSummery);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnPhoneBook);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rdbPrepaid);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblMultiply);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtNumber);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RechargeForm";
            this.Text = "Recharge Form";
            this.Load += new System.EventHandler(this.RechargeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblMultiply;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.RadioButton rdbPrepaid;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnPhoneBook;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtSummery;
        private System.Windows.Forms.Label lblSummery;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdbPostpaid;
    }
}