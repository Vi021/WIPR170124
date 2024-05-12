using Microsoft.Reporting.WinForms;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WIPR170124.STUDENTs
{
    public partial class PrinterFrm : Form
    {
        public PrinterFrm()
        {
            InitializeComponent();
        }

        internal DataSet _SourceDS = null;
        internal DataTable _SourceDT = null;
        internal string _getStr = "";   // if _SourceDT = null
        internal string _rdlc = "";     // .rdlc file path
        internal string _DSName = "";   //data set name
        internal string _DTName = "";   //table name

        private void useDT()
        {
            using (SqlConnection conn = new MyDB().Connection)
            {
                if (_rdlc.Length > 0 && _DSName.Length > 0)
                {
                    if (_SourceDT != null)
                    {
                        DataSet dS = new DataSet(_DSName);

                        dS.Tables.Add(_SourceDT);

                        repV_1.LocalReport.ReportEmbeddedResource = $"WIPR170124.{_rdlc}.rdlc";

                        ReportDataSource rds = new ReportDataSource();
                        rds.Name = _DSName;
                        rds.Value = dS.Tables[0];

                        repV_1.LocalReport.DataSources.Clear();
                        this.repV_1.LocalReport.DataSources.Add(rds);
                        this.repV_1.RefreshReport();
                    }
                    else if (_getStr.Length > 0)
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(_getStr, conn);

                        DataSet dS = new DataSet(_DSName);

                        adapter.Fill(dS, _DTName);

                        repV_1.LocalReport.ReportEmbeddedResource = $"WIPR170124.{_rdlc}.rdlc";

                        ReportDataSource rds = new ReportDataSource();
                        rds.Name = _DSName;
                        rds.Value = dS.Tables[_DTName];

                        repV_1.LocalReport.DataSources.Clear();
                        this.repV_1.LocalReport.DataSources.Add(rds);
                        this.repV_1.RefreshReport();
                    }
                }
            }
        }

        private void useDS()
        {
            /*dS_AvgScoreResult dS_ASR = new dS_AvgScoreResult(_SourceDS.DataSetName);
            dS_ASR._addTable(_SourceDS.Tables[_DTName]);*/

            ReportDataSource rds = new ReportDataSource(_DSName);
            rds.Value = _SourceDS.Tables[_DTName];

            repV_1.LocalReport.DataSources.Clear();
            repV_1.LocalReport.DataSources.Add(rds);
            repV_1.RefreshReport();
        }

        internal bool spsr = false;
        public void SPSR(string stuid, string name)
        {
            if (_SourceDT != null)
            {
                DataSet dS = new DataSet(_DSName);

                dS.Tables.Add(_SourceDT);

                repV_1.LocalReport.ReportEmbeddedResource = $"WIPR170124.{_rdlc}.rdlc";

                ReportDataSource rds = new ReportDataSource();
                rds.Name = _DSName;
                rds.Value = dS.Tables[0];

                /*Microsoft.Reporting.WinForms.ReportParameter _sid = new Microsoft.Reporting.WinForms.ReportParameter("stuid", stuid);
                repV_1.LocalReport.SetParameters(_sid);
                ReportParameter _name = new ReportParameter("name", name);
                repV_1.LocalReport.SetParameters(_name);*/

                repV_1.LocalReport.DataSources.Clear();
                this.repV_1.LocalReport.DataSources.Add(rds);
                this.repV_1.RefreshReport();
            }
        }

        private void print_Load(object sender, EventArgs e)
        {
            repV_1.LocalReport.DataSources.Clear();

            if (spsr) return;
            
            if (_SourceDS != null)
            {
                useDS();
            }
            else
            {
                useDT();
            }
        }
    }
}



/* PROBLEMS
 * Picture handling?
 * date format to dd/MM/YYYY (reformat each date b4 printing) 
 * 
 */