namespace WIPR170124.CONTACT_GROUPs
{
    partial class Con_ListFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV_Contacts = new System.Windows.Forms.DataGridView();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.lbl_Group = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.comB_Group = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Contacts)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_Contacts
            // 
            this.dGV_Contacts.AllowUserToAddRows = false;
            this.dGV_Contacts.AllowUserToDeleteRows = false;
            this.dGV_Contacts.AllowUserToResizeColumns = false;
            this.dGV_Contacts.AllowUserToResizeRows = false;
            this.dGV_Contacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Contacts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Contacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_Contacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Contacts.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_Contacts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGV_Contacts.Location = new System.Drawing.Point(0, 61);
            this.dGV_Contacts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGV_Contacts.Name = "dGV_Contacts";
            this.dGV_Contacts.ReadOnly = true;
            this.dGV_Contacts.RowHeadersVisible = false;
            this.dGV_Contacts.RowHeadersWidth = 62;
            this.dGV_Contacts.RowTemplate.Height = 28;
            this.dGV_Contacts.Size = new System.Drawing.Size(1237, 423);
            this.dGV_Contacts.TabIndex = 2;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.SlateBlue;
            this.pnl_Menu.Controls.Add(this.comB_Group);
            this.pnl_Menu.Controls.Add(this.lbl_Group);
            this.pnl_Menu.Controls.Add(this.lbl_Title);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(1237, 67);
            this.pnl_Menu.TabIndex = 3;
            // 
            // lbl_Group
            // 
            this.lbl_Group.AutoSize = true;
            this.lbl_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Group.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Group.Location = new System.Drawing.Point(1005, 27);
            this.lbl_Group.Name = "lbl_Group";
            this.lbl_Group.Size = new System.Drawing.Size(55, 18);
            this.lbl_Group.TabIndex = 13;
            this.lbl_Group.Text = "Group";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Title.Location = new System.Drawing.Point(26, 19);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(257, 25);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "List of Available Contacts";
            // 
            // comB_Group
            // 
            this.comB_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comB_Group.ForeColor = System.Drawing.Color.SlateBlue;
            this.comB_Group.FormattingEnabled = true;
            this.comB_Group.Location = new System.Drawing.Point(1074, 21);
            this.comB_Group.Name = "comB_Group";
            this.comB_Group.Size = new System.Drawing.Size(140, 26);
            this.comB_Group.TabIndex = 14;
            this.comB_Group.SelectedIndexChanged += new System.EventHandler(this.comB_Group_SelectedIndexChanged);
            // 
            // Con_ListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1237, 484);
            this.Controls.Add(this.dGV_Contacts);
            this.Controls.Add(this.pnl_Menu);
            this.Name = "Con_ListFrm";
            this.Text = "Your List of Contacts";
            this.Load += new System.EventHandler(this.Con_ListFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Contacts)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Contacts;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.ComboBox comB_Group;
        private System.Windows.Forms.Label lbl_Group;
        private System.Windows.Forms.Label lbl_Title;
    }
}