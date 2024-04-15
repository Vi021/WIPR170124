using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIPR170124.ServiceClasses;

namespace WIPR170124.COURSEs
{
    public partial class Cou_RemoveFrm : Form
    {
        public Cou_RemoveFrm()
        {
            InitializeComponent();
        }

        ServiceClasses.COURSE course = new ServiceClasses.COURSE();
        private bool loaded = false;

        private void load()
        {
            System.Data.DataTable dt = null;
            using (SqlConnection conn = new MyDB().Connection)
            {
                string getStr = "SELECT * FROM CourseTable";
                using (SqlCommand cmd = new SqlCommand(getStr, conn))
                {
                    dt = course.GetAllCourses(cmd);

                    if (dt != null)
                    {
                        comB_Course.DataSource = dt;
                        comB_Course.DisplayMember = "CName";
                        comB_Course.ValueMember = "CID";
                        comB_Course.SelectedItem = null;

                        txtB_CID.Text = "";
                    }
                }
            }
        }

        private void Cou_RemoveFrm_Load(object sender, EventArgs e)
        {
            load();
            loaded = true;
            
            txtB_CID.Enabled = false;
            txtB_CID.ReadOnly = true;
            bttn_Remove.Enabled = false;
        }

        private void comB_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && comB_Course.Items != null && comB_Course.SelectedIndex != -1)
            {
                var cid = comB_Course.SelectedValue.ToString();
                if (cid.Length == 3)    //
                {
                    DataTable dT = course.GetACourse(cid);
                    if (dT != null)
                    {
                        txtB_CID.Text = dT.Rows[0]["CID"].ToString();
                        txtB_CID.Enabled = true;
                        bttn_Remove.Enabled = true;
                    }
                }
                else
                {
                    txtB_CID.Enabled = false;
                    bttn_Remove.Enabled = false;
                }
            }
        }

        private void bttn_Remove_Click(object sender, EventArgs e)
        {
            if (txtB_CID.Text.Length > 0)
            {
                erPr_CID.Clear();
                ServiceClasses.COURSE course = new ServiceClasses.COURSE();
                if (!course.CheckCID(txtB_CID.Text))
                {
                    MessageBox.Show("CID doesn't exist", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (course.DoEnroll("", txtB_CID.Text))
                {
                    MessageBox.Show("Remove failed: This course has some students enrolled in, remove those data first", "Manage course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (course.RemoveCourse(txtB_CID.Text))
                {
                    MessageBox.Show("Removed course!", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                else
                {
                    MessageBox.Show("Remove failed..", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                erPr_CID.SetError(bttn_Remove, "Course ID can't be empty");
            }
        }
    }
}
