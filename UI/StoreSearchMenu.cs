using System;
using Models;
using BL;

namespace UI
{
    public class StoreSearchMenu : IMenu
    {
        private static StoreFront _findStore = new StoreFront();
        private IStoreBL _storeBL;
        public StoreSearchMenu(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;    
        }
        public void Menu()
        {
            Console.WriteLine("==== Store Search Menu ====");
            Console.WriteLine("How would you like search for a store?");
            Console.WriteLine("1) Store Name - ");
            Console.WriteLine("2) Store Address - ");
            Console.WriteLine("3) Store Number - ");
            Console.WriteLine("4) Search");
            Console.WriteLine("0) Go back");
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return MenuType.Exit;
                case "1":
                    _findStore.Name  = Console.ReadLine();
                    return MenuType.StoreSearchMenu;
                case "2":
                    _findStore.Address = Console.ReadLine();
                    return MenuType.StoreSearchMenu;
                case "3":
                    _findStore.StoreNumber = int.Parse(Console.ReadLine());
                    return MenuType.StoreSearchMenu;
                case "4":
                    StoreFound = _storeBL.GetStoreFront(_findStore);
                    return MenuType.StoreFoundMenu;

                default:
                    return MenuType.StoreSearchMenu;
            }
        }
        public StoreFront StoreFound { get; set; }
    }
}