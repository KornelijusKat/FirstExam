using System;
using System.Collections.Generic;

namespace ExamFunc
{
    public class MealRepo
    {
        public List<Meal> MealList { get; set; }

        public MealRepo()
        {
            MealList = new List<Meal>();
        }
        public List<Meal> GetList()
        {
            FileReaderService der = new FileReaderService();
            var readLines = der.FileReader(@"C:\Users\Kornelijus\source\repos\ExamFunc\ExamFunc\Files\Meals.CSV.txt");
            foreach (var item in readLines)
            {
            var lines = item.Split(',');
            MealList.Add(new Meal(lines[0], Convert.ToDecimal(lines[1])));
            }
            return MealList;
        }
        
    }
}
