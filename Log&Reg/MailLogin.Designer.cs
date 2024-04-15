namespace WIPR170124
{
    partial class MailLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailLogin));
            this.txtB_Email = new System.Windows.Forms.TextBox();
            this.txtB_Password = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.bttn_Cancel = new System.Windows.Forms.Button();
            this.bttn_Login = new System.Windows.Forms.Button();
            this.lLbl_Regis = new System.Windows.Forms.LinkLabel();
            this.lLbl_ForgetPass = new System.Windows.Forms.LinkLabel();
            this.picB_ShowPass = new System.Windows.Forms.PictureBox();
            this.picB_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_QuickL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picB_ShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtB_Email
            // 
            this.txtB_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.txtB_Email.Location = new System.Drawing.Point(74, 284);
            this.txtB_Email.Name = "txtB_Email";
            this.txtB_Email.Size = new System.Drawing.Size(225, 26);
            this.txtB_Email.TabIndex = 1;
            this.txtB_Email.TextChanged += new System.EventHandler(this.txtB_Email_TextChanged);
            this.txtB_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_Username_KeyPress);
            // 
            // txtB_Password
            // 
            this.txtB_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.txtB_Password.Location = new System.Drawing.Point(74, 359);
            this.txtB_Password.Name = "txtB_Password";
            this.txtB_Password.PasswordChar = '*';
            this.txtB_Password.Size = new System.Drawing.Size(225, 26);
            this.txtB_Password.TabIndex = 1;
            this.txtB_Password.TextChanged += new System.EventHandler(this.txtB_Password_TextChanged);
            this.txtB_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_Password_KeyPress);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Email.Location = new System.Drawing.Point(70, 259);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(59, 22);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Password.Location = new System.Drawing.Point(70, 334);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(97, 22);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // bttn_Cancel
            // 
            this.bttn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.bttn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.bttn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttn_Cancel.Location = new System.Drawing.Point(74, 458);
            this.bttn_Cancel.Name = "bttn_Cancel";
            this.bttn_Cancel.Size = new System.Drawing.Size(96, 36);
            this.bttn_Cancel.TabIndex = 4;
            this.bttn_Cancel.Text = "Cancel";
            this.bttn_Cancel.UseVisualStyleBackColor = true;
            this.bttn_Cancel.Click += new System.EventHandler(this.bttn_Cancel_Click);
            // 
            // bttn_Login
            // 
            this.bttn_Login.BackColor = System.Drawing.SystemColors.Control;
            this.bttn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.bttn_Login.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bttn_Login.Location = new System.Drawing.Point(203, 458);
            this.bttn_Login.Name = "bttn_Login";
            this.bttn_Login.Size = new System.Drawing.Size(96, 36);
            this.bttn_Login.TabIndex = 4;
            this.bttn_Login.Text = "Login";
            this.bttn_Login.UseVisualStyleBackColor = true;
            this.bttn_Login.Click += new System.EventHandler(this.bttn_Login_Click);
            // 
            // lLbl_Regis
            // 
            this.lLbl_Regis.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.lLbl_Regis.AutoSize = true;
            this.lLbl_Regis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLbl_Regis.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lLbl_Regis.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.lLbl_Regis.Location = new System.Drawing.Point(247, 549);
            this.lLbl_Regis.Name = "lLbl_Regis";
            this.lLbl_Regis.Size = new System.Drawing.Size(102, 17);
            this.lLbl_Regis.TabIndex = 5;
            this.lLbl_Regis.TabStop = true;
            this.lLbl_Regis.Text = "REGISTER>>>";
            this.lLbl_Regis.VisitedLinkColor = System.Drawing.SystemColors.Desktop;
            this.lLbl_Regis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLbl_Regis_LinkClicked);
            // 
            // lLbl_ForgetPass
            // 
            this.lLbl_ForgetPass.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.lLbl_ForgetPass.AutoSize = true;
            this.lLbl_ForgetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lLbl_ForgetPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lLbl_ForgetPass.Location = new System.Drawing.Point(169, 397);
            this.lLbl_ForgetPass.Name = "lLbl_ForgetPass";
            this.lLbl_ForgetPass.Size = new System.Drawing.Size(121, 17);
            this.lLbl_ForgetPass.TabIndex = 6;
            this.lLbl_ForgetPass.TabStop = true;
            this.lLbl_ForgetPass.Text = "Forget password?";
            this.lLbl_ForgetPass.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lLbl_ForgetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLbl_ForgetPass_LinkClicked);
            // 
            // picB_ShowPass
            // 
            this.picB_ShowPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picB_ShowPass.BackgroundImage = global::WIPR170124.Properties.Resources.openEyeIcon;
            this.picB_ShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_ShowPass.Location = new System.Drawing.Point(273, 362);
            this.picB_ShowPass.Name = "picB_ShowPass";
            this.picB_ShowPass.Size = new System.Drawing.Size(26, 23);
            this.picB_ShowPass.TabIndex = 3;
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
            this.picB_Logo.TabIndex = 0;
            this.picB_Logo.TabStop = false;
            // 
            // lbl_QuickL
            // 
            this.lbl_QuickL.AutoSize = true;
            this.lbl_QuickL.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuickL.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_QuickL.Location = new System.Drawing.Point(12, 555);
            this.lbl_QuickL.Name = "lbl_QuickL";
            this.lbl_QuickL.Size = new System.Drawing.Size(69, 15);
            this.lbl_QuickL.TabIndex = 7;
            this.lbl_QuickL.Text = "QuickLogin";
            this.lbl_QuickL.Click += new System.EventHandler(this.lbl_QuickL_Click);
            // 
            // MailLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 584);
            this.Controls.Add(this.lbl_QuickL);
            this.Controls.Add(this.lLbl_ForgetPass);
            this.Controls.Add(this.lLbl_Regis);
            this.Controls.Add(this.bttn_Login);
            this.Controls.Add(this.bttn_Cancel);
            this.Controls.Add(this.picB_ShowPass);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txtB_Password);
            this.Controls.Add(this.txtB_Email);
            this.Controls.Add(this.picB_Logo);
            this.Name = "MailLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.MailLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picB_ShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picB_Logo;
        private System.Windows.Forms.TextBox txtB_Email;
        private System.Windows.Forms.TextBox txtB_Password;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.PictureBox picB_ShowPass;
        private System.Windows.Forms.Button bttn_Cancel;
        private System.Windows.Forms.Button bttn_Login;
        private System.Windows.Forms.LinkLabel lLbl_Regis;
        private System.Windows.Forms.LinkLabel lLbl_ForgetPass;
        private System.Windows.Forms.Label lbl_QuickL;
    }
}