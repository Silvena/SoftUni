using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


namespace Ex_08MetorGroop
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameAndDates = ReadNameAndDates();
            var comments = ReadComments(nameAndDates.Keys.ToList());
            var allStudents = GetStudents(nameAndDates, comments);
            PrintStudents(allStudents);
        }

        private static void PrintStudents(List<Student> allStudents)
        {
            foreach (var student in allStudents.OrderBy(st => st.Name))
            {
                var studentName = student.Name;
                var dates = student.DatesAttend.OrderBy(dt => dt).ToList();
                var studentComments = student.Comments;
                Console.WriteLine($"{studentName}");
                var commetCount = studentComments.Count;
                if (commetCount > 0)
                {
                    Console.WriteLine("Comments:");
                    foreach (var comment in studentComments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }
                else
                {
                    Console.WriteLine("Comments:");
                }
                Console.WriteLine("Dates attended:");
                if (dates.Count > 0)
                {
                    foreach (var date in dates)
                    {
                        var day = date.Day;
                        var month = date.Month;
                        var year = date.Year;
                        Console.WriteLine($"-- {day:d2}/{month:d2}/{year:d2}");
                    }
                }
            }
        }

        private static List<Student> GetStudents(Dictionary<string, List<DateTime>> nameAndDates,Dictionary<string, List<string>> comments)
        {
            var studentList = new List<Student>();
            foreach (var student in nameAndDates)
            {
                var name = student.Key;
                var dates = student.Value;
                var studentComments = new List<string>();
                if (comments.ContainsKey(name))
                {
                    studentComments = comments[name];
                }
                var currentStudent = new Student
                {
                    Name = name,
                     DatesAttend = dates,
                     Comments = studentComments
                };
                studentList.Add(currentStudent);
            }
            return studentList;
        }

        private static Dictionary<string, List<string>> ReadComments(List<string> names)
        {
            var line = Console.ReadLine();
            var nameAndComments = new Dictionary<string, List<string>>();
            while (line != "end of comments")
            {
                var tokens = line.Split('-');
                var name = tokens[0];
                var comment = tokens[1];
                if (!names.Contains(name))
                {
                    line = Console.ReadLine();
                    continue;
                }
                if (!nameAndComments.ContainsKey(name))
                {
                    nameAndComments[name] = new List<string>();

                }
                nameAndComments[name].Add(comment);
                line = Console.ReadLine();
            }
            return nameAndComments;
        }
        private static Dictionary<string, List<DateTime>> ReadNameAndDates()
        {
            var line = Console.ReadLine();
            var nameAndDates = new Dictionary<string, List<DateTime>>();
            while (line != "end of dates")
            {
                var tokens = line.Split(new[] { ' ', ',' });
                var name = tokens[0];
                if (tokens.Length == 1)
                {
                    nameAndDates[name] = new List<DateTime>();
                    line = Console.ReadLine();
                    continue;
                }
                var dates = tokens.Skip(1).Select(a => DateTime.ParseExact(a, "dd/MM/yyyy",CultureInfo.InstalledUICulture)).ToList();
                if (!nameAndDates.ContainsKey(name))
                {
                    nameAndDates[name] = new List<DateTime>();
                }
                nameAndDates[name].AddRange(dates);
                line = Console.ReadLine();
            }
            return nameAndDates;
        }
        
    }
    class Student
    {
        public string Name { get; set; }
        public List<DateTime> DatesAttend { get; set; }
        public List<string> Comments { get; set; }
    }
}
