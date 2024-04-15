namespace WIPR170124
{
    partial class StuPrintFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV_1 = new System.Windows.Forms.DataGridView();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.bttn_Done = new System.Windows.Forms.Button();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.comB_To = new System.Windows.Forms.ComboBox();
            this.comB_From = new System.Windows.Forms.ComboBox();
            this.comB_Filter = new System.Windows.Forms.ComboBox();
            this.lbl_Filter = new System.Windows.Forms.Label();
            this.cLB_Gender = new System.Windows.Forms.CheckedListBox();
            this.lbl_Options = new System.Windows.Forms.Label();
            this.bttn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_1)).BeginInit();
            this.pnl_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_1
            // 
            this.dGV_1.AllowUserToAddRows = false;
            this.dGV_1.AllowUserToDeleteRows = false;
            this.dGV_1.AllowUserToResizeColumns = false;
            this.dGV_1.AllowUserToResizeRows = false;
            this.dGV_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(191)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dGV_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(191)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dGV_1.GridColor = System.Drawing.Color.AliceBlue;
            this.dGV_1.Location = new System.Drawing.Point(12, 12);
            this.dGV_1.Name = "dGV_1";
            this.dGV_1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(191)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dGV_1.RowHeadersVisible = false;
            this.dGV_1.RowHeadersWidth = 62;
            this.dGV_1.RowTemplate.Height = 28;
            this.dGV_1.Size = new System.Drawing.Size(840, 464);
            this.dGV_1.StandardTab = true;
            this.dGV_1.TabIndex = 0;
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnl_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_1.Controls.Add(this.bttn_Done);
            this.pnl_1.Controls.Add(this.lbl_To);
            this.pnl_1.Controls.Add(this.lbl_From);
            this.pnl_1.Controls.Add(this.comB_To);
            this.pnl_1.Controls.Add(this.comB_From);
            this.pnl_1.Controls.Add(this.comB_Filter);
            this.pnl_1.Controls.Add(this.lbl_Filter);
            this.pnl_1.Controls.Add(this.cLB_Gender);
            this.pnl_1.Location = new System.Drawing.Point(872, 116);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(282, 229);
            this.pnl_1.TabIndex = 1;
            // 
            // bttn_Done
            // 
            this.bttn_Done.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttn_Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.bttn_Done.Location = new System.Drawing.Point(105, 184);
            this.bttn_Done.Name = "bttn_Done";
            this.bttn_Done.Size = new System.Drawing.Size(73, 31);
            this.bttn_Done.TabIndex = 3;
            this.bttn_Done.Text = "Done";
            this.bttn_Done.UseVisualStyleBackColor = false;
            this.bttn_Done.Click += new System.EventHandler(this.bttn_Done_Click);
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.BackColor = System.Drawing.Color.Transparent;
            this.lbl_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To.Location = new System.Drawing.Point(20, 127);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(27, 20);
            this.lbl_To.TabIndex = 2;
            this.lbl_To.Text = "To";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.BackColor = System.Drawing.Color.Transparent;
            this.lbl_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From.Location = new System.Drawing.Point(20, 73);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(46, 20);
            this.lbl_From.TabIndex = 2;
            this.lbl_From.Text = "From";
            // 
            // comB_To
            // 
            this.comB_To.FormattingEnabled = true;
            this.comB_To.Location = new System.Drawing.Point(24, 150);
            this.comB_To.Name = "comB_To";
            this.comB_To.Size = new System.Drawing.Size(235, 28);
            this.comB_To.TabIndex = 1;
            // 
            // comB_From
            // 
            this.comB_From.FormattingEnabled = true;
            this.comB_From.Location = new System.Drawing.Point(24, 96);
            this.comB_From.Name = "comB_From";
            this.comB_From.Size = new System.Drawing.Size(235, 28);
            this.comB_From.TabIndex = 1;
            // 
            // comB_Filter
            // 
            this.comB_Filter.FormattingEnabled = true;
            this.comB_Filter.Items.AddRange(new object[] {
            "Student ID",
            "Gender"});
            this.comB_Filter.Location = new System.Drawing.Point(23, 38);
            this.comB_Filter.Name = "comB_Filter";
            this.comB_Filter.Size = new System.Drawing.Size(235, 28);
            this.comB_Filter.TabIndex = 1;
            this.comB_Filter.SelectedIndexChanged += new System.EventHandler(this.comB_Filter_SelectedIndexChanged);
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.AutoSize = true;
            this.lbl_Filter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filter.Location = new System.Drawing.Point(19, 13);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(74, 22);
            this.lbl_Filter.TabIndex = 0;
            this.lbl_Filter.Text = "Filter by";
            // 
            // cLB_Gender
            // 
            this.cLB_Gender.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cLB_Gender.FormattingEnabled = true;
            this.cLB_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cLB_Gender.Location = new System.Drawing.Point(23, 93);
            this.cLB_Gender.Name = "cLB_Gender";
            this.cLB_Gender.Size = new System.Drawing.Size(235, 73);
            this.cLB_Gender.TabIndex = 4;
            // 
            // lbl_Options
            // 
            this.lbl_Options.AutoSize = true;
            this.lbl_Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Options.Location = new System.Drawing.Point(957, 88);
            this.lbl_Options.Name = "lbl_Options";
            this.lbl_Options.Size = new System.Drawing.Size(110, 25);
            this.lbl_Options.TabIndex = 2;
            this.lbl_Options.Text = "OPTIONS";
            // 
            // bttn_Print
            // 
            this.bttn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(191)))), ((int)(((byte)(241)))));
            this.bttn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Print.Location = new System.Drawing.Point(962, 361);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(106, 41);
            this.bttn_Print.TabIndex = 3;
            this.bttn_Print.Text = "Print";
            this.bttn_Print.UseVisualStyleBackColor = false;
            this.bttn_Print.Click += new System.EventHandler(this.bttn_Print_Click);
            // 
            // StuPrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1172, 488);
            this.Controls.Add(this.bttn_Print);
            this.Controls.Add(this.lbl_Options);
            this.Controls.Add(this.pnl_1);
            this.Controls.Add(this.dGV_1);
            this.Name = "StuPrintFrm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Printer";
            this.Load += new System.EventHandler(this.PrinterFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_1)).EndInit();
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_1;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Label lbl_Options;
        private System.Windows.Forms.Button bttn_Print;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.ComboBox comB_To;
        private System.Windows.Forms.ComboBox comB_From;
        private System.Windows.Forms.ComboBox comB_Filter;
        private System.Windows.Forms.Label lbl_Filter;
        private System.Windows.Forms.CheckedListBox cLB_Gender;
        private System.Windows.Forms.Button bttn_Done;
    }
}