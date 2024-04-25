using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WIPR170124.CONTACT_GROUPs;

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
                    using(SqlConnection conn = new MyDB().Connection)
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
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CG_MainFrm_Load(object sender, EventArgs e)
        {
            innit_pfp(Program._id);
            lbl_Username.Text = "Welcome, " + Program._username + "!";
        }

        private void lbl_Refresh_Click(object sender, EventArgs e)
        {
            //
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
            if (txtB_CAID.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show($"Do you want to delete this Contact: {txtB_CAID.Text}", "Remove", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Removed", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            MessageBox.Show("Edited", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bttn_GRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Removed", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
