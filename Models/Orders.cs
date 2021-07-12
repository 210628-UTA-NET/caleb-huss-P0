using System;
using System.Collections.Generic;

namespace Models
{
    public class Orders
    {
        private List<LineItems> _itemslist = new List<LineItems>();
        private double _totalprice;
        private int _ordernum;
        public double TotalPrice
        {
            get
            {
                return _totalprice;
            }
        }
        public int OrderNum
        {
            get
            {
                return _ordernum;
            }
            set
            {
                _ordernum = value;
            }
        }
        public List<LineItems> ItemsList
        {
            get
            {
                return _itemslist;
            }
            set
            {
                _itemslist = value;
            }
        }
        public StoreFront StoreFront { get; set; }
        public Customers Customer { get; set; }

    }
}