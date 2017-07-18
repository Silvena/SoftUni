using System;
namespace rectangleOf10x10Stars
{
  public  class Program
    {
       public static void Main(string[] args)
        {
              for (int i = 1; i <= 10; i++)
               {
                   Console.WriteLine(new string('*',10));
               }
               



            /*      Same output with  do while

                int i = 1;
            do
            {
                Console.WriteLine(new string('*',10));
                i++;
            } while (i <= 10);


            */
        }
    }
}
