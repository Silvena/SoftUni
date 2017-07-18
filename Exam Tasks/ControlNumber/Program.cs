using System;


namespace ControlNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int contrNum = int.Parse(Console.ReadLine());
            int steps = 0;
            int result = 0;
            bool checkControlNum = false;
            for (int i = 1; i <= N; i++)
            {
                for (int j = M; j >= 1; j--)
                {
                    steps++;
                    result = result + (i * 2 + j * 3);
                    if (result >= contrNum)
                    {
                        checkControlNum = true;
                        break;
                    }
                }
                if (checkControlNum) break;
            }
            Console.WriteLine("{0} moves", steps);
            if (checkControlNum)
            {
                Console.WriteLine("Score: {0} >= {1}", result, contrNum);
            }
        }
    }
}
