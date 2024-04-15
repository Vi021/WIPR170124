namespace WIPR170124.STUDENTs
{
    partial class StuStatisticFrm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chrt_1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_1)).BeginInit();
            this.SuspendLayout();
            // 
            // chrt_1
            // 
            this.chrt_1.BackColor = System.Drawing.Color.Transparent;
            this.chrt_1.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chrt_1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chrt_1.BorderSkin.BorderColor = System.Drawing.Color.DarkOliveGreen;
            chartArea1.Name = "ChartArea1";
            this.chrt_1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_1.Legends.Add(legend1);
            this.chrt_1.Location = new System.Drawing.Point(29, 22);
            this.chrt_1.Name = "chrt_1";
            this.chrt_1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chrt_1.Size = new System.Drawing.Size(747, 416);
            this.chrt_1.TabIndex = 0;
            this.chrt_1.Text = "Birth Month";
            // 
            // StuStatisticFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chrt_1);
            this.Name = "StuStatisticFrm";
            this.Text = "Student Statistics";
            this.Load += new System.EventHandler(this.StuStatisticFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataVisualization.Charting.Chart chrt_1;
    }
}