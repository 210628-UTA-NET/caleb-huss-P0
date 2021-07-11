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

                if (Enum.IsDefined(typeof(MenuType), currentMenu))
                {
                    restMenu = menuFactory.GetMenu(currentMenu);
                }else
                {
                    Console.WriteLine("Could not process input. Hit enter and try again");
                    Console.ReadLine();
                    break;
                }
                if (currentMenu == MenuType.Exit)
                {
                    repeat = false;
                }
            }


        }
    }
}
