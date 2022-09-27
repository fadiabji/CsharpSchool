using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAssignment2.Classes
{
    internal class Teacher : Person
    {
        [Key]
        public int TeacherId { get; set; }

        public Teacher() : base()
        {
        }

        public Teacher(string fname, string lname, DateTime dateOfBirth):base(fname, lname, dateOfBirth)
        {
            Firstname = fname;
            Lastname = lname;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return "First Name : " + Firstname + "|| Last Name : " + Lastname + "\nDate Of Birth : " + DateOfBirth + "|| Student Id: " + TeacherId.ToString();
        }

        public int GetAge()
        {
            DateTime tody = DateTime.Today;
            var age = tody.Subtract(DateOfBirth);
            return age.Days / 365;
        }
    }
}
