using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WIPR170124.ServiceClasses;

namespace WIPR170124.CONTACT_GROUPs
{
    public partial class Con_AddFrm : Form
    {
        public Con_AddFrm()
        {
            InitializeComponent();
        }

        private void CG_AddFrm_Load(object sender, EventArgs e)
        {
            toolT_Avatar.SetToolTip(picB_Avatar, "Double click to choose a profile picture\nClick to remove the picture");
            picB_Avatar.BackgroundImage = Properties.Resources.profileIcon;
            picB_Avatar.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void picB_Avatar_Click(object sender, EventArgs e)
        {
            picB_Avatar.BackgroundImage = Properties.Resources.profileIcon;
        }

        private void picB_Avatar_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Select Image(*.png;*.jpg)|*png;*jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picB_Avatar.BackgroundImage = Image.FromFile(ofd.FileName);
                picB_Avatar.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        CONTACT contact = new CONTACT();
        GROUP group = new GROUP();
        private bool check()
        {
            bool _checked = true;

            //Contact ID
            if (txtB_ConID.Text.Length > 0 && contact.int_able(txtB_ConID.Text))
            {
                if (!contact.id_exist(Convert.ToInt32(txtB_ConID.Text)))
                {
                    erPr_ConID.Clear();
                }
                else
                {
                    erPr_ConID.SetError(txtB_ConID, "Id already exist");
                    _checked = false;
                }
            }
            else
            {
                erPr_ConID.SetError(txtB_ConID, "Field must contains only number 0-9");
                _checked = false;
            }

            // Firstname
            if (contact.name_valid(txtB_Fname.Text))
            {
                erPr_Fname.Clear();
            }
            else
            {
                erPr_Fname.SetError(txtB_Fname, "Field must contains spaces and letters a-z and A-Z");
                _checked = false;
            }

            //Lastname
            if (contact.name_valid(txtB_Lname.Text))
            {
                erPr_Lname.Clear();
            }
            else
            {
                erPr_Lname.SetError(txtB_Lname, "Field must contains spaces and letters a-z and A-Z");
                _checked = false;
            }

            //Group
            if (txtB_Group.Text.Length > 0 && group.int_able(txtB_Group.Text))
            {
                if (group.id_exist(Convert.ToInt32(txtB_Group.Text)))
                {
                    erPr_Group.Clear();
                }
                else
                {
                    erPr_Group.SetError(txtB_Group, "Id doesn't exist");
                    _checked = false;
                }
            }
            else
            {
                erPr_Group.SetError(txtB_Group, "Field must not be empty");
                _checked = false;
            }

            //Phone
            if (txtB_Phone.Text.Length == 10 && contact.int_able(txtB_Phone.Text))
            {
                if (!contact.phone_exist(txtB_Phone.Text))
                {
                    erPr_Phone.Clear();
                }
                else
                {
                    erPr_Phone.SetError(txtB_Phone, "Phone already used");
                    _checked = false;
                }
            }
            else
            {
                erPr_Phone.SetError(txtB_Phone, "Field must contains 10 ditgits");
                _checked = false;
            }

            //Email
            if (txtB_Email.Text.Length > 0)
            {
                /*if (!contact.id_exist(Convert.ToInt32(txtB_ConID.Text)))
                {
                    erPr_ConID.Clear();
                }
                else
                {
                    erPr_ConID.SetError(txtB_ConID, "Id already exist");
                    _checked = false;
                }*/
            }
            else
            {
                erPr_Email.SetError(txtB_Email, "Field must not be empty");
                _checked = false;
            }

            return _checked;
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (check())
                {
                    MemoryStream pic = new MemoryStream();
                    if (picB_Avatar.BackgroundImage != null)
                    {
                        picB_Avatar.BackgroundImage.Save(pic, picB_Avatar.BackgroundImage.RawFormat);
                        if (contact.AddContact(Convert.ToInt32(txtB_ConID.Text), txtB_Fname.Text, txtB_Lname.Text, Convert.ToInt32(txtB_Group.Text), txtB_Phone.Text, txtB_Email.Text, rTB_Address.Text, pic))
                        {
                            MessageBox.Show("Added!", "Add a Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }

                MessageBox.Show("Add failed..", "Add a Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add a Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
