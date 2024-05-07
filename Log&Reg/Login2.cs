using System;
using System.Windows.Forms;
using WIPR170124.CONTACTs_GRORPs;
using WIPR170124.ServiceClasses;

namespace WIPR170124.Log_Reg
{
    public partial class Login2 : Form
    {
        public Login2()
        {
            InitializeComponent();
        }

        private void Login2_Load(object sender, EventArgs e)
        {
            /*toolT_Type.SetToolTip(rBtn_Student, "Must choose one");
            toolT_Type.SetToolTip(rBtn_HR, "Must choose one");
            toolT_Type.SetToolTip(rBtn_Admin, "Must choose one");
            toolT_Type.SetToolTip(panel6, "Must choose one");*/
            rBtn_Admin.Enabled = false;
            rBtn_Admin.Visible = false;
            rBtn_HR.Enabled = false;
            rBtn_HR.Visible = false;
            rBtn_Student.Enabled = false;
            rBtn_Student.Visible = false;
        }

        private void pctBShowPass_Click(object sender, EventArgs e)
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

        private void lLbl_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            using (Register2 reg2 = new Register2())
            {
                if (reg2.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        USER user = new USER();
        private bool check()
        {
            try
            {
                bool ok = true;

                //Username
                if (txtB_Username.Text.Length <= 0)
                {
                    erPr_1.SetError(txtB_Username, "Field must not be empty");
                    ok = false;
                }
                else
                {
                    erPr_1.SetError(txtB_Username, "");
                }

                //Password
                if (txtB_Password.Text.Length <= 0)
                {
                    erPr_1.SetError(txtB_Password, "Field must not be empty");
                    ok = false;
                }
                else
                {
                    erPr_1.SetError(txtB_Password, "");
                }

                if (ok)
                {
                    if (user.username_exist(txtB_Username.Text))
                    {
                        if (user.password_correct(txtB_Username.Text, txtB_Password.Text))
                        {
                            /*if (!rBtn_Student.Checked && !rBtn_HR.Checked && !rBtn_Admin.Checked)
                            {
                                rBtn_Student.ForeColor = Color.Red;
                                rBtn_HR.ForeColor = Color.Red;
                                rBtn_Admin.ForeColor = Color.Red;
                            }
                            else
                            {
                                string _checked = "user";
                                if (rBtn_Admin.Checked)
                                {
                                    _checked = "admin";
                                }
                                else if (rBtn_Student.Checked)
                                {
                                    _checked = "student";
                                }

                                if (user.is_type(txtB_Username.Text, _checked))
                                {
                                    Program._username = txtB_Username.Text;
                                    return true;
                                }
                            }*/

                            Program._username = txtB_Username.Text;
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void bttn_Login_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string id = user.get_id(Program._username);
                if (id.Length <= 0)
                {
                    MessageBox.Show("Unable to obtains your account info..", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Program._id = Convert.ToInt32(id);
                }

                int status = user.is_active(txtB_Username.Text);
                if (status == 0)
                {
                    txtB_Password.Clear();
                    MessageBox.Show("Your account hasn't been approved yet, please try again later!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (status == -1)
                {
                    txtB_Username.Clear();
                    txtB_Password.Clear();
                    MessageBox.Show("Sorry, but your account wasn't approved.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (status == -2)
                {
                    txtB_Username.Clear();
                    txtB_Password.Clear();
                    MessageBox.Show("Your account has been disabled..", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Hide();

                /*if (rBtn_HR.Checked)
                {
                    CG_MainFrm cgMFrm = new CG_MainFrm();
                    cgMFrm.ShowDialog();
                }
                else
                {
                    MainForm mainFrm = new MainForm();

                    if (rBtn_Student.Checked)
                    {
                        mainFrm.setAdState = false;
                    }
                    else if (rBtn_Admin.Checked)
                    {
                        mainFrm.setAdState = true;
                    }

                    mainFrm.ShowDialog();
                }*/

                string type = user.get_type(Program._id);
                if ("user".Contains(type))
                {
                    CG_MainFrm cgMFrm = new CG_MainFrm();
                    cgMFrm.ShowDialog();
                }
                else
                {
                    MainForm mainFrm = new MainForm();

                    if ("student".Contains(type))
                    {
                        mainFrm.setAdState = false;
                    }
                    else if ("admin".Contains(type))
                    {
                        mainFrm.setAdState = true;
                    }

                    mainFrm.ShowDialog();
                }

                this.Close();
            }

            txtB_Password.Clear();
            MessageBox.Show("Wrong username or password, try again or register instead.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}



/* TODO:
 * check()
 * login() - classify acount type (handling)
 * 
 * 
 */