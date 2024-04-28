namespace WIPR170124.STUDENTs
{
    partial class PrinterFrm
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
            this.repV_1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // repV_1
            // 
            this.repV_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repV_1.LocalReport.ReportEmbeddedResource = "WIPR170124.STUDENTs.StuReport.rdlc";
            this.repV_1.Location = new System.Drawing.Point(0, 0);
            this.repV_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.repV_1.Name = "repV_1";
            this.repV_1.ServerReport.BearerToken = null;
            this.repV_1.Size = new System.Drawing.Size(1166, 694);
            this.repV_1.TabIndex = 0;
            // 
            // StuPrinterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 694);
            this.Controls.Add(this.repV_1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StuPrinterFrm";
            this.Text = "Printer";
            this.Load += new System.EventHandler(this.print_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repV_1;
    }
}