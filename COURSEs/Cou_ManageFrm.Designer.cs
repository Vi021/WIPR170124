namespace WIPR170124.COURSEs
{
    partial class Cou_ManageFrm
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
            this.dGV_Courses = new System.Windows.Forms.DataGridView();
            this.nUD_Period = new System.Windows.Forms.NumericUpDown();
            this.lbl_Descr = new System.Windows.Forms.Label();
            this.lbl_Period = new System.Windows.Forms.Label();
            this.lbl_CID = new System.Windows.Forms.Label();
            this.lbl_CName = new System.Windows.Forms.Label();
            this.rTB_Descr = new System.Windows.Forms.RichTextBox();
            this.txtB_CID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.bttn_Edit = new System.Windows.Forms.Button();
            this.bttn_Remove = new System.Windows.Forms.Button();
            this.txtB_CName = new System.Windows.Forms.TextBox();
            this.erPr_CID = new System.Windows.Forms.ErrorProvider(this.components);
            this.erPr_CName = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_TotalC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Courses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Period)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_CID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_CName)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Courses
            // 
            this.dGV_Courses.AllowUserToAddRows = false;
            this.dGV_Courses.AllowUserToDeleteRows = false;
            this.dGV_Courses.AllowUserToResizeColumns = false;
            this.dGV_Courses.AllowUserToResizeRows = false;
            this.dGV_Courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Courses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGV_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Courses.Location = new System.Drawing.Point(12, 12);
            this.dGV_Courses.Name = "dGV_Courses";
            this.dGV_Courses.ReadOnly = true;
            this.dGV_Courses.RowHeadersVisible = false;
            this.dGV_Courses.RowHeadersWidth = 62;
            this.dGV_Courses.RowTemplate.Height = 28;
            this.dGV_Courses.Size = new System.Drawing.Size(697, 428);
            this.dGV_Courses.TabIndex = 0;
            this.dGV_Courses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Courses_CellDoubleClick);
            this.dGV_Courses.Click += new System.EventHandler(this.dGV_Courses_Click);
            // 
            // nUD_Period
            // 
            this.nUD_Period.Location = new System.Drawing.Point(843, 190);
            this.nUD_Period.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nUD_Period.Name = "nUD_Period";
            this.nUD_Period.Size = new System.Drawing.Size(96, 26);
            this.nUD_Period.TabIndex = 25;
            this.nUD_Period.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // lbl_Descr
            // 
            this.lbl_Descr.AutoSize = true;
            this.lbl_Descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descr.Location = new System.Drawing.Point(732, 240);
            this.lbl_Descr.Name = "lbl_Descr";
            this.lbl_Descr.Size = new System.Drawing.Size(105, 22);
            this.lbl_Descr.TabIndex = 19;
            this.lbl_Descr.Text = "Description:";
            // 
            // lbl_Period
            // 
            this.lbl_Period.AutoSize = true;
            this.lbl_Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Period.Location = new System.Drawing.Point(770, 194);
            this.lbl_Period.Name = "lbl_Period";
            this.lbl_Period.Size = new System.Drawing.Size(67, 22);
            this.lbl_Period.TabIndex = 20;
            this.lbl_Period.Text = "Period:";
            // 
            // lbl_CID
            // 
            this.lbl_CID.AutoSize = true;
            this.lbl_CID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CID.Location = new System.Drawing.Point(742, 144);
            this.lbl_CID.Name = "lbl_CID";
            this.lbl_CID.Size = new System.Drawing.Size(95, 22);
            this.lbl_CID.TabIndex = 21;
            this.lbl_CID.Text = "Course ID:";
            // 
            // lbl_CName
            // 
            this.lbl_CName.AutoSize = true;
            this.lbl_CName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_CName.Location = new System.Drawing.Point(715, 94);
            this.lbl_CName.Name = "lbl_CName";
            this.lbl_CName.Size = new System.Drawing.Size(125, 22);
            this.lbl_CName.TabIndex = 22;
            this.lbl_CName.Text = "Course Name:";
            // 
            // rTB_Descr
            // 
            this.rTB_Descr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTB_Descr.Location = new System.Drawing.Point(843, 240);
            this.rTB_Descr.Name = "rTB_Descr";
            this.rTB_Descr.Size = new System.Drawing.Size(297, 116);
            this.rTB_Descr.TabIndex = 23;
            this.rTB_Descr.Text = "";
            // 
            // txtB_CID
            // 
            this.txtB_CID.Location = new System.Drawing.Point(843, 140);
            this.txtB_CID.Name = "txtB_CID";
            this.txtB_CID.Size = new System.Drawing.Size(96, 26);
            this.txtB_CID.TabIndex = 18;
            this.txtB_CID.TextChanged += new System.EventHandler(this.txtB_CID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(854, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "COURSE INFO";
            // 
            // bttn_Add
            // 
            this.bttn_Add.Location = new System.Drawing.Point(778, 393);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(89, 31);
            this.bttn_Add.TabIndex = 26;
            this.bttn_Add.Text = "Add";
            this.bttn_Add.UseVisualStyleBackColor = true;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // bttn_Edit
            // 
            this.bttn_Edit.Location = new System.Drawing.Point(896, 393);
            this.bttn_Edit.Name = "bttn_Edit";
            this.bttn_Edit.Size = new System.Drawing.Size(89, 31);
            this.bttn_Edit.TabIndex = 26;
            this.bttn_Edit.Text = "Edit";
            this.bttn_Edit.UseVisualStyleBackColor = true;
            this.bttn_Edit.Click += new System.EventHandler(this.bttn_Edit_Click);
            // 
            // bttn_Remove
            // 
            this.bttn_Remove.Location = new System.Drawing.Point(1014, 393);
            this.bttn_Remove.Name = "bttn_Remove";
            this.bttn_Remove.Size = new System.Drawing.Size(89, 31);
            this.bttn_Remove.TabIndex = 26;
            this.bttn_Remove.Text = "Remove";
            this.bttn_Remove.UseVisualStyleBackColor = true;
            this.bttn_Remove.Click += new System.EventHandler(this.bttn_Remove_Click);
            // 
            // txtB_CName
            // 
            this.txtB_CName.Location = new System.Drawing.Point(843, 90);
            this.txtB_CName.Name = "txtB_CName";
            this.txtB_CName.Size = new System.Drawing.Size(296, 26);
            this.txtB_CName.TabIndex = 27;
            // 
            // erPr_CID
            // 
            this.erPr_CID.ContainerControl = this;
            // 
            // erPr_CName
            // 
            this.erPr_CName.ContainerControl = this;
            // 
            // lbl_TotalC
            // 
            this.lbl_TotalC.AutoSize = true;
            this.lbl_TotalC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalC.Location = new System.Drawing.Point(21, 443);
            this.lbl_TotalC.Name = "lbl_TotalC";
            this.lbl_TotalC.Size = new System.Drawing.Size(64, 17);
            this.lbl_TotalC.TabIndex = 28;
            this.lbl_TotalC.Text = "Total: 0";
            // 
            // Cou_ManageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 483);
            this.Controls.Add(this.lbl_TotalC);
            this.Controls.Add(this.txtB_CName);
            this.Controls.Add(this.bttn_Remove);
            this.Controls.Add(this.bttn_Edit);
            this.Controls.Add(this.bttn_Add);
            this.Controls.Add(this.nUD_Period);
            this.Controls.Add(this.lbl_Descr);
            this.Controls.Add(this.lbl_Period);
            this.Controls.Add(this.lbl_CID);
            this.Controls.Add(this.lbl_CName);
            this.Controls.Add(this.rTB_Descr);
            this.Controls.Add(this.txtB_CID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_Courses);
            this.Name = "Cou_ManageFrm";
            this.Text = "Manage course";
            this.Load += new System.EventHandler(this.Cou_ManageFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Courses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Period)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_CID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_CName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Courses;
        private System.Windows.Forms.NumericUpDown nUD_Period;
        private System.Windows.Forms.Label lbl_Descr;
        private System.Windows.Forms.Label lbl_Period;
        private System.Windows.Forms.Label lbl_CID;
        private System.Windows.Forms.Label lbl_CName;
        private System.Windows.Forms.RichTextBox rTB_Descr;
        private System.Windows.Forms.TextBox txtB_CID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.Button bttn_Edit;
        private System.Windows.Forms.Button bttn_Remove;
        private System.Windows.Forms.TextBox txtB_CName;
        private System.Windows.Forms.ErrorProvider erPr_CID;
        private System.Windows.Forms.ErrorProvider erPr_CName;
        private System.Windows.Forms.Label lbl_TotalC;
    }
}