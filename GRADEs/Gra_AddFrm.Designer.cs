namespace WIPR170124.GRADEs
{
    partial class Gra_AddFrm
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
            this.bttn_Add = new System.Windows.Forms.Button();
            this.lbl_Descr = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_CName = new System.Windows.Forms.Label();
            this.lbl_StuID = new System.Windows.Forms.Label();
            this.rTB_Descr = new System.Windows.Forms.RichTextBox();
            this.txtB_Score = new System.Windows.Forms.TextBox();
            this.txtB_StuID = new System.Windows.Forms.TextBox();
            this.dGV_Scores = new System.Windows.Forms.DataGridView();
            this.comB_CID = new System.Windows.Forms.ComboBox();
            this.erPr_StuID = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_Sem = new System.Windows.Forms.Label();
            this.comB_Sem = new System.Windows.Forms.ComboBox();
            this.erPr_Add = new System.Windows.Forms.ErrorProvider(this.components);
            this.erPr_Grade = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Scores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_StuID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Grade)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_Add
            // 
            this.bttn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Add.Location = new System.Drawing.Point(161, 379);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(100, 40);
            this.bttn_Add.TabIndex = 14;
            this.bttn_Add.Text = "Add";
            this.bttn_Add.UseVisualStyleBackColor = true;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // lbl_Descr
            // 
            this.lbl_Descr.AutoSize = true;
            this.lbl_Descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descr.Location = new System.Drawing.Point(50, 242);
            this.lbl_Descr.Name = "lbl_Descr";
            this.lbl_Descr.Size = new System.Drawing.Size(105, 22);
            this.lbl_Descr.TabIndex = 9;
            this.lbl_Descr.Text = "Description:";
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(93, 200);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(62, 22);
            this.lbl_Score.TabIndex = 10;
            this.lbl_Score.Text = "Score:";
            // 
            // lbl_CName
            // 
            this.lbl_CName.AutoSize = true;
            this.lbl_CName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CName.Location = new System.Drawing.Point(30, 106);
            this.lbl_CName.Name = "lbl_CName";
            this.lbl_CName.Size = new System.Drawing.Size(125, 22);
            this.lbl_CName.TabIndex = 11;
            this.lbl_CName.Text = "Course Name:";
            // 
            // lbl_StuID
            // 
            this.lbl_StuID.AutoSize = true;
            this.lbl_StuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_StuID.Location = new System.Drawing.Point(56, 58);
            this.lbl_StuID.Name = "lbl_StuID";
            this.lbl_StuID.Size = new System.Drawing.Size(99, 22);
            this.lbl_StuID.TabIndex = 12;
            this.lbl_StuID.Text = "Student ID:";
            // 
            // rTB_Descr
            // 
            this.rTB_Descr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTB_Descr.Location = new System.Drawing.Point(161, 242);
            this.rTB_Descr.Name = "rTB_Descr";
            this.rTB_Descr.Size = new System.Drawing.Size(221, 116);
            this.rTB_Descr.TabIndex = 13;
            this.rTB_Descr.Text = "";
            // 
            // txtB_Score
            // 
            this.txtB_Score.Location = new System.Drawing.Point(161, 196);
            this.txtB_Score.Name = "txtB_Score";
            this.txtB_Score.Size = new System.Drawing.Size(100, 26);
            this.txtB_Score.TabIndex = 6;
            // 
            // txtB_StuID
            // 
            this.txtB_StuID.Location = new System.Drawing.Point(161, 54);
            this.txtB_StuID.Name = "txtB_StuID";
            this.txtB_StuID.Size = new System.Drawing.Size(149, 26);
            this.txtB_StuID.TabIndex = 8;
            // 
            // dGV_Scores
            // 
            this.dGV_Scores.AllowUserToAddRows = false;
            this.dGV_Scores.AllowUserToDeleteRows = false;
            this.dGV_Scores.AllowUserToResizeColumns = false;
            this.dGV_Scores.AllowUserToResizeRows = false;
            this.dGV_Scores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Scores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGV_Scores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Scores.Location = new System.Drawing.Point(419, 12);
            this.dGV_Scores.Name = "dGV_Scores";
            this.dGV_Scores.ReadOnly = true;
            this.dGV_Scores.RowHeadersVisible = false;
            this.dGV_Scores.RowHeadersWidth = 62;
            this.dGV_Scores.RowTemplate.Height = 28;
            this.dGV_Scores.Size = new System.Drawing.Size(555, 426);
            this.dGV_Scores.TabIndex = 15;
            this.dGV_Scores.Click += new System.EventHandler(this.dGV_Scores_Click);
            // 
            // comB_CID
            // 
            this.comB_CID.FormattingEnabled = true;
            this.comB_CID.Location = new System.Drawing.Point(161, 100);
            this.comB_CID.Name = "comB_CID";
            this.comB_CID.Size = new System.Drawing.Size(221, 28);
            this.comB_CID.TabIndex = 16;
            this.comB_CID.SelectedIndexChanged += new System.EventHandler(this.comB_CID_SelectedIndexChanged);
            // 
            // erPr_StuID
            // 
            this.erPr_StuID.ContainerControl = this;
            // 
            // lbl_Sem
            // 
            this.lbl_Sem.AutoSize = true;
            this.lbl_Sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sem.Location = new System.Drawing.Point(64, 154);
            this.lbl_Sem.Name = "lbl_Sem";
            this.lbl_Sem.Size = new System.Drawing.Size(91, 22);
            this.lbl_Sem.TabIndex = 10;
            this.lbl_Sem.Text = "Semester:";
            // 
            // comB_Sem
            // 
            this.comB_Sem.FormattingEnabled = true;
            this.comB_Sem.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comB_Sem.Location = new System.Drawing.Point(161, 148);
            this.comB_Sem.Name = "comB_Sem";
            this.comB_Sem.Size = new System.Drawing.Size(61, 28);
            this.comB_Sem.TabIndex = 16;
            this.comB_Sem.SelectedIndexChanged += new System.EventHandler(this.comB_CID_SelectedIndexChanged);
            // 
            // erPr_Add
            // 
            this.erPr_Add.ContainerControl = this;
            // 
            // erPr_Grade
            // 
            this.erPr_Grade.ContainerControl = this;
            // 
            // Gra_AddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 451);
            this.Controls.Add(this.comB_Sem);
            this.Controls.Add(this.comB_CID);
            this.Controls.Add(this.dGV_Scores);
            this.Controls.Add(this.bttn_Add);
            this.Controls.Add(this.lbl_Descr);
            this.Controls.Add(this.lbl_Sem);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_CName);
            this.Controls.Add(this.lbl_StuID);
            this.Controls.Add(this.rTB_Descr);
            this.Controls.Add(this.txtB_Score);
            this.Controls.Add(this.txtB_StuID);
            this.Name = "Gra_AddFrm";
            this.Text = "Add score";
            this.Load += new System.EventHandler(this.Gra_AddFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Scores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_StuID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Grade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.Label lbl_Descr;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_CName;
        private System.Windows.Forms.Label lbl_StuID;
        private System.Windows.Forms.RichTextBox rTB_Descr;
        private System.Windows.Forms.TextBox txtB_Score;
        private System.Windows.Forms.TextBox txtB_StuID;
        private System.Windows.Forms.DataGridView dGV_Scores;
        private System.Windows.Forms.ComboBox comB_CID;
        private System.Windows.Forms.ErrorProvider erPr_StuID;
        private System.Windows.Forms.ComboBox comB_Sem;
        private System.Windows.Forms.Label lbl_Sem;
        private System.Windows.Forms.ErrorProvider erPr_Add;
        private System.Windows.Forms.ErrorProvider erPr_Grade;
    }
}