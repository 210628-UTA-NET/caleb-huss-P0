using System;
using Models;
using BL;
namespace UI
{
    public class AddCustomerMenu : IMenu
    {
        //Create a customer class to add info too
        //It will be used to add a customer to the db
        private static Customers _newCust = new Customers();
        private ICustomerBL _custBL;
        public AddCustomerMenu(ICustomerBL p_custBL)
        {
            _custBL = p_custBL;
        }
        public void Menu()
        {
            Console.WriteLine("==== Add Customer Menu ====");
            Console.WriteLine("What would you like to add to the custome profile?");
            Console.WriteLine("1) Name - " + _newCust.Name);
            Console.WriteLine("2) Address - " + _newCust.Address);
            Console.WriteLine("3) City - " + _newCust.City);
            Console.WriteLine("4) State - " + _newCust.State);
            Console.WriteLine("5) Email - " + _newCust.Email);
            Console.WriteLine("6) PhoneNumber - " + _newCust.PhoneNumber);
            Console.WriteLine("7) Create Customer Profile");
            Console.WriteLine("0) Go back");
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();
            //inputs 1-6 add info to the _newCust obj
            switch (userInput)
            {   case "0":
                    return MenuType.CustomerMenu;
                case "1":
                    _newCust.Name = Console.ReadLine();
                    return MenuType.AddCustomerMenu;
                case "2":
                    _newCust.Address = Console.ReadLine();
                    return MenuType.AddCustomerMenu;
                case "3":
                    _newCust.City = Console.ReadLine();
                    return MenuType.AddCustomerMenu;
                case "4":
                    _newCust.State = Console.ReadLine();
                    return MenuType.AddCustomerMenu;
                case "5":
                    _newCust.Email = Console.ReadLine();
                    return MenuType.AddCustomerMenu;
                case "6":
                    _newCust.PhoneNumber = long.Parse(Console.ReadLine());
                    return MenuType.AddCustomerMenu;
                case "7":
                    _custBL.AddCustomer(_newCust); //THis commits the cust to the db
                    return MenuType.CustomerMenu;
                default:
                    return MenuType.AddCustomerMenu;
            }
        }
    }
}