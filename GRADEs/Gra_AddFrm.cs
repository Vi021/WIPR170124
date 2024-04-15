using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WIPR170124.ServiceClasses;

namespace WIPR170124.GRADEs
{
    public partial class Gra_AddFrm : Form
    {
        public Gra_AddFrm()
        {
            InitializeComponent();
        }

        COURSE course = new COURSE();
        GRADE grade = new GRADE();
        STUDENT student = new STUDENT();
        private bool loaded = false;

        private void load(string CID = null)
        {
            DataTable dt = null;
            using (SqlConnection conn = new MyDB().Connection)
            {
                string getStr = "";
                if (CID != null)
                {
                    getStr = "SELECT * FROM CourseTable WHERE CID = @cid";
                }
                else
                {
                    getStr = "SELECT * FROM CourseTable";
                }
                using (SqlCommand cmd = new SqlCommand(getStr, conn))
                {
                    if (CID != null)
                    {
                        cmd.Parameters.AddWithValue("@cid", CID);
                    }

                    dt = course.GetAllCourses(cmd);

                    if (dt != null)
                    {
                        comB_CID.DataSource = dt;
                        comB_CID.DisplayMember = "CName";
                        comB_CID.ValueMember = "CID";
                        comB_CID.SelectedItem = null;
                        comB_CID.Text = "";

                        loaded = true;
                    }
                }
            }
        }

        private void Gra_AddFrm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT StuID, Lname, Fname FROM QLSVDB");

            dGV_Scores.DataSource = student.GetStudents(cmd);
            dGV_Scores.Columns["Lname"].HeaderText = "Lastname";
            dGV_Scores.Columns["Fname"].HeaderText = "Firstname";

            load();
        }

        private void comB_CID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && comB_CID.Items != null && comB_CID.SelectedIndex != -1)
            {
                SqlCommand cmd = new SqlCommand("SELECT QLSVDB.StuID, Lname, Fname, Sem FROM QLSVDB, EnrollTable WHERE QLSVDB.StuID = EnrollTable.StuID AND EnrollTable.CID = @cid");
                cmd.Parameters.AddWithValue("@cid", comB_CID.SelectedValue.ToString().Trim());

                dGV_Scores.DataSource = student.GetStudents(cmd);
                dGV_Scores.Columns["Lname"].HeaderText = "Lastname";
                dGV_Scores.Columns["Fname"].HeaderText = "Firstname";
                dGV_Scores.Columns["Sem"].HeaderText = "Semester";
            }
            else
            {
                dGV_Scores.DataSource = null;
            }
        }

        private void dGV_Scores_Click(object sender, EventArgs e)
        {
            if (dGV_Scores.Rows.Count != 0)
            {
                txtB_StuID.Text = dGV_Scores.CurrentRow.Cells["StuID"].Value.ToString().Trim();
                comB_Sem.SelectedIndex = Convert.ToInt32(dGV_Scores.CurrentRow.Cells["Sem"].Value.ToString()) - 1;
            }
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            //StuID
            if (student.verifyID(txtB_StuID.Text))
            {
                erPr_StuID.Clear();
            }
            else
            {
                erPr_StuID.SetError(txtB_StuID, "This ID doen't exist" + txtB_StuID.Text);
                return;
            }
            //CID
            if (comB_CID.SelectedIndex == -1)
            {
                erPr_Add.SetError(comB_CID, "Select a course");
                return;
            }
            else
            {
                erPr_Add.Clear();
            }
            //Sem
            if (comB_Sem.SelectedIndex == -1)
            {
                erPr_Add.SetError(comB_Sem, "Select a semester");
                return;
            }
            else
            {
                erPr_Add.Clear();
            }
            //Grade
            if (0 <= Convert.ToDouble(txtB_Score.Text) && Convert.ToDouble(txtB_Score.Text) <= 10)
            {
                erPr_Grade.Clear();
            }
            else
            {
                erPr_Grade.SetError(txtB_Score, "Invalid score");
                return;
            }
            //is in EnrollTable
            if (course.DoEnroll(txtB_StuID.Text.Trim(), comB_CID.SelectedValue.ToString().Trim(), Convert.ToInt32(comB_Sem.SelectedItem.ToString())))
            {
                erPr_Add.Clear();
            }
            else
            {
                erPr_Add.SetError(bttn_Add, "This student does not enroll in this course or wrong semester");
                return;
            }
            //is graded
            if (grade.HasGrade(txtB_StuID.Text.Trim(), comB_CID.SelectedValue.ToString(), Convert.ToInt32(comB_Sem.SelectedItem.ToString())))
            {
                MessageBox.Show("Already has a score, please change in Manage Score instead!", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (grade.AddGrade(txtB_StuID.Text.Trim(), comB_CID.SelectedValue.ToString(), Convert.ToInt32(comB_Sem.SelectedItem.ToString()), Convert.ToDouble(txtB_Score.Text), rTB_Descr.Text))
            {
                MessageBox.Show("Score added!", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.comB_CID_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Add score failed", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
