using System;

namespace UI
{
    public class OrderMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("=== Order Corner ===");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Place an order?");
            Console.WriteLine("2) Look up order history for a customer?");
            Console.WriteLine("3) Look up order history for a store?");
            Console.WriteLine("0) Go back");
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return MenuType.Exit;
                case "1":
                    return MenuType.PlaceOrderMenu;
                case "2":
                    return MenuType.CustomerOrderHistory;
                case "3":
                    return MenuType.StoreOrderHistoryMenu;
                default:
                    return MenuType.OrderMenu;
            }
        }
    }
}