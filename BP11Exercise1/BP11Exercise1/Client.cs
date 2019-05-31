using System;
using System.Collections.Generic;
using System.Text;

namespace BP11Exercise1
{
    class Client : Person
    {
        private string shippingAddress;
        public Client()
        {

        }
        public Client(string firstName, string lastName, string shippingAddress) : base(firstName, lastName)
        {
            this.shippingAddress = shippingAddress;
        }
        public void OrderGoods()
        {
            Console.WriteLine("{0} {1} ({2}) - ordering goods.", FirstName, LastName, shippingAddress);
        }
        public string ShippingAddress
        {
            get { return shippingAddress; }
            set { shippingAddress = value; }
        }
    }
}
