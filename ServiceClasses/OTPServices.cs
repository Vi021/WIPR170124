using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WIPR170124
{
    internal class OTPServices
    {
        private string sMail = "service.noreply1701@gmail.com";
        
        public OTPServices(string senderMail="")
        {
            if (!(senderMail == ""))
            {
                if (Mailable(senderMail))
                {
                    this.SenderMail = senderMail;
                }
                else
                {
                    throw new Exception("Invalid Email format.");                       //valid?
                }
            }
        }

        public string SenderMail
        {
            get { return this.sMail; }
            set { this.sMail = value; }
        }

        public bool Mailable(string mail)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";       //woah!!
            return Regex.IsMatch(mail, pattern);
        }

        public string GenerateOTP(bool text=false, bool special_character=false)
        {
            //7 characters otp ()

            if (text) { /*TODO*/ }
            if (special_character) { /*TODO*/ }

            string OTP = "";

            Random random = new Random();

            OTP = random.Next(1111111, 10000000).ToString();

            return OTP;
        }

        public bool CheckOTP(string otp, string recvOTP)
        {
            if (otp != null && recvOTP != null)
            {
                if (otp.Contains(recvOTP))
                    return true;
            }

            return false;
        }

        public bool MailOTP(string receiverMail, string otp)
        {
            //send via mail
            try
            {
                MailAddress senderAddr = new MailAddress(SenderMail);
                MailAddress receiverAddr = new MailAddress(receiverMail);

                const string senderPass = "oocxiqerypbaeezl";    //2 step verification for app "Mail"
                
                //mail contents
                const string subject = "OTP Code for WIPR170124";
                string body = "<html><body>" +
                              
                              "<p>Here is your OTP:</p>" +
                              "<p style=\"font-weight: bold; font-size: 18px;\">" + otp + "</p>" +
                              "<p style=\"color: red; font-weight: bold;\">&nbsp;</p>" + // Empty line for spacing
                              "<p style=\"color: red; font-weight: bold;\">DO NOT SHARE THIS CODE TO ANYBODY ELSE.</p>" +
                              "<p style=\"color: red; font-weight: bold;\">&nbsp;</p>" + // Empty line for spacing
                              
                              "</body></html>";

                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,         //smtp's port
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderAddr.Address, senderPass),
                    Timeout = 200000
                };

                using(MailMessage msg = new MailMessage(senderAddr, receiverAddr)
                    {
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = true
                    }
                )
                {
                    smtp.Send(msg);
                    return true;
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void PhoneOTP(string phonenumber)
        {
            //send via phonenumber
        }

    }
}