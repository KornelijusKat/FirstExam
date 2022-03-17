using System;

namespace ExamFunc
{
    class ClientInvoice
    { 
        public static string MakeInvoice(Order myobj)
        {
           string clientInvoice = $"Your Order:\n{string.Join(Environment.NewLine,myobj.GoodsList)}\nTotal price: {myobj.CalculateOrderSum()} Euro\n{DateTime.Now}";
           return clientInvoice;    
        }
    }
}
