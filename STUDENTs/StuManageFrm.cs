using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIPR170124.ServiceClasses;
//using static System.Net.Mime.MediaTypeNames;

namespace WIPR170124
{
    public partial class StuManageFrm : Form
    {
        public StuManageFrm()
        {
            InitializeComponent();
        }

        private void ManageStudentFrm_Load(object sender, EventArgs e)
        {
            DaTi_BDate.MaxDate = DateTime.Now;
            DaTi_BDate.Value = DateTime.Now.AddMinutes(-1);
            if(dGV_1.DataSource == null)
            {
                lbl_Total.Text = "Total students: 0";
            }
            else
            {
                lbl_Total.Text = "Total students: " + dGV_1.Rows.Count.ToString();
            }
        }

        private void txtB_StuID_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z0-9]+$";

            if (Regex.IsMatch(txtB_StuID.Text, pattern))
            {
                erPr_StuID.Clear();
            }
            else
            {
                erPr_StuID.SetError(txtB_StuID, "ID can only contains letters and digits");
            }
        }

        private void bttn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Select Image(*.png;*.jpg)|*png;*jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picB_Pic.BackgroundImage = Image.FromFile(ofd.FileName);
                picB_Pic.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void bttn_Download_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();

            svf.FileName = ("student_" + txtB_StuID.Text.Trim()+"_Pic");
            if(picB_Pic.BackgroundImage == null)
            {
                MessageBox.Show("No image to download!");
            }
            else if (svf.ShowDialog() == DialogResult.OK)
            {
                picB_Pic.BackgroundImage.Save(svf.FileName + (".jpeg"));            //
            }
        }

        private void fillGrid(SqlCommand cmd)
        {
            STUDENT student = new STUDENT();
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            dGV_1.Columns.Clear();
            dGV_1.DataSource = null;

            dGV_1.RowTemplate.Height = 50;
            dGV_1.DataSource = student.GetStudents(cmd);

            picCol = (DataGridViewImageColumn)dGV_1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridViewColumn dgvc = new DataGridViewTextBoxColumn();
            dgvc.HeaderText = "Selected course(s)";
            dgvc.Name = "SCs";
            
            dGV_1.Columns.Add(dgvc);

            foreach (DataGridViewRow dr in dGV_1.Rows)
            {
                dr.Cells["SCs"].Value = "...";
            }
        }

        private void bttn_Search_Click(object sender, EventArgs e)
        {
            string searchStr = "SELECT * FROM QLSVDB WHERE CONCAT(FName,LName,Address) LIKE '%" + txtB_Search.Text + "%'";
            SqlCommand cmd = new SqlCommand(searchStr);

            fillGrid(cmd);

            dGV_1.Columns["StuID"].HeaderText = "Student ID";
            dGV_1.Columns["FName"].HeaderText = "Firstname";
            dGV_1.Columns["LName"].HeaderText = "Lastname";
            dGV_1.Columns["BDate"].HeaderText = "Birthdate";

            if (dGV_1.DataSource == null)
            {
                lbl_Total.Text = "Total students: 0";
            }
            else
            {
                lbl_Total.Text = "Total students: " + dGV_1.Rows.Count.ToString();
            }
        }

        private void dGV_1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtB_StuID.Text = dGV_1.CurrentRow.Cells[0].Value.ToString().Trim();
            txtB_Fname.Text = dGV_1.CurrentRow.Cells[1].Value.ToString();
            txtB_Lname.Text = dGV_1.CurrentRow.Cells[2].Value.ToString();
            txtB_Pnumber.Text = dGV_1.CurrentRow.Cells[5].Value.ToString();
            rtxtB_Addr.Text = dGV_1.CurrentRow.Cells[6].Value.ToString();

            DaTi_BDate.Value = ((DateTime)dGV_1.CurrentRow.Cells[3].Value).Date;

            string gender = dGV_1.CurrentRow.Cells[4].Value.ToString();
            if (gender.Contains("Male"))
            {
                rBtn_Male.Checked = true;
            }
            else if (gender.Contains("Female"))
            {
                rBtn_Female.Checked = true;
            }
            else
            {
                rBtn_Others.Checked = true;
            }

            MemoryStream image = new MemoryStream(dGV_1.CurrentRow.Cells[7].Value as byte[]);
            picB_Pic.BackgroundImage = Image.FromStream(image);
        }

        public bool verify()
        {
            if (txtB_Fname.Text.Trim() == "" || txtB_Lname.Text.Trim() == "" || txtB_Pnumber.Text.Trim() == "" || rtxtB_Addr.Text.Trim() == "" || picB_Pic.BackgroundImage == null)
                return false;
            else
                return true;
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            STUDENT stu = new STUDENT();

            string stuId = txtB_StuID.Text;
            if (stu.verifyID(stuId))
            {
                MessageBox.Show("This ID is already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erPr_StuID.SetError(txtB_StuID, "This ID is already exist");
                return;
            }
            else
            {
                erPr_StuID.Clear();
            }

            string fname = txtB_Fname.Text;
            if (stu.OnlyLettersAndSpace(txtB_Fname.Text))
            {
                erPr_Fname.Clear();
            }
            else
            {
                MessageBox.Show("Name can't contain digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erPr_Fname.SetError(txtB_Fname, "Name can't contain digits");
                return;
            }

            string lname = txtB_Lname.Text;
            if (stu.OnlyLettersAndSpace(txtB_Lname.Text))
            {
                erPr_Lname.Clear();
            }
            else
            {
                MessageBox.Show("Name can't contain digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erPr_Lname.SetError(txtB_Lname, "Name can't contain digits");
                return;
            }

            string pnumber = txtB_Pnumber.Text;
            string addr = rtxtB_Addr.Text;
            MemoryStream pic = new MemoryStream();

            string gender = "Others";
            if (rBtn_Male.Checked)
            {
                gender = "Male";
            }
            else if (rBtn_Female.Checked)
            {
                gender = "Female";
            }

            DateTime bdate = DaTi_BDate.Value;

            int bYear = bdate.Year;
            int thisYear = DateTime.Now.Year;
            if (thisYear - bYear < 18 || thisYear - bYear > 100)
            {
                MessageBox.Show("You must be from 18-100 years old to be a college student!", "Invalid birtdate!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                picB_Pic.BackgroundImage.Save(pic, picB_Pic.BackgroundImage.RawFormat);

                if (stu.AddStudent(stuId, fname, lname, bdate, gender, pnumber, addr, pic))
                {
                    MessageBox.Show("Added successfully!", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bttn_Search.PerformClick();
                }
                else
                {
                    MessageBox.Show("Unable to add a new student", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields must not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttn_Edit_Click(object sender, EventArgs e)
        {
            STUDENT stu = new STUDENT();
            string stuId = txtB_StuID.Text;
            if (!stu.verifyID(stuId))
            {
                MessageBox.Show("This ID does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erPr_StuID.SetError(txtB_StuID, "This ID does not exist!");
                return;
            }
            else
            {
                erPr_StuID.Clear();
            }

            string fname = txtB_Fname.Text;
            if (stu.OnlyLettersAndSpace(txtB_Fname.Text))
            {
                erPr_Fname.Clear();
            }
            else
            {
                MessageBox.Show("Name can't contain digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erPr_Fname.SetError(txtB_Fname, "Name can't contain digits");
                return;
            }

            string lname = txtB_Lname.Text;
            if (stu.OnlyLettersAndSpace(txtB_Lname.Text))
            {
                erPr_Lname.Clear();
            }
            else
            {
                MessageBox.Show("Name can't contain digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erPr_Lname.SetError(txtB_Lname, "Name can't contain digits");
                return;
            }

            string pnumber = txtB_Pnumber.Text;
            string addr = rtxtB_Addr.Text;
            MemoryStream pic = new MemoryStream();

            string gender = "Others";
            if (rBtn_Male.Checked)
            {
                gender = "Male";
            }
            else if (rBtn_Female.Checked)
            {
                gender = "Female";
            }

            DateTime bdate = DaTi_BDate.Value;

            int bYear = bdate.Year;
            int thisYear = DateTime.Now.Year;
            if (thisYear - bYear < 18 || thisYear - bYear > 100)
            {
                MessageBox.Show("You must be from 18-100 years old to be a college student!", "Invalid birtdate!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(txtB_Fname.Text.Trim() == "" || txtB_Lname.Text.Trim() == "" || txtB_Pnumber.Text.Trim() == "" || rtxtB_Addr.Text.Trim() == ""))
            {
                picB_Pic.BackgroundImage.Save(pic, picB_Pic.BackgroundImage.RawFormat);

                if (stu.ModifyStudent(stuId, fname, lname, bdate, gender, pnumber, addr, pic))
                {
                    MessageBox.Show("Modified successfully!", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bttn_Search.PerformClick();
                }
                else
                {
                    MessageBox.Show("Unable to modify student", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields must not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttn_Remove_Click(object sender, EventArgs e)
        {
            STUDENT stu = new STUDENT();
            DialogResult result = DialogResult.OK;
            if (txtB_StuID.Text != "" && stu.verifyID(txtB_StuID.Text))
            {
                result = MessageBox.Show("You are certain to remove this student, yes?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show($"Unable to find student with ID: {txtB_StuID.Text.Trim()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                COURSE course = new COURSE();
                if (course.DoEnroll(txtB_StuID.Text.Trim()))
                {
                    MessageBox.Show("Remove failed: This student is enrolled in some courses, remove those data first", "Manage student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                stu.RemoveStudent(txtB_StuID.Text.Trim());
                bttn_Search.PerformClick();
            }
        }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            txtB_StuID.Clear();
            txtB_Fname.Clear();
            txtB_Lname.Clear();
            txtB_Pnumber.Clear();
            rtxtB_Addr.Clear();
            txtB_Search.Clear();

            if(rBtn_Male.Checked) rBtn_Male.Checked = false;
            if(rBtn_Female.Checked) rBtn_Female.Checked = false;
            if(rBtn_Others.Checked) rBtn_Others.Checked = false;

            DaTi_BDate.MaxDate = DateTime.Now;
            DaTi_BDate.Value = DateTime.Now.AddMinutes(-1);

            picB_Pic.Image = null;

            dGV_1.DataSource = null;
            lbl_Total.Text = "Total students: 0";
        }

        private void dGV_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGV_1.CurrentCell == dGV_1.CurrentRow.Cells["SCs"])
            {
                STUDENTs.StuCouListFrm sCLFrm = new STUDENTs.StuCouListFrm();

                sCLFrm.lbl_StuNameC.Text = dGV_1.CurrentRow.Cells["LName"].Value.ToString().Trim() + " " + dGV_1.CurrentRow.Cells["FName"].Value.ToString().Trim();
                string stuid = dGV_1.CurrentRow.Cells["StuID"].Value.ToString().Trim();
                sCLFrm.lbl_StuIDC.Text = stuid;
                sCLFrm.StuID = stuid;
                STUDENT student = new STUDENT();
                sCLFrm.dGV_CouList.DataSource = student.GetEnrolledCourses(stuid);
                sCLFrm.dGV_CouList.Columns["CID"].HeaderText = "Course ID";
                sCLFrm.dGV_CouList.Columns["CName"].HeaderText = "Name";
                sCLFrm.dGV_CouList.Columns["Sem"].HeaderText = "Semester";

                sCLFrm.ShowDialog();
            }
        }
    }
}
