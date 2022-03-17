using System;
using System.Net;
using System.Net.Mail;

namespace ExamFunc
{
    class MailingService
    {
        public static void MailFunction(string theInvoice,string email)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.UseDefaultCredentials = false;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential { UserName = "insert Email", Password = "Insert Password" };
                smtpClient.EnableSsl = true;
                smtpClient.Send(from: "Insert email", email, "TheOrder", theInvoice);
            }
            catch (SmtpException e)
            {
                Console.WriteLine($"Email not sent, issue: {e}");            
            }
        }
    }
}
