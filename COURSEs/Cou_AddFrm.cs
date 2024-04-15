using System;
using System.Windows.Forms;

namespace WIPR170124.COURSEs
{
    public partial class Cou_AddFrm : Form
    {
        public Cou_AddFrm()
        {
            InitializeComponent();
        }

        private void Cou_AddFrm_Load(object sender, EventArgs e)
        {

        }

        ServiceClasses.COURSE course = new ServiceClasses.COURSE();

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            //handling Course ID
            if (txtB_CID.Text.Length > 0 && course.IsLetsAndDigs(txtB_CID.Text))
            {
                erPR_CID.Clear();
            }
            else
            {
                erPR_CID.SetError(txtB_CID, "Course ID can only contains letters and digits");
                return;
            }
            //handling Course name
            if (txtB_CName.Text.Length > 0)
            {
                erPr_CName.Clear();
            }
            else
            {
                erPr_CName.SetError(txtB_CName, "Course name can't be empty");
                return;
            }
            //handling period
            if (txtB_Period.Text.Length > 0 && course.IsDigits(txtB_Period.Text) && int.Parse(txtB_Period.Text) > 10)
            {
                erPr_Period.Clear();
            }
            else
            {
                erPr_Period.SetError(txtB_Period, "Period must be a number and greater than 10");
                return;
            }

            if (!course.CheckCID(txtB_CID.Text))
            {
                if (course.AddCourse(txtB_CID.Text, txtB_CName.Text, int.Parse(txtB_Period.Text), rTB_Descr.Text))
                {
                    MessageBox.Show("Course added!", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add failed..", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("CID already exists", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
