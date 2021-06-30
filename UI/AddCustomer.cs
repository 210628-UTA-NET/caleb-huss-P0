using System;
using Models;
namespace UI
{
    public class AddCustomer
    {
        public static Customers AddCust()
        {
            Customers CustObj = new Customers();
            Console.WriteLine("What is the customers Name?");
            CustObj.Name = Console.ReadLine();
            // Console.WriteLine("What is the customers Address?");
            // CustObj.Address = (Console.ReadLine());
            // Console.WriteLine("What is the customers Email?");
            // CustObj.Email = (Console.ReadLine());
            // Console.WriteLine("What is the customers phonenumber?");
            // CustObj.PhoneNumber = (Console.ReadLine());
            return CustObj;
        }
    }
}