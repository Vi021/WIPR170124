using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WIPR170124.ServiceClasses;

namespace WIPR170124.COURSEs
{
    public partial class Cou_StuListFrm : Form
    {
        public Cou_StuListFrm()
        {
            InitializeComponent();
        }

        bool loaded = false;
        private DataTable DT = new DataTable();
        internal string CID;

        private DataTable fillStudents(string CID)
        {
            try
            {
                if (CID == null || CID.Length <= 0) return null;

                string getStr = "SELECT QLSVDB.StuID, FName, LName, BDate, Sem FROM QLSVDB, EnrollTable WHERE QLSVDB.StuID = EnrollTable.StuID AND CID = @cid";
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(getStr, conn))
                    {
                        cmd.Parameters.AddWithValue("@cid", CID);

                        DataTable dT = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        adapter.Fill(dT);

                        return dT;
                    }
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, "Course Manage", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
        }

        private void Cou_StuListFrm_Load(object sender, EventArgs e)
        {
            if (dGV_StuList.DataSource != null)
            {
                loaded = true;
                //DT = (dGV_StuList.DataSource as DataTable).Clone();
            }
        }

        private void comB_Sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                if (comB_Sem.SelectedIndex != -1)
                {
                    dGV_StuList.DataSource = fillStudents(CID);

                    if (comB_Sem.SelectedIndex == 3)
                    {
                        return;
                    }

                    string sem1 = comB_Sem.SelectedItem.ToString();
                    DataTable dt = dGV_StuList.DataSource as DataTable;
                    COURSE course = new COURSE();

                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            string sem2 = dr["Sem"].ToString().Trim();
                            if (!sem1.Contains(sem2))
                            {
                                dr.Delete();
                            }
                        }
                    }

                    dGV_StuList.DataSource = dt;
                }
            }
            else
            {
                dGV_StuList.DataSource = fillStudents(CID);
            }
        }
    }
}
