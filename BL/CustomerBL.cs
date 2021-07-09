using System;
using Models;
using DL;
using System.Collections.Generic;

namespace BL
{
    public class CustomerBL : ICustomerBL
    {
        private ICustomerRepository _repo;
        public CustomerBL(ICustomerRepository p_repo)
        {
            _repo = p_repo;
        }
        public Customers AddCustomer(Customers p_cust)
        {
            p_cust.CustomerNumber = _repo.GetAllCustomers().Count + 1;
            // Modify customer to have a new customer id
            return _repo.AddCustomer(p_cust);
        }

        public List<Customers> GetAllCustomers()
        {
           return _repo.GetAllCustomers();
        }

        public Customers GetCustomer(Customers p_cust)
        {
            throw new NotImplementedException();
        }
    }
}