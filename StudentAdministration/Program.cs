namespace StudentAdministration
{
    internal class Program
    {
        static void Main()
        {
            LoadAll();

            


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to the Student Administration panel!\n");
            Console.WriteLine("Menu:\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1) Students ");
            Console.WriteLine("2) Courses ");
            Console.WriteLine("3) Grades ");
            Console.WriteLine("4) Exit ");

            var student = new Student();
            var course = new Course();
            var grade = new Grades();

            char menuChoice = Console.ReadKey(true).KeyChar;
            switch (menuChoice)
            {
                case '1':
                    Console.Clear();
                    student.ShowStudent();
                    break;
                case '2':
                    Console.Clear();
                    course.ShowCourse();
                    break;
                case '3':

                    grade.ShowGrades();
                    break;
                case '4':
                    Environment.Exit(69);
                    break;
               default:
                    Main();
                   break;
            }

            Console.ReadKey();
            Main();

        }

        static void LoadAll()
        {
            Student.LoadStudents();
            Course.LoadCourses();
            Grades.LoadGrades();
        }
    }
}
