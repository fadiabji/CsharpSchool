using oopAssignment2.Classes;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

//Creating a new School 
School lexicon = new()
{
    Name = "lexicon",
};

lexicon.StudentsList.Add(new Student() { Firstname = "Ella", Lastname = "Pearson", DateOfBirth = DateTime.Parse("1981-01-09") });
lexicon.StudentsList.Add(new Student() { Firstname = "Fadi", Lastname = "Pearson", DateOfBirth = DateTime.Parse("1981-01-09") });
lexicon.StudentsList.Add(new Student() { Firstname = "Well", Lastname = "Smith", DateOfBirth = DateTime.Parse("1982-01-09") });
lexicon.StudentsList.Add(new Student() { Firstname = "Samir", Lastname = "Gake", DateOfBirth = DateTime.Parse("1986-01-09") });
lexicon.StudentsList.Add(new Student() { Firstname = "Eric", Lastname = "Some", DateOfBirth = DateTime.Parse("1988-01-09") });


lexicon.TeachersList.Add(new Teacher() { Firstname = "Robert", Lastname = "Pearson", DateOfBirth = DateTime.Parse("1981-01-09") });
lexicon.TeachersList.Add(new Teacher() { Firstname = "Sibistian", Lastname = "Larson", DateOfBirth = DateTime.Parse("1981-01-09") });
lexicon.TeachersList.Add(new Teacher() { Firstname = "Fridric", Lastname = "Smith", DateOfBirth = DateTime.Parse("1982-01-09") });
lexicon.TeachersList.Add(new Teacher() { Firstname = "Nalini", Lastname = "propse", DateOfBirth = DateTime.Parse("1986-01-09") });
lexicon.TeachersList.Add(new Teacher() { Firstname = "Johan", Lastname = "Ericson", DateOfBirth = DateTime.Parse("1988-01-09") });



// adding date of birth as string in this way "1983-08-22"
void addTeachers(School school)
{
    WriteLine($"\nWe are going to add a new teacher to {school.Name}.");
    Write("Teacher first name: ");
    string fname = ReadLine();
    Write("Teacher last name: ");
    string lastname = ReadLine();
    Write("Teacher date of birth as \"1983-08-22\": " );
    string dateOfBirth = ReadLine();
    Teacher teacherObj = new(fname, lastname, dateOfBirth);
    school.TeachersList.Add(teacherObj);
    Write("You have Successfully added a new teacher to  the school!");
}

// adding date of birth as string in this way "1983-08-22"
void addStudents(School school)
{
    WriteLine($"\nWe are going to add a new Student to {school.Name}.");
    Write("Student first name :");
    string fname = ReadLine();
    Write("Student last name :");
    string lastname = ReadLine();
    Write("Student date of birth as \"1983-08-22\": ");
    string dateOfBirth = ReadLine();
    Student StudentObj = new(fname, lastname, dateOfBirth);
    school.StudentsList.Add(StudentObj);
    Write("You have Successfully added a new student to the school!");
}

void addCourses(School school)
{
    WriteLine($"\nWe are going to add a new Course to {school.Name}.");
    Write("Course Name: ");
    string courseName = ReadLine();
    WriteLine($"Here is the Teachers list in the school {school.Name}:\n");
    foreach(Teacher t in school.TeachersList)
    {
        Write(t.Firstname + " " + t.Lastname + " - ");
    }
    Write("\n\nAssign a teacher to Course you have entred by selecting teachers first name: ");
    string teacherFName = ReadLine();
    Teacher teacherObj = school.TeachersList.First(t => t.Firstname == teacherFName);
    Course CourseObj = new(courseName, teacherObj);
    school.AddCourse(CourseObj);
    Write("You have Successfully added a new Course to the school!");
}

//displaying the lists in a specific School
void displayingTeachers(School school)
{
    if (school.TeachersList.Any())
    {
        foreach (Teacher t in school.TeachersList)
        {
            Write(t.ToString());
        }
    }
    else
    {
        WriteLine("No Teachers yet!");
    }
    
}

void displayingGrades(School school)
{
    if (school.GradesList.Any())
    {
        foreach (Grade g in school.GradesList)
        {
            Write(g.ToString());
        }
    }
    else
    {
        WriteLine("No Grades yet!");
    }
}

void displayingStudents(School school)
{

    if (school.StudentsList.Any())
    {
        foreach (Student s in school.StudentsList)
        {
            Write(s.ToString());
        }
    }
    else
    {
        WriteLine("No Grades yet!");
    }
}

void displayingCourses(School school)
{
    if (school.CoursesList.Any())
    {
        foreach (Course c in school.CoursesList)
        {
            Write(c.ToString());
        }
    }
    else
    {
        WriteLine("No Courses yet!");
    }
}


// remove a course from school
void removeCourse(School school)
{
    WriteLine($"\nWe are going to REMOVE a Course to {school.Name}.");
    WriteLine($"Here is the course list in the school {school.Name}:\n");
    foreach (Course c in school.CoursesList)
    {
        WriteLine(c.Name + " Id: " + c.CourseId.ToString());
    }
    Write("\n\nConfirm Reoving the Course by entering the Course Id: ");
    string courseId = ReadLine();
    Guid courseIdGuid = Guid.Parse(courseId);
    school.RemoveCourse(courseIdGuid);
    WriteLine("The Course has successfully removed from the School!");
}

// withdrawing a student from the school by display all students with their id numbers and withdraw them by using this id number

void teacherWithdrawFromSchool(School school)
{
    WriteLine($"\nWe are going to Withdraw a Teacher from {school.Name}.");
    WriteLine($"Here is the Teachers list in the school {school.Name}:\n");
    foreach (Teacher t in school.TeachersList)
    {
        WriteLine(t.Firstname + " " + t.Lastname + " Id: " + t.TeacherId.ToString());
    }
    Write("\n\nConfirm Withdrawing the Teacher by entering the Teacher Id: ");
    string teacherId = ReadLine();
    Guid teacherIdGuid = Guid.Parse(teacherId);
    school.RemoveCourse(teacherIdGuid);
    WriteLine("The Teacher has successfully Withdrawed from the School!");
}

void studentWithdrawFromSchool(School school)
{
    WriteLine($"\nWe are going to Withdraw a Student from {school.Name}.");
    WriteLine($"Here is the Students list in the school {school.Name}:\n");
    foreach (Student s in school.StudentsList)
    {
        WriteLine(s.Firstname + " " + s.Lastname + " Id: " + s.StudentId.ToString());
    }
    Write("\n\nConfirm Reoving the Course by entering the Studnt Id: ");
    string studetnId = ReadLine();
    Guid studetnIdGuid = Guid.Parse(studetnId);
    school.RemoveCourse(studetnIdGuid);
    WriteLine("The Studet has successfully Withdrawed from the School!");
}


void setGrade(School school)
{
    if (school.CoursesList.Any())
    {
        WriteLine($"\nWe are going to Set Grade for a Student in a certain Course at {school.Name}.");
        WriteLine($"Here is the course list in the school {school.Name}:\n");
        foreach (Course c in school.CoursesList)
        {
            WriteLine(c.Name + " || Id: " + c.CourseId.ToString());
        }
        Write("\n\nSelect and Enter Course Id from the brivous list: ");
        string courseId = ReadLine();
        Guid courseIdGuid = Guid.Parse(courseId);

        if (school.StudentsList.Any())
        {
            foreach (Student s in school.StudentsList)
            {
                WriteLine(s.Firstname + " " + s.Lastname + " || Id: " + s.StudentId.ToString());
            }
            Write("\n\nSelect and Enter Student Id from the brivous list: ");
            string studetnId = ReadLine();
            Guid studetnIdGuid = Guid.Parse(studetnId);


            Grade newGrade = new()
            {
                DateAcquired = DateTime.Now,
                Course = school.CoursesList.Find(c => c.CourseId == courseIdGuid),
                Student = school.StudentsList.Find(c => c.StudentId == studetnIdGuid),
                //how to display the grade enum in console, then how to let the user enter select one of them.
                GradeResult = Grade.GradeType.F,
            };
            WriteLine("Here is the Grade Scale at School, (A the best,F faild): A B C D E F");
            Write($"Assigne a grade for the course {newGrade.Course.Name}: ");
            string result = ReadLine();
            Grade.GradeType assigendGrade = (Grade.GradeType)Enum.Parse(typeof(Grade.GradeType), result);
            newGrade.GradeResult = assigendGrade;
            school.SetGrade(newGrade, courseIdGuid, studetnIdGuid);
            WriteLine("The Grade has been successfully set in the grades list at the School!");
        }
        else
        {
            WriteLine("No Students yet!");
        }
        

    }
    else
    {
        WriteLine("No Courses yet!");
    }
    
}


void showGrades(School school)
{
    if (school.StudentsList.Any())
    {
        WriteLine($"\nWe are going to see a student results at {school.Name}.\nHere is a list of Student:");
        foreach (Student s in school.StudentsList)
        {
            WriteLine(s.Firstname + " " + s.Lastname + " || Id: " + s.StudentId.ToString());
        }
        Write("\n\nSelect and Enter Student Id from the brivous list: ");
        string studetnId = ReadLine();
        Guid studetnIdGuid = Guid.Parse(studetnId);
        lexicon.GetGrades(studetnIdGuid);
    }
    else
    {
        WriteLine("No Students yet!");
    }
    
}


void removeGrade(School school)
{
    WriteLine($"\nWe are going to Delete a grade for a student in one course at {school.Name}.\nHere is a list of Student:");
    if (school.StudentsList.Any())
    {
        foreach (Student s in school.StudentsList)
        {
            WriteLine(s.Firstname + " " + s.Lastname + " || Id: " + s.StudentId.ToString());
        }
        Write("\n\nSelect and Enter Student Id from the brivous list: ");
        string studetnId = ReadLine();
        Guid studetnIdGuid = Guid.Parse(studetnId);
        if (school.CoursesList.Any())
        {
            WriteLine($"Here is the course list in the school {school.Name}:\n");
            foreach (Course c in school.CoursesList)
            {
                WriteLine(c.Name + " || Id: " + c.CourseId.ToString());
            }
            Write("\n\nSelect and Enter Course Id from the brivous list: ");
            string courseId = ReadLine();
            Guid courseIdGuid = Guid.Parse(courseId);
            lexicon.RemoveGrade(courseIdGuid, studetnIdGuid);
            WriteLine("The Grade has successfully Removed from grades list at the School!");
        }
        else
        {
            WriteLine("No Courses yet!");
        }
        
    }
    else
    {
        WriteLine("No Students yet!");
    }
}


bool keepAlive = true;
while (keepAlive)
{
    try
    {
        Console.Write("Enter Action number (or -1 to exit): \n");
        Console.Write("1. Display all teachers\r\n\r\n2. Display all students\r\n\r\n3. Display all courses\r\n\r\n4. Add a teacher\r\n\r\n5. Add a student\r\n\r\n6. Add a course\r\n\r\n7. Withdraw a student\r\n\r\n8. Withdraw a teacher\r\n\r\n9. Withdraw a course\r\n\r\n10. Show grades\r\n\r\n11. Remove grade\r\n\r\n12. Set grade\n\n");

        var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
        Console.ForegroundColor = ConsoleColor.Green;
        switch (assignmentChoice)
        {
            case 1:
                displayingTeachers(lexicon);
                break;
            case 2:
                displayingStudents(lexicon);
                break;
            case 3:
                displayingCourses(lexicon);
                break;
            case 4:
                addTeachers(lexicon);
                break;
            case 5:
                addStudents(lexicon);
                break;
            case 6:
                addCourses(lexicon);
                break;
            case 7:
                studentWithdrawFromSchool(lexicon);
                break;
            case 8:
                teacherWithdrawFromSchool(lexicon);
                break;
            case 9:
                removeCourse(lexicon);
                break;
            case 10:
                showGrades(lexicon);
                break;
            case 11:
                removeGrade(lexicon);
                break;
            case 12:
                setGrade(lexicon);
                break;
            case -1:
                keepAlive = false;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is not a valid assignment number!");
                break;
        }
        ResetColor();
        WriteLine("\nHit any key to continue..");
        ReadKey();
        Clear();
    }
    catch (Exception e)
    {
        ForegroundColor = ConsoleColor.Red;
        WriteLine("Error: " + e.Message);
        ResetColor();
        WriteLine("\nHit any key to continue..");
        ReadKey();
        Clear();
    }
}
