using System;
using System.Collections.Generic;
using BL;
using Models;

namespace UI
{

    public class EmployeeViewInventoryMenu : IMenu
    {
        private IInventoryBL _invBL;
        private Products _product = new Products();
        private StoreFront _searchedstore = EmployeeStoreSelectorMenu._store;
        public EmployeeViewInventoryMenu(IInventoryBL p_invBL)
        {
            _invBL = p_invBL;
        }
        public void Menu()
        {
            Console.WriteLine($"==== {_searchedstore.Name}s Inventory Menu ====");
            Console.WriteLine("Here you can search for specific items or view the entire inventory");
            Console.WriteLine("1) Product name - " + _product.Name);
            Console.WriteLine("2) Product ID - " + _product.ProductID);
            Console.WriteLine("3) Product price - " + _product.Price);
            Console.WriteLine("4) Category - " + _product.Category);
            Console.WriteLine("5) Search");
            Console.WriteLine("6) View entire inventory");
            Console.WriteLine("0) Go back");
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return MenuType.CustomerCornerMenu;
                case "1":
                    Console.WriteLine("");
                    _product.Name = Console.ReadLine();
                    return MenuType.EmployeeViewInventoryMenu;
                case "2":
                    Console.WriteLine("");
                    return MenuType.EmployeeViewInventoryMenu;
                case "3":
                    Console.WriteLine("");
                    return MenuType.EmployeeViewInventoryMenu;
                case "4":
                    Console.WriteLine("");
                    return MenuType.EmployeeViewInventoryMenu;
                case "5":
                    List<LineItems> _specificinventory = _invBL.GetSearchedInventory(_searchedstore, _product);
                    Console.WriteLine("================");
                    if (_specificinventory.Count == 0)
                    {
                        Console.WriteLine("Could not find any products");
                    }
                    foreach (LineItems lineitem in _specificinventory)
                    {
                        Console.WriteLine(lineitem);
                        Console.WriteLine("================");
                    }
                    Console.WriteLine("Press enter to go back");
                    Console.ReadLine();

                    return MenuType.EmployeeViewInventoryMenu;
                case "6":
                    List<LineItems> _allinventory = _invBL.GetAllInventory(_searchedstore);
                    Console.WriteLine("================");
                    if (_allinventory.Count == 0)
                    {
                        Console.WriteLine("This store has no inventory.");
                    }
                    foreach (LineItems lineitem in _allinventory)
                    {
                        Console.WriteLine(lineitem);
                        Console.WriteLine("================");
                    }
                    Console.WriteLine("Press enter to go back");
                    Console.ReadLine();
                    return MenuType.EmployeeViewInventoryMenu;
                default:
                    return MenuType.EmployeeViewInventoryMenu;

            }
        }
    }
}