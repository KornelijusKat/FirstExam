
namespace ExamFunc
{
    public class Table 
    {
        public string Number { get; set; }
        public int Seats { get; set; }
        public bool IsVacant { get; set; }
        public Table(string number, int seats, bool isVacant)
        {
            Number = number;
            Seats = seats;
            IsVacant = isVacant;
        }
        public Table()
        {
        }
        public override string ToString()
        {
            return $"Table number: {Number} \nSeats: {Seats}";
        }
    }
}
