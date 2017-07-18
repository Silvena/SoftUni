using System;


namespace GenerateRectangles
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int left = -n; left <= n; left++)
            {
                for (int top = -n; top <= n; top++)
                {
                    for (int right = left+1; right <= n; right++)
                    {
                        for (int bottom = top + 1; bottom <= n; bottom++)
                        {
                            int currentArea = Math.Abs(left - right)* Math.Abs(bottom - top);
                            if (currentArea >= m && left < right && top < bottom)
                            {
                                Console.WriteLine($"({left}, {top}) ({right}, { bottom}) -> {currentArea}");
                                isFound = true;
                            }
                            if (left >= right || top >= bottom)
                            {
                                return;
                            }
                        }
                    }
                }
            }
            if (isFound == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
