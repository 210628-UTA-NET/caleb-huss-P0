using System;
using System.Collections.Generic;
using Models;
namespace UI
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Customers> _customers = new List<Customers>();

            // bool repeat = true;
            // while(repeat)
            // {
            //     _customers.Add(AddCustomer.AddCustomer());
            // }

            for (int x = 0; x < 3; x++)
            {
                _customers.Add(AddCustomer.AddCust());
            }
            foreach (Customers item in _customers)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
