namespace WIPR170124.GRADEs
{
    partial class Gra_ManageFrm
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
            this.dGV_List = new System.Windows.Forms.DataGridView();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.comB_ID = new System.Windows.Forms.ComboBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txtB_Name = new System.Windows.Forms.TextBox();
            this.lbl_Sem = new System.Windows.Forms.Label();
            this.comB_Sem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_List
            // 
            this.dGV_List.AllowUserToAddRows = false;
            this.dGV_List.AllowUserToDeleteRows = false;
            this.dGV_List.AllowUserToResizeColumns = false;
            this.dGV_List.AllowUserToResizeRows = false;
            this.dGV_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_List.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_List.Location = new System.Drawing.Point(12, 70);
            this.dGV_List.Name = "dGV_List";
            this.dGV_List.RowHeadersVisible = false;
            this.dGV_List.RowHeadersWidth = 62;
            this.dGV_List.RowTemplate.Height = 28;
            this.dGV_List.Size = new System.Drawing.Size(704, 432);
            this.dGV_List.TabIndex = 0;
            this.dGV_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_List_CellDoubleClick);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_ID.Location = new System.Drawing.Point(25, 31);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(32, 22);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID:";
            // 
            // comB_ID
            // 
            this.comB_ID.FormattingEnabled = true;
            this.comB_ID.Location = new System.Drawing.Point(61, 25);
            this.comB_ID.Name = "comB_ID";
            this.comB_ID.Size = new System.Drawing.Size(113, 28);
            this.comB_ID.TabIndex = 2;
            this.comB_ID.SelectedIndexChanged += new System.EventHandler(this.comB_ID_SelectedIndexChanged);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Name.Location = new System.Drawing.Point(190, 31);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(62, 22);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Name:";
            // 
            // txtB_Name
            // 
            this.txtB_Name.Location = new System.Drawing.Point(258, 25);
            this.txtB_Name.Name = "txtB_Name";
            this.txtB_Name.ReadOnly = true;
            this.txtB_Name.Size = new System.Drawing.Size(257, 26);
            this.txtB_Name.TabIndex = 4;
            // 
            // lbl_Sem
            // 
            this.lbl_Sem.AutoSize = true;
            this.lbl_Sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Sem.Location = new System.Drawing.Point(536, 31);
            this.lbl_Sem.Name = "lbl_Sem";
            this.lbl_Sem.Size = new System.Drawing.Size(91, 22);
            this.lbl_Sem.TabIndex = 1;
            this.lbl_Sem.Text = "Semester:";
            // 
            // comB_Sem
            // 
            this.comB_Sem.FormattingEnabled = true;
            this.comB_Sem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "All"});
            this.comB_Sem.Location = new System.Drawing.Point(633, 25);
            this.comB_Sem.Name = "comB_Sem";
            this.comB_Sem.Size = new System.Drawing.Size(60, 28);
            this.comB_Sem.TabIndex = 2;
            this.comB_Sem.SelectedIndexChanged += new System.EventHandler(this.comB_Sem_SelectedIndexChanged);
            // 
            // Gra_ManageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 514);
            this.Controls.Add(this.txtB_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.comB_Sem);
            this.Controls.Add(this.lbl_Sem);
            this.Controls.Add(this.comB_ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.dGV_List);
            this.Name = "Gra_ManageFrm";
            this.Text = "Manage score";
            this.Load += new System.EventHandler(this.Gra_ManageFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_List;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.ComboBox comB_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txtB_Name;
        private System.Windows.Forms.Label lbl_Sem;
        private System.Windows.Forms.ComboBox comB_Sem;
    }
}