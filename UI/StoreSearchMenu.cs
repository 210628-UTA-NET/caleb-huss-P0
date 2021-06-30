using System;

namespace UI
{
    public class StoreSearchMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("==== Store Search Menu ====");
            Console.WriteLine("How would you like search for a store?");
            Console.WriteLine("1) By store name");
            Console.WriteLine("2) By store address");
            Console.WriteLine("3) By store number");
            Console.WriteLine("0) Go back");
        }

        public MenuType YourChoice()
        {
            throw new NotImplementedException();
        }
    }
}