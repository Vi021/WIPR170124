using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIPR170124.ServiceClasses;

namespace WIPR170124.CONTACT_GROUPs
{
    public partial class Con_ListFrm : Form
    {
        public Con_ListFrm()
        {
            InitializeComponent();
        }

        GROUP group = new GROUP();
        private void fillComboBox()
        {
            try
            {
                using(SqlConnection conn = new MyDB().Connection)
                {
                    string getStr = "SELECT ID, GName FROM Groups";
                    using (SqlCommand cmd = new SqlCommand(getStr, conn))
                    {
                        DataTable dt = group.GetGroups(cmd);

                        if (dt.Columns.Count > 0 && dt.Rows.Count > 0)
                        {
                            comB_Group.DataSource = dt;
                            comB_Group.DisplayMember = "GName";
                            comB_Group.ValueMember = "ID";
                            comB_Group.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Your List of Contacts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool loaded = false;
        private void Con_ListFrm_Load(object sender, EventArgs e)
        {
            comB_Group.DropDownStyle = ComboBoxStyle.DropDownList;
            dGV_Contacts.RowTemplate.Height = 80;
            fillComboBox();

            loaded = true;
            this.comB_Group_SelectedIndexChanged(sender, e);
        }

        CONTACT contact = new CONTACT();
        private void comB_Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                int id = Convert.ToInt32(comB_Group.SelectedValue.ToString().Trim());
                DataTable dt = contact.GetContactsFromGroup(id, Program._id);

                if (dt.Columns.Count > 0)
                {
                    dGV_Contacts.DataSource = dt;
                    dGV_Contacts.Columns.RemoveAt(8);
                    dGV_Contacts.Columns["ConID"].HeaderText = "Contact ID";
                    dGV_Contacts.Columns["Fname"].HeaderText = "Firstname";
                    dGV_Contacts.Columns["Lname"].HeaderText = "Lastname";
                    dGV_Contacts.Columns["GID"].HeaderText = "Group";
                    dGV_Contacts.Columns["pfp"].HeaderText = "PFP";

                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                    picCol = (DataGridViewImageColumn)dGV_Contacts.Columns["pfp"];
                    picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }
        }
    }
}
