using System;
using System.Collections.Generic;

namespace Models
{
    public class Orders
    {
        private List<Orders> _orders;
        private string _location;
        private double _totalprice;
        private int _ordernum;

        public string Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }
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

    }
}