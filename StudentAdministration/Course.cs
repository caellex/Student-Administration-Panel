using System.Security.Cryptography.X509Certificates;

namespace StudentAdministration;

public class Course
{
    private int _courseId;
    private string _courseName;
    private double _coursePoints;
    private static List<Course> courseList = new List<Course>();

    public Course(int courseId, string courseName, double coursePoints)
    {
        _courseId = courseId;
        _courseName = courseName;
        _coursePoints = coursePoints;
    }

    public Course()
    {
        
    }

    public void ShowCourse()
    {
        LoadCourses();

        var courseName = "Course Name:";    
        var courseId = "Course Id:";    
        var coursePoints = "Course Points:";

        var padder = " ";

        var courseStr = Convert.ToString(_courseId);
        var pointsStr = Convert.ToString(_coursePoints);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(courseName.PadRight(30) + courseId.PadRight(30) + coursePoints + "\n");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (Course course in courseList)
        {
            Console.WriteLine(course._courseName.PadRight(30) + course._courseId.ToString().PadRight(30) + course._coursePoints);
        }
        
    }

    public static void LoadCourses()
    {
        if(courseList.Count == 0) {
        courseList.Add(new Course(1, "English", 3));
        courseList.Add(new Course(2, "Arts and Crafts", 1));
        courseList.Add(new Course(3, "Introduction to Programming", 1.5));
        courseList.Add(new Course(4, "Cybersecurity", 2));
        courseList.Add(new Course(5, "Math", 1.5));
        courseList.Add(new Course(6, "Physics", 2.5));
        }
    }

    public static String GetCourseById(int courseId)
    {
        string courseName = "";
        foreach (Course course in courseList)
        {
            if (course._courseId == courseId)
            {
                courseName = course._courseName;
            }
        }

        return courseName;
    }
    
}

