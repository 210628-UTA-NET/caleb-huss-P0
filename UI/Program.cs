using System;
using System.Collections.Generic;
using BL;
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

                // switch (currentMenu)
                // {
                //     case MenuType.MainMenu:
                //         restMenu = menuFactory.GetMenu(MenuType.MainMenu);
                //         break;
                //     case MenuType.CustomerMenu:
                //         restMenu = menuFactory.GetMenu(MenuType.CustomerMenu);
                //         break;
                //     default:
                //         Console.WriteLine("Cannot process. Press enter and try again.");
                //         Console.ReadLine();
                //         break;
                // }

                if (Enum.IsDefined(typeof(MenuType), currentMenu))
                {
                    restMenu = menuFactory.GetMenu(currentMenu);
                }else
                {
                    Console.WriteLine("Could not process input. Hit enter and try again");
                    Console.ReadLine();
                    break;
                }

                // Console.WriteLine("{0}: {1}", currentMenu, Enum.IsDefined(typeof(MenuType), currentMenu));
                // Console.ReadLine();
            }


        }
    }
}
