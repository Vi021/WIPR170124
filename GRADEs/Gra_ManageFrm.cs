using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WIPR170124.ServiceClasses;

namespace WIPR170124.GRADEs
{
    public partial class Gra_ManageFrm : Form
    {
        public Gra_ManageFrm()
        {
            InitializeComponent();
        }


        internal int mode = -1;
        bool loaded = false;

        COURSE course = new COURSE();
        Dictionary<string, string> couList = new Dictionary<string, string>();

        STUDENT student = new STUDENT();
        Dictionary<string, string> stuList = new Dictionary<string, string>();

        private void fillBaseInfo(int mode = -1)
        {
            if (mode == -1) return;

            try
            {
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();

                    // fill ID with CID
                    if (mode == 0)
                    {
                        string getStr = "SELECT CID, CName FROM CourseTable";
                        using (SqlCommand cmd = new SqlCommand(getStr, conn))
                        {
                            DataTable dT = new DataTable();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                            adapter.Fill(dT);

                            foreach (DataRow dR in dT.Rows)
                            {
                                string cid = dR["CID"].ToString().Trim();
                                string name = dR["CName"].ToString();

                                couList.Add(cid, name);

                                comB_ID.Items.Add(cid);
                            }
                        }
                    }
                    // fill ID with StuID
                    else if (mode == 1)
                    {
                        string getStr = "SELECT StuID, FName, LName FROM QLSVDB";
                        using (SqlCommand cmd = new SqlCommand(getStr, conn))
                        {
                            DataTable dT = new DataTable();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                            adapter.Fill(dT);

                            foreach (DataRow dR in dT.Rows)
                            {
                                string sid = dR["StuID"].ToString().Trim();
                                string name = dR["LName"].ToString().Trim() + " " + dR["FName"].ToString().Trim();

                                stuList.Add(sid, name);

                                comB_ID.Items.Add(sid);
                            }
                        }
                    }
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, "Manage score", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void fillList(int mode = -1, string ID = "")
        {
            if (mode == -1) return;

            try
            {
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();

                    // fill dGV with students
                    if (mode == 0)
                    {
                        string getStr = "SELECT QLSVDB.StuID, FName, LName, Gender, Sem, Grade FROM QLSVDB, Grade WHERE QLSVDB.StuID = Grade.StuID and CID = @id";
                        using (SqlCommand cmd = new SqlCommand(getStr, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", ID);

                            DataTable dT = new DataTable();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                            adapter.Fill(dT);

                            dGV_List.DataSource = dT;
                            if (dGV_List.Columns.Count > 0)
                            {
                                dGV_List.Columns["StuID"].HeaderText = "Student ID";
                                dGV_List.Columns["FName"].HeaderText = "Firstname";
                                dGV_List.Columns["LName"].HeaderText = "Lastname";
                                dGV_List.Columns["Sem"].HeaderText = "Semester";
                            }
                        }
                    }
                    // fill dGV with courses
                    else if (mode == 1)
                    {
                        string getStr = "SELECT CourseTable.CID, CName, Period, Sem, Grade FROM CourseTable, Grade WHERE CourseTable.CID = Grade.CID and StuID = @id";
                        using (SqlCommand cmd = new SqlCommand(getStr, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", ID);

                            DataTable dT = new DataTable();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                            adapter.Fill(dT);

                            dGV_List.DataSource = dT;
                            if (dGV_List.Columns.Count > 0)
                            {
                                dGV_List.Columns["CID"].HeaderText = "Course ID";
                                dGV_List.Columns["CName"].HeaderText = "Name";
                                dGV_List.Columns["Sem"].HeaderText = "Semester";
                            }
                        }
                    }
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, "Manage score", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        internal void load(int mode = -1, string ID = "")
        {
            if (mode == -1)
            {
                return;
            }
            else
            {
                if (ID.Length <= 0)
                {
                    // for id course ids
                    if (mode == 0)
                    {
                        fillBaseInfo(mode);
                    }
                    // for id student ids
                    else if (mode == 1)
                    {
                        fillBaseInfo(mode);
                    }
                }
                else
                {
                    // fill id course ids and list students
                    if (mode == 0)
                    {
                        fillBaseInfo(mode);
                        fillList(mode, ID);
                    }
                    // fill id student ids and list courses
                    else if (mode == 1)
                    {
                        fillBaseInfo(mode);
                        fillList(mode, ID);
                    }
                }
            }
        }

        private void Gra_ManageFrm_Load(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                this.Text = "Manage score by Courses";
            }
            else if (mode == 1)
            {
                this.Text = "Manage score by Students";
            }
            else
            {
                this.Text = "Manage score";
            }

            load(mode);

            loaded = true;
        }

        private void comB_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                string id = comB_ID.SelectedItem.ToString();
                if (id != null)
                {
                    if (mode == 0)
                    {
                        txtB_Name.Text = couList[id];
                        fillList(mode, id);
                    }
                    if (mode == 1)
                    {
                        txtB_Name.Text = stuList[id];
                        fillList(mode, id);
                    }

                    dGV_List.Columns["Grade"].DefaultCellStyle.Format = "N2";
                }
            }
        }

        private void comB_Sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                if (comB_Sem.SelectedIndex != -1)
                {
                    string id = comB_ID.SelectedItem.ToString();
                    fillList(mode, id);

                    if (comB_Sem.SelectedIndex == 3)
                    {
                        return;
                    }

                    string sem1 = comB_Sem.SelectedItem.ToString();
                    DataTable dt = dGV_List.DataSource as DataTable;
                    COURSE course = new COURSE();

                    /*string sem = comB_Sem.SelectedItem.ToString();
                    if (sem != null)
                    {
                        if (mode == 0)
                        {

                        }
                        if (mode == 1)
                        {

                        }
                    }*/

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

                    dGV_List.DataSource = dt;
                }
            }
            else
            {
                string id = comB_ID.SelectedItem.ToString();
                fillList(mode, id);
            }
        }

        private void dGV_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGV_List.CurrentCell == dGV_List.CurrentRow.Cells["Grade"])
            {
                if (mode == 0)
                {
                    Gra_GradeCellFrm gGCFrm = new Gra_GradeCellFrm();

                    gGCFrm.CID = comB_ID.SelectedItem.ToString().Trim();
                    gGCFrm.CName = txtB_Name.Text;
                    gGCFrm.StuID = dGV_List.CurrentRow.Cells["StuID"].Value.ToString().Trim();
                    gGCFrm.SName = dGV_List.CurrentRow.Cells["LName"].Value.ToString().Trim() + " " + dGV_List.CurrentRow.Cells["FName"].Value.ToString().Trim();
                    gGCFrm.Sem = Convert.ToInt32(dGV_List.CurrentRow.Cells["Sem"].Value.ToString());
                    gGCFrm.Grade = (float)Convert.ToDouble(dGV_List.CurrentRow.Cells["Grade"].Value.ToString());
                    gGCFrm.ShowDialog();
                    gGCFrm.Dispose();

                    this.comB_ID_SelectedIndexChanged(sender, e);
                    return;
                }
                else if (mode == 1)
                {
                    Gra_GradeCellFrm gGCFrm = new Gra_GradeCellFrm();

                    gGCFrm.StuID = comB_ID.SelectedItem.ToString().Trim();
                    gGCFrm.SName = txtB_Name.Text;
                    gGCFrm.CID = dGV_List.CurrentRow.Cells["CID"].Value.ToString().Trim();
                    gGCFrm.CName = dGV_List.CurrentRow.Cells["CName"].Value.ToString().Trim();
                    gGCFrm.Sem = Convert.ToInt32(dGV_List.CurrentRow.Cells["Sem"].Value.ToString());
                    gGCFrm.Grade = (float)Convert.ToDouble(dGV_List.CurrentRow.Cells["Grade"].Value.ToString());
                    gGCFrm.ShowDialog();
                    gGCFrm.Dispose();

                    this.comB_ID_SelectedIndexChanged(sender, e);
                    return;
                }
            }
        }
    }
}
