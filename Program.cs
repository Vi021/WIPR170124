using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*********************
 *
 ********************/

namespace WIPR170124
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MailLogin mailLogin = new MailLogin();
            //Application.Run(mailLogin);

            //Application.Run(new PrinterFrm());

            //Application.Run(new StudentListFrm());

            MainForm mFrm = new MainForm();
            mFrm.setAdState = true;
            Application.Run(mFrm);

            //Login loginFrm = new Login();
            //Application.Run(loginFrm);

            if (mailLogin.DialogResult == DialogResult.OK)
            {
                MainForm mainFrm = new MainForm();

                if (mailLogin.getAdState)
                {
                    mainFrm.setAdState = true;
                }
                else
                {
                    mainFrm.email = mailLogin.email;
                }

                mainFrm.ShowDialog();

                /*
                if (loginFrm.RegisterState)
                {
                    Register regisFrm = new Register();
                    Application.Run(regisFrm);
                    
                    if (regisFrm.DialogResult == DialogResult.OK)
                    {
                        //TODO
                    }
                    
                    Login loginFrm2 = new Login();
                    Application.Run(loginFrm2);

                    loginFrm.MainState = loginFrm2.MainState;

                }

                if(loginFrm.MainState)
                {
                    MainForm mainFrm = new MainForm();
                    Application.Run(mainFrm);
                }

                if (mainFrm.DialogResult == DialogResult.OK)
                {
                    AddStudent addStuFrm = new AddStudent();
                    Application.Run(addStuFrm);
                }
                else
                {
                    Application.Exit();
                }
                */
            }
            else
            {
                Application.Exit();
            }
        }
    }
}