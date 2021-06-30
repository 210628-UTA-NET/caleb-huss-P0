using System;

namespace UI
{
    public class MainMenu : IMenu
    {
        public MainMenu()
        {
        }
        public void Menu()
        {
            Console.WriteLine("====Main Menu====");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Fill in Customer Information");
            Console.WriteLine("0) Exit");
        }

        public string YourChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "CustomerMenu";
                default:
                    return "Unknown";
            }


        }
    }
}