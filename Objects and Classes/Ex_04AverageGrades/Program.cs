using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStud = int.Parse(Console.ReadLine());
            Student[] students = new Student[numStud];
            for (int i = 0; i < numStud; i++)
            {
                students[i] = ReadStudent(Console.ReadLine());
            }
            foreach (Student student in students.Where(x => x.AverageGrade >= 5)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}"); 
            }
        }

        private static Student ReadStudent(string input)
        {
            string[] tokens = input.Split(' ');
            List<double> grades = new List<double>();
            foreach (var token in tokens.Skip(1))
            {
                grades.Add(double.Parse(token));
            }
            return new Student { Name = tokens[0], Grades = grades };
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get { return Grades.Sum() / Grades.Count;}}
    }
}
