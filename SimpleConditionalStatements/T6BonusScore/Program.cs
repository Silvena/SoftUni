using System;


namespace T6BonusScore
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter score:");
         double num = double.Parse(Console.ReadLine());
          double bonus = 0.0;
            if(num <= 100)
            {
                bonus = 5;
            }
            else if ((num > 100) && (num <= 1000))
            {
                bonus = 0.2 * num;
            }
            else if (num > 1000)
            {
                bonus = 0.1 * num;
            }
            if(num % 2 == 0)
            {
                bonus += 1;
            }
            else if (num % 10 == 5)
            {
                bonus += 2;
            }
                Console.WriteLine("Bonus score: {0}", bonus);
                Console.WriteLine("Total score: {0}", num + bonus);
            
        }
    }
}
