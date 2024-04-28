using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WIPR170124.CONTACT_GROUPs;
using WIPR170124.ServiceClasses;

namespace WIPR170124.CONTACTs_GRORPs
{
    public partial class CG_MainFrm : Form
    {
        public CG_MainFrm()
        {
            InitializeComponent();
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void innit_pfp(int id)
        {
            if (id >= 0)
            {
                try
                {
                    using (SqlConnection conn = new MyDB().Connection)
                    {
                        conn.Open();
                        string getStr = $"SELECT pfp FROM [users] WHERE ID = {id}";
                        using (SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                byte[] image = dt.Rows[0]["pfp"] as byte[];
                                picB_Avatar.BackgroundImage = ByteArrayToImage(image);
                                picB_Avatar.BackgroundImageLayout = ImageLayout.Zoom;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        GROUP group = new GROUP();
        private void CG_MainFrm_Load(object sender, EventArgs e)
        {
            innit_pfp(Program._id);
            lbl_Username.Text = "Welcome, " + Program._username + "!";

            using (SqlConnection conn = new MyDB().Connection)
            {
                string getStr = $"SELECT ID, GName FROM Groups WHERE UID = {Program._id}";
                using (SqlCommand cmd = new SqlCommand(getStr, conn))
                {
                    DataTable dt = group.GetGroups(cmd);
                    comB_GEName.DropDownStyle = ComboBoxStyle.DropDownList;
                    comB_GEName.DataSource = dt;
                    comB_GEName.DisplayMember = "GName";
                    comB_GEName.ValueMember = "ID";

                    comB_GRName.DropDownStyle = ComboBoxStyle.DropDownList;
                    comB_GRName.DataSource = dt;
                    comB_GRName.DisplayMember = "GName";
                    comB_GRName.ValueMember = "ID";
                }
            }
        }

        private void lbl_Refresh_Click(object sender, EventArgs e)
        {
            this.CG_MainFrm_Load(sender, e);
        }

        private void lbl_MyInfo_Click(object sender, EventArgs e)
        {
            //
        }

        private void bttn_CAdd_Click(object sender, EventArgs e)
        {
            Con_AddFrm cAFrm = new Con_AddFrm();
            cAFrm.txtB_ConID.Text = txtB_CAID.Text;
            cAFrm.ShowDialog();
        }

        private void bttn_CEdit_Click(object sender, EventArgs e)
        {
            Con_EditFrm cEFrm = new Con_EditFrm();
            cEFrm.txtB_ConID.Text = txtB_CAID.Text;
            cEFrm.ShowDialog();
        }

        private void bttn_CRemove_Click(object sender, EventArgs e)
        {
            CONTACT contact = new CONTACT();
            if (txtB_CAID.Text.Length > 0 && contact.int_able(txtB_CAID.Text))
            {
                int id = Convert.ToInt32(txtB_CAID.Text);
                if (contact.id_exist(id))
                {
                    erPr_AllPurpose.SetError(txtB_CAID, "");

                    DialogResult result = MessageBox.Show($"Do you want to delete this Contact: {txtB_CAID.Text}", "Remove", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        if (contact.RemoveContact(id))
                        {
                            MessageBox.Show($"Removed Contact: {txtB_CAID.Text}", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Remove failed..", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    erPr_AllPurpose.SetError(txtB_CAID, "ID doesn't exist");
                }
            }
            else
            {
                erPr_AllPurpose.SetError(txtB_CAID, "Field must contains a number >= 0");
            }
        }

        private void bttn_ShowList_Click(object sender, EventArgs e)
        {
            Con_ListFrm cLF = new Con_ListFrm();
            cLF.ShowDialog();
        }

        private void bttn_GAdd_Click(object sender, EventArgs e)
        {
            Gro_AddFrm gAFrm = new Gro_AddFrm();
            gAFrm.txtB_ID.Text = txtB_GAID.Text;
            gAFrm.ShowDialog();
        }

        private void bttn_GEdit_Click(object sender, EventArgs e)
        {
            if (comB_GEName.SelectedIndex != -1)
            {
                if (txtB_GEName.Text.Length > 0)
                {
                    erPr_AllPurpose.SetError(txtB_GEName, "");
                    if (group.EditGroup(Convert.ToInt32(comB_GEName.SelectedValue), txtB_GEName.Text, Program._id))
                    {
                        MessageBox.Show("Edited", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Edit failed", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    erPr_AllPurpose.SetError(txtB_GEName, "Field can't be empty");
                }
            }
            else
            {
                erPr_AllPurpose.SetError(comB_GEName, "Please select a group");
            }
        }

        private void bttn_GRemove_Click(object sender, EventArgs e)
        {
            if (comB_GRName.SelectedIndex != -1)
            {
                erPr_AllPurpose.SetError(txtB_GEName, "");
                if (group.RemoveGroup(Convert.ToInt32(comB_GEName.SelectedValue), Program._id))
                {
                    MessageBox.Show("Removed", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Remove failed", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                erPr_AllPurpose.SetError(comB_GEName, "Please select a group");
            }
        }
    }
}
