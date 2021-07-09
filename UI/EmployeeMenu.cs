using System;

namespace UI
{
    public class EmployeeMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("=== Employee Menu ===");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Get all Customers");
            Console.WriteLine("2) Get store order history");
            Console.WriteLine("3) Replenish store inventory");
            Console.WriteLine("0) Go back");
        }
           

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return MenuType.MainMenu;
                case "1":
                    return MenuType.ViewAllCustomersMenu;
                case "2":
                    return MenuType.StoreOrderHistoryMenu;
                case "3":
                    return MenuType.ReplenishInventoryMenu;
                default:
                    return MenuType.EmployeeMenu;
            }
        }
    }
}