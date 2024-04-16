using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WIPR170124.GRADEs
{
    public partial class Gra_AverageFrm : Form
    {
        public Gra_AverageFrm()
        {
            InitializeComponent();
            //lbl_Avg.Parent = pnl_Avg;
        }

        private bool loaded = false;

        private DataTable fillGrades(SqlCommand cmd)
        {
            cmd.Connection = new MyDB().Connection;

            DataTable dT = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dT);

            return dT;
        }

        private void Gra_AverageFrm_Load(object sender, EventArgs e)
        {
            comB_Filter.Text = "All";
            comB_Filter.SelectedIndex = 2;

            loaded = true;
        }

        private void comB_By_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                int selected = comB_By.SelectedIndex;
                if (selected == 0)
                {
                    string getStr = "SELECT CourseTable.CID, CName, Period, CourseTable.Sem, Grade FROM CoursTable JOIN EnrollTable";
                    //TODO: Create VIEW -> Find avg of each course, inlcudes course that dont have any enrolled student
                }
                else if (selected == 1)
                {
                    string getStr = "SELECT ";
                    //TODO: Similar but avg of student instead
                }
                else
                {
                    dGV_Avg.DataSource = null;
                }
            }
        }

        private void comB_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
