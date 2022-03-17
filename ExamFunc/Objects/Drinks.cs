
namespace ExamFunc
{
    public class Drinks : Goods
    {
        public Drinks(string name, decimal price) : base(name, price)
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
