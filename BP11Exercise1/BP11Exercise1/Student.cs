using System;
using System.Collections.Generic;
using System.Text;

namespace BP11Exercise1
{
    class Student : Person
    {
        private int indexNumber;
        public Student()
        {

        }
        public Student(string firstName, String lastName, int indexNumber) : base(firstName, lastName)
        {
            this.indexNumber = indexNumber;
        }

        public int IndexNumber
        {
            get { return indexNumber; }
            set { indexNumber = value; }
        }

        public void EnrollToCourse()
        {
            Console.WriteLine("{0} {1} ({2}) - enrolling to course.", FirstName, LastName, indexNumber);
        }
    }
}
