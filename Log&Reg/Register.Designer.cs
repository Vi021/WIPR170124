namespace WIPR170124
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.Button_Register = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Label_Username = new System.Windows.Forms.Label();
            this.txtBox_Username = new System.Windows.Forms.TextBox();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.pctBShowPass = new System.Windows.Forms.PictureBox();
            this.Login_Icon = new System.Windows.Forms.PictureBox();
            this.ErPr_Username = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctBShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPr_Username)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Register
            // 
            this.Button_Register.Location = new System.Drawing.Point(200, 338);
            this.Button_Register.Name = "Button_Register";
            this.Button_Register.Size = new System.Drawing.Size(99, 34);
            this.Button_Register.TabIndex = 12;
            this.Button_Register.Text = "Register";
            this.Button_Register.UseVisualStyleBackColor = true;
            this.Button_Register.Click += new System.EventHandler(this.Button_Register_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(58, 338);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(99, 34);
            this.Button_Cancel.TabIndex = 11;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(39, 261);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(82, 20);
            this.Label_Password.TabIndex = 10;
            this.Label_Password.Text = "Password:";
            this.Label_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Location = new System.Drawing.Point(39, 192);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(87, 20);
            this.Label_Username.TabIndex = 9;
            this.Label_Username.Text = "Username:";
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.Location = new System.Drawing.Point(128, 189);
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(193, 26);
            this.txtBox_Username.TabIndex = 8;
            this.txtBox_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Username_KeyPress);
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Location = new System.Drawing.Point(128, 258);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.PasswordChar = '*';
            this.txtBox_Password.Size = new System.Drawing.Size(193, 26);
            this.txtBox_Password.TabIndex = 7;
            this.txtBox_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Password_KeyPress);
            // 
            // pctBShowPass
            // 
            this.pctBShowPass.BackColor = System.Drawing.SystemColors.Window;
            this.pctBShowPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBShowPass.BackgroundImage")));
            this.pctBShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBShowPass.InitialImage = null;
            this.pctBShowPass.Location = new System.Drawing.Point(302, 260);
            this.pctBShowPass.Name = "pctBShowPass";
            this.pctBShowPass.Size = new System.Drawing.Size(19, 21);
            this.pctBShowPass.TabIndex = 14;
            this.pctBShowPass.TabStop = false;
            this.pctBShowPass.Click += new System.EventHandler(this.pctBShowPass_Click);
            // 
            // Login_Icon
            // 
            this.Login_Icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_Icon.BackgroundImage")));
            this.Login_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_Icon.Location = new System.Drawing.Point(81, 40);
            this.Login_Icon.Name = "Login_Icon";
            this.Login_Icon.Size = new System.Drawing.Size(206, 103);
            this.Login_Icon.TabIndex = 13;
            this.Login_Icon.TabStop = false;
            // 
            // ErPr_Username
            // 
            this.ErPr_Username.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 428);
            this.Controls.Add(this.pctBShowPass);
            this.Controls.Add(this.Login_Icon);
            this.Controls.Add(this.Button_Register);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_Username);
            this.Controls.Add(this.txtBox_Username);
            this.Controls.Add(this.txtBox_Password);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pctBShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPr_Username)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Login_Icon;
        private System.Windows.Forms.Button Button_Register;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.TextBox txtBox_Username;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.PictureBox pctBShowPass;
        private System.Windows.Forms.ErrorProvider ErPr_Username;
    }
}