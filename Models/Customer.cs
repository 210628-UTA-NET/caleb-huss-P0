using System;

namespace Models
{
    public class Customers
    {
        private string _name;
        private string _address;
        private string _city;
        private string _state;
        private string _email;
        private string _phonenumber;
        private List<Orders> _orders = new List<Orders>;
        public Customers() { }

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
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }

        }
        public string PhoneNumber
        {
            get
            {
                return _phonenumber;
            }
            set
            {
                _phonenumber = value;
            }
        }


    }


}