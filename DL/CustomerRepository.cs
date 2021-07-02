using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace DL
{
    public class CustomerRepository : ICustomerRepository
    {

        private const string _filePath = "./../DL/Database/Customers.json";
        private string _jsonString;
        public Customers AddCustomer(Customers p_cust)
        {
            List<Customers> listOfCustomers = this.GetAllCustomers();
            listOfCustomers.Add(p_cust);
            _jsonString = JsonSerializer.Serialize(listOfCustomers, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filePath,_jsonString);
            return p_cust;
        }

        public List<Customers> GetAllCustomers()
        {
            try
            {
                _jsonString = File.ReadAllText(_filePath);
            }
            catch (System.Exception)
            {
                
                throw new Exception("Something went wrong while trying to open the Customer DB");
            }
            return JsonSerializer.Deserialize<List<Customers>>(_jsonString);
        }

        public Customers GetCustomers(Customers p_cust)
        {
            throw new NotImplementedException();
        }
    }
}