using System;


namespace PointOnSegment
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            int left = Math.Min(first , second);
            int right = Math.Max(first, second);
            int leftDistance = Math.Abs(point - left);
            int rightDistance = Math.Abs(point - right);
            int distance = Math.Min(leftDistance, rightDistance);
              if (point >= left && point <= right)
                {
                    Console.WriteLine("in");
                    Console.WriteLine(distance);
                }
                else
                {
                    Console.WriteLine("out");
                    Console.WriteLine(distance);
                }
            
        }
    }
}
