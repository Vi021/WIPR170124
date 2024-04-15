namespace WIPR170124
{
    partial class ExportFrm
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
            this.comB_SaveAs = new System.Windows.Forms.ComboBox();
            this.lbl_SaveAs = new System.Windows.Forms.Label();
            this.lbl_Filename = new System.Windows.Forms.Label();
            this.txtB_Filename = new System.Windows.Forms.TextBox();
            this.bttn_Export = new System.Windows.Forms.Button();
            this.erPr_Filename = new System.Windows.Forms.ErrorProvider(this.components);
            this.erPr_SaveAs = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Filename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_SaveAs)).BeginInit();
            this.SuspendLayout();
            // 
            // comB_SaveAs
            // 
            this.comB_SaveAs.FormattingEnabled = true;
            this.comB_SaveAs.Items.AddRange(new object[] {
            ".docx",
            ".pdf",
            ".txt",
            ".xlsx"});
            this.comB_SaveAs.Location = new System.Drawing.Point(43, 152);
            this.comB_SaveAs.Name = "comB_SaveAs";
            this.comB_SaveAs.Size = new System.Drawing.Size(275, 28);
            this.comB_SaveAs.TabIndex = 6;
            // 
            // lbl_SaveAs
            // 
            this.lbl_SaveAs.AutoSize = true;
            this.lbl_SaveAs.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_SaveAs.Location = new System.Drawing.Point(39, 127);
            this.lbl_SaveAs.Name = "lbl_SaveAs";
            this.lbl_SaveAs.Size = new System.Drawing.Size(75, 22);
            this.lbl_SaveAs.TabIndex = 7;
            this.lbl_SaveAs.Text = "Save as";
            // 
            // lbl_Filename
            // 
            this.lbl_Filename.AutoSize = true;
            this.lbl_Filename.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Filename.Location = new System.Drawing.Point(39, 57);
            this.lbl_Filename.Name = "lbl_Filename";
            this.lbl_Filename.Size = new System.Drawing.Size(88, 22);
            this.lbl_Filename.TabIndex = 7;
            this.lbl_Filename.Text = "File name";
            // 
            // txtB_Filename
            // 
            this.txtB_Filename.Location = new System.Drawing.Point(43, 82);
            this.txtB_Filename.Name = "txtB_Filename";
            this.txtB_Filename.Size = new System.Drawing.Size(275, 26);
            this.txtB_Filename.TabIndex = 8;
            // 
            // bttn_Export
            // 
            this.bttn_Export.Location = new System.Drawing.Point(135, 208);
            this.bttn_Export.Name = "bttn_Export";
            this.bttn_Export.Size = new System.Drawing.Size(94, 38);
            this.bttn_Export.TabIndex = 9;
            this.bttn_Export.Text = "Export";
            this.bttn_Export.UseVisualStyleBackColor = true;
            this.bttn_Export.Click += new System.EventHandler(this.bttn_Export_Click);
            // 
            // erPr_Filename
            // 
            this.erPr_Filename.ContainerControl = this;
            // 
            // erPr_SaveAs
            // 
            this.erPr_SaveAs.ContainerControl = this;
            // 
            // ExportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 290);
            this.Controls.Add(this.bttn_Export);
            this.Controls.Add(this.txtB_Filename);
            this.Controls.Add(this.comB_SaveAs);
            this.Controls.Add(this.lbl_Filename);
            this.Controls.Add(this.lbl_SaveAs);
            this.Name = "ExportFrm";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.ExportFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Filename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_SaveAs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comB_SaveAs;
        private System.Windows.Forms.Label lbl_SaveAs;
        private System.Windows.Forms.Label lbl_Filename;
        private System.Windows.Forms.TextBox txtB_Filename;
        private System.Windows.Forms.Button bttn_Export;
        private System.Windows.Forms.ErrorProvider erPr_Filename;
        private System.Windows.Forms.ErrorProvider erPr_SaveAs;
    }
}