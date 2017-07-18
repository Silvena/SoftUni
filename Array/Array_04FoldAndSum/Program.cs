using System;

using System.Linq;


namespace Array_04FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int middleStartInd = (sequence.Length / 2) / 2;
            int middleEndInd = middleStartInd + sequence.Length / 2;
            int summingIndex = middleStartInd - 1;
            for (int i = middleStartInd; i < middleEndInd ;i ++)
            {
                int sum = sequence[i] + sequence[summingIndex];
                Console.Write($"{sum} ");
                summingIndex--;
                if (summingIndex <0)
                {
                    summingIndex = sequence.Length - 1;
                }

            }
        }
    }
}
