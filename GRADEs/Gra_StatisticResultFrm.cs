using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WIPR170124.GRADEs
{
    public partial class Gra_StatisticResultFrm : Form
    {
        public Gra_StatisticResultFrm()
        {
            InitializeComponent();
        }

        private void load()
        {
            string getStr = "SELECT CName, AVG(AvgGr) AS AvgGra FROM AvgGraByCou GROUP BY CID, CName";
            SqlConnection conn = new MyDB().Connection;
            SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn);
            DataTable dT = new DataTable();

            adapter.Fill(dT);

            chrt_1.Titles.Add("Average Score By Course");

            Series series = new Series("Scores");
            chrt_1.Series.Clear();
            chrt_1.Series.Add(series);

            series.ChartType = SeriesChartType.Column;
            series.Palette = ChartColorPalette.BrightPastel;

            int passed = 0;
            int failed = 0;

            Dictionary<string, double> avgScores= new Dictionary<string, double>();
            foreach (DataRow row in dT.Rows)
            {
                double score = Math.Round(Convert.ToDouble(row["AvgGra"]), 2);

                avgScores.Add(row["CName"].ToString().Trim(), score);

                if (score >= 5) passed ++;
                else failed ++;
            }

            foreach(var s in avgScores)
            {
                series.Points.AddXY(s.Key, s.Value);
            }

            chrt_2.Titles.Add("Result");

            Series series2 = new Series("Results");
            chrt_2.Series.Clear();
            chrt_2.Series.Add(series2);

            series2.ChartType = SeriesChartType.Pie;
            series2.Palette = ChartColorPalette.BrightPastel;

            if (passed > 0) series2.Points.AddXY("Passed", passed);
            if (failed > 0) series2.Points.AddXY("Failed", failed);
        }

        private void Gra_StatisticResultFrm_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
