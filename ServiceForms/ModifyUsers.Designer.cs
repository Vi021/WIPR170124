namespace WIPR170124.ServiceForms
{
    partial class ModifyUsers
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
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.grpB_1 = new System.Windows.Forms.GroupBox();
            this.chkB_ActYes = new System.Windows.Forms.CheckBox();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.lbl_Request = new System.Windows.Forms.Label();
            this.lbl_Active = new System.Windows.Forms.Label();
            this.bttn_Deny = new System.Windows.Forms.Button();
            this.grpB_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(14, 267);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(100, 16);
            this.lbl_Status.TabIndex = 8;
            this.lbl_Status.Text = "No change yet..";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(31, 24);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(29, 18);
            this.lbl_ID.TabIndex = 6;
            this.lbl_ID.Text = "ID:";
            // 
            // grpB_1
            // 
            this.grpB_1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpB_1.Controls.Add(this.chkB_ActYes);
            this.grpB_1.Controls.Add(this.bttn_Deny);
            this.grpB_1.Controls.Add(this.bttn_Update);
            this.grpB_1.Controls.Add(this.lbl_Request);
            this.grpB_1.Controls.Add(this.lbl_Active);
            this.grpB_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpB_1.Location = new System.Drawing.Point(35, 53);
            this.grpB_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpB_1.Name = "grpB_1";
            this.grpB_1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpB_1.Size = new System.Drawing.Size(302, 191);
            this.grpB_1.TabIndex = 7;
            this.grpB_1.TabStop = false;
            this.grpB_1.Text = "Status";
            // 
            // chkB_ActYes
            // 
            this.chkB_ActYes.AutoSize = true;
            this.chkB_ActYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkB_ActYes.Location = new System.Drawing.Point(137, 42);
            this.chkB_ActYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkB_ActYes.Name = "chkB_ActYes";
            this.chkB_ActYes.Size = new System.Drawing.Size(55, 22);
            this.chkB_ActYes.TabIndex = 4;
            this.chkB_ActYes.Text = "Yes";
            this.chkB_ActYes.UseVisualStyleBackColor = true;
            this.chkB_ActYes.CheckedChanged += new System.EventHandler(this.chkB_ActYes_CheckedChanged);
            // 
            // bttn_Update
            // 
            this.bttn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Update.Location = new System.Drawing.Point(60, 134);
            this.bttn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(80, 29);
            this.bttn_Update.TabIndex = 2;
            this.bttn_Update.Text = "Update";
            this.bttn_Update.UseVisualStyleBackColor = true;
            this.bttn_Update.Click += new System.EventHandler(this.bttn_Update_Click);
            // 
            // lbl_Request
            // 
            this.lbl_Request.AutoSize = true;
            this.lbl_Request.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Request.Location = new System.Drawing.Point(49, 89);
            this.lbl_Request.Name = "lbl_Request";
            this.lbl_Request.Size = new System.Drawing.Size(67, 18);
            this.lbl_Request.TabIndex = 1;
            this.lbl_Request.Text = "Request:";
            // 
            // lbl_Active
            // 
            this.lbl_Active.AutoSize = true;
            this.lbl_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Active.Location = new System.Drawing.Point(65, 43);
            this.lbl_Active.Name = "lbl_Active";
            this.lbl_Active.Size = new System.Drawing.Size(51, 18);
            this.lbl_Active.TabIndex = 1;
            this.lbl_Active.Text = "Active:";
            // 
            // bttn_Deny
            // 
            this.bttn_Deny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Deny.Location = new System.Drawing.Point(166, 134);
            this.bttn_Deny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttn_Deny.Name = "bttn_Deny";
            this.bttn_Deny.Size = new System.Drawing.Size(80, 29);
            this.bttn_Deny.TabIndex = 2;
            this.bttn_Deny.Text = "Deny";
            this.bttn_Deny.UseVisualStyleBackColor = true;
            this.bttn_Deny.Click += new System.EventHandler(this.bttn_Deny_Click);
            // 
            // ModifyUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 295);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.grpB_1);
            this.Name = "ModifyUsers";
            this.Text = "Modify User";
            this.Load += new System.EventHandler(this.ModifyUsers_Load);
            this.grpB_1.ResumeLayout(false);
            this.grpB_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Status;
        internal System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.GroupBox grpB_1;
        internal System.Windows.Forms.CheckBox chkB_ActYes;
        private System.Windows.Forms.Button bttn_Update;
        internal System.Windows.Forms.Label lbl_Request;
        private System.Windows.Forms.Label lbl_Active;
        private System.Windows.Forms.Button bttn_Deny;
    }
}