using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando
{
    class Course
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void ListStudents()
        {
            Console.WriteLine($"Tanulók a {Name} kurzuson:");
            foreach (Student student in Students)
            {
                Console.WriteLine($"- {student.Name}");
            }
        }
    }
}
