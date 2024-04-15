using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR170124
{
    public partial class StuListEditor : Form
    {
        STUDENT student = new STUDENT();

        public StuListEditor()
        {
            InitializeComponent();
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

        private void but_Update_Click(object sender, EventArgs e)
        {
            string stuId = txtBox_stuID.Text;
            if (!student.verifyID(stuId))
            {
                MessageBox.Show("This ID does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErPr_StuID.SetError(txtBox_stuID, "This ID does not exist!");
                return;
            }

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
            }
            else if (!(txtBox_stuFName.Text.Trim() == "" || txtBox_stuLName.Text.Trim() == "" || txtBox_stuPNumber.Text.Trim() == "" || txtBox_stuAddress.Text.Trim() == ""))
            {
                picBox_stuPic.BackgroundImage.Save(pic, picBox_stuPic.BackgroundImage.RawFormat);

                if (student.ModifyStudent(stuId, fname, lname, bdate, gender, pnumber, addr, pic))
                {
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

            student.RemoveStudent(txtBox_stuID.Text);
        }

        string oldID = "";
        private void StuListEditor_Load(object sender, EventArgs e)
        {
            oldID = txtBox_stuID.Text;  //TODO
        }
    }
}
