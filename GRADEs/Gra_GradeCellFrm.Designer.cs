namespace WIPR170124.GRADEs
{
    partial class Gra_GradeCellFrm
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
            this.lbl_SName = new System.Windows.Forms.Label();
            this.lbl_CName = new System.Windows.Forms.Label();
            this.lbl_Sem = new System.Windows.Forms.Label();
            this.lbl_Grade = new System.Windows.Forms.Label();
            this.txtB_SName = new System.Windows.Forms.TextBox();
            this.txtB_CName = new System.Windows.Forms.TextBox();
            this.txtB_Sem = new System.Windows.Forms.TextBox();
            this.txtB_Grade = new System.Windows.Forms.TextBox();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.bttn_Edit = new System.Windows.Forms.Button();
            this.bttn_Remove = new System.Windows.Forms.Button();
            this.erPr_Grade = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Grade)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SName
            // 
            this.lbl_SName.AutoSize = true;
            this.lbl_SName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_SName.Location = new System.Drawing.Point(45, 80);
            this.lbl_SName.Name = "lbl_SName";
            this.lbl_SName.Size = new System.Drawing.Size(103, 18);
            this.lbl_SName.TabIndex = 0;
            this.lbl_SName.Text = "Student name:";
            // 
            // lbl_CName
            // 
            this.lbl_CName.AutoSize = true;
            this.lbl_CName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_CName.Location = new System.Drawing.Point(51, 117);
            this.lbl_CName.Name = "lbl_CName";
            this.lbl_CName.Size = new System.Drawing.Size(102, 18);
            this.lbl_CName.TabIndex = 0;
            this.lbl_CName.Text = "Course name:";
            // 
            // lbl_Sem
            // 
            this.lbl_Sem.AutoSize = true;
            this.lbl_Sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Sem.Location = new System.Drawing.Point(77, 154);
            this.lbl_Sem.Name = "lbl_Sem";
            this.lbl_Sem.Size = new System.Drawing.Size(76, 18);
            this.lbl_Sem.TabIndex = 0;
            this.lbl_Sem.Text = "Semester:";
            // 
            // lbl_Grade
            // 
            this.lbl_Grade.AutoSize = true;
            this.lbl_Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Grade.Location = new System.Drawing.Point(101, 191);
            this.lbl_Grade.Name = "lbl_Grade";
            this.lbl_Grade.Size = new System.Drawing.Size(53, 18);
            this.lbl_Grade.TabIndex = 0;
            this.lbl_Grade.Text = "Grade:";
            // 
            // txtB_SName
            // 
            this.txtB_SName.Location = new System.Drawing.Point(177, 79);
            this.txtB_SName.Name = "txtB_SName";
            this.txtB_SName.Size = new System.Drawing.Size(241, 23);
            this.txtB_SName.TabIndex = 1;
            // 
            // txtB_CName
            // 
            this.txtB_CName.Location = new System.Drawing.Point(177, 116);
            this.txtB_CName.Name = "txtB_CName";
            this.txtB_CName.Size = new System.Drawing.Size(241, 23);
            this.txtB_CName.TabIndex = 1;
            // 
            // txtB_Sem
            // 
            this.txtB_Sem.Location = new System.Drawing.Point(177, 153);
            this.txtB_Sem.Name = "txtB_Sem";
            this.txtB_Sem.Size = new System.Drawing.Size(63, 23);
            this.txtB_Sem.TabIndex = 1;
            // 
            // txtB_Grade
            // 
            this.txtB_Grade.Location = new System.Drawing.Point(177, 190);
            this.txtB_Grade.Name = "txtB_Grade";
            this.txtB_Grade.Size = new System.Drawing.Size(112, 23);
            this.txtB_Grade.TabIndex = 1;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Info.Location = new System.Drawing.Point(161, 27);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(126, 24);
            this.lbl_Info.TabIndex = 2;
            this.lbl_Info.Text = "SCORE INFO";
            // 
            // bttn_Edit
            // 
            this.bttn_Edit.Location = new System.Drawing.Point(102, 250);
            this.bttn_Edit.Name = "bttn_Edit";
            this.bttn_Edit.Size = new System.Drawing.Size(106, 32);
            this.bttn_Edit.TabIndex = 3;
            this.bttn_Edit.Text = "Edit";
            this.bttn_Edit.UseVisualStyleBackColor = true;
            this.bttn_Edit.Click += new System.EventHandler(this.bttn_Edit_Click);
            // 
            // bttn_Remove
            // 
            this.bttn_Remove.Location = new System.Drawing.Point(262, 250);
            this.bttn_Remove.Name = "bttn_Remove";
            this.bttn_Remove.Size = new System.Drawing.Size(106, 32);
            this.bttn_Remove.TabIndex = 3;
            this.bttn_Remove.Text = "Remove";
            this.bttn_Remove.UseVisualStyleBackColor = true;
            this.bttn_Remove.Click += new System.EventHandler(this.bttn_Remove_Click);
            // 
            // erPr_Grade
            // 
            this.erPr_Grade.ContainerControl = this;
            // 
            // Gra_GradeCellFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(470, 310);
            this.Controls.Add(this.bttn_Remove);
            this.Controls.Add(this.bttn_Edit);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.txtB_Grade);
            this.Controls.Add(this.txtB_Sem);
            this.Controls.Add(this.txtB_CName);
            this.Controls.Add(this.txtB_SName);
            this.Controls.Add(this.lbl_Grade);
            this.Controls.Add(this.lbl_Sem);
            this.Controls.Add(this.lbl_CName);
            this.Controls.Add(this.lbl_SName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "Gra_GradeCellFrm";
            this.Text = "Gra_GradeCellFrm";
            this.Load += new System.EventHandler(this.Gra_GradeCellFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Grade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SName;
        private System.Windows.Forms.Label lbl_CName;
        private System.Windows.Forms.Label lbl_Sem;
        private System.Windows.Forms.Label lbl_Grade;
        private System.Windows.Forms.TextBox txtB_SName;
        private System.Windows.Forms.TextBox txtB_CName;
        private System.Windows.Forms.TextBox txtB_Sem;
        private System.Windows.Forms.TextBox txtB_Grade;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Button bttn_Edit;
        private System.Windows.Forms.Button bttn_Remove;
        private System.Windows.Forms.ErrorProvider erPr_Grade;
    }
}