using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Course
    {
        public Course(string name, string instructor)
        {
            Name = name;
            Instructor = instructor;
        }

        public string Name { get; set; }
        public string Instructor { get; set; }

        public override string ToString ()
        {
            return $"Course Namw: {Name}, Instructor: {Instructor}";

        }
    }
}
