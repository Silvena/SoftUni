using System;
namespace TruckDriver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            double kM = double.Parse(Console.ReadLine());
            double salary = 0;
            double totalSalary = 0;

            if (month.Equals("spring") || month.Equals("autumn"))
            {
                if (kM <= 5000)
                {
                    salary = kM * 0.75;
                }
            else   if (kM <= 10000)
                {
                    salary = kM * 0.95;
                }
           else  
                {
                    salary = kM * 1.45;
                }
            }
          else  if (month.Equals("summer"))
            {
                if (kM <= 5000)
                {
                    salary = kM * 0.90;
                }
                else if ( kM <= 10000)
                {
                    salary = kM * 1.10;
                }
                else
                {
                    salary = kM * 1.45;
                }
            }
          else  if (month.Equals("winter"))
            {
                if (kM <= 5000)
                {
                    salary = kM * 1.05;
                }
                else if (kM <= 10000)
                {
                    salary = kM * 1.25;
                }
                
                else 
                {
                    salary = kM * 1.45;
                }
            }

            totalSalary = salary * 4;  // 4 - working season 
            
            Console.WriteLine("{0:f2}",totalSalary -(0.1*totalSalary)); // 10% tax
        }
    }
}

