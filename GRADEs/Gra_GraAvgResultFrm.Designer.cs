namespace WIPR170124.GRADEs
{
    partial class Gra_GraAvgResultFrm
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
            this.dGV_Result = new System.Windows.Forms.DataGridView();
            this.lbl_StuID = new System.Windows.Forms.Label();
            this.lbl_FName = new System.Windows.Forms.Label();
            this.lbl_LName = new System.Windows.Forms.Label();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.txtB_StuID = new System.Windows.Forms.TextBox();
            this.txtB_FName = new System.Windows.Forms.TextBox();
            this.txtB_LName = new System.Windows.Forms.TextBox();
            this.txtB_Search = new System.Windows.Forms.TextBox();
            this.bttn_Print = new System.Windows.Forms.Button();
            this.bttn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Result
            // 
            this.dGV_Result.AllowUserToAddRows = false;
            this.dGV_Result.AllowUserToDeleteRows = false;
            this.dGV_Result.AllowUserToResizeColumns = false;
            this.dGV_Result.AllowUserToResizeRows = false;
            this.dGV_Result.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGV_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Result.Location = new System.Drawing.Point(12, 12);
            this.dGV_Result.Name = "dGV_Result";
            this.dGV_Result.ReadOnly = true;
            this.dGV_Result.RowHeadersVisible = false;
            this.dGV_Result.RowHeadersWidth = 51;
            this.dGV_Result.RowTemplate.Height = 24;
            this.dGV_Result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Result.Size = new System.Drawing.Size(951, 536);
            this.dGV_Result.TabIndex = 0;
            this.dGV_Result.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Result_CellClick);
            // 
            // lbl_StuID
            // 
            this.lbl_StuID.AutoSize = true;
            this.lbl_StuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_StuID.Location = new System.Drawing.Point(986, 97);
            this.lbl_StuID.Name = "lbl_StuID";
            this.lbl_StuID.Size = new System.Drawing.Size(76, 18);
            this.lbl_StuID.TabIndex = 1;
            this.lbl_StuID.Text = "Student ID";
            // 
            // lbl_FName
            // 
            this.lbl_FName.AutoSize = true;
            this.lbl_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_FName.Location = new System.Drawing.Point(986, 162);
            this.lbl_FName.Name = "lbl_FName";
            this.lbl_FName.Size = new System.Drawing.Size(74, 18);
            this.lbl_FName.TabIndex = 1;
            this.lbl_FName.Text = "Firstname";
            // 
            // lbl_LName
            // 
            this.lbl_LName.AutoSize = true;
            this.lbl_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_LName.Location = new System.Drawing.Point(986, 227);
            this.lbl_LName.Name = "lbl_LName";
            this.lbl_LName.Size = new System.Drawing.Size(73, 18);
            this.lbl_LName.TabIndex = 1;
            this.lbl_LName.Text = "Lastname";
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.Location = new System.Drawing.Point(986, 338);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(180, 18);
            this.lbl_Search.TabIndex = 1;
            this.lbl_Search.Text = "Search by ID or Firstname";
            // 
            // txtB_StuID
            // 
            this.txtB_StuID.Location = new System.Drawing.Point(988, 118);
            this.txtB_StuID.Name = "txtB_StuID";
            this.txtB_StuID.Size = new System.Drawing.Size(101, 22);
            this.txtB_StuID.TabIndex = 2;
            // 
            // txtB_FName
            // 
            this.txtB_FName.Location = new System.Drawing.Point(988, 183);
            this.txtB_FName.Name = "txtB_FName";
            this.txtB_FName.Size = new System.Drawing.Size(123, 22);
            this.txtB_FName.TabIndex = 2;
            // 
            // txtB_LName
            // 
            this.txtB_LName.Location = new System.Drawing.Point(988, 248);
            this.txtB_LName.Name = "txtB_LName";
            this.txtB_LName.Size = new System.Drawing.Size(187, 22);
            this.txtB_LName.TabIndex = 2;
            // 
            // txtB_Search
            // 
            this.txtB_Search.Location = new System.Drawing.Point(990, 359);
            this.txtB_Search.Name = "txtB_Search";
            this.txtB_Search.Size = new System.Drawing.Size(176, 22);
            this.txtB_Search.TabIndex = 2;
            // 
            // bttn_Print
            // 
            this.bttn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bttn_Print.Location = new System.Drawing.Point(1069, 458);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(86, 32);
            this.bttn_Print.TabIndex = 3;
            this.bttn_Print.Text = "Print";
            this.bttn_Print.UseVisualStyleBackColor = true;
            this.bttn_Print.Click += new System.EventHandler(this.bttn_Print_Click);
            // 
            // bttn_Search
            // 
            this.bttn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.bttn_Search.Location = new System.Drawing.Point(1172, 358);
            this.bttn_Search.Name = "bttn_Search";
            this.bttn_Search.Size = new System.Drawing.Size(69, 25);
            this.bttn_Search.TabIndex = 3;
            this.bttn_Search.Text = "Search";
            this.bttn_Search.UseVisualStyleBackColor = true;
            this.bttn_Search.Click += new System.EventHandler(this.bttn_Search_Click);
            // 
            // Gra_GraAvgResultFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 560);
            this.Controls.Add(this.bttn_Search);
            this.Controls.Add(this.bttn_Print);
            this.Controls.Add(this.txtB_Search);
            this.Controls.Add(this.txtB_LName);
            this.Controls.Add(this.txtB_FName);
            this.Controls.Add(this.txtB_StuID);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.lbl_LName);
            this.Controls.Add(this.lbl_FName);
            this.Controls.Add(this.lbl_StuID);
            this.Controls.Add(this.dGV_Result);
            this.Name = "Gra_GraAvgResultFrm";
            this.Text = "Score Average Result";
            this.Load += new System.EventHandler(this.Gra_GraAvgResultFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Result;
        private System.Windows.Forms.Label lbl_StuID;
        private System.Windows.Forms.Label lbl_FName;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txtB_StuID;
        private System.Windows.Forms.TextBox txtB_FName;
        private System.Windows.Forms.TextBox txtB_LName;
        private System.Windows.Forms.TextBox txtB_Search;
        private System.Windows.Forms.Button bttn_Print;
        private System.Windows.Forms.Button bttn_Search;
        private System.Windows.Forms.Label lbl_LName;
    }
}