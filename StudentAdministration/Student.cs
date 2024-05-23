using System.Security.Cryptography.X509Certificates;

namespace StudentAdministration;

public class Student
{
    private string _name;
    private int _age;
    private string _courses;
    private int _studentId;
    private static List<Student> students = new List<Student>();

    public Student()
    {
        
    }
    public Student(string name, int age, string courses, int studentId)
    {
        _name = name;
        _age = age;
        _courses = courses;
        _studentId = studentId;
    }

    public void ShowStudent()
    {
        LoadStudents();
        var nameT = "Student Name:";
        var ageT = "Age:";
        var enrolledT = "Classes:";
        var studentIdT = "Student Id:";

        Console.Clear();
        
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"{nameT.PadRight(30)}{ageT.PadRight(30)}{enrolledT.PadRight(30)}{studentIdT}\n");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (Student student in students)
        {
            Console.WriteLine(student._name.PadRight(30) + student._age.ToString().PadRight(30) + student._courses.PadRight(30) + $"{student._studentId}");
        }

    }

    public static void LoadStudents()
    {
        if(students.Count == 0) {
            students.Add(new Student("Carl", 23, "IT Start", 1));
            students.Add(new Student("Kjell", 22, "Helse og Oppvekst", 2));
            students.Add(new Student("Birger", 23, "Bygg og Anlegg", 3));
        }

        
    }

    public static String GetStudentById(int studentId)
    {
        string name = "";
        foreach (Student student in students)
        {
            if (student._studentId == studentId)
            {
                name = student._name;
            }
        }

        return name;
    }
}