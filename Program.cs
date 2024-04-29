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

        internal static int _id = -1;
        internal static string _username = "";
        private static void log2()
        {
            Login2 loginFrm2 = new Login2();
            Application.Run(loginFrm2);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new StuPrintFrm());

            //Application.Run(new StuModifyInfo());

            MainForm mFrm = new MainForm();
            mFrm.setAdState = false;
            Application.Run(mFrm);

            //Application.Run(new CONTACTs_GRORPs.CG_MainFrm());

            //mail();

            //log();

            //log2();
        }
    }
}