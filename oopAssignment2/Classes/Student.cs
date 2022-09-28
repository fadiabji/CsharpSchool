using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.ComponentModel.DataAnnotations;

namespace oopAssignment2.Classes
{
    internal class Student : Person
    {
        [Key]
        [Required]
        public Guid StudentId { get; private set; } = Guid.NewGuid();


        public Student() :base()
        {
        }

        public Student(string fname, string lname, DateTime dateOfBirth) : base(fname, lname, dateOfBirth)
        {
            Firstname = fname;
            Lastname = lname;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return "First Name : " + Firstname + "|| Last Name : " + Lastname + "\nDate Of Birth : " + DateOfBirth + "|| Student Id: " + StudentId.ToString();
        }

        public int GetAge()
        {
            DateTime tody = DateTime.Today;
            var age = tody.Subtract(DateOfBirth);
            return age.Days / 365;
        }

    }
}
