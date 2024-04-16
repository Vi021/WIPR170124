using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WIPR170124.STUDENTs
{
    public partial class StuPrinterFrm : Form
    {
        public StuPrinterFrm()
        {
            InitializeComponent();
        }

        internal DataTable _SourceDT = null;
        private void print_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new MyDB().Connection)
            {
                if (_SourceDT != null)
                {
                    DataSet dS = new DataSet();

                    dS.Tables.Add(_SourceDT);

                    repV_1.LocalReport.ReportEmbeddedResource = "WIPR170124.STUDENTs.StuReport.rdlc";

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "dS_StudentList";
                    rds.Value = dS.Tables[0];

                    this.repV_1.LocalReport.DataSources.Add(rds);
                    this.repV_1.RefreshReport();
                }
                else
                {
                    string getStr = "SELECT * FROM QLSVDB";
                    SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn);

                    DataSet dS = new DataSet();

                    adapter.Fill(dS, "Student List");

                    repV_1.LocalReport.ReportEmbeddedResource = "WIPR170124.STUDENTs.StuReport.rdlc";

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "dS_StudentList";
                    rds.Value = dS.Tables["Student List"];

                    this.repV_1.LocalReport.DataSources.Add(rds);
                    this.repV_1.RefreshReport();
                }
            }
        }
    }
}



/* PROBLEMS
 * Picture handling?
 * date format to dd/MM/YYYY (reformat each date b4 printing) 
 * 
 */