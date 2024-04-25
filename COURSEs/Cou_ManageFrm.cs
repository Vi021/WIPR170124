using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WIPR170124.ServiceClasses;

namespace WIPR170124.COURSEs
{
    public partial class Cou_ManageFrm : Form
    {
        public Cou_ManageFrm()
        {
            InitializeComponent();
        }

        ServiceClasses.COURSE course = new ServiceClasses.COURSE();
        private void load()
        {
            using (SqlConnection conn = new MyDB().Connection)
            {
                conn.Open();
                string getStr = "SELECT * FROM CourseTable";
                using (SqlCommand cmd = new SqlCommand(getStr, conn))
                {
                    dGV_Courses.DataSource = course.GetAllCourses(cmd);
                    dGV_Courses.Columns["CID"].HeaderText = "Course ID";
                    dGV_Courses.Columns["CName"].HeaderText = "Course name";
                    lbl_TotalC.Text = "Total: " + dGV_Courses.RowCount; 
                }
            }
        }


        private void Cou_ManageFrm_Load(object sender, EventArgs e)
        {
            bttn_Edit.Enabled = false;
            bttn_Remove.Enabled = false;

            load();
        }

        //private string currentCID = "";
        private void dGV_Courses_Click(object sender, EventArgs e)
        {
            txtB_CName.Text = dGV_Courses.CurrentRow.Cells["CName"].Value.ToString();
            txtB_CID.Text = dGV_Courses.CurrentRow.Cells["CID"].Value.ToString().Trim();
            nUD_Period.Value = Convert.ToInt32(dGV_Courses.CurrentRow.Cells["Period"].Value);
            rTB_Descr.Text = dGV_Courses.CurrentRow.Cells["Description"].Value.ToString();

            txtB_CName.Enabled = true;
            txtB_CID.Enabled = true;
            nUD_Period.Enabled = true;
            rTB_Descr.Enabled = true;
            bttn_Add.Enabled = true;
            bttn_Edit.Enabled = true;
            bttn_Remove.Enabled = true;
        }

        private void txtB_CID_TextChanged(object sender, EventArgs e)
        {
            if (course.IsLetsAndDigs(txtB_CID.Text))
            {
                bttn_Add.Enabled = true;
                bttn_Edit.Enabled = true;
                bttn_Remove.Enabled = true;
            }
            else
            {
                bttn_Add.Enabled = false;
                bttn_Edit.Enabled = false;
                bttn_Remove.Enabled = false;
            }
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            if (txtB_CName.Text.Length > 0)
            {
                erPr_CName.Clear();
            }
            else
            {
                erPr_CName.SetError(txtB_CName, "Course name can't be empty");
                return;
            }
            if (txtB_CID.Text.Length > 0)
            {
                erPr_CID.Clear();
            }
            else
            {
                erPr_CID.SetError(txtB_CID, "Course ID can't be empty");
                return;
            }

            if (!course.CheckCID(txtB_CID.Text))
            {
                if (course.AddCourse(txtB_CID.Text, txtB_CName.Text, Convert.ToInt16(nUD_Period.Value), rTB_Descr.Text))
                {
                    MessageBox.Show("Course added!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                else
                {
                    MessageBox.Show("Add failed..", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("CID already exists", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttn_Edit_Click(object sender, EventArgs e)
        {
            if (txtB_CName.TextLength > 0)
            {
                erPr_CName.Clear();
            }
            else
            {
                erPr_CName.SetError(txtB_CName, "Course name can't be empty");
                return;
            }
            if (txtB_CID.TextLength > 0)
            {
                erPr_CID.Clear();
            }
            else
            {
                erPr_CID.SetError(txtB_CID, "Course ID can't be empty");
                return;
            }

            if (course.UpdateCourse(txtB_CID.Text, txtB_CName.Text, Convert.ToInt16(nUD_Period.Value), rTB_Descr.Text))
            {
                MessageBox.Show("Edited!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            else
            {
                MessageBox.Show("Edit failed!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttn_Remove_Click(object sender, EventArgs e)
        {
            if (txtB_CID.Text.Length > 0)
            {
                erPr_CID.Clear();
            }
            else
            {
                erPr_CID.SetError(txtB_CID, "Course ID can't be empty");
                return;
            }

            string cid = txtB_CID.Text;
            if (course.CheckCID(cid))
            {
                if (course.DoEnroll("", txtB_CID.Text))
                {
                    MessageBox.Show("Remove failed: This course has some students enrolled in, remove those data first", "Manage course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (course.RemoveCourse(cid))
                {
                    MessageBox.Show("Removed course!", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                else
                {
                    MessageBox.Show("Remove failed..", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("CID doesn't exist", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable fillStudents(string CID)
        {
            try
            {
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
            catch(Exception exc) { MessageBox.Show(exc.Message, "Course Manage", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
        }

        private void dGV_Courses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cou_StuListFrm cSLFrm = new Cou_StuListFrm();
            cSLFrm.lbl_CouC.Text = dGV_Courses.CurrentRow.Cells["CName"].Value.ToString().Trim();
            //cSLFrm.dGV_StuList.Columns.Clear();
            string cid = dGV_Courses.CurrentRow.Cells["CID"].Value.ToString().Trim();
            cSLFrm.CID = cid;
            cSLFrm.dGV_StuList.DataSource = fillStudents(cid);
            cSLFrm.dGV_StuList.Columns["StuID"].HeaderText = "Student ID";
            cSLFrm.dGV_StuList.Columns["FName"].HeaderText = "Firstname";
            cSLFrm.dGV_StuList.Columns["LName"].HeaderText = "Lastname";
            cSLFrm.dGV_StuList.Columns["BDate"].HeaderText = "DoB";
            cSLFrm.dGV_StuList.Columns["Sem"].HeaderText = "Semester";
            cSLFrm.ShowDialog();
        }
    }
}
