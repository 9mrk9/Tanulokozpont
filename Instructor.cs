using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando
{
    class Instructor
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public void ListCourses()
        {
            Console.WriteLine($"{Name} kurzusai:");
            foreach (Course course in Courses)
            {
                Console.WriteLine($"- {course.Name}");
            }
        }
    }
}