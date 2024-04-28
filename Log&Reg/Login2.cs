using System;
using System.Drawing;
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
            toolT_Type.SetToolTip(rBtn_Student, "Must choose one");
            toolT_Type.SetToolTip(rBtn_HR, "Must choose one");
            toolT_Type.SetToolTip(rBtn_Admin, "Must choose one");
            toolT_Type.SetToolTip(panel6, "Must choose one");
            //rBtn_Admin.Enabled = false;
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
                //Username
                if (user.username_exist(txtB_Username.Text))
                {
                    //Password
                    if (user.password_correct(txtB_Username.Text, txtB_Password.Text))
                    {
                        if (!rBtn_Student.Checked && !rBtn_HR.Checked && !rBtn_Admin.Checked)
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
                Program._id = Convert.ToInt32(user.getID(Program._username));

                this.Hide();

                if (rBtn_HR.Checked)
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