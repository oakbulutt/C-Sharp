using System;
using System.Collections.Generic;
using System.Text;

namespace BP11Exercise1
{
    class Person
    {
        private string firstName;
        private string lastName;
        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public void Introduce()
        {
            Console.WriteLine("{0} {1}", firstName, lastName);
        }
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
    }
}
