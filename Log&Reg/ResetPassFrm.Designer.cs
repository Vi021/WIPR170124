namespace WIPR170124
{
    partial class ResetPassFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassFrm));
            this.bttn_GetOTP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB_OTP = new System.Windows.Forms.TextBox();
            this.bttn_Done = new System.Windows.Forms.Button();
            this.bttn_Cancel = new System.Windows.Forms.Button();
            this.picB_ShowPass = new System.Windows.Forms.PictureBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txtB_Password = new System.Windows.Forms.TextBox();
            this.txtB_Email = new System.Windows.Forms.TextBox();
            this.picB_Logo = new System.Windows.Forms.PictureBox();
            this.txtB_RetypePass = new System.Windows.Forms.TextBox();
            this.lbl_RetypePass = new System.Windows.Forms.Label();
            this.picB_ShowPass2 = new System.Windows.Forms.PictureBox();
            this.lbl_OTPInfo = new System.Windows.Forms.Label();
            this.erPr_Pass = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picB_ShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_ShowPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Pass)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_GetOTP
            // 
            this.bttn_GetOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_GetOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttn_GetOTP.Location = new System.Drawing.Point(211, 362);
            this.bttn_GetOTP.Name = "bttn_GetOTP";
            this.bttn_GetOTP.Size = new System.Drawing.Size(89, 33);
            this.bttn_GetOTP.TabIndex = 26;
            this.bttn_GetOTP.Text = "Get OTP";
            this.bttn_GetOTP.UseVisualStyleBackColor = true;
            this.bttn_GetOTP.Click += new System.EventHandler(this.bttn_GetOTP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(71, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "OTP";
            // 
            // txtB_OTP
            // 
            this.txtB_OTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_OTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.txtB_OTP.Location = new System.Drawing.Point(75, 362);
            this.txtB_OTP.Name = "txtB_OTP";
            this.txtB_OTP.Size = new System.Drawing.Size(130, 26);
            this.txtB_OTP.TabIndex = 24;
            this.txtB_OTP.TextChanged += new System.EventHandler(this.txtB_OTP_TextChanged);
            // 
            // bttn_Done
            // 
            this.bttn_Done.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttn_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.bttn_Done.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bttn_Done.Location = new System.Drawing.Point(204, 554);
            this.bttn_Done.Name = "bttn_Done";
            this.bttn_Done.Size = new System.Drawing.Size(96, 36);
            this.bttn_Done.TabIndex = 22;
            this.bttn_Done.Text = "Done";
            this.bttn_Done.UseVisualStyleBackColor = true;
            this.bttn_Done.Click += new System.EventHandler(this.bttn_Done_Click);
            // 
            // bttn_Cancel
            // 
            this.bttn_Cancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.bttn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttn_Cancel.Location = new System.Drawing.Point(75, 554);
            this.bttn_Cancel.Name = "bttn_Cancel";
            this.bttn_Cancel.Size = new System.Drawing.Size(96, 36);
            this.bttn_Cancel.TabIndex = 23;
            this.bttn_Cancel.Text = "Cancel";
            this.bttn_Cancel.UseVisualStyleBackColor = true;
            this.bttn_Cancel.Click += new System.EventHandler(this.bttn_Cancel_Click);
            // 
            // picB_ShowPass
            // 
            this.picB_ShowPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picB_ShowPass.BackgroundImage = global::WIPR170124.Properties.Resources.openEyeIcon;
            this.picB_ShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_ShowPass.Location = new System.Drawing.Point(274, 439);
            this.picB_ShowPass.Name = "picB_ShowPass";
            this.picB_ShowPass.Size = new System.Drawing.Size(26, 23);
            this.picB_ShowPass.TabIndex = 21;
            this.picB_ShowPass.TabStop = false;
            this.picB_ShowPass.Click += new System.EventHandler(this.picB_ShowPass_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Password.Location = new System.Drawing.Point(71, 411);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(97, 22);
            this.lbl_Password.TabIndex = 19;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Email.Location = new System.Drawing.Point(71, 261);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(59, 22);
            this.lbl_Email.TabIndex = 20;
            this.lbl_Email.Text = "Email";
            // 
            // txtB_Password
            // 
            this.txtB_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.txtB_Password.Location = new System.Drawing.Point(75, 436);
            this.txtB_Password.Name = "txtB_Password";
            this.txtB_Password.PasswordChar = '*';
            this.txtB_Password.Size = new System.Drawing.Size(225, 26);
            this.txtB_Password.TabIndex = 17;
            this.txtB_Password.TextChanged += new System.EventHandler(this.txtB_Password_TextChanged);
            // 
            // txtB_Email
            // 
            this.txtB_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.txtB_Email.Location = new System.Drawing.Point(75, 286);
            this.txtB_Email.Name = "txtB_Email";
            this.txtB_Email.Size = new System.Drawing.Size(225, 26);
            this.txtB_Email.TabIndex = 18;
            this.txtB_Email.TextChanged += new System.EventHandler(this.txtB_Email_TextChanged);
            // 
            // picB_Logo
            // 
            this.picB_Logo.BackColor = System.Drawing.SystemColors.Control;
            this.picB_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_Logo.BackgroundImage")));
            this.picB_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_Logo.InitialImage = null;
            this.picB_Logo.Location = new System.Drawing.Point(119, 47);
            this.picB_Logo.Name = "picB_Logo";
            this.picB_Logo.Size = new System.Drawing.Size(141, 167);
            this.picB_Logo.TabIndex = 16;
            this.picB_Logo.TabStop = false;
            // 
            // txtB_RetypePass
            // 
            this.txtB_RetypePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_RetypePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.txtB_RetypePass.Location = new System.Drawing.Point(75, 496);
            this.txtB_RetypePass.Name = "txtB_RetypePass";
            this.txtB_RetypePass.PasswordChar = '*';
            this.txtB_RetypePass.Size = new System.Drawing.Size(225, 26);
            this.txtB_RetypePass.TabIndex = 17;
            this.txtB_RetypePass.TextChanged += new System.EventHandler(this.txtB_RetypePass_TextChanged);
            // 
            // lbl_RetypePass
            // 
            this.lbl_RetypePass.AutoSize = true;
            this.lbl_RetypePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RetypePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_RetypePass.Location = new System.Drawing.Point(71, 471);
            this.lbl_RetypePass.Name = "lbl_RetypePass";
            this.lbl_RetypePass.Size = new System.Drawing.Size(164, 22);
            this.lbl_RetypePass.TabIndex = 19;
            this.lbl_RetypePass.Text = "Retype password";
            // 
            // picB_ShowPass2
            // 
            this.picB_ShowPass2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picB_ShowPass2.BackgroundImage = global::WIPR170124.Properties.Resources.openEyeIcon;
            this.picB_ShowPass2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_ShowPass2.Location = new System.Drawing.Point(274, 499);
            this.picB_ShowPass2.Name = "picB_ShowPass2";
            this.picB_ShowPass2.Size = new System.Drawing.Size(26, 23);
            this.picB_ShowPass2.TabIndex = 21;
            this.picB_ShowPass2.TabStop = false;
            this.picB_ShowPass2.Click += new System.EventHandler(this.picB_ShowPass2_Click);
            // 
            // lbl_OTPInfo
            // 
            this.lbl_OTPInfo.AutoSize = true;
            this.lbl_OTPInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbl_OTPInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_OTPInfo.Location = new System.Drawing.Point(3, 629);
            this.lbl_OTPInfo.Name = "lbl_OTPInfo";
            this.lbl_OTPInfo.Size = new System.Drawing.Size(93, 17);
            this.lbl_OTPInfo.TabIndex = 27;
            this.lbl_OTPInfo.Text = "Getting info...";
            // 
            // erPr_Pass
            // 
            this.erPr_Pass.ContainerControl = this;
            // 
            // ResetPassFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 655);
            this.Controls.Add(this.lbl_OTPInfo);
            this.Controls.Add(this.bttn_GetOTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB_OTP);
            this.Controls.Add(this.bttn_Done);
            this.Controls.Add(this.bttn_Cancel);
            this.Controls.Add(this.picB_ShowPass2);
            this.Controls.Add(this.picB_ShowPass);
            this.Controls.Add(this.lbl_RetypePass);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txtB_RetypePass);
            this.Controls.Add(this.txtB_Password);
            this.Controls.Add(this.txtB_Email);
            this.Controls.Add(this.picB_Logo);
            this.Name = "ResetPassFrm";
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.ResetPassFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picB_ShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_ShowPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Pass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_GetOTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB_OTP;
        private System.Windows.Forms.Button bttn_Done;
        private System.Windows.Forms.Button bttn_Cancel;
        private System.Windows.Forms.PictureBox picB_ShowPass;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txtB_Password;
        internal System.Windows.Forms.TextBox txtB_Email;
        private System.Windows.Forms.PictureBox picB_Logo;
        private System.Windows.Forms.TextBox txtB_RetypePass;
        private System.Windows.Forms.Label lbl_RetypePass;
        private System.Windows.Forms.PictureBox picB_ShowPass2;
        private System.Windows.Forms.Label lbl_OTPInfo;
        private System.Windows.Forms.ErrorProvider erPr_Pass;
    }
}