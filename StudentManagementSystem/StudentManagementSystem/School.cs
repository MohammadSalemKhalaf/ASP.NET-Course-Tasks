using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class School
    {
        public School()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
        }

        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }

        public void AddStudent(Student student)
        {
            if(Students.Contains(student))
            {
                Console.WriteLine($"Student {student.name} already exists.");
                return;
            }
            else
            {
                Console.WriteLine($"Adding student {student.name}.");
            }
            Students.Add(student);
        }
        public void AddCourse(Course course)
        {
            if (Courses.Contains(course))
            {
                Console.WriteLine($"Course {course.Name} already exists.");
                return;
            }
            else
            {
                Console.WriteLine($"Adding course {course.Name}.");
            }
            Courses.Add(course);
        }

        public bool EnrollStudentToCourse(Student student,Course courseName)
        {
            if (!(Courses.Contains(courseName) && Students.Contains(student)))
            {
                Console.WriteLine($"one of student or course isn't exist ");
                return false;
            }
            else
            {
                student.EnrollCourse(courseName);
                return true;
            }
        }

        public override string ToString()
        {
            return $"All students: {string.Join("," , Students)}\nAll courses: {string.Join(",", Courses)}";
        }
    }
}
