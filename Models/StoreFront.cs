using System;
using System.Collections.Generic;

namespace Models
{
    public class StoreFront
    {
        private string _name;
        private string _address;
        private string _city;
        private string _state;

        private List<string> _inventory;
        private List<Orders> _orders;
        private int _storenum;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }
        public int StoreNum { 
            get
            {
                return _storenum;
            } 
            set
            {
                _storenum = value;
            } 
            }

    }
}