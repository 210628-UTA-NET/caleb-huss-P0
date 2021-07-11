using System;
using System.Collections.Generic;
using BL;
using Models;

namespace UI
{
    public class ViewAllCustomersMenu : IMenu
    {
        private ICustomerBL _custBL;
        public ViewAllCustomersMenu(ICustomerBL p_cust)
        {
            _custBL = p_cust;
        }
        public void Menu()
        {
            Console.WriteLine("List of Customers");
            List<Customers> customers = _custBL.GetAllCustomers();
            Console.WriteLine("=====================");

            foreach (Customers cust in customers)
            {
                Console.WriteLine(cust);
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
                    return MenuType.EmployeeMenu;                
                default:
                    return MenuType.ViewAllCustomersMenu;
            }
        }
    }
}