namespace WIPR170124
{
    partial class ModifyAccounts
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
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Active = new System.Windows.Forms.Label();
            this.lbl_Admin = new System.Windows.Forms.Label();
            this.grpB_1 = new System.Windows.Forms.GroupBox();
            this.chkB_AdmYes = new System.Windows.Forms.CheckBox();
            this.chkB_ActYes = new System.Windows.Forms.CheckBox();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.lbl_Request = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.grpB_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(32, 36);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(52, 20);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Active
            // 
            this.lbl_Active.AutoSize = true;
            this.lbl_Active.Location = new System.Drawing.Point(86, 39);
            this.lbl_Active.Name = "lbl_Active";
            this.lbl_Active.Size = new System.Drawing.Size(56, 20);
            this.lbl_Active.TabIndex = 1;
            this.lbl_Active.Text = "Active:";
            // 
            // lbl_Admin
            // 
            this.lbl_Admin.AutoSize = true;
            this.lbl_Admin.Location = new System.Drawing.Point(28, 78);
            this.lbl_Admin.Name = "lbl_Admin";
            this.lbl_Admin.Size = new System.Drawing.Size(114, 20);
            this.lbl_Admin.TabIndex = 1;
            this.lbl_Admin.Text = "Administration:";
            // 
            // grpB_1
            // 
            this.grpB_1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpB_1.Controls.Add(this.chkB_AdmYes);
            this.grpB_1.Controls.Add(this.chkB_ActYes);
            this.grpB_1.Controls.Add(this.bttn_Update);
            this.grpB_1.Controls.Add(this.lbl_Request);
            this.grpB_1.Controls.Add(this.lbl_Admin);
            this.grpB_1.Controls.Add(this.lbl_Active);
            this.grpB_1.Location = new System.Drawing.Point(36, 73);
            this.grpB_1.Name = "grpB_1";
            this.grpB_1.Size = new System.Drawing.Size(340, 239);
            this.grpB_1.TabIndex = 2;
            this.grpB_1.TabStop = false;
            this.grpB_1.Text = "Status";
            // 
            // chkB_AdmYes
            // 
            this.chkB_AdmYes.AutoSize = true;
            this.chkB_AdmYes.Location = new System.Drawing.Point(162, 74);
            this.chkB_AdmYes.Name = "chkB_AdmYes";
            this.chkB_AdmYes.Size = new System.Drawing.Size(63, 24);
            this.chkB_AdmYes.TabIndex = 4;
            this.chkB_AdmYes.Text = "Yes";
            this.chkB_AdmYes.UseVisualStyleBackColor = true;
            // 
            // chkB_ActYes
            // 
            this.chkB_ActYes.AutoSize = true;
            this.chkB_ActYes.Location = new System.Drawing.Point(162, 35);
            this.chkB_ActYes.Name = "chkB_ActYes";
            this.chkB_ActYes.Size = new System.Drawing.Size(63, 24);
            this.chkB_ActYes.TabIndex = 4;
            this.chkB_ActYes.Text = "Yes";
            this.chkB_ActYes.UseVisualStyleBackColor = true;
            // 
            // bttn_Update
            // 
            this.bttn_Update.Location = new System.Drawing.Point(125, 175);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(90, 36);
            this.bttn_Update.TabIndex = 2;
            this.bttn_Update.Text = "Update";
            this.bttn_Update.UseVisualStyleBackColor = true;
            this.bttn_Update.Click += new System.EventHandler(this.bttn_Update_Click);
            // 
            // lbl_Request
            // 
            this.lbl_Request.AutoSize = true;
            this.lbl_Request.Location = new System.Drawing.Point(68, 117);
            this.lbl_Request.Name = "lbl_Request";
            this.lbl_Request.Size = new System.Drawing.Size(74, 20);
            this.lbl_Request.TabIndex = 1;
            this.lbl_Request.Text = "Request:";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(12, 340);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(119, 20);
            this.lbl_Status.TabIndex = 5;
            this.lbl_Status.Text = "No change yet..";
            // 
            // ModifyAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 369);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.grpB_1);
            this.Name = "ModifyAccounts";
            this.Text = "ModifyAccounts";
            this.Load += new System.EventHandler(this.ModifyAccounts_Load);
            this.grpB_1.ResumeLayout(false);
            this.grpB_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Active;
        private System.Windows.Forms.Label lbl_Admin;
        private System.Windows.Forms.GroupBox grpB_1;
        internal System.Windows.Forms.CheckBox chkB_ActYes;
        internal System.Windows.Forms.CheckBox chkB_AdmYes;
        internal System.Windows.Forms.Label lbl_Request;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.Label lbl_Status;
    }
}