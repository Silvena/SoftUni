using System;

namespace TrainerSalary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numLectures = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double salary = budget / numLectures;
            double jelevSalary = 0;
            double royalSalary = 0;
            double roliSalary = 0;
            double trifonSalary = 0;
            double sinoSalary = 0;
            double otherSalary = 0;
            for (int i = 1; i <= numLectures; i++)
            {
                string nameLecture = Console.ReadLine().ToLower();

                if (nameLecture == "jelev") { jelevSalary += salary; }
                 else if(nameLecture == "royal"){ royalSalary += salary; }
                 else if(nameLecture == "roli") { roliSalary += salary; }
                 else if (nameLecture == "trofon") { trifonSalary += salary; }
                 else if(nameLecture == "sino") { sinoSalary += salary; }
                else { otherSalary += salary; }
            }
            Console.WriteLine("Jelev salary: {0:f2} lv", jelevSalary);
            Console.WriteLine("RoYaL salary: {0:f2} lv", royalSalary);
            Console.WriteLine("Roli salary: {0:f2} lv", roliSalary);
            Console.WriteLine("Trofon salary: {0:f2} lv", trifonSalary);
            Console.WriteLine("Sino salary: {0:f2} lv", sinoSalary);
            Console.WriteLine("Others salary: {0:f2} lv", otherSalary);

        }
    }
}
