using System;
using Models;
using BL;
namespace UI
{
    public class CustomerSearchMenu : IMenu
    {
        //Create a customer to be used as a reference
        //to find a customer in the db
        private static Customers _findCust = new Customers();
        private ICustomerBL _custBL;
        public CustomerSearchMenu(ICustomerBL p_custBL)
        {
            _custBL = p_custBL;
        }
        public void Menu()
        {
            Console.WriteLine("==== Customer Search Menu ====");
            Console.WriteLine("How would you like to search for a customer?");
            Console.WriteLine("1) Phone Number - ");
            Console.WriteLine("2) Email - ");
            Console.WriteLine("3) Name - ");
            Console.WriteLine("4) Customer Number - ");
            Console.WriteLine("5) Search");
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
                    _findCust.CustomerNumber = int.Parse(Console.ReadLine());
                    return MenuType.CustomerSearchMenu;
                case "5":
                    CustomerFound = _custBL.GetCustomer(_findCust);
                    Console.ReadLine(); // Pause after getting customer from db
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
        public Customers CustomerFound { get; set; }
    }
}