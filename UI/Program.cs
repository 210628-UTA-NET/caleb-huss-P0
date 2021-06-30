using System;
using System.Collections.Generic;
using Models;
namespace UI
{
    class Program
    {

        static void Main(string[] args)
        {
            //List<Customers> _customers = new List<Customers>();
            // generic code that created 3 customers then got their names
            // for (int x = 0; x < 3; x++)
            // {
            //     _customers.Add(AddCustomer.AddCust());
            // }
            // foreach (Customers item in _customers)
            // {
            //     Console.WriteLine(item.Name);
            // }

            IMenu restMenu = new MainMenu();
            bool repeat = true;
            MenuType currentMenu = MenuType.MainMenu;

            while (repeat)
            {
                Console.Clear();
                restMenu.Menu();
                currentMenu = restMenu.YourChoice();

                switch (currentMenu)
                {
                    case MenuType.MainMenu:
                        restMenu = new MainMenu();
                        break;
                    default:
                        Console.WriteLine("Cannot process. Please try again.");
                        break;
                }
            }


        }
    }
}
