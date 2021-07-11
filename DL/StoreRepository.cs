using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace DL
{
    public class StoreRepository : IStoreRepository
    {
        private Entities.DemoDBContext _context;
        public StoreRepository(Entities.DemoDBContext p_context)
        {
            _context = p_context;
        }
        public StoreFront AddStore(StoreFront p_store)
        {
            _context.Stores.Add(new Entities.Store
            {
                StoreNumber = p_store.StoreNumber,
                Address = p_store.Address,
                City = p_store.City,
                State = p_store.State,
                Name = p_store.Name
            });
            _context.SaveChanges();
            return p_store;
        }

        public List<StoreFront> GetAllStores()
        {
            throw new NotImplementedException();
        }

        public List<StoreFront> GetStore(StoreFront p_store)
        {
            throw new NotImplementedException();
        }
    }
}