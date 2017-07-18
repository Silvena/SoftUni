using System;


namespace T11Equal_Words
{
   public class Program
    {
       public static void Main(string[] args)
        {
           var word1= Console.ReadLine().ToLower();
            var word2 = Console.ReadLine().ToLower();

            if (word1 == word2)
            {
                Console.WriteLine("yes");
            }
             else 
            {
                Console.WriteLine("no");
            }   
        }
    }
}
