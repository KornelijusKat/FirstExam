using System;

namespace ExamFunc
{
    class FirstMenu
    {
        public TableRepository TableRep = new TableRepository();
        public TableOrder Tarbles = new TableOrder();
        public FirstMenu()
        {     
        }
        public bool MainMenu()
        {
            MenuStrings.TableMenuSrings();
            int input = Console.ReadLine().IntValidation();
            Console.Clear();
            if (input == 1)
            {
                TableRep.ShowList();
            }
            else if (input == 2)
            {
                TableRep.ShowList();
                Console.WriteLine("Pick Table from List by left side number");
                var clientTable = ItemPicker<Table>.PickTable(TableRep.TableList);
                if (clientTable.TableVacancyValidation() != null)
                {
                    clientTable.ChangeTableVacancy();
                    Tarbles.OrderMenu(clientTable);
                }
            }
            else if (input == 3)
            {
                Console.WriteLine("Choose Table to change vacancy status, to either vacant or taken");
                TableRep.ShowList();
                ChangeObjParam.ChangeTableVacancy(ItemSelecter.SelectItem<Table>(TableRep.TableList));
            }
            else if (input == 4)
            {
                Console.WriteLine("Exiting program");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Selection is out of range, try again");
            }
                return true;
        }
    }
}
