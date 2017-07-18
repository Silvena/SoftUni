using System;


namespace Bricks
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int brick = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = workers * capacity;
            Console.WriteLine(Math.Ceiling(brick / courses));
        }
    }
}
