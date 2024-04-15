namespace WIPR170124.GRADEs
{
    partial class Gra_RemoveFrm
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
            this.dGV_Scores = new System.Windows.Forms.DataGridView();
            this.bttn_Remove = new System.Windows.Forms.Button();
            this.lbl_CID = new System.Windows.Forms.Label();
            this.lbl_StuID = new System.Windows.Forms.Label();
            this.txtB_StuID = new System.Windows.Forms.TextBox();
            this.txtB_CID = new System.Windows.Forms.TextBox();
            this.lbl_Semester = new System.Windows.Forms.Label();
            this.txtB_Sem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Scores)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Scores
            // 
            this.dGV_Scores.AllowUserToAddRows = false;
            this.dGV_Scores.AllowUserToDeleteRows = false;
            this.dGV_Scores.AllowUserToResizeColumns = false;
            this.dGV_Scores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Scores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGV_Scores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Scores.Location = new System.Drawing.Point(329, 12);
            this.dGV_Scores.Name = "dGV_Scores";
            this.dGV_Scores.ReadOnly = true;
            this.dGV_Scores.RowHeadersVisible = false;
            this.dGV_Scores.RowHeadersWidth = 62;
            this.dGV_Scores.RowTemplate.Height = 28;
            this.dGV_Scores.Size = new System.Drawing.Size(613, 215);
            this.dGV_Scores.TabIndex = 25;
            this.dGV_Scores.Click += new System.EventHandler(this.dGV_Scores_Click);
            // 
            // bttn_Remove
            // 
            this.bttn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Remove.Location = new System.Drawing.Point(115, 182);
            this.bttn_Remove.Name = "bttn_Remove";
            this.bttn_Remove.Size = new System.Drawing.Size(100, 35);
            this.bttn_Remove.TabIndex = 24;
            this.bttn_Remove.Text = "Remove score";
            this.bttn_Remove.UseVisualStyleBackColor = true;
            this.bttn_Remove.Click += new System.EventHandler(this.bttn_Remove_Click);
            // 
            // lbl_CID
            // 
            this.lbl_CID.AutoSize = true;
            this.lbl_CID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CID.Location = new System.Drawing.Point(44, 87);
            this.lbl_CID.Name = "lbl_CID";
            this.lbl_CID.Size = new System.Drawing.Size(95, 22);
            this.lbl_CID.TabIndex = 21;
            this.lbl_CID.Text = "Course ID:";
            // 
            // lbl_StuID
            // 
            this.lbl_StuID.AutoSize = true;
            this.lbl_StuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_StuID.Location = new System.Drawing.Point(40, 42);
            this.lbl_StuID.Name = "lbl_StuID";
            this.lbl_StuID.Size = new System.Drawing.Size(99, 22);
            this.lbl_StuID.TabIndex = 22;
            this.lbl_StuID.Text = "Student ID:";
            // 
            // txtB_StuID
            // 
            this.txtB_StuID.Location = new System.Drawing.Point(145, 38);
            this.txtB_StuID.Name = "txtB_StuID";
            this.txtB_StuID.Size = new System.Drawing.Size(149, 26);
            this.txtB_StuID.TabIndex = 18;
            // 
            // txtB_CID
            // 
            this.txtB_CID.Location = new System.Drawing.Point(145, 84);
            this.txtB_CID.Name = "txtB_CID";
            this.txtB_CID.Size = new System.Drawing.Size(112, 26);
            this.txtB_CID.TabIndex = 18;
            // 
            // lbl_Semester
            // 
            this.lbl_Semester.AutoSize = true;
            this.lbl_Semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Semester.Location = new System.Drawing.Point(48, 134);
            this.lbl_Semester.Name = "lbl_Semester";
            this.lbl_Semester.Size = new System.Drawing.Size(91, 22);
            this.lbl_Semester.TabIndex = 46;
            this.lbl_Semester.Text = "Semester:";
            // 
            // txtB_Sem
            // 
            this.txtB_Sem.Location = new System.Drawing.Point(145, 130);
            this.txtB_Sem.Name = "txtB_Sem";
            this.txtB_Sem.Size = new System.Drawing.Size(77, 26);
            this.txtB_Sem.TabIndex = 18;
            // 
            // Gra_RemoveFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 239);
            this.Controls.Add(this.lbl_Semester);
            this.Controls.Add(this.dGV_Scores);
            this.Controls.Add(this.bttn_Remove);
            this.Controls.Add(this.lbl_CID);
            this.Controls.Add(this.txtB_Sem);
            this.Controls.Add(this.txtB_CID);
            this.Controls.Add(this.lbl_StuID);
            this.Controls.Add(this.txtB_StuID);
            this.Name = "Gra_RemoveFrm";
            this.Text = "Remove score";
            this.Load += new System.EventHandler(this.Gra_RemoveFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Scores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGV_Scores;
        private System.Windows.Forms.Button bttn_Remove;
        private System.Windows.Forms.Label lbl_CID;
        private System.Windows.Forms.Label lbl_StuID;
        private System.Windows.Forms.TextBox txtB_StuID;
        private System.Windows.Forms.TextBox txtB_CID;
        private System.Windows.Forms.Label lbl_Semester;
        private System.Windows.Forms.TextBox txtB_Sem;
    }
}