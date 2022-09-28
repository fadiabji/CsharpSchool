using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAssignment2.Classes
{
    internal class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person()
        {
        }

        public Person(string fname, string lname, string dateOfBirth) 
        {
            Firstname = fname;
            Lastname = lname;
            // adding time as string in this way "1983-08-22"
            DateOfBirth = DateTime.Parse(dateOfBirth) ;
        }
    }
}
