using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace DL
{
    public class InventoryRepository : IInventoryRepository
    {
        private Entities.DemoDBContext _context;
        public InventoryRepository(Entities.DemoDBContext p_context)
        {
            _context = p_context;
        }
        public LineItems ChangeInventory(StoreFront p_store, LineItems p_lineitem)
        {
            throw new NotImplementedException();
        }

        public List<LineItems> GetAllInventory(StoreFront p_store)
        {

            using (Entities.DemoDBContext _context = new Entities.DemoDBContext())
            {
                var _storeInventory = (from i in _context.Inventories
                                       join p in _context.Products on i.ProductId equals p.ProductId
                                       where i.StoreNumber == p_store.StoreNumber
                                       select new
                                       {
                                           StoreNumber = i.StoreNumber,
                                           Quantity = i.Quantity,
                                           ProductName = p.Name,
                                           Price = p.Price,
                                           Description = p.Description,
                                           Category = p.Category,
                                       }).ToList();
                List<LineItems> _inventory = new List<LineItems>();
                foreach (var item in _storeInventory)
                {
                    LineItems _lineitem = new LineItems();
                    _lineitem.Quantity= (int)item.Quantity;
                    Products _item = new Products()
                    {
                        Name = item.ProductName,
                        Price = (float)item.Price,
                        Description = item.Description,
                        Category = item.Category
                    };
                    _lineitem.Product = _item;
                    _inventory.Add(_lineitem);
                }

                return _inventory;
            }

            /*
        using (ModelsContext _context = new ModelsContext())
            {
                var _listOfOrderHistory = (from op in _context.OrdersProduct
                                        join o in _context.Orders on op.OrdersID equals o.ID
                                        join p in _context.Product on op.ProductID equals p.ID
                                        where o.LocationID == p_locationID
                                        select new {
                                            Date = o.Date,
                                            CustomerID = o.CustomerID,
                                            ProductName = p.ProductName,
                                            Cost = p.Cost,
                                            Quantity = op.SaleQuantity
                                        }).ToList();
                
                CustomerRepository _customerRepo = new CustomerRepository();

                List<OrderHistory> _newOrderHistory = new List<OrderHistory>();
                foreach (var item in _listOfOrderHistory)
                {
                    OrderHistory _item = new OrderHistory()
                    {
                        Date = item.Date,
                        ProductName = item.ProductName,
                        Cost = item.Cost,
                        Quantity = item.Quantity,
                        Customer = _customerRepo.GiveExistingCustomer(item.CustomerID)
                    };

                    _newOrderHistory.Add(_item);
                }
                
                return _newOrderHistory;



            */
        }

        public List<LineItems> GetSearchedInventory(StoreFront p_store, Products p_product)
        {
            throw new NotImplementedException();
        }
    }
}