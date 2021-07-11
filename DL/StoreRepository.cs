using System;
using System.Collections.Generic;
using System.Linq;
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
            return _context.Stores.Select(
                stores =>
                    new StoreFront()
                    {
                        StoreNumber = stores.StoreNumber,
                        Address = stores.Address,
                        City = stores.City,
                        State = stores.State,
                        Name = stores.Name
                    }
            ).ToList();
        }

        public List<StoreFront> GetStore(StoreFront p_store)
        {
            throw new NotImplementedException();
        }
    }
}