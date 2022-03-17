using System.Collections.Generic;

namespace ExamFunc
{
    class CompleteOrder
    {
        public static void FinishOrder(Order NewOrder)
        {
            var client = DinerInvoice.MakeInvoice(NewOrder);
            var diner = ClientInvoice.MakeInvoice(NewOrder);
            FileWriter.WriteToFile(client);
            List<IMailer> MailList = new List<IMailer>() { new DinerMail(), new ClientMail() };
            MailList.ForEach(x => x.SendMail(diner, client));
        }
    }
}
