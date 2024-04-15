namespace WIPR170124
{
    partial class StuSeacrhFrm
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
            this.bttn_Search = new System.Windows.Forms.Button();
            this.txtBox_stuAddress = new System.Windows.Forms.RichTextBox();
            this.txtBox_stuPNumber = new System.Windows.Forms.TextBox();
            this.Gender_Others = new System.Windows.Forms.RadioButton();
            this.Gender_Female = new System.Windows.Forms.RadioButton();
            this.Gender_Male = new System.Windows.Forms.RadioButton();
            this.DaTi_stuBrthDate = new System.Windows.Forms.DateTimePicker();
            this.txtBox_stuLName = new System.Windows.Forms.TextBox();
            this.txtBox_stuFName = new System.Windows.Forms.TextBox();
            this.txtBox_stuID = new System.Windows.Forms.TextBox();
            this.lbl_SearchStu = new System.Windows.Forms.Label();
            this.Stu_Address = new System.Windows.Forms.Label();
            this.Stu_PhoneNumber = new System.Windows.Forms.Label();
            this.Stu_Gender = new System.Windows.Forms.Label();
            this.Stu_BrthDate = new System.Windows.Forms.Label();
            this.Stu_LastName = new System.Windows.Forms.Label();
            this.Stu_FirstName = new System.Windows.Forms.Label();
            this.Stu_ID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGV_SearchResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_SearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_Search
            // 
            this.bttn_Search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.bttn_Search.Location = new System.Drawing.Point(201, 405);
            this.bttn_Search.Name = "bttn_Search";
            this.bttn_Search.Size = new System.Drawing.Size(109, 31);
            this.bttn_Search.TabIndex = 60;
            this.bttn_Search.Text = "Search";
            this.bttn_Search.UseVisualStyleBackColor = false;
            // 
            // txtBox_stuAddress
            // 
            this.txtBox_stuAddress.Location = new System.Drawing.Point(192, 285);
            this.txtBox_stuAddress.Name = "txtBox_stuAddress";
            this.txtBox_stuAddress.Size = new System.Drawing.Size(251, 96);
            this.txtBox_stuAddress.TabIndex = 59;
            this.txtBox_stuAddress.Text = "";
            // 
            // txtBox_stuPNumber
            // 
            this.txtBox_stuPNumber.Location = new System.Drawing.Point(192, 253);
            this.txtBox_stuPNumber.Name = "txtBox_stuPNumber";
            this.txtBox_stuPNumber.Size = new System.Drawing.Size(251, 26);
            this.txtBox_stuPNumber.TabIndex = 58;
            // 
            // Gender_Others
            // 
            this.Gender_Others.AutoSize = true;
            this.Gender_Others.Location = new System.Drawing.Point(361, 223);
            this.Gender_Others.Name = "Gender_Others";
            this.Gender_Others.Size = new System.Drawing.Size(82, 24);
            this.Gender_Others.TabIndex = 57;
            this.Gender_Others.TabStop = true;
            this.Gender_Others.Text = "Others";
            this.Gender_Others.UseVisualStyleBackColor = true;
            // 
            // Gender_Female
            // 
            this.Gender_Female.AutoSize = true;
            this.Gender_Female.Location = new System.Drawing.Point(266, 223);
            this.Gender_Female.Name = "Gender_Female";
            this.Gender_Female.Size = new System.Drawing.Size(87, 24);
            this.Gender_Female.TabIndex = 56;
            this.Gender_Female.TabStop = true;
            this.Gender_Female.Text = "Female";
            this.Gender_Female.UseVisualStyleBackColor = true;
            // 
            // Gender_Male
            // 
            this.Gender_Male.AutoSize = true;
            this.Gender_Male.Location = new System.Drawing.Point(192, 223);
            this.Gender_Male.Name = "Gender_Male";
            this.Gender_Male.Size = new System.Drawing.Size(68, 24);
            this.Gender_Male.TabIndex = 55;
            this.Gender_Male.TabStop = true;
            this.Gender_Male.Text = "Male";
            this.Gender_Male.UseVisualStyleBackColor = true;
            // 
            // DaTi_stuBrthDate
            // 
            this.DaTi_stuBrthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.DaTi_stuBrthDate.CustomFormat = "";
            this.DaTi_stuBrthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DaTi_stuBrthDate.Location = new System.Drawing.Point(192, 191);
            this.DaTi_stuBrthDate.MaxDate = new System.DateTime(2024, 1, 24, 0, 0, 0, 0);
            this.DaTi_stuBrthDate.MinDate = new System.DateTime(1899, 1, 1, 0, 0, 0, 0);
            this.DaTi_stuBrthDate.Name = "DaTi_stuBrthDate";
            this.DaTi_stuBrthDate.Size = new System.Drawing.Size(251, 26);
            this.DaTi_stuBrthDate.TabIndex = 49;
            this.DaTi_stuBrthDate.Value = new System.DateTime(2024, 1, 24, 0, 0, 0, 0);
            // 
            // txtBox_stuLName
            // 
            this.txtBox_stuLName.Location = new System.Drawing.Point(192, 159);
            this.txtBox_stuLName.Name = "txtBox_stuLName";
            this.txtBox_stuLName.Size = new System.Drawing.Size(251, 26);
            this.txtBox_stuLName.TabIndex = 53;
            // 
            // txtBox_stuFName
            // 
            this.txtBox_stuFName.Location = new System.Drawing.Point(192, 127);
            this.txtBox_stuFName.Name = "txtBox_stuFName";
            this.txtBox_stuFName.Size = new System.Drawing.Size(251, 26);
            this.txtBox_stuFName.TabIndex = 54;
            // 
            // txtBox_stuID
            // 
            this.txtBox_stuID.Location = new System.Drawing.Point(192, 95);
            this.txtBox_stuID.Name = "txtBox_stuID";
            this.txtBox_stuID.Size = new System.Drawing.Size(251, 26);
            this.txtBox_stuID.TabIndex = 52;
            // 
            // lbl_SearchStu
            // 
            this.lbl_SearchStu.AutoSize = true;
            this.lbl_SearchStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchStu.Location = new System.Drawing.Point(127, 35);
            this.lbl_SearchStu.Name = "lbl_SearchStu";
            this.lbl_SearchStu.Size = new System.Drawing.Size(250, 29);
            this.lbl_SearchStu.TabIndex = 51;
            this.lbl_SearchStu.Text = "Search for a Student";
            // 
            // Stu_Address
            // 
            this.Stu_Address.AutoSize = true;
            this.Stu_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Stu_Address.Location = new System.Drawing.Point(49, 286);
            this.Stu_Address.Name = "Stu_Address";
            this.Stu_Address.Size = new System.Drawing.Size(76, 22);
            this.Stu_Address.TabIndex = 50;
            this.Stu_Address.Text = "Address";
            // 
            // Stu_PhoneNumber
            // 
            this.Stu_PhoneNumber.AutoSize = true;
            this.Stu_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Stu_PhoneNumber.Location = new System.Drawing.Point(49, 257);
            this.Stu_PhoneNumber.Name = "Stu_PhoneNumber";
            this.Stu_PhoneNumber.Size = new System.Drawing.Size(127, 22);
            this.Stu_PhoneNumber.TabIndex = 48;
            this.Stu_PhoneNumber.Text = "Phone number";
            // 
            // Stu_Gender
            // 
            this.Stu_Gender.AutoSize = true;
            this.Stu_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Stu_Gender.Location = new System.Drawing.Point(49, 225);
            this.Stu_Gender.Name = "Stu_Gender";
            this.Stu_Gender.Size = new System.Drawing.Size(70, 22);
            this.Stu_Gender.TabIndex = 47;
            this.Stu_Gender.Text = "Gender";
            // 
            // Stu_BrthDate
            // 
            this.Stu_BrthDate.AutoSize = true;
            this.Stu_BrthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Stu_BrthDate.Location = new System.Drawing.Point(49, 195);
            this.Stu_BrthDate.Name = "Stu_BrthDate";
            this.Stu_BrthDate.Size = new System.Drawing.Size(90, 22);
            this.Stu_BrthDate.TabIndex = 46;
            this.Stu_BrthDate.Text = "Birth Date";
            // 
            // Stu_LastName
            // 
            this.Stu_LastName.AutoSize = true;
            this.Stu_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Stu_LastName.Location = new System.Drawing.Point(49, 163);
            this.Stu_LastName.Name = "Stu_LastName";
            this.Stu_LastName.Size = new System.Drawing.Size(88, 22);
            this.Stu_LastName.TabIndex = 45;
            this.Stu_LastName.Text = "Lastname";
            // 
            // Stu_FirstName
            // 
            this.Stu_FirstName.AutoSize = true;
            this.Stu_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Stu_FirstName.Location = new System.Drawing.Point(49, 131);
            this.Stu_FirstName.Name = "Stu_FirstName";
            this.Stu_FirstName.Size = new System.Drawing.Size(89, 22);
            this.Stu_FirstName.TabIndex = 44;
            this.Stu_FirstName.Text = "Firstname";
            // 
            // Stu_ID
            // 
            this.Stu_ID.AutoSize = true;
            this.Stu_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Stu_ID.Location = new System.Drawing.Point(49, 99);
            this.Stu_ID.Name = "Stu_ID";
            this.Stu_ID.Size = new System.Drawing.Size(94, 22);
            this.Stu_ID.TabIndex = 43;
            this.Stu_ID.Text = "Student ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(41, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 354);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // dGV_SearchResult
            // 
            this.dGV_SearchResult.AllowUserToAddRows = false;
            this.dGV_SearchResult.AllowUserToDeleteRows = false;
            this.dGV_SearchResult.AllowUserToResizeRows = false;
            this.dGV_SearchResult.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGV_SearchResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGV_SearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_SearchResult.Location = new System.Drawing.Point(41, 470);
            this.dGV_SearchResult.Name = "dGV_SearchResult";
            this.dGV_SearchResult.RowHeadersVisible = false;
            this.dGV_SearchResult.RowHeadersWidth = 62;
            this.dGV_SearchResult.RowTemplate.Height = 28;
            this.dGV_SearchResult.Size = new System.Drawing.Size(422, 166);
            this.dGV_SearchResult.TabIndex = 62;
            // 
            // SeacrhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 671);
            this.Controls.Add(this.bttn_Search);
            this.Controls.Add(this.dGV_SearchResult);
            this.Controls.Add(this.txtBox_stuAddress);
            this.Controls.Add(this.txtBox_stuPNumber);
            this.Controls.Add(this.Gender_Others);
            this.Controls.Add(this.Gender_Female);
            this.Controls.Add(this.Gender_Male);
            this.Controls.Add(this.DaTi_stuBrthDate);
            this.Controls.Add(this.txtBox_stuLName);
            this.Controls.Add(this.txtBox_stuFName);
            this.Controls.Add(this.txtBox_stuID);
            this.Controls.Add(this.lbl_SearchStu);
            this.Controls.Add(this.Stu_Address);
            this.Controls.Add(this.Stu_PhoneNumber);
            this.Controls.Add(this.Stu_Gender);
            this.Controls.Add(this.Stu_BrthDate);
            this.Controls.Add(this.Stu_LastName);
            this.Controls.Add(this.Stu_FirstName);
            this.Controls.Add(this.Stu_ID);
            this.Controls.Add(this.groupBox1);
            this.Name = "SeacrhForm";
            this.Text = "SeacrhForm";
            this.Load += new System.EventHandler(this.SeacrhForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_SearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Search;
        internal System.Windows.Forms.RichTextBox txtBox_stuAddress;
        internal System.Windows.Forms.TextBox txtBox_stuPNumber;
        internal System.Windows.Forms.RadioButton Gender_Others;
        internal System.Windows.Forms.RadioButton Gender_Female;
        internal System.Windows.Forms.RadioButton Gender_Male;
        internal System.Windows.Forms.DateTimePicker DaTi_stuBrthDate;
        internal System.Windows.Forms.TextBox txtBox_stuLName;
        internal System.Windows.Forms.TextBox txtBox_stuFName;
        internal System.Windows.Forms.TextBox txtBox_stuID;
        private System.Windows.Forms.Label lbl_SearchStu;
        private System.Windows.Forms.Label Stu_Address;
        private System.Windows.Forms.Label Stu_PhoneNumber;
        private System.Windows.Forms.Label Stu_Gender;
        private System.Windows.Forms.Label Stu_BrthDate;
        private System.Windows.Forms.Label Stu_LastName;
        private System.Windows.Forms.Label Stu_FirstName;
        private System.Windows.Forms.Label Stu_ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGV_SearchResult;
    }
}