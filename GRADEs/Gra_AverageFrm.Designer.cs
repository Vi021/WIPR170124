namespace WIPR170124.GRADEs
{
    partial class Gra_AverageFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV_Avg = new System.Windows.Forms.DataGridView();
            this.comB_By = new System.Windows.Forms.ComboBox();
            this.comB_Filter = new System.Windows.Forms.ComboBox();
            this.lbl_By = new System.Windows.Forms.Label();
            this.lbl_Avg = new System.Windows.Forms.Label();
            this.pnl_Avg = new System.Windows.Forms.Panel();
            this.lbl_Filter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Avg)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Avg
            // 
            this.dGV_Avg.AllowUserToAddRows = false;
            this.dGV_Avg.AllowUserToDeleteRows = false;
            this.dGV_Avg.AllowUserToResizeColumns = false;
            this.dGV_Avg.AllowUserToResizeRows = false;
            this.dGV_Avg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Avg.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_Avg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(141)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Avg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Avg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Avg.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Avg.Location = new System.Drawing.Point(11, 59);
            this.dGV_Avg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGV_Avg.Name = "dGV_Avg";
            this.dGV_Avg.ReadOnly = true;
            this.dGV_Avg.RowHeadersVisible = false;
            this.dGV_Avg.RowHeadersWidth = 62;
            this.dGV_Avg.RowTemplate.Height = 28;
            this.dGV_Avg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Avg.Size = new System.Drawing.Size(812, 395);
            this.dGV_Avg.TabIndex = 0;
            // 
            // comB_By
            // 
            this.comB_By.FormattingEnabled = true;
            this.comB_By.Items.AddRange(new object[] {
            "Courses",
            "Students"});
            this.comB_By.Location = new System.Drawing.Point(540, 28);
            this.comB_By.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comB_By.Name = "comB_By";
            this.comB_By.Size = new System.Drawing.Size(108, 24);
            this.comB_By.TabIndex = 1;
            this.comB_By.SelectedIndexChanged += new System.EventHandler(this.comB_By_SelectedIndexChanged);
            // 
            // comB_Filter
            // 
            this.comB_Filter.FormattingEnabled = true;
            this.comB_Filter.Items.AddRange(new object[] {
            "<5",
            "≥5",
            "All"});
            this.comB_Filter.Location = new System.Drawing.Point(718, 28);
            this.comB_Filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comB_Filter.Name = "comB_Filter";
            this.comB_Filter.Size = new System.Drawing.Size(86, 24);
            this.comB_Filter.TabIndex = 1;
            this.comB_Filter.SelectedIndexChanged += new System.EventHandler(this.comB_Filter_SelectedIndexChanged);
            // 
            // lbl_By
            // 
            this.lbl_By.AutoSize = true;
            this.lbl_By.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_By.Location = new System.Drawing.Point(509, 33);
            this.lbl_By.Name = "lbl_By";
            this.lbl_By.Size = new System.Drawing.Size(25, 18);
            this.lbl_By.TabIndex = 2;
            this.lbl_By.Text = "By";
            // 
            // lbl_Avg
            // 
            this.lbl_Avg.AutoSize = true;
            this.lbl_Avg.BackColor = System.Drawing.Color.OliveDrab;
            this.lbl_Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Avg.ForeColor = System.Drawing.Color.White;
            this.lbl_Avg.Location = new System.Drawing.Point(19, 30);
            this.lbl_Avg.Name = "lbl_Avg";
            this.lbl_Avg.Size = new System.Drawing.Size(186, 24);
            this.lbl_Avg.TabIndex = 3;
            this.lbl_Avg.Text = "AVERAGE SCORE";
            // 
            // pnl_Avg
            // 
            this.pnl_Avg.BackColor = System.Drawing.Color.OliveDrab;
            this.pnl_Avg.Location = new System.Drawing.Point(11, 22);
            this.pnl_Avg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Avg.Name = "pnl_Avg";
            this.pnl_Avg.Size = new System.Drawing.Size(210, 37);
            this.pnl_Avg.TabIndex = 4;
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.AutoSize = true;
            this.lbl_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Filter.Location = new System.Drawing.Point(672, 33);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(40, 18);
            this.lbl_Filter.TabIndex = 2;
            this.lbl_Filter.Text = "Filter";
            // 
            // Gra_AverageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 477);
            this.Controls.Add(this.lbl_Avg);
            this.Controls.Add(this.lbl_Filter);
            this.Controls.Add(this.lbl_By);
            this.Controls.Add(this.comB_Filter);
            this.Controls.Add(this.comB_By);
            this.Controls.Add(this.dGV_Avg);
            this.Controls.Add(this.pnl_Avg);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Gra_AverageFrm";
            this.Text = "Average score";
            this.Load += new System.EventHandler(this.Gra_AverageFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Avg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Avg;
        private System.Windows.Forms.ComboBox comB_By;
        private System.Windows.Forms.ComboBox comB_Filter;
        private System.Windows.Forms.Label lbl_By;
        private System.Windows.Forms.Label lbl_Avg;
        private System.Windows.Forms.Panel pnl_Avg;
        private System.Windows.Forms.Label lbl_Filter;
    }
}