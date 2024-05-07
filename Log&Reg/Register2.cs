using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WIPR170124.ServiceClasses;

namespace WIPR170124.Log_Reg
{
    public partial class Register2 : Form
    {
        public Register2()
        {
            InitializeComponent();
        }

        private void Register2_Load(object sender, EventArgs e)
        {
            toolT_PFP.SetToolTip(picB_PFP, "Double click to choose a profile picture\nClick to remove the picture");
            toolT_Type.SetToolTip(pnl_Type, "Choose a account type");

            picB_PFP.BackgroundImage = Properties.Resources.profileIcon;
            picB_PFP.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pctBShowPass_Click(object sender, EventArgs e)
        {
            if (txtB_Password.PasswordChar == '\0')
            {
                picB_ShowPass.BackgroundImage = Properties.Resources.openEyeIcon;
                txtB_Password.PasswordChar = '*';
            }
            else
            {
                picB_ShowPass.BackgroundImage = Properties.Resources.closedEyeIcon;
                txtB_Password.PasswordChar = '\0';
            }
        }

        private void picB_PFP_Click(object sender, EventArgs e)
        {
            picB_PFP.BackgroundImage = Properties.Resources.profileIcon;
        }

        private void picB_PFP_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Select Image(*.png;*.jpg)|*png;*jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picB_PFP.BackgroundImage = Image.FromFile(ofd.FileName);
                picB_PFP.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        USER user = new USER();
        private bool check()
        {
            bool accepted = true;

            //ID
            if (user.int_able(txtB_ID.Text) && Convert.ToInt32(txtB_ID.Text) >= 0)
            {
                if (!user.id_exist(Convert.ToInt32(txtB_ID.Text)))
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

            //Firstname
            if (user.name_valid(txtB_Fname.Text))
            {
                erPr_Fname.Clear();
            }
            else
            {
                erPr_Fname.SetError(txtB_Fname, "Field must contains spaces and letters a-z and A-Z");
                accepted = false;
            }

            //Lastname
            if (user.name_valid(txtB_Lname.Text))
            {
                erPr_Lname.Clear();
            }
            else
            {
                erPr_Lname.SetError(txtB_Lname, "Field must contains spaces and letters a-z and A-Z");
                accepted = false;
            }

            //Username
            if (txtB_Username.Text.Length > 0)
            {
                if (!user.username_exist(txtB_Username.Text))
                {
                    erPr_Username.Clear();
                }
                else
                {
                    erPr_Username.SetError(txtB_Username, "Username is in use, try another one");
                    accepted = false;
                }
            }
            else
            {
                erPr_Username.SetError(txtB_Username, "Username can't be empty");
                accepted = false;
            }

            //Password
            if (txtB_Password.Text.Length > 0)
            {
                erPr_Password.Clear();
            }
            else
            {
                erPr_Password.SetError(txtB_Password, "Field can't be empty");
                accepted = false;
            }

            //Account Type
            if (rBtn_Student.Checked == true || rBtn_HR.Checked == true)
            {
                pnl_Type.BackColor = Color.FromArgb(22, 130, 218);
                toolT_Type.SetToolTip(pnl_Type, "Please choose a account type");
                toolT_Type.ForeColor = Color.FromArgb(22, 130, 218);
            }
            else
            {
                pnl_Type.BackColor = Color.Red;
                toolT_Type.ForeColor = Color.Red;
                accepted = false;
            }

            return accepted;
        }

        private void bttn_Register_Click(object sender, EventArgs e)
        {
            if (check())
            {
                MemoryStream pic = new MemoryStream();
                if (picB_PFP.BackgroundImage != null)
                {
                    picB_PFP.BackgroundImage.Save(pic, picB_PFP.BackgroundImage.RawFormat);

                    string type = "user";
                    if (rBtn_Student.Checked)
                    {
                        type = "student";
                    }

                    if (user.AddUser(Convert.ToInt32(txtB_ID.Text), txtB_Fname.Text, txtB_Lname.Text, txtB_Username.Text, new PassHasher().HashPassword(txtB_Password.Text), pic, type))
                    {
                        MessageBox.Show("Registered! You can log in once your account is approved!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        return;
                    }
                }

                MessageBox.Show("Registry failed", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_Return_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}



/* TODO:
 *
 * register()
 */