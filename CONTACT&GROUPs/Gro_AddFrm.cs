using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Windows.Forms;
using WIPR170124.ServiceClasses;

namespace WIPR170124.CONTACT_GROUPs
{
    public partial class Gro_AddFrm : Form
    {
        public Gro_AddFrm()
        {
            InitializeComponent();
        }

        private void Gro_AddFrm_Load(object sender, EventArgs e)
        {

        }

        GROUP group = new GROUP();
        private bool check()
        {
            bool accepted = true;

            //ID
            if (group.int_able(txtB_ID.Text) && Convert.ToInt32(txtB_ID.Text) >= 0)
            {
                if (!group.id_exist(Convert.ToInt32(txtB_ID.Text)))
                {
                    erPr_ID.Clear();
                }
                else
                {
                    erPr_ID.SetError(txtB_ID, "ID is in use, try another one");
                    accepted = false;
                }
            }
            else
            {
                erPr_ID.SetError(txtB_ID, "Field must contains positive numbers 0-9");
                accepted = false;
            }

            //Name
            if (group.name_valid(txtB_Name.Text))
            {
                erPr_Name.Clear();
            }
            else
            {
                erPr_Name.SetError(txtB_Name, "Field must contains spaces and letters a-z and A-Z");
                accepted = false;
            }

            return accepted;
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (group.AddGroup(Convert.ToInt32(txtB_ID.Text), txtB_Name.Text))
                {
                    MessageBox.Show("Added!", "Add a Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Add failed..", "Add a Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
