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

namespace WIPR170124
{
    public partial class MailLogin : Form
    {
        public MailLogin()
        {
            InitializeComponent();
        }

        private void MailLogin_Load(object sender, EventArgs e)
        {
            //Logo
            //TODO: Save email/account, to log in faster
            txtB_Password.Enabled = false;
            bttn_Login.Enabled = false;
        }

        OTPServices OTPs = new OTPServices();
        private void txtB_Email_TextChanged(object sender, EventArgs e)
        {
            if (OTPs.Mailable(txtB_Email.Text))
            {
                txtB_Password.Enabled = true;
            }
            else
            {
                txtB_Password.Enabled = false;
            }
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

        private void txtB_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtB_Email.Text == "")
                {
                    MessageBox.Show("Username can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = false;
                }
                else
                {
                    txtB_Password.Focus();
                }
            }
        }

        private void txtB_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtB_Password.Text == "")
                {
                    MessageBox.Show("Password can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = false;
                }
                else
                {
                    bttn_Login.PerformClick();
                    e.Handled = true;
                }
            }
        }

        private bool validPass(string pass)
        {
            //7+ characters, inlcudes 0-9, a-z, A-Z, @, #, &, %
            string pattern = @"^(?=.*[0-9])(?=.*[a-zA-Z])[#@%$&\w].{6,}$";
            return Regex.IsMatch(pass, pattern);
        }

        private void txtB_Password_TextChanged(object sender, EventArgs e)
        {
            if (validPass(txtB_Password.Text))
            {
                bttn_Login.Enabled = true;
            }
            else
            {
                bttn_Login.Enabled = false;
            }
        }

        private void lLbl_ForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassFrm resetPassFrm = new ResetPassFrm();
            if (!string.IsNullOrWhiteSpace(txtB_Email.Text))
            {
                resetPassFrm.txtB_Email.Text = txtB_Email.Text;
            }
            resetPassFrm.Show();
        }

        private void lLbl_Regis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MailRegis mailRegis = new MailRegis();
            mailRegis.Show();
        }

        MyDB myDB = new MyDB();
        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (SqlConnection conn = myDB.Connection)
                {
                    conn.Open();

                    string getPassStr = "SELECT Password FROM MailAccounts WHERE Email = @email and Active = 1";
                    using (SqlCommand cmd = new SqlCommand(getPassStr, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", username);
                        //command.Parameters.AddWithValue("@pass", (new PassHasher()).HashPassword(txtB_Password.Text));

                        var Pass = cmd.ExecuteScalar();
                        if (Pass == null)
                        {
                            return false;
                        }
                        else
                        {
                            return new PassHasher().VerifyPassword(txtB_Password.Text, Pass.ToString());
                        }
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show("Error: " + msg.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private (bool, bool, bool) AccountType(string email, string pass)
        {
            // return ex(ist), ac(tivate), ad(min)

            try
            {
                MyDB myDB = new MyDB();
                using (SqlConnection conn = myDB.Connection)
                {
                    conn.Open();

                    string getStr = "SELECT * FROM MailAccounts WHERE Email = @email";
                    using (SqlCommand cmd = new SqlCommand(getStr, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                var Pass = dt.Rows[0]["Password"];
                                if (Pass != null)
                                {
                                    if (new PassHasher().VerifyPassword(pass, Pass.ToString()))
                                    {
                                        if (dt.Rows[0]["Active"].ToString().Contains("True") && dt.Rows[0]["Admin"].ToString().Trim().Contains("True"))
                                        {
                                            return (true, true, true);      //is Admin
                                        }
                                        if (dt.Rows[0]["Active"].ToString().Contains("True") && dt.Rows[0]["Admin"].ToString().Contains("False"))
                                        {
                                            return (true, true, false);     //is user
                                        }
                                        if (dt.Rows[0]["Active"].ToString().Contains("False") && dt.Rows[0]["Admin"].ToString().Contains("True"))
                                        {
                                            return (true, false, true);
                                        }
                                    }
                                }
                            }

                            return (false, false, false);
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, false, false);
            }
        }

        private bool Admin = false;

        public bool getAdState
        {
            get { return Admin; }
        }

        private string _email = "";

        public string email
        {
            get { return this._email; }
        }

        private void bttn_Login_Click(object sender, EventArgs e)
        {
            string email = txtB_Email.Text;
            string pass = txtB_Password.Text;

            (bool ex, bool ac, bool ad) = AccountType(email, pass);

            if (ex == false)
            {
                MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB_Password.Text = "";
            }
            else
            {
                if (ac == true)
                {
                    MessageBox.Show("Login successful!", "Logging in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    if (ad == true)
                    {
                        Admin = true;
                    }
                    else
                    {
                        this._email = txtB_Email.Text;
                    }
                    this.Close();
                }
            }

            /*if (AuthenticateUser(email, pass))
            {
                MessageBox.Show("Login successful!", "Logging in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB_Password.Text = "";
            }*/
        }

        private void bttn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //temp
        private void lbl_QuickL_Click(object sender, EventArgs e)
        {
            txtB_Email.Text = "hellno83737@gmail.com";
            txtB_Password.Text = "vi12345";
        }
    }
}
