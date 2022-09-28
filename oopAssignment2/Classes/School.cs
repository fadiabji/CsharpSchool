using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static oopAssignment2.Classes.Grade;
using static System.Console;

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
            StudentsList = new();
            CoursesList = new();
            TeachersList = new();
            GradesList = new();
        }
        // Check wherther the course had incuded in this school
        public Boolean HasCourse(Guid courseId)
        {
            return CoursesList.Any(c => c.CourseId == courseId);   
        }

        // Enroll the course to the Courses list in this School
        public void AddCourse(Course course)
        {
            if (CoursesList.Contains(course))
            {
                WriteLine("The course has already exisit in courses list!");
            }
            else 
            { 
                CoursesList.Add(course); 
            }
            
        }
        //Remove all instance of courses from the course List 
        public void RemoveCourse(Guid courseId)
        {
            while (HasCourse(courseId))
            {
                CoursesList.Remove(CoursesList.Find(c => c.CourseId == courseId));
            }
        }
        // Look at the specific Student whether he/she alredy enrolled in the school
        public Boolean IsSchoolEnrolled(Guid studentId)
        {
            return StudentsList.Any(c => c.StudentId == studentId); 
        }

        // Look at the specifice course has a specifice student 
        public Boolean IsCourseEnrolled(Guid courseId, Guid studentId) 
        {
            Course tragetCourse = CoursesList.First(c => c.CourseId == courseId);
            return tragetCourse.Students.Any(c => c.StudentId == studentId);
        }

        // Make enroll this student to this course
        public void EnrollCourse(Guid courseId , Guid studentId)
        {
            Course tragetCourse = CoursesList.First(c => c.CourseId == courseId);
            tragetCourse.Students.Add(StudentsList.First(c => c.StudentId == studentId));
        }

        // Enroll this student to this school
        public void EnrolSchool(Student student)
        {
            if (StudentsList.Contains(student))
            {
                WriteLine("The Student has alredy enrolled in the School");
            }
            else
            {
                StudentsList.Add(student);
            }
        }
        // Withdraw this student from this school
        public void WithdrawFromSchool(Guid studentId)
        {
            while (IsSchoolEnrolled(studentId))
            {
                StudentsList.Remove(StudentsList.FirstOrDefault(c => c.StudentId == studentId));
            }
        }

        // Withdraw this student from this course
        public void WithdrawFromCourse(Guid courseId, Guid studentId)
        {
            Course tragetCourse = CoursesList.First(c => c.CourseId == courseId);
            while(IsCourseEnrolled( courseId, studentId))
            {
                tragetCourse.Students.Remove(StudentsList.First(c => c.StudentId == studentId));
            }
        }


        public void SetGrade(Grade grading, Guid courseId, Guid studentId)
        {
                Grade targetStudentGrade = GradesList.First(g => g.GradeId == grading.GradeId);
                if (targetStudentGrade != null)
                {
                    targetStudentGrade.GradeResult = grading.GradeResult;
                }
                else
                {
                Grade newGrade = new()
                {
                    Student = StudentsList.Find(s => s.StudentId == studentId),
                    Course = CoursesList.Find(c => c.CourseId == courseId),
                    GradeResult = grading.GradeResult
                };
            }
        }

        public void RemoveGrade(Guid courseId, Guid studentId)
        {
            Grade targetStudentGrade = GradesList.First(g => g.Course.CourseId == courseId && g.Student.StudentId == studentId);
            GradesList.Remove(targetStudentGrade);
        }

        public String GetGrades(Guid studentId)
        {
            Grade targetStudentGrade = GradesList.First(g => g.Student.StudentId == studentId);
            return targetStudentGrade.ToString();
        }
    }
}
