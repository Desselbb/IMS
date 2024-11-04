using Microsoft.EntityFrameworkCore;
using IMSClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using IMSClassLibrary.Interfaces;

namespace IMSClassLibrary.repos
{
    public class EmailRepository
    {
       
        public EmailRepository()
        {

        }

        public bool sendMail(string Email, string Subject, string Message) {
            try
            {

                var fromAddress = new MailAddress("procurearc@gmail.com", "STAFF TRAVEL");
                var fromPassword = "mepgqfedavkzdxyk";

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

                };
                var toAddress = new MailAddress(Email);
                string body = Message;
                using (var msg = new MailMessage(fromAddress, toAddress)
                {
                    Subject = Subject,
                    Body = body
                })
                smtp.Send(msg);
                return true;
            }
            catch (Exception d)
            {
                Console.WriteLine(d.Message + "\n" + d.StackTrace);
                return false;
            }
        }
    }
}
