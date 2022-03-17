using System;
using System.Collections.Generic;
using System.Linq;


namespace ExamFunc
{
    public class GoodsMenu
    {
        public static Order PickFromList<T>(List<T> TList, Order newOrder)
        {          
             int index = 0;
             TList.ForEach(x => Console.WriteLine($"{index++}. {x}"));
             List<Goods> choiceList = TList.Cast<Goods>().ToList();
             newOrder.AddToList(ItemSelecter.SelectItem<Goods>(choiceList));     
             return newOrder;
        }
    }
}
