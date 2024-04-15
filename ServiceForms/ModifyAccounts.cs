using System;
using System.Data.SqlClient;
using System.Net.Cache;
using System.Windows.Forms;

namespace WIPR170124
{
    public partial class ModifyAccounts : Form
    {
        public ModifyAccounts()
        {
            InitializeComponent();
        }

        private string _email = "";

        public string email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        private void ModifyAccounts_Load(object sender, EventArgs e)
        {

        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            DialogResult result = result = MessageBox.Show("Are you certain about these change?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                string updateStr = "UPDATE MailAccounts SET Active = @act, Admin = @adm, Request = 0 WHERE Email = @ema";
                MyDB myDB = new MyDB();
                ACCOUNT acc = new ACCOUNT();

                using (SqlConnection conn = myDB.Connection)
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(updateStr, conn);

                    cmd.Parameters.AddWithValue("@ema", email);
                    cmd.Parameters.AddWithValue("@act", chkB_ActYes.Checked);
                    cmd.Parameters.AddWithValue("@adm", chkB_AdmYes.Checked);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        lbl_Status.Text = "Updated!";
                    }
                    else
                    {
                        lbl_Status.Text = "Failed..";
                    }
                }
            }
        }
    }
}
