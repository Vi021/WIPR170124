using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WIPR170124.ServiceClasses;

namespace WIPR170124.STUDENTs
{
    public partial class StuCouListFrm : Form
    {
        public StuCouListFrm()
        {
            InitializeComponent();
        }

        internal string StuID = "";
        internal string CID = "";
        internal int Sem = -1;

        STUDENT stu = new STUDENT();

        private void StuCouListFrm_Load(object sender, System.EventArgs e)
        {
            if (StuID.Length > 0 && CID.Length > 0 && (0 < Sem && Sem < 4))
            {
                if (stu.verifyID(StuID))
                {
                    stu.GetEnrolledCourses(StuID);
                }
            }
        }

        private void dGV_CouList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("You are certain to remove this student, yes?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                COURSE course = new COURSE();

                CID = dGV_CouList.CurrentRow.Cells["CID"].Value.ToString().Trim();
                Sem = Convert.ToInt32(dGV_CouList.CurrentRow.Cells["Sem"].Value.ToString());

                if (StuID.Length > 0 && CID.Length > 0 && (0 < Sem && Sem < 4))
                {
                    if (stu.verifyID(StuID) && course.CheckCID(CID))
                    {
                        GRADE grade = new GRADE();
                        if (grade.HasGrade(StuID, CID, Sem))
                        {
                            MessageBox.Show($"Remove failed: This student has score in Course: {CID}, semester: {Sem}.\nRemove those data first", "Manage student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (course.RemoveEnroll(StuID, CID, Sem))
                        {
                            dGV_CouList.DataSource = stu.GetEnrolledCourses(StuID);
                        }
                        else
                        {
                            MessageBox.Show($"Unable to remove this student from Course: {CID} - Semester: {Sem}", "Student's courses", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid data", "Student's courses", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Unable to get info", "Student's courses", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
