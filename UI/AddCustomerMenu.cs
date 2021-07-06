using System;
using Models;
using BL;
namespace UI
{
    public class AddCustomerMenu : IMenu
    {
        private static Customers _newCust = new Customers();
        private ICustomerBL _custBL;
        public AddCustomerMenu(ICustomerBL p_custBL)
        {
            _custBL = p_custBL;
        }
        public void Menu()
        {
            Console.WriteLine("==== Add Customer Menu ====");
            Console.WriteLine("What would you like to dadd to the custome profile?");
            Console.WriteLine("1) Name - ");
            Console.WriteLine("2) Address - ");
            Console.WriteLine("3) City - ");
            Console.WriteLine("4) State - ");
            Console.WriteLine("5) Email - ");
            Console.WriteLine("6) PhoneNumber - ");
            Console.WriteLine("7) Create Customer Profile");
            Console.WriteLine("0) Go back");
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();
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
                    _newCust.PhoneNumber = Console.ReadLine();
                    return MenuType.AddCustomerMenu;
                case "7":
                    _custBL.AddCustomer(_newCust);
                    return MenuType.CustomerMenu;
                default:
                    return MenuType.AddCustomerMenu;
            }
        }
    }
}