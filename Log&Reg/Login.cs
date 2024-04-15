using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WIPR170124
{
    public partial class Login : Form
    {
        MyDB myDB = new MyDB();
        //private bool regiState = false;
        //private bool mainState = false;

        /*public bool RegisterState
        {
            get {return regiState;} 
            set {regiState = value;}
        }

        public bool MainState
        {
            get {return mainState;}
            set {mainState = value;}
        }*/

        public Login()
        {
            InitializeComponent();
        }

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (SqlConnection conn = myDB.Connection)
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM AccInfo WHERE Username = @username AND Password = @password";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", (new PassHasher(password)).getHashedPass());

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show("Error: " + msg.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            string username = txtBox_Username.Text;
            string password = txtBox_Password.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!", "Logging in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MainState = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErPr_1.SetError(templbl, "Username or Password is incorrect");
                txtBox_Password.Text = "";
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //regiState = true;
            //this.DialogResult = DialogResult.OK;
            //this.Close();
            
            Register regisFrm = new Register();
            regisFrm.ShowDialog();
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

        private void txtBox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(txtBox_Username.Text == "")
                {
                    MessageBox.Show("Username can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = false;
                }
                else
                {
                    txtBox_Password.Focus();
                }
            }/*
            else if (e.KeyChar == (char)Keys.Down)
            {
                txtBox_Password.Focus();
            }*/
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
                    Button_Login.PerformClick();
                    e.Handled = true;
                }
            }/*
            else if (e.KeyChar == (char)Keys.Up)
            {
                txtBox_Username.Focus();
            }
            else if(e.KeyChar == (char)Keys.Down)
            {
                Button_Login.Focus();
            }*/
        }
    }
}