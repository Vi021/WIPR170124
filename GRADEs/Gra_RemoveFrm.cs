using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR170124.GRADEs
{
    public partial class Gra_RemoveFrm : Form
    {
        public Gra_RemoveFrm()
        {
            InitializeComponent();
        }

        ServiceClasses.GRADE grade = new ServiceClasses.GRADE();

        private void Gra_RemoveFrm_Load(object sender, EventArgs e)
        {
            dGV_Scores.DataSource = grade.GetAllGrades();
            dGV_Scores.Columns["StuID"].HeaderText = "Student ID";
            dGV_Scores.Columns["CID"].HeaderText = "Course ID";
            dGV_Scores.Columns["Sem"].HeaderText = "Semester";

            txtB_StuID.ReadOnly = true;
            txtB_CID.ReadOnly = true;
            txtB_Sem.ReadOnly = true;
            bttn_Remove.Enabled = false;
        }

        private void dGV_Scores_Click(object sender, EventArgs e)
        {
            if (dGV_Scores.Rows.Count == 0)
            {
                bttn_Remove.Enabled = false;
                return;
            }
            txtB_StuID.Text = dGV_Scores.CurrentRow.Cells["StuID"].Value.ToString().Trim();
            txtB_CID.Text = dGV_Scores.CurrentRow.Cells["CID"].Value.ToString().Trim();
            txtB_Sem.Text = dGV_Scores.CurrentRow.Cells["Sem"].Value.ToString().Trim();
            bttn_Remove.Enabled = true;
        }

        private void bttn_Remove_Click(object sender, EventArgs e)
        {   
            if(grade.RemoveGrade(txtB_StuID.Text.Trim(), txtB_CID.Text.Trim(), Convert.ToInt32(txtB_Sem.Text)))
            {
                MessageBox.Show("Removed!", "Remove score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Gra_RemoveFrm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Remove failed..", "Remove score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
