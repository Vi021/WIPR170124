using System;
using System.Windows.Forms;
using WIPR170124.Log_Reg;

/*********************
 *
 ********************/

namespace WIPR170124
{
    internal static class Program
    {
        private static void mail()
        {
            MailLogin mailLogin = new MailLogin();
            Application.Run(mailLogin);

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


            }
            else
            {
                Application.Exit();
            }
        }

        private static void log()
        {
            Login loginFrm = new Login();
            Application.Run(loginFrm);

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

            if (loginFrm.MainState)
            {
                MainForm mainFrm = new MainForm();
                Application.Run(mainFrm);
            }
        }

        private static void log2()
        {
            Login2 loginFrm2 = new Login2();
            Application.Run(loginFrm2);

            /*if (loginFrm.RegisterState)
            {
                Register2 regisFrm2 = new Register2();
                Application.Run(regisFrm2);

                if (regisFrm2.DialogResult == DialogResult.OK)
                {
                    //TODO
                }

                Login loginFrm2 = new Login();
                Application.Run(loginFrm2);

                loginFrm.MainState = loginFrm2.MainState;

            }

            if (loginFrm.MainState)
            {
                MainForm mainFrm = new MainForm();
                Application.Run(mainFrm);
            }*/
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new PrinterFrm());

            //Application.Run(new StudentListFrm());

            /*MainForm mFrm = new MainForm();
            mFrm.setAdState = true;
            Application.Run(mFrm);*/

            //mail();
            
            //log();

            log2();
        }
    }
}