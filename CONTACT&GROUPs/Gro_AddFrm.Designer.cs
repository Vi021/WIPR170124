namespace WIPR170124.CONTACT_GROUPs
{
    partial class Gro_AddFrm
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
            this.lbl_CInfo = new System.Windows.Forms.Label();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.txtB_Name = new System.Windows.Forms.TextBox();
            this.txtB_ID = new System.Windows.Forms.TextBox();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.pnl_Shadow = new System.Windows.Forms.Panel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.erPr_ID = new System.Windows.Forms.ErrorProvider(this.components);
            this.erPr_Name = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Name)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CInfo
            // 
            this.lbl_CInfo.AutoSize = true;
            this.lbl_CInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_CInfo.ForeColor = System.Drawing.Color.White;
            this.lbl_CInfo.Location = new System.Drawing.Point(115, 11);
            this.lbl_CInfo.Name = "lbl_CInfo";
            this.lbl_CInfo.Size = new System.Drawing.Size(137, 24);
            this.lbl_CInfo.TabIndex = 8;
            this.lbl_CInfo.Text = "GROUP INFO";
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.SlateBlue;
            this.pnl_1.Controls.Add(this.lbl_CInfo);
            this.pnl_1.Location = new System.Drawing.Point(-7, 0);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(363, 47);
            this.pnl_1.TabIndex = 17;
            // 
            // txtB_Name
            // 
            this.txtB_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtB_Name.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtB_Name.Location = new System.Drawing.Point(142, 137);
            this.txtB_Name.Name = "txtB_Name";
            this.txtB_Name.Size = new System.Drawing.Size(189, 24);
            this.txtB_Name.TabIndex = 14;
            // 
            // txtB_ID
            // 
            this.txtB_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtB_ID.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtB_ID.Location = new System.Drawing.Point(142, 86);
            this.txtB_ID.Name = "txtB_ID";
            this.txtB_ID.Size = new System.Drawing.Size(189, 24);
            this.txtB_ID.TabIndex = 15;
            // 
            // bttn_Add
            // 
            this.bttn_Add.BackColor = System.Drawing.Color.SlateBlue;
            this.bttn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Add.ForeColor = System.Drawing.SystemColors.Window;
            this.bttn_Add.Location = new System.Drawing.Point(227, 203);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(104, 38);
            this.bttn_Add.TabIndex = 13;
            this.bttn_Add.Text = "Add";
            this.bttn_Add.UseVisualStyleBackColor = false;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // pnl_Shadow
            // 
            this.pnl_Shadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(63)))), ((int)(((byte)(197)))));
            this.pnl_Shadow.Location = new System.Drawing.Point(239, 215);
            this.pnl_Shadow.Name = "pnl_Shadow";
            this.pnl_Shadow.Size = new System.Drawing.Size(100, 35);
            this.pnl_Shadow.TabIndex = 16;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Name.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbl_Name.Location = new System.Drawing.Point(14, 140);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(104, 18);
            this.lbl_Name.TabIndex = 18;
            this.lbl_Name.Text = "Group Name";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbl_ID.Location = new System.Drawing.Point(42, 89);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(76, 18);
            this.lbl_ID.TabIndex = 19;
            this.lbl_ID.Text = "Group ID";
            // 
            // erPr_ID
            // 
            this.erPr_ID.ContainerControl = this;
            // 
            // erPr_Name
            // 
            this.erPr_Name.ContainerControl = this;
            // 
            // Gro_AddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(353, 263);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.pnl_1);
            this.Controls.Add(this.txtB_Name);
            this.Controls.Add(this.txtB_ID);
            this.Controls.Add(this.bttn_Add);
            this.Controls.Add(this.pnl_Shadow);
            this.Name = "Gro_AddFrm";
            this.Text = "Add a Group";
            this.Load += new System.EventHandler(this.Gro_AddFrm_Load);
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPr_Name)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CInfo;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.TextBox txtB_Name;
        internal System.Windows.Forms.TextBox txtB_ID;
        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.Panel pnl_Shadow;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.ErrorProvider erPr_ID;
        private System.Windows.Forms.ErrorProvider erPr_Name;
    }
}