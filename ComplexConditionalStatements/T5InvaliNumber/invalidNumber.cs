using System;


namespace T5InvaliNumber
{
   public class invalidNumber
    {
       public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if ((number >= 100 && number <= 200 )|| number == 0)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("invalid");
            }
           
          
        }
    }
}
