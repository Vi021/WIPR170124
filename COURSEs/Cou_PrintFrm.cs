using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WIPR170124.STUDENTs;

namespace WIPR170124.COURSEs
{
    public partial class Cou_PrintFrm : Form
    {
        public Cou_PrintFrm()
        {
            InitializeComponent();
        }

        private void Cou_PrintFrm_Load(object sender, EventArgs e)
        {
            ServiceClasses.COURSE course = new ServiceClasses.COURSE();
            using (SqlConnection conn = new MyDB().Connection)
            {
                conn.Open();
                string getStr = "SELECT * FROM CourseTable";
                using (SqlCommand cmd = new SqlCommand(getStr, conn))
                {
                    dGV_Print.DataSource = course.GetAllCourses(cmd);
                    dGV_Print.Columns["CID"].HeaderText = "Course ID";
                    dGV_Print.Columns["CName"].HeaderText = "Course name";
                }
            }
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {
            PrinterFrm printer = new PrinterFrm();
            printer._SourceDT = dGV_Print.DataSource as DataTable;
            printer._DSName = "DS_Courses";
            printer._DTName = (dGV_Print.DataSource as DataTable).TableName;
            printer._rdlc = "COURSEs.CourseReport";
            printer.ShowDialog();
        }
    }
}
