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
            return _repo.AddCustomer(p_cust);
        }

        public List<Customers> GetAllCustomers()
        {
           return _repo.GetAllCustomers();
        }

        public List<Customers> GetCustomer(Customers p_cust)
        {
            if ((p_cust.Name == null) && (p_cust.Email == null) && (p_cust.CustomerId == 0) && (p_cust.PhoneNumber == 0))
            {
                p_cust.PhoneNumber = 1;
            }
            return _repo.GetCustomer(p_cust);
        }
    }
}