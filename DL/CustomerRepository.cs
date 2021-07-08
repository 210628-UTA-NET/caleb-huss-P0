using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace DL
{
    public class CustomerRepository : ICustomerRepository
    {
        private Entities.DemoDBContext _context;
        public CustomerRepository(Entities.DemoDBContext p_context)
        {
            _context = p_context;
        }
        public Customers AddCustomer(Customers p_cust)
        {
            // Need to query and get largest customer number then add 1
            int custNumber = 10;
            _context.Customers.Add(new Entities.Customer
            {
                CustomerId = (int)custNumber + 1,
                Name = p_cust.Name,
                Address = p_cust.Address,
                City = p_cust.City,
                State = p_cust.State,
                Email = p_cust.Email,
                PhoneNumber = p_cust.PhoneNumber
            });
            return p_cust;
        }

        public List<Customers> GetAllCustomers()
        {
            return _context.Customers.Select(
                rest =>
                    new Customers()
                    {
                        CustomerNumber = rest.CustomerId,
                        Name = rest.Name,
                        City = rest.City,
                        State = rest.State,
                        Address = rest.Address,
                        Email = rest.Email,
                        PhoneNumber = (int)rest.PhoneNumber
                    }
            ).ToList();
        }

        public Customers GetCustomers(Customers p_cust)
        {
            throw new NotImplementedException();
        }
    }
}