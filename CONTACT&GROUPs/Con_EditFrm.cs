using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WIPR170124.ServiceClasses;

namespace WIPR170124.CONTACT_GROUPs
{
    public partial class Con_EditFrm : Form
    {
        public Con_EditFrm()
        {
            InitializeComponent();
        }

        CONTACT contact = new CONTACT();
        private void Con_EditFrm_Load(object sender, EventArgs e)
        {
            toolT_Avatar.SetToolTip(picB_Avatar, "Double click to choose a profile picture\nClick to remove the picture");
            picB_Avatar.BackgroundImage = Properties.Resources.profileIcon;
            picB_Avatar.BackgroundImageLayout = ImageLayout.Zoom;

            if (txtB_ConID.Text.Length > 0)
                this.bttn_Pick_Click(sender, e);
        }

        private Image ByteArrayToImage(byte[] bytes)            // can cause "A generic error occurred in GDI+" when "picB_Avatar.BackgroundImage.Save(pic, picB_Avatar.BackgroundImage.RawFormat);" ?? - cus of "It appears that the memory stream that the object was created on has to be open at the time the object is saved" ??
        {
            if (bytes != null)
            {
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
            return null;
        }

        private void bttn_Pick_Click(object sender, EventArgs e)
        {
            if (txtB_ConID.Text.Length > 0 && contact.int_able(txtB_ConID.Text))
            {
                if (contact.id_exist(Convert.ToInt32(txtB_ConID.Text)))
                {
                    erPr_ConID.Clear();
                    int id = Convert.ToInt32(txtB_ConID.Text);
                    DataTable dt = contact.GetAContact(id);

                    if (dt.Columns.Count > 0 && dt.Rows.Count > 0)
                    {
                        txtB_ConID.Text = dt.Rows[0]["ConID"].ToString().Trim();
                        txtB_Fname.Text = dt.Rows[0]["Fname"].ToString().Trim();
                        txtB_Lname.Text = dt.Rows[0]["Lname"].ToString().Trim();
                        txtB_Group.Text = dt.Rows[0]["GID"].ToString().Trim();
                        txtB_Phone.Text = dt.Rows[0]["Phone"].ToString().Trim();
                        txtB_Email.Text = dt.Rows[0]["Email"].ToString().Trim();
                        rTB_Addr.Text = dt.Rows[0]["Address"].ToString().Trim();

                        byte[] imageBytes = dt.Rows[0]["pfp"] as byte[];
                        if (imageBytes != null)
                        {
                            picB_Avatar.BackgroundImage = null;
                            MemoryStream ms = new MemoryStream(imageBytes);
                            Image image = Image.FromStream(ms);
                            picB_Avatar.BackgroundImage = image;
                            picB_Avatar.BackgroundImageLayout = ImageLayout.Zoom;
                        }
                        else
                        {
                            this.picB_Avatar_Click(sender, e);
                        }
                    }
                }
                else
                {
                    erPr_ConID.SetError(txtB_ConID, "ID doesn't exist");
                }
            }
            else
            {
                erPr_ConID.SetError(txtB_ConID, "Field must contains only number 0-9");
            }
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

        GROUP group = new GROUP();
        private bool check()
        {
            bool _checked = true;

            //Contact ID
            if (txtB_ConID.Text.Length > 0 && contact.int_able(txtB_ConID.Text))
            {
                if (contact.id_exist(Convert.ToInt32(txtB_ConID.Text)))
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
                    erPr_Group.SetError(txtB_Group, "Id don't exist");
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
                if (contact.phone_exist(txtB_Phone.Text))
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
            if (txtB_Email.Text.Length >= 0)
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

        private void bttn_Edit_Click(object sender, EventArgs e)
        {
            if (check())
            {
                MemoryStream pic = new MemoryStream();
                if (picB_Avatar.BackgroundImage != null)
                {
                    picB_Avatar.BackgroundImage.Save(pic, picB_Avatar.BackgroundImage.RawFormat);
                    if (contact.EditContact(Convert.ToInt32(txtB_ConID.Text), txtB_Fname.Text, txtB_Lname.Text, Convert.ToInt32(txtB_Group.Text), txtB_Phone.Text, txtB_Email.Text, rTB_Addr.Text, pic))
                    {
                        MessageBox.Show("Edited!", "Edit a Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }

            MessageBox.Show("Edit failed..", "Edit a Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
