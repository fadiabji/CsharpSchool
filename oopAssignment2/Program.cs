using oopAssignment2.Classes;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

//Creating a new School 
School Lexicon = new()
{
    Name = "Lexicon",
};

// adding date of birth as string in this way "1983-08-22"
Teacher addTeachers(School school)
{
    Write("Teacher first name: ");
    string fname = ReadLine();
    Write("Teacher last name: ");
    string lastname = ReadLine();
    Write("Teacher date of birth as \"1983-08-22\": " );
    string dateOfBirth = ReadLine();
    Teacher teacherObj = new(fname, lastname, dateOfBirth);
    school.TeachersList.Add(teacherObj);
    return teacherObj;
}

// adding date of birth as string in this way "1983-08-22"
Student addStudents(School school)
{
    Write("Student first name :");
    string fname = ReadLine();
    Write("Student last name :");
    string lastname = ReadLine();
    Write("Student date of birth as \"1983-08-22\": ");
    string dateOfBirth = ReadLine();
    Student StudentObj = new(fname, lastname, dateOfBirth);
    school.StudentsList.Add(StudentObj);
    return StudentObj;
}

Course addCourses(School school)
{
    Write("Course Name: ");
    string courseName = ReadLine();
    WriteLine($"Here is the Teachers list in the school {school.Name}:");
    foreach(Teacher t in school.TeachersList)
    {
        Write(t.Firstname + " " + t.Lastname + " - ");
    }
    Write("\nSelect a teacher by entering first name: ");
    string teacherFName = ReadLine();
    Teacher teacherObj = school.TeachersList.First(t => t.Firstname == teacherFName);
    Course CourseObj = new(courseName, teacherObj);
    school.AddCourse(CourseObj);
    return CourseObj;
}

//displaying the lists in a specific School
void displayingTeachers(School school)
{
    Console.ForegroundColor = ConsoleColor.Green;
    foreach (Teacher t in school.TeachersList)
    {
        Write(t.ToString());
    }
}

void displayingGrades(School school)
{
    Console.ForegroundColor = ConsoleColor.Green;
    foreach (Grade g in school.GradesList)
    {
        Write(g.ToString());
    }
}

void displayingStudents(School school)
{
    Console.ForegroundColor = ConsoleColor.Green;
    foreach (Student s in school.StudentsList)
    {
        Write(s.ToString());
    }
}

void displayingCourses(School school)
{
    Console.ForegroundColor = ConsoleColor.Green;
    foreach (Course c in school.CoursesList)
    {
        Write(c.ToString());
    }
}

Teacher t1 = addTeachers(Lexicon);
Student s1 = addStudents(Lexicon);
Course c1 = addCourses(Lexicon);
displayingTeachers(Lexicon);
displayingStudents(Lexicon);
displayingCourses(Lexicon);



