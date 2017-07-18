using System;


namespace DateAfter5Days
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = 2016;
            DateTime firstDate = new DateTime(y,m,d);
            DateTime dt = firstDate.AddDays(Math.Abs(5));
            Console.WriteLine(dt.ToString("d.mm"));
        }
    }
}
