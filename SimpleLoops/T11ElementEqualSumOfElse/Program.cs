using System;


namespace T11OddOrEven
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
           float evenSum = 0;
            float oddSum = 0;
           
           
              var  evenMax = float.MinValue;
            var evenMin = float.MaxValue;
            var oddMin = float.MaxValue;
            var oddMax = float.MinValue;
            

            for (int i = 1; i <= n; i++)
            {
                var input = float.Parse(Console.ReadLine());
                
               if(i % 2 != 0)
                { 
                    oddSum += input;

                    if ( input < oddMin)
                    {
                        oddMin = input;
                    }
                    if (input > oddMax)
                    {
                        oddMax = input;
                    }
                }
                else if (i % 2 == 0)
                {

                    evenSum += input;
                    if (input < evenMin)
                    {
                        evenMin = input;
                    }
                    if (input > evenMax)
                    {
                        evenMax = input;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum},");
            if (oddMin == float.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin},");
            }
            if (oddMax == float.MinValue)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax},");
                
            }
             Console.WriteLine($"EvenSum={evenSum},");
            if (evenMin == float.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin},");
            }
            if (evenMax == float.MinValue)
            {
                Console.WriteLine("EvenMax=No,");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax},");
                
            }
        }
    }
}
