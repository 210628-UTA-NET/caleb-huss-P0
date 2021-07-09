using System;
using Models;
namespace UI
{

    public class EmployeeLoginMenu : IMenu
    {
        private static UserLogin _userlog = new UserLogin();

        public void Menu()
        {
            Console.WriteLine("=== Employee Login ===");
            Console.WriteLine("Please enter your credentials: ");
            Console.WriteLine("1) Enter EmployeeID - ");
            Console.WriteLine("2) Enter password - ");
            Console.WriteLine("3) Login");
            Console.WriteLine("0) Go back");
            
        }

        public MenuType YourChoice()
        {
            throw new NotImplementedException();
        }
    }
}