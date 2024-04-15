namespace WIPR170124.COURSEs
{
    partial class Cou_AddFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtB_CID = new System.Windows.Forms.TextBox();
            this.lbl_CID = new System.Windows.Forms.Label();
            this.txtB_CName = new System.Windows.Forms.TextBox();
            this.lbl_CName = new System.Windows.Forms.Label();
            this.txtB_Period = new System.Windows.Forms.TextBox();
            this.lbl_Period = new System.Windows.Forms.Label();
            this.lbl_Descr = new System.Windows.Forms.Label();
            this.rTB_Descr = new System.Windows.Forms.RichTextBox();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.erPR_CID = new System.Windows.Forms.ErrorProvider(this.components);
            this.erPr_CName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erPr_Period = new System.Windows.Forms.ErrorProvider(this.components);
            this.erPr_Descr = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erPR_CID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_CName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Period)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Descr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "COURSE INFO";
            // 
            // txtB_CID
            // 
            this.txtB_CID.Location = new System.Drawing.Point(163, 98);
            this.txtB_CID.Name = "txtB_CID";
            this.txtB_CID.Size = new System.Drawing.Size(100, 26);
            this.txtB_CID.TabIndex = 1;
            // 
            // lbl_CID
            // 
            this.lbl_CID.AutoSize = true;
            this.lbl_CID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_CID.Location = new System.Drawing.Point(62, 102);
            this.lbl_CID.Name = "lbl_CID";
            this.lbl_CID.Size = new System.Drawing.Size(95, 22);
            this.lbl_CID.TabIndex = 2;
            this.lbl_CID.Text = "Course ID:";
            // 
            // txtB_CName
            // 
            this.txtB_CName.Location = new System.Drawing.Point(163, 148);
            this.txtB_CName.Name = "txtB_CName";
            this.txtB_CName.Size = new System.Drawing.Size(297, 26);
            this.txtB_CName.TabIndex = 1;
            // 
            // lbl_CName
            // 
            this.lbl_CName.AutoSize = true;
            this.lbl_CName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CName.Location = new System.Drawing.Point(35, 152);
            this.lbl_CName.Name = "lbl_CName";
            this.lbl_CName.Size = new System.Drawing.Size(122, 22);
            this.lbl_CName.TabIndex = 2;
            this.lbl_CName.Text = "Course name:";
            // 
            // txtB_Period
            // 
            this.txtB_Period.Location = new System.Drawing.Point(163, 198);
            this.txtB_Period.Name = "txtB_Period";
            this.txtB_Period.Size = new System.Drawing.Size(100, 26);
            this.txtB_Period.TabIndex = 1;
            // 
            // lbl_Period
            // 
            this.lbl_Period.AutoSize = true;
            this.lbl_Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Period.Location = new System.Drawing.Point(90, 202);
            this.lbl_Period.Name = "lbl_Period";
            this.lbl_Period.Size = new System.Drawing.Size(67, 22);
            this.lbl_Period.TabIndex = 2;
            this.lbl_Period.Text = "Period:";
            // 
            // lbl_Descr
            // 
            this.lbl_Descr.AutoSize = true;
            this.lbl_Descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descr.Location = new System.Drawing.Point(52, 248);
            this.lbl_Descr.Name = "lbl_Descr";
            this.lbl_Descr.Size = new System.Drawing.Size(105, 22);
            this.lbl_Descr.TabIndex = 2;
            this.lbl_Descr.Text = "Description:";
            // 
            // rTB_Descr
            // 
            this.rTB_Descr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTB_Descr.Location = new System.Drawing.Point(163, 248);
            this.rTB_Descr.Name = "rTB_Descr";
            this.rTB_Descr.Size = new System.Drawing.Size(297, 116);
            this.rTB_Descr.TabIndex = 3;
            this.rTB_Descr.Text = "";
            // 
            // bttn_Add
            // 
            this.bttn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Add.Location = new System.Drawing.Point(212, 389);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(100, 40);
            this.bttn_Add.TabIndex = 4;
            this.bttn_Add.Text = "Add";
            this.bttn_Add.UseVisualStyleBackColor = true;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // erPR_CID
            // 
            this.erPR_CID.ContainerControl = this;
            // 
            // erPr_CName
            // 
            this.erPr_CName.ContainerControl = this;
            // 
            // erPr_Period
            // 
            this.erPr_Period.ContainerControl = this;
            // 
            // erPr_Descr
            // 
            this.erPr_Descr.ContainerControl = this;
            // 
            // Cou_AddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 464);
            this.Controls.Add(this.bttn_Add);
            this.Controls.Add(this.lbl_Descr);
            this.Controls.Add(this.lbl_Period);
            this.Controls.Add(this.lbl_CName);
            this.Controls.Add(this.lbl_CID);
            this.Controls.Add(this.rTB_Descr);
            this.Controls.Add(this.txtB_Period);
            this.Controls.Add(this.txtB_CName);
            this.Controls.Add(this.txtB_CID);
            this.Controls.Add(this.label1);
            this.Name = "Cou_AddFrm";
            this.Text = "Add a course";
            this.Load += new System.EventHandler(this.Cou_AddFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erPR_CID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_CName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Period)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Descr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB_CID;
        private System.Windows.Forms.Label lbl_CID;
        private System.Windows.Forms.TextBox txtB_CName;
        private System.Windows.Forms.Label lbl_CName;
        private System.Windows.Forms.TextBox txtB_Period;
        private System.Windows.Forms.Label lbl_Period;
        private System.Windows.Forms.Label lbl_Descr;
        private System.Windows.Forms.RichTextBox rTB_Descr;
        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.ErrorProvider erPR_CID;
        private System.Windows.Forms.ErrorProvider erPr_CName;
        private System.Windows.Forms.ErrorProvider erPr_Period;
        private System.Windows.Forms.ErrorProvider erPr_Descr;
    }
}