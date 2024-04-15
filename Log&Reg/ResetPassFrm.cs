using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WIPR170124
{
    public partial class ResetPassFrm : Form
    {
        public ResetPassFrm()
        {
            InitializeComponent();
        }

        OTPServices OTPs = new OTPServices();
        string otp = "";
        private void ResetPassFrm_Load(object sender, EventArgs e)
        {
            if (OTPs.Mailable(txtB_Email.Text))
            {
                    bttn_GetOTP.Enabled = true;
            }
            else
            {
                bttn_GetOTP.Enabled = false;
            }
            txtB_Password.Enabled = false;
            txtB_RetypePass.Enabled = false;
            bttn_Done.Enabled = false;
        }

        private void txtB_Email_TextChanged(object sender, EventArgs e)
        {
            if (OTPs.Mailable(txtB_Email.Text))
            {
                bttn_GetOTP.Enabled = true;
            }
            else
            {
                bttn_GetOTP.Enabled = false;
            }
        }

        MyDB myDB = new MyDB();

        private bool UserExists(string mail)
        {
            try
            {
                using (SqlConnection conn = myDB.Connection)
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM MailAccounts WHERE Email = @email";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@email", mail);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void bttn_GetOTP_Click(object sender, EventArgs e)
        {
            if (UserExists(txtB_Email.Text))
            {
                otp = OTPs.GenerateOTP();
                lbl_OTPInfo.Text = "Sending OTP..";
                if (OTPs.MailOTP(txtB_Email.Text, otp))
                {
                    lbl_OTPInfo.Text = "OTP has been sent!";
                    txtB_OTP.Focus();
                }
                else
                {
                    lbl_OTPInfo.Text = "Falied sending OTP.";
                }
            }
            else
            {
                MessageBox.Show("Unable to find your account, please sign up instead!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bttn_GetOTP.Enabled = false;
            }
        }

        private void txtB_OTP_TextChanged(object sender, EventArgs e)
        {
            if (txtB_OTP.Text.Length == 7)
            {
                if (OTPs.CheckOTP(otp, txtB_OTP.Text))
                {
                    lbl_OTPInfo.Text = "OTP comfirmed, please proceed!";
                    txtB_Password.Enabled = true;
                }
                else
                {
                    lbl_OTPInfo.Text = "OTP denied, please try again!";
                    txtB_Password.Enabled = false;
                }
            }
        }

        private bool validPass(string pass)
        {
            //7+ characters, inlcudes 0-9, a-z, A-Z, @, #, &, %
            string pattern = @"^(?=.*[0-9])(?=.*[a-zA-Z])[#@%$&\w].{6,}$";
            return Regex.IsMatch(pass, pattern);
        }

        private void picB_ShowPass_Click(object sender, EventArgs e)
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

        private void picB_ShowPass2_Click(object sender, EventArgs e)
        {
            if (txtB_RetypePass.PasswordChar == '\0')
            {
                picB_ShowPass2.BackgroundImage = Properties.Resources.openEyeIcon;
                txtB_RetypePass.PasswordChar = '*';
            }
            else
            {
                picB_ShowPass2.BackgroundImage = Properties.Resources.closedEyeIcon;
                txtB_RetypePass.PasswordChar = '\0';
            }
        }

        private void txtB_Password_TextChanged(object sender, EventArgs e)
        {
            if (validPass(txtB_Password.Text))
            {
                txtB_RetypePass.Enabled = true;
            }
            else
            {
                txtB_RetypePass.Enabled = false;
            }
        }

        private void txtB_RetypePass_TextChanged(object sender, EventArgs e)
        {
            if (txtB_RetypePass.Text.Contains(txtB_Password.Text))
            {
                bttn_Done.Enabled = true;
                erPr_Pass.Clear();
            }
            else
            {
                bttn_Done.Enabled = false;
                erPr_Pass.SetError(txtB_RetypePass, "Retyped password is unidentical");
            }
        }

        private void bttn_Done_Click(object sender, EventArgs e)
        {
            string email = txtB_Email.Text.Trim();
            string pass = txtB_RetypePass.Text.Trim();

            string updateStr = "UPDATE MailAccounts SET Password = @pass WHERE Email = @email";
            try
            {
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(updateStr, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@pass", new PassHasher().HashPassword(pass));

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Updated password, try logging in now!", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Update password failed, please try again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception exc) { MessageBox.Show("Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bttn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
