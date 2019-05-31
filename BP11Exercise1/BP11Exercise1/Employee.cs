using System;
using System.Collections.Generic;
using System.Text;

namespace BP11Exercise1
{
    class Employee : Person
    {
        private String position;
        public Employee()
        {

        }
        public Employee(string firstName, string lastName, string position) : base(firstName,lastName)
        {
            this.position = position;
        }

        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void SignList()
        {
            Console.WriteLine("{0} {1} ({2}) - signing a list",FirstName, LastName, position);
        }
        public String Position
        {
            get { return position; }
            set { position = value; }
        }


    }
}
