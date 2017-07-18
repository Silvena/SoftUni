using System;


namespace rectangleNxNStars
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < n; i++)

            {
                Console.WriteLine(new string('*' , n));
            }

        }
    }
}
