using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace DL
{
    public class StoreRepository : IStoreRepository
    {
        private const string _filePath = "./../DL/Database/Customer.json";
        private string _jsonString;
        public StoreFront AddStore(StoreFront p_store)
        {
            List<StoreFront> listOfStores = this.GetAllStores();
            listOfStores.Add(p_store);
            _jsonString = JsonSerializer.Serialize(listOfStores, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filePath,_jsonString);
            return p_store;
        }

        public List<StoreFront> GetAllStores()
        {
            try
            {
                _jsonString = File.ReadAllText(_filePath);
            }
            catch (System.Exception)
            {
                
                throw new Exception("Something went wrong while try to open the Store DB");

            }
            return JsonSerializer.Deserialize<List<StoreFront>>(_jsonString);
        }

        public StoreFront GetStore(StoreFront p_store)
        {
            throw new NotImplementedException();
        }
    }
}