namespace RechargeGauntlet
{
    partial class RegistrationForm
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
            this.TextboxName = new System.Windows.Forms.TextBox();
            this.TextboxUsername = new System.Windows.Forms.TextBox();
            this.TextboxPassword = new System.Windows.Forms.TextBox();
            this.TextboxPassConfirm = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextboxName
            // 
            this.TextboxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxName.Location = new System.Drawing.Point(39, 55);
            this.TextboxName.Multiline = true;
            this.TextboxName.Name = "TextboxName";
            this.TextboxName.Size = new System.Drawing.Size(234, 31);
            this.TextboxName.TabIndex = 0;
            // 
            // TextboxUsername
            // 
            this.TextboxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxUsername.Location = new System.Drawing.Point(39, 109);
            this.TextboxUsername.Multiline = true;
            this.TextboxUsername.Name = "TextboxUsername";
            this.TextboxUsername.Size = new System.Drawing.Size(234, 31);
            this.TextboxUsername.TabIndex = 1;
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxPassword.Location = new System.Drawing.Point(39, 163);
            this.TextboxPassword.Multiline = true;
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.PasswordChar = '•';
            this.TextboxPassword.Size = new System.Drawing.Size(234, 31);
            this.TextboxPassword.TabIndex = 2;
            // 
            // TextboxPassConfirm
            // 
            this.TextboxPassConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxPassConfirm.Location = new System.Drawing.Point(39, 217);
            this.TextboxPassConfirm.Multiline = true;
            this.TextboxPassConfirm.Name = "TextboxPassConfirm";
            this.TextboxPassConfirm.PasswordChar = '•';
            this.TextboxPassConfirm.Size = new System.Drawing.Size(234, 31);
            this.TextboxPassConfirm.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Light", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(39, 266);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(118, 41);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(163, 266);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(110, 41);
            this.BtnRegister.TabIndex = 9;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(313, 334);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.TextboxPassConfirm);
            this.Controls.Add(this.TextboxPassword);
            this.Controls.Add(this.TextboxUsername);
            this.Controls.Add(this.TextboxName);
            this.Name = "RegistrationForm";
            this.Text = "Admin Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxName;
        private System.Windows.Forms.TextBox TextboxUsername;
        private System.Windows.Forms.TextBox TextboxPassword;
        private System.Windows.Forms.TextBox TextboxPassConfirm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnRegister;
    }
}