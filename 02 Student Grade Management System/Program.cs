namespace _02_Student_Grade_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a gradebook
            GradeBook GradeBook = new GradeBook("Computer Science 101");


            // Create students
            Student Student1 = new Student("S001", "Alice Johnson", "alice@school.com");
            Student Student2 = new Student("S002", "Bob Smith", "bob@school.com");
            Student Student3 = new Student("S003", "Charlie Brown", "charlie@school.com");


            // Add grades for students
            Student1.AddGrade("Math", 95.0m);
            Student1.AddGrade("English", 88.0m);
            Student1.AddGrade("Science", 92.0m);

            Student2.AddGrade("Math", 78.0m);
            Student2.AddGrade("English", 85.0m);
            Student2.AddGrade("Science", 80.0m);

            Student3.AddGrade("Math", 90.0m);
            Student3.AddGrade("English", 92.0m);
            Student3.AddGrade("Science", 89.0m);

            // Add students to gradebook
            GradeBook.AddStudent(Student1);
            GradeBook.AddStudent(Student2);
            GradeBook.AddStudent(Student3);


            // Display all students
            Console.WriteLine("======================== Class Students ========================\n");
            GradeBook.DisplayAllStudents();

            // Get class average
            Console.WriteLine("======================== Class Average ========================\n");
            Console.WriteLine($"Class Avreage: {GradeBook.GetClassAverage():F2}\n");

            // Get top students
            Console.WriteLine("======================== Class Top Students ========================\n");
            List<Student> TopStudents = GradeBook.GetTopStudents(2);
            Console.WriteLine("Top 2 Stdents Are:\n");
            foreach(var s in TopStudents)
            {
                Console.WriteLine(s.GetStudentInfo());
            }

            // Get student info

        }
    }
}
