using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

        private DataTable baseDT;
        private void comB_By_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                int selected = comB_By.SelectedIndex;
                if (selected == 0)
                {
                    string getStr = "SELECT * FROM AvgGraByCou";
                    SqlConnection conn = new MyDB().Connection;
                    SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn);
                    DataTable dT = new DataTable();

                    adapter.Fill(dT);

                    dGV_Avg.DataSource = dT;
                    dGV_Avg.Columns["CID"].HeaderText = "Course ID";
                    dGV_Avg.Columns["CName"].HeaderText = "Course Name";
                    dGV_Avg.Columns["Sem"].HeaderText = "Semester";
                    dGV_Avg.Columns["AvgGr"].HeaderText = "Average";
                    dGV_Avg.Columns["AvgGr"].DefaultCellStyle.Format = "N2";
                    //TODO: Create VIEW -> Find avg of each course, inlcudes course that dont have any enrolled student
                }
                else if (selected == 1)
                {
                    string getStr = "SELECT * FROM AvgGraByStu";
                    SqlConnection conn = new MyDB().Connection;
                    SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn);
                    DataTable dT = new DataTable();

                    adapter.Fill(dT);

                    dGV_Avg.DataSource = dT;
                    dGV_Avg.Columns["StuID"].HeaderText = "Student ID";
                    dGV_Avg.Columns["LName"].HeaderText = "Lastname";
                    dGV_Avg.Columns["Fname"].HeaderText = "Firstname";
                    dGV_Avg.Columns["AvgGr"].HeaderText = "Average";
                    dGV_Avg.Columns["AvgGr"].DefaultCellStyle.Format = "N2";
                    //TODO: Similar but avg of student instead
                }
                else
                {
                    dGV_Avg.DataSource = null;
                }

                baseDT = (dGV_Avg.DataSource as DataTable).Copy();
            }
        }

        private void comB_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comB_By.SelectedIndex != -1)
            {
                int selected = comB_Filter.SelectedIndex;
                if (selected == 0)
                {
                    if (baseDT.AsEnumerable().Any(row => Convert.ToDouble(row["AvgGr"].ToString()) < 5))
                    {
                        DataTable filteredTable = baseDT.AsEnumerable().Where(row => Convert.ToDouble(row["AvgGr"].ToString()) < 5).CopyToDataTable();
                        dGV_Avg.DataSource = filteredTable;
                    }
                    else
                    {
                        dGV_Avg.DataSource = baseDT.Clone();
                    }
                }
                else if (selected == 1)
                {
                    if (baseDT.AsEnumerable().Any(row => Convert.ToDouble(row["AvgGr"].ToString()) >= 5))
                    {
                        DataTable filteredTable = baseDT.AsEnumerable().Where(row => Convert.ToDouble(row["AvgGr"].ToString()) >= 5).CopyToDataTable();
                        dGV_Avg.DataSource = filteredTable;
                    }
                    else
                    {
                        dGV_Avg.DataSource = baseDT.Clone();
                    }
                }
                else
                {
                    dGV_Avg.DataSource = baseDT;
                }
            }
        }
    }
}
