using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace DL
{
    public class OrderRepository : IOrderRepository
    {
        private Entities.DemoDBContext _context;
        public OrderRepository(Entities.DemoDBContext p_context)
        {
            _context = p_context;
        }
        public Orders AddOrder(Orders p_order)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetOrders(StoreFront p_store)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetOrders(Customers p_cust)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetOrders(StoreFront p_store, Customers p_cust)
        {
            throw new NotImplementedException();
        }
    }
}
