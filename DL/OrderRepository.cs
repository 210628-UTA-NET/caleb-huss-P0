using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace DL
{
    public class OrderRepository : IOrderRepository
    {
        private Entities.DemoDBContext _context;
        private List<Orders> _getorders = new List<Orders>();
        private Orders currentOrder = new Orders();
        public OrderRepository(Entities.DemoDBContext p_context)
        {
            _context = p_context;
        }
        public Orders AddOrder(Orders p_order)
        {
            using (Entities.DemoDBContext _context = new Entities.DemoDBContext())
            {
                //Get the highest order number
                var result = (from o in _context.Orders
                              orderby o.OrderId descending
                              select o).FirstOrDefault();
                p_order.OrderNum = result.OrderId + 1;
                var result2 = (from l in _context.LineItems
                               orderby l.LineItemId descending
                               select l).FirstOrDefault();
                int lastLineItemId = result2.LineItemId;
                foreach (LineItems item in p_order.ItemsList)
                {
                    lastLineItemId += 1;
                    _context.LineItems.Add(new Entities.LineItem
                    {
                        LineItemId = lastLineItemId,
                        ProductId = item.Product.ProductID,
                        Quantity = item.Quantity

                    });
                    _context.Orders.Add(new Entities.Order
                    {
                        OrderId = p_order.OrderNum,
                        StoreNumber = p_order.StoreFront.StoreNumber,
                        CustomerId = p_order.Customer.CustomerId,
                        LineItemId = lastLineItemId
                    });
                }
                _context.SaveChanges();
                return p_order;
            }
        }

        public List<Orders> GetOrders(StoreFront p_store)
        {
            using (Entities.DemoDBContext _context = new Entities.DemoDBContext())
            {
                var result = (from o in _context.Orders
                              join l in _context.LineItems on o.LineItemId equals l.LineItemId
                              join p in _context.Products on l.ProductId equals p.ProductId
                              join c in _context.Customers on o.CustomerId equals c.CustomerId
                              where o.StoreNumber == p_store.StoreNumber
                              select new
                              {
                                  OrderNum = o.OrderId,
                                  ProductName = p.Name,
                                  ProductID = p.ProductId,
                                  ProductPrice = p.Price,
                                  ProductDesc = p.Description,
                                  ProductCat = p.Category,
                                  Quantity = l.Quantity,
                                  CustName = c.Name,
                                  CustID = c.CustomerId,
                                  CustAddress = c.Address,
                                  CustCity = c.City,
                                  CustState = c.State,
                                  CustEmail = c.Email,
                                  CustPN = c.PhoneNumber
                              }).ToList();
                int currentOrderNum = result[0].OrderNum;

                foreach (var item in result)
                {
                    if (currentOrderNum != item.OrderNum)
                    {
                        currentOrderNum = item.OrderNum;
                        _getorders.Add(currentOrder);
                        currentOrder = new Orders();
                    }
                    currentOrder.Customer = new Customers()
                    {
                        CustomerId = item.CustID,
                        Name = item.CustName,
                        Address = item.CustAddress,
                        City = item.CustCity,
                        State = item.CustState,
                        Email = item.CustEmail,
                        PhoneNumber = item.CustPN
                    };
                    currentOrder.OrderNum = item.OrderNum;
                    currentOrder.StoreFront = p_store;
                    currentOrder.AddLineItem(new Products()
                    {
                        Name = item.ProductName,
                        Price = (float)item.ProductPrice,
                        Description = item.ProductDesc,
                        Category = item.ProductCat
                    }, (int)item.Quantity);
                }
                return _getorders;
            }

        }

        public List<Orders> GetOrders(Customers p_cust)
        {
            using (Entities.DemoDBContext _context = new Entities.DemoDBContext())
            {
                var result = (from o in _context.Orders
                              join l in _context.LineItems on o.LineItemId equals l.LineItemId
                              join p in _context.Products on l.ProductId equals p.ProductId
                              join s in _context.Stores on o.StoreNumber equals s.StoreNumber
                              where o.CustomerId == p_cust.CustomerId
                              select new
                              {
                                  OrderNum = o.OrderId,
                                  ProductName = p.Name,
                                  ProductID = p.ProductId,
                                  ProductPrice = p.Price,
                                  ProductDesc = p.Description,
                                  ProductCat = p.Category,
                                  Quantity = l.Quantity,
                                  StoreName = s.Name,
                                  StoreNum = s.StoreNumber,
                                  StoreAddress = s.Address,
                                  StoreCity = s.City,
                                  StoreState = s.State
                              }).ToList();
                int currentOrderNum = result[0].OrderNum;

                foreach (var item in result)
                {
                    if (currentOrderNum != item.OrderNum)
                    {
                        currentOrderNum = item.OrderNum;
                        _getorders.Add(currentOrder);
                        currentOrder = new Orders();
                    }
                    currentOrder.Customer = p_cust;
                    currentOrder.OrderNum = item.OrderNum;
                    currentOrder.StoreFront = new StoreFront()
                    {
                        StoreNumber = item.StoreNum,
                        Name = item.StoreName,
                        Address = item.StoreAddress,
                        City = item.StoreCity,
                        State = item.StoreState
                    };
                    currentOrder.AddLineItem(new Products()
                    {
                        Name = item.ProductName,
                        Price = (float)item.ProductPrice,
                        Description = item.ProductDesc,
                        Category = item.ProductCat
                    }, (int)item.Quantity);
                }
                return _getorders;
            }
        }

        public List<Orders> GetOrders(StoreFront p_store, Customers p_cust)
        {

            using (Entities.DemoDBContext _context = new Entities.DemoDBContext())
            {
                var result = (from o in _context.Orders
                              join l in _context.LineItems on o.LineItemId equals l.LineItemId
                              join p in _context.Products on l.ProductId equals p.ProductId
                              where o.StoreNumber == p_store.StoreNumber &&
                                    o.CustomerId == p_cust.CustomerId
                              select new
                              {
                                  OrderNum = o.OrderId,
                                  ProductName = p.Name,
                                  ProductID = p.ProductId,
                                  ProductPrice = p.Price,
                                  ProductDesc = p.Description,
                                  ProductCat = p.Category,
                                  Quantity = l.Quantity
                              }).ToList();
                int currentOrderNum = result[0].OrderNum;

                foreach (var item in result)
                {
                    if (currentOrderNum != item.OrderNum)
                    {
                        currentOrderNum = item.OrderNum;
                        _getorders.Add(currentOrder);
                        currentOrder = new Orders();
                    }
                    currentOrder.Customer = p_cust;
                    currentOrder.OrderNum = item.OrderNum;
                    currentOrder.StoreFront = p_store;
                    currentOrder.AddLineItem(new Products()
                    {
                        Name = item.ProductName,
                        Price = (float)item.ProductPrice,
                        Description = item.ProductDesc,
                        Category = item.ProductCat
                    }, (int)item.Quantity);
                }
                return _getorders;
            }
        }
    }
}
