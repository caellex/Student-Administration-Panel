using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentAdministration
{
    internal class Grades
    {
        private int _studentId;
        private int _courseId;
        private int _grade;
        private static List<Grades> gradesList = new List<Grades>();

        public Grades()
        {
            
        }
        public Grades(int studentId, int courseId, int grade)
        {
            _studentId = studentId;
            _courseId = courseId;
            _grade = grade;
        }
        public void ShowGrades()
        {
            LoadGrades();
            Console.Clear();
            
            var studentT = "Student:";
            var courseT = "Course:";
            var gradeT = "Grade:";  

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{studentT.PadRight(30)}{courseT.PadRight(30)}{gradeT.PadRight(30)}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (Grades grade in gradesList)
            {
                Console.WriteLine(Student.GetStudentById(grade._studentId).PadRight(30) + Course.GetCourseById(grade._courseId).PadRight(30) + grade._grade);
            }
            
        }

        public void ShowCourses()
        {
            LoadGrades();
            Console.Clear();


        }

        public static void LoadGrades()
        {
            if(gradesList.Count == 0){
            gradesList.Add(new Grades(1, 1, 6));
            gradesList.Add(new Grades(1, 3, 2));
            gradesList.Add(new Grades(1, 2, 4));
            gradesList.Add(new Grades(1, 4, 2));
            gradesList.Add(new Grades(1, 4, 6));
            gradesList.Add(new Grades(1, 6, 5));
            gradesList.Add(new Grades(2, 1, 3));
            gradesList.Add(new Grades(2, 5, 4));
            gradesList.Add(new Grades(2, 2, 6));
            gradesList.Add(new Grades(3, 1, 4));
            gradesList.Add(new Grades(3, 2, 4));
            gradesList.Add(new Grades(3, 6, 3));

            }
        }
    }




}
