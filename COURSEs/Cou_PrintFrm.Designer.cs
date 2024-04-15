namespace WIPR170124.COURSEs
{
    partial class Cou_PrintFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV_Print = new System.Windows.Forms.DataGridView();
            this.bttn_Print = new System.Windows.Forms.Button();
            this.bttn_ToFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Print)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Print
            // 
            this.dGV_Print.AllowUserToAddRows = false;
            this.dGV_Print.AllowUserToDeleteRows = false;
            this.dGV_Print.AllowUserToResizeColumns = false;
            this.dGV_Print.AllowUserToResizeRows = false;
            this.dGV_Print.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Print.BackgroundColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Print.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_Print.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Print.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_Print.Location = new System.Drawing.Point(12, 12);
            this.dGV_Print.Name = "dGV_Print";
            this.dGV_Print.RowHeadersVisible = false;
            this.dGV_Print.RowHeadersWidth = 62;
            this.dGV_Print.RowTemplate.Height = 28;
            this.dGV_Print.Size = new System.Drawing.Size(880, 395);
            this.dGV_Print.TabIndex = 0;
            // 
            // bttn_Print
            // 
            this.bttn_Print.BackColor = System.Drawing.Color.Goldenrod;
            this.bttn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Print.Location = new System.Drawing.Point(478, 423);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(105, 39);
            this.bttn_Print.TabIndex = 1;
            this.bttn_Print.Text = "Print";
            this.bttn_Print.UseVisualStyleBackColor = false;
            this.bttn_Print.Click += new System.EventHandler(this.bttn_Print_Click);
            // 
            // bttn_ToFile
            // 
            this.bttn_ToFile.BackColor = System.Drawing.Color.Cornsilk;
            this.bttn_ToFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttn_ToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_ToFile.Location = new System.Drawing.Point(322, 423);
            this.bttn_ToFile.Name = "bttn_ToFile";
            this.bttn_ToFile.Size = new System.Drawing.Size(105, 39);
            this.bttn_ToFile.TabIndex = 1;
            this.bttn_ToFile.Text = "To File";
            this.bttn_ToFile.UseVisualStyleBackColor = false;
            // 
            // Cou_PrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(904, 480);
            this.Controls.Add(this.bttn_ToFile);
            this.Controls.Add(this.bttn_Print);
            this.Controls.Add(this.dGV_Print);
            this.Name = "Cou_PrintFrm";
            this.Text = "Print course";
            this.Load += new System.EventHandler(this.Cou_PrintFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Print)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Print;
        private System.Windows.Forms.Button bttn_Print;
        private System.Windows.Forms.Button bttn_ToFile;
    }
}