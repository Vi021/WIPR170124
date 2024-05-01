namespace WIPR170124.GRADEs
{
    partial class Gra_StatisticResultFrm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrt_1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrt_2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_2)).BeginInit();
            this.SuspendLayout();
            // 
            // chrt_1
            // 
            chartArea1.Name = "ChartArea1";
            this.chrt_1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_1.Legends.Add(legend1);
            this.chrt_1.Location = new System.Drawing.Point(12, 12);
            this.chrt_1.Name = "chrt_1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrt_1.Series.Add(series1);
            this.chrt_1.Size = new System.Drawing.Size(617, 467);
            this.chrt_1.TabIndex = 0;
            // 
            // chrt_2
            // 
            chartArea2.Name = "ChartArea1";
            this.chrt_2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrt_2.Legends.Add(legend2);
            this.chrt_2.Location = new System.Drawing.Point(648, 12);
            this.chrt_2.Name = "chrt_2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrt_2.Series.Add(series2);
            this.chrt_2.Size = new System.Drawing.Size(520, 467);
            this.chrt_2.TabIndex = 0;
            // 
            // Gra_StatisticResultFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 491);
            this.Controls.Add(this.chrt_2);
            this.Controls.Add(this.chrt_1);
            this.Name = "Gra_StatisticResultFrm";
            this.Text = "Statistic Result";
            this.Load += new System.EventHandler(this.Gra_StatisticResultFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_2;
    }
}