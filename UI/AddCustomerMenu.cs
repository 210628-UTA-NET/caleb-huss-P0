using System;

namespace UI
{
    public class AddCustomerMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("==== Add Customer Menu ====");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Create a new Customer Profile");
            Console.WriteLine("0) Go back");
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {   default:
                    return MenuType.AddCustomerMenu;
            }
        }
    }
}