using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAssignment2.Classes
{
    internal class Student
    {
        [primerKey]
        public int StudentId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Student(string fname, string lname, DateTime dateOfBirth)
        {

        }

        public override string ToString()
        {
            return "First Name : " + Firstname + "|| Last Name : " + Lastname + "\nDate Of Birth : " + DateOfBirth + "|| Student Id: " + StudentId.ToString();
        }

        public void GetAge()
        {
            
        }


    }
}
