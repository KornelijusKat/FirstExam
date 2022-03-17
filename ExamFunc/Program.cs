
namespace ExamFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstMenu DinerMenu = new FirstMenu();
            bool isAlive = true;
            while (isAlive)
            {
                DinerMenu.MainMenu();
            }
        }
    }
}
