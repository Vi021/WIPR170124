namespace WIPR170124
{
    partial class MailRegis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailRegis));
            this.bttn_Register = new System.Windows.Forms.Button();
            this.bttn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txtB_Password = new System.Windows.Forms.TextBox();
            this.txtB_Email = new System.Windows.Forms.TextBox();
            this.txtB_OTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_GetOTP = new System.Windows.Forms.Button();
            this.lbl_OTPInfo = new System.Windows.Forms.Label();
            this.picB_ShowPass = new System.Windows.Forms.PictureBox();
            this.picB_Logo = new System.Windows.Forms.PictureBox();
            this.picB_ShowPass2 = new System.Windows.Forms.PictureBox();
            this.lbl_RetypePass = new System.Windows.Forms.Label();
            this.txtB_RetypePass = new System.Windows.Forms.TextBox();
            this.erPr_Email = new System.Windows.Forms.ErrorProvider(this.components);
            this.erPr_Pass = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picB_ShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_ShowPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Pass)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_Register
            // 
            this.bttn_Register.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.bttn_Register.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bttn_Register.Location = new System.Drawing.Point(203, 558);
            this.bttn_Register.Name = "bttn_Register";
            this.bttn_Register.Size = new System.Drawing.Size(96, 36);
            this.bttn_Register.TabIndex = 11;
            this.bttn_Register.Text = "Register";
            this.bttn_Register.UseVisualStyleBackColor = true;
            this.bttn_Register.Click += new System.EventHandler(this.bttn_Register_Click);
            // 
            // bttn_Cancel
            // 
            this.bttn_Cancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.bttn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttn_Cancel.Location = new System.Drawing.Point(74, 558);
            this.bttn_Cancel.Name = "bttn_Cancel";
            this.bttn_Cancel.Size = new System.Drawing.Size(96, 36);
            this.bttn_Cancel.TabIndex = 12;
            this.bttn_Cancel.Text = "Cancel";
            this.bttn_Cancel.UseVisualStyleBackColor = true;
            this.bttn_Cancel.Click += new System.EventHandler(this.bttn_Cancel_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Password.Location = new System.Drawing.Point(70, 411);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(97, 22);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Email.Location = new System.Drawing.Point(70, 259);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(59, 22);
            this.lbl_Email.TabIndex = 9;
            this.lbl_Email.Text = "Email";
            // 
            // txtB_Password
            // 
            this.txtB_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.txtB_Password.Location = new System.Drawing.Point(74, 436);
            this.txtB_Password.Name = "txtB_Password";
            this.txtB_Password.PasswordChar = '*';
            this.txtB_Password.Size = new System.Drawing.Size(225, 26);
            this.txtB_Password.TabIndex = 6;
            this.txtB_Password.TextChanged += new System.EventHandler(this.txtB_Password_TextChanged);
            // 
            // txtB_Email
            // 
            this.txtB_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.txtB_Email.Location = new System.Drawing.Point(74, 284);
            this.txtB_Email.Name = "txtB_Email";
            this.txtB_Email.Size = new System.Drawing.Size(225, 26);
            this.txtB_Email.TabIndex = 7;
            this.txtB_Email.TextChanged += new System.EventHandler(this.txtB_Email_TextChanged);
            // 
            // txtB_OTP
            // 
            this.txtB_OTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_OTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.txtB_OTP.Location = new System.Drawing.Point(74, 358);
            this.txtB_OTP.Name = "txtB_OTP";
            this.txtB_OTP.Size = new System.Drawing.Size(130, 26);
            this.txtB_OTP.TabIndex = 13;
            this.txtB_OTP.TextChanged += new System.EventHandler(this.txtB_OTP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(70, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "OTP";
            // 
            // bttn_GetOTP
            // 
            this.bttn_GetOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_GetOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttn_GetOTP.Location = new System.Drawing.Point(210, 358);
            this.bttn_GetOTP.Name = "bttn_GetOTP";
            this.bttn_GetOTP.Size = new System.Drawing.Size(89, 33);
            this.bttn_GetOTP.TabIndex = 15;
            this.bttn_GetOTP.Text = "Get OTP";
            this.bttn_GetOTP.UseVisualStyleBackColor = true;
            this.bttn_GetOTP.Click += new System.EventHandler(this.bttn_GetOTP_Click);
            // 
            // lbl_OTPInfo
            // 
            this.lbl_OTPInfo.AutoSize = true;
            this.lbl_OTPInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbl_OTPInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_OTPInfo.Location = new System.Drawing.Point(3, 630);
            this.lbl_OTPInfo.Name = "lbl_OTPInfo";
            this.lbl_OTPInfo.Size = new System.Drawing.Size(93, 17);
            this.lbl_OTPInfo.TabIndex = 16;
            this.lbl_OTPInfo.Text = "Getting info...";
            // 
            // picB_ShowPass
            // 
            this.picB_ShowPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picB_ShowPass.BackgroundImage = global::WIPR170124.Properties.Resources.openEyeIcon;
            this.picB_ShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_ShowPass.Location = new System.Drawing.Point(273, 439);
            this.picB_ShowPass.Name = "picB_ShowPass";
            this.picB_ShowPass.Size = new System.Drawing.Size(26, 23);
            this.picB_ShowPass.TabIndex = 10;
            this.picB_ShowPass.TabStop = false;
            this.picB_ShowPass.Click += new System.EventHandler(this.picB_ShowPass_Click);
            // 
            // picB_Logo
            // 
            this.picB_Logo.BackColor = System.Drawing.SystemColors.Control;
            this.picB_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_Logo.BackgroundImage")));
            this.picB_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_Logo.InitialImage = null;
            this.picB_Logo.Location = new System.Drawing.Point(118, 45);
            this.picB_Logo.Name = "picB_Logo";
            this.picB_Logo.Size = new System.Drawing.Size(141, 167);
            this.picB_Logo.TabIndex = 5;
            this.picB_Logo.TabStop = false;
            // 
            // picB_ShowPass2
            // 
            this.picB_ShowPass2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picB_ShowPass2.BackgroundImage = global::WIPR170124.Properties.Resources.openEyeIcon;
            this.picB_ShowPass2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_ShowPass2.Location = new System.Drawing.Point(273, 502);
            this.picB_ShowPass2.Name = "picB_ShowPass2";
            this.picB_ShowPass2.Size = new System.Drawing.Size(26, 23);
            this.picB_ShowPass2.TabIndex = 24;
            this.picB_ShowPass2.TabStop = false;
            this.picB_ShowPass2.Click += new System.EventHandler(this.picB_ShowPass2_Click);
            // 
            // lbl_RetypePass
            // 
            this.lbl_RetypePass.AutoSize = true;
            this.lbl_RetypePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RetypePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_RetypePass.Location = new System.Drawing.Point(70, 474);
            this.lbl_RetypePass.Name = "lbl_RetypePass";
            this.lbl_RetypePass.Size = new System.Drawing.Size(164, 22);
            this.lbl_RetypePass.TabIndex = 23;
            this.lbl_RetypePass.Text = "Retype password";
            // 
            // txtB_RetypePass
            // 
            this.txtB_RetypePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_RetypePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.txtB_RetypePass.Location = new System.Drawing.Point(74, 499);
            this.txtB_RetypePass.Name = "txtB_RetypePass";
            this.txtB_RetypePass.PasswordChar = '*';
            this.txtB_RetypePass.Size = new System.Drawing.Size(225, 26);
            this.txtB_RetypePass.TabIndex = 22;
            this.txtB_RetypePass.TextChanged += new System.EventHandler(this.txtB_RetypePass_TextChanged);
            // 
            // erPr_Email
            // 
            this.erPr_Email.ContainerControl = this;
            // 
            // erPr_Pass
            // 
            this.erPr_Pass.ContainerControl = this;
            // 
            // MailRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 656);
            this.Controls.Add(this.picB_ShowPass2);
            this.Controls.Add(this.lbl_RetypePass);
            this.Controls.Add(this.txtB_RetypePass);
            this.Controls.Add(this.lbl_OTPInfo);
            this.Controls.Add(this.bttn_GetOTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB_OTP);
            this.Controls.Add(this.bttn_Register);
            this.Controls.Add(this.bttn_Cancel);
            this.Controls.Add(this.picB_ShowPass);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txtB_Password);
            this.Controls.Add(this.txtB_Email);
            this.Controls.Add(this.picB_Logo);
            this.Name = "MailRegis";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.MailRegis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picB_ShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_ShowPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Pass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Register;
        private System.Windows.Forms.Button bttn_Cancel;
        private System.Windows.Forms.PictureBox picB_ShowPass;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txtB_Password;
        private System.Windows.Forms.TextBox txtB_Email;
        private System.Windows.Forms.PictureBox picB_Logo;
        private System.Windows.Forms.TextBox txtB_OTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_GetOTP;
        private System.Windows.Forms.Label lbl_OTPInfo;
        private System.Windows.Forms.PictureBox picB_ShowPass2;
        private System.Windows.Forms.Label lbl_RetypePass;
        private System.Windows.Forms.TextBox txtB_RetypePass;
        private System.Windows.Forms.ErrorProvider erPr_Email;
        private System.Windows.Forms.ErrorProvider erPr_Pass;
    }
}