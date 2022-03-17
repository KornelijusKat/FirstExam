using System;
using System.Text.RegularExpressions;

namespace ExamFunc
{
    public static class Validations
    {  
        public static int IntValidation(this string input)
        {
            int newInput;
            while(!int.TryParse(input, out newInput))
            {
                Console.WriteLine("Input is not an integer number, please repeat input");
                input = Console.ReadLine();
            }
                return newInput;
        }
        public static Table TableVacancyValidation(this Table obj)
        {  
            if(obj == null)
            {
                return null;
            }
           else if(obj.IsVacant == false)
            {
                Console.WriteLine("Table is taken");
                return null;
            }
            return obj;
        }    
        public static string EmailFormatValidation(this string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (!match.Success)
            {
                Console.WriteLine("Incorrect email format, re enter email");           
                email = Console.ReadLine().EmailFormatValidation();
            }
            return email;               
        }
    }
}
