using System;


namespace T5MaxNumber
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            var max = -10000000000000;
            for (var i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if(num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("max = "+ max);
        }
    }
}
