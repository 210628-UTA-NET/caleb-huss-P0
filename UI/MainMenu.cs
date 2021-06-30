using System;

namespace UI
{
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("====Main Menu====");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Search for a Store");
            Console.WriteLine("2) Search for a customer profile");
            Console.WriteLine("3) Add a customer profile");
            Console.WriteLine("4) Place order");
            Console.WriteLine("5) Order look up");
            Console.WriteLine("6) Replenish Inventory");
            Console.WriteLine("0) Exit");
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                default:
                    return MenuType.MainMenu;
            }


        }
    }
}