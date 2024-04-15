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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WIPR170124
{
    public partial class MailRegis : Form
    {
        public MailRegis()
        {
            InitializeComponent();
        }

        private void MailRegis_Load(object sender, EventArgs e)
        {
            bttn_GetOTP.Enabled = false;
            txtB_Password.Enabled = false;
            txtB_RetypePass.Enabled = false;
            bttn_Register.Enabled = false;
        }

        readonly OTPServices OTPs = new OTPServices();
        //pass: ssq1trypwa
        private string otp = null;
        private void txtB_Email_TextChanged(object sender, EventArgs e)
        {
            if (OTPs.Mailable(txtB_Email.Text))
            {
                //bttn_GetOTP.Enabled = !string.IsNullOrWhiteSpace(txtB_Email.Text);
                bttn_GetOTP.Enabled = true;
            }
            else
            {
                bttn_GetOTP.Enabled = false;
            }
        }

        private void bttn_GetOTP_Click(object sender, EventArgs e)
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

        private void txtB_OTP_TextChanged(object sender, EventArgs e)
        {
            if(txtB_OTP.Text.Length == 7)
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
                bttn_Register.Enabled = true;
                erPr_Pass.Clear();
            }
            else
            {
                bttn_Register.Enabled = false;
                erPr_Pass.SetError(txtB_RetypePass, "Retyped password is unidentical");
            }
        }

        private void bttn_Register_Click(object sender, EventArgs e)
        {
            //pass: st12345 - 22110459@student...
            string email = txtB_Email.Text.Trim();
            string pass = txtB_RetypePass.Text.Trim();

            /*string checkEmail = "SELECT COUNT(*) FROM Admins WHERE Email = @email";
            string addAdmin = "INSERT INTO Admins(Email, Password) VALUES (@email, @pass)";

            try
            {
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();

                    using (SqlCommand checkCmd = new SqlCommand(checkEmail, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@email", email);

                        if((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("This email is already in use, please log in instead!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            erPr_Email.SetError(txtB_Email, "Email is already in use");
                        }
                        else
                        {
                            erPr_Email.Clear();
                            
                            using (SqlCommand addCmd = new SqlCommand(addAdmin, conn))
                            {
                                addCmd.Parameters.AddWithValue("@email", email);
                                addCmd.Parameters.AddWithValue("@pass", (new PassHasher()).HashPassword(pass));

                                if (addCmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Registered! Try logging in now.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Failed adding you in..", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception exc) { MessageBox.Show("Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }*/

            string checkEmail = "SELECT COUNT(*) FROM MailAccounts WHERE Email = @email";
            string addUser = "INSERT INTO MailAccounts(Email, Password, Request) VALUES (@email, @pass, 1)";

            try
            {
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();

                    using (SqlCommand checkCmd = new SqlCommand(checkEmail, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@email", email);

                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("This email is already in use, please log in instead!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            erPr_Email.SetError(txtB_Email, "Email is already in use");
                        }
                        else
                        {
                            erPr_Email.Clear();

                            using (SqlCommand addCmd = new SqlCommand(addUser, conn))
                            {
                                addCmd.Parameters.AddWithValue("@email", email);
                                addCmd.Parameters.AddWithValue("@pass", (new PassHasher()).HashPassword(pass));

                                if (addCmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Registered! Waiting for approval..", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Failed adding you in..", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
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
