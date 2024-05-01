using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIPR170124.ServiceClasses;

namespace WIPR170124.GRADEs
{
    public partial class Gra_GradeCellFrm : Form
    {
        public Gra_GradeCellFrm()
        {
            InitializeComponent();
        }

        internal string StuID = "";
        internal string SName = "";
        internal string CID = "";
        internal string CName = "";
        internal int Sem = -1;
        internal float Grade = -1;

        private void Gra_GradeCellFrm_Load(object sender, EventArgs e)
        {
            txtB_SName.ReadOnly = true;
            txtB_CName.ReadOnly = true;
            txtB_Sem.ReadOnly = true;

            if (SName.Length > 0 && CName.Length > 0 && (0 < Sem && Sem < 4) && (0 <= Grade && Grade <= 10))
            {
                txtB_SName.Text = SName;
                txtB_CName.Text = CName;
                txtB_Sem.Text = Sem.ToString();
                txtB_Grade.Text = Grade.ToString();
            }
        }

        private void bttn_Edit_Click(object sender, EventArgs e)
        {
            if (txtB_Grade.Text.Length > 0)
            {
                erPr_Grade.Clear();

                float grade = (float)Math.Round(Convert.ToDouble(txtB_Grade.Text), 2);
                if (0 <= grade && grade <= 10)
                {
                    erPr_Grade.Clear();
                    GRADE g = new GRADE();
                    if (g.UpdateGrade(StuID, CID, Sem, grade))
                    {
                        Grade = grade;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable to change score..", "Manage score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    erPr_Grade.SetError(txtB_Grade, "Invalid score: Score must be a number and 0 <= Score <= 10");
                }
            }
            else
            {
                erPr_Grade.SetError(txtB_Grade, "Score can't be empty");
            }
        }

        private void bttn_Remove_Click(object sender, EventArgs e)
        {
            if (txtB_Grade.Text.Length > 0)
            {
                erPr_Grade.Clear();

                float grade = (float)Convert.ToDouble(txtB_Grade.Text);
                if (0 <= grade && grade <= 10)
                {
                    erPr_Grade.Clear();
                    GRADE g = new GRADE();
                    if (g.RemoveGrade(StuID, CID, Sem))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete core..", "Manage score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    erPr_Grade.SetError(txtB_Grade, "Invalid score: Score must be a number and 0 <= Score <= 10");
                }
            }
            else
            {
                erPr_Grade.SetError(txtB_Grade, "Score can't be empty");
            }
        }
    }
}
