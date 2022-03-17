using System.Collections.Generic;

namespace ExamFunc
{
    public class GoodsRep
    {
        public List<Goods> OrderGoods { get; set; }
        public GoodsRep()
        {
            OrderGoods = new List<Goods>();
        }
        public void AddToList(Goods item)
        {
            if (item != null)
            {
                OrderGoods.Add(item);
            }
        }
    }
}
