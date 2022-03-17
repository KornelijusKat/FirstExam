using System;

namespace ExamFunc
{
    class ClientMail : IMailer
    {
        public void SendMail(string clientInvoice,string dinerInvoice)
        {
            Console.Write("Send email to Client?Press y/n");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                MailingService.MailFunction(clientInvoice,Console.ReadLine().EmailFormatValidation());
            }
            else if (input == "n")
            {
                Console.WriteLine("Email not sent to client");
            }
            else
            {
                Console.WriteLine("Try again");
                SendMail(clientInvoice,dinerInvoice);
            }
        }
    }
}
