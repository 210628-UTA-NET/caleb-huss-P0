using System;
using Models;
using BL;
using System.Collections.Generic;

namespace UI
{
    public class CustomerSearchMenu : IMenu
    {
        //Create a customer to be used as a reference
        //to find a customer in the db
        private static Customers _findCust = new Customers();
        private static List<Customers> _foundCusts;
        private ICustomerBL _custBL;
        public CustomerSearchMenu(ICustomerBL p_custBL)
        {
            _custBL = p_custBL;
        }
        public void Menu()
        {
            Console.WriteLine("==== Customer Search Menu ====");
            Console.WriteLine("How would you like to search for a customer?");
            Console.WriteLine("1) Phone Number - " + _findCust.PhoneNumber);
            Console.WriteLine("2) Email - " + _findCust.Email);
            Console.WriteLine("3) Name - " + _findCust.Name);
            Console.WriteLine("4) CustomerID - " + _findCust.CustomerId);
            Console.WriteLine("5) Search");
            Console.WriteLine("6) Clear search");
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
                    _findCust.PhoneNumber = int.Parse(Console.ReadLine());
                    return MenuType.CustomerSearchMenu;
                case "2":
                    _findCust.Email = Console.ReadLine();
                    return MenuType.CustomerSearchMenu;
                case "3":
                    _findCust.Name = Console.ReadLine();
                    return MenuType.CustomerSearchMenu;
                case "4":
                    _findCust.CustomerId = int.Parse(Console.ReadLine());
                    return MenuType.CustomerSearchMenu;
                case "5":
                    _foundCusts = _custBL.GetCustomer(_findCust);
                    foreach (Customers custs in _foundCusts)
                    {
                        Console.WriteLine(custs);
                    }
                    if (_foundCusts.Count == 0)
                    {
                        Console.WriteLine("No customers found. Please try different search terms");
                    }
                    Console.WriteLine("Press enter to go back");
                    Console.ReadLine(); // Pause after getting customer from db
                    return MenuType.CustomerSearchMenu;
                case "6":
                    _findCust.Name = "";
                    _findCust.Email = "";
                    _findCust.PhoneNumber = 0;
                    _findCust.CustomerId = 0;
                    return MenuType.CustomerSearchMenu;
                default:
                    return MenuType.CustomerSearchMenu;
            }
        }
        /// <summary>
        /// This might not be needed but when the search funciton is used the returned customer is stored
        /// in this property
        /// </summary>
        /// <value>The values will be the searched for customer</value>
        public List<Customers> CustomerFound { get; set; }
    }
}