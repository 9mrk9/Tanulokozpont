using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando
{
    class Student
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public List<int> Grades { get; set; } = new List<int>();

        public void AddGrade(int grade)
        {
            Grades.Add(grade);
        }
        public double GetAverageGrade()
        {
            if (Grades.Count == 0)
                return 0;

            double sum = 0;
            foreach (int grade in Grades)
            {
                sum += grade;
            }
            return sum / Grades.Count;
        }
    }
}
