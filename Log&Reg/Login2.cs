using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
        }

        private void lLbl_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register2 reg2 = new Register2();
            reg2.Show();
        }

        private void bttn_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
