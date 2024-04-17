namespace WIPR170124
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnStrp_1 = new System.Windows.Forms.MenuStrip();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birthMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accounToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTHERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestForAdministrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlTp_1 = new System.Windows.Forms.ToolTip(this.components);
            this.dGV_Accounts = new System.Windows.Forms.DataGridView();
            this.bttn_Done = new System.Windows.Forms.Button();
            this.scoreAverageResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrp_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Accounts)).BeginInit();
            this.SuspendLayout();
            // 
            // mnStrp_1
            // 
            this.mnStrp_1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnStrp_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTToolStripMenuItem,
            this.cOURSEToolStripMenuItem,
            this.sCOREToolStripMenuItem,
            this.aDMINToolStripMenuItem,
            this.oTHERSToolStripMenuItem});
            this.mnStrp_1.Location = new System.Drawing.Point(0, 0);
            this.mnStrp_1.Name = "mnStrp_1";
            this.mnStrp_1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnStrp_1.Size = new System.Drawing.Size(904, 28);
            this.mnStrp_1.TabIndex = 0;
            this.mnStrp_1.Text = "mnStrp_1";
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.studentListToolStripMenuItem,
            this.staticsToolStripMenuItem,
            this.editRemoveToolStripMenuItem,
            this.manageStudentFormToolStripMenuItem,
            this.printToolStripMenuItem});
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.sTUDENTToolStripMenuItem.Text = "STUDENT";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.studentListToolStripMenuItem.Text = "Student List";
            this.studentListToolStripMenuItem.Click += new System.EventHandler(this.studentListToolStripMenuItem_Click);
            // 
            // staticsToolStripMenuItem
            // 
            this.staticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genderToolStripMenuItem,
            this.birthMonthToolStripMenuItem});
            this.staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            this.staticsToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.staticsToolStripMenuItem.Text = "Statistics";
            // 
            // genderToolStripMenuItem
            // 
            this.genderToolStripMenuItem.Name = "genderToolStripMenuItem";
            this.genderToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.genderToolStripMenuItem.Text = "Gender";
            this.genderToolStripMenuItem.Click += new System.EventHandler(this.genderToolStripMenuItem_Click);
            // 
            // birthMonthToolStripMenuItem
            // 
            this.birthMonthToolStripMenuItem.Name = "birthMonthToolStripMenuItem";
            this.birthMonthToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.birthMonthToolStripMenuItem.Text = "Birth Month";
            this.birthMonthToolStripMenuItem.Click += new System.EventHandler(this.birthMonthToolStripMenuItem_Click);
            // 
            // editRemoveToolStripMenuItem
            // 
            this.editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            this.editRemoveToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.editRemoveToolStripMenuItem.Text = "Edit / Remove";
            this.editRemoveToolStripMenuItem.Click += new System.EventHandler(this.editRemoveToolStripMenuItem_Click);
            // 
            // manageStudentFormToolStripMenuItem
            // 
            this.manageStudentFormToolStripMenuItem.Name = "manageStudentFormToolStripMenuItem";
            this.manageStudentFormToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.manageStudentFormToolStripMenuItem.Text = "Manage Student Form";
            this.manageStudentFormToolStripMenuItem.Click += new System.EventHandler(this.manageStudentFormToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // cOURSEToolStripMenuItem
            // 
            this.cOURSEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.removeCourseToolStripMenuItem,
            this.editCourseToolStripMenuItem,
            this.manageCourseToolStripMenuItem,
            this.printToolStripMenuItem1});
            this.cOURSEToolStripMenuItem.Name = "cOURSEToolStripMenuItem";
            this.cOURSEToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.cOURSEToolStripMenuItem.Text = "COURSE";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // removeCourseToolStripMenuItem
            // 
            this.removeCourseToolStripMenuItem.Name = "removeCourseToolStripMenuItem";
            this.removeCourseToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.removeCourseToolStripMenuItem.Text = "Edit Course";
            this.removeCourseToolStripMenuItem.Click += new System.EventHandler(this.removeCourseToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.editCourseToolStripMenuItem.Text = "Remove Course";
            this.editCourseToolStripMenuItem.Click += new System.EventHandler(this.editCourseToolStripMenuItem_Click);
            // 
            // manageCourseToolStripMenuItem
            // 
            this.manageCourseToolStripMenuItem.Name = "manageCourseToolStripMenuItem";
            this.manageCourseToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.manageCourseToolStripMenuItem.Text = "Manage Course";
            this.manageCourseToolStripMenuItem.Click += new System.EventHandler(this.manageCourseToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(195, 26);
            this.printToolStripMenuItem1.Text = "Print";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.printToolStripMenuItem1_Click);
            // 
            // sCOREToolStripMenuItem
            // 
            this.sCOREToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addScoreToolStripMenuItem,
            this.removeScoreToolStripMenuItem,
            this.manageScoreToolStripMenuItem,
            this.averageToolStripMenuItem,
            this.printToolStripMenuItem2,
            this.resultToolStripMenuItem});
            this.sCOREToolStripMenuItem.Name = "sCOREToolStripMenuItem";
            this.sCOREToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.sCOREToolStripMenuItem.Text = "SCORE";
            // 
            // addScoreToolStripMenuItem
            // 
            this.addScoreToolStripMenuItem.Name = "addScoreToolStripMenuItem";
            this.addScoreToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.addScoreToolStripMenuItem.Text = "Add Score";
            this.addScoreToolStripMenuItem.Click += new System.EventHandler(this.addScoreToolStripMenuItem_Click);
            // 
            // removeScoreToolStripMenuItem
            // 
            this.removeScoreToolStripMenuItem.Name = "removeScoreToolStripMenuItem";
            this.removeScoreToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.removeScoreToolStripMenuItem.Text = "Remove Score";
            this.removeScoreToolStripMenuItem.Click += new System.EventHandler(this.removeScoreToolStripMenuItem_Click);
            // 
            // manageScoreToolStripMenuItem
            // 
            this.manageScoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byCoursesToolStripMenuItem,
            this.byStudentsToolStripMenuItem});
            this.manageScoreToolStripMenuItem.Name = "manageScoreToolStripMenuItem";
            this.manageScoreToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.manageScoreToolStripMenuItem.Text = "Manage Score";
            // 
            // byCoursesToolStripMenuItem
            // 
            this.byCoursesToolStripMenuItem.Name = "byCoursesToolStripMenuItem";
            this.byCoursesToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.byCoursesToolStripMenuItem.Text = "By Courses";
            this.byCoursesToolStripMenuItem.Click += new System.EventHandler(this.byCoursesToolStripMenuItem_Click);
            // 
            // byStudentsToolStripMenuItem
            // 
            this.byStudentsToolStripMenuItem.Name = "byStudentsToolStripMenuItem";
            this.byStudentsToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.byStudentsToolStripMenuItem.Text = "By Students";
            this.byStudentsToolStripMenuItem.Click += new System.EventHandler(this.byStudentsToolStripMenuItem_Click);
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.averageToolStripMenuItem.Text = "Average";
            this.averageToolStripMenuItem.Click += new System.EventHandler(this.averageToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem2
            // 
            this.printToolStripMenuItem2.Name = "printToolStripMenuItem2";
            this.printToolStripMenuItem2.Size = new System.Drawing.Size(187, 26);
            this.printToolStripMenuItem2.Text = "Print";
            this.printToolStripMenuItem2.Click += new System.EventHandler(this.printToolStripMenuItem2_Click);
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoreAverageResultToolStripMenuItem,
            this.statisticResultToolStripMenuItem});
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.resultToolStripMenuItem.Text = "Result";
            // 
            // aDMINToolStripMenuItem
            // 
            this.aDMINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accounToolStripMenuItem,
            this.requestsToolStripMenuItem});
            this.aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            this.aDMINToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.aDMINToolStripMenuItem.Text = "ADMIN";
            this.aDMINToolStripMenuItem.Click += new System.EventHandler(this.aDMINToolStripMenuItem_Click);
            // 
            // accounToolStripMenuItem
            // 
            this.accounToolStripMenuItem.Name = "accounToolStripMenuItem";
            this.accounToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.accounToolStripMenuItem.Text = "Accounts";
            this.accounToolStripMenuItem.Click += new System.EventHandler(this.accounToolStripMenuItem_Click);
            // 
            // requestsToolStripMenuItem
            // 
            this.requestsToolStripMenuItem.Name = "requestsToolStripMenuItem";
            this.requestsToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.requestsToolStripMenuItem.Text = "Requests";
            this.requestsToolStripMenuItem.Click += new System.EventHandler(this.requestsToolStripMenuItem_Click);
            // 
            // oTHERSToolStripMenuItem
            // 
            this.oTHERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestForAdministrationToolStripMenuItem});
            this.oTHERSToolStripMenuItem.Name = "oTHERSToolStripMenuItem";
            this.oTHERSToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.oTHERSToolStripMenuItem.Text = "OTHERS";
            // 
            // requestForAdministrationToolStripMenuItem
            // 
            this.requestForAdministrationToolStripMenuItem.Name = "requestForAdministrationToolStripMenuItem";
            this.requestForAdministrationToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.requestForAdministrationToolStripMenuItem.Text = "Request for Administration";
            this.requestForAdministrationToolStripMenuItem.Click += new System.EventHandler(this.requestForAdministrationToolStripMenuItem_Click);
            // 
            // dGV_Accounts
            // 
            this.dGV_Accounts.AllowUserToAddRows = false;
            this.dGV_Accounts.AllowUserToDeleteRows = false;
            this.dGV_Accounts.AllowUserToResizeColumns = false;
            this.dGV_Accounts.AllowUserToResizeRows = false;
            this.dGV_Accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Accounts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Accounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dGV_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Accounts.DefaultCellStyle = dataGridViewCellStyle8;
            this.dGV_Accounts.Location = new System.Drawing.Point(11, 42);
            this.dGV_Accounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGV_Accounts.Name = "dGV_Accounts";
            this.dGV_Accounts.ReadOnly = true;
            this.dGV_Accounts.RowHeadersVisible = false;
            this.dGV_Accounts.RowHeadersWidth = 62;
            this.dGV_Accounts.RowTemplate.Height = 28;
            this.dGV_Accounts.Size = new System.Drawing.Size(881, 426);
            this.dGV_Accounts.TabIndex = 1;
            this.dGV_Accounts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Accounts_CellDoubleClick);
            // 
            // bttn_Done
            // 
            this.bttn_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.bttn_Done.Location = new System.Drawing.Point(821, 430);
            this.bttn_Done.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttn_Done.Name = "bttn_Done";
            this.bttn_Done.Size = new System.Drawing.Size(59, 26);
            this.bttn_Done.TabIndex = 2;
            this.bttn_Done.Text = "Done";
            this.bttn_Done.UseVisualStyleBackColor = true;
            this.bttn_Done.Click += new System.EventHandler(this.bttn_Done_Click);
            // 
            // scoreAverageResultToolStripMenuItem
            // 
            this.scoreAverageResultToolStripMenuItem.Name = "scoreAverageResultToolStripMenuItem";
            this.scoreAverageResultToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.scoreAverageResultToolStripMenuItem.Text = "Score Average Result";
            this.scoreAverageResultToolStripMenuItem.Click += new System.EventHandler(this.scoreAverageResultToolStripMenuItem_Click);
            // 
            // statisticResultToolStripMenuItem
            // 
            this.statisticResultToolStripMenuItem.Name = "statisticResultToolStripMenuItem";
            this.statisticResultToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.statisticResultToolStripMenuItem.Text = "Statistic Result";
            this.statisticResultToolStripMenuItem.Click += new System.EventHandler(this.statisticResultToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 479);
            this.Controls.Add(this.bttn_Done);
            this.Controls.Add(this.dGV_Accounts);
            this.Controls.Add(this.mnStrp_1);
            this.MainMenuStrip = this.mnStrp_1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mnStrp_1.ResumeLayout(false);
            this.mnStrp_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Accounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnStrp_1;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCOREToolStripMenuItem;
        private System.Windows.Forms.ToolTip tlTp_1;
        private System.Windows.Forms.ToolStripMenuItem aDMINToolStripMenuItem;
        private System.Windows.Forms.DataGridView dGV_Accounts;
        private System.Windows.Forms.ToolStripMenuItem accounToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestsToolStripMenuItem;
        private System.Windows.Forms.Button bttn_Done;
        private System.Windows.Forms.ToolStripMenuItem oTHERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestForAdministrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem genderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birthMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreAverageResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticResultToolStripMenuItem;
    }
}