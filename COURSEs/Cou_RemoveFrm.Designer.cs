namespace WIPR170124.COURSEs
{
    partial class Cou_RemoveFrm
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
            this.lbl_CID = new System.Windows.Forms.Label();
            this.txtB_CID = new System.Windows.Forms.TextBox();
            this.bttn_Remove = new System.Windows.Forms.Button();
            this.erPr_CID = new System.Windows.Forms.ErrorProvider(this.components);
            this.comB_Course = new System.Windows.Forms.ComboBox();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_CInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_CID)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CID
            // 
            this.lbl_CID.AutoSize = true;
            this.lbl_CID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_CID.Location = new System.Drawing.Point(38, 126);
            this.lbl_CID.Name = "lbl_CID";
            this.lbl_CID.Size = new System.Drawing.Size(95, 22);
            this.lbl_CID.TabIndex = 0;
            this.lbl_CID.Text = "Course ID:";
            // 
            // txtB_CID
            // 
            this.txtB_CID.Location = new System.Drawing.Point(139, 122);
            this.txtB_CID.Name = "txtB_CID";
            this.txtB_CID.Size = new System.Drawing.Size(101, 26);
            this.txtB_CID.TabIndex = 1;
            // 
            // bttn_Remove
            // 
            this.bttn_Remove.Location = new System.Drawing.Point(196, 181);
            this.bttn_Remove.Name = "bttn_Remove";
            this.bttn_Remove.Size = new System.Drawing.Size(98, 37);
            this.bttn_Remove.TabIndex = 2;
            this.bttn_Remove.Text = "Remove";
            this.bttn_Remove.UseVisualStyleBackColor = true;
            this.bttn_Remove.Click += new System.EventHandler(this.bttn_Remove_Click);
            // 
            // erPr_CID
            // 
            this.erPr_CID.ContainerControl = this;
            // 
            // comB_Course
            // 
            this.comB_Course.FormattingEnabled = true;
            this.comB_Course.Location = new System.Drawing.Point(139, 83);
            this.comB_Course.Name = "comB_Course";
            this.comB_Course.Size = new System.Drawing.Size(297, 28);
            this.comB_Course.TabIndex = 17;
            this.comB_Course.SelectedIndexChanged += new System.EventHandler(this.comB_Course_SelectedIndexChanged);
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Course.Location = new System.Drawing.Point(60, 89);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(73, 22);
            this.lbl_Course.TabIndex = 16;
            this.lbl_Course.Text = "Course:";
            // 
            // lbl_CInfo
            // 
            this.lbl_CInfo.AutoSize = true;
            this.lbl_CInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CInfo.Location = new System.Drawing.Point(159, 30);
            this.lbl_CInfo.Name = "lbl_CInfo";
            this.lbl_CInfo.Size = new System.Drawing.Size(176, 26);
            this.lbl_CInfo.TabIndex = 18;
            this.lbl_CInfo.Text = "COURSE INFO";
            // 
            // Cou_RemoveFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 243);
            this.Controls.Add(this.lbl_CInfo);
            this.Controls.Add(this.comB_Course);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.bttn_Remove);
            this.Controls.Add(this.txtB_CID);
            this.Controls.Add(this.lbl_CID);
            this.Name = "Cou_RemoveFrm";
            this.Text = "Remove a course";
            this.Load += new System.EventHandler(this.Cou_RemoveFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erPr_CID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CID;
        private System.Windows.Forms.TextBox txtB_CID;
        private System.Windows.Forms.Button bttn_Remove;
        private System.Windows.Forms.ErrorProvider erPr_CID;
        private System.Windows.Forms.Label lbl_CInfo;
        private System.Windows.Forms.ComboBox comB_Course;
        private System.Windows.Forms.Label lbl_Course;
    }
}