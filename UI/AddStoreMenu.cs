using System;
using Models;
using BL;

namespace UI
{
    public class AddStoreMenu : IMenu
    {
        private static StoreFront _newStore = new StoreFront();
        private IStoreBL _storeBL;
        public AddStoreMenu(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        public void Menu()
        {
            Console.WriteLine("==== Add Store Menu ====");
            Console.WriteLine("What would you like to the store profile?");
            Console.WriteLine("1) Store Name - " + _newStore.Name);
            Console.WriteLine("2) Store Address - " + _newStore.Address);
            Console.WriteLine("3) City - " + _newStore.City);
            Console.WriteLine("4) State - " + _newStore.State);
            Console.WriteLine("5) Create Store Profile");
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
                    _newStore.Name = Console.ReadLine();
                    return MenuType.AddStoreMenu;
                case "2":
                    _newStore.Address = Console.ReadLine();
                    return MenuType.AddStoreMenu;
                case "3":
                    _newStore.City = Console.ReadLine();
                    return MenuType.AddStoreMenu;
                case "4":
                    _newStore.State = Console.ReadLine();
                    return MenuType.AddStoreMenu;
                case "5":
                    _storeBL.AddStore(_newStore); //Commits the new store to the db
                    return MenuType.StoreMenu;
                default:
                    return MenuType.AddStoreMenu;
            }
        }
    }
}