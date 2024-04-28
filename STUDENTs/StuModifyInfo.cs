using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WIPR170124.ServiceClasses;

namespace WIPR170124
{
    public partial class StuModifyInfo : Form
    {
        MyDB myDB = new MyDB();
        STUDENT student = new STUDENT();

        public StuModifyInfo()
        {
            InitializeComponent();
        }

        private void but_Find_Click(object sender, EventArgs e)
        {
            string stuId = txtBox_stuID.Text;

            SqlCommand cmd = new SqlCommand("SELECT StuID, FName, LName, BDate, Gender, Phone, Address, Mugshot FROM QLSVDB WHERE StuID = '" + stuId + "'");

            DataTable table = student.GetStudents(cmd);

            if (table.Rows.Count > 0)
            {
                txtBox_stuFName.Text = table.Rows[0]["FName"].ToString();
                txtBox_stuLName.Text = table.Rows[0]["LName"].ToString();
                DaTi_stuBrthDate.Text = table.Rows[0]["BDate"].ToString();
                txtBox_stuPNumber.Text = table.Rows[0]["Phone"].ToString();
                txtBox_stuAddress.Text = table.Rows[0]["Address"].ToString();

                if (table.Rows[0]["Gender"].ToString().Contains("Male"))
                {
                    Gender_Male.Checked = true;
                }
                else if (table.Rows[0]["Gender"].ToString().Contains("Female"))
                {
                    Gender_Female.Checked = true;
                }
                else
                {
                    Gender_Others.Checked = true;
                }

                byte[] imageBytes = table.Rows[0]["Mugshot"] as byte[];
                if (imageBytes != null)
                {
                    MemoryStream ms = new MemoryStream(imageBytes);
                    Image image = Image.FromStream(ms);

                    picBox_stuPic.BackgroundImage = image;
                }

                /*
                SqlConnection conn = myDB.GetConnetion;
                
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    byte[] imageBytes = reader["Mugshot"] as byte[];
                    if (imageBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Image image = Image.FromStream(ms);
                            picBox_stuPic.BackgroundImage = image;
                        }
                    }
                }
                reader.Close();
                conn.Close();*/
            }
            else
            {
                MessageBox.Show("No match!", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void but_Remove_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.OK;
            if (txtBox_stuID.Text != "" && student.verifyID(txtBox_stuID.Text))
            {
                result = MessageBox.Show("You are certain to remove this student, yes?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show($"Unable to find student with ID: {txtBox_stuID.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (result == DialogResult.Cancel)
            {
                return;
            }

            COURSE course = new COURSE();
            GRADE grade = new GRADE();

            if (course.DoEnroll(txtBox_stuID.Text.Trim()))
            {
                MessageBox.Show("Remove failed: This student is enrolled in some courses, remove those data first", "Manage student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*if (course.RemoveEnroll(txtBox_stuID.Text.Trim()))
                if (grade.RemoveGrade(txtBox_stuID.Text.Trim()))*/
            if (student.RemoveStudent(txtBox_stuID.Text))
                        return;

            MessageBox.Show("Remove failed", "Modify Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Dictionary<string, string> Courses = new Dictionary<string, string>();
        private void ModifyStudentInfo_Load(object sender, EventArgs e)
        {
            this.Size = new Size(360, 560);

            DaTi_stuBrthDate.MaxDate = DateTime.Now;
            DaTi_stuBrthDate.Value = DateTime.Now.AddMinutes(-1);

            ServiceClasses.COURSE course = new ServiceClasses.COURSE();
            using (SqlConnection conn = new MyDB().Connection)
            {
                conn.Open();
                string getStr = "SELECT * FROM CourseTable";
                using (SqlCommand cmd = new SqlCommand(getStr, conn))
                {
                    DataTable dt = course.GetAllCourses(cmd);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string cname = dt.Rows[i]["CName"].ToString().Trim();
                        string cid = dt.Rows[i]["CID"].ToString().Trim();
                        cLB_Courses.Items.Add(cname);
                        Courses.Add(cname, cid);
                    }
                }
            }
        }

        private void but_Update_Click(object sender, EventArgs e)
        {
            string stuId = txtBox_stuID.Text.Trim();
            if (!student.verifyID(stuId))
            {
                MessageBox.Show("This ID does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErPr_StuID.SetError(but_Find, "This ID does not exist!");
                return;
            }
            ErPr_StuID.Clear();

            string fname = txtBox_stuFName.Text;
            if (onlyLetters(txtBox_stuFName.Text))
            {
                ErPr_FName.SetError(txtBox_stuFName, "");
            }
            else
            {
                MessageBox.Show("Name can't contain digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErPr_FName.SetError(txtBox_stuFName, "Name can't contain digits");
                return;
            }

            string lname = txtBox_stuLName.Text;
            if (onlyLetters(txtBox_stuLName.Text))
            {
                ErPr_LName.SetError(txtBox_stuLName, "");
            }
            else
            {
                MessageBox.Show("Name can't contain digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErPr_FName.SetError(txtBox_stuLName, "Name can't contain digits");
                return;
            }

            string pnumber = txtBox_stuPNumber.Text;
            string addr = txtBox_stuAddress.Text;
            MemoryStream pic = new MemoryStream();

            string gender = "Others";
            if (Gender_Male.Checked)
            {
                gender = "Male";
            }
            else if (Gender_Female.Checked)
            {
                gender = "Female";
            }

            DateTime bdate = DaTi_stuBrthDate.Value;

            int bYear = bdate.Year;
            int thisYear = DateTime.Now.Year;
            if (thisYear - bYear < 18 || thisYear - bYear > 100)
            {
                MessageBox.Show("You must be from 18-100 years old to be a college student!", "Invalid birtdate!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int con = 0;
            if (comB_Semester.SelectedIndex != -1) con += 1;
            if (cLB_Courses.CheckedItems.Count > 0) con += 2;
            if (con == 1)
            {
                erPr_SemCou.SetError(cLB_Courses, "Please select atleast 1 course");
            }
            else if (con == 2)
            {
                erPr_SemCou.SetError(comB_Semester, "Please choose a semester");
            }
            else
            {
                erPr_SemCou.Clear();

                if (!(txtBox_stuFName.Text.Trim() == "" || txtBox_stuLName.Text.Trim() == "" || txtBox_stuPNumber.Text.Trim() == "" || txtBox_stuAddress.Text.Trim() == ""))
                {
                    picBox_stuPic.BackgroundImage.Save(pic, picBox_stuPic.BackgroundImage.RawFormat);

                    if (student.ModifyStudent(stuId, fname, lname, bdate, gender, pnumber, addr, pic))
                    {
                        if (con == 3)
                        {
                            ServiceClasses.COURSE course = new ServiceClasses.COURSE();
                            foreach (string cname in cLB_Courses.CheckedItems)
                            {
                                //MessageBox.Show($"Courses: {Courses[cname]} - {cname}");
                                int sem = Convert.ToInt32(comB_Semester.SelectedItem.ToString());
                                if (!course.DoEnroll(stuId, Courses[cname], sem))
                                {
                                    if (!course.EnrollCourse(stuId, Courses[cname], sem))
                                    {
                                        MessageBox.Show($"Unable to add \"{cname}\" ({sem}) for {stuId}", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        
                        MessageBox.Show("Modified successfully!", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        }

        private void bttn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Select Image(*.png;*.jpg)|*png;*jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picBox_stuPic.BackgroundImage = Image.FromFile(ofd.FileName);
                picBox_stuPic.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private bool onlyLetters(string text)
        {
            string pattern = "^[a-zA-Z ]+$";

            return Regex.IsMatch(text, pattern);
        }

        private void txtBox_stuFName_TextChanged(object sender, EventArgs e)
        {
            /*if(onlyLetters(txtBox_stuFName.Text))
            {
                return true;
            }
            else
            {
                return false;
            }*/
        }

        private void txtBox_stuLName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}