using System;

namespace ExamFunc
{
    public class RemoveItemMenu
    {
        public static void RemoveItem(Order myOrder)
        {
            int index = 0;                   
            myOrder.GoodsList.ForEach(x => Console.WriteLine($"{index++}. {x}"));
            var itemToRemove = ItemSelecter.SelectItem<Goods>(myOrder.GoodsList);
            myOrder.GoodsList.Remove(itemToRemove);
        }
    }
}
