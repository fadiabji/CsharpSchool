using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAssignment2.Classes
{
    internal class Course
    {
        [Key]
        [Required]
        public Guid CourseId { get; private set; } = Guid.NewGuid();
        public int Name { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public Course()
        {
        }
    }
}
