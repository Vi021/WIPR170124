namespace WIPR170124.GRADEs
{
    partial class Gra_StuSelectFrm
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
            this.comB_1 = new System.Windows.Forms.ComboBox();
            this.dGV_GraPrint = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_GraPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // comB_1
            // 
            this.comB_1.FormattingEnabled = true;
            this.comB_1.Location = new System.Drawing.Point(74, 66);
            this.comB_1.Name = "comB_1";
            this.comB_1.Size = new System.Drawing.Size(171, 24);
            this.comB_1.TabIndex = 0;
            this.comB_1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dGV_GraPrint
            // 
            this.dGV_GraPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_GraPrint.Location = new System.Drawing.Point(343, 45);
            this.dGV_GraPrint.Name = "dGV_GraPrint";
            this.dGV_GraPrint.RowHeadersWidth = 51;
            this.dGV_GraPrint.RowTemplate.Height = 24;
            this.dGV_GraPrint.Size = new System.Drawing.Size(447, 155);
            this.dGV_GraPrint.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a Student:";
            // 
            // Gra_StuSelectFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 136);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_GraPrint);
            this.Controls.Add(this.comB_1);
            this.Name = "Gra_StuSelectFrm";
            this.Text = "Print Score";
            this.Load += new System.EventHandler(this.Gra_StuSelectFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_GraPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comB_1;
        private System.Windows.Forms.DataGridView dGV_GraPrint;
        private System.Windows.Forms.Label label1;
    }
}