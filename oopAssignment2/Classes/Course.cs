using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oopAssignment2.Classes
{
    internal class Course
    {
        [Key]
        [Required]
        public Guid CourseId { get; private set; } = Guid.NewGuid();
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public Course()
        {
            Name = "DefultCourseName";
            Students = new();
            Teacher teacher = new Teacher();
        }

        public Course(string courseName, Teacher teacher)
        {
            Name = courseName;
            Students = new();
            Teacher = teacher;
        }

        public override string ToString()
        {
            return "\nCourse Info:\nCoures title: " + Name + " || Responsple Teacher: " + Teacher.Firstname + " " + Teacher.Lastname + "id: " + CourseId.ToString() + "\n";
        }
    }
}
