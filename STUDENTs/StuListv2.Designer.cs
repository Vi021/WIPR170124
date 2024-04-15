namespace WIPR170124
{
    partial class StudentListFrmV2
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
            this.dGV_StuInfo = new System.Windows.Forms.DataGridView();
            this.qLSVDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wIPR170124DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wIPR_170124DataSet = new WIPR170124.WIPR_170124DataSet();
            this.but_Refresh = new System.Windows.Forms.Button();
            this.qLSVDBTableAdapter = new WIPR170124.WIPR_170124DataSetTableAdapters.QLSVDBTableAdapter();
            this.bttn_Import = new System.Windows.Forms.Button();
            this.bttn_Export = new System.Windows.Forms.Button();
            this.oFD_1 = new System.Windows.Forms.OpenFileDialog();
            this.bttn_Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_StuInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIPR170124DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIPR_170124DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_StuInfo
            // 
            this.dGV_StuInfo.AllowUserToAddRows = false;
            this.dGV_StuInfo.AllowUserToDeleteRows = false;
            this.dGV_StuInfo.AllowUserToResizeColumns = false;
            this.dGV_StuInfo.AllowUserToResizeRows = false;
            this.dGV_StuInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_StuInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_StuInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_StuInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_StuInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_StuInfo.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dGV_StuInfo.Location = new System.Drawing.Point(14, 12);
            this.dGV_StuInfo.Name = "dGV_StuInfo";
            this.dGV_StuInfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_StuInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_StuInfo.RowHeadersVisible = false;
            this.dGV_StuInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dGV_StuInfo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_StuInfo.RowTemplate.Height = 28;
            this.dGV_StuInfo.Size = new System.Drawing.Size(1234, 469);
            this.dGV_StuInfo.TabIndex = 0;
            this.dGV_StuInfo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_StuInfo_CellContentDoubleClick);
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
            this.but_Refresh.Location = new System.Drawing.Point(805, 502);
            this.but_Refresh.Name = "but_Refresh";
            this.but_Refresh.Size = new System.Drawing.Size(123, 36);
            this.but_Refresh.TabIndex = 1;
            this.but_Refresh.Text = "Refresh";
            this.but_Refresh.UseVisualStyleBackColor = true;
            this.but_Refresh.Click += new System.EventHandler(this.but_Refresh_Click);
            // 
            // qLSVDBTableAdapter
            // 
            this.qLSVDBTableAdapter.ClearBeforeFill = true;
            // 
            // bttn_Import
            // 
            this.bttn_Import.Location = new System.Drawing.Point(485, 502);
            this.bttn_Import.Name = "bttn_Import";
            this.bttn_Import.Size = new System.Drawing.Size(123, 36);
            this.bttn_Import.TabIndex = 2;
            this.bttn_Import.Text = "Import";
            this.bttn_Import.UseVisualStyleBackColor = true;
            this.bttn_Import.Click += new System.EventHandler(this.bttn_Import_Click);
            // 
            // bttn_Export
            // 
            this.bttn_Export.Location = new System.Drawing.Point(325, 502);
            this.bttn_Export.Name = "bttn_Export";
            this.bttn_Export.Size = new System.Drawing.Size(123, 36);
            this.bttn_Export.TabIndex = 2;
            this.bttn_Export.Text = "Export";
            this.bttn_Export.UseVisualStyleBackColor = true;
            this.bttn_Export.Click += new System.EventHandler(this.bttn_Export_Click);
            // 
            // bttn_Submit
            // 
            this.bttn_Submit.Location = new System.Drawing.Point(645, 502);
            this.bttn_Submit.Name = "bttn_Submit";
            this.bttn_Submit.Size = new System.Drawing.Size(123, 36);
            this.bttn_Submit.TabIndex = 3;
            this.bttn_Submit.Text = "Submit";
            this.bttn_Submit.UseVisualStyleBackColor = true;
            this.bttn_Submit.Click += new System.EventHandler(this.bttn_Submit_Click);
            // 
            // StudentListFrmV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 550);
            this.Controls.Add(this.bttn_Submit);
            this.Controls.Add(this.bttn_Export);
            this.Controls.Add(this.bttn_Import);
            this.Controls.Add(this.but_Refresh);
            this.Controls.Add(this.dGV_StuInfo);
            this.Name = "StudentListFrmV2";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_StuInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIPR170124DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIPR_170124DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_StuInfo;
        private System.Windows.Forms.Button but_Refresh;
        private System.Windows.Forms.BindingSource wIPR170124DataSetBindingSource;
        private WIPR_170124DataSet wIPR_170124DataSet;
        private System.Windows.Forms.BindingSource qLSVDBBindingSource;
        private WIPR_170124DataSetTableAdapters.QLSVDBTableAdapter qLSVDBTableAdapter;
        private System.Windows.Forms.Button bttn_Import;
        private System.Windows.Forms.Button bttn_Export;
        private System.Windows.Forms.OpenFileDialog oFD_1;
        private System.Windows.Forms.Button bttn_Submit;
    }
}