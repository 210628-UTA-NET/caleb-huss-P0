using System;

namespace UI
{
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("====Main Menu====");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Fill in Customer Information");
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