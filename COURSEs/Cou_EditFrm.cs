using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WIPR170124.COURSEs
{
    public partial class Cou_EditFrm : Form
    {
        public Cou_EditFrm()
        {
            InitializeComponent();
        }

        ServiceClasses.COURSE course = new ServiceClasses.COURSE();
        private bool loaded = false;

        private void Cou_EditFrm_Load(object sender, EventArgs e)
        {
            txtB_CName.Enabled = false;
            nUD_Period.Enabled = false;
            rTB_Descr.Enabled = false;
            bttn_Edit.Enabled = false;
            /*comB_CName.DataSource = null;
            comB_CName.Items.Clear();*/

            /*try
            {*/
            System.Data.DataTable dt = null;
            using (SqlConnection conn = new MyDB().Connection)
            {
                string getStr = "SELECT * FROM CourseTable";
                using (SqlCommand cmd = new SqlCommand(getStr, conn))
                {
                    dt = course.GetAllCourses(cmd);

                    if (dt != null)
                    {
                        comB_CID.DataSource = dt;
                        comB_CID.DisplayMember = "CName";
                        comB_CID.ValueMember = "CID";
                        comB_CID.SelectedItem = null;

                        loaded = true;
                    }
                }
            }/*
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void comB_CName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && comB_CID.Items != null && comB_CID.SelectedIndex != -1)
            {
                var cid = comB_CID.SelectedValue.ToString();
                if (cid.Length == 3)    //
                {
                    DataTable dT = course.GetACourse(cid);
                    if (dT != null)
                    {
                        txtB_CName.Text = dT.Rows[0]["CName"].ToString();
                        nUD_Period.Value = int.Parse(dT.Rows[0]["Period"].ToString());
                        rTB_Descr.Text = dT.Rows[0]["Description"].ToString();

                        txtB_CName.Enabled = true;
                        nUD_Period.Enabled = true;
                        rTB_Descr.Enabled = true;
                        bttn_Edit.Enabled = true;
                    }
                }
                else
                {
                    txtB_CName.Enabled = false;
                    nUD_Period.Enabled = false;
                    rTB_Descr.Enabled = false;
                    bttn_Edit.Enabled = false;
                }
            }
        }

        private void bttn_Edit_Click(object sender, EventArgs e)
        {
            ServiceClasses.COURSE course = new ServiceClasses.COURSE();
            if(course.UpdateCourse(comB_CID.SelectedValue.ToString(),txtB_CName.Text, Convert.ToInt16(nUD_Period.Value), rTB_Descr.Text))
            {
                MessageBox.Show("Edited!", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cou_EditFrm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Edit failed!", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
