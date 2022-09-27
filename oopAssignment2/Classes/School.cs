using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static oopAssignment2.Classes.Grade;

namespace oopAssignment2.Classes
{
    internal class School
    {
        public string Name { get; set; }
        public List<Student> StudentsList { get; set; }
        public List<Course> CoursesList { get; set; }
        public List<Teacher> TeachersList { get; set; }
        public List<Grade> GradesList { get; set; }


        public School()
        {

        }

        public Boolean HasCourse(int courseId)
        {
            // How can I reach the Course Object if I have courseId? I suppose to use Lambda experssion
            //return CoursesList.Exists(CoursesList.Where(x => x.CourseId == courseId));
            return CoursesList.Any(c => c.CourseId == courseId);   
        }

        public void AddCourse(Course course)
        {

        }

        public void RemoveCourse(int CourseId)
        {

        }

        public Boolean IsSchoolEnrolled(int StudentId)
        {
            return false;
        }

        public Boolean IsCourseEnrolled(int CourseId, int StudentId)
        {
            return false;
        }

        public void EnrollCourse(int CourseId , int StudentId)
        {
        }

        public void EnrolSchool(Student student)
        {
            StudentsList.Add(student);
        }

        public void WithdrawFromSchool(int StudentId)
        {

        }

        public void WithdrawFromCourse(int CourseId,int StudentId)
        {

        }

        public void SetGrade(Grade grading, int CourseId, int StudentId)
        {
            var grade = GradesList.First(c => c.GradeId == grading.GradeId);// Check if it is exisit in the GradeList
        }

        public void RemoveGrade(int CourseId, int StudentId)
        {

        }

        public void GetGrades(int StudentId)
        {

        }
    }
}
