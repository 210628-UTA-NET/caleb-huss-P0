using System;
using System.Collections.Generic;
using BL;
using Models;

namespace UI
{
    public class ViewAllStoresMenu : IMenu
    {
        private IStoreBL _storeBL;
        public ViewAllStoresMenu(IStoreBL p_store)
        {
            _storeBL = p_store;
        }
        public void Menu()
        {
            Console.WriteLine("List of all Stores");
            List<StoreFront> stores = _storeBL.GetAllStores();
            Console.WriteLine("=====================");

            foreach (StoreFront store in stores)
            {
                Console.WriteLine(store);
                Console.WriteLine("=====================");
            }
            Console.WriteLine("0) Go back");
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return MenuType.StoreMenu;
                default:
                    return MenuType.ViewAllStoresMenu;
            }
        }
    }
}