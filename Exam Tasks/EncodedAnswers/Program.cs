using System;


namespace EncodedAnswers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            string result = null;
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;



            for (int i = 0; i < N; i++)
            {
                var numAnswers = uint.Parse(Console.ReadLine());
                string answer;
                if (numAnswers % 4 == 0)
                {
                    answer = "a";
                    A++;
                }
                else if (numAnswers % 4 == 1)
                {
                    answer = "b";
                    B++;
                }
                else if (numAnswers % 4 == 2)
                {
                    answer = "c";
                    C++;
                }
                else
                {
                    answer = "d";
                    D++;
                }
                result += answer + " ";
            }
            Console.WriteLine(result);
            Console.WriteLine("Answer A: {0}\nAnswer B: {1}\nAnswer C: {2}\nAnswer D: {3}", A, B, C, D);
        }
    }
}
