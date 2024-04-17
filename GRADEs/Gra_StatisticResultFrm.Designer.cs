namespace WIPR170124.GRADEs
{
    partial class Gra_StatisticResultFrm
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
            this.rTB_1 = new System.Windows.Forms.RichTextBox();
            this.lbl_SbC = new System.Windows.Forms.Label();
            this.lbl_SbR = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_Fail = new System.Windows.Forms.Label();
            this.groB_1 = new System.Windows.Forms.GroupBox();
            this.groB_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTB_1
            // 
            this.rTB_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rTB_1.Location = new System.Drawing.Point(33, 49);
            this.rTB_1.Name = "rTB_1";
            this.rTB_1.Size = new System.Drawing.Size(368, 350);
            this.rTB_1.TabIndex = 0;
            this.rTB_1.Text = "";
            // 
            // lbl_SbC
            // 
            this.lbl_SbC.AutoSize = true;
            this.lbl_SbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SbC.Location = new System.Drawing.Point(29, 26);
            this.lbl_SbC.Name = "lbl_SbC";
            this.lbl_SbC.Size = new System.Drawing.Size(170, 20);
            this.lbl_SbC.TabIndex = 1;
            this.lbl_SbC.Text = "Statistic by Course";
            // 
            // lbl_SbR
            // 
            this.lbl_SbR.AutoSize = true;
            this.lbl_SbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SbR.Location = new System.Drawing.Point(469, 166);
            this.lbl_SbR.Name = "lbl_SbR";
            this.lbl_SbR.Size = new System.Drawing.Size(164, 20);
            this.lbl_SbR.TabIndex = 1;
            this.lbl_SbR.Text = "Statistic by Result";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Pass.Location = new System.Drawing.Point(15, 35);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(46, 18);
            this.lbl_Pass.TabIndex = 2;
            this.lbl_Pass.Text = "Pass:";
            // 
            // lbl_Fail
            // 
            this.lbl_Fail.AutoSize = true;
            this.lbl_Fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Fail.Location = new System.Drawing.Point(26, 73);
            this.lbl_Fail.Name = "lbl_Fail";
            this.lbl_Fail.Size = new System.Drawing.Size(35, 18);
            this.lbl_Fail.TabIndex = 2;
            this.lbl_Fail.Text = "Fail:";
            // 
            // groB_1
            // 
            this.groB_1.Controls.Add(this.lbl_Fail);
            this.groB_1.Controls.Add(this.lbl_Pass);
            this.groB_1.Location = new System.Drawing.Point(473, 189);
            this.groB_1.Name = "groB_1";
            this.groB_1.Size = new System.Drawing.Size(160, 120);
            this.groB_1.TabIndex = 3;
            this.groB_1.TabStop = false;
            // 
            // Gra_StatisticResultFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 428);
            this.Controls.Add(this.lbl_SbR);
            this.Controls.Add(this.lbl_SbC);
            this.Controls.Add(this.rTB_1);
            this.Controls.Add(this.groB_1);
            this.Name = "Gra_StatisticResultFrm";
            this.Text = "Statistic Result";
            this.Load += new System.EventHandler(this.Gra_StatisticResultFrm_Load);
            this.groB_1.ResumeLayout(false);
            this.groB_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTB_1;
        private System.Windows.Forms.Label lbl_SbC;
        private System.Windows.Forms.Label lbl_SbR;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_Fail;
        private System.Windows.Forms.GroupBox groB_1;
    }
}