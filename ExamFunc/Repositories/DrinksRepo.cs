using System;
using System.Collections.Generic;

namespace ExamFunc
{
    public class DrinksRepo
        {
        public List<Drinks> DrinkList { get; set; }
        public DrinksRepo()
        {
           DrinkList = new List<Drinks>();
        }
        public List<Drinks> GetList()
        {
            FileReaderService Read = new FileReaderService();
            var readLines = Read.FileReader(@"C:\Users\Kornelijus\source\repos\ExamFunc\ExamFunc\Files\Drinks.CSV.txt");
            foreach (var item in readLines)
            {
                var lines = item.Split(',');
                DrinkList.Add(new Drinks(lines[0], Convert.ToDecimal(lines[1])));
            }
            return DrinkList;
        }
    }
}
