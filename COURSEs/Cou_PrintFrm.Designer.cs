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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV_Print = new System.Windows.Forms.DataGridView();
            this.bttn_Print = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Print.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Print.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Print.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Print.Location = new System.Drawing.Point(11, 10);
            this.dGV_Print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGV_Print.Name = "dGV_Print";
            this.dGV_Print.RowHeadersVisible = false;
            this.dGV_Print.RowHeadersWidth = 62;
            this.dGV_Print.RowTemplate.Height = 28;
            this.dGV_Print.Size = new System.Drawing.Size(782, 316);
            this.dGV_Print.TabIndex = 0;
            // 
            // bttn_Print
            // 
            this.bttn_Print.BackColor = System.Drawing.Color.Goldenrod;
            this.bttn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Print.Location = new System.Drawing.Point(356, 342);
            this.bttn_Print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(93, 31);
            this.bttn_Print.TabIndex = 1;
            this.bttn_Print.Text = "Print";
            this.bttn_Print.UseVisualStyleBackColor = false;
            this.bttn_Print.Click += new System.EventHandler(this.bttn_Print_Click);
            // 
            // Cou_PrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(804, 384);
            this.Controls.Add(this.bttn_Print);
            this.Controls.Add(this.dGV_Print);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cou_PrintFrm";
            this.Text = "Print course";
            this.Load += new System.EventHandler(this.Cou_PrintFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Print)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Print;
        private System.Windows.Forms.Button bttn_Print;
    }
}