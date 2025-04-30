namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course c1= new Course("Math", "Dr. Smith");
            Course c2 = new Course("Science", "Dr. Jones");
            Course c3 = new Course("History", "Dr. Brown");
            Student s1 = new Student(1, "Alice");
            Student s2 = new Student(2, "Bob");
            Student s4 = new Student(3, "mohammad bashar");
            Course c4 = new Course("Arabic", "dr.hamodi");
            s1.EnrollCourse(c1);
            s1.EnrollCourse(c2);
            s2.EnrollCourse(c2);
            s2.EnrollCourse(c3);
            School school = new School();
            school.AddStudent(s4);
            school.AddCourse(c4);
            school.EnrollStudentToCourse(s4, c4);
            Console.WriteLine(school);
        }
    }
}
