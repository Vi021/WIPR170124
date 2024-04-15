namespace WIPR170124
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.txtBox_Username = new System.Windows.Forms.TextBox();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Login = new System.Windows.Forms.Button();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lnkLbl = new System.Windows.Forms.LinkLabel();
            this.Login_Icon = new System.Windows.Forms.PictureBox();
            this.pctBShowPass = new System.Windows.Forms.PictureBox();
            this.ErPr_1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.templbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Login_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPr_1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Location = new System.Drawing.Point(139, 262);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.PasswordChar = '*';
            this.txtBox_Password.Size = new System.Drawing.Size(202, 26);
            this.txtBox_Password.TabIndex = 0;
            this.txtBox_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Password_KeyPress);
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.Location = new System.Drawing.Point(139, 193);
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(202, 26);
            this.txtBox_Username.TabIndex = 1;
            this.txtBox_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Username_KeyPress);
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Location = new System.Drawing.Point(50, 196);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(87, 20);
            this.Label_Username.TabIndex = 2;
            this.Label_Username.Text = "Username:";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(50, 265);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(82, 20);
            this.Label_Password.TabIndex = 3;
            this.Label_Password.Text = "Password:";
            this.Label_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(73, 331);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(99, 34);
            this.Button_Cancel.TabIndex = 4;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Login
            // 
            this.Button_Login.Location = new System.Drawing.Point(215, 331);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(99, 34);
            this.Button_Login.TabIndex = 5;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblText1.Location = new System.Drawing.Point(12, 431);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(150, 17);
            this.lblText1.TabIndex = 7;
            this.lblText1.Text = "Don\'t have a account?";
            // 
            // lnkLbl
            // 
            this.lnkLbl.AutoSize = true;
            this.lnkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lnkLbl.LinkColor = System.Drawing.SystemColors.Desktop;
            this.lnkLbl.Location = new System.Drawing.Point(181, 431);
            this.lnkLbl.Name = "lnkLbl";
            this.lnkLbl.Size = new System.Drawing.Size(93, 17);
            this.lnkLbl.TabIndex = 8;
            this.lnkLbl.TabStop = true;
            this.lnkLbl.Text = "Register now!";
            this.lnkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLbl_LinkClicked);
            // 
            // Login_Icon
            // 
            this.Login_Icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_Icon.BackgroundImage")));
            this.Login_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_Icon.InitialImage = null;
            this.Login_Icon.Location = new System.Drawing.Point(92, 44);
            this.Login_Icon.Name = "Login_Icon";
            this.Login_Icon.Size = new System.Drawing.Size(206, 103);
            this.Login_Icon.TabIndex = 6;
            this.Login_Icon.TabStop = false;
            // 
            // pctBShowPass
            // 
            this.pctBShowPass.BackColor = System.Drawing.SystemColors.Window;
            this.pctBShowPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBShowPass.BackgroundImage")));
            this.pctBShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBShowPass.InitialImage = null;
            this.pctBShowPass.Location = new System.Drawing.Point(322, 265);
            this.pctBShowPass.Name = "pctBShowPass";
            this.pctBShowPass.Size = new System.Drawing.Size(19, 21);
            this.pctBShowPass.TabIndex = 15;
            this.pctBShowPass.TabStop = false;
            this.pctBShowPass.Click += new System.EventHandler(this.pctBShowPass_Click);
            // 
            // ErPr_1
            // 
            this.ErPr_1.ContainerControl = this;
            // 
            // templbl
            // 
            this.templbl.AutoSize = true;
            this.templbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F);
            this.templbl.Location = new System.Drawing.Point(352, 439);
            this.templbl.Name = "templbl";
            this.templbl.Size = new System.Drawing.Size(6, 7);
            this.templbl.TabIndex = 16;
            this.templbl.Text = ".";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 465);
            this.Controls.Add(this.templbl);
            this.Controls.Add(this.pctBShowPass);
            this.Controls.Add(this.lnkLbl);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.Login_Icon);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_Username);
            this.Controls.Add(this.txtBox_Username);
            this.Controls.Add(this.txtBox_Password);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Login_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPr_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.TextBox txtBox_Username;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.PictureBox Login_Icon;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.LinkLabel lnkLbl;
        private System.Windows.Forms.PictureBox pctBShowPass;
        private System.Windows.Forms.ErrorProvider ErPr_1;
        private System.Windows.Forms.Label templbl;
    }
}

