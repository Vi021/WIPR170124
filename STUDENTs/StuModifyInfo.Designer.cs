namespace WIPR170124
{
    partial class StuModifyInfo
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
            this.but_Update = new System.Windows.Forms.Button();
            this.but_Remove = new System.Windows.Forms.Button();
            this.txtBox_stuAddress = new System.Windows.Forms.RichTextBox();
            this.txtBox_stuPNumber = new System.Windows.Forms.TextBox();
            this.Gender_Others = new System.Windows.Forms.RadioButton();
            this.Gender_Female = new System.Windows.Forms.RadioButton();
            this.Gender_Male = new System.Windows.Forms.RadioButton();
            this.DaTi_stuBrthDate = new System.Windows.Forms.DateTimePicker();
            this.txtBox_stuLName = new System.Windows.Forms.TextBox();
            this.txtBox_stuFName = new System.Windows.Forms.TextBox();
            this.txtBox_stuID = new System.Windows.Forms.TextBox();
            this.Label_StuInfo = new System.Windows.Forms.Label();
            this.Stu_Pic = new System.Windows.Forms.Label();
            this.Stu_Address = new System.Windows.Forms.Label();
            this.Stu_PhoneNumber = new System.Windows.Forms.Label();
            this.Stu_Gender = new System.Windows.Forms.Label();
            this.Stu_BrthDate = new System.Windows.Forms.Label();
            this.Stu_LastName = new System.Windows.Forms.Label();
            this.Stu_FirstName = new System.Windows.Forms.Label();
            this.Stu_ID = new System.Windows.Forms.Label();
            this.but_Find = new System.Windows.Forms.Button();
            this.picBox_stuPic = new System.Windows.Forms.PictureBox();
            this.bttn_Upload = new System.Windows.Forms.Button();
            this.ErPr_FName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErPr_LName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErPr_StuID = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_Courses = new System.Windows.Forms.Label();
            this.cLB_Courses = new System.Windows.Forms.CheckedListBox();
            this.lbl_Semester = new System.Windows.Forms.Label();
            this.comB_Semester = new System.Windows.Forms.ComboBox();
            this.erPr_SemCou = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_stuPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPr_FName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPr_LName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPr_StuID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_SemCou)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Update
            // 
            this.but_Update.Location = new System.Drawing.Point(278, 732);
            this.but_Update.Name = "but_Update";
            this.but_Update.Size = new System.Drawing.Size(177, 34);
            this.but_Update.TabIndex = 41;
            this.but_Update.Text = "Update";
            this.but_Update.UseVisualStyleBackColor = true;
            this.but_Update.Click += new System.EventHandler(this.but_Update_Click);
            // 
            // but_Remove
            // 
            this.but_Remove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.but_Remove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.but_Remove.Location = new System.Drawing.Point(65, 732);
            this.but_Remove.Name = "but_Remove";
            this.but_Remove.Size = new System.Drawing.Size(177, 34);
            this.but_Remove.TabIndex = 40;
            this.but_Remove.Text = "Remove";
            this.but_Remove.UseVisualStyleBackColor = false;
            this.but_Remove.Click += new System.EventHandler(this.but_Remove_Click);
            // 
            // txtBox_stuAddress
            // 
            this.txtBox_stuAddress.Location = new System.Drawing.Point(204, 272);
            this.txtBox_stuAddress.Name = "txtBox_stuAddress";
            this.txtBox_stuAddress.Size = new System.Drawing.Size(251, 96);
            this.txtBox_stuAddress.TabIndex = 37;
            this.txtBox_stuAddress.Text = "";
            // 
            // txtBox_stuPNumber
            // 
            this.txtBox_stuPNumber.Location = new System.Drawing.Point(204, 240);
            this.txtBox_stuPNumber.Name = "txtBox_stuPNumber";
            this.txtBox_stuPNumber.Size = new System.Drawing.Size(251, 26);
            this.txtBox_stuPNumber.TabIndex = 36;
            // 
            // Gender_Others
            // 
            this.Gender_Others.AutoSize = true;
            this.Gender_Others.Location = new System.Drawing.Point(373, 210);
            this.Gender_Others.Name = "Gender_Others";
            this.Gender_Others.Size = new System.Drawing.Size(82, 24);
            this.Gender_Others.TabIndex = 35;
            this.Gender_Others.TabStop = true;
            this.Gender_Others.Text = "Others";
            this.Gender_Others.UseVisualStyleBackColor = true;
            // 
            // Gender_Female
            // 
            this.Gender_Female.AutoSize = true;
            this.Gender_Female.Location = new System.Drawing.Point(278, 210);
            this.Gender_Female.Name = "Gender_Female";
            this.Gender_Female.Size = new System.Drawing.Size(87, 24);
            this.Gender_Female.TabIndex = 34;
            this.Gender_Female.TabStop = true;
            this.Gender_Female.Text = "Female";
            this.Gender_Female.UseVisualStyleBackColor = true;
            // 
            // Gender_Male
            // 
            this.Gender_Male.AutoSize = true;
            this.Gender_Male.Location = new System.Drawing.Point(204, 210);
            this.Gender_Male.Name = "Gender_Male";
            this.Gender_Male.Size = new System.Drawing.Size(68, 24);
            this.Gender_Male.TabIndex = 33;
            this.Gender_Male.TabStop = true;
            this.Gender_Male.Text = "Male";
            this.Gender_Male.UseVisualStyleBackColor = true;
            // 
            // DaTi_stuBrthDate
            // 
            this.DaTi_stuBrthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.DaTi_stuBrthDate.CustomFormat = "dd/MM/yyyy";
            this.DaTi_stuBrthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DaTi_stuBrthDate.Location = new System.Drawing.Point(204, 178);
            this.DaTi_stuBrthDate.MaxDate = new System.DateTime(2024, 1, 24, 0, 0, 0, 0);
            this.DaTi_stuBrthDate.MinDate = new System.DateTime(1899, 1, 1, 0, 0, 0, 0);
            this.DaTi_stuBrthDate.Name = "DaTi_stuBrthDate";
            this.DaTi_stuBrthDate.Size = new System.Drawing.Size(251, 26);
            this.DaTi_stuBrthDate.TabIndex = 26;
            this.DaTi_stuBrthDate.Value = new System.DateTime(2024, 1, 24, 0, 0, 0, 0);
            // 
            // txtBox_stuLName
            // 
            this.txtBox_stuLName.Location = new System.Drawing.Point(204, 146);
            this.txtBox_stuLName.Name = "txtBox_stuLName";
            this.txtBox_stuLName.Size = new System.Drawing.Size(251, 26);
            this.txtBox_stuLName.TabIndex = 31;
            this.txtBox_stuLName.TextChanged += new System.EventHandler(this.txtBox_stuLName_TextChanged);
            // 
            // txtBox_stuFName
            // 
            this.txtBox_stuFName.Location = new System.Drawing.Point(204, 114);
            this.txtBox_stuFName.Name = "txtBox_stuFName";
            this.txtBox_stuFName.Size = new System.Drawing.Size(251, 26);
            this.txtBox_stuFName.TabIndex = 32;
            this.txtBox_stuFName.TextChanged += new System.EventHandler(this.txtBox_stuFName_TextChanged);
            // 
            // txtBox_stuID
            // 
            this.txtBox_stuID.Location = new System.Drawing.Point(204, 82);
            this.txtBox_stuID.Name = "txtBox_stuID";
            this.txtBox_stuID.Size = new System.Drawing.Size(161, 26);
            this.txtBox_stuID.TabIndex = 30;
            // 
            // Label_StuInfo
            // 
            this.Label_StuInfo.AutoSize = true;
            this.Label_StuInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_StuInfo.Location = new System.Drawing.Point(189, 28);
            this.Label_StuInfo.Name = "Label_StuInfo";
            this.Label_StuInfo.Size = new System.Drawing.Size(152, 29);
            this.Label_StuInfo.TabIndex = 29;
            this.Label_StuInfo.Text = "Student Info";
            // 
            // Stu_Pic
            // 
            this.Stu_Pic.AutoSize = true;
            this.Stu_Pic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stu_Pic.Location = new System.Drawing.Point(61, 374);
            this.Stu_Pic.Name = "Stu_Pic";
            this.Stu_Pic.Size = new System.Drawing.Size(66, 22);
            this.Stu_Pic.TabIndex = 28;
            this.Stu_Pic.Text = "Picture";
            // 
            // Stu_Address
            // 
            this.Stu_Address.AutoSize = true;
            this.Stu_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Stu_Address.Location = new System.Drawing.Point(61, 273);
            this.Stu_Address.Name = "Stu_Address";
            this.Stu_Address.Size = new System.Drawing.Size(76, 22);
            this.Stu_Address.TabIndex = 27;
            this.Stu_Address.Text = "Address";
            // 
            // Stu_PhoneNumber
            // 
            this.Stu_PhoneNumber.AutoSize = true;
            this.Stu_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Stu_PhoneNumber.Location = new System.Drawing.Point(61, 244);
            this.Stu_PhoneNumber.Name = "Stu_PhoneNumber";
            this.Stu_PhoneNumber.Size = new System.Drawing.Size(127, 22);
            this.Stu_PhoneNumber.TabIndex = 25;
            this.Stu_PhoneNumber.Text = "Phone number";
            // 
            // Stu_Gender
            // 
            this.Stu_Gender.AutoSize = true;
            this.Stu_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Stu_Gender.Location = new System.Drawing.Point(61, 212);
            this.Stu_Gender.Name = "Stu_Gender";
            this.Stu_Gender.Size = new System.Drawing.Size(70, 22);
            this.Stu_Gender.TabIndex = 24;
            this.Stu_Gender.Text = "Gender";
            // 
            // Stu_BrthDate
            // 
            this.Stu_BrthDate.AutoSize = true;
            this.Stu_BrthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Stu_BrthDate.Location = new System.Drawing.Point(61, 182);
            this.Stu_BrthDate.Name = "Stu_BrthDate";
            this.Stu_BrthDate.Size = new System.Drawing.Size(90, 22);
            this.Stu_BrthDate.TabIndex = 23;
            this.Stu_BrthDate.Text = "Birth Date";
            // 
            // Stu_LastName
            // 
            this.Stu_LastName.AutoSize = true;
            this.Stu_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Stu_LastName.Location = new System.Drawing.Point(61, 150);
            this.Stu_LastName.Name = "Stu_LastName";
            this.Stu_LastName.Size = new System.Drawing.Size(88, 22);
            this.Stu_LastName.TabIndex = 22;
            this.Stu_LastName.Text = "Lastname";
            // 
            // Stu_FirstName
            // 
            this.Stu_FirstName.AutoSize = true;
            this.Stu_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Stu_FirstName.Location = new System.Drawing.Point(61, 118);
            this.Stu_FirstName.Name = "Stu_FirstName";
            this.Stu_FirstName.Size = new System.Drawing.Size(89, 22);
            this.Stu_FirstName.TabIndex = 21;
            this.Stu_FirstName.Text = "Firstname";
            // 
            // Stu_ID
            // 
            this.Stu_ID.AutoSize = true;
            this.Stu_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Stu_ID.Location = new System.Drawing.Point(61, 86);
            this.Stu_ID.Name = "Stu_ID";
            this.Stu_ID.Size = new System.Drawing.Size(94, 22);
            this.Stu_ID.TabIndex = 20;
            this.Stu_ID.Text = "Student ID";
            // 
            // but_Find
            // 
            this.but_Find.BackColor = System.Drawing.SystemColors.ControlLight;
            this.but_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Find.Location = new System.Drawing.Point(380, 82);
            this.but_Find.Name = "but_Find";
            this.but_Find.Size = new System.Drawing.Size(75, 29);
            this.but_Find.TabIndex = 42;
            this.but_Find.Text = "Find";
            this.but_Find.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_Find.UseVisualStyleBackColor = false;
            this.but_Find.Click += new System.EventHandler(this.but_Find_Click);
            // 
            // picBox_stuPic
            // 
            this.picBox_stuPic.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.picBox_stuPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_stuPic.Location = new System.Drawing.Point(204, 374);
            this.picBox_stuPic.Name = "picBox_stuPic";
            this.picBox_stuPic.Size = new System.Drawing.Size(251, 151);
            this.picBox_stuPic.TabIndex = 38;
            this.picBox_stuPic.TabStop = false;
            // 
            // bttn_Upload
            // 
            this.bttn_Upload.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bttn_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.bttn_Upload.Location = new System.Drawing.Point(290, 531);
            this.bttn_Upload.Name = "bttn_Upload";
            this.bttn_Upload.Size = new System.Drawing.Size(75, 31);
            this.bttn_Upload.TabIndex = 43;
            this.bttn_Upload.Text = "Upload";
            this.bttn_Upload.UseVisualStyleBackColor = false;
            this.bttn_Upload.Click += new System.EventHandler(this.bttn_Upload_Click);
            // 
            // ErPr_FName
            // 
            this.ErPr_FName.ContainerControl = this;
            // 
            // ErPr_LName
            // 
            this.ErPr_LName.ContainerControl = this;
            // 
            // ErPr_StuID
            // 
            this.ErPr_StuID.ContainerControl = this;
            // 
            // lbl_Courses
            // 
            this.lbl_Courses.AutoSize = true;
            this.lbl_Courses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Courses.Location = new System.Drawing.Point(61, 610);
            this.lbl_Courses.Name = "lbl_Courses";
            this.lbl_Courses.Size = new System.Drawing.Size(89, 22);
            this.lbl_Courses.TabIndex = 28;
            this.lbl_Courses.Text = "Course(s)";
            // 
            // cLB_Courses
            // 
            this.cLB_Courses.FormattingEnabled = true;
            this.cLB_Courses.Location = new System.Drawing.Point(156, 609);
            this.cLB_Courses.Name = "cLB_Courses";
            this.cLB_Courses.Size = new System.Drawing.Size(299, 96);
            this.cLB_Courses.TabIndex = 44;
            // 
            // lbl_Semester
            // 
            this.lbl_Semester.AutoSize = true;
            this.lbl_Semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Semester.Location = new System.Drawing.Point(62, 573);
            this.lbl_Semester.Name = "lbl_Semester";
            this.lbl_Semester.Size = new System.Drawing.Size(86, 22);
            this.lbl_Semester.TabIndex = 28;
            this.lbl_Semester.Text = "Semester";
            // 
            // comB_Semester
            // 
            this.comB_Semester.FormattingEnabled = true;
            this.comB_Semester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comB_Semester.Location = new System.Drawing.Point(156, 567);
            this.comB_Semester.Name = "comB_Semester";
            this.comB_Semester.Size = new System.Drawing.Size(70, 28);
            this.comB_Semester.TabIndex = 45;
            // 
            // erPr_SemCou
            // 
            this.erPr_SemCou.ContainerControl = this;
            // 
            // StuModifyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 778);
            this.Controls.Add(this.comB_Semester);
            this.Controls.Add(this.cLB_Courses);
            this.Controls.Add(this.bttn_Upload);
            this.Controls.Add(this.but_Find);
            this.Controls.Add(this.but_Update);
            this.Controls.Add(this.but_Remove);
            this.Controls.Add(this.picBox_stuPic);
            this.Controls.Add(this.txtBox_stuAddress);
            this.Controls.Add(this.txtBox_stuPNumber);
            this.Controls.Add(this.Gender_Others);
            this.Controls.Add(this.Gender_Female);
            this.Controls.Add(this.Gender_Male);
            this.Controls.Add(this.DaTi_stuBrthDate);
            this.Controls.Add(this.txtBox_stuLName);
            this.Controls.Add(this.txtBox_stuFName);
            this.Controls.Add(this.txtBox_stuID);
            this.Controls.Add(this.Label_StuInfo);
            this.Controls.Add(this.lbl_Semester);
            this.Controls.Add(this.lbl_Courses);
            this.Controls.Add(this.Stu_Pic);
            this.Controls.Add(this.Stu_Address);
            this.Controls.Add(this.Stu_PhoneNumber);
            this.Controls.Add(this.Stu_Gender);
            this.Controls.Add(this.Stu_BrthDate);
            this.Controls.Add(this.Stu_LastName);
            this.Controls.Add(this.Stu_FirstName);
            this.Controls.Add(this.Stu_ID);
            this.Name = "StuModifyInfo";
            this.Text = "Update/Delete a Student";
            this.Load += new System.EventHandler(this.ModifyStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_stuPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPr_FName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPr_LName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPr_StuID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_SemCou)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Update;
        private System.Windows.Forms.Button but_Remove;
        internal System.Windows.Forms.PictureBox picBox_stuPic;
        internal System.Windows.Forms.RichTextBox txtBox_stuAddress;
        internal System.Windows.Forms.TextBox txtBox_stuPNumber;
        internal System.Windows.Forms.RadioButton Gender_Others;
        internal System.Windows.Forms.RadioButton Gender_Female;
        internal System.Windows.Forms.RadioButton Gender_Male;
        internal System.Windows.Forms.DateTimePicker DaTi_stuBrthDate;
        internal System.Windows.Forms.TextBox txtBox_stuLName;
        internal System.Windows.Forms.TextBox txtBox_stuFName;
        internal System.Windows.Forms.TextBox txtBox_stuID;
        private System.Windows.Forms.Label Label_StuInfo;
        private System.Windows.Forms.Label Stu_Pic;
        private System.Windows.Forms.Label Stu_Address;
        private System.Windows.Forms.Label Stu_PhoneNumber;
        private System.Windows.Forms.Label Stu_Gender;
        private System.Windows.Forms.Label Stu_BrthDate;
        private System.Windows.Forms.Label Stu_LastName;
        private System.Windows.Forms.Label Stu_FirstName;
        private System.Windows.Forms.Label Stu_ID;
        private System.Windows.Forms.Button but_Find;
        private System.Windows.Forms.Button bttn_Upload;
        private System.Windows.Forms.ErrorProvider ErPr_FName;
        private System.Windows.Forms.ErrorProvider ErPr_LName;
        private System.Windows.Forms.ErrorProvider ErPr_StuID;
        private System.Windows.Forms.Label lbl_Courses;
        private System.Windows.Forms.CheckedListBox cLB_Courses;
        private System.Windows.Forms.ComboBox comB_Semester;
        private System.Windows.Forms.Label lbl_Semester;
        private System.Windows.Forms.ErrorProvider erPr_SemCou;
    }
}