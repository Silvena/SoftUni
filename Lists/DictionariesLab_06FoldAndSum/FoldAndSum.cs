using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesLab_06FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int k = n.Length / 4;
            int[] leftRow = n.Take(k).Reverse().ToArray();
            int[] rightRow = n.Reverse().Take(k).ToArray();
            int[] row1 = leftRow.Concat(rightRow).ToArray();
            int[] row2 = n.Skip(k).Take(2 * k).ToArray();
            var sum = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
