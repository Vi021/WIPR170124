namespace WIPR170124.STUDENTs
{
    partial class StuCouListFrm
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
            this.lbl_StuName = new System.Windows.Forms.Label();
            this.lbl_StuID = new System.Windows.Forms.Label();
            this.lbl_StuNameC = new System.Windows.Forms.Label();
            this.lbl_StuIDC = new System.Windows.Forms.Label();
            this.dGV_CouList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CouList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_StuName
            // 
            this.lbl_StuName.AutoSize = true;
            this.lbl_StuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_StuName.Location = new System.Drawing.Point(115, 48);
            this.lbl_StuName.Name = "lbl_StuName";
            this.lbl_StuName.Size = new System.Drawing.Size(62, 22);
            this.lbl_StuName.TabIndex = 0;
            this.lbl_StuName.Text = "Name:";
            // 
            // lbl_StuID
            // 
            this.lbl_StuID.AutoSize = true;
            this.lbl_StuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_StuID.Location = new System.Drawing.Point(499, 48);
            this.lbl_StuID.Name = "lbl_StuID";
            this.lbl_StuID.Size = new System.Drawing.Size(32, 22);
            this.lbl_StuID.TabIndex = 1;
            this.lbl_StuID.Text = "ID:";
            // 
            // lbl_StuNameC
            // 
            this.lbl_StuNameC.AutoSize = true;
            this.lbl_StuNameC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_StuNameC.Location = new System.Drawing.Point(183, 46);
            this.lbl_StuNameC.Name = "lbl_StuNameC";
            this.lbl_StuNameC.Size = new System.Drawing.Size(17, 25);
            this.lbl_StuNameC.TabIndex = 2;
            this.lbl_StuNameC.Text = ".";
            // 
            // lbl_StuIDC
            // 
            this.lbl_StuIDC.AutoSize = true;
            this.lbl_StuIDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_StuIDC.Location = new System.Drawing.Point(537, 45);
            this.lbl_StuIDC.Name = "lbl_StuIDC";
            this.lbl_StuIDC.Size = new System.Drawing.Size(17, 25);
            this.lbl_StuIDC.TabIndex = 2;
            this.lbl_StuIDC.Text = ".";
            // 
            // dGV_CouList
            // 
            this.dGV_CouList.AllowUserToAddRows = false;
            this.dGV_CouList.AllowUserToDeleteRows = false;
            this.dGV_CouList.AllowUserToResizeColumns = false;
            this.dGV_CouList.AllowUserToResizeRows = false;
            this.dGV_CouList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_CouList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_CouList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_CouList.Location = new System.Drawing.Point(12, 85);
            this.dGV_CouList.Name = "dGV_CouList";
            this.dGV_CouList.RowHeadersVisible = false;
            this.dGV_CouList.RowHeadersWidth = 62;
            this.dGV_CouList.RowTemplate.Height = 28;
            this.dGV_CouList.Size = new System.Drawing.Size(698, 277);
            this.dGV_CouList.TabIndex = 3;
            this.dGV_CouList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CouList_CellDoubleClick);
            // 
            // StuCouListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 374);
            this.Controls.Add(this.dGV_CouList);
            this.Controls.Add(this.lbl_StuIDC);
            this.Controls.Add(this.lbl_StuNameC);
            this.Controls.Add(this.lbl_StuID);
            this.Controls.Add(this.lbl_StuName);
            this.Name = "StuCouListFrm";
            this.Text = "StuCouListFrm";
            this.Load += new System.EventHandler(this.StuCouListFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CouList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StuName;
        private System.Windows.Forms.Label lbl_StuID;
        internal System.Windows.Forms.Label lbl_StuNameC;
        internal System.Windows.Forms.Label lbl_StuIDC;
        internal System.Windows.Forms.DataGridView dGV_CouList;
    }
}