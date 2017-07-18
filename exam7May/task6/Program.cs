using System;

namespace task6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialNum = int.Parse(Console.ReadLine());
            int contrNum = int.Parse(Console.ReadLine());



            for (int i = n; i >= 1; i--)
            {
                for (int j = m; j >= 1; j--)
                {
                    for (int k = l; k >= 1; k--)
                    {
                        int oddI = i;
                        int oddJ = j;
                        int oddK = k;

                        int sum = oddI * 100 + oddJ * 10 + oddK * 1;

                        if (sum % 3 == 0)
                        {
                            specialNum += 5;
                        }
                        else if (sum % 10 == 5)
                        {
                            specialNum -= 2;
                        }
                        else if (sum % 2 == 0)
                        {
                            specialNum *= 2;
                        }
                        if (specialNum >= contrNum) { break; }

                    }
                    if (specialNum >= contrNum) { break; }
                }
                if (specialNum >= contrNum) { break; }
            }
            

            if (specialNum >= contrNum)
                {
                    Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNum}.");
                }
                else
                {
                    Console.WriteLine($"No! {specialNum} is the last reached special number.");
                }


          
        }
    }

}
