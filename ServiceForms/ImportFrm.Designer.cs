namespace WIPR170124.ServiceForms
{
    partial class ImportFrm
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
            this.txtB_FilePN = new System.Windows.Forms.TextBox();
            this.lbl_FilePN = new System.Windows.Forms.Label();
            this.bttn_Check = new System.Windows.Forms.Button();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.testLbl = new System.Windows.Forms.Label();
            this.pnl_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtB_FilePN
            // 
            this.txtB_FilePN.Location = new System.Drawing.Point(38, 60);
            this.txtB_FilePN.Name = "txtB_FilePN";
            this.txtB_FilePN.Size = new System.Drawing.Size(376, 26);
            this.txtB_FilePN.TabIndex = 10;
            // 
            // lbl_FilePN
            // 
            this.lbl_FilePN.AutoSize = true;
            this.lbl_FilePN.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FilePN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_FilePN.Location = new System.Drawing.Point(34, 35);
            this.lbl_FilePN.Name = "lbl_FilePN";
            this.lbl_FilePN.Size = new System.Drawing.Size(177, 22);
            this.lbl_FilePN.TabIndex = 9;
            this.lbl_FilePN.Text = "File path or file name";
            // 
            // bttn_Check
            // 
            this.bttn_Check.Location = new System.Drawing.Point(189, 107);
            this.bttn_Check.Name = "bttn_Check";
            this.bttn_Check.Size = new System.Drawing.Size(74, 31);
            this.bttn_Check.TabIndex = 11;
            this.bttn_Check.Text = "Check";
            this.bttn_Check.UseVisualStyleBackColor = true;
            this.bttn_Check.Click += new System.EventHandler(this.bttn_Check_Click);
            // 
            // pnl_1
            // 
            this.pnl_1.Controls.Add(this.testLbl);
            this.pnl_1.Location = new System.Drawing.Point(2, -1);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(311, 161);
            this.pnl_1.TabIndex = 12;
            // 
            // testLbl
            // 
            this.testLbl.AutoSize = true;
            this.testLbl.Location = new System.Drawing.Point(106, 67);
            this.testLbl.Name = "testLbl";
            this.testLbl.Size = new System.Drawing.Size(24, 20);
            this.testLbl.TabIndex = 13;
            this.testLbl.Text = "Hi";
            // 
            // ImportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 163);
            this.Controls.Add(this.pnl_1);
            this.Controls.Add(this.bttn_Check);
            this.Controls.Add(this.txtB_FilePN);
            this.Controls.Add(this.lbl_FilePN);
            this.Name = "ImportFrm";
            this.Text = "Import";
            this.Load += new System.EventHandler(this.ImportFrm_Load);
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_FilePN;
        private System.Windows.Forms.Label lbl_FilePN;
        private System.Windows.Forms.Button bttn_Check;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Label testLbl;
    }
}