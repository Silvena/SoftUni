using System;


namespace T7LeftRightSum
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;


            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                leftSum += input;
              
            }
            for (int a = 0; a < n; a++)
            {
                int input = int.Parse(Console.ReadLine());
                rightSum += input;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}",leftSum);
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, diff = {0} " , diff);
            }
        }
    }
}

/*
 * ******   DIFFERENT WAY WITH ONE LOOP  ****
 * 
 * using System;


namespace T7LeftRightSum
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;


            for (int i = 0; i < (2*n); i++)
            {
                int input = int.Parse(Console.ReadLine());
                 if(i < n)
                 {            
                    leftSum += input;
                 }
                 else
                 {
                       rightSum += input;
                 }
            }
           
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}",leftSum);
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, diff = {0} " , diff);
            }
        }
    }
}

    */
