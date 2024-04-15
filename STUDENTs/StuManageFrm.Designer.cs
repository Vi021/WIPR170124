namespace WIPR170124
{
    partial class StuManageFrm
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
            this.bttn_Upload = new System.Windows.Forms.Button();
            this.picB_Pic = new System.Windows.Forms.PictureBox();
            this.rtxtB_Addr = new System.Windows.Forms.RichTextBox();
            this.txtB_Pnumber = new System.Windows.Forms.TextBox();
            this.rBtn_Others = new System.Windows.Forms.RadioButton();
            this.rBtn_Female = new System.Windows.Forms.RadioButton();
            this.rBtn_Male = new System.Windows.Forms.RadioButton();
            this.DaTi_BDate = new System.Windows.Forms.DateTimePicker();
            this.txtB_Lname = new System.Windows.Forms.TextBox();
            this.txtB_Fname = new System.Windows.Forms.TextBox();
            this.txtB_StuID = new System.Windows.Forms.TextBox();
            this.lbl_Pic = new System.Windows.Forms.Label();
            this.lbl_Addr = new System.Windows.Forms.Label();
            this.lbl_Pnumber = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_BDate = new System.Windows.Forms.Label();
            this.lbl_Lname = new System.Windows.Forms.Label();
            this.lbl_Fname = new System.Windows.Forms.Label();
            this.lbl_StuID = new System.Windows.Forms.Label();
            this.bttn_Download = new System.Windows.Forms.Button();
            this.dGV_1 = new System.Windows.Forms.DataGridView();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtB_Search = new System.Windows.Forms.TextBox();
            this.bttn_Search = new System.Windows.Forms.Button();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.grpB_1 = new System.Windows.Forms.GroupBox();
            this.bttn_Reset = new System.Windows.Forms.Button();
            this.bttn_Remove = new System.Windows.Forms.Button();
            this.bttn_Edit = new System.Windows.Forms.Button();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.erPr_Fname = new System.Windows.Forms.ErrorProvider(this.components);
            this.erPr_StuID = new System.Windows.Forms.ErrorProvider(this.components);
            this.erPr_Lname = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picB_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_1)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpB_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Fname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_StuID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Lname)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_Upload
            // 
            this.bttn_Upload.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bttn_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.bttn_Upload.Location = new System.Drawing.Point(187, 514);
            this.bttn_Upload.Name = "bttn_Upload";
            this.bttn_Upload.Size = new System.Drawing.Size(90, 32);
            this.bttn_Upload.TabIndex = 38;
            this.bttn_Upload.Text = "Upload";
            this.bttn_Upload.UseVisualStyleBackColor = false;
            this.bttn_Upload.Click += new System.EventHandler(this.bttn_Upload_Click);
            // 
            // picB_Pic
            // 
            this.picB_Pic.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.picB_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_Pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picB_Pic.Location = new System.Drawing.Point(171, 357);
            this.picB_Pic.Name = "picB_Pic";
            this.picB_Pic.Size = new System.Drawing.Size(227, 151);
            this.picB_Pic.TabIndex = 37;
            this.picB_Pic.TabStop = false;
            // 
            // rtxtB_Addr
            // 
            this.rtxtB_Addr.Location = new System.Drawing.Point(171, 255);
            this.rtxtB_Addr.Name = "rtxtB_Addr";
            this.rtxtB_Addr.Size = new System.Drawing.Size(227, 96);
            this.rtxtB_Addr.TabIndex = 36;
            this.rtxtB_Addr.Text = "";
            // 
            // txtB_Pnumber
            // 
            this.txtB_Pnumber.Location = new System.Drawing.Point(171, 223);
            this.txtB_Pnumber.Name = "txtB_Pnumber";
            this.txtB_Pnumber.Size = new System.Drawing.Size(227, 26);
            this.txtB_Pnumber.TabIndex = 35;
            // 
            // rBtn_Others
            // 
            this.rBtn_Others.AutoSize = true;
            this.rBtn_Others.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.rBtn_Others.Location = new System.Drawing.Point(322, 193);
            this.rBtn_Others.Name = "rBtn_Others";
            this.rBtn_Others.Size = new System.Drawing.Size(76, 21);
            this.rBtn_Others.TabIndex = 34;
            this.rBtn_Others.TabStop = true;
            this.rBtn_Others.Text = "Others";
            this.rBtn_Others.UseVisualStyleBackColor = true;
            // 
            // rBtn_Female
            // 
            this.rBtn_Female.AutoSize = true;
            this.rBtn_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.rBtn_Female.Location = new System.Drawing.Point(237, 193);
            this.rBtn_Female.Name = "rBtn_Female";
            this.rBtn_Female.Size = new System.Drawing.Size(79, 21);
            this.rBtn_Female.TabIndex = 33;
            this.rBtn_Female.TabStop = true;
            this.rBtn_Female.Text = "Female";
            this.rBtn_Female.UseVisualStyleBackColor = true;
            // 
            // rBtn_Male
            // 
            this.rBtn_Male.AutoSize = true;
            this.rBtn_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.rBtn_Male.Location = new System.Drawing.Point(171, 193);
            this.rBtn_Male.Name = "rBtn_Male";
            this.rBtn_Male.Size = new System.Drawing.Size(63, 21);
            this.rBtn_Male.TabIndex = 32;
            this.rBtn_Male.TabStop = true;
            this.rBtn_Male.Text = "Male";
            this.rBtn_Male.UseVisualStyleBackColor = true;
            // 
            // DaTi_BDate
            // 
            this.DaTi_BDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.DaTi_BDate.CustomFormat = "dd/MM/yyyy";
            this.DaTi_BDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DaTi_BDate.Location = new System.Drawing.Point(171, 161);
            this.DaTi_BDate.MaxDate = new System.DateTime(2024, 3, 13, 0, 0, 0, 0);
            this.DaTi_BDate.MinDate = new System.DateTime(1899, 1, 1, 0, 0, 0, 0);
            this.DaTi_BDate.Name = "DaTi_BDate";
            this.DaTi_BDate.Size = new System.Drawing.Size(227, 26);
            this.DaTi_BDate.TabIndex = 25;
            this.DaTi_BDate.Value = new System.DateTime(2024, 3, 13, 0, 0, 0, 0);
            // 
            // txtB_Lname
            // 
            this.txtB_Lname.Location = new System.Drawing.Point(171, 129);
            this.txtB_Lname.Name = "txtB_Lname";
            this.txtB_Lname.Size = new System.Drawing.Size(227, 26);
            this.txtB_Lname.TabIndex = 31;
            // 
            // txtB_Fname
            // 
            this.txtB_Fname.Location = new System.Drawing.Point(171, 97);
            this.txtB_Fname.Name = "txtB_Fname";
            this.txtB_Fname.Size = new System.Drawing.Size(227, 26);
            this.txtB_Fname.TabIndex = 30;
            // 
            // txtB_StuID
            // 
            this.txtB_StuID.Location = new System.Drawing.Point(171, 65);
            this.txtB_StuID.Name = "txtB_StuID";
            this.txtB_StuID.Size = new System.Drawing.Size(227, 26);
            this.txtB_StuID.TabIndex = 29;
            this.txtB_StuID.TextChanged += new System.EventHandler(this.txtB_StuID_TextChanged);
            // 
            // lbl_Pic
            // 
            this.lbl_Pic.AutoSize = true;
            this.lbl_Pic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pic.Location = new System.Drawing.Point(28, 357);
            this.lbl_Pic.Name = "lbl_Pic";
            this.lbl_Pic.Size = new System.Drawing.Size(66, 22);
            this.lbl_Pic.TabIndex = 27;
            this.lbl_Pic.Text = "Picture";
            // 
            // lbl_Addr
            // 
            this.lbl_Addr.AutoSize = true;
            this.lbl_Addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Addr.Location = new System.Drawing.Point(28, 256);
            this.lbl_Addr.Name = "lbl_Addr";
            this.lbl_Addr.Size = new System.Drawing.Size(76, 22);
            this.lbl_Addr.TabIndex = 26;
            this.lbl_Addr.Text = "Address";
            // 
            // lbl_Pnumber
            // 
            this.lbl_Pnumber.AutoSize = true;
            this.lbl_Pnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Pnumber.Location = new System.Drawing.Point(28, 227);
            this.lbl_Pnumber.Name = "lbl_Pnumber";
            this.lbl_Pnumber.Size = new System.Drawing.Size(127, 22);
            this.lbl_Pnumber.TabIndex = 24;
            this.lbl_Pnumber.Text = "Phone number";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Gender.Location = new System.Drawing.Point(28, 195);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(70, 22);
            this.lbl_Gender.TabIndex = 23;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_BDate
            // 
            this.lbl_BDate.AutoSize = true;
            this.lbl_BDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_BDate.Location = new System.Drawing.Point(28, 165);
            this.lbl_BDate.Name = "lbl_BDate";
            this.lbl_BDate.Size = new System.Drawing.Size(90, 22);
            this.lbl_BDate.TabIndex = 22;
            this.lbl_BDate.Text = "Birth Date";
            // 
            // lbl_Lname
            // 
            this.lbl_Lname.AutoSize = true;
            this.lbl_Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Lname.Location = new System.Drawing.Point(28, 133);
            this.lbl_Lname.Name = "lbl_Lname";
            this.lbl_Lname.Size = new System.Drawing.Size(88, 22);
            this.lbl_Lname.TabIndex = 21;
            this.lbl_Lname.Text = "Lastname";
            // 
            // lbl_Fname
            // 
            this.lbl_Fname.AutoSize = true;
            this.lbl_Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Fname.Location = new System.Drawing.Point(28, 101);
            this.lbl_Fname.Name = "lbl_Fname";
            this.lbl_Fname.Size = new System.Drawing.Size(89, 22);
            this.lbl_Fname.TabIndex = 20;
            this.lbl_Fname.Text = "Firstname";
            // 
            // lbl_StuID
            // 
            this.lbl_StuID.AutoSize = true;
            this.lbl_StuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_StuID.Location = new System.Drawing.Point(28, 69);
            this.lbl_StuID.Name = "lbl_StuID";
            this.lbl_StuID.Size = new System.Drawing.Size(94, 22);
            this.lbl_StuID.TabIndex = 19;
            this.lbl_StuID.Text = "Student ID";
            // 
            // bttn_Download
            // 
            this.bttn_Download.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bttn_Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.bttn_Download.Location = new System.Drawing.Point(292, 514);
            this.bttn_Download.Name = "bttn_Download";
            this.bttn_Download.Size = new System.Drawing.Size(90, 32);
            this.bttn_Download.TabIndex = 38;
            this.bttn_Download.Text = "Download";
            this.bttn_Download.UseVisualStyleBackColor = false;
            this.bttn_Download.Click += new System.EventHandler(this.bttn_Download_Click);
            // 
            // dGV_1
            // 
            this.dGV_1.AllowUserToAddRows = false;
            this.dGV_1.AllowUserToDeleteRows = false;
            this.dGV_1.AllowUserToResizeRows = false;
            this.dGV_1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGV_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_1.Location = new System.Drawing.Point(423, 65);
            this.dGV_1.Name = "dGV_1";
            this.dGV_1.ReadOnly = true;
            this.dGV_1.RowHeadersVisible = false;
            this.dGV_1.RowHeadersWidth = 62;
            this.dGV_1.RowTemplate.Height = 28;
            this.dGV_1.Size = new System.Drawing.Size(574, 443);
            this.dGV_1.TabIndex = 39;
            this.dGV_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_1_CellClick);
            this.dGV_1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_1_CellContentDoubleClick);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Total.Location = new System.Drawing.Point(3, 14);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(129, 22);
            this.lbl_Total.TabIndex = 40;
            this.lbl_Total.Text = "Total students:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Total);
            this.panel1.Location = new System.Drawing.Point(840, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 44);
            this.panel1.TabIndex = 41;
            // 
            // txtB_Search
            // 
            this.txtB_Search.Location = new System.Drawing.Point(738, 33);
            this.txtB_Search.Name = "txtB_Search";
            this.txtB_Search.Size = new System.Drawing.Size(180, 26);
            this.txtB_Search.TabIndex = 42;
            // 
            // bttn_Search
            // 
            this.bttn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.bttn_Search.Location = new System.Drawing.Point(924, 33);
            this.bttn_Search.Name = "bttn_Search";
            this.bttn_Search.Size = new System.Drawing.Size(73, 31);
            this.bttn_Search.TabIndex = 43;
            this.bttn_Search.Text = "Search";
            this.bttn_Search.UseVisualStyleBackColor = true;
            this.bttn_Search.Click += new System.EventHandler(this.bttn_Search_Click);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Search.Location = new System.Drawing.Point(419, 37);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(301, 22);
            this.lbl_Search.TabIndex = 44;
            this.lbl_Search.Text = "Search firstname, lastname, address";
            // 
            // grpB_1
            // 
            this.grpB_1.BackColor = System.Drawing.SystemColors.Control;
            this.grpB_1.Controls.Add(this.bttn_Reset);
            this.grpB_1.Controls.Add(this.bttn_Remove);
            this.grpB_1.Controls.Add(this.bttn_Edit);
            this.grpB_1.Controls.Add(this.bttn_Add);
            this.grpB_1.Location = new System.Drawing.Point(120, 565);
            this.grpB_1.Name = "grpB_1";
            this.grpB_1.Size = new System.Drawing.Size(786, 77);
            this.grpB_1.TabIndex = 45;
            this.grpB_1.TabStop = false;
            // 
            // bttn_Reset
            // 
            this.bttn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bttn_Reset.ForeColor = System.Drawing.Color.Navy;
            this.bttn_Reset.Location = new System.Drawing.Point(596, 25);
            this.bttn_Reset.Name = "bttn_Reset";
            this.bttn_Reset.Size = new System.Drawing.Size(130, 34);
            this.bttn_Reset.TabIndex = 0;
            this.bttn_Reset.Text = "Reset";
            this.bttn_Reset.UseVisualStyleBackColor = true;
            this.bttn_Reset.Click += new System.EventHandler(this.bttn_Reset_Click);
            // 
            // bttn_Remove
            // 
            this.bttn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bttn_Remove.ForeColor = System.Drawing.Color.Maroon;
            this.bttn_Remove.Location = new System.Drawing.Point(418, 25);
            this.bttn_Remove.Name = "bttn_Remove";
            this.bttn_Remove.Size = new System.Drawing.Size(130, 34);
            this.bttn_Remove.TabIndex = 0;
            this.bttn_Remove.Text = "Remove";
            this.bttn_Remove.UseVisualStyleBackColor = true;
            this.bttn_Remove.Click += new System.EventHandler(this.bttn_Remove_Click);
            // 
            // bttn_Edit
            // 
            this.bttn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bttn_Edit.ForeColor = System.Drawing.Color.Olive;
            this.bttn_Edit.Location = new System.Drawing.Point(240, 25);
            this.bttn_Edit.Name = "bttn_Edit";
            this.bttn_Edit.Size = new System.Drawing.Size(130, 34);
            this.bttn_Edit.TabIndex = 0;
            this.bttn_Edit.Text = "Edit";
            this.bttn_Edit.UseVisualStyleBackColor = true;
            this.bttn_Edit.Click += new System.EventHandler(this.bttn_Edit_Click);
            // 
            // bttn_Add
            // 
            this.bttn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bttn_Add.ForeColor = System.Drawing.Color.Green;
            this.bttn_Add.Location = new System.Drawing.Point(62, 25);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(130, 34);
            this.bttn_Add.TabIndex = 0;
            this.bttn_Add.Text = "Add";
            this.bttn_Add.UseVisualStyleBackColor = true;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // erPr_Fname
            // 
            this.erPr_Fname.ContainerControl = this;
            // 
            // erPr_StuID
            // 
            this.erPr_StuID.ContainerControl = this;
            // 
            // erPr_Lname
            // 
            this.erPr_Lname.ContainerControl = this;
            // 
            // StuManageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 676);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.bttn_Search);
            this.Controls.Add(this.txtB_Search);
            this.Controls.Add(this.dGV_1);
            this.Controls.Add(this.bttn_Download);
            this.Controls.Add(this.bttn_Upload);
            this.Controls.Add(this.picB_Pic);
            this.Controls.Add(this.rtxtB_Addr);
            this.Controls.Add(this.txtB_Pnumber);
            this.Controls.Add(this.rBtn_Others);
            this.Controls.Add(this.rBtn_Female);
            this.Controls.Add(this.rBtn_Male);
            this.Controls.Add(this.DaTi_BDate);
            this.Controls.Add(this.txtB_Lname);
            this.Controls.Add(this.txtB_Fname);
            this.Controls.Add(this.txtB_StuID);
            this.Controls.Add(this.lbl_Pic);
            this.Controls.Add(this.lbl_Addr);
            this.Controls.Add(this.lbl_Pnumber);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_BDate);
            this.Controls.Add(this.lbl_Lname);
            this.Controls.Add(this.lbl_Fname);
            this.Controls.Add(this.lbl_StuID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpB_1);
            this.Name = "StuManageFrm";
            this.Text = "ManageStudentFrm";
            this.Load += new System.EventHandler(this.ManageStudentFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picB_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpB_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Fname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_StuID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Lname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Upload;
        private System.Windows.Forms.PictureBox picB_Pic;
        private System.Windows.Forms.RichTextBox rtxtB_Addr;
        private System.Windows.Forms.TextBox txtB_Pnumber;
        private System.Windows.Forms.RadioButton rBtn_Others;
        private System.Windows.Forms.RadioButton rBtn_Female;
        private System.Windows.Forms.RadioButton rBtn_Male;
        private System.Windows.Forms.DateTimePicker DaTi_BDate;
        private System.Windows.Forms.TextBox txtB_Lname;
        private System.Windows.Forms.TextBox txtB_Fname;
        private System.Windows.Forms.TextBox txtB_StuID;
        private System.Windows.Forms.Label lbl_Pic;
        private System.Windows.Forms.Label lbl_Addr;
        private System.Windows.Forms.Label lbl_Pnumber;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_BDate;
        private System.Windows.Forms.Label lbl_Lname;
        private System.Windows.Forms.Label lbl_Fname;
        private System.Windows.Forms.Label lbl_StuID;
        private System.Windows.Forms.Button bttn_Download;
        private System.Windows.Forms.DataGridView dGV_1;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtB_Search;
        private System.Windows.Forms.Button bttn_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.GroupBox grpB_1;
        private System.Windows.Forms.Button bttn_Reset;
        private System.Windows.Forms.Button bttn_Remove;
        private System.Windows.Forms.Button bttn_Edit;
        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.ErrorProvider erPr_Fname;
        private System.Windows.Forms.ErrorProvider erPr_StuID;
        private System.Windows.Forms.ErrorProvider erPr_Lname;
    }
}