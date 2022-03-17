using System;
using System.Collections.Generic;

namespace ExamFunc
{
    public class TableRepository
    {
        public List<Table> TableList { get;set; }
        public TableRepository()
        {
            TableList = new List<Table>() {new Table("1",4,true),
                                           new Table("2",2,true),
                                           new Table("3",5,true),
                                           new Table("4",4,true),
                                           new Table("5",6,true),
                                           new Table("6",4,true)};
        }
        public void ShowList()
        {
            int index = 0;
            foreach(var item in TableList)
            {
                Console.WriteLine($"{index++}.Table number: {item.Number}, Seats: {item.Seats},{(item.IsVacant ? "Vacant": "Taken")}");
            }          
        }
    }
}

