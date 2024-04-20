using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
        }

        private void picB_PFP_Click(object sender, EventArgs e)
        {
            picB_PFP.BackgroundImage = null;
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

        private bool int_able(string str)
        {
            string pattern = @"^-?\d+$";
            return Regex.IsMatch(str, pattern);
        }
        private bool id_able(string id)
        {
            //
            return false;
        }
        private bool name_valid(string str)
        {
            string pattern = @"^[\p{L} ]+$";
            return Regex.IsMatch(str, pattern);
        }
        private bool username_exist(string str)
        {
            //
            return false;
        }

        private bool check()
        {
            bool accepted = true;

            //ID
            if (int_able(txtB_ID.Text))
            {
                if (id_able(txtB_ID.Text))
                {

                }
                else
                {
                    accepted = false;
                }
            }
            else
            {

                accepted = false;
            }

            //Firstname
            if (name_valid(txtB_Fname.Text))
            {

            }
            else
            {
                accepted = false;
            }

            //Lastname
            if (name_valid(txtB_Lname.Text))
            {

            }
            else
            {
                accepted = false;
            }

            //Username
            if (username_exist(txtB_Username.Text))
            {

            }
            else
            {
                accepted = false;
            }

            return true;
        }

        private void bttn_Register_Click(object sender, EventArgs e)
        {
            if (check())
            {

            }
        }

        private void bttn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
