namespace WIPR170124.COURSEs
{
    partial class Cou_EditFrm
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
            this.bttn_Edit = new System.Windows.Forms.Button();
            this.lbl_Descr = new System.Windows.Forms.Label();
            this.lbl_Period = new System.Windows.Forms.Label();
            this.lbl_CName = new System.Windows.Forms.Label();
            this.lbl_CID = new System.Windows.Forms.Label();
            this.rTB_Descr = new System.Windows.Forms.RichTextBox();
            this.txtB_CName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comB_CID = new System.Windows.Forms.ComboBox();
            this.nUD_Period = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Period)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_Edit
            // 
            this.bttn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Edit.Location = new System.Drawing.Point(211, 394);
            this.bttn_Edit.Name = "bttn_Edit";
            this.bttn_Edit.Size = new System.Drawing.Size(100, 40);
            this.bttn_Edit.TabIndex = 14;
            this.bttn_Edit.Text = "Edit";
            this.bttn_Edit.UseVisualStyleBackColor = true;
            this.bttn_Edit.Click += new System.EventHandler(this.bttn_Edit_Click);
            // 
            // lbl_Descr
            // 
            this.lbl_Descr.AutoSize = true;
            this.lbl_Descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descr.Location = new System.Drawing.Point(67, 246);
            this.lbl_Descr.Name = "lbl_Descr";
            this.lbl_Descr.Size = new System.Drawing.Size(105, 22);
            this.lbl_Descr.TabIndex = 9;
            this.lbl_Descr.Text = "Description:";
            // 
            // lbl_Period
            // 
            this.lbl_Period.AutoSize = true;
            this.lbl_Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Period.Location = new System.Drawing.Point(105, 200);
            this.lbl_Period.Name = "lbl_Period";
            this.lbl_Period.Size = new System.Drawing.Size(67, 22);
            this.lbl_Period.TabIndex = 10;
            this.lbl_Period.Text = "Period:";
            // 
            // lbl_CName
            // 
            this.lbl_CName.AutoSize = true;
            this.lbl_CName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CName.Location = new System.Drawing.Point(47, 150);
            this.lbl_CName.Name = "lbl_CName";
            this.lbl_CName.Size = new System.Drawing.Size(125, 22);
            this.lbl_CName.TabIndex = 11;
            this.lbl_CName.Text = "Course Name:";
            // 
            // lbl_CID
            // 
            this.lbl_CID.AutoSize = true;
            this.lbl_CID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_CID.Location = new System.Drawing.Point(77, 100);
            this.lbl_CID.Name = "lbl_CID";
            this.lbl_CID.Size = new System.Drawing.Size(95, 22);
            this.lbl_CID.TabIndex = 12;
            this.lbl_CID.Text = "Course ID:";
            // 
            // rTB_Descr
            // 
            this.rTB_Descr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTB_Descr.Location = new System.Drawing.Point(178, 246);
            this.rTB_Descr.Name = "rTB_Descr";
            this.rTB_Descr.Size = new System.Drawing.Size(297, 116);
            this.rTB_Descr.TabIndex = 13;
            this.rTB_Descr.Text = "";
            // 
            // txtB_CName
            // 
            this.txtB_CName.Location = new System.Drawing.Point(178, 146);
            this.txtB_CName.Name = "txtB_CName";
            this.txtB_CName.Size = new System.Drawing.Size(297, 26);
            this.txtB_CName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "COURSE INFO";
            // 
            // comB_CID
            // 
            this.comB_CID.FormattingEnabled = true;
            this.comB_CID.Location = new System.Drawing.Point(178, 94);
            this.comB_CID.Name = "comB_CID";
            this.comB_CID.Size = new System.Drawing.Size(297, 28);
            this.comB_CID.TabIndex = 15;
            this.comB_CID.SelectedIndexChanged += new System.EventHandler(this.comB_CName_SelectedIndexChanged);
            // 
            // nUD_Period
            // 
            this.nUD_Period.Location = new System.Drawing.Point(178, 196);
            this.nUD_Period.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nUD_Period.Name = "nUD_Period";
            this.nUD_Period.Size = new System.Drawing.Size(96, 26);
            this.nUD_Period.TabIndex = 16;
            this.nUD_Period.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // Cou_EditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 464);
            this.Controls.Add(this.nUD_Period);
            this.Controls.Add(this.comB_CID);
            this.Controls.Add(this.bttn_Edit);
            this.Controls.Add(this.lbl_Descr);
            this.Controls.Add(this.lbl_Period);
            this.Controls.Add(this.lbl_CName);
            this.Controls.Add(this.lbl_CID);
            this.Controls.Add(this.rTB_Descr);
            this.Controls.Add(this.txtB_CName);
            this.Controls.Add(this.label1);
            this.Name = "Cou_EditFrm";
            this.Text = "Edit course";
            this.Load += new System.EventHandler(this.Cou_EditFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Period)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Edit;
        private System.Windows.Forms.Label lbl_Descr;
        private System.Windows.Forms.Label lbl_Period;
        private System.Windows.Forms.Label lbl_CName;
        private System.Windows.Forms.Label lbl_CID;
        private System.Windows.Forms.RichTextBox rTB_Descr;
        private System.Windows.Forms.TextBox txtB_CName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comB_CID;
        private System.Windows.Forms.NumericUpDown nUD_Period;
    }
}