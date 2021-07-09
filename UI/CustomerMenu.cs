using System;

namespace UI
{
    public class CustomerMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("===Customer Menu===");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Search for existing Customer?");
            Console.WriteLine("2) Create a customer profile?");
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
                    return MenuType.CustomerSearchMenu;
                case "2":
                    return MenuType.AddCustomerMenu;
                default:
                    return MenuType.CustomerMenu;
            }
        }
    }


}