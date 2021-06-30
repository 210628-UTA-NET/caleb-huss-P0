using System;

namespace UI
{
    public class CustomerSearchMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("==== Customer Search Menu ====");
            Console.WriteLine("How would you like to search for a customer?");
            Console.WriteLine("1) By phone number?");
            Console.WriteLine("2) By email?");
            Console.WriteLine("3) By Name?");
            Console.WriteLine("4) By address?");
        }

        public MenuType YourChoice()
        {
            throw new NotImplementedException();
        }
    }
}