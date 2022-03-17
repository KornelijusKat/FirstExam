
namespace ExamFunc
{
   public class Meal : Goods
    {
        public Meal(string name, decimal price) : base(name, price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name} {Price} Euro";
        }
    }
}
