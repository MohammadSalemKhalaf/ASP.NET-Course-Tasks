using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Student
    {
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
            courses = new List<Course>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public List<Course> courses { get; set; }
        public bool EnrollCourse(Course courseName)
        {
            if(courses.Contains(courseName))
            {
                Console.WriteLine($"Already enrolled in {courseName.Name}");
                return false;
            }
            else
            {
                courses.Add(courseName);
                return true;
            }
        }
        public override string ToString () {
            return $"Student ID: {id}, Name: {name}, Courses: {string.Join(", ", courses)}";
        }
    }
}
