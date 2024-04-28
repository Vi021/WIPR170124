using Microsoft.Reporting.WinForms;
using System;
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

        internal DataTable _SourceDT = null;
        internal string _getStr = "";   // if _SourceDT = null
        internal string _rdlc = "";     // .rdlc file path
        internal string _DSName = "";   //data set name
        internal string _DTName = "";   //table name
        private void print_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new MyDB().Connection)
            {
                if (_rdlc.Length > 0 && _DSName.Length > 0)
                {
                    if (_SourceDT != null)
                    {
                        DataSet dS = new DataSet();

                        dS.Tables.Add(_SourceDT);

                        repV_1.LocalReport.ReportEmbeddedResource = $"WIPR170124.{_rdlc}.rdlc";

                        ReportDataSource rds = new ReportDataSource();
                        rds.Name = _DSName;
                        rds.Value = dS.Tables[0];

                        this.repV_1.LocalReport.DataSources.Add(rds);
                        this.repV_1.RefreshReport();
                    }
                    else if (_getStr.Length > 0)
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(_getStr, conn);

                        DataSet dS = new DataSet();

                        adapter.Fill(dS, _DTName);

                        repV_1.LocalReport.ReportEmbeddedResource = $"WIPR170124.{_rdlc}.rdlc";

                        ReportDataSource rds = new ReportDataSource();
                        rds.Name = _DSName;
                        rds.Value = dS.Tables[_DTName];

                        this.repV_1.LocalReport.DataSources.Add(rds);
                        this.repV_1.RefreshReport();
                    }
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