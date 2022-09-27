using oopAssignment2.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAssignment2.Classes
{
    internal class Grade
    {
        public int GradeId { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
        public DateTime DateAcquired { get; set; }
        public GradeType GradeResult { get; set; }

        public enum GradeType { A, B, C, D, E, F }

        public override string ToString()
        {
            switch (GradeResult)
            {
                case GradeType.A:
                    return $"Congratulations, you get A in  {Course.Name}.";
                case GradeType.B:
                    return $"Congratulations, you get B in  {Course.Name}";
                case GradeType.C:
                    return $"Very Good, you get V in  {Course.Name}";
                case GradeType.D:
                    return $"Good, you get D in  {Course.Name}";
                case GradeType.E:
                    return $"Good, you get E in  {Course.Name}";
                case GradeType.F:
                    return $"Unfortunatly, you get F in  {Course.Name} you are not passing the exam.";
                default:
                    return "Wrong grade adding!";
            }
        }
    }
}
