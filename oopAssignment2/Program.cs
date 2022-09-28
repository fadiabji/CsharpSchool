using oopAssignment2.Classes;
using System.Security.Cryptography.X509Certificates;
using static System.Console;


School lexicon = new()
{
    Name = "Lexicon",
};

Teacher teacherObj1 = new() 
{
    Firstname = "Robert",
    Lastname = "Larson",
    DateOfBirth = DateTime.Parse("2/16/1981")
};

Teacher teacherObj2 = new()
{
    Firstname = "Fadi",
    Lastname = "Larson",
    DateOfBirth = DateTime.Parse("2/16/1987")
};

lexicon.TeachersList.Add(teacherObj1);
lexicon.TeachersList.Add(teacherObj2);


void displayingTeachers()
{
    foreach (Teacher t in lexicon.TeachersList)
    {
        Write(t.ToString());
    }
}
displayingTeachers();