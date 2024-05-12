namespace WIPR170124.CONTACT_GROUPs
{
    partial class Con_CouGraListFrm
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
            this.dGV_List = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_List
            // 
            this.dGV_List.AllowUserToAddRows = false;
            this.dGV_List.AllowUserToDeleteRows = false;
            this.dGV_List.AllowUserToResizeColumns = false;
            this.dGV_List.AllowUserToResizeRows = false;
            this.dGV_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_List.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_List.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_List.Location = new System.Drawing.Point(0, 0);
            this.dGV_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGV_List.Name = "dGV_List";
            this.dGV_List.ReadOnly = true;
            this.dGV_List.RowHeadersVisible = false;
            this.dGV_List.RowHeadersWidth = 62;
            this.dGV_List.RowTemplate.Height = 28;
            this.dGV_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_List.Size = new System.Drawing.Size(765, 357);
            this.dGV_List.TabIndex = 1;
            // 
            // Con_CouGraListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 357);
            this.Controls.Add(this.dGV_List);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "Con_CouGraListFrm";
            this.Text = "Courses taught by";
            this.Load += new System.EventHandler(this.Con_CouGraListFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_List;
    }
}