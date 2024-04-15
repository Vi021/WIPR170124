using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WIPR170124
{
    public partial class Register : Form
    {
        MyDB myDB = new MyDB();

        public Register()
        {
            InitializeComponent();
        }

        private void pctBShowPass_Click(object sender, EventArgs e)
        {
            if (txtBox_Password.PasswordChar == '\0')
            {
                pctBShowPass.BackgroundImage = Properties.Resources.openEyeIcon;
                txtBox_Password.PasswordChar = '*';
            }
            else
            {
                pctBShowPass.BackgroundImage = Properties.Resources.closedEyeIcon;
                txtBox_Password.PasswordChar = '\0';
            }
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            if (txtBox_Username.Text == "")
            {
                MessageBox.Show("Username can't be blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBox_Password.Text == "")
            {
                MessageBox.Show("Password can't be blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = txtBox_Username.Text;
                string pass = txtBox_Password.Text;
                string checkUsername = "SELECT COUNT(*) FROM AccInfo WHERE Username = @Username";
                string addAccInfo = "INSERT INTO AccInfo (Username, Password) VALUES (@username, @pass)";

                SqlConnection conn = myDB.Connection;
                conn.Open();

                try
                {
                    using (SqlCommand checkCmd = new SqlCommand(checkUsername, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);

                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Your username is already taken, please try a different one!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ErPr_Username.SetError(txtBox_Username, "Username already exits");
                        }
                        else
                        {
                            using (SqlCommand addCmd = new SqlCommand(addAccInfo, conn))
                            {
                                addCmd.Parameters.AddWithValue("@username", username);
                                addCmd.Parameters.AddWithValue("@pass", (new PassHasher(pass)).getHashedPass());

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
                catch (Exception exc)
                {
                    MessageBox.Show("Error! " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtBox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtBox_Username.Text == "")
                {
                    MessageBox.Show("Username can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = false;
                }
                else
                {
                    txtBox_Password.Focus();
                }
            }
        }

        private void txtBox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtBox_Password.Text == "")
                {
                    MessageBox.Show("Password can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = false;
                }
                else
                {
                    Button_Register.PerformClick();
                    e.Handled = true;
                }
            }
        }
    }
}
