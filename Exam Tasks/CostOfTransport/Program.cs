using System;

namespace CostOfTransport
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string timeZone = Console.ReadLine().ToLower();
            var taxiD =  0.79;
            var taxiN =  0.90;
            var train = 0.06;
            var bus = 0.09;
            if( n < 20)
            {
                if (timeZone.Equals("day"))
                {
                    Console.WriteLine("Taxi {0}", 0.7 + n * taxiD );
                }
               
        
            else
                {
                    Console.WriteLine("Taxi {0}", 0.7 + n * taxiN);
                }
            }
      else  if (n < 100)
            {
                
                Console.WriteLine("Bus {0}",n * bus);
            }
            else  
            {
                
                Console.WriteLine("Train {0}",n * train);
            }
        }
    }
}
