using System;

namespace ExamFunc
{
    class TableOrder
    {
        public GoodsRep Goods = new GoodsRep();
        public DrinksRepo Drinks = new DrinksRepo();
        public MealRepo Meals = new MealRepo();
        public Order NewOrder = new Order();
        public TableOrder()
        {         
            Meals.GetList();
            Drinks.GetList();
        }
        public bool OrderMenu(Table client)
        {
                NewOrder.MyTable = client;
                MenuStrings.OrderMenu();
                Console.WriteLine("Pick selection");     
                int input = Console.ReadLine().IntValidation();
                Console.Clear();
                if (input == 1)
                {
                    GoodsMenu.PickFromList<Meal>(Meals.MealList, NewOrder);
                }
                else if (input == 2)
                {
                    GoodsMenu.PickFromList<Drinks>(Drinks.DrinkList, NewOrder);
                }
                else if (input == 3)
                {
                    Console.WriteLine(NewOrder);                 
                }
                else if (input == 4)
                {
                    CompleteOrder.FinishOrder(NewOrder);
                    return false;
                }
                else if (input == 5)
                {
                    client.ChangeTableVacancy();
                    return false;
                }
                else if (input == 6)
                {
                    RemoveItemMenu.RemoveItem(NewOrder);
                }
                else
                {
                    Console.WriteLine("Selection is out of range, returning to selection");
                }        
                return OrderMenu(client);
        }
    }
}
