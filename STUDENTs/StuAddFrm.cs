using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WIPR170124
{
    public partial class StuAddFrm : Form
    {
        public StuAddFrm()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            DaTi_stuBrthDate.MaxDate = DateTime.Now;
            DaTi_stuBrthDate.Value = DateTime.Now.AddMinutes(-1);
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            STUDENT stu = new STUDENT();

            string stuId = txtBox_stuID.Text;
            if (stu.verifyID(stuId))
            {
                MessageBox.Show("This ID is already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErPr_StuID.SetError(txtBox_stuID, "This ID is already exist");
                return;
            }
            else
            {
                ErPr_StuID.SetError(txtBox_stuID, "");
            }

            string fname = txtBox_stuFName.Text;
            if (stu.OnlyLettersAndSpace(txtBox_stuFName.Text))
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
            if (stu.OnlyLettersAndSpace(txtBox_stuLName.Text))
            {
                ErPr_LName.SetError(txtBox_stuLName, "");
            }
            else
            {
                MessageBox.Show("Name can't contain digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErPr_LName.SetError(txtBox_stuLName, "Name can't contain digits");
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
            }
            else if (verify())
            {
                picBox_stuPic.BackgroundImage.Save(pic, picBox_stuPic.BackgroundImage.RawFormat);

                if (stu.AddStudent(stuId, fname, lname, bdate, gender, pnumber, addr, pic))
                {
                    MessageBox.Show("Added successfully!", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public bool verify()
        {
            if (txtBox_stuFName.Text.Trim() == "" || txtBox_stuLName.Text.Trim() == "" || txtBox_stuPNumber.Text.Trim() == "" || txtBox_stuAddress.Text.Trim() == "")
                return false;
            else
                return true;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBox_stuID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_UploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Select Image(*.png;*.jpg)|*png;*jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picBox_stuPic.BackgroundImage = Image.FromFile(ofd.FileName);
                picBox_stuPic.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
