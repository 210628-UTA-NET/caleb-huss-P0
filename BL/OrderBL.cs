using Models;
using DL;
using System.Collections.Generic;

namespace BL
{
    public class OrderBL : IOrderBL
    {
        private IOrderRepository _repo;
        public OrderBL(IOrderRepository p_repo)
        {
            _repo = p_repo;
        }
        public Orders AddOrder(Orders p_order)
        {
            return _repo.AddOrder(p_order);
        }

        public List<Orders> GetAllOrders(Customers p_cust)
        {
            return _repo.GetOrders(p_cust);
        }

        public List<Orders> GetAllOrders(StoreFront p_store)
        {
            return _repo.GetOrders(p_store);
        }

        public List<Orders> GetAllOrders(StoreFront p_store, Customers p_cust)
        {
            return _repo.GetOrders(p_store, p_cust);
        }
    }
}