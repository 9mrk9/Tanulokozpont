using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando { 
internal class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        List<Course> courses = new List<Course>();
        List<Instructor> instructors = new List<Instructor>();

        while (true)
        {
            Console.WriteLine("\n1. Hozz létre egy új tanulót");
            Console.WriteLine("2. Hozz létre egy új kurzust");
            Console.WriteLine("3. Hozz létre egy új tanárt");
            Console.WriteLine("4. Tanulók listája");
            Console.WriteLine("5. Kurzusok listája");
            Console.WriteLine("6. Tanárok listája");
            Console.WriteLine("7. Kilépés");

            Console.Write("Válasszon egy opciót (1-7ig): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateStudent(students);
                    break;
                case "2":
                    CreateCourse(courses);
                    break;
                case "3":
                    CreateInstructor(instructors);
                    break;
                case "4":
                    DisplayStudents(students);
                    break;
                case "5":
                    DisplayCourses(courses);
                    break;
                case "6":
                    DisplayInstructors(instructors);
                    break;
                case "7":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Nem létező opció. Kérlek próbáld újra (1-7ig).");
                    break;
            }
        }
    }
    static void CreateStudent(List<Student> students)
    {
        Console.Write("Add meg a tanuló nevét: ");
        string name = Console.ReadLine();

        Console.Write("Add meg a születési évet: (éééé-hh-nn): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());

        Student student = new Student { Name = name, BirthDate = birthDate };
        students.Add(student);

        Console.WriteLine($"{name} sikeresen létrehozva!");
    }
    static void CreateCourse(List<Course> courses)
    {
        Console.Write("Adja meg a kurzus nevét: ");
        string name = Console.ReadLine();

        Console.Write("Adja meg a kurzus rövid leirását: ");
        string description = Console.ReadLine();

        Course course = new Course { Name = name, Description = description };
        courses.Add(course);

        Console.WriteLine($"{name} kurzus sikeresen létrehozva!");
    }
    static void CreateInstructor(List<Instructor> instructors)
    {
        Console.Write("Adja meg a tanár nevét: ");
        string name = Console.ReadLine();

        Instructor instructor = new Instructor { Name = name };
        instructors.Add(instructor);

        Console.WriteLine($"{name} tanár sikeresen létrehozva!");
    }
    static void DisplayStudents(List<Student> students)
    {
        Console.WriteLine("\nA tanulók listája:");
        foreach (Student student in students)
        {
            Console.WriteLine($"- {student.Name} (Születési idő: {student.BirthDate.ToString("yyyy-MM-dd")}, Átlagos jegy: {student.GetAverageGrade()})");
        }
    }
    static void DisplayCourses(List<Course> courses)
    {
        Console.WriteLine("\nA kurzusok listája:");
        foreach (Course course in courses)
        {
            Console.WriteLine($"- {course.Name} ({course.Description})");
        }
    }
    static void DisplayInstructors(List<Instructor> instructors)
    {
        Console.WriteLine("\nA tanárok listája:");
        foreach (Instructor instructor in instructors)
        {
            Console.WriteLine($"- {instructor.Name}");
        }
    }
}
}