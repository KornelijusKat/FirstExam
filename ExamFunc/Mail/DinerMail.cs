
namespace ExamFunc
{
    class DinerMail :IMailer
    {
        public void SendMail(string clientInvoice,string dinerInvoice)
        {
            var CompanyEmail = "katinaskornelijus@gmail.com";
            MailingService.MailFunction(dinerInvoice,CompanyEmail);
        }
    }
}
