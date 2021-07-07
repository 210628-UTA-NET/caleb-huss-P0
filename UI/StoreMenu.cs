using System;

namespace UI
{
    public class StoreMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("=== Welcome to the Store Corner ===");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Search for a store?");
            Console.WriteLine("2) Add a store");
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
                    return MenuType.StoreSearchMenu;
                case "2":
                    return MenuType.AddStoreMenu;
                default:
                    return MenuType.StoreMenu;
            }
        }
    }
}