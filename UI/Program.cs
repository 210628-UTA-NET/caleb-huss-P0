using System;
using System.Collections.Generic;
using Models;
namespace UI
{
    class Program
    {

        static void Main(string[] args)
        {
            IMenu restMenu = new MainMenu();
            bool repeat = true;
            MenuType currentMenu = MenuType.MainMenu;
            IFactory menuFactory = new MenuFactory();

            while (repeat)
            {
                Console.Clear();
                restMenu.Menu();
                currentMenu = restMenu.YourChoice();

                switch (currentMenu)
                {

                    default:
                        Console.WriteLine("Cannot process. Please try again.");
                        break;
                }
            }


        }
    }
}
