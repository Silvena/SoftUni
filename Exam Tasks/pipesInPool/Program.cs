using System;


namespace pipesInPool
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double v = double.Parse(Console.ReadLine());
            double P1 = double.Parse(Console.ReadLine());
            double P2 = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double pipe1 = P1 * H;
            double pipe2 = P2 * H;
            double sumOfPipe = pipe1 + pipe2;

            if(sumOfPipe <= v)
            {

                double poolFull = sumOfPipe / (v/100);
                double pipe1Persent = pipe1 / (sumOfPipe / 100);
                double pipe2Persent = pipe2 / (sumOfPipe / 100);
                
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1:f0}%. Pipe 2: {2:f0}%.", (int)poolFull , (int)pipe1Persent , (int)pipe2Persent);
            }
            else
            {
                double over = sumOfPipe - v;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",H,over );
            }
        }
    }
}
