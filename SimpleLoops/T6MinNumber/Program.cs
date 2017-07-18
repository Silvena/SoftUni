using System;


namespace T5MaxNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (var i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine( min);
        }
    }
}