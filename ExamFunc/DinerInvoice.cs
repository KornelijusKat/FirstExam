using System;
namespace ExamFunc
{
    class DinerInvoice
    {
        public static string MakeInvoice(Order myObj)
        {
            string dinerInvoice = Convert.ToString(myObj);
            return dinerInvoice;
        }
    }
}
