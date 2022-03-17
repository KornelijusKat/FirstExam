using System;
using System.Collections.Generic;
using System.Linq;


namespace ExamFunc
{
     public class Order
    {
        public Table MyTable { get; set; }
        public List<Goods> GoodsList { get; set; }
        public Order()
        {
            GoodsList = new List<Goods>();
        }
        public decimal CalculateOrderSum()
        {
            return GoodsList.Sum(x => x.Price);
        }
        public override string ToString()
        {
            return $"Clients table:\n{MyTable}\nOrdered Items:\n{string.Join(Environment.NewLine, GoodsList)}\nTotal price: {CalculateOrderSum()} Euro\n{DateTime.Now}";
        }
        public void AddToList(Goods item)
        {
            if (item != null)
            {
                GoodsList.Add(item);
            }
        }
    }
}
