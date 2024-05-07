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

namespace WIPR170124.ServiceForms
{
    public partial class ModifyUsers : Form
    {
        public ModifyUsers()
        {
            InitializeComponent();
        }

        private bool started_check = false;
        private bool loaded = false;
        internal string _id = "";
        internal bool req = false;
        private void ModifyUsers_Load(object sender, EventArgs e)
        {
            started_check = chkB_ActYes.Checked;
            
            if (req)
            {
                bttn_Deny.Enabled = true;
            }
            else
            {
                bttn_Deny.Enabled = false;
            }
            
            loaded = true;
        }

        private void chkB_ActYes_CheckedChanged(object sender, EventArgs e)
        {
            if (!loaded) return;

            if (started_check == chkB_ActYes.Checked)
            {
                lbl_Status.Text = "No changes yet";
            }
            else
            {
                lbl_Status.Text = "Changed \"Active\" to " + chkB_ActYes.Checked.ToString();
            }
        }

        private async void bttn_Update_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                if (started_check != chkB_ActYes.Checked)
                {
                    using(SqlConnection conn = new MyDB().Connection)
                    {
                        conn.Open();
                        string update = $"UPDATE users SET active = @value, request = 0 WHERE ID = {_id}";
                        using (SqlCommand cmd = new SqlCommand(update, conn))
                        {
                            cmd.Parameters.AddWithValue("@value", chkB_ActYes.Checked);

                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Updated!", "Sys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Unable to make an update..", "Sys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No changes made!", "Sys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bttn_Deny_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();
                    string update = $"UPDATE users SET active = 0, request = 0 WHERE ID = {_id}";
                    using (SqlCommand cmd = new SqlCommand(update, conn))
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Done!", "Sys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Unable to make an update..", "Sys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
