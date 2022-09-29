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
        [Required]
        public Guid TeacherId { get; private set; } = Guid.NewGuid();
       
        public Teacher() : base()
        {
        }

        public Teacher(string fname, string lname, string dateOfBirth):base(fname, lname, dateOfBirth)
        {
            //Firstname = fname;
            //Lastname = lname;
            //// adding time as string in this way "2/16/1987"
            //DateOfBirth = DateTime.Parse(dateOfBirth);
        }

        public override string ToString()
        {
            return "\nTeacher Info:\nTeacher Name: " + Firstname + " " + Lastname + "\nDate Of Birth: " + DateOfBirth + "id: "+ TeacherId.ToString()+"\n";
        }

        public int GetAge()
        {
            DateTime tody = DateTime.Today;
            var age = tody.Subtract(DateOfBirth);
            return age.Days / 365;
        }
    }
}
