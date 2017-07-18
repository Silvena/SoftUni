using System;


namespace NumberInRange
{
  public  class Program
    {
     public   static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            int num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number!");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0} ",num);
        }
    }
}
