namespace WIPR170124.COURSEs
{
    partial class Cou_StuListFrm
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
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_Sem = new System.Windows.Forms.Label();
            this.lbl_CouC = new System.Windows.Forms.Label();
            this.dGV_StuList = new System.Windows.Forms.DataGridView();
            this.bttn_Print = new System.Windows.Forms.Button();
            this.comB_Sem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_StuList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Course.Location = new System.Drawing.Point(137, 48);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(73, 22);
            this.lbl_Course.TabIndex = 0;
            this.lbl_Course.Text = "Course:";
            // 
            // lbl_Sem
            // 
            this.lbl_Sem.AutoSize = true;
            this.lbl_Sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Sem.Location = new System.Drawing.Point(448, 48);
            this.lbl_Sem.Name = "lbl_Sem";
            this.lbl_Sem.Size = new System.Drawing.Size(91, 22);
            this.lbl_Sem.TabIndex = 1;
            this.lbl_Sem.Text = "Semester:";
            // 
            // lbl_CouC
            // 
            this.lbl_CouC.AutoSize = true;
            this.lbl_CouC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_CouC.Location = new System.Drawing.Point(216, 44);
            this.lbl_CouC.Name = "lbl_CouC";
            this.lbl_CouC.Size = new System.Drawing.Size(18, 26);
            this.lbl_CouC.TabIndex = 2;
            this.lbl_CouC.Text = ".";
            // 
            // dGV_StuList
            // 
            this.dGV_StuList.AllowUserToAddRows = false;
            this.dGV_StuList.AllowUserToDeleteRows = false;
            this.dGV_StuList.AllowUserToOrderColumns = true;
            this.dGV_StuList.AllowUserToResizeColumns = false;
            this.dGV_StuList.AllowUserToResizeRows = false;
            this.dGV_StuList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_StuList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_StuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_StuList.Location = new System.Drawing.Point(12, 83);
            this.dGV_StuList.Name = "dGV_StuList";
            this.dGV_StuList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGV_StuList.RowHeadersVisible = false;
            this.dGV_StuList.RowHeadersWidth = 62;
            this.dGV_StuList.RowTemplate.Height = 28;
            this.dGV_StuList.Size = new System.Drawing.Size(726, 403);
            this.dGV_StuList.TabIndex = 3;
            // 
            // bttn_Print
            // 
            this.bttn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bttn_Print.Location = new System.Drawing.Point(331, 504);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(88, 35);
            this.bttn_Print.TabIndex = 4;
            this.bttn_Print.Text = "Print";
            this.bttn_Print.UseVisualStyleBackColor = true;
            // 
            // comB_Sem
            // 
            this.comB_Sem.FormattingEnabled = true;
            this.comB_Sem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "None"});
            this.comB_Sem.Location = new System.Drawing.Point(545, 42);
            this.comB_Sem.MaxDropDownItems = 3;
            this.comB_Sem.Name = "comB_Sem";
            this.comB_Sem.Size = new System.Drawing.Size(58, 28);
            this.comB_Sem.TabIndex = 5;
            this.comB_Sem.SelectedIndexChanged += new System.EventHandler(this.comB_Sem_SelectedIndexChanged);
            // 
            // Cou_StuListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 551);
            this.Controls.Add(this.comB_Sem);
            this.Controls.Add(this.bttn_Print);
            this.Controls.Add(this.dGV_StuList);
            this.Controls.Add(this.lbl_CouC);
            this.Controls.Add(this.lbl_Sem);
            this.Controls.Add(this.lbl_Course);
            this.Name = "Cou_StuListFrm";
            this.Text = "Course\'s student list";
            this.Load += new System.EventHandler(this.Cou_StuListFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_StuList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_Sem;
        private System.Windows.Forms.Button bttn_Print;
        internal System.Windows.Forms.Label lbl_CouC;
        internal System.Windows.Forms.DataGridView dGV_StuList;
        private System.Windows.Forms.ComboBox comB_Sem;
    }
}