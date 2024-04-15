namespace WIPR170124
{
    partial class StuList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_StuInfo = new System.Windows.Forms.DataGridView();
            this.stuIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mugshot = new System.Windows.Forms.DataGridViewImageColumn();
            this.qLSVDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wIPR170124DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wIPR_170124DataSet = new WIPR170124.WIPR_170124DataSet();
            this.but_Refresh = new System.Windows.Forms.Button();
            this.qLSVDBTableAdapter = new WIPR170124.WIPR_170124DataSetTableAdapters.QLSVDBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_StuInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIPR170124DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIPR_170124DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_StuInfo
            // 
            this.DGV_StuInfo.AllowUserToAddRows = false;
            this.DGV_StuInfo.AllowUserToDeleteRows = false;
            this.DGV_StuInfo.AllowUserToResizeColumns = false;
            this.DGV_StuInfo.AllowUserToResizeRows = false;
            this.DGV_StuInfo.AutoGenerateColumns = false;
            this.DGV_StuInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_StuInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_StuInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_StuInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_StuInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuIdDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.bDateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.Mugshot});
            this.DGV_StuInfo.DataSource = this.qLSVDBBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_StuInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_StuInfo.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGV_StuInfo.Location = new System.Drawing.Point(14, 12);
            this.DGV_StuInfo.Name = "DGV_StuInfo";
            this.DGV_StuInfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_StuInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_StuInfo.RowHeadersVisible = false;
            this.DGV_StuInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_StuInfo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_StuInfo.RowTemplate.Height = 28;
            this.DGV_StuInfo.Size = new System.Drawing.Size(1180, 469);
            this.DGV_StuInfo.TabIndex = 0;
            this.DGV_StuInfo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_StuInfo_CellContentDoubleClick);
            // 
            // stuIdDataGridViewTextBoxColumn
            // 
            this.stuIdDataGridViewTextBoxColumn.DataPropertyName = "StuId";
            this.stuIdDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.stuIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stuIdDataGridViewTextBoxColumn.Name = "stuIdDataGridViewTextBoxColumn";
            this.stuIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.fNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDateDataGridViewTextBoxColumn
            // 
            this.bDateDataGridViewTextBoxColumn.DataPropertyName = "BDate";
            this.bDateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.bDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bDateDataGridViewTextBoxColumn.Name = "bDateDataGridViewTextBoxColumn";
            this.bDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Mugshot
            // 
            this.Mugshot.DataPropertyName = "Mugshot";
            this.Mugshot.HeaderText = "Profile Image";
            this.Mugshot.MinimumWidth = 8;
            this.Mugshot.Name = "Mugshot";
            this.Mugshot.ReadOnly = true;
            // 
            // qLSVDBBindingSource
            // 
            this.qLSVDBBindingSource.DataMember = "QLSVDB";
            this.qLSVDBBindingSource.DataSource = this.wIPR170124DataSetBindingSource;
            // 
            // wIPR170124DataSetBindingSource
            // 
            this.wIPR170124DataSetBindingSource.DataSource = this.wIPR_170124DataSet;
            this.wIPR170124DataSetBindingSource.Position = 0;
            // 
            // wIPR_170124DataSet
            // 
            this.wIPR_170124DataSet.DataSetName = "WIPR_170124DataSet";
            this.wIPR_170124DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // but_Refresh
            // 
            this.but_Refresh.Location = new System.Drawing.Point(561, 501);
            this.but_Refresh.Name = "but_Refresh";
            this.but_Refresh.Size = new System.Drawing.Size(92, 36);
            this.but_Refresh.TabIndex = 1;
            this.but_Refresh.Text = "Refresh";
            this.but_Refresh.UseVisualStyleBackColor = true;
            this.but_Refresh.Click += new System.EventHandler(this.but_Refresh_Click);
            // 
            // qLSVDBTableAdapter
            // 
            this.qLSVDBTableAdapter.ClearBeforeFill = true;
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 549);
            this.Controls.Add(this.but_Refresh);
            this.Controls.Add(this.DGV_StuInfo);
            this.Name = "StudentList";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_StuInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIPR170124DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIPR_170124DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_StuInfo;
        private System.Windows.Forms.Button but_Refresh;
        private System.Windows.Forms.BindingSource wIPR170124DataSetBindingSource;
        private WIPR_170124DataSet wIPR_170124DataSet;
        private System.Windows.Forms.BindingSource qLSVDBBindingSource;
        private WIPR_170124DataSetTableAdapters.QLSVDBTableAdapter qLSVDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Mugshot;
    }
}