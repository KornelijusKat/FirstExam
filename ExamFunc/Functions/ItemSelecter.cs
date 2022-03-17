using System;
using System.Collections.Generic;

namespace ExamFunc
{
    public class ItemSelecter
    {
        public static T SelectItem<T>(List<T> Listas)
        {
            try
            {
                var Selected = Listas[Convert.ToInt32(Console.ReadLine().IntValidation())];
                return Selected;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Your selection was out of range of the list,returning to selection menu");
                return default(T);
            }
        }
    }
}
